using System;
using System.Windows.Forms;

namespace ClasificadorNoticiasGUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
