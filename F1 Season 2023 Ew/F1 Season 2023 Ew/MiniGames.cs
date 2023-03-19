using System.Diagnostics;

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
            Console.Write("Five " + Colors.Teams()[2] + "Red " + Colors.White + "Lights" + Colors.Gray + "\nPress [W] as soon as the red lights go out" + Colors.Dark + " [Enter]");
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
                Console.Write($"{Colors.Teams()[2]}False Start\n{Colors.LessGray}You've been penalised with a 5 second penalty");
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
                    Console.Write(Colors.Teams()[2] + $"{stopwatch.ElapsedMilliseconds}ms");
                else
                    Console.Write(Colors.Teams()[2] + "\rYou are stationary");
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
            Console.Write('\n' + Colors.White + "It's lights out and away we go" + Colors.Dark + " [Enter]");
            Util.KeyAdvance(ConsoleKey.Enter);
            return score;
        }
        public static int DRS()
        {
            Random rnd = new();
            Stopwatch stopwatch = new();
            ConsoleKeyInfo key;
            int miniGameDRS = rnd.Next(2860, 7650), score, difficulty = Data.Difficulty * 200;
            Console.Write("Turning On" + Colors.Green + " DRS\n" + Colors.Gray + "Press [D] only when DRS turns green" + Colors.Dark + " [Enter]\n\n" + 
                "             ┌─────┐\n" +
                "             │ DRS │\n" +
                "             └─────┘");
            Util.KeyAdvance(ConsoleKey.Enter);
            Console.SetCursorPosition(36, Console.CursorTop - 4);
            Console.WriteLine("         " + '\n');
            Task.Delay(miniGameDRS - difficulty).Wait();
            Console.Write(Colors.Gray + "" +
                "             ┌─────┐\n" +
               $"             │ {Colors.Green}DRS{Colors.Gray} │\n" +
                "             └─────┘\n\n" + Colors.White);
            stopwatch.Start();
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.D)
                stopwatch.Stop();
            Task.Delay(700).Wait();
            if (stopwatch.IsRunning)
                stopwatch.Stop();
            Console.Write("Your time ");
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
                Console.Write(Colors.Teams()[3] + $"{stopwatch.ElapsedMilliseconds}ms");
                score = 0;
            }
            else if (stopwatch.ElapsedMilliseconds < 401 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Teams()[2] + $"{stopwatch.ElapsedMilliseconds}ms");
                score = -1;
            }
            else if (stopwatch.ElapsedMilliseconds < 501 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Teams()[2] + $"{stopwatch.ElapsedMilliseconds}ms");
                score = -2;
            }
            else if (stopwatch.ElapsedMilliseconds < 801 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Teams()[2] + $"{stopwatch.ElapsedMilliseconds}ms");
                score = -4;
            }
            else if (stopwatch.ElapsedMilliseconds > 800 && key.Key == ConsoleKey.D)
            {
                Console.Write(Colors.Teams()[2] + $"{stopwatch.ElapsedMilliseconds}ms");
                score = -5;
            }
            else
            {
                Console.Write($"\rYou pressed the wrong button\n{Colors.LessGray}Specifically [{key.Key}]");
                score = -10;
            }
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
        public static int Speed()
        {
            ConsoleKeyInfo key;
            int speed = 0, change = 0, score, difficulty = Data.Difficulty * 4;
            Stopwatch stopwatch = new();
            Stopwatch stopwatchBG = new();
            Random random = new();
            string color = Colors.Teams()[2], zeros = "000";
            var clues = new List<string> { "", "", "", "" };
            var keyList = new List<ConsoleKey> { ConsoleKey.Z, ConsoleKey.X, ConsoleKey.C, ConsoleKey.V };
            var rndPattern = keyList.OrderBy(z => random.Next()).ToList();
            for (int i = 1; i < 5; i++)
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
            Console.Write(Colors.White + $"I am Sp{clues[0]}e{clues[1]}e{clues[2]}e{clues[3]}e{Colors.White}d\n{Colors.Gray}Keys will light up randomly\nPress them to accelerate" + Colors.Dark + " [Enter]\n\n" + Colors.Grayer +
                "  ┌───┐  ┌───┐  ┌───┐  ┌───┐\n" +
                "  │ Z │  │ X │  │ C │  │ V │\n" +
                "  └───┘  └───┘  └───┘  └───┘\n\n" + Colors.White +
               $"Speed {Colors.Grayer}000 {Colors.White}KM/H");
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
                            $"  {Colors.LessGray}└───┘  {Colors.Grayer}└───┘  └───┘  └───┘\n" + Colors.White + '\n');
                        break;
                    case ConsoleKey.X:
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.Write("" +
                            $"  {Colors.Grayer}┌───┐  {Colors.LessGray}┌───┐  {Colors.Grayer}┌───┐  ┌───┐\n" +
                            $"  {Colors.Grayer}│ Z │  {Colors.LessGray}│ {color}X {Colors.LessGray}│  {Colors.Grayer}│ C │  │ V │\n" +
                            $"  {Colors.Grayer}└───┘  {Colors.LessGray}└───┘  {Colors.Grayer}└───┘  └───┘\n" + Colors.White + '\n');
                        break;
                    case ConsoleKey.C:
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.Write("" +
                            $"  {Colors.Grayer}┌───┐  ┌───┐  {Colors.LessGray}┌───┐  {Colors.Grayer}┌───┐\n" +
                            $"  {Colors.Grayer}│ Z │  │ X │  {Colors.LessGray}│ {color}C {Colors.LessGray}│  {Colors.Grayer}│ V │\n" +
                            $"  {Colors.Grayer}└───┘  └───┘  {Colors.LessGray}└───┘  {Colors.Grayer}└───┘\n" + Colors.White + '\n');
                        break;
                    case ConsoleKey.V:
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.Write("" +
                            $"  {Colors.Grayer}┌───┐  ┌───┐  ┌───┐  {Colors.LessGray}┌───┐\n" +
                            $"  {Colors.Grayer}│ Z │  │ X │  │ C │  {Colors.LessGray}│ {color}V {Colors.LessGray}│\n" +
                            $"  {Colors.Grayer}└───┘  └───┘  └───┘  {Colors.LessGray}└───┘\n" + Colors.White + '\n');
                        break;
                }
                if (speed < 10)
                    zeros = "00";
                else if (speed < 100)
                    zeros = "0";
                else
                    zeros = "";
                Console.Write($"Speed {Colors.Grayer + zeros + color + speed + Colors.White} KM/H");
                if (stopwatchBG.ElapsedMilliseconds / 27 > rndSwitch[change])
                { change = Math.Min(change + 1, 3); stopwatch.Stop(); color = Colors.Teams()[2]; }
                if (Console.KeyAvailable)
                {
                    color = Colors.Green;
                    key = Console.ReadKey(true);
                    if (key.Key != rndPattern[change])
                    { stopwatch.Stop(); color = Colors.Teams()[2]; }
                    else if (key.Key == rndPattern[change] && stopwatch.IsRunning == false)
                        stopwatch.Start();
                }
            }
            stopwatch.Stop();
            stopwatchBG.Stop();
            if (speed > 354)
            {
                score = 3;
                Console.Write(" · " + Colors.Gold + "Perfect!");
            }
            else if (speed > 349)
            {
                score = 3;
                Console.Write(Colors.White + " · Great!");
            }
            else if (speed > 344)
            {
                score = 2;
                Console.Write(Colors.White + " · Good");
            }
            else if (speed > 339)
            {
                score = 1;
                Console.Write(Colors.White + " · Nice");
            }
            else if (speed > 329)
            {
                score = 0;
                Console.Write(Colors.White + " · Aight");
            }
            else if (speed > 299)
            {
                score = -1;
                Console.Write(Colors.White + " · Could be better");
            }
            else if (speed > 249)
            {
                score = -3;
                Console.Write(" · " + Colors.Teams()[3] + "Slow");
            }
            else if (speed == 0)
            {
                score = -19;
                Console.Write(" · " + Colors.Teams()[2] + "You are stationary");
            }
            else
            {
                score = -5;
                Console.Write(" · " + Colors.Teams()[2] + "Very slow");
            }
            Util.KeyAdvance(ConsoleKey.Enter);
            return score;
        }
        public static int GearUp(int line)
        {
            ConsoleKeyInfo key;
            Stopwatch stopwatch = new();
            int score, gear = 0, difficulty = Data.Difficulty - 1;
            char gearPart;
            bool rightTimeing = false, pointerDirection = true;
            string fullGears = Colors.Grayer + "  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █\n══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █";
            Console.WriteLine(Colors.Grayer + "Gearing Up\n" + Colors.Gray + "Gear up to 8th as fast as possible\nPress [Space] when the pointer is in the middle" + Colors.Dark + " [Enter]" + "\n\n  1   2   3   4   5   6   7   8\n\n" + fullGears);
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
                    short midLine = 3;
                    if (i == 1)
                        midLine = 2;
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
                            Console.Write(Colors.White + '═');
                        }
                    } 
                    Console.SetCursorPosition(i * 4 - 2, line + j);
                    Console.Write(Colors.White + gearPart);
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
                    Console.WriteLine(Colors.White + "Perfect acceleration\n" + Colors.White + "Your Time " + Colors.Teams()[7] + time + Colors.Dark + " [Enter]" + Colors.Teams()[7]);
                    score = 3;
                }
                else if (stopwatch.ElapsedMilliseconds < 3900)
                {
                    Console.WriteLine(Colors.White + "Good acceleration\n" + Colors.White + "Your Time " + Colors.Green + time + Colors.Dark + " [Enter]" + Colors.Green);
                    score = 1;
                }
                else if (stopwatch.ElapsedMilliseconds < 5500)
                {
                    Console.WriteLine(Colors.White + "Normal acceleration\nYour Time " + time + Colors.Dark + " [Enter]" + Colors.White);
                    score = 0;
                }
                else if (stopwatch.ElapsedMilliseconds < 8850)
                {
                    Console.WriteLine(Colors.White + "Bad acceleration\nYour Time " + Colors.Teams()[3] + time + Colors.Dark + " [Enter]" + Colors.Teams()[3]);
                    score = -1;
                }
                else
                {
                    Console.WriteLine(Colors.White + "Snale pace\nYour Time " + Colors.Teams()[2] + time + Colors.Dark + " [Enter]" + Colors.Teams()[2]);
                    score = -3;
                }
                Console.SetCursorPosition(0, line + 2);
                Console.Write("══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣");
            }
            else
            {
                Console.Write("You got to gear " + Colors.Teams()[2] + gear + Colors.Dark + " [Enter]");
                if (gear != 0)
                {
                    Console.SetCursorPosition(gear * 4 - 2, line - 2);
                    Console.Write(Colors.Teams()[2] + gear);
                }
                Console.SetCursorPosition(0, line + 6);
                score = -8 + gear;
            }
            Util.KeyAdvance(ConsoleKey.Enter);
            return score;
        }
        public static int FastestLap(int circuit)
        {
            ConsoleKeyInfo key;
            Stopwatch stopwatch = new();
            int lives = 6 - Data.Difficulty, score;
            var currentCircuit = CircuitKeyLists.CircuitKeyList(circuit);
            Console.Write(Colors.Magenta + "Fastest Lap\n" + Colors.Gray + $"Press the keys in the right order\n{Colors.Magenta}{QGraphics.Qlives(lives)}{Colors.Gray}You have {lives} ");
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
                        Console.Write(Colors.Magenta + currentCircuit[j]);
                }
                stopwatch.Stop();
            }
            if (stopwatch.IsRunning) { stopwatch.Stop(); }
            double time = stopwatch.ElapsedMilliseconds, multi = currentCircuit.Count / (time / 1000);
            Console.Write(Colors.White + "\n\nYour Time ");
            if (lives == 0)
            {
                Console.Write($"\r{Colors.Teams()[2]}Shunt! {Colors.White}You're out");
                score = -19;
            }
            else if (multi > 7)
            {
                Console.Write(Colors.Gold + time / 1000 + Colors.White + " · " + Colors.Gold + "Perfect Lap!\n" + Colors.White + "That might be a new record");
                score = 7;
            }
            else if (multi > 6.2)
            {
                Console.Write(Colors.Magenta + time / 1000 + Colors.White + " · Great Lap\nYou got the fastest lap");
                score = 3;
            }
            else if (multi > 5.89)
            {
                Console.Write(time / 1000 + " · Good Lap\nBut not enough");
                score = 1;
            }
            else if (multi > 4)
            {
                Console.Write(time / 1000 + " · Not enough");
                score = -1;
            }
            else if (multi > 2)
            {
                Console.Write(Colors.Teams()[2] + time / 1000 + Colors.White + " · Not good");
                score = -2;
            }
            else
            {
                Console.Write($"\r{Colors.Gray}You fell asleep");
                score = -6;
            }
            Console.Write(Colors.Dark + " [Enter]");
            Util.KeyAdvance(ConsoleKey.Enter);
            return score;
        }
    }
}