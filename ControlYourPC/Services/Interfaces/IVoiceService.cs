namespace ControlYourPC.Services.Interfaces
{
  public interface IVoiceService
  {
    void VolumeUpAbout(string value);

    void VolumeDownAbout(string value);

    void SetVolumeTo(string value);

    void Mute();

    void Unmute();
  }
}