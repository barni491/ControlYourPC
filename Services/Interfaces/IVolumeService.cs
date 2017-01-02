namespace sterowanie_glosem.Services.Interfaces
{
  public interface IVolumeService
  {
    void VolumeUp(int value);

    void VolumeDown(int value);

    void Mute();

    int GetVolume();
  }
}