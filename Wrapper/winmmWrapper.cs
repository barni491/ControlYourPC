using System;
using System.Runtime.InteropServices;

namespace sterowanie_glosem.Wrapper
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