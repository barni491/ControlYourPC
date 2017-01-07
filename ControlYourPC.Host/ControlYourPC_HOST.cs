using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace ControlYourPC.Host
{
  public partial class ControlYourPC_HOST : Form
  {
    private readonly IKeyboardMouseEvents _keyboardMouseEvents;

    private readonly App _app;

    public ControlYourPC_HOST()
    {
      InitializeComponent();

      _app = new App();

      _keyboardMouseEvents = Hook.GlobalEvents();
      _keyboardMouseEvents.KeyPress += GlobalHookKeyPress;
    }

    private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == 'q')
      {
        _app.Main();
      }
    }
  }
}