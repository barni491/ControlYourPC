using sterowanie_glosem.Services.Interfaces;
using System;

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
            string[] test = new string [] { "przycisz", "głośniej" };

            Console.WriteLine(test[1]);
//      _voiceRecordService.RecordCommand();

   //   string text = _speechRecognationService.RecognizeCommand();

      _grammarService.AnalizeGrammar(test[1]);
    }
  }
}