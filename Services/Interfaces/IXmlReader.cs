using sterowanie_glosem.Domain;

namespace sterowanie_glosem.Services.Interfaces
{
  public interface IXmlReader
  {
    ProgramList ReadProgramList(string path);
  }
}