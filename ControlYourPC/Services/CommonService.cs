using ControlYourPC.Services.Interfaces;
using ControlYourPC.Wrapper.Interfaces;

namespace ControlYourPC.Services
{
  public class CommonService : ICommonService
  {
    private readonly Iuser32dllCommonWrapper _commonWrapper;

    public CommonService(Iuser32dllCommonWrapper commonWrapper)
    {
      _commonWrapper = commonWrapper;
    }

    public void TurnOnCapsLock()
    {
      _commonWrapper.PressCapsLockKey();
    }

    public void TurnOffCapsLock()
    {
      _commonWrapper.PressCapsLockKey();
    }
  }
}