using System.Diagnostics;

namespace F1_Season_2023_Ew
{
    public static class QGraphics
    {
        public static string Qlives(int lives)
        {
            string symblos = " ";
            switch (lives)
            {
                case 5:
                    symblos = "♦ ♦ ♦ ♦ ♦ ";
                    break;
                case 4:
                    symblos = "♦ ♦ ♦ ♦ ";
                    break;
                case 3:
                    symblos = "♦ ♦ ♦ ";
                    break;
                case 2:
                    symblos = "♦ ♦ ";
                    break;
                case 1:
                    symblos = $"{Colors.Teams()[2]}♦ ";
                    break;
                case 0:
                    break;
            }
            return symblos;
        }
        public static void QLineup(List<KeyValuePair<int, double>> startingLineup, List<Tuple<int, int>> userChoice)
        {
            Console.Clear();
            Console.Write("" + Colors.Gold + 
                "  ┌Pole\n" + 
                " 1|\n" + Colors.White +
                "  ┌\n" + 
                " 2|\n" +
                " 3|\n" +
                " 4|\n" +
                " 5|\n" +
                " 6|\n" +
                " 7|\n" +
                " 8|\n" +
                " 9|\n" +
                "10|\n" + Colors.Teams()[2] +
               $"  ┌E{Colors.Gray}liminated {Colors.Teams()[2]}Q{Colors.Gray}2\n" +
               $"11{Colors.Teams()[2]}|\n" + Colors.Gray +
               $"12{Colors.Teams()[2]}|\n" + Colors.Gray +
               $"13{Colors.Teams()[2]}|\n" + Colors.Gray +
               $"14{Colors.Teams()[2]}|\n" + Colors.Gray +
               $"15{Colors.Teams()[2]}|\n" + Colors.Teams()[2] +
               $"  ┌E{Colors.Gray}liminated {Colors.Teams()[2]}Q{Colors.Gray}1\n" + 
               $"16{Colors.Teams()[2]}|\n" + Colors.Gray +
               $"17{Colors.Teams()[2]}|\n" + Colors.Gray +
               $"18{Colors.Teams()[2]}|\n" + Colors.Gray +
               $"19{Colors.Teams()[2]}|\n" + Colors.Gray +
               $"20{Colors.Teams()[2]}|");
            Data data = new();
            ConsoleKeyInfo key;
            int number = 20;
            int delay = 1;
            Console.Write('\r');
            for (int n = 19; n > -1; n--)
            {
                for (int j = 19; j > -1; j--)
                {
                    if (startingLineup[n].Key == Data.DriverData()[j].Item4)
                    {
                        for (int i = 234; i < 255; i += 2)
                        {
                            if (Console.KeyAvailable)
                            {
                                key = Console.ReadKey(true);
                                if (key.Key == ConsoleKey.Spacebar)
                                {
                                    i = 255;
                                    delay = 0;
                                }
                            }
                            if (number > 15)
                                Console.Write(Colors.Gray);
                            else if (number == 1)
                                Console.Write(Colors.Gold);
                            else if (number > 10)
                                Console.Write(Colors.LessGray);
                            else
                                Console.Write(Colors.White);
                            if (number < 10)
                                Console.Write(" ");
                            if (j == userChoice[0].Item1)
                                Console.WriteLine(number + Colors.Teams()[j / 2] + '|' + $"\x1b[38;5;{i}m" + data.UserData()[1].Item3 + Colors.Teams()[j / 2] + " <");
                            else
                                Console.WriteLine(number + Colors.Teams()[j / 2] + '|' + $"\x1b[38;5;{i}m" + Data.DriverData()[j].Item2);
                            if (i < 254)
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Task.Delay(delay).Wait();
                        }
                        if (number == 16 || number == 11 || number == 2) 
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        break;
                    }
                }
                number--;
            }
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
        }
    }
    public static class CircuitKeyLists
    {
        public static List<string> CircuitKeyList(int circuit)
        {
            var circuitKeyList = new List<string> { "E R R O R " };
            switch (circuit)
            {
                case 0:
                    circuitKeyList = new List<string> { "> ", "< ", "> ", "D ", "> ", "< ", "> ", "< ", "> ", "< ", "< ", "D ", "< ", "> ", "> ", "> ", "> ", "D " };
                    break;
                case 1:
                    circuitKeyList = new List<string> { "< ", "> ", "< ", "< ", "> ", "< ", "< ", "> ", "> ", "< ", "> ", "< ", "< ", "> ", "< ", "> ", "< ", "< ", "> ", "D ", "< ", "> ", "< ", "> ", "> ", "D ", "< ", "< ", "< ", "D " };
                    break;
                case 2:
                    circuitKeyList = new List<string> { "> ", "< ", "D ", "> ", "< ", "> ", "> ", "< ", "> ", "< ", "> ", "D ", "> ", "> ", "< ", "> ", "D " };
                    break;
                case 4:
                    circuitKeyList = new List<string> { "< ", "< ", "D ", "< ", "> ", "< ", "> ", "> ", "< ", "> ", "< ", "> ", "< ", "< ", "< ", "< ", "< ", "> ", "< ", "> ", "> ", "D " };
                    break;
                case 5:
                    circuitKeyList = new List<string> { "> ", "< ", "> ", "< ", "> ", "< ", "< ", "< ", "> ", "D ", "< ", "< ", "> ", "< ", "< ", "> ", "< ", "D ", "< ", "< ", "> ", "D " };
                    break;
                case 6: 
                    circuitKeyList = new List<string> { "> ", "< ", "> ", "< ", "< ", "> ", "< ", "> ", "< ", "< ", "> ", "> ", "< ", "> ", "< ", "> ", "< ", "< ", "D ", "> " };
                    break;
                case 7:
                    circuitKeyList = new List<string> { "> ", "> ", "< ", "> ", "> ", "< ", "> ", "> ", "> ", "< ", "> ", "< ", "< ", "> ", "> ", "< ", "< ", "> ", "> ", "D " };
                    break;
                case 8:          
                    circuitKeyList = new List<string> { "> ", "< ", "> ", "> ", "> ", "< ", "< ", "< ", "> ", "> ", "D ", "< ", "< ", "> ", "> ", "< ", "> ", "> ", "D " };
                    break;
                case 9:      
                    circuitKeyList = new List<string> { "< ", "> ", "> ", "< ", "> ", "< ", "> ", "D ", "> ", "< ", "> ", "< ", "D ", "> ", "> ", "< ", "D " };
                    break;
                case 10:    
                    circuitKeyList = new List<string> { "> ", "D ", "< ", "> ", "D ", "> ", "> ", "< ", "< ", "> ", "> ", "> ", "D " };
                    break;
                case 11:
                    circuitKeyList = new List<string> { "> ", "< ", "> ", "< ", "< ", "D ", "< ", "> ", "> ", "> ", "< ", "> ", "< ", "> ", "< ", "D ", "> ", "< ", "> ", "> " };
                    break;
                case 12:
                    circuitKeyList = new List<string> { "> ", "D ", "< ", "> ", "< ", "> ", "> ", "< ", "< ", "> ", "< ", "> ", "> ", "< ", "> ", "D " };
                    break;
                case 21:
                    circuitKeyList = new List<string> { "< ", "> ", "< ", "D ", "< ", "< ", "> ", "> ", "> ", "< ", "> ", "< ", "< ", "< ", "< ", "D ", "< " };
                    break;
                case 23:
                    circuitKeyList = new List<string> { "< ", "< ", "> ", "< ", "< ", "D ", "< ", "> ", "< ", "D ", "< ", "> ", "> ", "> ", "< ", "< ", "> ", "> " };
                    break;
            }
            return circuitKeyList;
        }
    }
    public static class Qualifying
    {
        public static int Qualification(int userTeam, int circuit)
        {
            int score = 20;
            for (int q = -2; q < 4; q++)
            {
                int lives = 6 - Menu.Difficulty;
                ConsoleKeyInfo key;
                Stopwatch stopwatch = new();
                var currentCircuit = CircuitKeyLists.CircuitKeyList(circuit);
                Console.Clear();
                Console.Write($"{Colors.White}{Data.CircuitData()[circuit].Item1} Grand Prix 2023 {Colors.Teams()[userTeam]}> {Colors.White}");
                if (q > 0)
                    Console.WriteLine($"Q{q}"); 
                else
                    Console.WriteLine($"Practice {q + 3}");
                if (q == 1 || q == -2)
                {
                    Console.Write($"{Colors.Gray}Press the keys in the right order\n{Colors.Teams()[userTeam]}{QGraphics.Qlives(lives)}{Colors.Gray}You have {lives} ");
                    if (lives == 1)
                        Console.Write("life, ");
                    else
                        Console.Write("lives, ");
                }
                else
                    Console.Write(Colors.Teams()[userTeam] + QGraphics.Qlives(lives) + Colors.Gray);
                Console.Write("Press 'Enter' to start");
                do
                {
                    key = Console.ReadKey(true);
                } while (key.Key != ConsoleKey.Enter);
                Console.WriteLine($"\r{Colors.Teams()[userTeam]}{QGraphics.Qlives(lives)}                                                               \n" + Colors.Gray);
                for (int i = 0; i < currentCircuit.Count; i++)
                {
                    Console.Write(currentCircuit[i]);
                }
                Console.Write('\r');
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
                            case "D ":
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
                                Console.Write(Colors.Teams()[userTeam]);
                                Console.WriteLine('\r' + QGraphics.Qlives(lives) + " \n");
                            }
                            if (lives == 0) { break; }
                        } while (key.Key != currentKey);
                        if (lives == 0) { break; }
                        Console.Write('\r');
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write(Colors.Teams()[userTeam] + currentCircuit[j]);
                        }
                    }
                    stopwatch.Stop();
                }
                if (stopwatch.IsRunning) { stopwatch.Stop(); }
                double time = stopwatch.ElapsedMilliseconds;
                double multi = currentCircuit.Count / (time/1000);
                if (q > 0)
                {
                    if (lives == 0)
                    {
                        Console.WriteLine($"\n\n{Colors.Teams()[2]}Shunt! {Colors.White}You're out\n" + Colors.Gray + "Press 'Enter' to continue");
                        do
                        {
                            key = Console.ReadKey(true);
                        } while (key.Key != ConsoleKey.Enter);
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
                        Console.WriteLine(Colors.Gold + "\n\nTime: " + time / 1000 + " - Perfect Lap!  " + Colors.White);
                        if (q < 3)
                            Console.WriteLine("You're through to the next round");
                        else
                            Console.WriteLine(Colors.Teams()[userTeam] + "You're on Pole!");
                        score = 0;
                    }
                    else if (multi > 5.6 + q * 0.1)
                    {
                        Console.WriteLine("\n\nTime: " + Colors.Teams()[userTeam] + time / 1000 + " - Great Lap!    " + Colors.White);
                        if (q < 3)
                            Console.WriteLine("You're through to the next round");
                        else
                            Console.WriteLine("Lets check the results");
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
                        Console.WriteLine("\n\nTime: " + Colors.Teams()[userTeam] + time / 1000 + " - Good Lap      " + Colors.White);
                        if (q < 3)
                            Console.WriteLine("You're through to the next round");
                        else
                            Console.WriteLine("Lets check the results");
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
                        Console.Write(Colors.White + "\n\nTime: " + time / 1000);
                        if (q < 3)
                            Console.WriteLine(" - Just enough   \nYou're through to the next round");
                        else
                            Console.WriteLine(" - Ok            \nLets check the results");
                        if (multi > 4.4)
                            score = 7;
                        else if (multi > 3.9)
                            score = 8;
                    }
                    else if (multi > 3 + q * 0.1)
                    {
                        Console.Write(Colors.White + "\n\nTime: " + Colors.Teams()[2] + time / 1000 + Colors.White);
                        if (q < 3)
                            Console.WriteLine(" - Not enough    \nYou're eliminated");
                        else
                            Console.WriteLine(" - Subpar        \nLets check the results");
                        Console.Write(Colors.Gray + "Press 'Enter' to continue");
                        do
                        {
                            key = Console.ReadKey(true);
                        } while (key.Key != ConsoleKey.Enter);
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
                        Console.Write(Colors.White + "\n\nTime: " + Colors.Teams()[2] + time / 1000);
                        if (q < 3)
                            Console.WriteLine(" - Bad       \nYou're eliminated");
                        else
                            Console.WriteLine(" - Not good  \nLets check the results");
                        Console.Write(Colors.Gray + "Press 'Enter' to continue");
                        do
                        {
                            key = Console.ReadKey(true);
                        } while (key.Key != ConsoleKey.Enter);
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
                        Console.WriteLine($"\n\n{Colors.Gray}You fell asleep\nPress 'Enter' to continue");
                        do
                        {
                            key = Console.ReadKey(true);
                        } while (key.Key != ConsoleKey.Enter);
                        if (q == 1)
                            score = 19;
                        else if (q == 2)
                            score = 14;
                        else
                            score = 9;
                        break;
                    }
                    Console.Write(Colors.Gray + "Press 'Enter' to continue");
                    do
                    {
                        key = Console.ReadKey(true);
                    } while (key.Key != ConsoleKey.Enter);
                }
            }
            return score;
        }
    }
}