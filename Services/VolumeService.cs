using sterowanie_glosem.Services.Interfaces;
using sterowanie_glosem.Wrapper.Interfaces;

namespace sterowanie_glosem.Services
{
  public class VolumeService : IVolumeService
  {
    private readonly Iuser32dllVolumeFunctionWrapper _volumeFunctionWrapper;
    private readonly IwinmmWrapper _winmmWrapper;

    public VolumeService(Iuser32dllVolumeFunctionWrapper volumeFunctionWrapper, IwinmmWrapper winmmWrapper)
    {
      _volumeFunctionWrapper = volumeFunctionWrapper;
      _winmmWrapper = winmmWrapper;
    }

    public void VolumeUp(int value)
    {
      int repetitionCount = value / 2;
      for (int i = 0; i < repetitionCount; i++)
      {
        _volumeFunctionWrapper.VolumeUp();
      }
    }

    public void VolumeDown(int value)
    {
      int repetitionCount = value / 2;
      for (int i = 0; i < repetitionCount; i++)
      {
        _volumeFunctionWrapper.VolumeDown();
      }
    }

    public void Mute()
    {
      _volumeFunctionWrapper.Mute();
    }

    public int GetVolume()
    {
      return _winmmWrapper.GetVolume();
    }
  }
}