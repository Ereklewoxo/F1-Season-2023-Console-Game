using NAudio.Vorbis;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using VisioForge.MediaFramework.Helpers;
using WaveOutEvent = NAudio.Wave.WaveOutEvent;

namespace F1_Season_2023_Ew
{

    public class Data
    {
        public bool ChangeUserData = false;
        public static int Difficulty = 3;
        public static void LoadDifficulty()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            StreamReader difficultyR = new(@$"{path}\UserData\Difficulty.txt");
            Difficulty = Convert.ToInt32(difficultyR.ReadLine());
            difficultyR.Close();
        }
        public static void SaveDifficulty()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            StreamWriter difficultyW = new(@$"{path}\UserData\Difficulty.txt");
            difficultyW.Write(Difficulty);
            difficultyW.Close();
        }
        public static List<Tuple<string, string, string, int, string, int, int>> CircuitData()
        {
            var circuitData = new List<Tuple<string, string, string, int, string, int, int>>
            {                                                           //country          venue                 date             GP             rain% laps 
                new Tuple<string, string, string, int, string, int, int>("Bahrain",       "Sakhir",             "March", 5,      "Bahrain",         2, 57),
                new Tuple<string, string, string, int, string, int, int>("Saudi Arabia",  "Jeddah",             "March", 19,     "Saudi Arabian",   0, 50),
                new Tuple<string, string, string, int, string, int, int>("Australia",     "Albert Park",        "April", 2,      "Austrlian",      17, 58),
                new Tuple<string, string, string, int, string, int, int>("Azerbaijan",    "Baku",               "April", 30,     "Azerbaijan",     16, 51),
                new Tuple<string, string, string, int, string, int, int>("USA",           "Miami",              "May", 7,        "Miami",          23, 57),
                new Tuple<string, string, string, int, string, int, int>("Italy",         "Imola",              "May", 21,       "Emilia Romagna", 15, 63),
                new Tuple<string, string, string, int, string, int, int>("Monaco",        "Monaco",             "May", 28,       "Monaco",          7, 78),
                new Tuple<string, string, string, int, string, int, int>("Spain",         "Catalunya",          "June", 4,       "Spanish",        17, 66),
                new Tuple<string, string, string, int, string, int, int>("Canada",        "Gilles Villeneuve",  "June", 18,      "Canadian",       19, 70),
                new Tuple<string, string, string, int, string, int, int>("Austria",       "Red Bull Ring",      "July", 2,       "Austrian",       19, 71),
                new Tuple<string, string, string, int, string, int, int>("Great Britain", "Silverstone",        "July", 9,       "British",        31, 52),
                new Tuple<string, string, string, int, string, int, int>("Hungary",       "Hungaroring",        "July", 23,      "Hungarian",      21, 70),
                new Tuple<string, string, string, int, string, int, int>("Belgium",       "Spa",                "July", 30,      "Belgian",        46, 44),
                new Tuple<string, string, string, int, string, int, int>("Netherlands",   "Zandvoort",          "August", 27,    "Dutch",          22, 72),
                new Tuple<string, string, string, int, string, int, int>("Italy",         "Monza",              "September", 3,  "Italian",        20, 53),
                new Tuple<string, string, string, int, string, int, int>("Singapore",     "Marina Bay",         "September", 17, "Singapore",      38, 61),
                new Tuple<string, string, string, int, string, int, int>("Japan",         "Suzuka",             "September", 24, "Japanese",       40, 53),
                new Tuple<string, string, string, int, string, int, int>("Qatar",         "Losail",             "October", 8,    "Qatar",           1, 57),
                new Tuple<string, string, string, int, string, int, int>("USA",           "COTA",               "October", 22,   "United States",  16, 56),
                new Tuple<string, string, string, int, string, int, int>("Mexico",        "Hermanos Rodriguez", "October", 29,   "Mexican",        17, 71),
                new Tuple<string, string, string, int, string, int, int>("Brazil",        "Interlagos",         "November", 5,   "Sao Paulo",      35, 71),
                new Tuple<string, string, string, int, string, int, int>("USA",           "Las Vegas",          "November", 18,  "Las Vegas",      18, 50),
                new Tuple<string, string, string, int, string, int, int>("Abu Dhabi",     "Yas Marina",         "November", 26,  "Abu Dhabi",       3, 58),
                new Tuple<string, string, string, int, string, int, int>("Portugal",      "Portimao",           "April", 16,     "Portugese",      15, 66)
            };
            return circuitData;
        }
        public static List<string> TeamList()
        {
            var teamList = new List<string> { "Mercedes", "Red Bull Racing", "Ferrari", "McLaren", "Alpine", "AlphaTauri", "Aston Martin", "Williams", "Alfa Romeo", "Haas F1 Team" };
            return teamList;
        }
        public static List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> DriverData()
        {
            var driverData = new List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>>
            {                                                                                 //Team            Full Name         SrtNm  Num  Country          Race Data    AG     AF    FL DNF
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[0], "Lewis Hamilton",  "HAM", 44, "United Kingdom", Tuple.Create( 6.41,  5.12, 2, 2)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[0], "George Russell",  "RUS", 63, "United Kingdom", Tuple.Create( 6.36,  4.38, 4, 1)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[1], "Max Verstappen",  "VER",  1, "Netherlands",    Tuple.Create( 3.41,  2.81, 5, 2)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[1], "Sergio Perez",    "PER", 11, "Mexico",         Tuple.Create( 4.82,  3.95, 3, 3)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[2], "Charles Leclerc", "LEC", 16, "Monaco",         Tuple.Create( 3.91,  3.32, 3, 3)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[2], "Carlos Sainz",    "SAI", 55, "Spain",          Tuple.Create( 4.55,  3.50, 2, 6)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[3], "Lando Norris",    "NOR",  4, "United Kingdom", Tuple.Create( 8.05,  7.80, 2, 2)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[3], "Oscar Piastri",   "PIA", 81, "Australia",      Tuple.Create(12.41, 12.29, 0, 3)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[4], "Esteban Ocon",    "OCO", 31, "France",         Tuple.Create(11.74,  8.55, 0, 2)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[4], "Pierre Gasly",    "GAS", 10, "France",         Tuple.Create(12.18, 11.58, 0, 3)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[5], "Yuki Tsunoda",    "TSU", 22, "Japan",          Tuple.Create(14.05, 12.81, 0, 5)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[5], "Nyck de Vries",   "DEV", 45, "Netherlands",    Tuple.Create(13.85, 11.75, 0, 3)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[6], "Lance Stroll",    "STR", 18, "Canada",         Tuple.Create(14.64, 11.95, 0, 3)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[6], "Fernando Alonso", "ALO", 14, "Spain",          Tuple.Create(10.41,  9.65, 0, 6)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[7], "Alexander Albon", "ALB", 23, "Thailand",       Tuple.Create(15.62, 12.86, 0, 5)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[7], "Logan Sargeant",  "SAR",  6, "United States",  Tuple.Create(16.82, 15.52, 0, 5)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[8], "Valtteri Bottas", "BOT", 77, "Finland",        Tuple.Create(11.36, 10.41, 0, 6)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[8], "Zhou Guanyu",     "ZHO", 24, "China",          Tuple.Create(14.27, 12.88, 1, 6)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[9], "Kevin Magnussen", "MAG", 20, "Denmark",        Tuple.Create(12.01, 13.17, 0, 5)),
                new Tuple<string, string, string, int, string, Tuple<double, double, int, int>>(TeamList()[9], "Nico Hulkenberg", "HUL", 25, "Germany",        Tuple.Create(13.69, 13.44, 0, 3))
            };
            return driverData;
        }
        public List<Tuple<string, string, string, string, string>> UserData()
        {
            var userData = new List<Tuple<string, string, string, string, string>>
            {
                new Tuple<string, string, string, string, string>("John", "Doe", "John Doe", "DOE", "Sealand")
            };
            string? firstName, lastName, fullName, shortName, nationality, firstNameRead;
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            StreamReader saveFileR = new(@$"{path}\UserData\SaveFile.txt");
            firstNameRead = saveFileR.ReadLine();
            if (firstNameRead.IsNullOrEmpty() == false)
            {
                firstName = firstNameRead;
                lastName = saveFileR.ReadLine();
                fullName = saveFileR.ReadLine();
                shortName = saveFileR.ReadLine();
                nationality = saveFileR.ReadLine();
                userData.Add(new Tuple<string, string, string, string, string>(firstName, lastName, fullName, shortName, nationality));
            }
            saveFileR.Close();
            if (firstNameRead.IsNullOrEmpty() || ChangeUserData == true)
            {
                StreamWriter saveFileW = new(@$"{path}\UserData\SaveFile.txt");
                if (ChangeUserData)
                    Console.Write("\n              ");
                Console.Write("     /What's your first name?" + '\n' + Colors.Teams()[2]);
                if (ChangeUserData)
                    Console.Write("              ");
                Console.Write($"    /" + Colors.White);
                firstName = Console.ReadLine();
                if (firstName.Length == 1)
                    firstName = firstName.ToUpper();
                else if (firstName.Length == 0)
                    firstName = "John";
                else
                    firstName = firstName.Remove(1).ToUpper() + firstName.Remove(0, 1).ToLower();
                saveFileW.WriteLine(firstName);
                Console.SetCursorPosition(0, Console.CursorTop - 2);
                if (ChangeUserData)
                    Console.Write("              ");
                Console.Write("     /And your last name?    " + '\n' + Colors.Teams()[2]);
                if (ChangeUserData)
                    Console.Write("              ");
                Console.Write($"    /{firstName} " + Colors.White);
                lastName = Console.ReadLine();
                if (lastName.Length == 1)
                    lastName = lastName.ToUpper();
                else if (lastName.Length == 0)
                    lastName = "Doe";
                else
                    lastName = lastName.Remove(1).ToUpper() + lastName.Remove(0, 1).ToLower();
                saveFileW.WriteLine(lastName);
                fullName = firstName + " " + lastName;
                saveFileW.WriteLine(fullName);
                if (lastName.Length == 3)
                    shortName = lastName;
                else if (firstName.Length + lastName.Length < 3)
                    shortName = firstName + lastName;
                else if (firstName.Length + lastName.Length == 3)
                    shortName = firstName + lastName;
                else if (firstName.Length > 1 && lastName.Length == 1)
                    shortName = firstName.Remove(2) + lastName;
                else if (firstName.Length > 1 && lastName.Length < 3)
                    shortName = firstName.Remove(1) + lastName;
                else
                    shortName = lastName.Remove(3);
                shortName = shortName.ToUpper();
                saveFileW.WriteLine(shortName);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(Colors.Teams()[2]);
                if (ChangeUserData)
                    Console.Write("              ");
                Console.WriteLine($"    /{firstName} {lastName}" + Colors.White);
                if (ChangeUserData)
                    Console.Write("              ");
                Console.Write("   /Where are you from?" + '\n' + Colors.Teams()[2]);
                if (ChangeUserData)
                    Console.Write("              ");
                Console.Write($"  /" + Colors.White);
                nationality = Console.ReadLine();
                if (nationality.Length == 1)
                    nationality = nationality.ToUpper();
                else if (nationality.IsNullOrEmpty())
                    nationality = "Sealand";
                else
                    nationality = nationality.Remove(1).ToUpper() + nationality.Remove(0, 1).ToLower();
                saveFileW.WriteLine(nationality);
                saveFileW.Close();
                Console.Write(Colors.White);
                userData.Add(new Tuple<string, string, string, string, string>(firstName, lastName, fullName, shortName, nationality));
                Console.SetCursorPosition(0, Console.CursorTop - 4);
            }
            return userData;
        }
    }
    public class CircuitSelector
    {
        public static int CircuitListing()
        {
            ConsoleKeyInfo key;
            var circuitData = Data.CircuitData();
            bool bonusCircuits = false;
            char letterForNubering = 'R';
            Console.Clear();
            int selCircuit = 0, minCircuit = 0, maxCircuit = 23;
            Console.SetCursorPosition(84, 0);
            Console.WriteLine(Colors.White + "<" + Colors.Teams()[2] + " FORMULA 1 " + Colors.White + "2023 SEASON >");
            do
            {
                Console.SetCursorPosition(0, 0);
                if (bonusCircuits)
                    DisplayCircuit.BonusCircuits(selCircuit - 23);
                else
                    DisplayCircuit.Circuits(selCircuit);
                for (int i = minCircuit; i < maxCircuit; i++)
                {
                    if (bonusCircuits)
                        Console.SetCursorPosition(84, i - 22);
                    else
                        Console.SetCursorPosition(84, i + 1);
                    if (i == selCircuit)
                        Console.Write(Colors.Teams()[2]);
                    else
                    {
                        if (i < selCircuit && selCircuit - i < 11)
                            Console.Write($"\x1b[38;5;{256 - (selCircuit - i)}m");
                        else if (i > selCircuit && i - selCircuit < 11)
                            Console.Write($"\x1b[38;5;{256 - (i - selCircuit)}m");
                        else
                            Console.Write(Colors.Gray);
                    }
                    if (i < 9 || i > 22 && i < 32)
                        Console.Write($"{letterForNubering}0");
                    else
                        Console.Write(letterForNubering);
                    if (bonusCircuits)
                        Console.Write((i - 23) + 1);
                    else
                        Console.Write(i + 1);
                    if (i == minCircuit)
                        Console.Write('╒');
                    else if (i == maxCircuit - 1)
                        Console.Write('╘');
                    else
                        Console.Write('╞');
                    string country = circuitData[i].Item1.ToUpper();
                    Console.Write(country + ' ');
                    if (i == selCircuit)
                        Console.Write(Colors.LessGray);
                    else
                        Console.Write(Colors.Gray);
                    Console.WriteLine(circuitData[i].Item2);
                }
                int oldSelCircuit = selCircuit;
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                        selCircuit = Math.Min(selCircuit + 1, maxCircuit - 1);
                    else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                        selCircuit = Math.Max(selCircuit - 1, minCircuit);
                    else if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                    {
                        selCircuit = 0;
                        Console.Clear();
                        bonusCircuits = !bonusCircuits;
                        if (bonusCircuits)
                        {
                            selCircuit = 23; minCircuit = 23; maxCircuit = Data.CircuitData().Count;
                            letterForNubering = 'B';
                            Console.SetCursorPosition(84, 0);
                            Console.WriteLine(Colors.White + "<" + Colors.Teams()[2] + " Bonus GPs " + Colors.White + ">");
                        }
                        else
                        {
                            selCircuit = 0; minCircuit = 0; maxCircuit = 23;
                            letterForNubering = 'R';
                            Console.SetCursorPosition(84, 0);
                            Console.WriteLine(Colors.White + "<" + Colors.Teams()[2] + " FORMULA 1 " + Colors.White + "2023 SEASON >");
                        }
                        break;
                    }
                    else if (key.Key == ConsoleKey.Enter)
                        break;
                } while (oldSelCircuit == selCircuit);
            } while (key.Key != ConsoleKey.Enter);
            return selCircuit;
        }
    }
    public class TeamSelector
    {
        public static List<Tuple<int, int>> TeamListing()
        {
            ConsoleKeyInfo key;
            Data data = new();
            bool firtstDriverSeled = true;
            int userNumber = 1, selTeam = 0, replace;
            Console.Clear();
            do
            {
                do
                {
                    Console.WriteLine(Colors.White + "Choose a Team & Who To Replace " + Colors.Teams()[selTeam] + data.UserData()[1].Item3 + '\n');
                    for (int i = 0; i < Data.TeamList().Count; i++)
                    {
                        Console.Write(Colors.Teams()[i] + '|');
                        if (i != selTeam)
                            Console.Write(Colors.LessGray);
                        Console.WriteLine(Data.TeamList()[i] + "                                                ");
                        if (i == selTeam)
                        {
                            Console.Write("└─┤");
                            if (firtstDriverSeled == false)
                                Console.Write(Colors.White);
                            else if (firtstDriverSeled && i == 9)
                                Console.Write(Colors.Teams()[2]);
                            Console.Write($"{Data.DriverData()[i * 2].Item4}" + ' ' + Data.DriverData()[i * 2].Item2 + Colors.White);
                            Console.SetCursorPosition(22, Console.CursorTop);
                            Console.Write(Colors.Teams()[i] + "| ");
                            if (firtstDriverSeled == false && i != 9)
                                Console.Write(Colors.Teams()[i]);
                            else if (firtstDriverSeled == false && i == 9)
                                Console.Write(Colors.Teams()[2]);
                            else
                                Console.Write(Colors.White);
                            Console.WriteLine($"{Data.DriverData()[i * 2 + 1].Item4}" + ' ' + Data.DriverData()[i * 2 + 1].Item2);
                        }
                    }
                    key = Console.ReadKey(true);
                    if ((key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S) && selTeam < 9)
                    {
                        firtstDriverSeled = true;
                        selTeam = Math.Min(selTeam + 1, 9);
                    }
                    else if ((key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W) && selTeam > 0)
                    {
                        firtstDriverSeled = true;
                        selTeam = Math.Max(selTeam - 1, 0);
                    }
                    else if ((key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D))
                        firtstDriverSeled = false;
                    else if ((key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A))
                        firtstDriverSeled = true;
                    else if (key.Key == ConsoleKey.Enter)
                        break;
                    Console.SetCursorPosition(0, 0);
                } while (key.Key != ConsoleKey.Enter);
                if (firtstDriverSeled)
                    replace = selTeam * 2;
                else
                    replace = selTeam * 2 + 1;
                Console.WriteLine('\n' + Colors.Teams()[selTeam] + "|" + Colors.White + "Pick Your Number" + Colors.Teams()[selTeam] + "|");
                bool numberPicked = false;
                while (numberPicked == false)
                {
                    if (Console.KeyAvailable)
                        key = Console.ReadKey(false);
                    for (int i = 0; i < Data.DriverData().Count; i++)
                    {
                        while (Data.DriverData()[i].Item4 == userNumber && i != replace)
                        {
                            i = 0;
                            userNumber++;
                        }
                    }
                    Console.Write(Colors.Teams()[selTeam] + "\r└─┤" + Colors.LessGray + "   < ");
                    if (userNumber < 10)
                        Console.Write(Colors.Gray + 0);
                    Console.Write(Colors.Teams()[selTeam] + userNumber + Colors.LessGray + " >  " + Colors.Teams()[selTeam] + " ├─┘");
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                    {
                        if (userNumber < 12)
                            userNumber = 1;
                        else
                            userNumber -= 10;
                    }
                    else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                    {
                        if (userNumber > 89)
                            userNumber = 99;
                        else
                            userNumber += 10;
                    }
                    else if ((key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D) && userNumber < 99)
                        userNumber++;
                    else if ((key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A) && userNumber > 1)
                        userNumber--;
                    for (int i = 0; i < Data.DriverData().Count; i++)
                    {
                        while (Data.DriverData()[i].Item4 == userNumber && i != replace)
                        {
                            if ((key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A) && userNumber > 2)
                            {
                                i = 0;
                                userNumber--;
                            }
                            else if ((key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D) && userNumber < 99)
                            {
                                i = 0;
                                userNumber++;
                            }
                            else
                            {
                                i = 0;
                                userNumber++;
                            }
                        }
                    }
                    if (key.Key == ConsoleKey.Enter)
                        numberPicked = true;
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        Console.WriteLine("                                                  \n                                                  \n                                                  ");
                        Console.SetCursorPosition(0, 0);
                        break;
                    }
                }
            } while (key.Key == ConsoleKey.Escape);
            var userTeamChoice = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(replace, userNumber),
            };
            return userTeamChoice;
        }
    }
    public class LineupGenerator
    {
        public static List<KeyValuePair<int, double>> StartingLineup(int user, int qualification)
        {
            var driver = Data.DriverData();
            Random rnd = new();
            double startRndDouble;
            int startRnd, userKey = 0;
            List<KeyValuePair<int, double>> lineup = new() { };
            do
            {
                for (int i = 0; i < Data.DriverData().Count; i++)
                {
                    startRndDouble = rnd.NextDouble();
                    startRnd = rnd.Next(10);
                    if (i == user) {
                        userKey = driver[i].Item4;
                        lineup.Add(new KeyValuePair<int, double>(userKey, 50)); }
                    else
                        lineup.Add(new KeyValuePair<int, double>(driver[i].Item4, startRnd + driver[i].Item6.Item1 - startRndDouble));
                }
            } while (lineup.Count != lineup.Distinct().Count());
            lineup.Sort((x, y) => x.Value.CompareTo(y.Value));
            for (int i = 0; i < Data.DriverData().Count; i++)
            {
                if (lineup[i].Key == userKey)
                {
                    var item = new KeyValuePair<int, double>(userKey, 50);
                    lineup.RemoveAt(i);
                    lineup.Insert(qualification, item);
                    break;
                }
            }
            return lineup;
        }
        public static List<KeyValuePair<int, double>> RaceLineup(int userKey, int newPos, List<KeyValuePair<int, double>> lineup, List<KeyValuePair<int, double>> listDNF)
        {
            var driver = Data.DriverData();
            Random rnd = new();
            double raceRndDouble;
            int raceRnd;
            do
            {
                for (int i = 0; i < driver.Count; i++)
                {
                    for (int j = 0; j < lineup.Count; j++)
                    {
                        if (lineup[j].Key == driver[i].Item4)
                        {
                            bool driverDNF = false;
                            raceRnd = rnd.Next(5);
                            for (int n = 0; n < listDNF.Count; n++)
                            {
                                if (listDNF[n].Key == driver[i].Item4)
                                {
                                    driverDNF = true;
                                    raceRnd = (int)listDNF[n].Value;
                                    break;
                                }
                            }
                            if (raceRnd == 0)
                                raceRnd = rnd.Next(5, 10);
                            raceRndDouble = rnd.NextDouble();
                            if (driverDNF)
                                lineup[j] = new KeyValuePair<int, double>(driver[i].Item4, raceRnd + raceRndDouble);
                            else
                                lineup[j] = new KeyValuePair<int, double>(driver[i].Item4, (j + 1.2) * (1.1 + raceRndDouble) + (driver[i].Item6.Item2 / 1.69 - raceRnd * (raceRndDouble * 3.71)));
                            break;
                        }
                    }
                }
            } while (lineup.Count != lineup.Distinct().Count());
            lineup.Sort((x, y) => x.Value.CompareTo(y.Value));
            for (int i = 0; i < lineup.Count; i++)
            {
                if (lineup[i].Key == userKey)
                {
                    var item = new KeyValuePair<int, double>(userKey, 100);
                    lineup.RemoveAt(i);
                    lineup.Insert(newPos, item);
                    break;
                }
            }
            return lineup;
        }
    }
    public class QuickRace
    {
        public static void NormalRace(bool random)
        {
            Data data = new();
            Random rnd = new();
            ConsoleKeyInfo key;
            var driver = Data.DriverData();
            int rndNumber = rnd.Next(1, 100), selPreRace = 1, userKey = 0;
            for (int i = 0; i < Data.DriverData().Count; i++)
                while (Data.DriverData()[i].Item4 == rndNumber)
                    rndNumber = rnd.Next(1, 100);
            int circuit = rnd.Next(Data.CircuitData().Count);
            var userTeamNumber = new List<Tuple<int, int>>
            { new Tuple<int, int>(rnd.Next(Data.DriverData().Count), rndNumber) };
            if (random == false) {
                circuit = CircuitSelector.CircuitListing();
                userTeamNumber = TeamSelector.TeamListing(); }
            int qualifying = QPlayOrSkip.PlayOrSkipQ(circuit, userTeamNumber[0].Item1 / 2);
            var startingLineup = LineupGenerator.StartingLineup(userTeamNumber[0].Item1, qualifying);
            QGraphics.QLineup(startingLineup, userTeamNumber);
            WeatherSet.Weather weather = WeatherSet.WeatherFormula(Data.CircuitData()[circuit].Item6);
            string userTeamColor = Colors.Teams()[userTeamNumber[0].Item1 / 2];
            do
            {
                Util.ClearPart(0);
                Console.WriteLine(Colors.Gray + "Sunday, " + Data.CircuitData()[circuit].Item3 + ' ' + Data.CircuitData()[circuit].Item4 + ", " + 2023 + '\n' + Colors.White + Data.CircuitData()[circuit].Item5 + " Grand Prix " + userTeamColor + ">" + Colors.White + " Race\n" + Colors.Gray + Data.CircuitData()[circuit].Item2 + '\n');
                do
                {
                    switch (selPreRace)
                    {
                        case 1:
                            Console.Write(userTeamColor + "Starting Lineup");
                            if (userTeamNumber[0].Item1 / 2 == 9)
                                Console.Write(Colors.Teams()[2] + " <");
                            Console.WriteLine(Colors.White + "\nCircuit View  \nWeather Forcast  \nStart the Race  ");
                            break;
                        case 2:
                            Console.Write(Colors.White + "Starting Lineup  " + '\n' + userTeamColor + "Circuit View");
                            if (userTeamNumber[0].Item1 / 2 == 9)
                                Console.Write(Colors.Teams()[2] + " <");
                            Console.WriteLine(Colors.White + "\nWeather Forcast  \nStart the Race  ");
                            break;
                        case 3:
                            Console.Write(Colors.White + "Starting Lineup  \nCircuit View  " + '\n' + userTeamColor + "Weather Forcast");
                            if (userTeamNumber[0].Item1 / 2 == 9)
                                Console.Write(Colors.Teams()[2] + " <");
                            Console.WriteLine(Colors.White + "\nStart the Race  ");
                            break;
                        case 4:
                            Console.Write(Colors.White + "Starting Lineup  \nCircuit View  \nWeather Forcast  " + '\n' + userTeamColor + "Start the Race");
                            if (userTeamNumber[0].Item1 / 2 == 9)
                                Console.WriteLine(Colors.Teams()[2] + " <");
                            else
                                Console.WriteLine();
                                break;
                    }
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                        selPreRace = Math.Min(selPreRace + 1, 4);
                    else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                        selPreRace = Math.Max(selPreRace - 1, 1);
                    Console.SetCursorPosition(0, Console.CursorTop - 4);
                } while (key.Key != ConsoleKey.Enter);
                if (selPreRace == 1)
                {
                    Util.ClearPart(0);
                    Console.WriteLine(Colors.Gray + "Sunday, " + Data.CircuitData()[circuit].Item3 + ' ' + Data.CircuitData()[circuit].Item4 + ", " + 2023 + '\n' + Colors.White + Data.CircuitData()[circuit].Item5 + " Grand Prix " + userTeamColor + ">" + Colors.White + " Race " + userTeamColor + ">" + Colors.White + " Starting Lineup\n" + Colors.Gray + Data.CircuitData()[circuit].Item2 + '\n');
                    #region
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine(Colors.Dark + "[Space] to speed up");
                    Console.SetCursorPosition(0, 4);
                    int number = 1, delay = 1;
                    foreach (var val in startingLineup)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            if (val.Key == Data.DriverData()[j].Item4)
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
                                    Console.Write($"\x1b[38;5;{i}m");
                                    if (number < 10)
                                        Console.Write(" ");
                                    if (j == userTeamNumber[0].Item1)
                                    {
                                        Console.Write(number + Colors.Teams()[j / 2] + $"|" + $"\x1b[38;5;{i}m" + data.UserData()[1].Item4 + " ");
                                        if (userTeamNumber[0].Item2 < 10)
                                            Console.Write(" ");
                                        Console.WriteLine(Colors.Teams()[j / 2] + userTeamNumber[0].Item2 + $"\x1b[38;5;{i - 2}m " + data.UserData()[1].Item3 + Colors.Teams()[j / 2] + " <");
                                    }
                                    else
                                    {
                                        Console.Write(number + Colors.Teams()[j / 2] + $"|" + $"\x1b[38;5;{i}m" + Data.DriverData()[j].Item3 + " ");
                                        if (Data.DriverData()[j].Item4 < 10)
                                            Console.Write(" ");
                                        Console.WriteLine(Colors.Teams()[j / 2] + Data.DriverData()[j].Item4 + $"\x1b[38;5;{i - 2}m " + Data.DriverData()[j].Item2);
                                    }
                                    if (i < 254)
                                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    Task.Delay(delay).Wait();
                                }
                                break;
                            }
                        }
                        number++;
                    }
                    Console.WriteLine(Colors.Dark + "[Escape]            ");
                    Util.KeyAdvance(ConsoleKey.Escape);
                    #endregion
                }
                else if (selPreRace == 2)
                {
                    Util.ClearPart(0);
                    Console.WriteLine(Colors.Gray + "Sunday, " + Data.CircuitData()[circuit].Item3 + ' ' + Data.CircuitData()[circuit].Item4 + ", " + 2023 + '\n' + Colors.White + Data.CircuitData()[circuit].Item5 + " Grand Prix " + userTeamColor + ">" + Colors.White + " Race " + userTeamColor + ">" + Colors.White + " Circuit View\n" + Colors.Gray + Data.CircuitData()[circuit].Item2 + Colors.Dark + " [Escape]" + '\n');
                    DisplayCircuitRace.CircuitsRace(circuit);
                }
                else if (selPreRace == 3)
                {
                    Util.ClearPart(0);
                    Console.WriteLine(Colors.Gray + "Sunday, " + Data.CircuitData()[circuit].Item3 + ' ' + Data.CircuitData()[circuit].Item4 + ", " + 2023 + '\n' + Colors.White + Data.CircuitData()[circuit].Item5 + " Grand Prix " + userTeamColor + ">" + Colors.White + " Race " + userTeamColor + ">" + Colors.White + " Weather Forcast\n" + Colors.Gray + Data.CircuitData()[circuit].Item2 + Colors.Dark + " [Escape]" + '\n');
                    WeatherSet.WeatherGraphics(weather);
                }
            } while (selPreRace != 4);
            var lineup = RaceUpdate.LineupUpdate(startingLineup);
            Util.ClearPart(0);
            Console.WriteLine(Colors.Gray + "Sunday, " + Data.CircuitData()[circuit].Item3 + ' ' + Data.CircuitData()[circuit].Item4 + ", " + 2023 + '\n' + Colors.White + Data.CircuitData()[circuit].Item5 + " Grand Prix " + userTeamColor + ">" + Colors.White + " Race " + userTeamColor + ">" + Colors.White + " Formation Lap\n" + Colors.Gray + Data.CircuitData()[circuit].Item2 + '\n');
            Console.SetCursorPosition(0, 5);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(Colors.White);
                for (int j = 0; j < 20; j++)
                {
                    if (startingLineup[i].Key == Data.DriverData()[j].Item4)
                    {
                        if (i % 2 == 0)
                            Console.SetCursorPosition(5, Console.CursorTop);
                        else
                            Console.SetCursorPosition(18, Console.CursorTop);
                        if (j == userTeamNumber[0].Item1)
                        { Console.WriteLine($"{data.UserData()[1].Item4}{Colors.Teams()[j / 2]}⌠{Colors.Dark}{data.UserData()[1].Item3}"); userKey = startingLineup[i].Key; }
                        else
                            Console.WriteLine($"{Data.DriverData()[j].Item3}{Colors.Teams()[j / 2]}⌠{Colors.Darker}{Data.DriverData()[j].Item2}");
                        break;
                    }
                }
            }
            Assets.RedLights(4, 1000);
            Task.Delay(1000).Wait();
            Util.ClearPart(0);

            int newPos = 0, oldPos = 0, score = 0, totalLaps = Data.CircuitData()[circuit].Item7, pitCount = 0, noRepeats = 0, randomMiniGame = 0, miniGameCounter = 1, winner = 0, flHolder = 0;
            string posIndicator;
            bool fLPlayed = false, userDNF = false;
            var listDNF = new List<KeyValuePair<int, double>> { };
            for (int lap = 1; lap <= Data.CircuitData()[circuit].Item7;)
            {
                Console.WriteLine(Colors.Gray + $"{listDNF.Count}Sunday, " + Data.CircuitData()[circuit].Item3 + ' ' + Data.CircuitData()[circuit].Item4 + ", " + 2023 + '\n' + Colors.White + Data.CircuitData()[circuit].Item5 + " Grand Prix " + userTeamColor + ">" + Colors.White + " Race " + userTeamColor + ">" + Colors.White + $" Lap {lap}/{totalLaps}\n");
                if (userDNF == false)
                {
                    while (randomMiniGame == noRepeats)
                    { randomMiniGame = rnd.Next(3); }
                    Console.Write($"{Colors.White}Challenge {miniGameCounter} · ");
                    miniGameCounter++;
                    Util.ClearKey();
                    if (lap == 1)
                    { score = MiniGames.RedLights(); lap++; }
                    else if (randomMiniGame == 0 && lap > 3 && oldPos != 1)
                        score = MiniGames.DRS();
                    else if (randomMiniGame == 1 && lap > totalLaps / 3 && (pitCount == 0 || pitCount == 4) && lap < totalLaps - totalLaps / 10)
                    { score = MiniGames.BoxBox(); pitCount++; }
                    else if (randomMiniGame == 2 && lap > totalLaps / 2 && !fLPlayed)
                    { score = MiniGames.FastestLap(circuit); fLPlayed = true; flHolder = userKey; }
                    else
                    {
                        do
                        {
                            randomMiniGame = rnd.Next(4, 6);
                        } while (randomMiniGame == noRepeats);
                        if (randomMiniGame == 4)
                            score = MiniGames.GearUp(9);
                        else
                            score = MiniGames.Speed();
                    }
                    if (pitCount > 0 && pitCount == 4)
                        pitCount++;
                    noRepeats = randomMiniGame;
                }
                Util.ClearKey();
                driver.Sort((x, y) => y.Item6.Item4.CompareTo(x.Item6.Item4));
                for (int i = 0; i < driver.Count; i++)
                {
                    int randomDNF = rnd.Next(7700 - WeatherSet.DNFModifier(weather));
                    if (driver[i].Item6.Item4 * 10 + 2 > randomDNF && driver[i].Item4 != userKey)
                    {
                        double rndDouble = rnd.NextDouble();
                        listDNF.Add(new KeyValuePair<int, double>(driver[i].Item4, (totalLaps + 10 - lap) * 1000 + rndDouble));
                    }
                }
                for (int i = 0; i < lineup.Count; i++)
                {
                    if (lineup[i].Key == userKey && userDNF == false)
                    {
                        if (score <= -7)
                        {
                            Console.WriteLine(Colors.Teams()[2] + "\rYou're out of the race" + Colors.Dark + " [Enter]                            ");
                            Util.KeyAdvance(ConsoleKey.Enter);
                            double rndDouble = rnd.NextDouble();
                            userDNF = true;
                            listDNF.Add(new KeyValuePair<int, double>(userKey, lap * 1000 + rndDouble));
                            newPos = 20 - listDNF.Count;
                        }
                        else 
                            newPos = Math.Max(0, Math.Min(i - score, 19 - listDNF.Count));
                        oldPos = i;
                        break;
                    }
                }
                Util.ClearPart(3);
                lineup = LineupGenerator.RaceLineup(userKey, newPos, lineup, listDNF);
                driver.Sort((x, y) => y.Item6.Item3.CompareTo(x.Item6.Item3));
                int flNumber = 0, randomFL = rnd.Next(170);
                for (int i = 0; i < driver.Count && flHolder != userKey; i++)
                {
                    bool driverDNF = false;
                    flNumber += driver[i].Item6.Item3 * 5 + 5;
                    for (int j = 0; j < listDNF.Count; j++)
                    {
                        if (listDNF[j].Key == driver[i].Item4)
                        {  
                            driverDNF = true;
                            break;
                        }
                    }
                    if (driverDNF == false && driver[i].Item4 != userKey)
                    {
                        if (driver[i].Item4 == flHolder)
                            randomFL -= (driver[i].Item6.Item3 + 4) * 4;
                        if (randomFL <= flNumber)
                        {
                            flHolder = driver[i].Item4;
                            break;
                        }
                    }
                }
                if (userDNF)
                    posIndicator = Colors.Gray + "OUT" + Colors.Custom(0, 0, 0);
                else if (oldPos == newPos)
                    posIndicator = Colors.Gray + "◄" + Colors.Dark;
                else if (oldPos < newPos)
                    posIndicator = Colors.Teams()[2] + "▼" + Colors.Custom(120, 0, 0);
                else
                    posIndicator = Colors.Green + "▲" + Colors.Custom(0, 120, 0);
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(Colors.White);
                    for (int j = 0; j < 20; j++)
                    {
                        if (lineup[i].Key == Data.DriverData()[j].Item4)
                        {
                            string fl = " ";
                            if (Data.DriverData()[j].Item4 == flHolder)
                                fl = Colors.Magenta + "♦";
                            if (lap == totalLaps && i == 0)
                            {
                                if (j == userTeamNumber[0].Item1)
                                    winner = 20;
                                else
                                    winner = j;
                            }
                            string space = "";
                            if (i < 9)
                                space = " ";
                            string partOne = $"{space}{Colors.Grayer}{i + 1} {Colors.White}";
                            for (int n = 0; n < listDNF.Count; n++)
                            {
                                if (listDNF[n].Key == Data.DriverData()[j].Item4) {
                                    partOne = $"{Colors.Dark}-- {Colors.Grayer}";
                                    break; }
                            }
                            if (j == userTeamNumber[0].Item1)
                                Console.WriteLine($"{partOne}{data.UserData()[1].Item4}{fl}{Colors.Teams()[j / 2]}|{Colors.Dark}{data.UserData()[1].Item3} {posIndicator + " " + (oldPos - newPos)}");
                            else
                                Console.WriteLine($"{partOne}{Data.DriverData()[j].Item3}{fl}{Colors.Teams()[j / 2]}|{Colors.Darker}{Data.DriverData()[j].Item2}");
                            break;
                        }
                    }
                }
                Util.ClearKey();
                Util.KeyAdvance(ConsoleKey.Enter);
                Util.ClearPart(0);
                if (lap == totalLaps)
                    lap++;
                else
                    lap = Math.Min(totalLaps, lap + totalLaps / 10);
            }
            Play.Anthem(winner);
        }
    }
    public class Play
    {
        public static void Anthem(int winner)
        {
            ConsoleKeyInfo key;
            Data data = new();
            bool timeout = true;
            int skip = 0;
            string driverCountry, the = "", path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            if (winner < 20)
                driverCountry = Data.DriverData()[winner].Item5;
            else
                driverCountry = data.UserData()[1].Item5;
            Console.WriteLine(Colors.Gray + "Finish the race" + Colors.Dark + " [Enter]" + Colors.White);
            Util.KeyAdvance(ConsoleKey.Enter);
            if (driverCountry == "United Kingdom" || driverCountry == "United States" || driverCountry == "Netherlands")
                the = "the ";
            Console.Write(Colors.White + "The winner is ");
            if (winner < 20)
                Console.WriteLine(Data.DriverData()[winner].Item2 + $"\nThe natonal anthem of {the}{driverCountry} is playing");
            else
                Console.WriteLine(data.UserData()[1].Item3 + $"\nThe natonal anthem of {the}{driverCountry} is playing");
            try
            {
                using VorbisWaveReader reader = new(@$"{path}\Sound\{driverCountry}.ogg");
                using WaveOutEvent waveOut = new();
                waveOut.Init(reader);
                waveOut.Play();
                while (skip != 10)
                {
                    Task.Delay(80).Wait();
                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Spacebar)
                        {
                            skip++;
                            timeout = false;
                        }
                    }
                    if (skip > 0 && timeout == true)
                        skip--;
                    Console.Write(Colors.Dark + "\rHold [Space] to skip");
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
                    while (Console.KeyAvailable)
                        Console.ReadKey(false);
                    timeout = true;
                    if (skip == 10)
                        waveOut.Dispose();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No anthem available");
                Util.KeyAdvance(ConsoleKey.Enter);
            }
            Console.Clear();
        }
    }
    public class WeatherSet 
    {
        public static int DNFModifier(Weather weather)
        {
            int modifier = 0;
            switch (weather)
            {
                case Weather.Sunny:
                    modifier = 350;
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
            ConsoleKeyInfo key;
            switch (weather)
            {
                case Weather.Sunny:
                    Console.WriteLine(Colors.Sun + "      ____" + '\n' + "    .-    -.     " + Colors.White + "It's Sunny" + '\n' + Colors.Sun + @"   /        \" + '\n' + "  |          |" + '\n' + @"   \        /" + '\n' + "    '-____-'");
                    break;
                case Weather.PartlyCloudy:
                    Console.WriteLine(Colors.Sun + $"      ____\n    .-    -.     {Colors.White}It's Partly Cloudy\n{Colors.Sun}   /    {Colors.LessGray}.--.{Colors.Sun}\\\n  |  {Colors.LessGray}.-(    ).{Colors.Sun}\n   \\{Colors.LessGray}(___.__)__)\n{Colors.Sun}    '-____-'");
                    break;
                case Weather.Cloudy:
                    Console.WriteLine(Colors.LessGray +  "      .--.       " + Colors.White + "It's cloudy" + '\n' + Colors.LessGray + "   .-(    )." + '\n' + "  (___.__)__)");
                    break;
                case Weather.SlightRain:
                    Console.WriteLine(Colors.LessGray +  "      .--.       " + Colors.White + "It's raining" + '\n' + Colors.LessGray + "   .-(    ).     " + Colors.White + $"Intensity: 1\n  {Colors.LessGray}(___.__)__)\n   {Colors.Rain} |  |  |");
                    break;
                case Weather.ModerateRain:
                    Console.WriteLine(Colors.LessGray +  "      .--.       " + Colors.White + "It's raining" + '\n' + Colors.LessGray + "   .-(    ).     " + Colors.White + $"Intensity: 2\n  {Colors.LessGray}(___.__)__)\n   {Colors.Rain}| | | | |");
                    break;
                case Weather.HeavyRain:
                    Console.WriteLine(Colors.LessGray +  "      .--.       " + Colors.White + "It's raining" + '\n' + Colors.LessGray + "   .-(    ).     " + Colors.White + $"Intensity: 3\n  {Colors.LessGray}(___.__)__)\n   {Colors.Rain}|||||||||");
                    break;
            }
            Util.KeyAdvance(ConsoleKey.Escape);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Write("\x1b[48;2;0;0;0m");
            Console.Clear();
            Data.LoadDifficulty();
            Data data = new();
            data.UserData();
            Intro.IntroLogo();
            while (true)
            {
                Display.Logo();
                Util.ClearKey();
                short mode = Menu.MainMenu();
                if (mode == 0)
                    QuickRace.NormalRace(true);
                else if (mode == 1)
                    QuickRace.NormalRace(false);
                else if (mode == 4)
                    break;
                Console.Clear();
            }
        }
    }
}