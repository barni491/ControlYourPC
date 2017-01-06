using System;
using sterowanie_glosem.Services.Interfaces;

namespace sterowanie_glosem.Services
{
  public class MainService : IMainService
  {
    private readonly ISpeechRecognationService _speechRecognationService;
    private readonly IVoiceRecordService _voiceRecordService;
    private readonly IGrammarService _grammarService;
    private readonly IExternalProcessManager _externalProcessManager;
    private readonly IScreenService _screenService;

    public MainService(
      ISpeechRecognationService speechRecognationService,
      IVoiceRecordService voiceRecordService,
      IGrammarService grammarService,
      IExternalProcessManager externalProcessManager, 
      IScreenService screenService)
    {
      _speechRecognationService = speechRecognationService;
      _voiceRecordService = voiceRecordService;
      _grammarService = grammarService;
      _externalProcessManager = externalProcessManager;
      _screenService = screenService;
    }

    public void Process()
    {
      //_voiceRecordService.RecordCommand();

      //string text = _speechRecognationService.RecognizeCommand();
      //string text = "ciszej o 11";
      //_grammarService.AnalizeGrammar(text);

      //_externalProcessManager.Run("wordadsa");

      _screenService.DoPrintScreen();
    }
  }
}