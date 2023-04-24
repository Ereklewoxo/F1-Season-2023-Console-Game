using System.Diagnostics;

namespace F1_Season_2023_Ew
{
    public static class CircuitKeyLists
    {
        public static List<string> CircuitKeyList(int circuit) => circuit switch
        {
             0 => new List<string> { "> ", "< ", "> ", "D ", "> ", "< ", "> ", "< ", "> ", "< ", "< ", "D ", "< ", "> ", "> ", "> ", "> ", "D " },
             1 => new List<string> { "< ", "> ", "< ", "< ", "> ", "< ", "< ", "> ", "> ", "< ", "> ", "< ", "< ", "> ", "< ", "> ", "< ", "< ", "> ", "D ", "< ", "> ", "< ", "> ", "> ", "D ", "< ", "< ", "< ", "D " },
             2 => new List<string> { "> ", "< ", "D ", "> ", "< ", "> ", "> ", "< ", "> ", "D ", "< ", "> ", "D ", "> ", "> ", "< ", "> ", "D " },
             3 => new List<string> { "< ", "< ", "D ", "< ", "> ", "< ", "> ", "> ", "< ", "> ", "< ", "> ", "< ", "< ", "< ", "< ", "< ", "> ", "< ", "> ", "> ", "D " },
             4 => new List<string> { "> ", "< ", "> ", "< ", "> ", "< ", "< ", "< ", "> ", "D ", "< ", "< ", "> ", "< ", "< ", "> ", "< ", "D ", "< ", "< ", "> ", "D " },
             5 => new List<string> { "> ", "< ", "> ", "< ", "< ", "> ", "< ", "> ", "< ", "< ", "> ", "> ", "< ", "> ", "< ", "> ", "< ", "< ", "D ", "> " },
             6 => new List<string> { "> ", "> ", "< ", "> ", "> ", "< ", "> ", "> ", "> ", "< ", "> ", "< ", "< ", "> ", "> ", "< ", "< ", "> ", "> ", "D " },
             7 => new List<string> { "> ", "< ", "> ", "> ", "> ", "< ", "< ", "< ", "> ", "> ", "D ", "< ", "< ", "> ", "> ", "> ", "D " },
             8 => new List<string> { "< ", "> ", "> ", "< ", "> ", "< ", "> ", "D ", "> ", "< ", "> ", "< ", "D ", "> ", "> ", "< ", "D " },
             9 => new List<string> { "> ", "D ", "< ", "> ", "D ", "> ", "> ", "< ", "< ", "> ", "> ", "> ", "D " },
            10 => new List<string> { "> ", "< ", "> ", "< ", "< ", "D ", "< ", "> ", "> ", "> ", "< ", "> ", "< ", "> ", "< ", "D ", "> ", "< ", "> ", "> " },
            11 => new List<string> { "> ", "D ", "< ", "> ", "< ", "> ", "> ", "< ", "< ", "> ", "< ", "> ", "> ", "< ", "> ", "D " },
            12 => new List<string> { "> ", "< ", "> ", "< ", "D ", "> ", "< ", "> ", "> ", "< ", "< ", "< ", "> ", "< ", "> ", "> ", "< ", "< ", "> ", "< ", "D " },
            13 => new List<string> { "> ", "> ", "< ", "> ", "< ", "> ", "> ", "> ", "> ", "< ", "D ", "> ", "< ", "> ", "< ", "D ", "> " },
            14 => new List<string> { "D ", "> ", "< ", "> ", "< ", "> ", "> ", "> ", "D ", "< ", "> ", "< ", "> " },
            15 => new List<string> { "< ", "> ", "< ", "< ", "> ", "D ", "> ", "< ", "> ", "< ", "< ", "> ", "< ", "< ", "D ", "> ", "< ", "> ", "< ", "< ", "> ", "> ", "< ", "< ", "< ", "D " },
            16 => new List<string> { "D ", "> ", "> ", "< ", "> ", "< ", "> ", "< ", "> ", "> ", "> ", "< ", "> ", "< ", "< ", "< ", "> ", "< ", "> " },
            17 => new List<string> { "> ", "< ", "> ", "> ", "> ", "< ", "> ", "< ", "> ", "< ", "< ", "> ", "> ", "> ", "< ", "> ", "D " },
            18 => new List<string> { "< ", "> ", "< ", "> ", "< ", "> ", "< ", "> ", "< ", "< ", "< ", "D ", "< ", "> ", "> ", "< ", "> ", "> ", "> ", "< ", "< ", "D " },
            19 => new List<string> { "D ", "> ", "< ", "> ", "D ", "< ", "> ", "> ", "< ", "> ", "< ", "> ", "< ", "D ", "> ", "< ", "> ", "< ", "> ", "> " },
            20 => new List<string> { "< ", "> ", "< ", "D ", "< ", "< ", "> ", "> ", "> ", "< ", "> ", "< ", "< ", "< ", "< ", "D ", "< " },
            21 => new List<string> { "< ", "< ", "> ", "> ", "D ", "> ", "< ", "< ", "> ", "< ", "> ", "< ", "< ", "D ", "< ", "< ", "> ", "< ", "< " },
            22 => new List<string> { "< ", "< ", "> ", "< ", "< ", "D ", "< ", "> ", "< ", "D ", "< ", "> ", "> ", "> ", "< ", "< ", "> ", "> " },
            23 => new List<string> { "> ", "> ", "> ", "< ", "D ", "< ", "< ", "> ", "> ", "< ", "> ", "> ", "< ", "< ", "> ", "> ", "D " },
             _ => new List<string> { "E ", "R ", "R ", "O ", "R " }
        };
    }
    public static class QGraphics
    {
        public static string Qlives(int lives) => lives switch
        {
            1 => $"{Colors.Red}♦ ",
            2 => "♦ ♦ ",
            3 => "♦ ♦ ♦ ",
            4 => "♦ ♦ ♦ ♦ ",
            5 => "♦ ♦ ♦ ♦ ♦ ",
            _ => " "
        };
        public static void QLineup(List<KeyValuePair<int, double>> startingLineup, List<Tuple<int, int>> userChoice, List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> drivers)
        {
            Util.ClearKey();
            Console.Clear();
            Console.WriteLine("" + Colors.Text + 
                "  ┌Pole\n" + 
                " 1|\n" + 
                "  ┌\n" + 
                " 2|\n" +
                " 3|\n" +
                " 4|\n" +
                " 5|\n" +
                " 6|\n" +
                " 7|\n" +
                " 8|\n" +
                " 9|\n" +
                "10|\n" + Colors.Red +
               $"  ┌{Colors.Gray}Eliminated {Colors.Red}Q{Colors.Gray}2\n" + Colors.LessGray +
               $"11{Colors.Red}|\n" + Colors.LessGray +
               $"12{Colors.Red}|\n" + Colors.LessGray +
               $"13{Colors.Red}|\n" + Colors.LessGray +
               $"14{Colors.Red}|\n" + Colors.LessGray +
               $"15{Colors.Red}|\n" + Colors.Red +
               $"  ┌{Colors.Gray}Eliminated {Colors.Red}Q{Colors.Gray}1\n" + 
               $"16{Colors.Red}|\n" + Colors.Gray +
               $"17{Colors.Red}|\n" + Colors.Gray +
               $"18{Colors.Red}|\n" + Colors.Gray +
               $"19{Colors.Red}|\n" + Colors.Gray +
               $"20{Colors.Red}|");
            Data data = new();
            var gridList = new List<string>();
            for (int n = 0; n < 20; n++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (startingLineup[n].Key == drivers[j].Item4)
                    {
                        string space = " ";
                        if (j == userChoice[0].Item1)
                        {
                            if (userChoice[0].Item2 < 10)
                                space = "  ";
                            gridList.Add(Colors.Teams(j / 2) + "|☺" + data.UserData()[0].Item4 + Colors.Teams(j / 2) + space + userChoice[0].Item2 + Colors.Darker + "☺ " + data.UserData()[0].Item3 + Colors.Teams(j / 2) + " <");
                        }
                        else
                        {
                            if (drivers[j].Item4 < 10)
                                space = "  ";
                            gridList.Add(Colors.Teams(j / 2) + "|☺" + drivers[j].Item3 + Colors.Teams(j / 2) + space + drivers[j].Item4 + Colors.Darker + "☺ " + drivers[j].Item2);
                        }
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.SetCursorPosition(2, 19);
                        break;
                    case 1:
                        Console.SetCursorPosition(2, 13);
                        break;
                    case 2:
                        Console.SetCursorPosition(2, 3);
                        break;
                    case 3:
                        Console.SetCursorPosition(2, 1);
                        break;
                }
                for (int fade = 234; fade < 255; fade++)
                {
                    if (i < 2)
                    {
                        for (int j = 15; j < 20; j++)
                        {
                            Console.WriteLine(GridString(gridList[j - i * 5], fade));
                            Console.SetCursorPosition(2, Console.CursorTop);
                        }
                        Console.SetCursorPosition(2, Console.CursorTop - 5);
                    }
                    else if (i == 2)
                    {
                        for (int j = 1; j < 10; j++)
                        {
                            Console.WriteLine(GridString(gridList[j], fade));
                            Console.SetCursorPosition(2, Console.CursorTop);
                        }
                        Console.SetCursorPosition(2, Console.CursorTop - 9);
                    }
                    else if (i == 3)
                    {
                        Console.Write(GridString(gridList[0], fade));
                        Console.SetCursorPosition(2, Console.CursorTop);
                    }
                    Task.Delay(2).Wait();
                }
                Task.Delay(200).Wait();
            }
            Console.Write('\r');
            Util.ClearKey();
            Util.KeyAdvance(ConsoleKey.Enter);
        }
        public static string GridString(string grid, int fadeColor)
        {
            string gridDriver;
            string[] gridArray = grid.Split('☺');
            gridDriver = gridArray[0] + $"\x1b[38;5;{fadeColor}m" + gridArray[1] + $"\x1b[38;5;{fadeColor - 2}m" + gridArray[2];
            return gridDriver;
        }
    }
    public static class QPlayOrSkip
    {
        public static int PlayOrSkipQ(int circuit, int userTeam, List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> drivers, List<Tuple<string, string, string, int, string, int, int>> circuitData)
        {
            Util.ClearPart(0);
            ConsoleKeyInfo key;
            int qualifying;
            bool selectedOption = true;
            Console.WriteLine($"{Colors.Text}           Do you wish to play qualifications?\n{Colors.Gray}    If you skip you'll be given a random grid position\n");
            do
            {
                switch (selectedOption)
                {
                    case true:
                        Console.Write($"\r               {Colors.Teams(userTeam)}Play                  {Colors.Gray}Skip");
                        break;
                    case false:
                        Console.Write($"\r               {Colors.Gray}Play                  {Colors.Teams(userTeam)}Skip");
                        break;
                }
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.LeftArrow)
                    selectedOption = true;
                else if (key.Key == ConsoleKey.RightArrow)
                    selectedOption = false;
            } while (key.Key != ConsoleKey.Enter);
            Util.ClearPart(0);
            if (selectedOption)
                qualifying = Qualifying.Qualification(userTeam, circuit, drivers, circuitData);
            else
            {
                Random rnd = new();
                int startRnd = rnd.Next(4, 20);
                qualifying = startRnd;
            }
            return qualifying;
        }
    }
    public static class Qualifying
    {
        public static int Qualification(int userTeam, int circuit, List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> drivers, List<Tuple<string, string, string, int, string, int, int>> circuitData)
        {
            int score = 20;
            for (int q = -2; q < 4; q++)
            {
                int lives = 6 - Data.Difficulty;
                ConsoleKeyInfo key;
                Stopwatch stopwatch = new();
                var currentCircuit = CircuitKeyLists.CircuitKeyList(circuit);
                Util.ClearPart(0);
                Console.Write($"{Colors.Text}{circuitData[circuit].Item5} Grand Prix 2023 {Colors.Teams(userTeam)}> {Colors.Text}");
                if (q > 0)
                    Console.WriteLine($"Q{q}"); 
                else
                    Console.WriteLine($"Practice {q + 3}");
                if (q == 1 || q == -2)
                {
                    Console.Write($"{Colors.Gray}Press the keys in the right order\n{Colors.Teams(userTeam)}{QGraphics.Qlives(lives)}{Colors.Gray}You have {lives} ");
                    if (lives == 1)
                        Console.Write("life ");
                    else
                        Console.Write("lives ");
                }
                else
                    Console.Write(Colors.Teams(userTeam) + QGraphics.Qlives(lives) + Colors.Gray);
                Console.Write(Colors.Dark + "[Enter]");
                Util.KeyAdvance(ConsoleKey.Enter);
                Console.WriteLine($"\r{Colors.Teams(userTeam)}{QGraphics.Qlives(lives)}                                                               \n" + Colors.Gray);
                for (int i = 0; i < currentCircuit.Count; i++)
                    Console.Write(currentCircuit[i]);
                stopwatch.Start();
                while (stopwatch.IsRunning)
                {
                    for (int i = 0; i < currentCircuit.Count; i++)
                    {
                        ConsoleKey currentKey = currentCircuit[i] switch
                        {
                            "< " => ConsoleKey.LeftArrow,
                            "> " => ConsoleKey.RightArrow,
                            "D " => ConsoleKey.D,
                            "E " => ConsoleKey.E,
                            "R " => ConsoleKey.R,
                            "O " => ConsoleKey.O,
                            _ => ConsoleKey.Spacebar,
                        };
                        do
                        {
                            key = Console.ReadKey(true);
                            int oldLives = lives; 
                            if (key.Key != currentKey) { lives--; }
                            if (lives < oldLives)
                            {
                                Console.SetCursorPosition(0, Console.CursorTop - 2);
                                Console.WriteLine(Colors.Teams(userTeam) + '\r' + QGraphics.Qlives(lives) + " \n");
                            }
                            if (lives == 0) { break; }
                        } while (key.Key != currentKey);
                        if (lives == 0) { break; }
                        Console.Write('\r');
                        for (int j = 0; j <= i; j++)
                            Console.Write(Colors.Teams(userTeam) + currentCircuit[j]);
                    }
                    stopwatch.Stop();
                }
                if (stopwatch.IsRunning) { stopwatch.Stop(); }
                double time = stopwatch.ElapsedMilliseconds, multi = currentCircuit.Count / (time / 1000);
                Console.Write(Colors.Text + "\n\nYour Time ");
                if (q > 0)
                {
                    if (lives == 0)
                    {
                        Console.WriteLine($"\r{Colors.Red}Shunt! {Colors.Text}You're out" + Colors.Dark + " [Enter]");
                        Util.KeyAdvance(ConsoleKey.Enter);
                        if (q == 1)
                            score = 19;
                        else if (q == 2)
                            score = 14;
                        else
                            score = 9;
                        break;
                    }
                    else if (multi > 6.6 + q * 0.1)
                    {
                        Console.WriteLine(Colors.Gold + time / 1000 + Colors.Text + " · " + Colors.Gold + "Perfect Lap!" + Colors.Text);
                        if (q < 3)
                            Console.Write("You're through to the next round");
                        else
                            Console.Write(Colors.Teams(userTeam) + "You're on Pole!");
                        score = 0;
                    }
                    else if (multi > 5.6 + q * 0.1)
                    {
                        Console.WriteLine(Colors.Teams(userTeam) + time / 1000 + Colors.Text + " · Great Lap");
                        if (q < 3)
                            Console.Write("You're through to the next round");
                        else
                            Console.Write("Lets check the results");
                        if (multi > 6.4)
                            score = 1;
                        else if (multi > 6.2)
                            score = 2;
                        else if (multi > 5.9)
                            score = 3;
                        else if (multi > 5.6)
                            score = 4;
                    }
                    else if (multi > 4.4 + q * 0.1)
                    {
                        Console.WriteLine(Colors.Teams(userTeam) + time / 1000 + Colors.Text + " · Good Lap");
                        if (q < 3)
                            Console.Write("You're through to the next round");
                        else
                            Console.Write("Lets check the results");
                        if (multi > 5.6)
                            score = 4;
                        else if (multi > 5.2)
                            score = 5;
                        else if (multi > 4.8)
                            score = 6;
                        else if (multi > 4.4)
                            score = 7;
                    }
                    else if (multi > 3.9 + q * 0.1)
                    {
                        Console.Write(time / 1000);
                        if (q < 3)
                            Console.Write(" · Just enough\nYou're through to the next round");
                        else
                            Console.Write(" · Ok\nLets check the results");
                        if (multi > 4.4)
                            score = 7;
                        else if (multi > 3.9)
                            score = 8;
                    }
                    else if (multi > 3 + q * 0.1)
                    {
                        Console.Write(Colors.Red + time / 1000 + Colors.Text);
                        if (q < 3)
                            Console.Write($" · Not enough\n{Colors.Red}You're eliminated");
                        else
                            Console.Write(" · Subpar\nLets check the results");
                        Console.Write(Colors.Dark + " [Enter]");
                        Util.KeyAdvance(ConsoleKey.Enter);
                        if (q == 1)
                        {
                            if (multi > 3.9)
                                score = 15;
                            else if (multi > 3.6)
                                score = 16;
                            else if (multi > 3.3)
                                score = 17;
                            else if (multi > 3)
                                score = 18;
                        }
                        else if (q == 2)
                        {
                            if (multi > 3.9)
                                score = 10;
                            else if (multi > 3.6)
                                score = 11;
                            else if (multi > 3.3)
                                score = 12;
                            else if (multi > 3)
                                score = 13;
                        }
                        else
                            score = 9;
                        break;
                    }
                    else if (multi > 2 + q * 0.1)
                    {
                        Console.Write(Colors.Red + time / 1000 + Colors.Text);
                        if (q < 3)
                            Console.Write($" · {Colors.Red}Bad\nYou're eliminated");
                        else
                            Console.Write(" · Not good\nLets check the results");
                        Console.Write(Colors.Dark + " [Enter]");
                        Util.KeyAdvance(ConsoleKey.Enter);
                        if (q == 1)
                            score = 19;
                        else if (q == 2)
                            score = 14;
                        else
                            score = 9;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\r{Colors.Gray}You fell asleep {Colors.Dark}[Enter]");
                        Util.KeyAdvance(ConsoleKey.Enter);
                        if (q == 1)
                            score = 19;
                        else if (q == 2)
                            score = 14;
                        else
                            score = 9;
                        break;
                    }
                    Console.Write(Colors.Dark + " [Enter]");
                    Util.KeyAdvance(ConsoleKey.Enter);
                }
            }
            return score;
        }
    }
}