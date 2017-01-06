namespace ControlYourPC.Services.Interfaces
{
  public interface IVoiceService
  {
    void VolumeUp(int value);

    void VolumeDown(int value);

    void Mute();

    void Unmute();

    int GetVolume();
  }
}