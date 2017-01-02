using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using sterowanie_glosem.Services;
using sterowanie_glosem.Services.Interfaces;

namespace sterowanie_glosem.WindsorInstallers
{
  public class ServicesInstaller : IWindsorInstaller
  {
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
      container.Register(
        Component.For<IVolumeService>()
          .ImplementedBy<VolumeService>()
          .LifestyleSingleton());

      container.Register(
        Component.For<IScreenService>()
          .ImplementedBy<ScreenService>()
          .LifestyleSingleton());

      container.Register(
        Component.For<ICommonService>()
          .ImplementedBy<CommonService>()
          .LifestyleSingleton());

      container.Register(
        Component.For<IVoiceRecordService>()
          .ImplementedBy<VoiceRecordService>()
          .LifestyleSingleton());

       container.Register(
         Component.For<ISpeechRecognationService>()
           .ImplementedBy<SpeechRecognationService>()
           .LifestyleSingleton());

       container.Register(
         Component.For<Visitor>()
         .ImplementedBy<Visitor>()
         .LifestyleSingleton());

       container.Register(
          Component.For<IGrammarService>()
          .ImplementedBy<GrammarService>()
          .LifestyleSingleton());
        
        }
    }
}