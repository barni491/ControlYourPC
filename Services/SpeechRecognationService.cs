using Google.Apis.Auth.OAuth2;
using Google.Apis.CloudSpeechAPI.v1beta1;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using sterowanie_glosem.Services.Interfaces;

namespace sterowanie_glosem.Services
{
    class SpeechRecognationService:ISpeechRecognationService
    {
        const String AUDIO_FILE_PATH = "przycisz_SOX.flac";

        private CloudSpeechAPIService CreateAuthorizedClient(){
            GoogleCredential credential =
                GoogleCredential.GetApplicationDefaultAsync().Result;
            if (credential.IsCreateScopedRequired)
            {
                credential = credential.CreateScoped(new[]
                {
                    CloudSpeechAPIService.Scope.CloudPlatform
                });
            }
            return new CloudSpeechAPIService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "DotNet Google Cloud Platform Speech Sample",
            });
        }

        public String RecognizeCommand() {
            var service = CreateAuthorizedClient();
            Console.WriteLine("Signed in Google Speech Api");
            
            String command = null;

            var request = new Google.Apis.CloudSpeechAPI.v1beta1.Data.SyncRecognizeRequest()
            {
                Config = new Google.Apis.CloudSpeechAPI.v1beta1.Data.RecognitionConfig()
                {

                    Encoding = "FLAC",
                    SampleRate = 16000,
                    LanguageCode = "pl-PL"
                },
                Audio = new Google.Apis.CloudSpeechAPI.v1beta1.Data.RecognitionAudio()
                {
                    
                    Content = Convert.ToBase64String(File.ReadAllBytes(AUDIO_FILE_PATH))
                }
            };
            var response = service.Speech.Syncrecognize(request).Execute();
            foreach (var result in response.Results)
            {
                foreach (var alternative in result.Alternatives)
                     command = alternative.Transcript;
            }
            return command;
        }

    }
}
