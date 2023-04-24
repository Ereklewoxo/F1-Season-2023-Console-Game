using System.Diagnostics;
using static F1_Season_2023_Ew.WeatherSet;
using Task = System.Threading.Tasks.Task;

namespace F1_Season_2023_Ew
{
    public class RaceUpdate
    {
        public static List<KeyValuePair<int, double>> LineupUpdate(List<KeyValuePair<int, double>> lineup)
        {
            var updatedLineup = new List<KeyValuePair<int, double>> { };
            for (short i = 0; i < lineup.Count; i++)
                updatedLineup.Add(new KeyValuePair<int, double>(lineup[i].Key, i));
            return updatedLineup;
        }
    }
    public class MiniGames
    {
        public static int RedLights()
        {
            ConsoleKeyInfo key;
            Random rnd = new();
            Stopwatch stopwatch = new();
            int score, lastDelay = 1000 + rnd.Next(-300, 1000), difficulty = Data.Difficulty * 100;
            Console.Write("Five " + Colors.Red + "Red " + Colors.Text + "Lights" + Colors.Gray + "\nPress [W] as soon as the red lights go out" + Colors.Dark + " [Enter]");
            Util.KeyAdvance(ConsoleKey.Enter);
            Console.SetCursorPosition(Console.CursorLeft - 8, Console.CursorTop);
            Console.Write("         ");
            Assets.RedLights(6, lastDelay - difficulty);
            stopwatch.Start();
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.W)
            {
                stopwatch.Stop();
                Task.Delay(600).Wait();
            }
            else 
            {
                Task.Delay(1000).Wait();
                stopwatch.Stop();
            }
            Console.WriteLine("\n");
            if (stopwatch.ElapsedMilliseconds < 3 && key.Key == ConsoleKey.W)
            {
                Console.Write($"{Colors.Red}False Start\n{Colors.LessGray}You've been penalised with a 5 second penalty");
                score = -6;
            }
            else if (key.Key != ConsoleKey.W)
            {
                Console.Write($"You pressed the wrong button\n{Colors.LessGray}Specifically [{key.Key}]");
                score = -13;
            }
            else
            {
                Console.Write("Your time ");
                if (stopwatch.ElapsedMilliseconds < 301)
                    Console.Write(Colors.Green + $"{stopwatch.ElapsedMilliseconds}ms");
                else if (stopwatch.ElapsedMilliseconds > 300 && stopwatch.ElapsedMilliseconds < 1000)
                    Console.Write(Colors.Red + $"{stopwatch.ElapsedMilliseconds}ms");
                else
                    Console.Write(Colors.Red + "\rYou are stationary");
                if (stopwatch.ElapsedMilliseconds < 21)
                    score = 7;
                else if (stopwatch.ElapsedMilliseconds < 81)
                    score = 6;
                else if (stopwatch.ElapsedMilliseconds < 151)
                    score = 5;
                else if (stopwatch.ElapsedMilliseconds < 236)
                    score = 3;
                else if (stopwatch.ElapsedMilliseconds < 266)
                    score = 2;
                else if (stopwatch.ElapsedMilliseconds < 291)
                    score = 1;
                else if (stopwatch.ElapsedMilliseconds < 301)
                    score = 0;
                else if (stopwatch.ElapsedMilliseconds < 351)
                    score = -1;
                else if (stopwatch.ElapsedMilliseconds < 401)
                    score = -2;
                else if (stopwatch.ElapsedMilliseconds < 601)
                    score = -4;
                else if (stopwatch.ElapsedMilliseconds < 1001)
                    score = -6;
                else
                    score = -15;

            }
            Console.Write('\n' + Colors.Text + "It's lights out and away we go" + Colors.Dark + " [Enter]");
            Util.KeyAdvance(ConsoleKey.Enter);
            return score;
        }
        public static int DRS()
        {
            Random rnd = new();
            Stopwatch stopwatch = new();
            ConsoleKeyInfo key;
            int miniGameDRS = rnd.Next(2860, 7650), score, difficulty = Data.Difficulty * 100;
            Console.Write("Turning On" + Colors.Green + " DRS\n" + Colors.Gray + "Press [D] only when DRS turns green");
            Console.Write(Colors.Dark + " [Enter]");
            int cursorTop = Console.CursorTop, cursorLeft = Console.CursorLeft - 8;
            Console.SetCursorPosition(0, cursorTop + 2);
            Console.Write(Colors.Dark + "" +
                "             ┌─────┐\n" +
               $"             │ DRS │\n" +
                "             └─────┘");
            Util.KeyAdvance(ConsoleKey.Enter);
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.WriteLine("         ");
            Task.Delay(miniGameDRS - difficulty).Wait();
            Console.SetCursorPosition(0, cursorTop + 2);
            Console.Write(Colors.Gray + "" +
                "             ┌─────┐\n" +
               $"             │ {Colors.Green}DRS{Colors.Gray} │\n" +
                "             └─────┘\n\n" + Colors.Text);
            stopwatch.Start();
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.D)
                stopwatch.Stop();
            Task.Delay(700).Wait();
            if (stopwatch.IsRunning)
                stopwatch.Stop();
            Console.Write("Your time ");
            #region scoreing system
            if (stopwatch.ElapsedMilliseconds < 3 && key.Key == ConsoleKey.D)
            {
                Console.Write($"\r[D] was pressed preemptively");
                score = -6;
            }
            else if (stopwatch.ElapsedMilliseconds < 201 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Gold + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 5;
            }
            else if (stopwatch.ElapsedMilliseconds < 251 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Green + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 4;
            }
            else if (stopwatch.ElapsedMilliseconds < 266 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Green + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 3;
            }
            else if (stopwatch.ElapsedMilliseconds < 286 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Green + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 2;
            }
            else if (stopwatch.ElapsedMilliseconds < 301 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Green + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 1;
            }
            else if (stopwatch.ElapsedMilliseconds < 311 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Sun + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 0;
            }
            else if (stopwatch.ElapsedMilliseconds < 401 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Red + $"{stopwatch.ElapsedMilliseconds}ms");
                score = -1;
            }
            else if (stopwatch.ElapsedMilliseconds < 501 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Red + $"{stopwatch.ElapsedMilliseconds}ms");
                score = -2;
            }
            else if (stopwatch.ElapsedMilliseconds < 801 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Red + $"{stopwatch.ElapsedMilliseconds}ms");
                score = -4;
            }
            else if (stopwatch.ElapsedMilliseconds > 800 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Red + $"{stopwatch.ElapsedMilliseconds}ms");
                score = -5;
            }
            else
            {
                Console.Write($"\rYou pressed the wrong button\n{Colors.LessGray}Specifically [{key.Key}]");
                score = -10;
            }
            #endregion
            Console.Write(Colors.Dark + " [Enter]");
            Util.KeyAdvance(ConsoleKey.Enter);
            return score;
        }
        public static int Brakes(WeatherSet.Weather weather)
        {
            Random rnd = new();
            Stopwatch stopwatch = new();
            ConsoleKeyInfo key;
            int miniGameBrakes = rnd.Next(2601, 7500), miniGameRain = 0, score, difficulty = Data.Difficulty * 100;
            Console.Write(Colors.Custom(255, 100, 70) + "Braking Point\n" + Colors.Gray + "Hit the brakes [S] when the button turns red");
            if (weather is (WeatherSet.Weather)1 or (WeatherSet.Weather)2 or (WeatherSet.Weather)3)
                Console.Write($"\n{Colors.Rain}Rain effect{Colors.Gray}: Button might turn blue");
            Console.Write(Colors.Dark + " [Enter]");
            int cursorTop = Console.CursorTop, cursorLeft = Console.CursorLeft - 8;
            Console.SetCursorPosition(0, cursorTop + 2);
            Console.Write(Colors.Dark + "" +
                "            ┌────────┐\n" +
               $"            │ BRAKES │\n" +
                "            └────────┘");
            Util.KeyAdvance(ConsoleKey.Enter);
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.WriteLine("         ");
            bool randomRainEvent = (int)weather >= rnd.Next(10);
            if ((weather is (WeatherSet.Weather)1 or (WeatherSet.Weather)2 or (WeatherSet.Weather)3) && randomRainEvent)
            {
                miniGameRain = rnd.Next(1600, 2100);
                Task.Delay(miniGameRain).Wait();
                Console.SetCursorPosition(0, cursorTop + 2);
                Console.Write(Colors.Dark + "" +
                "            ┌────────┐\n" +
               $"            │ {Colors.Rain}BRAKES{Colors.Dark} │\n" +
                "            └────────┘");
            }
            Task.Delay(miniGameBrakes - difficulty - (int)(miniGameRain / 1.5)).Wait();
            Console.SetCursorPosition(0, cursorTop + 2);
            Console.Write(Colors.Text + "" +
                "            ┌────────┐\n" +
               $"            │ {Colors.Custom(255, 100, 70)}BRAKES{Colors.Text} │\n" +
                "            └────────┘\n\n");
            stopwatch.Start();
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.S)
                stopwatch.Stop();
            Task.Delay(700).Wait();
            if (stopwatch.IsRunning)
                stopwatch.Stop();
            Console.Write("Your time ");
            #region scoreing system
            if (stopwatch.ElapsedMilliseconds < 3 && key.Key == ConsoleKey.S)
            {
                Console.Write($"\r[S] was pressed preemptively");
                score = -6;
            }
            else if (stopwatch.ElapsedMilliseconds < 201 && key.Key == ConsoleKey.S)
            {
                Console.Write(Colors.Magenta + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 4;
            }
            else if (stopwatch.ElapsedMilliseconds < 251 && key.Key == ConsoleKey.S)
            {
                Console.Write(Colors.Green + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 3;
            }
            else if (stopwatch.ElapsedMilliseconds < 266 && key.Key == ConsoleKey.S)
            {
                Console.Write(Colors.Green + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 2;
            }
            else if (stopwatch.ElapsedMilliseconds < 286 && key.Key == ConsoleKey.S)
            {
                Console.Write(Colors.Green + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 1;
            }
            else if (stopwatch.ElapsedMilliseconds < 301 && key.Key == ConsoleKey.S)
            {
                Console.Write(Colors.Green + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 1;
            }
            else if (stopwatch.ElapsedMilliseconds < 311 && key.Key == ConsoleKey.S)
            {
                Console.Write(Colors.Sun + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 0;
            }
            else if (stopwatch.ElapsedMilliseconds < 401 && key.Key == ConsoleKey.S)
            {
                Console.Write(Colors.Red + $"{stopwatch.ElapsedMilliseconds}ms");
                score = -1;
            }
            else if (stopwatch.ElapsedMilliseconds < 501 && key.Key == ConsoleKey.S)
            {
                Console.Write(Colors.Red + $"{stopwatch.ElapsedMilliseconds}ms");
                score = -2;
            }
            else if (stopwatch.ElapsedMilliseconds < 801 && key.Key == ConsoleKey.S)
            {
                Console.Write(Colors.Red + $"{stopwatch.ElapsedMilliseconds}ms");
                score = -3;
            }
            else if (stopwatch.ElapsedMilliseconds > 800 && key.Key == ConsoleKey.S)
            {
                Console.Write(Colors.Red + $"{stopwatch.ElapsedMilliseconds}ms");
                score = -4;
            }
            else
            {
                Console.Write($"\rYou pressed the wrong button\n{Colors.LessGray}Specifically [{key.Key}]");
                score = -10;
            }
            #endregion
            Console.Write(Colors.Dark + " [Enter]");
            Util.KeyAdvance(ConsoleKey.Enter);
            return score;
        }
        public static int BoxBox()
        {
            Random rnd = new();
            int badPitRnd = rnd.Next(30 - Data.Difficulty), stopTime, score;
            Console.Write("Box, box\n" + Colors.Gray + "Hope for a good stop" + Colors.Dark + " [Enter]");
            Util.KeyAdvance(ConsoleKey.Enter);
            Console.SetCursorPosition(Console.CursorLeft - 8, Console.CursorTop);
            Console.WriteLine("         \n");
            if (badPitRnd == 0)
                stopTime = rnd.Next(6000, 10000);
            else if (badPitRnd <= 5)
                stopTime = rnd.Next(3500, 6000);
            else if (badPitRnd == 29)
                stopTime = rnd.Next(1980, 2100);
            else
                stopTime = rnd.Next(2000, 3500);
            Assets.ColorStopwatch(stopTime);
            if (-(stopTime / 1000) < -6)
                score = -6;
            else
                score = -(stopTime / 1000);
            Console.Write(Colors.Dark + "[Enter]");
            while (Console.KeyAvailable)
                Console.ReadKey(false);
            Util.KeyAdvance(ConsoleKey.Enter);
            return score;
        }
        public static int Speed(WeatherSet.Weather weather)
        {
            ConsoleKeyInfo key;
            int speed = 0, change = 0, score, difficulty = Data.Difficulty * 4;
            Stopwatch stopwatch = new();
            Stopwatch stopwatchBG = new();
            Random random = new();
            string color = Colors.Red, zeros = "000";
            var clues = new List<string> { Colors.Rain, Colors.Rain, Colors.Rain, Colors.Rain };
            var keyList = new List<ConsoleKey> { ConsoleKey.Z, ConsoleKey.X, ConsoleKey.C, ConsoleKey.V };
            var rndPattern = keyList.OrderBy(z => random.Next()).ToList();
            for (int i = 1; i < 5 && !(weather is (WeatherSet.Weather)1 or (WeatherSet.Weather)2 or (WeatherSet.Weather)3); i++)
            {
                switch (rndPattern[i - 1])
                {
                    case ConsoleKey.Z:
                        clues[0] = $"\x1b[38;2;{250 - i * 10};0;0m";
                        break;
                    case ConsoleKey.X:
                        clues[1] = $"\x1b[38;2;{250 - i * 10};0;0m";
                        break;
                    case ConsoleKey.C:
                        clues[2] = $"\x1b[38;2;{250 - i * 10};0;0m";
                        break;
                    case ConsoleKey.V:
                        clues[3] = $"\x1b[38;2;{250 - i * 10};0;0m";
                        break;
                }
            }
            var rndSwitch = new List<int> { random.Next(40 - difficulty, 75 + difficulty), random.Next(150 - difficulty, 225 + difficulty), random.Next(285 - difficulty, 315 + difficulty), 400 };
            Console.Write(Colors.Text + $"I am Sp{clues[0]}e{clues[1]}e{clues[2]}e{clues[3]}e{Colors.Text}d\n{Colors.Gray}Keys will light up randomly\nPress them to accelerate" + Colors.Dark + " [Enter]\n\n" + Colors.Grayer +
                "  ┌───┐  ┌───┐  ┌───┐  ┌───┐\n" +
                "  │ Z │  │ X │  │ C │  │ V │\n" +
                "  └───┘  └───┘  └───┘  └───┘\n\n" + Colors.Text +
               $"Speed {Colors.Grayer}000 {Colors.Text}KM/H");
            Util.KeyAdvance(ConsoleKey.Enter);
            Console.SetCursorPosition(25, Console.CursorTop - 6);
            Console.Write("         ");
            Console.SetCursorPosition(0, Console.CursorTop + 6);
            stopwatchBG.Start();
            while (stopwatchBG.ElapsedMilliseconds / 27 <= 385)
            {
                speed = (int)(stopwatch.ElapsedMilliseconds / 27);
                switch (rndPattern[change])
                {
                    case ConsoleKey.Z:
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.Write("" +
                            $"  {Colors.LessGray}┌───┐  {Colors.Grayer}┌───┐  ┌───┐  ┌───┐\n" +
                            $"  {Colors.LessGray}│ {color}Z {Colors.LessGray}│  {Colors.Grayer}│ X │  │ C │  │ V │\n" +
                            $"  {Colors.LessGray}└───┘  {Colors.Grayer}└───┘  └───┘  └───┘\n" + Colors.Text + '\n');
                        break;
                    case ConsoleKey.X:
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.Write("" +
                            $"  {Colors.Grayer}┌───┐  {Colors.LessGray}┌───┐  {Colors.Grayer}┌───┐  ┌───┐\n" +
                            $"  {Colors.Grayer}│ Z │  {Colors.LessGray}│ {color}X {Colors.LessGray}│  {Colors.Grayer}│ C │  │ V │\n" +
                            $"  {Colors.Grayer}└───┘  {Colors.LessGray}└───┘  {Colors.Grayer}└───┘  └───┘\n" + Colors.Text + '\n');
                        break;
                    case ConsoleKey.C:
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.Write("" +
                            $"  {Colors.Grayer}┌───┐  ┌───┐  {Colors.LessGray}┌───┐  {Colors.Grayer}┌───┐\n" +
                            $"  {Colors.Grayer}│ Z │  │ X │  {Colors.LessGray}│ {color}C {Colors.LessGray}│  {Colors.Grayer}│ V │\n" +
                            $"  {Colors.Grayer}└───┘  └───┘  {Colors.LessGray}└───┘  {Colors.Grayer}└───┘\n" + Colors.Text + '\n');
                        break;
                    case ConsoleKey.V:
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.Write("" +
                            $"  {Colors.Grayer}┌───┐  ┌───┐  ┌───┐  {Colors.LessGray}┌───┐\n" +
                            $"  {Colors.Grayer}│ Z │  │ X │  │ C │  {Colors.LessGray}│ {color}V {Colors.LessGray}│\n" +
                            $"  {Colors.Grayer}└───┘  └───┘  └───┘  {Colors.LessGray}└───┘\n" + Colors.Text + '\n');
                        break;
                }
                if (speed < 10)
                    zeros = "00";
                else if (speed < 100)
                    zeros = "0";
                else
                    zeros = "";
                Console.Write($"Speed {Colors.Grayer + zeros + color + speed + Colors.Text} KM/H");
                if (stopwatchBG.ElapsedMilliseconds / 27 > rndSwitch[change])
                { change = Math.Min(change + 1, 3); stopwatch.Stop(); color = Colors.Red; }
                if (Console.KeyAvailable)
                {
                    color = Colors.Green;
                    key = Console.ReadKey(true);
                    if (key.Key != rndPattern[change])
                    { stopwatch.Stop(); color = Colors.Red; }
                    else if (key.Key == rndPattern[change] && stopwatch.IsRunning == false)
                        stopwatch.Start();
                }
            }
            stopwatch.Stop();
            stopwatchBG.Stop();
            if (speed > 360)
            {
                score = 5;
                Console.Write(" · " + Colors.Red + "You are SPEED!");
            }
            else if (speed > 354)
            {
                score = 3;
                Console.Write(" · " + Colors.Magenta + "Perfect!");
            }
            else if (speed > 349)
            {
                score = 2;
                Console.Write(" · Great!");
            }
            else if (speed > 344)
            {
                score = 1;
                Console.Write(" · Good");
            }
            else if (speed > 339)
            {
                score = 0;
                Console.Write(" · Nice");
            }
            else if (speed > 329)
            {
                score = -1;
                Console.Write(" · Aight");
            }
            else if (speed > 319)
            {
                score = -2;
                Console.Write(" · Could be better");
            }
            else if (speed > 249)
            {
                score = -3;
                Console.Write(" · " + Colors.Sun + "Slow");
            }
            else if (speed == 0)
            {
                score = -19;
                Console.Write(" · " + Colors.Red + "You are stationary");
            }
            else
            {
                score = -5;
                Console.Write(" · " + Colors.Red + "Very slow");
            }
            Util.KeyAdvance(ConsoleKey.Enter);
            return score;
        }
        public static int Overtake(string color, int otherDriverNumber, int userDriverNumber, Weather weather)
        {
            ConsoleKeyInfo key;
            int otherDriver = 0, 
                score = 0, 
                userNumber = 1, 
                win = 50,
                crash = 90;
            for (int i = 0; i < 20; i++)
            {
                if (otherDriverNumber == Data.DriverNumbers()[i])
                    otherDriver = i;
            }
            int comNumber = ComNumber(Math.Min(100, (int)Data.DriverData()[otherDriver].Item6.Item2 * 10), Math.Max(0, (int)weather));
            string otherColor = Colors.Teams(otherDriver / 2), doubleCrash = "", rainColor = "", plusMinus = "",
            comNumberString = comNumber < 100 ? Colors.Gray + '0' + otherColor + comNumber.ToString() : otherColor + comNumber.ToString();
            comNumberString = comNumber < 10 ? Colors.Gray + '0' + comNumberString : comNumberString;
            if ((int)weather > 0)
            {
                win -= (int)weather * 5;
                crash -= (int)weather * 5;
                rainColor = Colors.Rain;
                doubleCrash = Colors.Rain + " or are adjacent";
                plusMinus = " ± 1";
            }
            string[] rules = { Colors.Gray + 
                    "Pick a number & press [Enter]", Colors.Gray + 
                    $"If the difference is ≤ {rainColor + win}" , Colors.Gray + 
                    " Higher number wins", Colors.Gray +
                    $"If the difference is {rainColor + (win + 1) + Colors.Gray + '-' + rainColor + crash}", Colors.Gray + 
                    " Higher number pits", Colors.Gray +
                    $"If the difference is > {rainColor}{crash}", Colors.Gray + 
                    " Higher number crashes", Colors.Gray + 
                    $"if numbers match{rainColor + doubleCrash + Colors.Gray}, both crash"},
            otherCar = Assets.Car(otherColor, Data.DriverData()[otherDriver].Item4),
            yourCar = Assets.Car(color, userDriverNumber);
            Console.WriteLine(Colors.Text + $"Overtake VS {otherColor + Data.DriverData()[otherDriver].Item2}");
            for (int i = 0; i < rules.Length; i++)
            {
                Console.SetCursorPosition(40, 5 + i);
                Console.WriteLine(rules[i]);
            }
            if ((int)weather > 0)
            {
                Console.SetCursorPosition(40, Console.CursorTop + 1);
                Console.WriteLine(Colors.Rain + $"Rain effect{Colors.Gray}: Incidents are more common");
            }
            if (color == otherColor)
            {
                string name = Data.DriverData()[otherDriver].Item3.Split(' ')[0];
                Console.SetCursorPosition(40, Console.CursorTop + 1);
                Console.WriteLine(Colors.Gray + $"Since {color + name + Colors.Gray} is your teammate");
                Console.SetCursorPosition(40, Console.CursorTop);
                Console.WriteLine(Colors.Gray + " you can see part of his number");
            }
            Console.SetCursorPosition(0, 6);
            for (int i = 0; i < otherCar.Length; i++)
            {
                Console.SetCursorPosition(23, Console.CursorTop + 1);
                Console.Write(otherCar[i]);
            }
            Console.SetCursorPosition(0, Console.CursorTop - 7);
            for (int i = 0; i < yourCar.Length; i++)
            {
                Console.SetCursorPosition(4, Console.CursorTop + 1);
                Console.Write(yourCar[i]);
            }
            Console.SetCursorPosition(26, 5);
            Console.Write(Colors.Gray + "| 000 |");
            if (otherColor == color)
            {
                Console.SetCursorPosition(30, 5);
                Console.Write(Colors.LessGray + comNumberString.Remove(0, comNumberString.Length - 1));
            }
            Util.ClearKey();
            for (bool numberPicked = false; numberPicked == false;)
            {
                Console.Write(color + "\r" + Colors.LessGray + "       < ");
                if (userNumber < 10)
                    Console.Write(Colors.Gray + "00");
                else if (userNumber < 100)
                    Console.Write(Colors.Gray + 0);
                Console.Write(color + userNumber + Colors.LessGray + " >");
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                    userNumber = Math.Max(userNumber - 10, 1);
                else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                    userNumber = Math.Min(userNumber + 10, 100);
                else if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D)
                    userNumber = Math.Min(userNumber + 1, 100);
                else if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A)
                    userNumber = Math.Max(userNumber - 1, 1);
                if (key.Key == ConsoleKey.Enter)
                    numberPicked = true;
                if (Console.KeyAvailable)
                    Console.ReadKey(false);
            }
            Console.SetCursorPosition(28, Console.CursorTop);
            Console.Write(comNumberString + Colors.Text);
            Console.SetCursorPosition(0, 21);
            if (comNumber == userNumber || (comNumber == userNumber - 1 && (int)weather > 0) || (comNumber == userNumber + 1 && (int)weather > 0))
            {
                Console.WriteLine($"({color + userNumber + Colors.Text} = {otherColor + comNumber + Colors.Text + plusMinus}) · Double crash!");
                score = -210;
            }
            else if (comNumber - userNumber > crash)
            {
                Console.WriteLine($"({otherColor + comNumber + Colors.Text} - {color + userNumber + Colors.Text}) > {crash} · {Data.DriverData()[otherDriver].Item2} crashed");
                score = -201;
            }
            else if (userNumber - comNumber > crash)
            {
                Console.WriteLine($"({color + userNumber + Colors.Text} - {otherColor + comNumber + Colors.Text}) > {crash} · You crashed");
                score = -10;
            }
            else if (comNumber - userNumber > win)
            {
                Console.WriteLine($"({otherColor + comNumber + Colors.Text} - {color + userNumber + Colors.Text}) > {win} · {Data.DriverData()[otherDriver].Item2} needs to pit");
                score = -99;
            }
            else if (userNumber - comNumber > win)
            {
                Console.WriteLine($"({color + userNumber + Colors.Text} - {otherColor + comNumber + Colors.Text}) > {win} · You need to pit");
                score = -102;
            }
            else if (userNumber > comNumber)
            {
                Console.WriteLine($"({color + userNumber + Colors.Text} - {otherColor + comNumber + Colors.Text}) ≤ {win} · You passed {Data.DriverData()[otherDriver].Item2}");
                score = (userNumber - comNumber) / 10 + 1;
            }
            else if (userNumber < comNumber)
            {
                Console.WriteLine($"({otherColor + comNumber + Colors.Text} - {color + userNumber + Colors.Text}) ≤ {win} · {Data.DriverData()[otherDriver].Item2} remains ahead");
                score = (userNumber - comNumber) / 10;
            }
            Util.KeyAdvance(ConsoleKey.Enter);
            return score;
        }
        public static int ComNumber(int driverOverall, int weather)
        {
            Random rnd = new();
            bool randomAction = rnd.Next(3) == 0;
            int finalScore;
            Dictionary<int, int> algorithmNumbersOne = new(),
                                 algorithmNumbersTwo = new();
            for (int i = 1; i < 101; i++)
            {
                finalScore = 0;
                for (int j = 1; j < 101; j++)
                    finalScore += OvertakeSimulation(i, weather, j);
                algorithmNumbersOne.Add(i, finalScore);
            }
            var algorithmNumbersTest = algorithmNumbersOne.OrderByDescending(x => x.Value).Take(driverOverall).ToList();
            for (int i = 1; i < 101; i++)
            {
                finalScore = 0;
                for (int j = 0; j < driverOverall; j++)
                    finalScore += OvertakeSimulation(i, weather, algorithmNumbersTest[j].Key);
                algorithmNumbersTwo.Add(i, finalScore);
            }
            var topAlgorithmNumbers = randomAction
                ? algorithmNumbersOne.OrderByDescending(x => x.Value).Take(driverOverall).ToList()
                : algorithmNumbersTwo.OrderByDescending(x => x.Value).Take(driverOverall).ToList();
            return topAlgorithmNumbers[rnd.Next(topAlgorithmNumbers.Count)].Key;
        }
        public static int OvertakeSimulation(int user, int weather, int oponent)
        {
            int score = 0, win = 50, crash = 90;
            if (weather > 0)
            {
                win -= weather * 5;
                crash -= weather * 5;
            }
            if (oponent == user || (oponent == user - 1 && weather > 0) || (oponent == user + 1 && weather > 0))
                score = -20;
            else if (oponent - user > crash)
                score = 1;
            else if (user - oponent > crash)
                score = -20;
            else if (oponent - user > win)
                score = 2;
            else if (user - oponent > win)
                score = -2;
            else if (user > oponent)
                score = (user - oponent) / 10 + 1;
            else if (user < oponent)
                score = (user - oponent) / 10;
            return score;
        }
        public static int GearUp(int line)
        {
            ConsoleKeyInfo key;
            Stopwatch stopwatch = new();
            int score, gear = 0, midLine, difficulty = Data.Difficulty - 1;
            char gearPart;
            bool rightTimeing = false, pointerDirection = true;
            string fullGears = Colors.Grayer + "  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █\n══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █";
            Console.WriteLine(Colors.Grayer + "Gearing Up↑\n" + Colors.Gray + "Gear up to 8th as fast as possible\nPress [Space] when the pointer is in the middle" + Colors.Dark + " [Enter]" + "\n\n  1   2   3   4   5   6   7   8\n\n" + fullGears);
            Util.KeyAdvance(ConsoleKey.Enter);
            Console.SetCursorPosition(47, line - 4);
            Console.Write("         ");
            stopwatch.Start();
            for (short i = 1; i < 9; i++)
            {
                gear = i - 1;
                rightTimeing = false;
                for (short j = 0; rightTimeing == false;)
                {
                    midLine = i == 1 ? 2 : 3;
                    gearPart = '█';
                    if (j == 2 && i == 8)
                        gearPart = '╣';
                    else if (j == 2)
                        gearPart = '╬';
                    if (j == 2)
                    {
                        for (short k = 1; k !<= midLine; k++)
                        {
                            Console.SetCursorPosition(i * 4 - (2 + k), line + 2);
                            Console.Write(Colors.Text + '═');
                        }
                    } 
                    Console.SetCursorPosition(i * 4 - 2, line + j);
                    Console.Write(Colors.Text + gearPart);
                    Task.Delay(170 - i * 10 - difficulty * 5).Wait();
                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey(true);
                        if (key.Key != ConsoleKey.Spacebar || j != 2)
                            break;
                        else
                        { rightTimeing = true; break; }
                    }
                    if (j == 2)
                    {
                        for (short k = 1; k! <= midLine; k++)
                        {
                            Console.SetCursorPosition(i * 4 - (2 + k), line + 2);
                            Console.Write(Colors.Grayer + '═');
                        }
                    }
                    Console.SetCursorPosition(i * 4 - 2, line + j);
                    Console.Write(Colors.Grayer + gearPart);
                    if (pointerDirection && j == 4 || !pointerDirection && j == 0)
                        pointerDirection = !pointerDirection;
                    if (pointerDirection)
                        j++;
                    else if (!pointerDirection)
                        j--;
                }
                if (!rightTimeing)
                    break;
            }
            stopwatch.Stop();
            Console.SetCursorPosition(0, line + 6);
            if (rightTimeing == true)
            {
                string time = stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds;
                if (stopwatch.Elapsed.Milliseconds < 10)
                    time = stopwatch.Elapsed.Seconds + ".00" + stopwatch.Elapsed.Milliseconds;
                else if (stopwatch.Elapsed.Milliseconds < 100)
                    time = stopwatch.Elapsed.Seconds + ".0" + stopwatch.Elapsed.Milliseconds;
                if (stopwatch.ElapsedMilliseconds < 3350)
                {
                    Console.WriteLine(Colors.Text + "Perfect acceleration\n" + Colors.Text + "Your Time " + Colors.Magenta + time + Colors.Dark + " [Enter]" + Colors.Magenta);
                    score = 3;
                }
                else if (stopwatch.ElapsedMilliseconds < 3900)
                {
                    Console.WriteLine(Colors.Text + "Good acceleration\n" + Colors.Text + "Your Time " + Colors.Green + time + Colors.Dark + " [Enter]" + Colors.Green);
                    score = 1;
                }
                else if (stopwatch.ElapsedMilliseconds < 5500)
                {
                    Console.WriteLine(Colors.Text + "Normal acceleration\nYour Time " + time + Colors.Dark + " [Enter]" + Colors.Text);
                    score = 0;
                }
                else if (stopwatch.ElapsedMilliseconds < 8850)
                {
                    Console.WriteLine(Colors.Text + "Bad acceleration\nYour Time " + Colors.Sun + time + Colors.Dark + " [Enter]" + Colors.Sun);
                    score = -1;
                }
                else
                {
                    Console.WriteLine(Colors.Text + "Snale pace\nYour Time " + Colors.Red + time + Colors.Dark + " [Enter]" + Colors.Red);
                    score = -3;
                }
                Console.SetCursorPosition(0, line + 2);
                Console.Write("══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣");
            }
            else
            {
                Console.Write("You got to gear " + Colors.Red + gear + Colors.Dark + " [Enter]");
                if (gear != 0)
                {
                    Console.SetCursorPosition(gear * 4 - 2, line - 2);
                    Console.Write(Colors.Red + gear);
                }
                Console.SetCursorPosition(0, line + 6);
                score = -8 + gear;
            }
            Util.KeyAdvance(ConsoleKey.Enter);
            return score;
        }
        public static int FastestLap(int circuit, WeatherSet.Weather weather)
        {
            ConsoleKeyInfo key;
            Stopwatch stopwatch = new();
            Random rnd = new();
            int lives = 6 - Data.Difficulty, score;
            var currentCircuit = CircuitKeyLists.CircuitKeyList(circuit);
            if ((int)weather > 0)
                currentCircuit.RemoveAll(item => item == "D ");
            for (int i = 0; i < (int)weather && (int)weather > 0; i++)
            {
                int random = rnd.Next(2);
                int randomPos = rnd.Next(currentCircuit.Count);
                if (random == 0)
                    currentCircuit.Insert(randomPos, Colors.Rain + "< " + Colors.Gray);
                else if (random == 1)
                    currentCircuit.Insert(randomPos, Colors.Rain + "> " + Colors.Gray);
            }
            Console.WriteLine(Colors.Magenta + "Fastest Lap\n" + Colors.Gray + $"Press the keys in the right order");
            if ((int)weather > 0)
                Console.WriteLine($"{Colors.Rain}Rain effect{Colors.Gray}: Extra arrows and no DRS");
            Console.Write($"{Colors.Magenta}{QGraphics.Qlives(lives)}{Colors.Gray}You have {lives} ");
            if (lives == 1)
                Console.Write("life ");
            else
                Console.Write("lives ");
            Console.Write(Colors.Dark + "[Enter]");
            Util.KeyAdvance(ConsoleKey.Enter);
            Console.WriteLine($"\r{Colors.Magenta}{QGraphics.Qlives(lives)}                                                                                      \n" + Colors.Gray);
            for (int i = 0; i < currentCircuit.Count; i++)
                Console.Write(currentCircuit[i]);
            stopwatch.Start();
            while (stopwatch.IsRunning)
            {
                for (int i = 0; i < currentCircuit.Count; i++)
                {
                    var currentKey = ConsoleKey.D;
                    switch (currentCircuit[i])
                    {
                        case "< ":
                            currentKey = ConsoleKey.LeftArrow;
                            break;
                        case "> ":
                            currentKey = ConsoleKey.RightArrow;
                            break;
                        case "\x1b[38;2;107;186;230m> \x1b[38;5;245m":
                            currentKey = ConsoleKey.RightArrow;
                            break;
                        case "\x1b[38;2;107;186;230m< \x1b[38;5;245m":
                            currentKey = ConsoleKey.LeftArrow;
                            break;
                        case "E ":
                            currentKey = ConsoleKey.E;
                            break;
                        case "R ":
                            currentKey = ConsoleKey.R;
                            break;
                        case "O ":
                            currentKey = ConsoleKey.O;
                            break;
                    }
                    do
                    {
                        key = Console.ReadKey(true);
                        int oldLives = lives;
                        if (key.Key != currentKey) { lives--; }
                        if (lives < oldLives)
                        {
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                            Console.WriteLine(Colors.Magenta + '\r' + QGraphics.Qlives(lives) + " \n");
                        }
                        if (lives == 0) { break; }
                    } while (key.Key != currentKey);
                    if (lives == 0) { break; }
                    Console.Write('\r');
                    for (int j = 0; j <= i; j++)
                    {
                        if (currentCircuit[j] is "\x1b[38;2;107;186;230m< \x1b[38;5;245m")
                            Console.Write(Colors.Magenta + "< ");
                        else if (currentCircuit[j] is "\x1b[38;2;107;186;230m> \x1b[38;5;245m")
                            Console.Write(Colors.Magenta + "> ");
                        else
                            Console.Write(Colors.Magenta + currentCircuit[j]);
                    }
                }
                stopwatch.Stop();
            }
            if (stopwatch.IsRunning) { stopwatch.Stop(); }
            double time = stopwatch.ElapsedMilliseconds, multi = currentCircuit.Count / (time / 1000);
            Console.Write(Colors.Text + "\n\nYour Time ");
            if (lives == 0)
            { Console.Write($"\r{Colors.Red}Shunt! {Colors.Text}You're out"); score = -19; }
            else if (multi > 7.3)
            { Console.Write(Colors.Gold + time / 1000 + Colors.Text + " · " + Colors.Gold + "Perfect Lap!\n" + Colors.Text + "Might be a new record"); score = 6; }
            else if (multi > 6)
            { Console.Write(Colors.Magenta + time / 1000 + Colors.Text + " · Great Lap\nYou got the fastest lap"); score = 3; }
            else if (multi > 5)
            { Console.Write(time / 1000 + " · Good Lap\nBut not enough"); score = 1; }
            else if (multi > 3.3)
            { Console.Write(time / 1000 + " · Not enough"); score = 0; }
            else if (multi > 2.2)
            { Console.Write(Colors.Red + time / 1000 + Colors.Text + " · Not good"); score = -1; }
            else
            { Console.Write($"\r{Colors.Gray}You fell asleep"); score = -5; }
            Console.Write(Colors.Dark + " [Enter]");
            Util.KeyAdvance(ConsoleKey.Enter);
            return score;
        }
    }
}