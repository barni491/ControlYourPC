using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using sterowanie_glosem.Services.Interfaces;

namespace sterowanie_glosem.Services
{
  public class ScreenService : IScreenService
  {
    private static readonly string PrintScreenDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screens\\";

    public void TakePrintScreen()
    {
      Rectangle rectangle = Screen.GetBounds(Point.Empty);

      using (var bitmap = new Bitmap(rectangle.Width, rectangle.Height))
      {
        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
          graphics.CopyFromScreen(Point.Empty, Point.Empty, rectangle.Size);
        }

        string fileName = $"Screen_{DateTime.Now.ToString("dd-MM-yy HH_mm_ss_fff")}.jpg";
        string printScreenFilePath = $"{PrintScreenDirectoryPath}{fileName}";

        if (!Directory.Exists(PrintScreenDirectoryPath))
        {
          Directory.CreateDirectory(PrintScreenDirectoryPath);
        }

        bitmap.Save(printScreenFilePath, ImageFormat.Jpeg);
      }
    }
  }
}