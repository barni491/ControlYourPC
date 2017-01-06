using sterowanie_glosem.Services.Interfaces;
using sterowanie_glosem.Wrapper.Interfaces;

namespace sterowanie_glosem.Services
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
      _commonWrapper.TurnOnCapsLock();
    }
  }
}