using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlYourPC.Host
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      var form = new ControlYourPC_HOST
      {
        ShowInTaskbar = false,
        Visible = false,
        FormBorderStyle = FormBorderStyle.None,
        Size = new Size(0, 0)
      };

      Application.Run(form);
    }
  }
}