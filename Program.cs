using System;
using System.Threading;
using System.Windows.Forms;

namespace SmthRender
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Console.Title = "Console 3Dimensional Graphics Engine";
            Grid.InitializeScreen();
            Grid.InitializeGrid();
            Thread console = new Thread(ConsoleWork);
            console.Start();
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        private static void ConsoleWork()
        {
            for (; ; )
            {
                Render.RunTestScene();
            }
        }
    }
}
