using System;
using ControlYourPC.Domain;
using ControlYourPC.Services.Interfaces;

namespace ControlYourPC.Services
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
            _voiceRecordService.RecordCommand();

            string recordedText = _speechRecognationService.RecognizeCommand();

            Console.WriteLine(recordedText);

            Command command = _grammarService.AnalizeGrammar(recordedText.ToLower());

            RunInternal(command);
        }

        private void RunInternal(Command command)
        {
            if (command == null)
            {
                Console.WriteLine("Unrecognized command!");
                return;
            }

            Console.WriteLine($"Command type = [{command.CommandType.ToString()}], command value = [{command.Value}].");

            switch (command.CommandType)
            {
                case CommandType.SetVolumeTo:
                    _voiceService.SetVolumeTo(command.Value);
                    break;
                case CommandType.Mute:
                    _voiceService.Mute();
                    break;
                case CommandType.Unmute:
                    _voiceService.Unmute();
                    break;
                case CommandType.VoiceUpAbout:
                    _voiceService.VolumeUpAbout(command.Value);
                    break;
                case CommandType.VoiceDownAbout:
                    _voiceService.VolumeDownAbout(command.Value);
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
                case CommandType.TurnOffCapsLock:
                    _commonService.TurnOffCapsLock();
                    break;
                default:
                    Console.WriteLine($"Handling this type of command is not implemented. Command type:[{command.CommandType}].");
                    throw new NotImplementedException();
            }
        }
    }
}