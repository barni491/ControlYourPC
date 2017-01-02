using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sterowanie_glosem.Services.Interfaces;
using NAudio;
using NAudio.Wave;
using System.Diagnostics;

namespace sterowanie_glosem.Services
{
    class VoiceRecordService : IVoiceRecordService
    {
        private static WaveFileWriter waveFile;

        public void RecordCommand()
        {

            var waveSource = new WaveInEvent();
            waveSource.WaveFormat = new WaveFormat(16000, 2);
            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(WaveSourceDataAvailable);
            waveSource.StartRecording();

            waveFile = new WaveFileWriter("przycisz_SOX.wav", waveSource.WaveFormat);
            System.Threading.Thread.Sleep(5000);
            waveSource.StopRecording();
            waveFile.Close();
            SoxConvertToFlac();
            
        }


        private void SoxConvertToFlac()
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


        static void WaveSourceDataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }

        }
    }
}
