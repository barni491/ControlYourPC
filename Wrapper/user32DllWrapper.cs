using System.Runtime.InteropServices;
using System.Windows.Forms;
using sterowanie_glosem.Wrapper.Interfaces;

namespace sterowanie_glosem.Wrapper
{
  public class user32DllWrapper : Iuser32dllCommonWrapper, Iuser32dllVolumeFunctionWrapper, Iuser32dllScreenFuncionWrapper
  {
    [DllImport("user32.dll")]
    static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

    public void PressVolumeUpKey()
    {
      ExecuteWithParam(Keys.VolumeUp);
    }

    public void PressVolumeDownKey()
    {
     ExecuteWithParam(Keys.VolumeDown);
    }

    public void PressMuteKey()
    {
      ExecuteWithParam(Keys.VolumeMute);
    }

    public void PressCapsLockKey()
    {
      ExecuteWithParam(Keys.CapsLock);
    }

    private static void ExecuteWithParam(Keys key)
    {
      keybd_event((byte)key, 0, 0, 0);
    }
  }
}