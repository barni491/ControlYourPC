using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using System.IO;
using Antlr4.Runtime.Tree;
using Google.Apis.CloudSpeechAPI.v1beta1;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System.Diagnostics;
using NAudio.Wave;

namespace sterowanie_glosem
{
    class Program
    {

        static WaveFileWriter waveFile = null;

        static public CloudSpeechAPIService CreateAuthorizedClient()
        {
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


        public static void SoxMethod()
        {
            var startInfo = new ProcessStartInfo();
            startInfo.FileName = "C:\\Program Files (x86)\\sox-14-4-2\\sox.exe";
            startInfo.Arguments = "przycisz_SOX.wav -c 1 przycisz_SOX.flac";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = false;
            startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            using (Process soxProc = Process.Start(startInfo))
            {
                soxProc.WaitForExit();
            }
        }


        public static void RecordCommand()
        {
            var waveSource = new WaveInEvent();
            waveSource.WaveFormat = new WaveFormat(16000, 2);
            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            waveSource.StartRecording();

            waveFile = new WaveFileWriter("przycisz_SOX.wav", waveSource.WaveFormat);
            System.Threading.Thread.Sleep(5000);
            waveSource.StopRecording();
            waveFile.Close();

        }

        static void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }

        }


        static public void Main(string[] args)
        {

            var app = new App();
            app.Start();

            app.Main();

            /*   RecordCommand();

                Console.WriteLine("Application Base Directory: " + AppDomain.CurrentDomain);
                String text = null ;
                if (args.Count() < 1)
                {
                    Console.WriteLine("Usage:\nTranscribe audio_file");
                    //  return;
                }
                var service = CreateAuthorizedClient();
                Console.WriteLine("Signed in Google Speech Api");
                string audio_file_path = "przycisz_SOX.flac";

                SoxMethod();
                Console.In.Read();

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
                        Content = Convert.ToBase64String(File.ReadAllBytes(audio_file_path))
                    }
                };
                var response = service.Speech.Syncrecognize(request).Execute();
                foreach (var result in response.Results)
                {
                    foreach (var alternative in result.Alternatives)
                         text = alternative.Transcript;
                }



   //             String text = "przycisz o 50%";
               if (text != null) {

                       StreamReader inputStream = new StreamReader(Console.OpenStandardInput());
                       //   AntlrInputStream input = new AntlrInputStream("zrób głośniej o 50 procent" );
                       //  AntlrInputStream input = new AntlrInputStream("podgłośnij o 50 procent");
                       //  AntlrInputStream input = new AntlrInputStream("głośniej o 50 procent");
                       // AntlrInputStream input = new AntlrInputStream("głośniej");
                       //AntlrInputStream input = new AntlrInputStream("ustaw głośność na 50 procent");
                       //  AntlrInputStream input = new AntlrInputStream("przycisz o 50 procent");
                       AntlrInputStream input = new AntlrInputStream(text);
                       Combined1Lexer lexer = new Combined1Lexer(input);
                       CommonTokenStream tokens = new CommonTokenStream(lexer);
                       Combined1Parser parser = new Combined1Parser(tokens);
                       IParseTree tree = parser.prog();
                       Console.WriteLine(tree.ToStringTree(parser));
                       Visitor visitor = new Visitor();
                       Console.WriteLine(visitor.Visit(tree));

                       Console.In.Read();

               }
               Console.In.Read();
           }*/
        }
    }
}
