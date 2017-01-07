using System;

namespace ControlYourPC
{
  class Program
  {
    [STAThread]
    static public void Main(string[] args)
    {
      var app = new App();
      app.Main();
    }
  }
}