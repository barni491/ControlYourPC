using System;
using System.IO;
using ControlYourPC.Services.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.CloudSpeechAPI.v1beta1;
using Google.Apis.CloudSpeechAPI.v1beta1.Data;
using Google.Apis.Services;
using System.Collections.Generic;

namespace ControlYourPC.Services
{
  class SpeechRecognationService : ISpeechRecognationService
  {
    private const string AudioFilePath = "przycisz_SOX.flac";

    public string RecognizeCommand()
    {
      CloudSpeechAPIService cloudSpeechApiService = CreateAuthorizedClient();
      Console.WriteLine("Signed in Google Speech Api");

      string command = null;

      SyncRecognizeRequest syncRecognizeRequest = CreateSyncRecognizeRequest();

      SyncRecognizeResponse response = cloudSpeechApiService.Speech.Syncrecognize(syncRecognizeRequest).Execute();

      foreach (SpeechRecognitionResult result in response.Results)
      {
        foreach (SpeechRecognitionAlternative alternative in result.Alternatives)
        {
          command = alternative.Transcript;
        }
      }

      return command;
    }

    private static CloudSpeechAPIService CreateAuthorizedClient()
    {
      GoogleCredential credential = GoogleCredential.GetApplicationDefaultAsync().Result;
      if (credential.IsCreateScopedRequired)
      {
        credential = credential.CreateScoped(CloudSpeechAPIService.Scope.CloudPlatform);
      }

      return new CloudSpeechAPIService(new BaseClientService.Initializer()
      {
        HttpClientInitializer = credential,
        ApplicationName = "DotNet Google Cloud Platform Speech Sample",
      });
    }

    private static SyncRecognizeRequest CreateSyncRecognizeRequest()
    {
      return new SyncRecognizeRequest
      {
        Config = new RecognitionConfig
        {
          Encoding = "FLAC",
          SampleRate = 16000,
          LanguageCode = "pl-PL",
          SpeechContext = new SpeechContext
          {
            Phrases = new List<string> {"przycisz"}
          }
        },
        Audio = new RecognitionAudio
        {
          Content = Convert.ToBase64String(File.ReadAllBytes(AudioFilePath))
        }
      };
    }
  }
}