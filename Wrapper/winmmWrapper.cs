using System;
using System.Runtime.InteropServices;
using ControlYourPC.Wrapper.Interfaces;

namespace ControlYourPC.Wrapper
{
  public class winmmWrapper : IwinmmWrapper
  {
    [DllImport("winmm.dll", EntryPoint = "waveOutGetVolume")]
    public static extern void GetWaveVolume(IntPtr devicehandle, out int volume);

    public int GetVolume()
    {
      int volume;
      GetWaveVolume((IntPtr)null, out volume);

      return volume;
    }
  }
}