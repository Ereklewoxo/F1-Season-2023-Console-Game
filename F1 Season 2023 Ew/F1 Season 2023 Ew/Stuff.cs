
using System.Diagnostics;

namespace F1_Season_2023_Ew
{
    public class Colors
    {
        public static string Custom(int red, int green, int blue) => $"\x1b[38;2;{red};{green};{blue}m";
        public static List<string> Teams() => new() { "\x1b[38;5;85m", "\x1b[38;5;27m", "\x1b[38;5;196m", "\x1b[38;5;214m", "\x1b[38;5;69m", "\x1b[38;2;110;160;175m", "\x1b[38;5;35m", "\x1b[38;5;45m", "\x1b[38;5;160m", "\x1b[38;5;251m" };
        
        public static readonly string Gray = "\x1b[38;5;245m", Grayer = "\x1b[38;5;239m", Darker = "\x1b[38;5;233m", Dark = "\x1b[38;5;235m", LessGray = "\x1b[38;5;252m", White = "\x1b[38;5;255m", Gold = "\x1b[38;2;245;232;3m", Magenta = "\x1b[38;2;241;0;255m", Green = "\x1b[38;2;10;223;20m", Sun = "\x1b[38;2;252;229;112m", Rain = "\x1b[38;2;107;186;230m";
    }
    public class WeatherSet
    {
        public static int DNFModifier(Weather weather)
        {
            int modifier = 0;
            switch (weather)
            {
                case Weather.Sunny:
                    modifier = 300;
                    break;
                case Weather.PartlyCloudy:
                    break;
                case Weather.Cloudy:
                    modifier = 100;
                    break;
                case Weather.SlightRain:
                    modifier = 1000;
                    break;
                case Weather.ModerateRain:
                    modifier = 2000;
                    break;
                case Weather.HeavyRain:
                    modifier = 3500;
                    break;
            }
            return modifier;
        }
        public enum Weather
        {
            Sunny,
            Cloudy,
            PartlyCloudy,
            SlightRain,
            ModerateRain,
            HeavyRain
        }
        public static Weather WeatherFormula(int circuitWeather)
        {
            Weather weather;
            Random rnd = new();
            int weatherRnd = rnd.Next(100);
            if (circuitWeather > weatherRnd)
            {
                int rainIntensity = rnd.Next(6);
                if (rainIntensity == 0)
                    weather = Weather.HeavyRain;
                else if (rainIntensity < 3)
                    weather = Weather.ModerateRain;
                else
                    weather = Weather.SlightRain;
            }
            else
            {
                int sunnyOrCloudy = rnd.Next(3);
                if (sunnyOrCloudy == 0)
                    weather = Weather.Sunny;
                else if (sunnyOrCloudy == 1)
                    weather = Weather.PartlyCloudy;
                else
                    weather = Weather.Cloudy;
            }
            return weather;
        }
        public static void WeatherGraphics(Weather weather)
        {
            switch (weather)
            {
                case Weather.Sunny:
                    Console.WriteLine(Colors.Sun + "      ____" + '\n' + "    .-    -.     " + Colors.White + "It's Sunny" + '\n' + Colors.Sun + @"   /        \" + '\n' + "  |          |" + '\n' + @"   \        /" + '\n' + "    '-____-'");
                    break;
                case Weather.PartlyCloudy:
                    Console.WriteLine(Colors.Sun + $"      ____\n    .-    -.     {Colors.White}It's Partly Cloudy\n{Colors.Sun}   /    {Colors.LessGray}.--.{Colors.Sun}\\\n  |  {Colors.LessGray}.-(    ).{Colors.Sun}\n   \\{Colors.LessGray}(___.__)__)\n{Colors.Sun}    '-____-'");
                    break;
                case Weather.Cloudy:
                    Console.WriteLine(Colors.LessGray + "      .--.       " + Colors.White + "It's cloudy" + '\n' + Colors.LessGray + "   .-(    )." + '\n' + "  (___.__)__)");
                    break;
                case Weather.SlightRain:
                    Console.WriteLine(Colors.LessGray + "      .--.       " + Colors.White + "It's raining" + '\n' + Colors.LessGray + "   .-(    ).     " + Colors.White + $"Intensity: 1\n  {Colors.LessGray}(___.__)__)\n   {Colors.Rain} |  |  |");
                    break;
                case Weather.ModerateRain:
                    Console.WriteLine(Colors.LessGray + "      .--.       " + Colors.White + "It's raining" + '\n' + Colors.LessGray + "   .-(    ).     " + Colors.White + $"Intensity: 2\n  {Colors.LessGray}(___.__)__)\n   {Colors.Rain}| | | | |");
                    break;
                case Weather.HeavyRain:
                    Console.WriteLine(Colors.LessGray + "      .--.       " + Colors.White + "It's raining" + '\n' + Colors.LessGray + "   .-(    ).     " + Colors.White + $"Intensity: 3\n  {Colors.LessGray}(___.__)__)\n   {Colors.Rain}|||||||||");
                    break;
            }
            Util.KeyAdvance(ConsoleKey.Escape);
        }
    }
    public class Assets
    {
        public static void FillBar(int skip)
        {
            switch (skip)
            {
                case 0:
                case 1:
                    Console.Write($"{Colors.Dark} ·····");
                    break;
                case 2:
                case 3:
                    Console.Write($"{Colors.White} ·{Colors.Dark}····");
                    break;
                case 4:
                case 5:
                    Console.Write($"{Colors.White} ··{Colors.Dark}···");
                    break;
                case 6:
                case 7:
                    Console.Write($"{Colors.White} ···{Colors.Dark}··");
                    break;
                case 8:
                case 9:
                    Console.Write($"{Colors.White} ····{Colors.Dark}·");
                    break;
                case 10:
                    Console.Write($"{Colors.White} ·····");
                    break;
            }
        }
        public enum Flag
        {
            Green,
            Yellow,
            Red
        }
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
    public class Debug
    {
        public static void CheckFlag()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F7)
                {
                    while (true)
                    {
                        string? country = Console.ReadLine();
                        Util.ClearPart(0);
                        Console.WriteLine(Play.Flag(country)[0] + '\n' + Play.Flag(country)[1] + '\n' + Play.Flag(country)[2] + '\n' + Play.Flag(country)[3] + '\n' + Play.Flag(country)[4] + '\n' + Play.Flag(country)[5]);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Escape)
                            break;
                        Util.ClearPart(0);
                    }
                }
            }
        }
    }
    public class WoxoTuple
    {
        public short F1 { get; set; }
        public short F2 { get; set; }
        public short F3 { get; set; }
        public short F4 { get; set; }
        public short F5 { get; set; }
        public short F6 { get; set; }
        public short F7 { get; set; }
        public short F8 { get; set; }
        public short F9 { get; set; }
        public short F10 { get; set; }

        public WoxoTuple(short item1, short item2, short item3, short item4, short item5, short item6, short item7, short item8, short item9, short item10)
        {
            F1 = item1;
            F2 = item2;
            F3 = item3;
            F4 = item4;
            F5 = item5;
            F6 = item6;
            F7 = item7;
            F8 = item8;
            F9 = item9;
            F10 = item10;
        }
    }
    public class CareerSave<T1, T2, T3>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }

        public CareerSave(T1 item1, T2 item2, T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }
    }
}