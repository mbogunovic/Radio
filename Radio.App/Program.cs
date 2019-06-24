using Radio.Core.Context;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace Radio.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Container container = new Container();

            container.Register<IRadioContext>(() => new RadioContext());

            Application.Run(container.GetInstance<MainForm>());
        }
    }
}
