using System.Runtime.InteropServices;
using System.Windows.Forms;
using sterowanie_glosem.Wrapper.Interfaces;

namespace sterowanie_glosem.Wrapper
{
  public class user32DllWrapper : Iuser32dllCommonWrapper, Iuser32dllScreenFuncionWrapper, Iuser32dllVolumeFunctionWrapper
  {
    [DllImport("user32.dll")]
    static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

    public void VolumeUp()
    {
      ExecuteWithParam(Keys.VolumeUp);
    }

    public void VolumeDown()
    {
     ExecuteWithParam(Keys.VolumeDown);
    }

    public void Mute()
    {
      ExecuteWithParam(Keys.VolumeMute);
    }

    public void TurnOnCapsLock()
    {
      ExecuteWithParam(Keys.CapsLock);
    }

    public void DoPrintScreen()
    {
      ExecuteWithParam(Keys.PrintScreen);
    }

    private static void ExecuteWithParam(Keys key)
    {
      keybd_event((byte)key, 0, 0, 0);
    }
  }
}