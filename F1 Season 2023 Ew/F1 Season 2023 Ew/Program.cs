using NAudio.Vorbis;
using System.Text;
using VisioForge.MediaFramework.Helpers;
using WaveOutEvent = NAudio.Wave.WaveOutEvent;

namespace F1_Season_2023_Ew
{

    public class Data
    {
        public bool ChangeUserData = false;
        public static int Difficulty { get; set; }
        public static void LoadDifficulty()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            StreamReader difficultyR = new(@$"{path}\UserData\Difficulty.txt");
            Difficulty = Convert.ToInt32(difficultyR.ReadLine());
            difficultyR.Close();
        }
        public static void SaveDifficulty()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            StreamWriter difficultyW = new(@$"{path}\UserData\Difficulty.txt");
            difficultyW.Write(Difficulty);
            difficultyW.Close();
        }
        public static List<Tuple<string, string, string, int, string, int, int>> CircuitData() => new()
            {      //country          venue                 date             GP             rain% laps 
                new("Bahrain",       "Sakhir",             "March", 5,      "Bahrain",         2, 57),
                new("Saudi Arabia",  "Jeddah",             "March", 19,     "Saudi Arabian",   0, 50),
                new("Australia",     "Albert Park",        "April", 2,      "Austrlian",      17, 58),
                new("Azerbaijan",    "Baku",               "April", 30,     "Azerbaijan",     16, 51),
                new("USA",           "Miami",              "May", 7,        "Miami",          23, 57),
                new("Italy",         "Imola",              "May", 21,       "Emilia Romagna", 15, 63),
                new("Monaco",        "Monaco",             "May", 28,       "Monaco",          7, 78),
                new("Spain",         "Catalunya",          "June", 4,       "Spanish",        17, 66),
                new("Canada",        "Gilles Villeneuve",  "June", 18,      "Canadian",       19, 70),
                new("Austria",       "Red Bull Ring",      "July", 2,       "Austrian",       19, 71),
                new("Great Britain", "Silverstone",        "July", 9,       "British",        31, 52),
                new("Hungary",       "Hungaroring",        "July", 23,      "Hungarian",      21, 70),
                new("Belgium",       "Spa",                "July", 30,      "Belgian",        46, 44),
                new("Netherlands",   "Zandvoort",          "August", 27,    "Dutch",          22, 72),
                new("Italy",         "Monza",              "September", 3,  "Italian",        20, 53),
                new("Singapore",     "Marina Bay",         "September", 17, "Singapore",      38, 61),
                new("Japan",         "Suzuka",             "September", 24, "Japanese",       40, 53),
                new("Qatar",         "Losail",             "October", 8,    "Qatar",           1, 57),
                new("USA",           "COTA",               "October", 22,   "United States",  16, 56),
                new("Mexico",        "Hermanos Rodriguez", "October", 29,   "Mexican",        17, 71),
                new("Brazil",        "Interlagos",         "November", 5,   "Sao Paulo",      35, 71),
                new("USA",           "Las Vegas",          "November", 18,  "Las Vegas",      18, 50),
                new("Abu Dhabi",     "Yas Marina",         "November", 26,  "Abu Dhabi",       3, 58),
                new("Portugal",      "Portimao",           "April", 16,     "Portugese",      15, 66)
            };
        public static List<string> TeamList() => new() { 
            "Mercedes    ",
            "Red Bull    ",
            "Ferrari     ",
            "McLaren     ",
            "Alpine      ",
            "AlphaTauri  ",
            "Aston Martin",
            "Williams    ",
            "Alfa Romeo  ",
            "Haas F1 Team"
        };
        public static List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> DriverData() => new()
            {     //Team            Full Name         SrtNm  Num  Country          Race Data    AG     AF    FL DNF
                new(TeamList()[0], "Lewis Hamilton",  "HAM", 44, "United Kingdom", Tuple.Create( 6.31,  4.31, 2, 2)),
                new(TeamList()[0], "George Russell",  "RUS", 63, "United Kingdom", Tuple.Create( 6.49,  5.48, 4, 2)),
                new(TeamList()[1], "Max Verstappen",  "VER",  1, "Netherlands",    Tuple.Create( 3.21,  2.15, 5, 2)),
                new(TeamList()[1], "Sergio Perez",    "PER", 11, "Mexico",         Tuple.Create( 4.52,  3.86, 3, 3)),
                new(TeamList()[2], "Charles Leclerc", "LEC", 16, "Monaco",         Tuple.Create( 3.91,  3.42, 3, 3)),
                new(TeamList()[2], "Carlos Sainz",    "SAI", 55, "Spain",          Tuple.Create( 4.83,  4.85, 2, 7)),
                new(TeamList()[3], "Lando Norris",    "NOR",  4, "United Kingdom", Tuple.Create(10.95, 10.98, 2, 2)),
                new(TeamList()[3], "Oscar Piastri",   "PIA", 81, "Australia",      Tuple.Create(12.85, 12.89, 0, 3)),
                new(TeamList()[4], "Esteban Ocon",    "OCO", 31, "France",         Tuple.Create(11.84,  9.89, 0, 2)),
                new(TeamList()[4], "Pierre Gasly",    "GAS", 10, "France",         Tuple.Create(12.28, 12.18, 0, 3)),
                new(TeamList()[5], "Yuki Tsunoda",    "TSU", 22, "Japan",          Tuple.Create(14.00, 12.81, 0, 5)),
                new(TeamList()[5], "Nyck de Vries",   "DEV", 21, "Netherlands",    Tuple.Create(14.00, 12.75, 0, 3)),
                new(TeamList()[6], "Lance Stroll",    "STR", 18, "Canada",         Tuple.Create(12.62, 10.25, 0, 3)),
                new(TeamList()[6], "Fernando Alonso", "ALO", 14, "Spain",          Tuple.Create( 7.00,  7.00, 0, 5)),
                new(TeamList()[7], "Alexander Albon", "ALB", 23, "Thailand",       Tuple.Create(15.42, 12.89, 0, 5)),
                new(TeamList()[7], "Logan Sargeant",  "SAR",  2, "United States",  Tuple.Create(15.42, 14.22, 0, 5)),
                new(TeamList()[8], "Valtteri Bottas", "BOT", 77, "Finland",        Tuple.Create(11.32, 10.31, 0, 6)),
                new(TeamList()[8], "Zhou Guanyu",     "ZHO", 24, "China",          Tuple.Create(14.24, 12.48, 1, 6)),
                new(TeamList()[9], "Kevin Magnussen", "MAG", 20, "Denmark",        Tuple.Create(12.01, 13.15, 0, 5)),
                new(TeamList()[9], "Nico Hulkenberg", "HUL", 27, "Germany",        Tuple.Create(13.09, 13.42, 0, 3))
            };
        public static List<int> DriverNumbers()
        {
            var driverNumbers = new List<int>();
            for (int i = 0; i < DriverData().Count; i++)
                driverNumbers.Add(DriverData()[i].Item4);
            return driverNumbers;
        }
        public List<Tuple<string?, string?, string?, string?, string?>> UserData()
        {
            var userData = new List<Tuple<string?, string?, string?, string?, string?>>
            { new("FirstName", "LastName", "Full Name", "SHN", "Nationality") };
            string? firstName, lastName, fullName, shortName, nationality, firstNameRead = "", workingDirectory = Environment.CurrentDirectory, path = Directory.GetParent(workingDirectory).Parent.Parent.FullName, blankSpace = "";
            try
            {
                StreamReader saveFileR = new(@$"{path}\UserData\SaveFile.txt");
                firstNameRead = saveFileR.ReadLine();
                if (firstNameRead.IsNullOrEmpty() == false)
                {
                    firstName = firstNameRead;
                    lastName = saveFileR.ReadLine();
                    fullName = saveFileR.ReadLine();
                    shortName = saveFileR.ReadLine();
                    nationality = saveFileR.ReadLine();
                    userData[0] = new(firstName, lastName, fullName, shortName, nationality);
                }
                saveFileR.Close();
            }
            catch
            { 
                Console.WriteLine($"{Colors.White}Can't read save file\nCheck this path - " + @$"{Colors.Gold}{path}\UserData\SaveFile.txt{Colors.White}");
                Util.KeyAdvance(ConsoleKey.Enter);
                Util.ClearPart(0);
            }
            if (firstNameRead.IsNullOrEmpty() || ChangeUserData)
            {
                if (ChangeUserData)
                    blankSpace = "              ";
                Console.Write($"\n{blankSpace}     /What's your first name?" + '\n' + Colors.Teams()[2] + $"{blankSpace}    /" + Colors.White);
                firstName = Console.ReadLine().Trim();
                firstName = UserInfoAdjuster(firstName, UserInfoType.firstName);
                Console.SetCursorPosition(0, Console.CursorTop - 2);
                Console.Write($"{blankSpace}     /And your last name?    " + '\n' + Colors.Teams()[2] + $"{blankSpace}    /{firstName} " + Colors.White);
                lastName = Console.ReadLine().Trim();
                lastName = UserInfoAdjuster(lastName, UserInfoType.lastName);
                fullName = firstName + " " + lastName;
                shortName = ShortNameCreator(firstName, lastName);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write($"{Colors.Teams()[2]}{blankSpace}    /{fullName}" + Colors.White + $"\n{blankSpace}   /Where are you from?" + '\n' + Colors.Teams()[2] + $"{blankSpace}  /" + Colors.White);
                nationality = Console.ReadLine().Trim();
                nationality = UserInfoAdjuster(nationality, UserInfoType.nationality);
                userData[0] = new(firstName, lastName, fullName, shortName, nationality);
                Console.SetCursorPosition(0, Console.CursorTop - 4);
                try
                {
                    StreamWriter saveFileW = new(@$"{path}\UserData\SaveFile.txt");
                    saveFileW.WriteLine(firstName);
                    saveFileW.WriteLine(lastName);
                    saveFileW.WriteLine(fullName);
                    saveFileW.WriteLine(shortName);
                    saveFileW.WriteLine(nationality);
                    saveFileW.Close();
                }
                catch
                {
                    Console.WriteLine($"{Colors.White}Can't save user data\nCheck this path - " + @$"{Colors.Gold}{path}\UserData\SaveFile.txt{Colors.White}");
                    Util.KeyAdvance(ConsoleKey.Enter);
                    Util.ClearPart(0);
                }
            }
            return userData;
        }
        private static string ShortNameCreator(string? firstName, string? lastName)
        {
            string? shortName;
            if (lastName.Length == 3)
                shortName = lastName;
            else if (firstName.Length + lastName.Length < 3)
                shortName = firstName + lastName;
            else if (firstName.Length + lastName.Length == 3)
                shortName = firstName + lastName;
            else if (firstName.Length > 2 && lastName.Length < 3)
                shortName = firstName.Remove(3);
            else if (firstName.Length > 1 && lastName.Length == 1)
                shortName = firstName.Remove(2) + lastName;
            else if (firstName.Length > 1 && lastName.Length < 3)
                shortName = firstName.Remove(1) + lastName;
            else
                shortName = lastName.Remove(3);
            shortName = shortName.ToUpper();
            return shortName;
        }
        private static string? UserInfoAdjuster(string? @string, UserInfoType userInfoType)
        {
            if (@string.IsNullOrEmpty())
            {
                if (userInfoType == UserInfoType.firstName)
                    @string = "John";
                else if (userInfoType == UserInfoType.lastName)
                    @string = "Doe";
                else if (userInfoType == UserInfoType.nationality)
                    @string = "SeaLand";
            }
            else if (@string.Length == 1)
                @string = @string.ToUpper();
            else if (@string.Length > 13)
                @string = @string.Remove(1).ToUpper() + @string.Remove(0, 1).Remove(13).ToLower();
            else
                @string = @string.Remove(1).ToUpper() + @string.Remove(0, 1).ToLower();
            return @string;
        }
        private enum UserInfoType
        {
            firstName,
            lastName,
            nationality
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
            var driverNumbers = Data.DriverNumbers();
            Console.Clear();
            do
            {
                do
                {
                    Console.WriteLine(Colors.White + "Choose a team & who to replace " + Colors.Teams()[selTeam] + data.UserData()[0].Item3 + '\n');
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


                Console.WriteLine('\n' + Colors.Teams()[selTeam] + "|" + Colors.White + "Pick your number" + Colors.Teams()[selTeam] + "|");
                for (bool numberPicked = false; numberPicked == false;)
                {
                    for (int i = 0; driverNumbers.Contains(userNumber) && userNumber != driverNumbers[replace];)
                    {
                        if (i > 19)
                            userNumber--;
                        else if (i < -19)
                            userNumber++;
                        else if (userNumber >= 50)
                        { userNumber = Math.Max(userNumber - 1, 1); i--; }
                        else if (userNumber < 50)
                        { userNumber = Math.Min(userNumber + 1, 99); i++; }
                    }
                    if (Console.KeyAvailable)
                        Console.ReadKey(false);
                    Console.Write(Colors.Teams()[selTeam] + "\r└─┤" + Colors.LessGray + "   < ");
                    if (userNumber < 10)
                        Console.Write(Colors.Gray + 0);
                    Console.Write(Colors.Teams()[selTeam] + userNumber + Colors.LessGray + " >  " + Colors.Teams()[selTeam] + " ├─┘");
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                        userNumber = Math.Max(userNumber - 10, 1);
                    else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                        userNumber = Math.Min(userNumber + 10, 99);
                    else if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D)
                        userNumber = Math.Min(userNumber + 1, 99);
                    else if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A)
                        userNumber = Math.Max(userNumber - 1, 1);
                    for (int i = 0; driverNumbers.Contains(userNumber) && userNumber != driverNumbers[replace];)
                    {                        
                        if (i > 19)
                            userNumber--;
                        else if (i < -19)
                            userNumber++;
                        else if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A)
                        { userNumber = Math.Max(userNumber - 1, 1); i--; }
                        else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D)
                        { userNumber = Math.Min(userNumber + 1, 99); i++; }
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
            { new Tuple<int, int>(replace, userNumber) };
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
                                raceRnd = rnd.Next(5, 9);
                            raceRndDouble = rnd.NextDouble();
                            if (driverDNF)
                                lineup[j] = new KeyValuePair<int, double>(driver[i].Item4, raceRnd + raceRndDouble);
                            else
                                lineup[j] = new KeyValuePair<int, double>(driver[i].Item4, (j + 1.4) * (1 + raceRndDouble) + (driver[i].Item6.Item2 / 1.5 - raceRnd * (raceRndDouble * 3.5)));
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
        public static void NormalRace(bool randomStart)
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
            if (randomStart == false) {
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
                            Console.WriteLine(Colors.LessGray + "\nCircuit View  \nWeather Forcast  \nStart the Race  ");
                            break;
                        case 2:
                            Console.Write(Colors.LessGray + "Starting Lineup  " + '\n' + userTeamColor + "Circuit View");
                            if (userTeamNumber[0].Item1 / 2 == 9)
                                Console.Write(Colors.Teams()[2] + " <");
                            Console.WriteLine(Colors.LessGray + "\nWeather Forcast  \nStart the Race  ");
                            break;
                        case 3:
                            Console.Write(Colors.LessGray + "Starting Lineup  \nCircuit View  " + '\n' + userTeamColor + "Weather Forcast");
                            if (userTeamNumber[0].Item1 / 2 == 9)
                                Console.Write(Colors.Teams()[2] + " <");
                            Console.WriteLine(Colors.LessGray + "\nStart the Race  ");
                            break;
                        case 4:
                            Console.Write(Colors.LessGray + "Starting Lineup  \nCircuit View  \nWeather Forcast  " + '\n' + userTeamColor + "Start the Race");
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
                    #region display grid
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
                                        Console.Write(number + Colors.Teams()[j / 2] + $"|" + $"\x1b[38;5;{i}m" + data.UserData()[0].Item4 + " ");
                                        if (userTeamNumber[0].Item2 < 10)
                                            Console.Write(" ");
                                        Console.WriteLine(Colors.Teams()[j / 2] + userTeamNumber[0].Item2 + $"\x1b[38;5;{i - 2}m " + data.UserData()[0].Item3 + Colors.Teams()[j / 2] + " <");
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
                        { Console.WriteLine($"{data.UserData()[0].Item4}{Colors.Teams()[j / 2]}⌠{Colors.Dark}{data.UserData()[0].Item3}"); userKey = startingLineup[i].Key; }
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
            Assets.Flag flag = Assets.Flag.Green, lastFlag = Assets.Flag.Green;
            bool fLPlayed = false, userDNF = false, redFlag = false, yellowFlag = false;
            var listDNF = new List<KeyValuePair<int, double>> { };
            for (int lap = 1; lap <= Data.CircuitData()[circuit].Item7;)
            {
                Console.WriteLine(Colors.Gray + $"Sunday, " + Data.CircuitData()[circuit].Item3 + ' ' + Data.CircuitData()[circuit].Item4 + ", " + 2023 + '\n' + Colors.White + Data.CircuitData()[circuit].Item5 + " Grand Prix " + userTeamColor + ">" + Colors.White + " Race " + userTeamColor + ">" + Colors.White + $" Lap {lap}/{totalLaps}\n");
                int listDNFLast = listDNF.Count;

                if (flag == Assets.Flag.Green && lastFlag == Assets.Flag.Green)
                {
                    if (userDNF == false)
                    {
                        while (randomMiniGame == noRepeats)
                        { randomMiniGame = rnd.Next(2); }
                        Util.ClearKey();
                        Console.Write($"\r{Colors.White}Challenge {miniGameCounter} · ");
                        miniGameCounter++;
                        if (lap == 1 || redFlag)
                        { score = MiniGames.RedLights(); redFlag = false; }
                        else if (randomMiniGame == 0 && lap > 3 && newPos != 0)
                            score = MiniGames.DRS();
                        else if (randomMiniGame == 1 && lap > totalLaps / 3 && (pitCount == 0 || pitCount == 4) && lap < totalLaps - totalLaps / 10)
                        { score = MiniGames.BoxBox(); pitCount++; }
                        else if (lap > totalLaps / 2 && !fLPlayed)
                        { score = MiniGames.FastestLap(circuit); fLPlayed = true; if (score > 2) flHolder = userKey; }
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
                        int randomDNF = rnd.Next(7500 - WeatherSet.DNFModifier(weather));
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

                    if (listDNF.Count - listDNFLast > 2 && lap < totalLaps / 4)
                    { flag = Assets.Flag.Red; redFlag = true; }
                    else if (listDNF.Count - listDNFLast > 1)
                    { flag = Assets.Flag.Yellow; yellowFlag = true; }

                    lineup = LineupGenerator.RaceLineup(userKey, newPos, lineup, listDNF);

                    driver.Sort((x, y) => y.Item6.Item3.CompareTo(x.Item6.Item3));
                    int flNumber = 0, randomFL = rnd.Next(170);
                    for (int i = 0; i < driver.Count && flHolder != userKey && lap != 1; i++)
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
                }

                if (lap == totalLaps)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.Write(Colors.Grayer + "▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄");
                }
                if (flag == Assets.Flag.Yellow)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.Write($"\r{Colors.Custom(220, 217, 2)}VIRTUAL SAFETY CAR");
                }
                else if (flag == Assets.Flag.Red)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.Write($"\r{Colors.Custom(235, 20, 10)}RED FLAG");
                }
                else if (flag == Assets.Flag.Green && yellowFlag == true)
                {
                    yellowFlag = false;
                    Console.SetCursorPosition(0, 2);
                    Console.Write($"\r{Colors.Custom(40, 240, 44)}GREEN FLAG");
                }

                lastFlag = flag;
                flag = Assets.Flag.Green;

                if (userDNF)
                    posIndicator = Colors.Gray + "OUT" + Colors.Custom(0, 0, 0);
                else if (oldPos == newPos)
                    posIndicator = Colors.Gray + "◄" + Colors.Dark;
                else if (oldPos < newPos)
                    posIndicator = Colors.Teams()[2] + "▼" + Colors.Custom(120, 0, 0);
                else
                    posIndicator = Colors.Green + "▲" + Colors.Custom(0, 120, 0);
                Util.ClearPart(3);

                Console.SetCursorPosition(0, 3);
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
                                Console.WriteLine($"{partOne}{data.UserData()[0].Item4}{fl}{Colors.Teams()[j / 2]}|{Colors.Dark}{data.UserData()[0].Item3} {posIndicator + " " + (oldPos - newPos)}");
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
            Play.RunningLineStringBuilder(lineup, userKey, flHolder);
            Play.RaceEndScreen(lineup, userKey, userTeamNumber[0].Item2);
            Play.Anthem(winner, circuit, userTeamNumber[0].Item1);
        }
    }
    public class Play
    {
        public static string[] Flag(string country)
        {
            string[] flag = new string[6];
            country = country.ToLower();
            switch (country)
            {
                case "monaco":
                    flag[0] = flag[1] = flag[2] = Colors.Custom(206, 17, 38) + "█████████";
                    flag[3] = flag[4] = flag[5] = Colors.White + "█████████";
                    break;
                case "poland":
                    flag[0] = flag[1] = flag[2] = Colors.White + "█████████";
                    flag[3] = flag[4] = flag[5] = Colors.Custom(220, 20, 60) + "█████████";
                    break;
                case "ukraine":
                    flag[0] = flag[1] = flag[2] = Colors.Custom(0, 87, 183) + "█████████";
                    flag[3] = flag[4] = flag[5] = Colors.Custom(255, 221, 0) + "█████████";
                    break;
                case "united states": 
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = Colors.Custom(179, 25, 66) + "\x1b[48;5;255m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[5] = Colors.Custom(179, 25, 66) + "▀▀▀▀▀▀▀▀▀";
                    break;
                case "spain":
                    flag[5] = flag[0] = Colors.Custom(170, 21, 27) + "█████████";
                    flag[2] = flag[3] = Colors.Custom(241, 191, 0) + "█████████";
                    flag[1] = Colors.Custom(170, 21, 27) + "\x1b[48;2;241;191;0m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[4] = Colors.Custom(170, 21, 27) + "\x1b[48;2;241;191;0m" + "▄▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                case "mexico":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.White + "███" + Colors.Custom(206, 17, 37) + "██████";
                    flag[2] = flag[3] = Colors.Custom(75, 35, 20) + "█" + Colors.White + "██" + Colors.Custom(206, 17, 37) + "██████";
                    break;
                case "france":
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = flag[5] = Colors.White + "███" + Colors.Custom(237, 41, 57) + "██████";
                    break;
                case "italy":
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = flag[5] = Colors.White + "███" + Colors.Custom(205, 33, 42) + "██████";
                    break;
                case "belgium":
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = flag[5] = Colors.Custom(255, 205, 0) + "███" + Colors.Custom(200, 16, 46) + "██████";
                    break;
                case "ireland":
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = flag[5] = Colors.White + "███" + Colors.Custom(255, 130, 0) + "██████";
                    break;
                case "qatar":
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = flag[5] = Colors.White + "\x1b[48;2;138;21;56m" + "►        " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White; ;
                    break;
                case "bahrain":
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = flag[5] = Colors.White + "\x1b[48;2;206;17;38m" + "►        " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White; ;
                    break;
                case "china":
                    flag[0] = flag[3] = Colors.Custom(255, 255, 0) + "\x1b[48;2;238;28;37m" + "   ·     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[1] = Colors.Custom(255, 255, 0) + "\x1b[48;2;238;28;37m" + " ♦  ·    " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[2] = Colors.Custom(255, 255, 0) + "\x1b[48;2;238;28;37m" + "    ·    " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[4] = flag[5] = Colors.Custom(238, 28, 37) + "█████████";
                    break;
                case "united kingdom":
                    flag[0] = "\x1b[48;5;255m" + Colors.Custom(200, 16, 46) + "█" + Colors.White + "█" + Colors.Custom(1, 33, 105) + "▀" + Colors.Custom(200, 16, 46) + " ▄█▀ " + Colors.Custom(1, 33, 105) + "▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[1] = "\x1b[48;5;255m" + Colors.Custom(200, 16, 46) + "█" + Colors.White + "█" + Colors.Custom(200, 16, 46)+ "▄█▀ " + Colors.Custom(1, 33, 105) + "▄██" +"\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[2] = "\x1b[48;5;255m" + Colors.Custom(200, 16, 46) + "\x1b[48;5;255m" + "█▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[3] = "\x1b[48;5;255m" + Colors.Custom(200, 16, 46) + "\x1b[48;5;255m" + "█▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[5] = "\x1b[48;5;255m" + Colors.Custom(200, 16, 46) + "█" + Colors.White + "█" + Colors.Custom(1, 33, 105) + "█▄ " + Colors.Custom(200, 16, 46) + "▀█▄ " +"\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[4] = "\x1b[48;5;255m" + Colors.Custom(200, 16, 46) + "█" + Colors.White + "█" + Colors.Custom(200, 16, 46) + " ▀█▄ " + Colors.Custom(1, 33, 105) + "▀█" +"\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                case "austria":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Custom(239, 51, 64) + "█████████";
                    flag[2] = flag[3] = Colors.White + "█████████";
                    break;
                case "argentina":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Custom(108, 172, 228) + "█████████";
                    flag[2] = Colors.Custom(255, 184, 28) + "\x1b[48;5;255m" + "(☻)      " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[3] = Colors.White + "█████████";
                    break;
                case "netherlands":
                    flag[0] = flag[1] = Colors.Custom(169, 31, 50) + "█████████";
                    flag[2] = flag[3] = Colors.White + "█████████";
                    flag[4] = flag[5] = Colors.Custom(30, 71, 133) + "█████████";
                    break;
                case "hungary":
                    flag[0] = flag[1] = Colors.Custom(206, 41, 57) + "█████████";
                    flag[2] = flag[3] = Colors.White + "█████████";
                    flag[4] = flag[5] = Colors.Custom(71, 112, 80) + "█████████";
                    break;
                case "thailand":
                    flag[0] = flag[5] = Colors.Custom(239, 51, 64) + "█████████";
                    flag[1] = flag[4] = Colors.White + "█████████";
                    flag[2] = flag[3] = Colors.Custom(0, 36, 125) + "█████████";
                    break;
                case "germany":
                    flag[0] = flag[1] = Colors.Custom(10, 10, 10) + "█████████";
                    flag[2] = flag[3] = Colors.Custom(221, 0, 0) + "█████████";
                    flag[4] = flag[5] = Colors.Custom(255, 204, 0) + "█████████";
                    break;
                case "lithuania":
                    flag[0] = flag[1] = Colors.Custom(255, 184, 28) + "█████████";
                    flag[2] = flag[3] = Colors.Custom(4, 106, 56) + "█████████";
                    flag[4] = flag[5] = Colors.Custom(190, 58, 52) + "█████████";
                    break;
                case "estonia":
                    flag[0] = flag[1] = Colors.Custom(0, 114, 206) + "█████████";
                    flag[2] = flag[3] = Colors.Custom(6, 6, 6) + "█████████";
                    flag[4] = flag[5] = Colors.White + "█████████";
                    break;
                case "georgia":
                    flag[0] = Colors.Custom(255, 0, 0) + "\x1b[48;5;255m" + "█    ▄   " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[1] = Colors.Custom(255, 0, 0) + "\x1b[48;5;255m" + "█   ▀█▀  " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[2] = Colors.Custom(255, 0, 0) + "\x1b[48;5;255m" + "█▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[3] = Colors.Custom(255, 0, 0) + "\x1b[48;5;255m" + "█▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[4] = Colors.Custom(255, 0, 0) + "\x1b[48;5;255m" + "█   ▄█▄  " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[5] = Colors.Custom(255, 0, 0) + "\x1b[48;5;255m" + "█    ▀   " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                case "sealand":
                    flag[0] = Colors.Custom(200, 50, 50) + "\x1b[48;5;255m" + "███████▀ " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[1] = Colors.Custom(200, 50, 50) + "\x1b[48;5;255m" + "█████▀   " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[2] = Colors.Custom(200, 50, 50) + "\x1b[48;5;255m" + "███▀   " + Colors.Custom(10, 10, 10) + "▄█" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[3] = Colors.Custom(200, 50, 50) + "\x1b[48;5;255m" + "█▀   " + Colors.Custom(10, 10, 10) + "▄███" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[4] = Colors.Custom(10, 10, 10) + "\x1b[48;5;255m" + "   ▄█████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[5] = Colors.Custom(10, 10, 10) + "\x1b[48;5;255m" + " ▄███████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                case "brazil":
                    flag[0] = "\x1b[48;2;254;221;0m" + Colors.Custom(0, 151, 57) + "▀▀███████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[1] = "\x1b[48;2;254;221;0m" + Colors.Custom(1, 33, 105) + "▄▄ " + Colors.Custom(0, 151, 57) + "▀█████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[2] = "\x1b[48;2;254;221;0m" + Colors.Custom(1, 33, 105) + "███  " + Colors.Custom(0, 151, 57) + "▀███" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[3] = "\x1b[48;2;254;221;0m" + Colors.Custom(1, 33, 105) + "███  " + Colors.Custom(0, 151, 57) + "▄███" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[4] = "\x1b[48;2;254;221;0m" + Colors.Custom(1, 33, 105) + "▀▀ " + Colors.Custom(0, 151, 57) + "▄█████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[5] = "\x1b[48;2;254;221;0m" + Colors.Custom(0, 151, 57) + "▄▄███████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                case "switzerland":
                    flag[0] = flag[5] = Colors.Custom(218, 41, 28) + "██████";
                    flag[1] = flag[4] = Colors.White + "█" + Colors.Custom(218, 41, 28) + "█████";
                    flag[2] = Colors.White + "\x1b[48;2;218;41;28m" + "█▄▄▄  " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[3] = Colors.White + "\x1b[48;2;218;41;28m" + "█▀▀▀  " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                case "canada":
                    flag[0] = flag[5] = Colors.White + "█████" + Colors.Custom(216, 6, 33) + "████";
                    flag[1] = Colors.Custom(216, 6, 33) + "\x1b[48;5;255m" + "█▄   ████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[2] = Colors.Custom(216, 6, 33) + "\x1b[48;5;255m" + "██▄█ ████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[3] = Colors.Custom(216, 6, 33) + "\x1b[48;5;255m" + "███▄ ████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[4] = Colors.Custom(216, 6, 33) + "\x1b[48;5;255m" + "▌    ████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                case "japan":
                    flag[0] = flag[5] = Colors.White + "█████████";
                    flag[1] = Colors.Custom(188, 0, 45) + "\x1b[48;5;255m" + "▄▄       " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[2] = Colors.Custom(188, 0, 45) + "\x1b[48;5;255m" + "███▄     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[3] = Colors.Custom(188, 0, 45) + "\x1b[48;5;255m" + "███▀     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[4] = Colors.Custom(188, 0, 45) + "\x1b[48;5;255m" + "▀▀       " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                case "australia":
                    flag[0] = flag[4] = Colors.Custom(255, 255, 255) + "\x1b[48;2;1;33;105m" + "   ♦     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[1] = Colors.Custom(255, 255, 255) + "\x1b[48;2;1;33;105m" + "     ♦   " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[2] = Colors.Custom(255, 255, 255) + "\x1b[48;2;1;33;105m" + " ♦  ․    " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[5] = flag[3] = Colors.Custom(1, 33, 105) + "█████████";
                    break;
                case "new zealand":
                    flag[0] = flag[4] = Colors.Custom(200, 16, 46) + "\x1b[48;2;1;33;105m" + "   ♦     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[1] = Colors.Custom(200, 16, 46) + "\x1b[48;2;1;33;105m" + "     ♦   " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[2] = Colors.Custom(200, 16, 46) + "\x1b[48;2;1;33;105m" + " ♦  ․    " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[5] = flag[3] = Colors.Custom(1, 33, 105) + "█████████";
                    break;
                case "finland":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.White + "█████████";
                    flag[2] = Colors.Custom(0, 47, 108) + "\x1b[48;5;255m" + "▄▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[3] = Colors.Custom(0, 47, 108) + "\x1b[48;5;255m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                case "denmark":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Custom(200, 16, 46) + "█████████";
                    flag[3] = Colors.Custom(200, 16, 46) + "\x1b[48;5;255m" + "▄▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[2] = Colors.Custom(200, 16, 46) + "\x1b[48;5;255m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                case "sweden":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Custom(0, 106, 167) + "█████████"; 
                    flag[2] = Colors.Custom(254, 204, 2) + "\x1b[48;2;0;106;167m" + "▄▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[3] = Colors.Custom(254, 204, 2) + "\x1b[48;2;0;106;167m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                case "latvia":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Custom(164, 52, 58) + "█████████";
                    flag[3] = Colors.Custom(164, 52, 58) + "\x1b[48;5;255m" + "▄▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[2] = Colors.Custom(164, 52, 58) + "\x1b[48;5;255m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                case "norway":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Custom(186, 12, 47) + "█████████";
                    flag[2] = Colors.Custom(0, 32, 91) + "\x1b[48;5;255m" + "▄▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[3] = Colors.Custom(0, 32, 91) + "\x1b[48;5;255m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
                default:
                    flag[1] = flag[3] = flag[5] = Colors.Darker + "\x1b[48;5;255m" + "█  ██  ██" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    flag[0] = flag[2] = flag[4] = Colors.Darker + "\x1b[48;5;255m" + " ██  ██  " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.White;
                    break;
            }
            return flag;
        }
        public static void RaceEndScreen(List<KeyValuePair<int, double>> lineup, int userKey, int userNumber)
        {
            Data data = new();
            int[] keys = new int[3];
            string[] nums = new string[3], names = new string[3], countries = new string[3], teams = new string[3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (lineup[i].Key == Data.DriverData()[j].Item4)
                    {
                        keys[i] = j;
                        if (Data.DriverData()[j].Item4 == userKey)
                        {
                            nums[i] = userNumber.ToString();
                            names[i] = data.UserData()[0].Item3 + "";
                            countries[i] = data.UserData()[0].Item5 + "";
                        }
                        else
                        {
                            nums[i] = Data.DriverData()[j].Item4.ToString();
                            names[i] = Data.DriverData()[j].Item2;
                            countries[i] = Data.DriverData()[j].Item5;
                        }
                        if (nums[i].Length == 1)
                            nums[i] = Colors.Teams()[j / 2] + nums[i] + " " + Colors.White;
                        else
                            nums[i] = Colors.Teams()[j / 2] + nums[i] + Colors.White;
                        string[] capsName = names[i].Split(' ' , 2);
                        if (j == 17 && Data.DriverData()[j].Item4 != userKey)
                            names[i] = capsName[0].ToUpper() + " " + capsName[1];
                        else
                            names[i] = capsName[0] + " " + capsName[1].ToUpper();
                        while (names[i].Length < 21)
                            names[i] = names[i] + " ";
                        teams[i] = Colors.Teams()[j / 2] + Data.DriverData()[j].Item1 + Colors.White;
                    }
                }
            }
            Console.WriteLine("" + Colors.White + 
                "───────────────────────┐" + '\n' + 
                          $" {names[0]} │" + Flag(countries[0])[0] + '\n' + 
        $" {nums[0]}     {Colors.Teams()[keys[0] / 2]}_______{Colors.White}        │" + Flag(countries[0])[1] + '\n' +
              $@"       {Colors.Teams()[keys[0] / 2]}_\═.o.═/_{Colors.White}       │" + Flag(countries[0])[2] + '\n' +
               $"      {Colors.Teams()[keys[0] / 2]}|_|_____|_|{Colors.White}      │" + Flag(countries[0])[3] + '\n' + Colors.White +
                "                    /  │" + Flag(countries[0])[4] + '\n' + 
                 $"  {teams[0]}     / st│" + Flag(countries[0])[5] + '\n' + Colors.White +
                "───────────────────────┤" + '\n' + 
                          $" {names[1]} │" + Flag(countries[1])[0] + '\n' + 
        $" {nums[1]}     {Colors.Teams()[keys[1] / 2]}_______{Colors.White}        │" + Flag(countries[1])[1] + '\n' +
              $@"       {Colors.Teams()[keys[1] / 2]}_\═.o.═/_{Colors.White}       │" + Flag(countries[1])[2] + '\n' +
               $"      {Colors.Teams()[keys[1] / 2]}|_|_____|_|{Colors.White}  __  │" + Flag(countries[1])[3] + '\n' + Colors.White +
                "                   _/  │" + Flag(countries[1])[4] + '\n' +
                 $"  {teams[1]}    /_ nd│" + Flag(countries[1])[5] + '\n' + Colors.White +
                "───────────────────────┤" + '\n' +
                          $" {names[2]} │" + Flag(countries[2])[0] + '\n' +
        $" {nums[2]}     {Colors.Teams()[keys[2] / 2]}_______{Colors.White}        │" + Flag(countries[2])[1] + '\n' +
              $@"       {Colors.Teams()[keys[2] / 2]}_\═.o.═/_{Colors.White}       │" + Flag(countries[2])[2] + '\n' +
               $"      {Colors.Teams()[keys[2] / 2]}|_|_____|_|{Colors.White}  _   │" + Flag(countries[2])[3] + '\n' + Colors.White +
               @"                   _\  │" + Flag(countries[2])[4] + '\n' +
                 $"  {teams[2]}    __/rd│" + Flag(countries[2])[5] + '\n' + Colors.White +
                "───────────────────────┘");
        }
        public static void Anthem(int winner, int circuit, int userKey)
        {
            ConsoleKeyInfo key;
            Data data = new();
            bool timeout;
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, the = "",
            driverCountry = winner == userKey ? data.UserData()[0].Item5 + "" : Data.DriverData()[winner].Item5,
            driverWinner = winner == userKey ? data.UserData()[0].Item3 + "" : Data.DriverData()[winner].Item2;
            if (driverCountry == "United Kingdom" || driverCountry == "United States" || driverCountry == "Netherlands")
                the = "the ";
            Console.SetCursorPosition(42, 2);
            Console.Write(Colors.Teams()[winner / 2] + $"{driverWinner}{Colors.White} is the winner of {Data.CircuitData()[circuit].Item5} GP");
            Console.SetCursorPosition(42, 3);
            Console.Write($"The natonal anthem of {the}{driverCountry} is playing");
            BoxForLine();
            Thread runningLine = new(new ThreadStart(RunningLine))
            { IsBackground = true };
            runningLine.Start();
            try
            {
                using VorbisWaveReader reader = new(@$"{path}\sound\{driverCountry.ToLower()}.ogg");
                using WaveOutEvent waveOut = new();
                waveOut.Init(reader);
                waveOut.Play();
                for (int skip = 0; skip < 10;)
                {
                    timeout = true;
                    Task.Delay(68).Wait();
                    if (Console.KeyAvailable)
                    {
                        ConsoleSemaphore.Wait();
                        key = Console.ReadKey(true);
                        ConsoleSemaphore.Release();
                        if (key.Key == ConsoleKey.Spacebar)
                        {
                            skip++;
                            timeout = false;
                        }
                        if (key.Key == ConsoleKey.UpArrow)
                            waveOut.Volume = Math.Min(waveOut.Volume + 0.05f, 1);
                        if (key.Key == ConsoleKey.DownArrow)
                            waveOut.Volume = Math.Max(waveOut.Volume - 0.05f, 0);
                    }
                    if (skip > 0 && timeout)
                        skip--;
                    ConsoleSemaphore.Wait();
                    if (waveOut.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                    {
                        Console.SetCursorPosition(42, 4);
                        Console.Write(Colors.Dark + "Hold [Space] to skip");
                        Assets.FillBar(skip);
                    }
                    else
                    {
                        Console.SetCursorPosition(42, 4);
                        Console.Write(Colors.Dark + "Press [Enter] to advance       ");
                        ConsoleSemaphore.Release();
                        Util.KeyAdvance(ConsoleKey.Enter);
                        break;
                    }
                    ConsoleSemaphore.Release();
                    while (Console.KeyAvailable)
                        Console.ReadKey(false);
                }
                waveOut.Dispose();
            }
            catch
            {
                ConsoleSemaphore.Wait();
                Console.SetCursorPosition(42, 4);
                Console.Write($"{Colors.Gray}No anthem available {Colors.Dark}[Enter]");
                ConsoleSemaphore.Release();
                Util.KeyAdvance(ConsoleKey.Enter);
            }
            StopRunningLine = true;
            runningLine.Join();
            Util.ClearPart(0);
        }
        public static void RunningLineStringBuilder(List<KeyValuePair<int, double>> lineup, int userKey, int fastestLap)
        {
            StringBuilder runningLine = new();
            string fl, driverSN;
            Data data = new();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (lineup[i].Key == Data.DriverData()[j].Item4)
                    {
                        driverSN = lineup[i].Key == userKey ? data.UserData()[0].Item4 + "" : Data.DriverData()[j].Item3;
                        fl = lineup[i].Key == fastestLap ? "·" : " ";
                        runningLine.Append("|" + (i + 1) + fl + driverSN + " " + TeamColorForRunningLine(j / 2) + "          ");
                    }
                }
            }
            Line = runningLine.ToString();
        }
        static List<char> TeamColorChars => new() { '❶', '❷', '❸', '❹', '❺', '❻', '❼', '❽', '❾', '❿' };
        static char TeamColorForRunningLine(int team) => TeamColorChars[team];
        static string? Line { get; set; }

        static readonly SemaphoreSlim ConsoleSemaphore = new(1, 1);
        static bool StopRunningLine = false;
        public static void BoxForLine()
        {
            Console.SetCursorPosition(41, 11);
            Console.Write("┌──────────────────────────────────────────────────┐");
            Console.SetCursorPosition(41, 12);
            Console.Write("│                                                  │");
            Console.SetCursorPosition(41, 13);
            Console.Write("└──────────────────────────────────────────────────┘");
        }
        public static void RunningLine()
        {
            string line = Line + "", displayLine;
            int x = 0;
            for (int i = 50; i > 0 || StopRunningLine; i--)
            {
                ConsoleSemaphore.Wait();
                displayLine = new string(' ', Math.Max(i, 0)) + line.Remove(50 - i);
                Console.SetCursorPosition(42, 12);
                for (int j = 0; j < displayLine.Length; j++)
                {
                    if (displayLine[j] == '·')
                        Console.Write(Colors.Magenta + displayLine[j] + Colors.White);
                    else if (displayLine[j] == '|')
                        Console.Write(Colors.Dark + displayLine[j] + Colors.White);
                    else if (TeamColorChars.Contains(displayLine[j]))
                        Console.Write(Colors.Teams()[TeamColorChars.IndexOf(displayLine[j])] + "■" + Colors.White);
                    else
                        Console.Write(Colors.White + displayLine[j]);
                }
                ConsoleSemaphore.Release();
                Task.Delay(90).Wait();
            }
            while (!StopRunningLine)
            {
                ConsoleSemaphore.Wait();
                displayLine = line.Remove(0, x);
                if (displayLine.Length < 50)
                    displayLine += line.Remove(50 - displayLine.Length);
                else
                    displayLine = displayLine.Remove(50);
                Console.SetCursorPosition(42, 12);
                for (int j = 0; j < displayLine.Length; j++)
                {
                    if (displayLine[j] == '·')
                        Console.Write(Colors.Magenta + displayLine[j] + Colors.White);
                    else if (displayLine[j] == '|')
                        Console.Write(Colors.Dark + displayLine[j] + Colors.White);
                    else if (TeamColorChars.Contains(displayLine[j]))
                        Console.Write(Colors.Teams()[TeamColorChars.IndexOf(displayLine[j])] + "■" + Colors.White);
                    else
                        Console.Write(Colors.White + displayLine[j]);
                }
                ConsoleSemaphore.Release();
                if (x == line.Length)
                    x = 0;
                else
                    x++;
                Task.Delay(90).Wait();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread disableCursorThread = new(new ThreadStart(DisableCursor))
            { IsBackground = true };
            disableCursorThread.Start();
            Console.Write("\x1b[48;2;0;0;0m" + Colors.White);
            Console.Clear();
            Data.LoadDifficulty();
            Data data = new();
            data.UserData();
            Debug.CheckFlag();
            Util.ClearPart(0);
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
        static void DisableCursor()
        {
            while (true)
            {
                if (Console.CursorVisible == true)
                    Console.CursorVisible = false;
            }
        }
    }
    public static class CareerManager
    {
        private static int CareerGP { get; set; }
        public static List<CareerSave<int, int, WoxoTuple>> CareerMode { get; set; } = new();
        public static void LoadCareer()
        {
            try
            {
                var userDataPath = Path.Combine(Environment.CurrentDirectory, "UserData");
                var careerModePath = Path.Combine(userDataPath, "CareerMode.txt");
                using var careerReader = new StreamReader(careerModePath);
                CareerGP = Convert.ToInt32(careerReader.ReadLine());
                foreach (var driverData in Data.DriverData())
                {
                    var points = Convert.ToInt32(careerReader.ReadLine());
                    var winStrings = careerReader.ReadLine().Split(',');
                    short[] wins = new short[10];
                    for (int i = 0; i < 10; i++)
                        wins[i] = Convert.ToInt16(winStrings[i]);
                    CareerMode.Add(new CareerSave<int, int, WoxoTuple>(driverData.Item4, points, new WoxoTuple(wins[0], wins[1], wins[2], wins[3], wins[4], wins[5], wins[6], wins[7], wins[8], wins[9])));
                }
            }
            catch
            {
                Console.WriteLine("Can't load career save data\nCheck save directory or copy original [CareerMode.txt] from git");
                Util.KeyAdvance(ConsoleKey.Enter);
            }
        }
        public static void SaveCareer()
        {
            try
            {
                var userDataPath = Path.Combine(Environment.CurrentDirectory, "UserData");
                var careerModePath = Path.Combine(userDataPath, "CareerMode.txt");
                using var careerWriter = new StreamWriter(careerModePath);
                careerWriter.WriteLine(CareerGP);
                foreach (var careerSave in CareerMode)
                {
                    var winArray = new object[] { careerSave.Item3.F1, careerSave.Item3.F2, careerSave.Item3.F3, careerSave.Item3.F4, careerSave.Item3.F5, careerSave.Item3.F6, careerSave.Item3.F7, careerSave.Item3.F8, careerSave.Item3.F9, careerSave.Item3.F10 };
                    var winString = string.Join(",", winArray); 
                    careerWriter.WriteLine($"{careerSave.Item2}\n{winString}");
                }
            }
            catch
            {
                Console.WriteLine("Can't save career save data\nCheck save directory or copy original [CareerMode.txt] from git");
                Util.KeyAdvance(ConsoleKey.Enter);
            }
        }
    }
}