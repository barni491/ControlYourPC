namespace ControlYourPC.Domain
{
  public enum CommandType
  {
    NOT_SET,

    VoiceUpAbout,
    VoiceDownAbout,
    SetVolumeTo,
    Mute,
    Unmute,

    TakePrintScreen,

    RunExternalProcess,

    TurnOnCapsLock,
    TurnOfCapsLock
  }
}