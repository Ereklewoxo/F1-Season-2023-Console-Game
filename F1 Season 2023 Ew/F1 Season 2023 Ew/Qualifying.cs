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
                    Console.WriteLine(" ");
                    break;
            }
            return symblos;
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
                case 23:
                    circuitKeyList = new List<string> { "< ", "< ", "> ", "< ", "< ", "D ", "< ", "> ", "< ", "D ", "< ", "> ", "> ", "> ", "< ", "< ", "> ", "> " };
                    break;
                case 21:
                    circuitKeyList = new List<string> { "< ", "> ", "< ", "D ", "< ", "< ", "> ", "> ", "> ", "< ", "> ", "< ", "< ", "< ", "< ", "D ", "< " };
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
                        Console.WriteLine(Colors.Purple + "\n\nTime: " + time / 1000 + " - Perfect Lap!  " + Colors.White);
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
                            score = 19;
                        else if (q == 2)
                            score = 14;
                        else
                            score = 9;
                        break;
                    }
                    else if (multi > 1 + q * 0.1)
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