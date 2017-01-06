namespace ControlYourPC.Domain
{
  public enum CommandType
  {
    NOT_SET,

    VoiceUpAbout,
    VoiceDownAbout,
    VoiceUpTo,
    VoiceDownTo,
    Mute,
    Unmute,

    TakePrintScreen,

    RunExternalProcess,

    TurnOnCapsLock,
    TurnOfCapsLock
  }
}