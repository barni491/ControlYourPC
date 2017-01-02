using System;
using Castle.Windsor;
using Castle.Windsor.Installer;
using sterowanie_glosem.Services.Interfaces;

namespace sterowanie_glosem
{
  public class App
  {
    private IVolumeService _volumeService;
    private IScreenService _screenService;
    private ICommonService _commonService;
    private IVoiceRecordService _voiceRecordService;
    private ISpeechRecognationService _speechRecognationService;
        private IVisitor _visitor;
        private IGrammarService _grammarService;
    public void Start()
    {
        var container = new WindsorContainer();
        container.Install(FromAssembly.This());

//        _volumeService = container.Resolve<IVolumeService>();
  //      _screenService = container.Resolve<IScreenService>();
    //    _commonService = container.Resolve<ICommonService>();
        _voiceRecordService = container.Resolve<IVoiceRecordService>();
        _speechRecognationService = container.Resolve<ISpeechRecognationService>();
        _grammarService = container.Resolve<IGrammarService>();
    }

    public void Main()
    {

            _voiceRecordService.RecordCommand();
            String text = _speechRecognationService.RecognizeCommand();    
            _grammarService.analizeGrammar(text);
            Console.In.Read();
            // _commonService.TurnOnCapsLock();
            //_volumeService.VolumeDown(20);
        }
  }
}