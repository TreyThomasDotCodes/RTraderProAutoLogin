using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;

namespace TreyThomasDotCodes.RTraderProAutoLogin.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Program Files (x86)\Rithmic\Rithmic Trader Pro\Rithmic Trader Pro.exe";
            if (args.Length > 0)
                path = args[0];

            using var automation = new UIA3Automation();
            using var app = Application.AttachOrLaunch(new System.Diagnostics.ProcessStartInfo(path));

            var window = app.GetMainWindow(automation);
            var loginButton = window.FindFirstDescendant(cf => cf.ByText("Login")).AsButton();

            loginButton.Invoke();
        }
    }
}
