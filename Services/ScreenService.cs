using sterowanie_glosem.Services.Interfaces;
using sterowanie_glosem.Wrapper.Interfaces;

namespace sterowanie_glosem.Services
{
  public class ScreenService : IScreenService
  {
    private readonly Iuser32dllScreenFuncionWrapper _screenFuncionWrapper;

    public ScreenService(Iuser32dllScreenFuncionWrapper screenFuncionWrapper)
    {
      _screenFuncionWrapper = screenFuncionWrapper;
    }

    public void DoPrintScreen()
    {
      _screenFuncionWrapper.DoPrintScreen();
    }
  }
}