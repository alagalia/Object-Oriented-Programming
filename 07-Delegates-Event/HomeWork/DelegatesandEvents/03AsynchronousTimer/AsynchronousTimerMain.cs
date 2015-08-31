using System;

namespace _03AsynchronousTimer
{
    class AsynchronousTimerMain
    {
        static void Main()
        {
           
            AsyncTimer printGreen = new AsyncTimer(PrintCyanBackgroundToConsole, 7, 1500);
            printGreen.Run();

            AsyncTimer printInfo = new AsyncTimer(PrintInfoText, 7, 2000);
            printInfo.Run();
            

            AsyncTimer beep = new AsyncTimer(MakeSound, 10, 1500);
            beep.Run();
        }

        private static void MakeSound(int num)
        {
            Console.Beep();
        }
        
        private static void PrintCyanBackgroundToConsole(int num)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(num+ ",");
        }

        public static void PrintInfoText(int num)
        {
            Console.WriteLine("I am a method and I was called {0} times", num);
        }
    }
}
