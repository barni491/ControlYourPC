using sterowanie_glosem.Services.Interfaces;

namespace sterowanie_glosem.Services
{
  public class MainService : IMainService
  {
    private readonly ISpeechRecognationService _speechRecognationService;
    private readonly IVoiceRecordService _voiceRecordService;
    private readonly IGrammarService _grammarService;

    public MainService(
      ISpeechRecognationService speechRecognationService, 
      IVoiceRecordService voiceRecordService, 
      IGrammarService grammarService)
    {
      _speechRecognationService = speechRecognationService;
      _voiceRecordService = voiceRecordService;
      _grammarService = grammarService;
    }

    public void Process()
    {
      _voiceRecordService.RecordCommand();

      string text = _speechRecognationService.RecognizeCommand();

      _grammarService.AnalizeGrammar(text);
    }
  }
}