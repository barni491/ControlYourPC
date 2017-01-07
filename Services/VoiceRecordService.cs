using System;
using System.Diagnostics;
using ControlYourPC.Services.Interfaces;
using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace ControlYourPC.Services
{
    class VoiceRecordService : IVoiceRecordService
    {
        private readonly WaveInEvent _waveInEvent;
        private readonly WaveFileWriter _waveFileWriter;

        public VoiceRecordService()
        {
            _waveInEvent = new WaveInEvent
            {
                WaveFormat = new WaveFormat(16000, 2)
            };

            _waveInEvent.DataAvailable += WaveSourceDataAvailable;

            _waveFileWriter = new WaveFileWriter("przycisz_SOX.wav", _waveInEvent.WaveFormat);
        }

        public void RecordCommand()
        {

            /*   MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
               MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
               defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = 0.10f;
               string currVolume = "MasterPeakVolume : " + defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar.ToString();*/
            Console.WriteLine("Rozpoczynam nagrywania");
            _waveInEvent.StartRecording();

            System.Threading.Thread.Sleep(5000);

            _waveInEvent.StopRecording();
            Console.WriteLine("Koniec nagrywania");

            _waveFileWriter.Close();

            SoxConvertToFlac();
        }

        private static void SoxConvertToFlac()
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "C:\\Program Files (x86)\\sox-14-4-2\\sox.exe",
                Arguments = "przycisz_SOX.wav -c 1 przycisz_SOX.flac",
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                CreateNoWindow = false,
                WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory
            };

            using (Process soxProc = Process.Start(startInfo))
            {
                soxProc.WaitForExit();
            }
        }

        private void WaveSourceDataAvailable(object sender, WaveInEventArgs e)
        {
            if (_waveFileWriter != null)
            {
                _waveFileWriter.Write(e.Buffer, 0, e.BytesRecorded);
                _waveFileWriter.Flush();
            }
        }
    }
}