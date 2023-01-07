using System.Diagnostics;

namespace F1_Season_2023_Ew
{
    public static class QGraphics
    {
        public static void Qlives(int lives)
        {
            switch (lives)
            {
                case 2:
                    Console.WriteLine("\r♦ ♦  \n");
                    break;
                case 1:
                    Console.WriteLine($"{Colors.Teams()[2]}\r♦  \n");
                    break;
                case 0:
                    Console.WriteLine("\r \n");
                    break;
            }
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
        public static double Qualification(int userTeam, int circuit)
        {
            double score = 30;
            for (int q = -2; q < 4; q++)
            {
                int lives = 3;
                ConsoleKeyInfo key;
                Stopwatch stopwatch = new();
                var currentCircuit = CircuitKeyLists.CircuitKeyList(circuit);
                Console.Clear();
                if (q > 0)
                    Console.WriteLine($"{Colors.White}{Data.CircuitData()[circuit].Item1} Grand Prix 2023 {Colors.Teams()[userTeam]}> {Colors.White}Q{q}");
                else
                    Console.WriteLine($"{Colors.White}{Data.CircuitData()[circuit].Item1} Grand Prix 2023 {Colors.Teams()[userTeam]}> {Colors.White}Practice {q + 3}");
                if (q == 1)
                    Console.Write($"{Colors.Gray}Press the keys in the right order\n{Colors.Teams()[userTeam]}♦ ♦ ♦ {Colors.Gray}You're allowed 3 mistakes, Press 'Enter' to start");
                else
                    Console.Write($"{Colors.Teams()[userTeam]}♦ ♦ ♦ {Colors.Gray}Press 'Enter' to start");
                do
                {
                    key = Console.ReadKey(true);
                } while (key.Key != ConsoleKey.Enter);
                Console.WriteLine($"\r{Colors.Teams()[userTeam]}♦ ♦ ♦                                                                \n" + Colors.Gray);
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
                            if (key.Key != currentKey) { lives--; }
                            if (lives < 3)
                            {
                                Console.SetCursorPosition(0, Console.CursorTop - 2);
                                Console.Write(Colors.Teams()[userTeam]);
                                QGraphics.Qlives(lives);
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
                if (q > 0)
                {
                    score = stopwatch.ElapsedMilliseconds;
                    if (lives == 0)
                    {
                        Console.WriteLine($"\n\n{Colors.Teams()[2]}Shunt! {Colors.White}Better luck next time\n" + Colors.Gray + "Press 'Enter' to continue");
                        do
                        {
                            key = Console.ReadKey(true);
                        } while (key.Key != ConsoleKey.Enter);
                        if (q == 1)
                            score = 30;
                        else if (q == 2)
                            score = 18.8;
                        else
                            score = 14.5;
                        break;
                    }
                    else if (score < (2300 + currentCircuit.Count * 25) - q * 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("\n\nScore: " + score / 475);
                        Console.SetCursorPosition(12, Console.CursorTop);
                        Console.WriteLine(" - Perfect Lap!  " + Colors.White);
                        if (q < 3)
                            Console.WriteLine("You're through to the next round");
                        else
                            Console.WriteLine(Colors.Teams()[userTeam] + "You're on Pole!");
                        score = score / 3000;
                    }
                    else if (score < (3000 + currentCircuit.Count * 25) - q * 10)
                    {
                        Console.Write("\n\nScore: " + Colors.Teams()[userTeam] + score / 475);
                        Console.SetCursorPosition(12, Console.CursorTop);
                        Console.WriteLine(" - Great Lap!    " + Colors.White);
                        if (q < 3)
                            Console.WriteLine("You're through to the next round");
                        else
                            Console.WriteLine("Lets check the results");
                        score = score / 475;
                    }
                    else if (stopwatch.ElapsedMilliseconds < (4200 + currentCircuit.Count * 25) - q * 20)
                    {
                        Console.Write("\n\nScore: " + Colors.Teams()[userTeam] + score / 475);
                        Console.SetCursorPosition(12, Console.CursorTop);
                        Console.WriteLine(" - Good Lap      " + Colors.White);
                        if (q < 3)
                            Console.WriteLine("You're through to the next round");
                        else
                            Console.WriteLine("Lets check the results");
                        score = score / 475;
                    }
                    else if (stopwatch.ElapsedMilliseconds < (7000 + currentCircuit.Count * 25) - q * 600)
                    {
                        Console.Write(Colors.White + "\n\nScore: " + score / 475);
                        Console.SetCursorPosition(12, Console.CursorTop);
                        if (q < 3)
                            Console.WriteLine(" - Just enough   \nYou're through to the next round");
                        else
                            Console.WriteLine(" - Ok            \nLets check the results");
                        score = score / 475;
                    }
                    else if (stopwatch.ElapsedMilliseconds < 10000)
                    {
                        Console.Write(Colors.White + "\n\nScore: " + Colors.Teams()[2] + score / 475 + Colors.White);
                        Console.SetCursorPosition(12, Console.CursorTop);
                        if (q < 3)
                            Console.WriteLine(" - Not enough    \nYou're eliminated");
                        else
                            Console.WriteLine(" - Subpar         \nLets check the results");
                        Console.Write(Colors.Gray + "Press 'Enter' to continue");
                        do
                        {
                            key = Console.ReadKey(true);
                        } while (key.Key != ConsoleKey.Enter);
                        if (q == 1)
                            score = 27;
                        else if (q == 2)
                            score = 19;
                        else
                            score = 14.5;
                        break;
                    }
                    else if (stopwatch.Elapsed.Seconds < 20)
                    {
                        Console.Write(Colors.White + "\n\nScore: " + Colors.Teams()[2] + score / 475);
                        Console.SetCursorPosition(12, Console.CursorTop);
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
                            score = 30;
                        else if (q == 2)
                            score = 19;
                        else
                            score = 14.5;
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
                            score = 30;
                        else if (q == 2)
                            score = 19;
                        else
                            score = 14.5;
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