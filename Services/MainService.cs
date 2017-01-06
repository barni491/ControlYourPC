using System;
using sterowanie_glosem.Domain;
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
    private readonly IVoiceService _voiceService;
    private readonly ICommonService _commonService;

    public MainService(
      ISpeechRecognationService speechRecognationService,
      IVoiceRecordService voiceRecordService,
      IGrammarService grammarService,
      IExternalProcessManager externalProcessManager,
      IScreenService screenService,
      IVoiceService voiceService,
      ICommonService commonService)
    {
      _speechRecognationService = speechRecognationService;
      _voiceRecordService = voiceRecordService;
      _grammarService = grammarService;
      _externalProcessManager = externalProcessManager;
      _screenService = screenService;
      _voiceService = voiceService;
      _commonService = commonService;
    }

    public void Process()
    {
      //_voiceRecordService.RecordCommand();

      //string text = _speechRecognationService.RecognizeCommand();

      string text = "ciszej o 10";
      Command command = _grammarService.AnalizeGrammar(text);

      RunInternal(command);
    }

    private void RunInternal(Command command)
    {
      switch (command.CommandType)
      {
        case CommandType.Mute:
          _voiceService.Mute();
          break;
        case CommandType.Unmute:
          _voiceService.Unmute();
          break;
        case CommandType.VoiceUpAbout:
          _voiceService.VolumeUp(Convert.ToInt32(command.Value));
          break;
        case CommandType.VoiceDownAbout:
          _voiceService.VolumeDown(Convert.ToInt32(command.Value));
          break;
        case CommandType.RunExternalProcess:
          _externalProcessManager.Run(command.Value);
          break;
        case CommandType.TakePrintScreen:
          _screenService.TakePrintScreen();
          break;
        case CommandType.TurnOnCapsLock:
          _commonService.TurnOnCapsLock();
          break;
        case CommandType.TurnOfCapsLock:
          _commonService.TurnOffCapsLock();
          break;
        default:
          Console.WriteLine($"Unknown command. Command type:[{command.CommandType}].");
          throw new NotImplementedException();
      }
    }
  }
}