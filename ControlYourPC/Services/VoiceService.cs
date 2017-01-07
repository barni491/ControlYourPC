using ControlYourPC.Services.Interfaces;
using ControlYourPC.Wrapper.Interfaces;

namespace ControlYourPC.Services
{
  public class VoiceService : IVoiceService
  {
    private readonly Iuser32dllVolumeFunctionWrapper _volumeFunctionWrapper;
    private readonly IwinmmWrapper _winmmWrapper;

    public VoiceService(Iuser32dllVolumeFunctionWrapper volumeFunctionWrapper, IwinmmWrapper winmmWrapper)
    {
      _volumeFunctionWrapper = volumeFunctionWrapper;
      _winmmWrapper = winmmWrapper;
    }

    public void VolumeUp(int value)
    {
      int repetitionCount = value / 2;
      for (int i = 0; i < repetitionCount; i++)
      {
        _volumeFunctionWrapper.PressVolumeUpKey();
      }
    }

    public void VolumeDown(int value)
    {
      int repetitionCount = value / 2;
      for (int i = 0; i < repetitionCount; i++)
      {
        _volumeFunctionWrapper.PressVolumeDownKey();
      }
    }

    public void Mute()
    {
      _volumeFunctionWrapper.PressMuteKey();
    }

    public void Unmute()
    {
      _volumeFunctionWrapper.PressMuteKey();
    }

    public int GetVolume()
    {
      return _winmmWrapper.GetVolume();
    }
  }
}