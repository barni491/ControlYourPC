using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using ControlYourPC.Domain;
using ControlYourPC.Services.Interfaces;

namespace ControlYourPC.Services
{
  public class ExternalProcessManager : IExternalProcessManager
  {
    private static readonly string ProgramListFilePath =
      $"{AppDomain.CurrentDomain.BaseDirectory}Programs.xml";

    private readonly IXmlReader _xmlReader;

    public ExternalProcessManager(IXmlReader xmlReader)
    {
      _xmlReader = xmlReader;
    }

    public void Run(string programName)
    {
      ProgramList programList = _xmlReader.ReadProgramList(ProgramListFilePath);
      if (!programList.Programs.Any())
      {
        Console.WriteLine($"You define any program! Program list localized in [{ProgramListFilePath}] is empty.");

        return;
      }

      Domain.Program selectedProgram = null;
      foreach (Domain.Program program in programList.Programs)
      {
        if (program.Name.Equals(programName))
        {
          selectedProgram = program;
        }
      }

      if (selectedProgram == null)
      {
        Console.WriteLine($"Selected program is not defined! Program name: [{programName}].");

        return;
      }

      RunExternalProcess(selectedProgram.Path);
    }

    private static void RunExternalProcess(string path)
    {
      if (!File.Exists(path))
      {
        throw new FileNotFoundException(path);
      }

      var externalProcess = new Process
      {
        StartInfo = new ProcessStartInfo
        {
          FileName = path,
          WindowStyle = ProcessWindowStyle.Maximized
        }
      };

      externalProcess.Start();
      externalProcess.WaitForExit();
    }
  }
}