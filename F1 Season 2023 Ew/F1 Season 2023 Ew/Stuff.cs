using System.Diagnostics;
using System.Media;

namespace F1_Season_2023_Ew
{
    public class Colors
    {
        public static string Custom(int red, int green, int blue) => $"\x1b[38;2;{red};{green};{blue}m";
        public static string Teams(int team) => team switch
        {
            0 => "\x1b[38;2;99;224;163m",//Mercedes
            1 => "\x1b[38;2;10;63;186m",//Red Bull
            2 => "\x1b[38;2;250;17;24m",//Ferrari
            3 => "\x1b[38;2;247;135;34m",//McLaren
            4 => "\x1b[38;2;34;147;210m",//Alpine
            5 => "\x1b[38;2;90;125;147m",//AlphaTauri
            6 => "\x1b[38;2;51;162;106m",//Aston Martin
            7 => "\x1b[38;2;70;210;240m",//Williams
            8 => "\x1b[38;2;211;45;75m",//Alfa Romeo
            9 => "\x1b[38;2;192;196;199m",//Haas
            _ => Text
        };
        public static readonly string Red = "\x1b[38;2;255;0;0m", Black = "\x1b[38;5;232m", Gray = "\x1b[38;5;245m", Grayer = "\x1b[38;5;239m", Darker = "\x1b[38;5;233m", Dark = "\x1b[38;5;235m", LessGray = "\x1b[38;5;254m", White = "\x1b[38;5;255m", Gold = "\x1b[38;2;245;232;3m", Magenta = "\x1b[38;2;241;0;255m", Green = "\x1b[38;2;10;223;20m", Sun = "\x1b[38;2;252;229;112m", Rain = "\x1b[38;2;107;186;230m", Blue = "\x1b[38;2;0;90;240m", Yellow = "\x1b[38;2;200;200;0m";
        public static string Text { get; set; } = White;
    }
    public class WeatherSet
    {
        public static int DNFModifier(Weather weather) => weather switch
        {
            Weather.Sunny => 300,
            Weather.PartlyCloudy => 0,
            Weather.Cloudy => 100,
            Weather.SlightRain => 1000,
            Weather.ModerateRain => 2000,
            Weather.HeavyRain => 3500,
            _ => 0
        };
        public enum Weather
        {
            Sunny = -2,
            Cloudy = -1,
            PartlyCloudy = 0,
            SlightRain = 1,
            ModerateRain = 2,
            HeavyRain = 3
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
                    Console.WriteLine(Colors.Sun + "      ____" + '\n' + "    .-    -.     " + Colors.Text + "It's Sunny" + '\n' + Colors.Sun + @"   /        \" + '\n' + "  |          |" + '\n' + @"   \        /" + '\n' + "    '-____-'");
                    break;
                case Weather.PartlyCloudy:
                    Console.WriteLine(Colors.Sun + $"      ____\n    .-    -.     {Colors.Text}It's Partly Cloudy\n{Colors.Sun}   /    {Colors.LessGray}.--.{Colors.Sun}\\\n  |  {Colors.LessGray}.-(    ).{Colors.Sun}\n   \\{Colors.LessGray}(___.__)__)\n{Colors.Sun}    '-____-'");
                    break;
                case Weather.Cloudy:
                    Console.WriteLine(Colors.LessGray + "      .--.       " + Colors.Text + "It's cloudy" + '\n' + Colors.LessGray + "   .-(    )." + '\n' + "  (___.__)__)");
                    break;
                case Weather.SlightRain:
                    Console.WriteLine(Colors.LessGray + "      .--.       " + Colors.Text + "It's raining" + '\n' + Colors.LessGray + "   .-(    ).     " + Colors.Text + $"Intensity: 1\n  {Colors.LessGray}(___.__)__)\n   {Colors.Rain} |  |  |");
                    break;
                case Weather.ModerateRain:
                    Console.WriteLine(Colors.LessGray + "      .--.       " + Colors.Text + "It's raining" + '\n' + Colors.LessGray + "   .-(    ).     " + Colors.Text + $"Intensity: 2\n  {Colors.LessGray}(___.__)__)\n   {Colors.Rain}| | | | |");
                    break;
                case Weather.HeavyRain:
                    Console.WriteLine(Colors.LessGray + "      .--.       " + Colors.Text + "It's raining" + '\n' + Colors.LessGray + "   .-(    ).     " + Colors.Text + $"Intensity: 3\n  {Colors.LessGray}(___.__)__)\n   {Colors.Rain}|||||||||");
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
                    Console.Write($"{Colors.Text} ·{Colors.Dark}····");
                    break;
                case 4:
                case 5:
                    Console.Write($"{Colors.Text} ··{Colors.Dark}···");
                    break;
                case 6:
                case 7:
                    Console.Write($"{Colors.Text} ···{Colors.Dark}··");
                    break;
                case 8:
                case 9:
                    Console.Write($"{Colors.Text} ····{Colors.Dark}·");
                    break;
                case 10:
                    Console.Write($"{Colors.Text} ·····");
                    break;
            }
        }
        public enum Flag
        {
            Green,
            Yellow,
            Red
        }
        public static void RedLightsFormationLap(int line)
        {
            Console.SetCursorPosition(0, line);
            Console.Write(Colors.Grayer + $"\r           ••••{Colors.Red}•");
            Task.Delay(3000).Wait();
            Console.Write(Colors.Green + "\r           •••••" + Colors.Text);
            Task.Delay(1500).Wait();
        }
        public static void RedLights(int line, int delay)
        {
            SoundPlayer player = new($@"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\sound\StartingBeep.wav");
            Console.SetCursorPosition(0, line);
            Console.Write(Colors.Grayer + "\r           •••••" + Colors.Red);
            Task.Delay(1000).Wait();
            for (int i = 0; i < 5; i++)
            {
                player.Play();
                Console.SetCursorPosition(11 + i, line);
                Console.Write('•');
                if (i == 4)
                    Task.Delay(delay).Wait();
                else
                    Task.Delay(1000).Wait();
            }
            Console.Write(Colors.Grayer + "\r           •••••" + Colors.Text);
            player.Dispose();
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
                    Console.Write(Colors.Text + "\rStop Time " + $"\x1b[38;2;{red};{green};{blue}m" + stopwatch.Elapsed.Seconds + "." + milliseconds + " ");
                    ms += 11;
                }
            }
            stopwatch.Stop();
        }
        public static string[] Car(string color, int number)
        {
            string numberString = NumberToSubscriptString(number);
            string[] car = new string[10];
            car[0] = color + "     ___";
            car[1] = color + "  |━┷┳━┳┷━|";
            car[2] = $"  {Colors.Dark}▐█{color}═┫ ┣═{Colors.Dark}█▌{color}";
            car[3] = color + "     ┃ ┃";
            car[4] = color + "    ╱┃ ┃╲";
            car[5] = color + "   ┃‾(●)‾┃";
            car[6] = color +$"   ┃{numberString}   ┃";
            car[7] = color + "   ┗┓   ┏┛";
            car[8] = $"  {Colors.Dark}▐█{color}┫___┣{Colors.Dark}█▌{color}";
            car[9] = color + @"    /___\";
            return car;
        }
        public static string NumberToSubscriptString(int number) => number < 10 ? NumberToSubscriptChars(number) + " " : NumberToSubscriptChars(number / 10 % 10) + NumberToSubscriptChars(number - (number / 10 % 10 * 10));
        public static string NumberToSubscriptChars(int number) => number switch
        {
            0 => "₀",
            1 => "₁",
            2 => "₂",
            3 => "₃",
            4 => "₄",
            5 => "₅",
            6 => "₆",
            7 => "₇",
            8 => "₈",
            9 => "₉",
            _ => "ₓ",
        };
        public static string NumberToSuperscriptString(int number) => number < 10 ? NumberToSuperscriptChars(number) + " " : NumberToSuperscriptChars(number / 10 % 10) + NumberToSuperscriptChars(number - (number / 10 % 10 * 10));
        public static string NumberToSuperscriptChars(int number) => number switch
        {
            0 => "⁰",
            1 => "¹",
            2 => "²",
            3 => "³",
            4 => "⁴",
            5 => "⁵",
            6 => "⁶",
            7 => "⁷",
            8 => "⁸",
            9 => "⁹",
            _ => "ⁱ",
        };
        public static string NumberToCircledChars(int number) => number switch
        {
             1 => "❶",
             2 => "❷",
             3 => "❸",
             4 => "❹",
             5 => "❺",
             6 => "❻",
             7 => "❼",
             8 => "❽",
             9 => "❾",
            10 => "❿",
            11 => "⓫",
            12 => "⓬",
            13 => "⓭",
            14 => "⓮",
            15 => "⓯",
            16 => "⓰",
            17 => "⓱",
            18 => "⓲",
            19 => "⓳",
            20 => "⓴",
            _ => "⓿"
        };
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
                        string? country = Console.ReadLine() + "";
                        Util.ClearPart(0);
                        Console.WriteLine(EndScreen.Flag(country)[0] + '\n' + EndScreen.Flag(country)[1] + '\n' + EndScreen.Flag(country)[2] + '\n' + EndScreen.Flag(country)[3] + '\n' + EndScreen.Flag(country)[4] + '\n' + EndScreen.Flag(country)[5]);
                        Util.ClearKey();
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Escape)
                            break;
                        Util.ClearPart(0);
                    }
                }
            }
        }
    }
    public class Position
    {
        public short P1 { get; set; }
        public short P2 { get; set; }
        public short P3 { get; set; }
        public short P4 { get; set; }
        public short P5 { get; set; }
        public short P6 { get; set; }
        public short P7 { get; set; }
        public short P8 { get; set; }
        public short P9 { get; set; }
        public short P10 { get; set; }
        public short P11 { get; set; }
        public short P12 { get; set; }
        public short P13 { get; set; }
        public short P14 { get; set; }
        public short P15 { get; set; }
        public short P16 { get; set; }
        public short P17 { get; set; }
        public short P18 { get; set; }
        public short P19 { get; set; }
        public short P20 { get; set; }

        public Position(short item1, short item2, short item3, short item4, short item5, short item6, short item7, short item8, short item9, short item10, short item11, short item12, short item13, short item14, short item15, short item16, short item17, short item18, short item19, short item20)
        {
            P1 = item1;
            P2 = item2;
            P3 = item3;
            P4 = item4;
            P5 = item5;
            P6 = item6;
            P7 = item7;
            P8 = item8;
            P9 = item9;
            P10 = item10;
            P11 = item11;
            P12 = item12;
            P13 = item13;
            P14 = item14;
            P15 = item15;
            P16 = item16;
            P17 = item17;
            P18 = item18;
            P19 = item19;
            P20 = item20;
        }
    }
    public class CareerSave<T1, T2, T3, T4, T5>
    {
        public T1 Number { get; set; }
        public T2 Points { get; set; }
        public T3 Positions { get; set; }
        public T4 FastestLaps { get; set; }
        public T5 DNFs { get; set; }

        public CareerSave(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            Number = item1;
            Points = item2;
            Positions = item3;
            FastestLaps = item4;
            DNFs = item5;
        }
    }
}