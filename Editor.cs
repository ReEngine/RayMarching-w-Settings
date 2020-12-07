using System;

namespace SmthRender
{
    internal class Editor
    {
        public static void Construct()
        {

        }
        public static void EditorInitialize()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            DrawInterface();
        }

        private static void DrawInterface()
        {
            Grid.DrawRectangle(1, 1, 15, 30, ConsoleColor.White);
            Grid.FillRectangle(2, 2, 14, 29, ConsoleColor.DarkBlue);
            Console.SetCursorPosition(4, 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            FastConsole.Write("Editor");

            DrawCircle();


        }

        private static void DrawCircle()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                MarkPoint(Grid.Width / 2, Grid.Height / 2);
            }
        }

        private static void MarkPoint(int x, int y)
        {
            try
            {
                if (y < Grid.Height - 1)
                {
                    Console.SetCursorPosition(x * 2, y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    FastConsole.Write("▒▒");
                }
            }
            catch
            {

            }


            // FastConsole.Write("##");
        }






    }

}
