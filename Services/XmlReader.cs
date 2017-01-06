using System;
using System.IO;
using System.Xml.Serialization;
using sterowanie_glosem.Domain;
using sterowanie_glosem.Services.Interfaces;

namespace sterowanie_glosem.Services
{
  public class XmlReader : IXmlReader
  {
    public ProgramList ReadProgramList(string path)
    {
      try
      {
        if (!File.Exists(path))
        {
          throw new FileNotFoundException(path);
        }

        ProgramList programList;

        var xmlSerializer = new XmlSerializer(typeof(ProgramList));

        using (var fileStream = File.OpenRead(path))
        {
          programList = (ProgramList)xmlSerializer.Deserialize(fileStream);
        }

        return programList;
      }
      catch (Exception exception)
      {
        Console.WriteLine(
          $"An error occurred while getting programs from [{path}]. Error message: [{exception.Message}]");

        throw;
      }     
    }
  }
}