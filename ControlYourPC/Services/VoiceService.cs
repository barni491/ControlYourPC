using System;
using ControlYourPC.Services.Interfaces;
using ControlYourPC.Wrapper.Interfaces;
using NAudio.CoreAudioApi;

namespace ControlYourPC.Services
{
  public class VoiceService : IVoiceService
  {
    private readonly Iuser32dllVolumeFunctionWrapper _volumeFunctionWrapper;

    private readonly MMDeviceEnumerator _deviceEnumerator = new MMDeviceEnumerator();
    private readonly MMDevice _defaultDevice;

    public VoiceService(Iuser32dllVolumeFunctionWrapper volumeFunctionWrapper)
    {
      _volumeFunctionWrapper = volumeFunctionWrapper;

      _defaultDevice = _deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
    }
    public void VolumeUpAbout(string value)
    {
      float? valueFloat = ConvertToFloat(value);
      if (!valueFloat.HasValue)
      {
        return;
      }

      float currentVolume = GetVolume();
      float newVolume = currentVolume + valueFloat.Value;

      SetVolume(newVolume);
    }

    public void VolumeDownAbout(string value)
    {
      float? valueFloat = ConvertToFloat(value);
      if (!valueFloat.HasValue)
      {
        return;
      }

      float currentVolume = GetVolume();
      float newVolume = currentVolume - valueFloat.Value;

      SetVolume(newVolume);
    }

    public void SetVolumeTo(string value)
    {
      float? newVolume = ConvertToFloat(value);
      if (!newVolume.HasValue)
      {
        return;
      }

      SetVolume(newVolume.Value);
    }

    public void Mute()
    {
      _volumeFunctionWrapper.PressMuteKey();
    }

    public void Unmute()
    {
      _volumeFunctionWrapper.PressMuteKey();
    }

    private static float? ConvertToFloat(string value)
    {
      float newVolume;
      bool success = float.TryParse(value, out newVolume);
      if (success)
      {
        return newVolume / 100;
      }

      Console.WriteLine($"Given value is invalid! Value:[{value}].");
      return null;
    }

    private float GetVolume()
    {
      float currentVolume = _defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar;

      return currentVolume;
    }

    private void SetVolume(float value)
    {
      if (value < 0)
      {
        value = 0;
      }
      if (value > 1)
      {
        value = 1;
      }

      _defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = value;
    }
  }
}