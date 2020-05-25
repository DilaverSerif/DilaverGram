using System;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;

namespace easygrammm
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dilavergram());

        }
    }
}
