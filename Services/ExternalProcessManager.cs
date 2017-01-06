﻿using System;
using System.Diagnostics;
using System.IO;
using sterowanie_glosem.Domain;
using sterowanie_glosem.Services.Interfaces;

namespace sterowanie_glosem.Services
{
  public class ExternalProcessManager : IExternalProcessManager
  {
    private static readonly string ProgramListFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}//..//..//Programs.xml";

    private readonly IXmlReader _xmlReader;

    public ExternalProcessManager(IXmlReader xmlReader)
    {
      _xmlReader = xmlReader;
    }

    public void Run(string programName)
    {
      ProgramList programList = _xmlReader.ReadProgramList(ProgramListFilePath);

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
        Console.WriteLine($"Program is not defined! Program name: [{programName}].");

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