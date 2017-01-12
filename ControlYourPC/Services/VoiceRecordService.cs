using System;
using System.Diagnostics;
using ControlYourPC.Services.Interfaces;
using NAudio.Wave;
using System.IO;

namespace ControlYourPC.Services
{
    class VoiceRecordService : IVoiceRecordService
    {
        private readonly WaveInEvent _waveInEvent;
        private WaveFileWriter _waveFileWriter;

        public VoiceRecordService()
        {
            _waveInEvent = new WaveInEvent
            {
                WaveFormat = new WaveFormat(16000, 2)
            };

            _waveInEvent.DataAvailable += WaveSourceDataAvailable;
        }

        public void RecordCommand()
        {
            _waveFileWriter = new WaveFileWriter("Nagranie.wav", _waveInEvent.WaveFormat);

            _waveInEvent.StartRecording();

            System.Threading.Thread.Sleep(5000);

            _waveInEvent.StopRecording();

            _waveFileWriter.Close();

            SoxConvertToFlac();
        }

        private static void PlayStartSound()
        {
            var mainOutputStream = new Mp3FileReader("Ping.mp3");
            var volumeStream = new WaveChannel32(mainOutputStream);
            var player = new WaveOutEvent();

            player.Init(volumeStream);

            player.Play();
        }

        private static void SoxConvertToFlac()
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "C:\\Program Files (x86)\\sox-14-4-2\\sox.exe",
                Arguments = "Nagranie.wav -c 1 Nagranie.flac",
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