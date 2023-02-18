
using System.Diagnostics;

namespace F1_Season_2023_Ew
{
    public class Colors
    {
        public static string Custom(int red, int green, int blue)
        {
            string color = $"\x1b[38;2;{red};{green};{blue}m";
            return color;
        }
        public static List<string> Teams()
        {
            //Mercedes         Red Bull         Ferrari           McLaren           Alpine           AlphaTauri                Aston Martin     Williams         Alfa Romeo        Haas F1 Team
            var colorIndex = new List<string> { "\x1b[38;5;85m", "\x1b[38;5;27m", "\x1b[38;5;196m", "\x1b[38;5;214m", "\x1b[38;5;69m", "\x1b[38;2;110;160;175m", "\x1b[38;5;35m", "\x1b[38;5;45m", "\x1b[38;5;160m", "\x1b[38;5;251m" };
            return colorIndex;
        }
        public static readonly string Gray = "\x1b[38;5;245m", Grayer = "\x1b[38;5;239m", Darker = "\x1b[38;5;233m", Dark = "\x1b[38;5;235m", LessGray = "\x1b[38;5;252m", White = "\x1b[38;5;255m", Gold = "\x1b[38;2;245;232;3m", Magenta = "\x1b[38;2;241;0;255m", Green = "\x1b[38;2;10;223;20m", Sun = "\x1b[38;2;252;229;112m", Rain = "\x1b[38;2;107;186;230m";
    }
    public class Assets
    {
        public static void RedLights(int line, int delay)
        {
            Console.SetCursorPosition(0, line);
            Console.Write(Colors.Gray + "\r           ·····" + Colors.Teams()[2]);
            Task.Delay(1000).Wait();
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(11 + i, line);
                Console.Write('·');
                if (i == 4)
                    Task.Delay(delay).Wait();
                else
                    Task.Delay(1000).Wait();
            }
            Console.Write(Colors.Gray + "\r           ·····" + Colors.White);
        }
        public static void ColorStopwatch(int stopTime)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            int ms = 2, red = 10, green = 222, blue = 20;
            while (stopwatch.ElapsedMilliseconds < stopTime)
            {
                if (ms - stopwatch.ElapsedMilliseconds < 5)
                {
                    if (stopwatch.Elapsed.Seconds < 1.15)
                        green = 222;
                    else if (stopwatch.Elapsed.Seconds < 2.5)
                        red = Math.Min(red + 1, 255);
                    else if (stopwatch.Elapsed.Seconds < 3.5)
                    {
                        red = Math.Min(red + 1, 255);
                        green = Math.Max(green - 1, 0);
                    }
                    else if (stopwatch.Elapsed.Seconds < 5)
                    {
                        green = Math.Max(green - 1, 0);
                        blue = Math.Max(blue - 1, 0);
                    }
                    else if (stopwatch.Elapsed.Seconds < 8)
                    {
                        red = Math.Min(red + 1, 255);
                        green = Math.Max(green - 1, 0);
                        blue = Math.Max(blue - 1, 0);
                    }
                    else if (stopwatch.Elapsed.Seconds < 10)
                        red = Math.Max(red - 1, 160);
                    else
                        blue = Math.Min(blue + 1, 255);
                    string milliseconds = stopwatch.Elapsed.Milliseconds.ToString();
                    if (stopwatch.Elapsed.Milliseconds < 10)
                        milliseconds = "00" + milliseconds;
                    else if (stopwatch.Elapsed.Milliseconds < 100)
                        milliseconds = "0" + milliseconds;
                    Console.Write(Colors.White + "\rStop Time " + $"\x1b[38;2;{red};{green};{blue}m" + stopwatch.Elapsed.Seconds + "." + milliseconds + " ");
                    ms += 11;
                }
            }
            stopwatch.Stop();
        }
    }
    public class Util
    {
        public static void ClearPart(int startingPosition)
        {
            if (startingPosition >= 0)
            {  
                string line = "".PadLeft(Console.WindowWidth);
                Console.SetCursorPosition(0, startingPosition);
                for (int i = startingPosition; i <= Console.WindowHeight - startingPosition; i++)
                    Console.WriteLine(line);
                Console.SetCursorPosition(0, startingPosition);
            }
        }
        public static void KeyAdvance(ConsoleKey advanceKey)
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != advanceKey);
        }
        public static void ClearKey()
        {
            while (Console.KeyAvailable)
                Console.ReadKey(false);
        }
    }
}