using ControlYourPC.Domain;

namespace ControlYourPC.Services.Interfaces
{
  public interface IXmlReader
  {
    ProgramList ReadProgramList(string path);
  }
}