using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ControlYourPC.Services;
using ControlYourPC.Services.Interfaces;

namespace ControlYourPC.WindsorInstallers
{
  public class ServicesInstaller : IWindsorInstaller
  {
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
      container.Register(
        Component.For<IVoiceService>()
          .ImplementedBy<VoiceService>()
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
        Component.For<IExternalProcessManager>()
          .ImplementedBy<ExternalProcessManager>()
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
        Component.For<ICombined1Visitor<string>>()
          .ImplementedBy<Combined1BaseVisitor<string>>()
          .LifestyleSingleton());

      container.Register(
        Component.For<IVisitor>()
          .ImplementedBy<Visitor>()
          .LifestyleSingleton());

      container.Register(
        Component.For<IGrammarService>()
          .ImplementedBy<GrammarService>()
          .LifestyleSingleton());

      container.Register(
        Component.For<IMainService>()
          .ImplementedBy<MainService>()
          .LifestyleSingleton());

      container.Register(
        Component.For<IXmlReader>()
          .ImplementedBy<XmlReader>()
          .LifestyleSingleton());
    }
  }
}