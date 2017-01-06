using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using sterowanie_glosem.Wrapper;
using sterowanie_glosem.Wrapper.Interfaces;

namespace sterowanie_glosem.WindsorInstallers
{
  public class WrappersInstaller : IWindsorInstaller
  {
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
      container.Register(
       Component.For<Iuser32dllCommonWrapper, Iuser32dllVolumeFunctionWrapper, Iuser32dllScreenFuncionWrapper>()
         .ImplementedBy<user32DllWrapper>()
         .LifestyleSingleton());

      container.Register(
        Component.For<IwinmmWrapper>()
          .ImplementedBy<winmmWrapper>()
          .LifestyleSingleton());
    }
  }
}