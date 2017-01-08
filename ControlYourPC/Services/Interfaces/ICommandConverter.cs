using ControlYourPC.Domain;

namespace ControlYourPC.Services.Interfaces
{
  public interface ICommandConverter
  {
    Command Convert(string source);
  }
}