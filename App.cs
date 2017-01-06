using System;
using Castle.Windsor;
using Castle.Windsor.Installer;
using ControlYourPC.Services.Interfaces;

namespace ControlYourPC
{
  public class App
  {
    private IMainService _mainService;

    public void Start()
    {
      var container = new WindsorContainer();
      container.Install(FromAssembly.This());

      _mainService = container.Resolve<IMainService>();
    }

    public void Main()
    {
      _mainService.Process();

      Console.ReadKey();
    }
  }
}