using NAudio.Vorbis;
using System.Text;
using VisioForge.MediaFramework.Helpers;
using static F1_Season_2023_Ew.Assets;
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
            new("Bahrain",       "Sakhir",             "March", 5,      "Bahrain",         1, 57),
            new("Saudi Arabia",  "Jeddah",             "March", 19,     "Saudi Arabian",   0, 50),
            new("Australia",     "Albert Park",        "April", 2,      "Austrlian",      18, 58),
            new("Azerbaijan",    "Baku",               "April", 30,     "Azerbaijan",     16, 51),
            new("United States", "Miami",              "May", 7,        "Miami",          23, 57),
            new("Italy",         "Imola",              "May", 21,       "Emilia Romagna", 15, 63),
            new("Monaco",        "Monaco",             "May", 28,       "Monaco",          7, 78),
            new("Spain",         "Catalunya",          "June", 4,       "Spanish",        16, 66),
            new("Canada",        "Gilles Villeneuve",  "June", 18,      "Canadian",       18, 70),
            new("Austria",       "Red Bull Ring",      "July", 2,       "Austrian",       19, 71),
            new("United Kingdom","Silverstone",        "July", 9,       "British",        31, 52),
            new("Hungary",       "Hungaroring",        "July", 23,      "Hungarian",      21, 70),
            new("Belgium",       "Spa",                "July", 30,      "Belgian",        45, 44),
            new("Netherlands",   "Zandvoort",          "August", 27,    "Dutch",          22, 72),
            new("Italy",         "Monza",              "September", 3,  "Italian",        20, 53),
            new("Singapore",     "Marina Bay",         "September", 17, "Singapore",      35, 61),
            new("Japan",         "Suzuka",             "September", 24, "Japanese",       40, 53),
            new("Qatar",         "Losail",             "October", 8,    "Qatar",           1, 57),
            new("United States", "COTA",               "October", 22,   "United States",  15, 56),
            new("Mexico",        "Hermanos Rodriguez", "October", 29,   "Mexican",        12, 71),
            new("Brazil",        "Interlagos",         "November", 5,   "Sao Paulo",      34, 71),
            new("United States", "Las Vegas",          "November", 18,  "Las Vegas",      12, 50),
            new("UAE",           "Yas Marina",         "November", 26,  "Abu Dhabi",       2, 58)
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
            "Haas        "
        };
        public static List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> DriverData() => new() 
        {     //Team            Full Name         SrtNm  Num  Country          Race Data    AG     AF    FL DNF
            new(TeamList()[0], "Lewis Hamilton",  "HAM", 44, "United Kingdom", Tuple.Create( 5.30,  4.49, 2, 2)),
            new(TeamList()[0], "George Russell",  "RUS", 63, "United Kingdom", Tuple.Create( 5.32,  4.88, 4, 2)),
            new(TeamList()[1], "Max Verstappen",  "VER",  1, "Netherlands",    Tuple.Create( 2.40,  2.00, 5, 2)),
            new(TeamList()[1], "Sergio Perez",    "PER", 11, "Mexico",         Tuple.Create( 4.12,  3.46, 3, 3)),
            new(TeamList()[2], "Charles Leclerc", "LEC", 16, "Monaco",         Tuple.Create( 2.81,  3.82, 3, 4)), 
            new(TeamList()[2], "Carlos Sainz",    "SAI", 55, "Spain",          Tuple.Create( 5.55,  6.28, 2, 6)),
            new(TeamList()[3], "Lando Norris",    "NOR",  4, "United Kingdom", Tuple.Create(11.95, 11.07, 2, 2)),
            new(TeamList()[3], "Oscar Piastri",   "PIA", 81, "Australia",      Tuple.Create(12.15, 12.70, 0, 3)),
            new(TeamList()[4], "Esteban Ocon",    "OCO", 31, "France",         Tuple.Create( 8.88,  9.29, 0, 2)),
            new(TeamList()[4], "Pierre Gasly",    "GAS", 10, "France",         Tuple.Create( 9.58,  9.87, 0, 3)),
            new(TeamList()[5], "Yuki Tsunoda",    "TSU", 22, "Japan",          Tuple.Create(13.20, 12.51, 0, 3)),
            new(TeamList()[5], "Nyck de Vries",   "DEV", 21, "Netherlands",    Tuple.Create(14.27, 13.98, 0, 5)),
            new(TeamList()[6], "Lance Stroll",    "STR", 18, "Canada",         Tuple.Create( 8.82,  8.55, 0, 3)),
            new(TeamList()[6], "Fernando Alonso", "ALO", 14, "Spain",          Tuple.Create( 5.00,  5.00, 1, 4)),
            new(TeamList()[7], "Alexander Albon", "ALB", 23, "Thailand",       Tuple.Create(12.22, 13.12, 0, 5)),
            new(TeamList()[7], "Logan Sargeant",  "SAR",  2, "United States",  Tuple.Create(15.00, 14.00, 0, 5)),
            new(TeamList()[8], "Valtteri Bottas", "BOT", 77, "Finland",        Tuple.Create(11.22, 10.81, 0, 6)),
            new(TeamList()[8], "Zhou Guanyu",     "ZHO", 24, "China",          Tuple.Create(12.18, 11.58, 1, 6)),
            new(TeamList()[9], "Kevin Magnussen", "MAG", 20, "Denmark",        Tuple.Create(12.11, 13.15, 0, 5)),
            new(TeamList()[9], "Nico Hulkenberg", "HUL", 27, "Germany",        Tuple.Create(10.49, 13.35, 0, 3))
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
                Console.WriteLine($"{Colors.Text}Can't read save file\nCheck this path - " + @$"{Colors.Gold}{path}\UserData\SaveFile.txt{Colors.Text}");
                Util.KeyAdvance(ConsoleKey.Enter);
                Util.ClearPart(0);
            }
            if (firstNameRead.IsNullOrEmpty() || ChangeUserData)
            {
                if (ChangeUserData)
                    blankSpace = "              ";
                Console.Write($"\n{blankSpace}     /What's your first name?" + '\n' + Colors.Red + $"{blankSpace}    /" + Colors.Text);
                firstName = Console.ReadLine().Trim();
                firstName = UserInfoAdjuster(firstName, UserInfoType.firstName);
                Console.SetCursorPosition(0, Console.CursorTop - 2);
                Console.Write($"{blankSpace}     /And your last name?    " + '\n' + Colors.Red + $"{blankSpace}    /{firstName} " + Colors.Text);
                lastName = Console.ReadLine().Trim();
                lastName = UserInfoAdjuster(lastName, UserInfoType.lastName);
                fullName = firstName + " " + lastName;
                shortName = ShortNameCreator(firstName, lastName);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write($"{Colors.Red}{blankSpace}    /{fullName}" + Colors.Text + $"\n{blankSpace}   /Where are you from?" + '\n' + Colors.Red + $"{blankSpace}  /" + Colors.Text);
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
                    Console.WriteLine($"{Colors.Text}Can't save user data\nCheck this path - " + @$"{Colors.Gold}{path}\UserData\SaveFile.txt{Colors.Text}");
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
                    @string = "Sealand";
            }
            else if (@string.Length == 1)
                @string = @string.ToUpper();
            else if (@string.Length > 13)
                @string = @string.Remove(1).ToUpper() + @string.Remove(0, 1).Remove(13);
            else
                @string = @string.Remove(1).ToUpper() + @string.Remove(0, 1);
            return @string;
        }
        private enum UserInfoType
        {
            firstName,
            lastName,
            nationality
        }
    }
    public class Data2003 : Data
    {
        public static string CircuitNumbering(int number) => number < 10 
            ? $"{Colors.Text + "\x1b[48;2;200;200;0m"} {number}{"\x1b[48;5;255m" + Colors.White}█{Colors.Text}" 
            : $"{Colors.Text + "\x1b[48;2;200;200;0m"}{number}{"\x1b[48;5;255m" + Colors.White}█{Colors.Text}";

        public static new List<Tuple<string, string, string, int, string, int, int>> CircuitData() => new()
        {      //dot          name                 date             GP             rain% laps 
            new("Australian Grand Prix","",       "March", 9,         "Australian",       1, 57),
            new("Malaysian Grand Prix", "",       "March", 23,        "Malaysian",        1, 57),
            new("Brazilian Grand Prix","",        "April",  6,        "Brazilian",        1, 57),
            new("San Marino Grand Prix","",       "April", 20,        "San Marino",       1, 57),
            new("Spanish Grand Prix","",          "May", 4,           "Spanish",          1, 57),
            new("Austrian Grand Prix","",         "May", 18,          "Austrian",         1, 57),
            new("Monaco Grand Prix","",           "June", 1,          "Monaco",           1, 57),
            new("Canadian Grand Prix","",         "June", 15,         "Canadian",         1, 57),
            new("European Grand Prix","",         "June", 29,         "European",         1, 57),
            new("French Grand Prix","",           "July", 6,          "French",           1, 57),
            new("British Grand Prix","",          "July", 20,         "British",          1, 57),
            new("German Grand Prix","",           "August", 3,        "German",           1, 57),
            new("Hungarian Grand Prix","",        "August", 24,       "Hungarian",        1, 57),
            new("Italian Grand Prix","",          "September", 14,    "Italian",          1, 57),
            new("United States Grand Prix","",    "September", 28,    "United States",    1, 57),
            new("Japanese Grand Prix","",         "October", 12,      "Japanese",         1, 57),
        };
        public static new List<string> TeamList() => new() {
            "FERRARI          ",
            "BMW WILLIAMS     ",
            "McLAREN MERCEDES ",
            "RENAULT          ",
            "SAUBER PETRONAS  ",
            "JORDAN FORD      ",
            "JAGUAR           ",
            "BAR HONDA        ",
            "TOYOTA           ",
            "MINARDI COSWORTH "
        };
        public static string TyreType(bool B) => B ? $"{Colors.White + "\x1b[48;2;255;0;0m"}▌B{"\x1b[48;5;255m" + Colors.Custom(255, 0, 0) + "▌" + Colors.White}█{Colors.Text}" :
                                                     $"{Colors.Custom(0,0,255) + "▐" + Colors.White + "\x1b[48;2;0;0;255m"}M▐{"\x1b[48;5;255m"}█{Colors.Text}";
        public static string TyreTypeForTeam(int team) => team is 1 or 2 or 3 or 6 or 8 ? TyreType(false) : TyreType(true);
        public static new List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> DriverData() => new()
        {    
            new(TeamList()[0], "Michael Schumacher",    "M SCHUMACHER", 1,  "GER",   Tuple.Create( 3.65,  3.20, 5, 1)),
            new(TeamList()[0], "Rubens Barrichello",    "BARRICHELLO",  2,  "BRA",   Tuple.Create( 3.33,  3.35, 3, 5)),
            new(TeamList()[1], "Juan Pablo Montoya",    "MONTOYA",      3,  "COL",   Tuple.Create( 4.09,  4.02, 3, 3)),
            new(TeamList()[1], "Ralf Schumacher",       "R SCHUMACHER", 4,  "GER",   Tuple.Create( 5.63,  5.35, 1, 2)),
            new(TeamList()[2], "David Coulthard",       "COULTHARD",    5,  "GBR",   Tuple.Create( 8.50,  6.08, 0, 5)),
            new(TeamList()[2], "Kimi Räikkönen",        "RÄIKKÖNEN",    6,  "FIN",   Tuple.Create( 6.61,  3.59, 3, 3)),
            new(TeamList()[3], "Jarno Trulli",          "TRULLI",       7,  "ITA",   Tuple.Create( 7.31,  7.36, 0, 5)),
            new(TeamList()[3], "Fernando Alonso",       "ALONSO",       8,  "SPA",   Tuple.Create( 7.68,  5.17, 0, 5)),
            new(TeamList()[4], "Nick Heidfeld",         "HEIDFELD",     9,  "GER",   Tuple.Create(12.31, 10.72, 0, 4)),
            new(TeamList()[4], "Heinz-Harald Frentzen", "FRENTZEN",    10,  "GER",   Tuple.Create(13.25, 10.39, 0, 7)),
            new(TeamList()[5], "Giancarlo Fisichella",  "FISICHELLA",  11,  "ITA",   Tuple.Create(13.94, 11.42, 0, 9)),
            new(TeamList()[5], "Ralph Firman",          "FIRMAN",      12,  "IRE",   Tuple.Create(17.00, 12.95, 0, 6)),
            new(TeamList()[6], "Mark Webber",           "WEBBER",      14,  "AUS",   Tuple.Create( 9.88,  9.27, 0, 5)),
            new(TeamList()[6], "Antônio Pizzonia",      "PIZZONIA",    15,  "BRA",   Tuple.Create(13.82, 11.80, 0, 6)),
            new(TeamList()[7], "Jacques Villeneuve",    "VILLENEUVE",  16,  "CAN",   Tuple.Create(11.67, 10.31, 0, 8)),
            new(TeamList()[7], "Jenson Button",         "BUTTON",      17,  "GBR",   Tuple.Create(11.88,  8.70, 0, 6)),
            new(TeamList()[8], "Justin Wilson",         "WILSON",      18,  "GBR",   Tuple.Create(17.19, 14.37, 0, 9)),
            new(TeamList()[8], "Jos Verstappen",        "VERSTAPPEN",  19,  "NET",   Tuple.Create(18.44, 13.90, 0, 6)),
            new(TeamList()[9], "Olivier Panis",         "PANIS",       20,  "FRA",   Tuple.Create( 9.00, 10.96, 0, 9)),
            new(TeamList()[9], "Cristiano da Matta",    "DE MATTA",    13,  "BRA",   Tuple.Create(11.25,  9.83, 0, 3))
        };
    }
    public class CircuitSelector
    {
        public static int CircuitListing()
        {
            ConsoleKeyInfo key;
            var circuitData = Data.CircuitData();
            bool bonusCircuits = false;
            string country;
            string[] flag;
            int selCircuit = 0;
            Console.Clear();
            Console.SetCursorPosition(84, 0);
            Console.WriteLine(Colors.Text + "<" + Colors.Red + " FORMULA 1 " + Colors.Text + "2023 SEASON >");
            do
            {
                Console.SetCursorPosition(0, 0);
                if (bonusCircuits)
                    DisplayCircuit.BonusCircuits(selCircuit);
                else
                    DisplayCircuit.Circuits(selCircuit);
                for (int i = 0; i < circuitData.Count; i++)
                {
                    if (bonusCircuits)
                    {
                        if (i % 2 == 0)
                            Console.SetCursorPosition(84, i + 1);
                        else
                            Console.SetCursorPosition(87, i + 1);
                    }
                    else
                        Console.SetCursorPosition(84, i + 1);
                    if (i == selCircuit)
                        Console.Write(Colors.Red);
                    else if (bonusCircuits)
                        Console.Write(Colors.Text);
                    else
                    {
                        if (i < selCircuit && selCircuit - i < 11)
                            Console.Write($"\x1b[38;5;{256 - (selCircuit - i)}m");
                        else if (i > selCircuit && i - selCircuit < 11)
                            Console.Write($"\x1b[38;5;{256 - (i - selCircuit)}m");
                        else
                            Console.Write(Colors.Gray);
                    }
                    if (bonusCircuits)
                    {
                        Console.Write(Data2003.CircuitNumbering(i + 1) + " ");
                        if (i == selCircuit)
                            Console.Write(Colors.Blue);
                        else
                            Console.Write(Colors.Text);
                        Console.WriteLine(circuitData[i].Item5 + Colors.Gray + " Grand Prix");
                    }
                    else
                    {
                        if (i < 9)
                            Console.Write("R0");
                        else
                            Console.Write("R");
                        Console.Write(i + 1);
                        if (i == 0)
                            Console.Write('┌');
                        else if (i == circuitData.Count - 1)
                            Console.Write('└');
                        else
                            Console.Write('├');
                        country = circuitData[i].Item1.ToUpper();
                        Console.Write(country + ' ');
                        if (i == selCircuit)
                            Console.Write(Colors.LessGray);
                        else
                            Console.Write(Colors.Gray);
                        Console.WriteLine(circuitData[i].Item2);
                    }
                }
                if (bonusCircuits)
                    flag = EndScreen.Flag("2003");
                else
                    flag = EndScreen.Flag(circuitData[selCircuit].Item1);
                for (int i = 0; i < flag.Length && !bonusCircuits; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write(flag[i]);
                }
                for (int i = 0; i < flag.Length && bonusCircuits; i++)
                {
                    Console.SetCursorPosition(84, 24 + i);
                    Console.Write(flag[i]);
                }
                int oldSelCircuit = selCircuit;
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                        selCircuit = Math.Min(selCircuit + 1, circuitData.Count - 1);
                    else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                        selCircuit = Math.Max(selCircuit - 1, 0);
                    else if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                    {
                        selCircuit = 0;
                        bonusCircuits = !bonusCircuits;
                        if (bonusCircuits)
                        {
                            Console.Write("\x1b[48;5;255m");
                            Console.Clear();
                            circuitData = Data2003.CircuitData();
                            Colors.Text = Colors.Black;
                            Console.SetCursorPosition(84, 0);
                            Console.WriteLine(Colors.Text + "<" + Colors.Red + " FORMULA 1 " + Colors.Text + "2003 SEASON >");
                        }
                        else
                        {
                            Console.Write("\x1b[48;2;0;0;0m");
                            Console.Clear();
                            circuitData = Data.CircuitData();
                            Colors.Text = Colors.White;
                            Console.SetCursorPosition(84, 0);
                            Console.WriteLine(Colors.Text + "<" + Colors.Red + " FORMULA 1 " + Colors.Text + "2023 SEASON >");
                        }
                        break;
                    }
                    else if (key.Key == ConsoleKey.Enter)
                        break;
                } while (oldSelCircuit == selCircuit);
                Util.ClearKey();
            } while (key.Key != ConsoleKey.Enter);
            if (bonusCircuits)
                selCircuit += 100;
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
                    Console.WriteLine(Colors.Text + "Choose a team & who to replace " + Colors.Teams(selTeam) + data.UserData()[0].Item3 + '\n');
                    for (int i = 0; i < Data.TeamList().Count; i++)
                    {
                        Console.Write(Colors.Teams(i) + '|');
                        if (i != selTeam)
                            Console.Write(Colors.LessGray);
                        Console.WriteLine(Data.TeamList()[i] + "                                           ");
                        if (i == selTeam)
                        {
                            Console.Write("└─┨");
                            if (firtstDriverSeled == false)
                                Console.Write(Colors.Text);
                            else if (firtstDriverSeled && i == 9)
                                Console.Write(Colors.Red);
                            Console.Write($"{Data.DriverData()[i * 2].Item4}" + ' ' + Data.DriverData()[i * 2].Item2 + Colors.Text);
                            Console.SetCursorPosition(24, Console.CursorTop);
                            Console.Write(Colors.Teams(i) + "┃");
                            if (firtstDriverSeled == false && i != 9)
                                Console.Write(Colors.Teams(i));
                            else if (firtstDriverSeled == false && i == 9)
                                Console.Write(Colors.Red);
                            else
                                Console.Write(Colors.Text);
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


                Console.WriteLine('\n' + Colors.Teams(selTeam) + "|" + Colors.Text + "Pick your number" + Colors.Teams(selTeam) + "|");
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
                    Console.Write(Colors.Teams(selTeam) + "\r└─┤" + Colors.LessGray + "   < ");
                    if (userNumber < 10)
                        Console.Write(Colors.Gray + 0);
                    Console.Write(Colors.Teams(selTeam) + userNumber + Colors.LessGray + " >  " + Colors.Teams(selTeam) + " ├─┘");
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
        public static List<Tuple<int, int>> TeamListing2003()
        {
            ConsoleKeyInfo key;
            Data data = new();
            bool firtstDriverSeled = true;
            int selTeam = 0, replace;
            var teams = Data2003.TeamList();
            var drivers = Data2003.DriverData();
            Util.ClearPart(0);
            do
            {
                do
                {
                    Console.WriteLine(Colors.Text + "Choose a team & who to replace " + data.UserData()[0].Item3 + '\n');
                    for (int i = 0; i < teams.Count; i++)
                    {
                        Console.Write(Data2003.CircuitNumbering(i + 1));
                        Console.WriteLine(Colors.Blue + teams[i] + Data2003.TyreTypeForTeam(i));
                        if (firtstDriverSeled && i == selTeam)
                            Console.Write($" {Colors.Blue + NumberToCircledChars(drivers[i * 2].Item4)} {Colors.Text + drivers[i * 2].Item2 + Colors.Text}");
                        else
                            Console.Write($" {Colors.Gray + NumberToCircledChars(drivers[i * 2].Item4)} {drivers[i * 2].Item2 + Colors.Text}");
                        Console.SetCursorPosition(24, Console.CursorTop);
                        if (firtstDriverSeled == false && i == selTeam)
                            Console.WriteLine($"{Colors.Blue + NumberToCircledChars(drivers[i * 2 + 1].Item4)} {Colors.Text + drivers[i * 2 + 1].Item2 + Colors.Text}");
                        else
                            Console.WriteLine($"{Colors.Gray + NumberToCircledChars(drivers[i * 2 + 1].Item4)} {drivers[i * 2 + 1].Item2 + Colors.Text}");
                    }
                    key = Console.ReadKey(true);
                    if ((key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S) && selTeam < 9)
                        selTeam = Math.Min(selTeam + 1, 9);
                    else if ((key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W) && selTeam > 0)
                        selTeam = Math.Max(selTeam - 1, 0);
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
            } while (key.Key == ConsoleKey.Escape);
            int userNumber = drivers[replace].Item4;
            var userTeamChoice = new List<Tuple<int, int>>
            { new Tuple<int, int>(replace, userNumber) };
            return userTeamChoice;
        }
    }
    public class LineupGenerator
    {
        public static List<KeyValuePair<int, double>> StartingLineup(int user, int qualification, List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> drivers)
        {
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
                        userKey = drivers[i].Item4;
                        lineup.Add(new KeyValuePair<int, double>(userKey, 50)); }
                    else
                        lineup.Add(new KeyValuePair<int, double>(drivers[i].Item4, startRnd + drivers[i].Item6.Item1 - startRndDouble));
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
        public static List<KeyValuePair<int, double>> RaceLineup(int userKey, int newPos, List<KeyValuePair<int, double>> lineup, List<KeyValuePair<int, double>> listDNF, int overtakeDriver)
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
                            if (raceRnd == 0)
                                raceRnd = rnd.Next(5, 8);
                            if (driver[i].Item4 == overtakeDriver)
                                raceRnd = rnd.Next(-6, -1);
                            for (int n = 0; n < listDNF.Count; n++)
                            {
                                if (listDNF[n].Key == driver[i].Item4)
                                {
                                    driverDNF = true;
                                    raceRnd = (int)listDNF[n].Value;
                                    break;
                                }
                            }
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
    public class RaceSetup
    {
        public static void CareerRace(int circuit, List<Tuple<int, int>> userTeamNumber, int userKey)
        {
            Data data = new();
            Random rnd = new();
            var drivers = Data.DriverData();
            var circuitData = Data.CircuitData();
            int qualifying = QPlayOrSkip.PlayOrSkipQ(circuit, userTeamNumber[0].Item1 / 2, drivers, circuitData);
            var startingLineup = LineupGenerator.StartingLineup(userTeamNumber[0].Item1, qualifying, drivers);
            QGraphics.QLineup(startingLineup, userTeamNumber, drivers);
            WeatherSet.Weather weather = WeatherSet.WeatherFormula(circuitData[circuit].Item6);
            string userTeamColor = Colors.Teams(userTeamNumber[0].Item1 / 2);
            Race.PreRaceMenu(data, circuit, userTeamNumber, startingLineup, weather, userTeamColor, drivers, circuitData);
            Race.FullRace(data, rnd, drivers, userKey, circuit, userTeamNumber, startingLineup, weather, userTeamColor);
        }
        public static void NormalRace(bool randomStart)
        {
            Data data = new();
            Random rnd = new();

            bool its2003 = false;
            int rndNumber = rnd.Next(1, 100),
                userKey = 0, 
                circuit = rnd.Next(Data.CircuitData().Count);

            var drivers = Data.DriverData();
            var circuitData = Data.CircuitData();

            while (randomStart == true && Data.DriverNumbers().Contains(rndNumber))
                rndNumber = rnd.Next(1, 100);

            var userTeamNumber = new List<Tuple<int, int>>
            { new Tuple<int, int>(rnd.Next(Data.DriverData().Count), rndNumber) };

            if (randomStart == false)
            {
                circuit = CircuitSelector.CircuitListing();
                if (circuit > 99)
                {
                    circuit -= 100;
                    its2003 = true;
                    drivers = Data2003.DriverData();
                    circuitData = Data2003.CircuitData();
                    userTeamNumber = TeamSelector.TeamListing2003();
                }
                else
                    userTeamNumber = TeamSelector.TeamListing();
            }

            int qualifying = QPlayOrSkip.PlayOrSkipQ(circuit, userTeamNumber[0].Item1 / 2, drivers, circuitData);

            var startingLineup = LineupGenerator.StartingLineup(userTeamNumber[0].Item1, qualifying, drivers);

            if (!its2003)
                QGraphics.QLineup(startingLineup, userTeamNumber, drivers);

            WeatherSet.Weather weather = WeatherSet.WeatherFormula(circuitData[circuit].Item6);

            string userTeamColor = its2003 ? Colors.Blue : Colors.Teams(userTeamNumber[0].Item1 / 2);

            if (its2003)
                Race2003.PreRaceMenu(data, circuit, userTeamNumber, startingLineup, weather, userTeamColor, drivers, circuitData);
            else
                Race.PreRaceMenu(data, circuit, userTeamNumber, startingLineup, weather, userTeamColor, drivers, circuitData);

            Race.FullRace(data, rnd, drivers, userKey, circuit, userTeamNumber, startingLineup, weather, userTeamColor);
        }
    }
    public class Race
    {
        public static string HeaderString(int circuit, string userTeamColor, List<Tuple<string, string, string, int, string, int, int>> circuitData) => 
            Colors.Gray + "Sunday, " + circuitData[circuit].Item3 + ' ' + circuitData[circuit].Item4 + ", " + 2023 + '\n' + Colors.Text + circuitData[circuit].Item5 + " Grand Prix " + userTeamColor + ">" + Colors.Text + " Race";
        public static void PreRaceMenu(Data data, int circuit, List<Tuple<int, int>> userTeamNumber, List<KeyValuePair<int, double>> startingLineup, WeatherSet.Weather weather, string userTeamColor, List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> drivers, List<Tuple<string, string, string, int, string, int, int>> circuitData)
        {
            ConsoleKeyInfo key;
            int selPreRace = 1;
            string header = HeaderString(circuit, userTeamColor, circuitData);
            do
            {
                Util.ClearPart(0);
                Console.WriteLine(header + '\n' + Colors.Gray + circuitData[circuit].Item2 + '\n');
                do
                {
                    PreRaceMenuSelection(userTeamNumber, userTeamColor, selPreRace);
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                        selPreRace = Math.Min(selPreRace + 1, 4);
                    else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                        selPreRace = Math.Max(selPreRace - 1, 1);
                    Console.SetCursorPosition(0, Console.CursorTop - 4);
                } while (key.Key != ConsoleKey.Enter);
                PreRaceMenuTabs(data, circuit, userTeamNumber, startingLineup, weather, userTeamColor, drivers, circuitData, selPreRace, header);
            } while (selPreRace != 4);
        }
        public static void PreRaceMenuTabs(Data data, int circuit, List<Tuple<int, int>> userTeamNumber, List<KeyValuePair<int, double>> startingLineup, WeatherSet.Weather weather, string userTeamColor, List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> drivers, List<Tuple<string, string, string, int, string, int, int>> circuitData, int selPreRace, string header)
        {
            switch (selPreRace)
            {
                case 1:
                    Util.ClearPart(0);
                    Console.WriteLine(header + userTeamColor + " >" + Colors.Text + " Starting Lineup\n" + Colors.Gray + circuitData[circuit].Item2 + '\n');
                    PreRaceGrid(data, userTeamNumber, startingLineup, drivers);
                    break;
                case 2:
                    Util.ClearPart(0);
                    Console.WriteLine(header + userTeamColor + " >" + Colors.Text + " Circuit View\n" + Colors.Gray + circuitData[circuit].Item2 + Colors.Dark + " [Escape]" + '\n');
                    DisplayCircuitRace.CircuitsRace(circuit);
                    break;
                case 3:
                    Util.ClearPart(0);
                    Console.WriteLine(header + userTeamColor + " >" + Colors.Text + " Weather Forcast\n" + Colors.Gray + circuitData[circuit].Item2 + Colors.Dark + " [Escape]" + '\n');
                    WeatherSet.WeatherGraphics(weather);
                    break;
            }
        }
        public static void PreRaceMenuSelection(List<Tuple<int, int>> userTeamNumber, string userTeamColor, int selPreRace)
        {
            switch (selPreRace)
            {
                case 1:
                    Console.Write(userTeamColor + "Starting Lineup");
                    if (userTeamNumber[0].Item1 / 2 == 9)
                        Console.Write(Colors.Red + " <");
                    Console.WriteLine(Colors.LessGray + "\nCircuit View  \nWeather Forcast  \nStart the Race  ");
                    break;
                case 2:
                    Console.Write(Colors.LessGray + "Starting Lineup  " + '\n' + userTeamColor + "Circuit View");
                    if (userTeamNumber[0].Item1 / 2 == 9)
                        Console.Write(Colors.Red + " <");
                    Console.WriteLine(Colors.LessGray + "\nWeather Forcast  \nStart the Race  ");
                    break;
                case 3:
                    Console.Write(Colors.LessGray + "Starting Lineup  \nCircuit View  " + '\n' + userTeamColor + "Weather Forcast");
                    if (userTeamNumber[0].Item1 / 2 == 9)
                        Console.Write(Colors.Red + " <");
                    Console.WriteLine(Colors.LessGray + "\nStart the Race  ");
                    break;
                case 4:
                    Console.Write(Colors.LessGray + "Starting Lineup  \nCircuit View  \nWeather Forcast  " + '\n' + userTeamColor + "Start the Race");
                    if (userTeamNumber[0].Item1 / 2 == 9)
                        Console.WriteLine(Colors.Red + " <");
                    else
                        Console.WriteLine();
                    break;
            }
        }
        public static void PreRaceGrid(Data data, List<Tuple<int, int>> userTeamNumber, List<KeyValuePair<int, double>> startingLineup, List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> drivers)
        {
            ConsoleKeyInfo key;
            int number = 1, delay = 1;
            Console.SetCursorPosition(0, 24);
            Console.WriteLine(Colors.Dark + "[Space] to speed up");
            Console.SetCursorPosition(0, 4);
            foreach (var val in startingLineup)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (val.Key == drivers[j].Item4)
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
                                Console.Write(number + Colors.Teams(j / 2) + $"|" + $"\x1b[38;5;{i}m" + data.UserData()[0].Item4 + " ");
                                if (userTeamNumber[0].Item2 < 10)
                                    Console.Write(" ");
                                Console.WriteLine(Colors.Teams(j / 2) + userTeamNumber[0].Item2 + $"\x1b[38;5;{i - 2}m " + data.UserData()[0].Item3 + Colors.Teams(j / 2) + " <");
                            }
                            else
                            {
                                Console.Write(number + Colors.Teams(j / 2) + $"|" + $"\x1b[38;5;{i}m" + drivers[j].Item3 + " ");
                                if (drivers[j].Item4 < 10)
                                    Console.Write(" ");
                                Console.WriteLine(Colors.Teams(j / 2) + drivers[j].Item4 + $"\x1b[38;5;{i - 2}m " + drivers[j].Item2);
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
        }
        public static void FullRace(Data data, Random rnd, List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> driver, int userKey, int circuit, List<Tuple<int, int>> userTeamNumber, List<KeyValuePair<int, double>> startingLineup, WeatherSet.Weather weather, string userTeamColor)
        {
            var lineup = RaceUpdate.LineupUpdate(startingLineup);
            Util.ClearPart(0);
            Console.WriteLine(Colors.Gray + "Sunday, " + Data.CircuitData()[circuit].Item3 + ' ' + Data.CircuitData()[circuit].Item4 + ", " + 2023 + '\n' + Colors.Text + Data.CircuitData()[circuit].Item5 + " Grand Prix " + userTeamColor + ">" + Colors.Text + " Race " + userTeamColor + ">" + Colors.Text + " Formation Lap\n" + Colors.Gray + Data.CircuitData()[circuit].Item2 + '\n');
            Console.SetCursorPosition(0, 5);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(Colors.Text);
                for (int j = 0; j < 20; j++)
                {
                    if (startingLineup[i].Key == Data.DriverData()[j].Item4)
                    {
                        if (i % 2 == 0)
                            Console.SetCursorPosition(5, Console.CursorTop);
                        else
                            Console.SetCursorPosition(18, Console.CursorTop);
                        if (j == userTeamNumber[0].Item1)
                        { Console.WriteLine($"{data.UserData()[0].Item4}{Colors.Teams(j / 2)}⌠{Colors.Dark}{data.UserData()[0].Item3}"); userKey = startingLineup[i].Key; }
                        else
                            Console.WriteLine($"{Data.DriverData()[j].Item3}{Colors.Teams(j / 2)}⌠{Colors.Darker}{Data.DriverData()[j].Item2}");
                        break;
                    }
                }
            }
            RedLightsFormationLap(4);
            Util.ClearPart(0);

            int newPos = 0, oldPos = 0, score = 0, totalLaps = Data.CircuitData()[circuit].Item7, pitCount = 0, noRepeats = 0, randomMiniGame = 0, miniGameCounter = 1, winner = 0, flHolder = 0, otherDriverInOvertake;
            string posIndicator;
            Flag flag = Flag.Green, lastFlag = Flag.Green;
            bool fLPlayed = false, userDNF = false, redFlag = false, yellowFlag = false, otherDriverInOvertakeCrashed;
            var listDNF = new List<KeyValuePair<int, double>> { };
            for (int lap = 1; lap <= Data.CircuitData()[circuit].Item7;)
            {
                Console.WriteLine(Colors.Gray + $"Sunday, " + Data.CircuitData()[circuit].Item3 + ' ' + Data.CircuitData()[circuit].Item4 + ", " + 2023 + '\n' + Colors.Text + Data.CircuitData()[circuit].Item5 + " Grand Prix " + userTeamColor + ">" + Colors.Text + " Race " + userTeamColor + ">" + Colors.Text + $" Lap {lap}/{totalLaps}\n");
                int listDNFLast = listDNF.Count;
                otherDriverInOvertakeCrashed = false;
                otherDriverInOvertake = 0;
                if (flag == Flag.Green && lastFlag == Flag.Green)
                {
                    if (userDNF == false)
                    {
                        while (randomMiniGame == noRepeats)
                        { randomMiniGame = rnd.Next(3); }
                        Util.ClearKey();
                        Console.Write($"\r{Colors.Text}Challenge {miniGameCounter} · ");
                        miniGameCounter++;
                        if (lap == 1 || redFlag)
                        {
                            score = MiniGames.RedLights();
                            redFlag = false;
                        }
                        else if ((randomMiniGame == 0 && lap > totalLaps / 3 && pitCount == 0 && lap < totalLaps - totalLaps / 10) || pitCount == 3)
                        {
                            score = MiniGames.BoxBox();
                            pitCount++;
                        }
                        else if (lap > totalLaps / 2 && !fLPlayed)
                        {
                            score = MiniGames.FastestLap(circuit, weather);
                            fLPlayed = true;
                            if (score > 2) flHolder = userKey;
                        }
                        else if (randomMiniGame == 1 && newPos != 0)
                        {
                            score = MiniGames.Overtake(userTeamColor, lineup[newPos - 1].Key, userTeamNumber[0].Item2, weather);
                            if (score < -199)
                            { score += 200; otherDriverInOvertake = lineup[newPos - 1].Key; otherDriverInOvertakeCrashed = true; }
                            else if (score < -98)
                            {
                                if (score == -99)
                                    otherDriverInOvertake = lineup[newPos - 1].Key;
                                else if (score == -102)
                                    pitCount = 3;
                                score += 100;
                            }
                        }
                        else if (randomMiniGame == 2 && lap > 3 && newPos != 0)
                        {
                            int BrakesOrDRS = rnd.Next(2);
                            if (BrakesOrDRS == 0 && (int)weather < 1)
                                score = MiniGames.DRS();
                            else
                                score = MiniGames.Brakes(weather);
                        }
                        else
                        {
                            do
                            { randomMiniGame = rnd.Next(4, 6); } while (randomMiniGame == noRepeats);
                            if (randomMiniGame == 4)
                                score = MiniGames.GearUp(9);
                            else
                                score = MiniGames.Speed(weather);
                        }
                        noRepeats = randomMiniGame;
                    }
                    Util.ClearKey();

                    driver.Sort((x, y) => y.Item6.Item4.CompareTo(x.Item6.Item4));
                    for (int i = 0; i < driver.Count; i++)
                    {
                        int randomDNF = rnd.Next(7500 - WeatherSet.DNFModifier(weather));
                        if (driver[i].Item6.Item4 * 10 + 2 > randomDNF && driver[i].Item4 != userKey || driver[i].Item4 == otherDriverInOvertake && otherDriverInOvertakeCrashed == true)
                            listDNF.Add(new KeyValuePair<int, double>(driver[i].Item4, (totalLaps + 10 - lap) * 1000 + driver[i].Item6.Item2));
                    }

                    for (int i = 0; i < lineup.Count; i++)
                    {
                        if (lineup[i].Key == userKey && userDNF == false)
                        {
                            if (score <= -7)
                            {
                                Console.WriteLine(Colors.Red + "\rYou're out of the race" + Colors.Dark + " [Enter]                            ");
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
                    { flag = Flag.Red; redFlag = true; }
                    else if (listDNF.Count - listDNFLast > 1)
                    { flag = Flag.Yellow; yellowFlag = true; }

                    lineup = LineupGenerator.RaceLineup(userKey, newPos, lineup, listDNF, otherDriverInOvertake);

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
                if (flag == Flag.Yellow)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.Write($"\r{Colors.Custom(220, 217, 2)}VIRTUAL SAFETY CAR");
                }
                else if (flag == Flag.Red)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.Write($"\r{Colors.Custom(235, 20, 10)}RED FLAG");
                }
                else if (flag == Flag.Green && yellowFlag == true)
                {
                    yellowFlag = false;
                    Console.SetCursorPosition(0, 2);
                    Console.Write($"\r{Colors.Custom(40, 240, 44)}GREEN FLAG");
                }

                lastFlag = flag;
                flag = Flag.Green;

                if (userDNF)
                    posIndicator = Colors.Gray + "OUT" + Colors.Custom(0, 0, 0);
                else if (oldPos == newPos)
                    posIndicator = Colors.Gray + "◂" + Colors.Dark;
                else if (oldPos < newPos)
                    posIndicator = Colors.Red + "▾" + Colors.Custom(120, 0, 0) + "⁻";
                else
                    posIndicator = Colors.Green + "▴" + Colors.Custom(0, 120, 0);
                Util.ClearPart(3);

                Console.SetCursorPosition(0, 3);
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(Colors.Text);
                    for (int j = 0; j < 20; j++)
                    {
                        if (lineup[i].Key == Data.DriverData()[j].Item4)
                        {
                            if (lap == totalLaps && i == 0)
                                winner = j;
                            string fl = Data.DriverData()[j].Item4 == flHolder ? Colors.Magenta + "♦" : " ";
                            string space = i < 9 ? Colors.Magenta + " " : "";
                            string partOne = $"{space}{Colors.Grayer}{i + 1} {Colors.Text}";
                            for (int n = 0; n < listDNF.Count; n++)
                            {
                                if (listDNF[n].Key == Data.DriverData()[j].Item4)
                                {
                                    partOne = $"{Colors.Dark}-- {Colors.Grayer}";
                                    break;
                                }
                            }
                            int posDiff = oldPos - newPos < 0 ? (oldPos - newPos) * -1 : oldPos - newPos;
                            if (j == userTeamNumber[0].Item1)
                                Console.WriteLine($"{partOne}{data.UserData()[0].Item4}{fl}{Colors.Teams(j / 2)}|{Colors.Dark}{data.UserData()[0].Item3} {posIndicator + Assets.NumberToSuperscriptString(posDiff)}");
                            else
                                Console.WriteLine($"{partOne}{Data.DriverData()[j].Item3}{fl}{Colors.Teams(j / 2)}|{Colors.Darker}{Data.DriverData()[j].Item2}");
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
            EndScreen.RunningLineStringBuilder(lineup, listDNF, userKey, flHolder);
            EndScreen.RaceEndScreen(lineup, userKey, userTeamNumber[0].Item2);
            EndScreen.Anthem(winner, circuit, userTeamNumber[0].Item1);
            if (CareerMode.Active)
            { 
                CareerMode.Lineup = lineup;
                List<int> dnfDriversList = listDNF.Select(x => x.Key).ToList();
                CareerMode.DNFList = dnfDriversList;
                CareerMode.FastestLapPoint = flHolder;
            }
        }
    }
    public class Race2003 : Race
    {
        public static string HeaderString(int circuit, List<Tuple<string, string, string, int, string, int, int>> circuitData) =>
            Colors.Gray + "Sunday, " + circuitData[circuit].Item3 + ' ' + circuitData[circuit].Item4 + ", " + 2003 + '\n' + Colors.Text + circuitData[circuit].Item5.ToUpper() + " GRAND PRIX " + Colors.Yellow + "██" + Colors.Text + " RACE";
        public static new void PreRaceMenu(Data data, int circuit, List<Tuple<int, int>> userTeamNumber, List<KeyValuePair<int, double>> startingLineup, WeatherSet.Weather weather, string userTeamColor, List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> drivers, List<Tuple<string, string, string, int, string, int, int>> circuitData)
        {
            ConsoleKeyInfo key;
            int selPreRace = 1;
            string header = HeaderString(circuit, userTeamColor, circuitData);
            do
            {
                Util.ClearPart(0);
                Console.WriteLine(header + '\n' + Colors.Gray + circuitData[circuit].Item2 + '\n');
                do
                {
                    PreRaceMenuSelection(userTeamNumber, userTeamColor, selPreRace);
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                        selPreRace = Math.Min(selPreRace + 1, 4);
                    else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                        selPreRace = Math.Max(selPreRace - 1, 1);
                    Console.SetCursorPosition(0, Console.CursorTop - 4);
                } while (key.Key != ConsoleKey.Enter);
                PreRaceMenuTabs(data, circuit, userTeamNumber, startingLineup, weather, userTeamColor, drivers, circuitData, selPreRace, header);
            } while (selPreRace != 4);
        }
        public static void PreRaceMenuTabs(Data data, int circuit, List<Tuple<int, int>> userTeamNumber, List<KeyValuePair<int, double>> startingLineup, WeatherSet.Weather weather, List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> drivers, List<Tuple<string, string, string, int, string, int, int>> circuitData, int selPreRace, string header)
        {
            switch (selPreRace)
            {
                case 1:
                    Util.ClearPart(0);
                    Console.WriteLine(header + Colors.Yellow + " ██" + Colors.Text + " STARTING GRID\n" + Colors.Gray + circuitData[circuit].Item2 + '\n');
                    PreRaceGrid(data, userTeamNumber, startingLineup, drivers);
                    break;
                case 2:
                    Util.ClearPart(0);
                    Console.WriteLine(header + Colors.Yellow + " ██" + Colors.Text + " CIRCUIT VIEW\n" + Colors.Gray + circuitData[circuit].Item2 + Colors.LessGray + " [Escape]" + '\n');
                    DisplayCircuitRace.CircuitsRace(circuit);
                    break;
                case 3:
                    Util.ClearPart(0);
                    Console.WriteLine(header + Colors.Yellow + " ██" + Colors.Text + " WEATHER FORCAST\n" + Colors.Gray + circuitData[circuit].Item2 + Colors.LessGray + " [Escape]" + '\n');
                    WeatherSet.WeatherGraphics(weather);
                    break;
            }
        }
        public static void PreRaceMenuSelection(int selPreRace)
        {
            switch (selPreRace)
            {
                case 1:
                    Console.WriteLine(Colors.Yellow + "■ STARTING GRID" + Colors.Text + "\n■ CIRCUIT VIEW  \n■ WEATHER FORCAST  \n■ START THE RACE  ");
                    break;
                case 2:
                    Console.WriteLine(Colors.Text + "■ STARTING GRID  \n" + Colors.Yellow + "■ CIRCUIT VIEW" + Colors.Text + "\n■ WEATHER FORCAST  \n■ START THE RACE  ");
                    break;
                case 3:
                    Console.WriteLine(Colors.Text + "■ STARTING GRID  \n■ CIRCUIT VIEW  " + '\n' + Colors.Yellow + "■ WEATHER FORCAST" + Colors.Text + "\n■ START THE RACE  ");
                    break;
                case 4:
                    Console.WriteLine(Colors.Text + "■ STARTING GRID  \n■ CIRCUIT VIEW  \n■ WEATHER FORCAST  " + '\n' + Colors.Yellow + "■ START THE RACE");
                    break;
            }
        }
        public static new void PreRaceGrid(Data data, List<Tuple<int, int>> userTeamNumber, List<KeyValuePair<int, double>> startingLineup, List<Tuple<string, string, string, int, string, Tuple<double, double, int, int>>> drivers)
        {
            ConsoleKeyInfo key;
            int delay = 300;
            Console.SetCursorPosition(0, 24);
            Console.WriteLine(Colors.LessGray + "[Space] to speed up");
            Console.SetCursorPosition(0, 4);
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (startingLineup[i].Key == drivers[j].Item4)
                    {
                        if (Console.KeyAvailable)
                        {
                            key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Spacebar)
                                delay = 0;
                        }
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write(Data2003.CircuitNumbering(i + 1));
                        if (j == userTeamNumber[0].Item1)
                        {
                            Console.Write(Colors.Yellow + data.UserData()[0].Item2.ToUpper() + "".PadRight(Math.Max(14 - data.UserData()[0].Item2.Length, 0) ,'─') + '┐');
                            Console.SetCursorPosition(0, Console.CursorTop + 1);
                            if (16 - Data2003.TeamList()[j / 2].TrimEnd().Length > 0)
                                Console.Write('└');
                            Console.WriteLine("".PadRight(Math.Max(15 - Data2003.TeamList()[j / 2].TrimEnd().Length, 0), '─') + Colors.Blue + Data2003.TeamList()[j / 2].TrimEnd() + Data2003.TyreTypeForTeam(j / 2));
                        }
                        else
                        {
                            Console.Write(Colors.Text + drivers[j].Item3 + "".PadRight(Math.Max(14 - drivers[j].Item3.Length, 0), '─') + '┐');
                            Console.SetCursorPosition(0, Console.CursorTop + 1);
                            if (16 - Data2003.TeamList()[j / 2].TrimEnd().Length > 0)
                                Console.Write('└');
                            Console.WriteLine("".PadRight(Math.Max(15 - drivers[j].Item1.TrimEnd().Length, 0), '─') + Colors.Blue + drivers[j].Item1.TrimEnd() + Data2003.TyreTypeForTeam(j / 2));
                        }
                    }
                }
                i = Math.Min(i + 1, 19);
                for (int j = 0; j < 20; j++)
                {
                    if (startingLineup[i].Key == drivers[j].Item4)
                    {
                        if (Console.KeyAvailable)
                        {
                            key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Spacebar)
                                delay = 0;
                        }
                        Console.SetCursorPosition(20, Console.CursorTop - 1);
                        Console.Write(Data2003.CircuitNumbering(i + 1));
                        if (j == userTeamNumber[0].Item1)
                        {
                            Console.Write(Colors.Yellow + data.UserData()[0].Item2.ToUpper() + "".PadRight(Math.Max(14 - data.UserData()[0].Item2.Length, 0), '─') + '┐');
                            Console.SetCursorPosition(20, Console.CursorTop + 1);
                            if (16 - Data2003.TeamList()[j / 2].TrimEnd().Length > 0)
                                Console.Write('└');
                            Console.WriteLine("".PadRight(Math.Max(15 - Data2003.TeamList()[j / 2].TrimEnd().Length, 0), '─') + Colors.Blue + Data2003.TeamList()[j / 2].TrimEnd() + Data2003.TyreTypeForTeam(j / 2));
                        }
                        else
                        {
                            Console.Write(Colors.Text + drivers[j].Item3 + "".PadRight(Math.Max(14 - drivers[j].Item3.Length, 0), '─') + '┐');
                            Console.SetCursorPosition(20, Console.CursorTop + 1);
                            if (16 - Data2003.TeamList()[j / 2].TrimEnd().Length > 0)
                                Console.Write('└');
                            Console.WriteLine("".PadRight(Math.Max(15 - drivers[j].Item1.TrimEnd().Length, 0), '─') + Colors.Blue + drivers[j].Item1.TrimEnd() + Data2003.TyreTypeForTeam(j / 2));
                        }
                    }
                }
                Task.Delay(delay).Wait();
            }
            Console.WriteLine(Colors.LessGray + "[Escape]            ");
            Util.KeyAdvance(ConsoleKey.Escape);
        }
    }
    public class EndScreen
    {
        public static string[] Flag(string country)
        {
            string[] flag = new string[6];
            country = country.ToLower();
            switch (country)
            {
                case "2003":
                    flag[0] = Colors.Black + $"     █████████▀   {Colors.Red}▄████▓▒▒░░░" + Colors.Text;
                    flag[1] = Colors.Black + $"    █████▀▀▀     {Colors.Red}▄████▓▒▒░░░" + Colors.Text;
                    flag[2] = Colors.Black + $"   █████▄▄▄     {Colors.Red}▄████▓▒▒░░░" + Colors.Text;
                    flag[3] = Colors.Black + $"  ████████▀    {Colors.Red}▄████▓▒▒░░░" + Colors.Text;
                    flag[4] = Colors.Black + $" █████         {Colors.Red}   █▓▒▒░░░" + Colors.Text;
                    flag[5] = Colors.Black + $"█████            {Colors.Red}█▓▒▒░░░" + Colors.Text;
                    break;
                case "monaco":
                    flag[0] = flag[1] = flag[2] = Colors.Custom(206, 17, 38) + "█████████";
                    flag[3] = flag[4] = flag[5] = Colors.Text + "█████████";
                    break;
                case "singapore":
                    flag[0] = Colors.Text + "\x1b[48;2;199;59;60m" + "╭ .      " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[1] = Colors.Text + "\x1b[48;2;199;59;60m" + "│· ·     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = Colors.Text + "\x1b[48;2;199;59;60m" + "╰ ¨      " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[3] = flag[4] = flag[5] = Colors.Text + "█████████";
                    break;
                case "poland":
                    flag[0] = flag[1] = flag[2] = Colors.Text + "█████████";
                    flag[3] = flag[4] = flag[5] = Colors.Custom(220, 20, 60) + "█████████";
                    break;
                case "ukraine":
                    flag[0] = flag[1] = flag[2] = Colors.Custom(0, 87, 183) + "█████████";
                    flag[3] = flag[4] = flag[5] = Colors.Custom(255, 221, 0) + "█████████";
                    break;
                case "united states": 
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = Colors.Custom(179, 25, 66) + "\x1b[48;5;255m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[5] = Colors.Custom(179, 25, 66) + "▀▀▀▀▀▀▀▀▀";
                    break;
                case "spain":
                    flag[5] = flag[0] = Colors.Custom(170, 21, 27) + "█████████";
                    flag[2] = flag[3] = Colors.Custom(241, 191, 0) + "█████████";
                    flag[1] = Colors.Custom(170, 21, 27) + "\x1b[48;2;241;191;0m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[4] = Colors.Custom(170, 21, 27) + "\x1b[48;2;241;191;0m" + "▄▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "mexico":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Text + "███" + Colors.Custom(206, 17, 37) + "██████";
                    flag[2] = flag[3] = Colors.Custom(75, 35, 20) + "█" + Colors.Text + "██" + Colors.Custom(206, 17, 37) + "██████";
                    break;
                case "france":
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = flag[5] = Colors.Text + "███" + Colors.Custom(237, 41, 57) + "██████";
                    break;
                case "italy":
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = flag[5] = Colors.Text + "███" + Colors.Custom(205, 33, 42) + "██████";
                    break;
                case "belgium":
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = flag[5] = Colors.Custom(255, 205, 0) + "███" + Colors.Custom(200, 16, 46) + "██████";
                    break;
                case "ireland":
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = flag[5] = Colors.Text + "███" + Colors.Custom(255, 130, 0) + "██████";
                    break;
                case "qatar":
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = flag[5] = Colors.Text + "\x1b[48;2;138;21;56m" + "►        " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text; ;
                    break;
                case "bahrain":
                    flag[0] = flag[1] = flag[2] = flag[3] = flag[4] = flag[5] = Colors.Text + "\x1b[48;2;206;17;38m" + "►        " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text; ;
                    break;
                case "china":
                    flag[0] = flag[3] = Colors.Custom(255, 255, 0) + "\x1b[48;2;238;28;37m" + "   ·     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[1] = Colors.Custom(255, 255, 0) + "\x1b[48;2;238;28;37m" + " ♦  ·    " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = Colors.Custom(255, 255, 0) + "\x1b[48;2;238;28;37m" + "    ·    " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[4] = flag[5] = Colors.Custom(238, 28, 37) + "█████████";
                    break;
                case "united kingdom":
                    flag[0] = "\x1b[48;5;255m" + Colors.Custom(200, 16, 46) + "█" + Colors.Text + "█" + Colors.Custom(1, 33, 105) + "▀" + Colors.Custom(200, 16, 46) + " ▄█▀ " + Colors.Custom(1, 33, 105) + "▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[1] = "\x1b[48;5;255m" + Colors.Custom(200, 16, 46) + "█" + Colors.Text + "█" + Colors.Custom(200, 16, 46)+ "▄█▀ " + Colors.Custom(1, 33, 105) + "▄██" +"\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = "\x1b[48;5;255m" + Colors.Custom(200, 16, 46) + "\x1b[48;5;255m" + "█▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[3] = "\x1b[48;5;255m" + Colors.Custom(200, 16, 46) + "\x1b[48;5;255m" + "█▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[5] = "\x1b[48;5;255m" + Colors.Custom(200, 16, 46) + "█" + Colors.Text + "█" + Colors.Custom(1, 33, 105) + "█▄ " + Colors.Custom(200, 16, 46) + "▀█▄ " +"\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[4] = "\x1b[48;5;255m" + Colors.Custom(200, 16, 46) + "█" + Colors.Text + "█" + Colors.Custom(200, 16, 46) + " ▀█▄ " + Colors.Custom(1, 33, 105) + "▀█" +"\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "austria":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Custom(239, 51, 64) + "█████████";
                    flag[2] = flag[3] = Colors.Text + "█████████";
                    break;
                case "argentina":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Custom(108, 172, 228) + "█████████";
                    flag[2] = Colors.Custom(255, 184, 28) + "\x1b[48;5;255m" + "(☻)      " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[3] = Colors.Text + "█████████";
                    break;
                case "netherlands":
                    flag[0] = flag[1] = Colors.Custom(169, 31, 50) + "█████████";
                    flag[2] = flag[3] = Colors.Text + "█████████";
                    flag[4] = flag[5] = Colors.Custom(30, 71, 133) + "█████████";
                    break;
                case "uae":
                    flag[0] = flag[1] = Colors.Custom(239, 51, 64) + "█" + Colors.Custom(0, 151, 57) + "████████";
                    flag[2] = flag[3] = Colors.Custom(239, 51, 64) + "█" + Colors.Text + "████████";
                    flag[4] = flag[5] = Colors.Custom(239, 51, 64) + "█" + Colors.Custom(10, 10, 10) + "████████";
                    break;
                case "hungary":
                    flag[0] = flag[1] = Colors.Custom(206, 41, 57) + "█████████";
                    flag[2] = flag[3] = Colors.Text + "█████████";
                    flag[4] = flag[5] = Colors.Custom(71, 112, 80) + "█████████";
                    break;
                case "thailand":
                    flag[0] = flag[5] = Colors.Custom(239, 51, 64) + "█████████";
                    flag[1] = flag[4] = Colors.Text + "█████████";
                    flag[2] = flag[3] = Colors.Custom(0, 36, 125) + "█████████";
                    break;
                case "germany":
                    flag[0] = flag[1] = Colors.Custom(10, 10, 10) + "█████████";
                    flag[2] = flag[3] = Colors.Custom(221, 0, 0) + "█████████";
                    flag[4] = flag[5] = Colors.Custom(255, 204, 0) + "█████████";
                    break;
                case "azerbaijan":
                    flag[0] = flag[1] = Colors.Custom(0, 146, 188) + "█████████";
                    flag[2] = flag[3] = Colors.Custom(228, 0, 43) + "█████████";
                    flag[4] = flag[5] = Colors.Custom(0, 175, 102) + "█████████";
                    break;
                case "lithuania":
                    flag[0] = flag[1] = Colors.Custom(255, 184, 28) + "█████████";
                    flag[2] = flag[3] = Colors.Custom(4, 106, 56) + "█████████";
                    flag[4] = flag[5] = Colors.Custom(190, 58, 52) + "█████████";
                    break;
                case "estonia":
                    flag[0] = flag[1] = Colors.Custom(0, 114, 206) + "█████████";
                    flag[2] = flag[3] = Colors.Custom(6, 6, 6) + "█████████";
                    flag[4] = flag[5] = Colors.Text + "█████████";
                    break;
                case "georgia":
                    flag[0] = Colors.Custom(255, 0, 0) + "\x1b[48;5;255m" + "█    ▄   " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[1] = Colors.Custom(255, 0, 0) + "\x1b[48;5;255m" + "█   ▀█▀  " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = Colors.Custom(255, 0, 0) + "\x1b[48;5;255m" + "█▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[3] = Colors.Custom(255, 0, 0) + "\x1b[48;5;255m" + "█▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[4] = Colors.Custom(255, 0, 0) + "\x1b[48;5;255m" + "█   ▄█▄  " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[5] = Colors.Custom(255, 0, 0) + "\x1b[48;5;255m" + "█    ▀   " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "saudi arabia":
                    flag[0] = flag[3] = flag[5] = Colors.Custom(22, 93, 49) + "█████████";
                    flag[1] = Colors.Text + "\x1b[48;2;22;93;49m" + "░▓▒▒     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = Colors.Text + "\x1b[48;2;22;93;49m" + "▓▒░▓     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[4] = Colors.Text + "\x1b[48;2;22;93;49m" + "══╪╴     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "sealand":
                    flag[0] = Colors.Custom(200, 50, 50) + "\x1b[48;5;255m" + "███████▀ " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[1] = Colors.Custom(200, 50, 50) + "\x1b[48;5;255m" + "█████▀   " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = Colors.Custom(200, 50, 50) + "\x1b[48;5;255m" + "███▀   " + Colors.Custom(10, 10, 10) + "▄█" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[3] = Colors.Custom(200, 50, 50) + "\x1b[48;5;255m" + "█▀   " + Colors.Custom(10, 10, 10) + "▄███" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[4] = Colors.Custom(10, 10, 10) + "\x1b[48;5;255m" + "   ▄█████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[5] = Colors.Custom(10, 10, 10) + "\x1b[48;5;255m" + " ▄███████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "brazil":
                    flag[0] = "\x1b[48;2;254;221;0m" + Colors.Custom(0, 151, 57) + "▀▀███████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[1] = "\x1b[48;2;254;221;0m" + Colors.Custom(1, 33, 105) + "▄▄ " + Colors.Custom(0, 151, 57) + "▀█████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = "\x1b[48;2;254;221;0m" + Colors.Custom(1, 33, 105) + "███  " + Colors.Custom(0, 151, 57) + "▀███" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[3] = "\x1b[48;2;254;221;0m" + Colors.Custom(1, 33, 105) + "███  " + Colors.Custom(0, 151, 57) + "▄███" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[4] = "\x1b[48;2;254;221;0m" + Colors.Custom(1, 33, 105) + "▀▀ " + Colors.Custom(0, 151, 57) + "▄█████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[5] = "\x1b[48;2;254;221;0m" + Colors.Custom(0, 151, 57) + "▄▄███████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "switzerland":
                    flag[0] = flag[5] = Colors.Custom(218, 41, 28) + "██████";
                    flag[1] = flag[4] = Colors.Text + "█" + Colors.Custom(218, 41, 28) + "█████";
                    flag[2] = Colors.Text + "\x1b[48;2;218;41;28m" + "█▄▄▄  " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[3] = Colors.Text + "\x1b[48;2;218;41;28m" + "█▀▀▀  " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "canada":
                    flag[0] = flag[5] = Colors.Text + "█████" + Colors.Custom(216, 6, 33) + "████";
                    flag[1] = Colors.Custom(216, 6, 33) + "\x1b[48;5;255m" + "█▄   ████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = Colors.Custom(216, 6, 33) + "\x1b[48;5;255m" + "██▄█ ████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[3] = Colors.Custom(216, 6, 33) + "\x1b[48;5;255m" + "███▄ ████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[4] = Colors.Custom(216, 6, 33) + "\x1b[48;5;255m" + "▌    ████" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "japan":
                    flag[0] = flag[5] = Colors.Text + "█████████";
                    flag[1] = Colors.Custom(188, 0, 45) + "\x1b[48;5;255m" + "▄▄       " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = Colors.Custom(188, 0, 45) + "\x1b[48;5;255m" + "███▄     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[3] = Colors.Custom(188, 0, 45) + "\x1b[48;5;255m" + "███▀     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[4] = Colors.Custom(188, 0, 45) + "\x1b[48;5;255m" + "▀▀       " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "australia":
                    flag[0] = flag[4] = Colors.Custom(255, 255, 255) + "\x1b[48;2;1;33;105m" + "   ♦     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[1] = Colors.Custom(255, 255, 255) + "\x1b[48;2;1;33;105m" + "     ♦   " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = Colors.Custom(255, 255, 255) + "\x1b[48;2;1;33;105m" + " ♦  ․    " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[5] = flag[3] = Colors.Custom(1, 33, 105) + "█████████";
                    break;
                case "new zealand":
                    flag[0] = flag[4] = Colors.Custom(200, 16, 46) + "\x1b[48;2;1;33;105m" + "   ♦     " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[1] = Colors.Custom(200, 16, 46) + "\x1b[48;2;1;33;105m" + "     ♦   " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = Colors.Custom(200, 16, 46) + "\x1b[48;2;1;33;105m" + " ♦  ․    " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[5] = flag[3] = Colors.Custom(1, 33, 105) + "█████████";
                    break;
                case "finland":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Text + "█████████";
                    flag[2] = Colors.Custom(0, 47, 108) + "\x1b[48;5;255m" + "▄▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[3] = Colors.Custom(0, 47, 108) + "\x1b[48;5;255m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "denmark":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Custom(200, 16, 46) + "█████████";
                    flag[3] = Colors.Custom(200, 16, 46) + "\x1b[48;5;255m" + "▄▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = Colors.Custom(200, 16, 46) + "\x1b[48;5;255m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "sweden":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Custom(0, 106, 167) + "█████████"; 
                    flag[2] = Colors.Custom(254, 204, 2) + "\x1b[48;2;0;106;167m" + "▄▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[3] = Colors.Custom(254, 204, 2) + "\x1b[48;2;0;106;167m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "latvia":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Custom(164, 52, 58) + "█████████";
                    flag[3] = Colors.Custom(164, 52, 58) + "\x1b[48;5;255m" + "▄▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[2] = Colors.Custom(164, 52, 58) + "\x1b[48;5;255m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                case "norway":
                    flag[0] = flag[1] = flag[4] = flag[5] = Colors.Custom(186, 12, 47) + "█████████";
                    flag[2] = Colors.Custom(0, 32, 91) + "\x1b[48;5;255m" + "▄▄▄▄▄▄▄▄▄" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[3] = Colors.Custom(0, 32, 91) + "\x1b[48;5;255m" + "▀▀▀▀▀▀▀▀▀" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    break;
                default:
                    flag[1] = flag[3] = flag[5] = Colors.Darker + "\x1b[48;5;255m" + "█  ██  ██" + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
                    flag[0] = flag[2] = flag[4] = Colors.Darker + "\x1b[48;5;255m" + " ██  ██  " + "\x1b[48;2;0;0;0m" + Colors.Custom(0, 0, 0) + '█' + Colors.Text;
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
                            countries[i] = data.UserData()[0].Item5.ToLower() + "";
                        }
                        else
                        {
                            nums[i] = Data.DriverData()[j].Item4.ToString();
                            names[i] = Data.DriverData()[j].Item2;
                            countries[i] = Data.DriverData()[j].Item5.ToLower();
                        }
                        if (nums[i].Length == 1)
                            nums[i] = Colors.Teams(j / 2) + nums[i] + " " + Colors.Text;
                        else
                            nums[i] = Colors.Teams(j / 2) + nums[i] + Colors.Text;
                        string[] capsName = names[i].Split(' ' , 2);
                        if (j == 17 && Data.DriverData()[j].Item4 != userKey)
                            names[i] = capsName[0].ToUpper() + " " + capsName[1];
                        else
                            names[i] = capsName[0] + " " + capsName[1].ToUpper();
                        while (names[i].Length < 21)
                            names[i] = names[i] + " ";
                        teams[i] = Colors.Teams(j / 2) + Data.DriverData()[j].Item1 + Colors.Text;
                    }
                }
            }
            Console.WriteLine("" + Colors.Text + 
                "───────────────────────┐" + '\n' + 
                          $" {names[0]} │" + Flag(countries[0])[0] + '\n' + 
        $" {nums[0]}     {Colors.Teams(keys[0] / 2)}_______{Colors.Text}        │" + Flag(countries[0])[1] + '\n' +
              $@"       {Colors.Teams(keys[0] / 2)}_\═.o.═/_{Colors.Text}       │" + Flag(countries[0])[2] + '\n' +
               $"      {Colors.Teams(keys[0] / 2)}|_|_____|_|{Colors.Text}      │" + Flag(countries[0])[3] + '\n' + Colors.Text +
                "                    /  │" + Flag(countries[0])[4] + '\n' + 
                 $"  {teams[0]}     / st│" + Flag(countries[0])[5] + '\n' + Colors.Text +
                "───────────────────────┤" + '\n' + 
                          $" {names[1]} │" + Flag(countries[1])[0] + '\n' + 
        $" {nums[1]}     {Colors.Teams(keys[1] / 2)}_______{Colors.Text}        │" + Flag(countries[1])[1] + '\n' +
              $@"       {Colors.Teams(keys[1] / 2)}_\═.o.═/_{Colors.Text}       │" + Flag(countries[1])[2] + '\n' +
               $"      {Colors.Teams(keys[1] / 2)}|_|_____|_|{Colors.Text}  __  │" + Flag(countries[1])[3] + '\n' + Colors.Text +
                "                   _/  │" + Flag(countries[1])[4] + '\n' +
                 $"  {teams[1]}    /_ nd│" + Flag(countries[1])[5] + '\n' + Colors.Text +
                "───────────────────────┤" + '\n' +
                          $" {names[2]} │" + Flag(countries[2])[0] + '\n' +
        $" {nums[2]}     {Colors.Teams(keys[2] / 2)}_______{Colors.Text}        │" + Flag(countries[2])[1] + '\n' +
              $@"       {Colors.Teams(keys[2] / 2)}_\═.o.═/_{Colors.Text}       │" + Flag(countries[2])[2] + '\n' +
               $"      {Colors.Teams(keys[2] / 2)}|_|_____|_|{Colors.Text}  _   │" + Flag(countries[2])[3] + '\n' + Colors.Text +
               @"                   _\  │" + Flag(countries[2])[4] + '\n' +
                 $"  {teams[2]}    __/rd│" + Flag(countries[2])[5] + '\n' + Colors.Text +
                "───────────────────────┘");
        }
        public static void Anthem(int winner, int circuit, int userKey)
        {
            ConsoleKeyInfo key;
            StopRunningLine = false;
            Data data = new();
            bool timeout;
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, the = "",
            driverCountry = winner == userKey ? data.UserData()[0].Item5 + "" : Data.DriverData()[winner].Item5,
            driverWinner = winner == userKey ? data.UserData()[0].Item3 + "" : Data.DriverData()[winner].Item2;
            if (driverCountry == "United Kingdom" || driverCountry == "United States" || driverCountry == "Netherlands")
                the = "the ";
            Console.SetCursorPosition(42, 2);
            Console.Write(Colors.Teams(winner / 2) + $"{driverWinner}{Colors.Text} is the winner of {Data.CircuitData()[circuit].Item5} GP");
            Console.SetCursorPosition(42, 3);
            Console.Write($"The natonal anthem of {the}{driverCountry} is playing");
            BoxForLine();
            Thread runningLine = new(new ThreadStart(RunningLine))
            { IsBackground = true };
            runningLine.Start();
            try
            {
                using VorbisWaveReader anthermPath = new(@$"{path}\sound\{driverCountry.ToLower()}.ogg"), carmenPath = new(@$"{path}\sound\Carmen_Prelude_to_Act_1.ogg");
                using WaveOutEvent play = new();
                play.Init(anthermPath);
                play.Play();

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
                            play.Volume = Math.Min(play.Volume + 0.05f, 1);
                        if (key.Key == ConsoleKey.DownArrow)
                            play.Volume = Math.Max(play.Volume - 0.05f, 0);
                    }
                    if (skip > 0 && timeout)
                        skip--;
                    if (play.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                    {
                        ConsoleSemaphore.Wait();
                        Console.SetCursorPosition(42, 4);
                        Console.Write(Colors.Dark + "Hold [Space] to skip");
                        Assets.FillBar(skip);
                        ConsoleSemaphore.Release();
                    }
                    else
                    {
                        ConsoleSemaphore.Wait();
                        Console.SetCursorPosition(42, 4);
                        Console.Write(Colors.Dark + "Press [Enter] to advance       ");
                        ConsoleSemaphore.Release();
                        play.Init(carmenPath);
                        play.Play();
                        Util.KeyAdvance(ConsoleKey.Enter);
                        break;
                    }
                    Util.ClearKey();
                }
                play.Dispose();
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
        public static void RunningLineStringBuilder(List<KeyValuePair<int, double>> lineup, List<KeyValuePair<int, double>> listDNF, int userKey, int fastestLap)
        {
            StringBuilder runningLine = new();
            string fl, driverSN;
            string[] driverDNF = new string[3];
            Data data = new();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (lineup[i].Key == Data.DriverData()[j].Item4)
                    {
                        driverSN = lineup[i].Key == userKey ? data.UserData()[0].Item4 + "" : Data.DriverData()[j].Item3;
                        for (int n = 0; n < listDNF.Count; n++)
                        {
                            if (listDNF[n].Key == Data.DriverData()[j].Item4)
                            {
                                driverDNF[0] = Data.DriverData()[j].Item4 == listDNF[n].Key ? "₁" : " ";
                                driverDNF[1] = Data.DriverData()[j].Item4 == listDNF[n].Key ? "₂" : " ";
                                driverDNF[2] = Data.DriverData()[j].Item4 == listDNF[n].Key ? "₃" : " ";
                                break;
                            }
                        }
                        fl = lineup[i].Key == fastestLap ? "·" : " ";
                        runningLine.Append("|" + (i + 1) + fl + driverSN + " " + TeamColorChars[j / 2] + " " + driverDNF[0] + driverDNF[1] + driverDNF[2] + "           ");
                    }
                }
            }
            Line = runningLine.ToString();
        }
        static List<char> TeamColorChars => new() { '❶', '❷', '❸', '❹', '❺', '❻', '❼', '❽', '❾', '❿' };
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
            for (int i = 50; i > 0 && !StopRunningLine; i = Math.Max(i - 1, 0))
            {
                displayLine = new string(' ', Math.Max(i, 0)) + line.Remove(50 - i);
                ConsoleSemaphore.Wait();
                for (int j = 0; j < displayLine.Length; j++)
                {
                    Console.SetCursorPosition(42 + j, 12);
                    if (displayLine[j] == '·')
                        Console.Write(Colors.Magenta + displayLine[j] + Colors.Text);
                    else if (displayLine[j] == '|')
                        Console.Write(Colors.Dark + displayLine[j] + Colors.Text);
                    else if (displayLine[j] == '₁')
                        Console.Write(Colors.Grayer + "D");
                    else if (displayLine[j] == '₂')
                        Console.Write(Colors.Grayer + "N");
                    else if (displayLine[j] == '₃')
                        Console.Write(Colors.Grayer + "F" + Colors.Text);
                    else if (TeamColorChars.Contains(displayLine[j]))
                        Console.Write(Colors.Teams(TeamColorChars.IndexOf(displayLine[j])) + "●" + Colors.Text);
                    else
                        Console.Write(Colors.Text + displayLine[j]);
                }
                ConsoleSemaphore.Release();
                Task.Delay(86).Wait();
            }
            while (!StopRunningLine)
            {
                displayLine = line.Remove(0, x);
                if (displayLine.Length < 50)
                    displayLine += line.Remove(50 - displayLine.Length);
                else
                    displayLine = displayLine.Remove(50);
                for (int j = 0; j < displayLine.Length; j++)
                {
                    ConsoleSemaphore.Wait();
                    Console.SetCursorPosition(42 + j, 12);
                    if (displayLine[j] == '·')
                        Console.Write(Colors.Magenta + displayLine[j] + Colors.Text);
                    else if (displayLine[j] == '|')
                        Console.Write(Colors.Dark + displayLine[j] + Colors.Text);
                    else if (displayLine[j] == '₁')
                        Console.Write(Colors.Grayer + "D");
                    else if (displayLine[j] == '₂')
                        Console.Write(Colors.Grayer + "N");
                    else if (displayLine[j] == '₃')
                        Console.Write(Colors.Grayer + "F" + Colors.Text);
                    else if (TeamColorChars.Contains(displayLine[j]))
                        Console.Write(Colors.Teams(TeamColorChars.IndexOf(displayLine[j])) + "●" + Colors.Text);
                    else
                        Console.Write(Colors.Text + displayLine[j]);
                    ConsoleSemaphore.Release();
                }
                if (x == line.Length)
                    x = 0;
                else
                    x++;
                Task.Delay(86).Wait();
            }
        }
    }
    public class CareerMode
    {
        public static bool OverwriteSaveWarrning()
        {
            bool selectedOption = true;
            if (!ThereIsNoSave())
            {
                ConsoleKeyInfo key;
                Console.WriteLine($"{Colors.Red}                    /{Colors.Text}There's Already a Save\n{Colors.Red}                   /{Colors.Gray}Overwrite It?\n");
                do
                {
                    switch (selectedOption)
                    {
                        case true:
                            Console.Write($"\r                      {Colors.Red}Yes              {Colors.Gray}No");
                            break;
                        case false:
                            Console.Write($"\r                      {Colors.Gray}Yes              {Colors.Red}No");
                            break;
                    }
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.LeftArrow)
                        selectedOption = true;
                    else if (key.Key == ConsoleKey.RightArrow)
                        selectedOption = false;
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        selectedOption = false;
                        break;
                    }
                } while (key.Key != ConsoleKey.Enter);
            }
            return selectedOption;
        }
        public static bool ThereIsNoSave() 
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            using var careerReader = new StreamReader(@$"{path}\UserData\CareerMode.txt");
            string? careerLine = careerReader.ReadLine();
            return careerLine == "0";
        }
        public static List<KeyValuePair<int, double>>? Lineup { get; set; }
        public static List<int>? DNFList { get; set; }
        public static int FastestLapPoint { get; set; }
        public static bool Active { get; set; }
        public static void NewCareer()
        {
            CareerManager.InitializeSave();
            CareerManager.InitializeGrandPrixStats();
            CareerManager.ClearGrandPrixStats();
            CareerManager.UserKey = 0;
            CareerManager.UserNumber = 0;
            CareerManager.CareerGP = 0;
            CareerManager.SaveCareer();
        }
        public static void Career()
        {
            CareerManager.LoadCareer();
            List<Tuple<int, int>> userTeamNumber = new();
            bool backToMainMenu = false;
            if (CareerManager.UserNumber is 0)
            {
                userTeamNumber = TeamSelector.TeamListing();
                CareerManager.UserKey = userTeamNumber[0].Item1;
                CareerManager.UserNumber = userTeamNumber[0].Item2;
            }
            else
            {
                CareerManager.LoadGrandPrixStats();
                userTeamNumber.Add(new Tuple<int, int>(CareerManager.UserKey, CareerManager.UserNumber));
                var key = CareerMenu(userTeamNumber[0].Item1, CareerManager.CareerGP - 1, SortDrivers, SortConstructors());
                if (key is ConsoleKey.Escape)
                    backToMainMenu = true;
            }
            int userKey = CareerManager.UserKey; 
            for (int circuit = CareerManager.CareerGP; circuit < Data.CircuitData().Count && !backToMainMenu; circuit++)
            {
                Util.ClearPart(0);
                ASCIITextConverter($"{Data.CircuitData()[circuit].Item5} GP", 5, Colors.Teams(userKey / 2));
                Task.Delay(1000).Wait();
                Active = true;
                RaceSetup.CareerRace(circuit, userTeamNumber, userKey);
                Active = false;
                Updater();
                GrandPrixStatsUpdater();
                CareerManager.CareerGP = circuit + 1;
                CareerManager.SaveCareer();
                CareerManager.SaveGrandPrixStats();
                var sortedPoints = SortDrivers;
                var sortedConstructors = SortConstructors();
                var key = CareerMenu(userKey, circuit, sortedPoints, sortedConstructors);
                if (key is ConsoleKey.Escape)
                    break;
            }
        }
        private static ConsoleKey CareerMenu(int userKey, int circuit, List<CareerSave<int, int, Position, short[], short[]>> sortedPoints, List<Tuple<int, int, Position>> sortedConstructors)
        {
            Util.ClearPart(0);
            Data data = new();
            ConsoleKeyInfo key;
            int menu = 0;
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(MenuTabs(userKey, menu) + Colors.White);
                Util.ClearKey();
                if (menu is 0)
                    key = Dashboard(userKey, sortedPoints, sortedConstructors, data);
                else if (menu is 1)
                    key = Standings(userKey, circuit, sortedPoints, sortedConstructors, data);
                else if (menu is 2)
                    key = Calendar(userKey);
                else
                    key = Settings(userKey);
                if (key.Key is ConsoleKey.RightArrow)
                    menu = Math.Min(menu + 1, 3);
                else if (key.Key is ConsoleKey.LeftArrow)
                    menu = Math.Max(menu - 1, 0);
                else if (key.Key is ConsoleKey.Escape or ConsoleKey.Enter)
                    return key.Key;
                Util.ClearPart(0);
            }
        }
        private static ConsoleKeyInfo Calendar(int userKey)
        {
            ConsoleKeyInfo key;
            Data data = new();
            int selectedGP = CareerManager.CareerGP - 1, pos, points;
            string numbering, symbol, grid;
            Console.WriteLine(Colors.Text + $"{Colors.Teams(userKey / 2)}\rCalendar >\n");
            while (true)
            {
                Console.SetCursorPosition(0, 5);
                for (int gp = 0; gp < Data.CircuitData().Count; gp++)
                {
                    numbering = gp < 9 ? $"R0{gp + 1}" : $"R{gp + 1}";
                    if (gp > CareerManager.CareerGP - 1)
                        Console.Write(Colors.Gray + numbering + " " + Data.CircuitData()[gp].Item5 + " GP");
                    else if (gp == selectedGP)
                        Console.Write(Colors.Teams(userKey / 2) + numbering + " " + Data.CircuitData()[gp].Item5 + " GP");
                    else if (gp != selectedGP)
                        Console.Write(Colors.White + numbering + " " + Data.CircuitData()[gp].Item5 + " GP");
                    Console.SetCursorPosition(30, Console.CursorTop);
                    Console.Write("│");
                    Console.SetCursorPosition(23, Console.CursorTop);
                    Console.WriteLine(Colors.Gray + Data.CircuitData()[gp].Item3.Remove(3).ToUpper() + " " + Data.CircuitData()[gp].Item4);
                }
                GPProgressBar(selectedGP, 11, 2, userKey);
                for (int driver = 0; driver < 20; driver++)
                {
                    if (CareerManager.GrandPrixStats[driver][selectedGP] < -99)
                    {
                        pos = CareerManager.GrandPrixStats[driver][selectedGP] * -1 - 100;
                        symbol = $"{Colors.Gray}DNF{Colors.Magenta}◊";
                        if (pos < 9)
                            points = PointDistribution(pos) + 1;
                        else
                            points = PointDistribution(pos);
                    }
                    else if (CareerManager.GrandPrixStats[driver][selectedGP] < 0)
                    {
                        pos = CareerManager.GrandPrixStats[driver][selectedGP] * -1;
                        symbol = $"{Colors.Gray}DNF ";
                        points = PointDistribution(pos);
                    }
                    else if (CareerManager.GrandPrixStats[driver][selectedGP] > 19)
                    {
                        pos = CareerManager.GrandPrixStats[driver][selectedGP] - 100;
                        symbol = $"{Colors.Magenta}♦   ";
                        if (pos < 10)
                            points = PointDistribution(pos) + 1;
                        else
                            points = PointDistribution(pos);
                    }
                    else
                    { 
                        pos = CareerManager.GrandPrixStats[driver][selectedGP]; 
                        symbol = "    ";
                        points = PointDistribution(pos);
                    }
                    numbering = pos < 9 ? $"P0{pos + 1}" : $"P{pos + 1}";
                    grid = driver == userKey
                    ? Colors.Gray + numbering + Colors.Teams(driver / 2) + " |" + Colors.White + data.UserData()[0].Item4 + " " + Colors.Teams(driver / 2) + CareerManager.UserNumber + "  "
                    : Colors.Gray + numbering + Colors.Teams(driver / 2) + " |" + Colors.White + Data.DriverData()[driver].Item3 + " " + Colors.Teams(driver / 2) + Data.DriverData()[driver].Item4 +  "  ";
                    if (pos < 3)
                        Console.SetCursorPosition(34, 6 + pos);
                    else if (pos < 10)
                        Console.SetCursorPosition(34, 7 + pos);
                    else
                        Console.SetCursorPosition(34, 8 + pos);
                    Console.Write(grid);
                    Console.SetCursorPosition(46, Console.CursorTop);
                    Console.Write(symbol);
                    if (points != 0)
                        Console.Write(Colors.Gray + "+" + points + "Pts");
                }
                key = Console.ReadKey(true);
                if (key.Key is ConsoleKey.DownArrow or ConsoleKey.S)
                    selectedGP = Math.Min(CareerManager.CareerGP - 1, selectedGP + 1);
                else if (key.Key is ConsoleKey.UpArrow or ConsoleKey.W)
                    selectedGP = Math.Max(0, selectedGP - 1);
                else if (key.Key is ConsoleKey.Escape or ConsoleKey.LeftArrow or ConsoleKey.RightArrow or ConsoleKey.Enter)
                    break;
                Util.ClearKey();
            }
            return key;
        }
        private static ConsoleKeyInfo Standings(int userKey, int circuit, List<CareerSave<int, int, Position, short[], short[]>> sortedPoints, List<Tuple<int, int, Position>> sortedConstructors, Data data)
        {
            ConsoleKeyInfo key;
            int selectedDriver = userKey, driverId = userKey;
            Console.WriteLine(Colors.Teams(userKey / 2) + $"\rChampionship Standings > {Colors.Text}After {Data.CircuitData()[circuit].Item5} GP\n\n{Colors.White}Drivers                            Constructors");
            for (int sorted = 0; sorted < 20; sorted++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (sortedPoints[sorted].Number == Data.DriverData()[j].Item4)
                    {
                        string pos = sorted < 9 ? $" {sorted + 1}" : (sorted + 1).ToString();
                        string? driverName = userKey == j ? data.UserData()[0].Item3 : Data.DriverData()[j].Item2;
                        if (j == userKey)
                        { Console.Write(Colors.Red + pos + Colors.Teams(j / 2) + "|" + Colors.Red + driverName); selectedDriver = sorted; }
                        else if (sorted % 2 == 0)
                            Console.Write(Colors.Text + pos + Colors.Teams(j / 2) + "|" + Colors.Text + driverName);
                        else
                            Console.Write(Colors.Custom(200, 200, 200) + pos + Colors.Teams(j / 2) + "|" + Colors.Custom(200, 200, 200) + driverName);
                        Console.SetCursorPosition(23 + (3 - sortedPoints[sorted].Points.ToString().Length), Console.CursorTop);
                        Console.WriteLine(sortedPoints[sorted].Points + "Pts");
                        break;
                    }
                }
            }
            for (int team = 0; team < Data.TeamList().Count; team++)
            {
                string pos = team != 9 ? $" {team + 1}" : (team + 1).ToString();
                Console.SetCursorPosition(35, 6 + team);
                if (team % 2 == 0)
                    Console.Write(Colors.Text + pos + Colors.Teams(sortedConstructors[team].Item1) + "|" + Data.TeamList()[sortedConstructors[team].Item1] + Colors.Text);
                else
                    Console.Write(Colors.Custom(200, 200, 200) + pos + Colors.Teams(sortedConstructors[team].Item1) + "|" + Data.TeamList()[sortedConstructors[team].Item1] + Colors.Custom(200, 200, 200));
                Console.SetCursorPosition(51 + (4 - sortedConstructors[team].Item2.ToString().Length), Console.CursorTop);
                Console.WriteLine(sortedConstructors[team].Item2 + "Pts");
            }
            while (true)
            {
                Console.SetCursorPosition(0, 6);
                for (int sorted = 0; sorted < 20; sorted++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (sortedPoints[sorted].Number == Data.DriverData()[j].Item4)
                        {
                            string pos = sorted < 9 ? $" {sorted + 1}" : (sorted + 1).ToString();
                            string? driverName = userKey == j ? data.UserData()[0].Item3 : Data.DriverData()[j].Item2;
                            if (sorted == selectedDriver)
                            { Console.Write(Colors.Red + pos + Colors.Teams(j / 2) + "|" + Colors.Red + driverName); driverId = j; }
                            else if (sorted % 2 == 0)
                                Console.Write(Colors.Text + pos + Colors.Teams(j / 2) + "|" + Colors.Text + driverName);
                            else
                                Console.Write(Colors.Custom(200, 200, 200) + pos + Colors.Teams(j / 2) + "|" + Colors.Custom(200, 200, 200) + driverName);
                            Console.SetCursorPosition(23 + (3 - sortedPoints[sorted].Points.ToString().Length), Console.CursorTop);
                            Console.WriteLine(sortedPoints[sorted].Points + "Pts");
                            if (sorted == selectedDriver)
                            {
                                Console.SetCursorPosition(35, 17);
                                Console.Write(Colors.Teams(j / 2) + driverName + "'s " + Colors.Text + "Stats     ");
                                Console.SetCursorPosition(35, Console.CursorTop + 1);
                                Console.Write(" Wins             " + sortedPoints[sorted].Positions.P1 + Colors.Custom(200, 200, 200) + "   ");
                                Console.SetCursorPosition(35, Console.CursorTop + 1);
                                Console.Write(" Podiums          " + (sortedPoints[sorted].Positions.P1 + sortedPoints[sorted].Positions.P2 + sortedPoints[sorted].Positions.P3) + Colors.Text + "   ");
                                Console.SetCursorPosition(35, Console.CursorTop + 1);
                                Console.Write(" Fastest Laps     " + (sortedPoints[sorted].FastestLaps.Length - 1) + Colors.Custom(200, 200, 200) + "   ");
                                Console.SetCursorPosition(35, Console.CursorTop + 1);
                                Console.Write(" DNFs             " + (sortedPoints[sorted].DNFs.Length - 1) + Colors.Text + "   ");
                                Console.SetCursorPosition(35, Console.CursorTop + 1);
                                Console.Write(" Average Finish   " + Math.Round(PosToArray(sortedPoints[sorted].Positions).Average(), 2, MidpointRounding.AwayFromZero) + "     ");
                                Console.SetCursorPosition(0, 7 + sorted);
                            }
                            break;
                        }
                    }
                }
                DriverPerformanceGraph(driverId, 63, 5);
                key = Console.ReadKey(true);
                if (key.Key is ConsoleKey.DownArrow or ConsoleKey.S)
                    selectedDriver = Math.Min(19, selectedDriver + 1);
                else if (key.Key is ConsoleKey.UpArrow or ConsoleKey.W)
                    selectedDriver = Math.Max(0, selectedDriver - 1);
                else if (key.Key is ConsoleKey.Escape or ConsoleKey.LeftArrow or ConsoleKey.RightArrow or ConsoleKey.Enter)
                    break;
                Util.ClearKey();
                ClearGraph(68, 5);
            }
            return key;
        }
        private static ConsoleKeyInfo Dashboard(int userKey, List<CareerSave<int, int, Position, short[], short[]>> sortedPoints, List<Tuple<int, int, Position>> sortedConstructors, Data data)
        {
            ConsoleKeyInfo key;
            Console.WriteLine(Colors.Teams(userKey / 2) + $"\rDashboard\n");
            for (int sorted = 0; sorted < 20; sorted++)
            {
                if (sortedPoints[sorted].Number == Data.DriverData()[userKey].Item4)
                {
                    string pos = sorted < 9 ? $" {sorted + 1}" : (sorted + 1).ToString();
                    Console.Write(Colors.Text + pos + Colors.Teams(userKey / 2) + "|" + Colors.Text + data.UserData()[0].Item3);
                    Console.SetCursorPosition(22, Console.CursorTop);
                    Console.Write(sortedPoints[sorted].Points + "Pts");
                    Console.SetCursorPosition(3, Console.CursorTop + 1);
                    Console.Write("Wins               " + sortedPoints[sorted].Positions.P1 + Colors.Custom(200, 200, 200) + "   ");
                    Console.SetCursorPosition(3, Console.CursorTop + 1);
                    Console.Write("Podiums            " + (sortedPoints[sorted].Positions.P1 + sortedPoints[sorted].Positions.P2 + sortedPoints[sorted].Positions.P3) + Colors.Text + "   ");
                    Console.SetCursorPosition(3, Console.CursorTop + 1);
                    Console.Write("Fastest Laps       " + (sortedPoints[sorted].FastestLaps.Length - 1) + Colors.Custom(200, 200, 200) + "   ");
                    Console.SetCursorPosition(3, Console.CursorTop + 1);
                    Console.Write("DNFs               " + (sortedPoints[sorted].DNFs.Length - 1) + Colors.Text + "   ");
                    Console.SetCursorPosition(3, Console.CursorTop + 1);
                    Console.Write("Average Finish     " + Math.Round(PosToArray(sortedPoints[sorted].Positions).Average(), 2, MidpointRounding.AwayFromZero) + "     ");
                    break;
                }
            }
            for (int team = 0; team < Data.TeamList().Count; team++)
            {
                if (sortedConstructors[team].Item1 == userKey / 2)
                {
                    string pos = team != 9 ? $" {team + 1}" : (team + 1).ToString();
                    Console.SetCursorPosition(35, 3);
                    Console.Write(Colors.Text + pos + Colors.Teams(sortedConstructors[team].Item1) + "|" + Data.TeamList()[sortedConstructors[team].Item1] + Colors.Text);
                    Console.SetCursorPosition(57, Console.CursorTop);
                    Console.WriteLine(sortedConstructors[team].Item2 + "Pts");
                    break;
                }
            }
            for (int sorted = 0; sorted < 20; sorted++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (sortedPoints[sorted].Number == Data.DriverData()[j].Item4 && (j / 2) == (userKey / 2) && j != userKey)
                    {
                        string pos = sorted < 9 ? $" {sorted + 1}" : (sorted + 1).ToString();
                        Console.SetCursorPosition(35, 5);
                        Console.Write(Colors.Text + pos + Colors.Teams(userKey / 2) + "|" + Colors.Text + Data.DriverData()[j].Item2);
                        Console.SetCursorPosition(57, Console.CursorTop);
                        Console.Write(sortedPoints[sorted].Points + "Pts");
                        Console.SetCursorPosition(38, Console.CursorTop + 1);
                        Console.Write("Wins               " + sortedPoints[sorted].Positions.P1 + Colors.Custom(200, 200, 200) + "   ");
                        Console.SetCursorPosition(38, Console.CursorTop + 1);
                        Console.Write("Podiums            " + (sortedPoints[sorted].Positions.P1 + sortedPoints[sorted].Positions.P2 + sortedPoints[sorted].Positions.P3) + Colors.Text + "   ");
                        Console.SetCursorPosition(38, Console.CursorTop + 1);
                        Console.Write("Fastest Laps       " + (sortedPoints[sorted].FastestLaps.Length - 1) + Colors.Custom(200, 200, 200) + "   ");
                        Console.SetCursorPosition(38, Console.CursorTop + 1);
                        Console.Write("DNFs               " + (sortedPoints[sorted].DNFs.Length - 1) + Colors.Text + "   ");
                        Console.SetCursorPosition(38, Console.CursorTop + 1);
                        Console.Write("Average Finish     " + Math.Round(PosToArray(sortedPoints[sorted].Positions).Average(), 2, MidpointRounding.AwayFromZero) + "     ");
                        break;
                    }
                }
            }
            GPProgressBar(CareerManager.CareerGP, 7, 13, userKey);
            Console.SetCursorPosition(8, 16);
            if (CareerManager.CareerGP < Data.CircuitData().Count)
            {
                Console.Write($"Next {Colors.Teams(userKey / 2)}>{Colors.Text} {Data.CircuitData()[CareerManager.CareerGP].Item5} GP");
                Console.SetCursorPosition(45, Console.CursorTop);
                Console.WriteLine($"{Colors.Rain}Rain > {Data.CircuitData()[CareerManager.CareerGP].Item6}%");
            }
            if (CheckIfTheresChampion != null)
            {
                Console.SetCursorPosition(2, Console.CursorTop + 1);
                for (int i = 0; i < Data.DriverData().Count; i++)
                {
                    if (Data.DriverData()[i].Item4 == CheckIfTheresChampion)
                    {
                        if (i == userKey)
                            Console.WriteLine($"{Colors.Teams(i / 2) + '|' + Colors.Text + data.UserData()[0].Item3 + Colors.Teams(i / 2) + ' ' + CareerManager.UserNumber + Colors.Text}, You are The World Champion! Congratulations!");
                        else 
                            Console.WriteLine($"{Colors.Teams(i / 2) + '|' + Colors.Text + Data.DriverData()[i].Item2 + Colors.Teams(i / 2) + ' ' + Data.DriverData()[i].Item4 + Colors.Text} is The World Champion");
                    }
                }
            }
            if (CheckIfTheresChampionConstructor != null)
            {
                Console.SetCursorPosition(3, Console.CursorTop + 1);
                for (int i = 0; i < Data.TeamList().Count; i++)
                {
                    if (i == CheckIfTheresChampionConstructor)
                    {
                        if (i == userKey / 2)
                            Console.WriteLine($"{Colors.Text}We, {Colors.Teams(i) + Data.TeamList()[i].TrimEnd() + Colors.Text}, are The World Champions!");
                        else
                            Console.WriteLine($"{Colors.Teams(i) + Data.TeamList()[i].TrimEnd() + Colors.Text} is The World Champion");
                    }
                }
            }
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.LeftArrow && key.Key != ConsoleKey.RightArrow && key.Key != ConsoleKey.Escape && key.Key != ConsoleKey.Enter);
            return key;
        }
        private static ConsoleKeyInfo Settings(int userKey)
        {
            ConsoleKeyInfo key;
            Console.WriteLine(Colors.Teams(userKey / 2) + $"\rSettings\n");
            do
            {
                Console.Write(Colors.Text + "\rDifficulty ");
                Display.DifficultyBar(Colors.Teams(userKey / 2));
                Console.Write(Colors.Dark + " [A D]");
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.A)
                { Data.Difficulty = Math.Max(Data.Difficulty - 1, 1); Data.SaveDifficulty(); }
                else if (key.Key == ConsoleKey.D)
                { Data.Difficulty = Math.Min(Data.Difficulty + 1, 5); Data.SaveDifficulty(); }
            } while (key.Key != ConsoleKey.LeftArrow && key.Key != ConsoleKey.RightArrow && key.Key != ConsoleKey.Escape && key.Key != ConsoleKey.Enter);
            return key;
        }
        public static void GPProgressBar(int grandPrix, int cursorLeft, int cursorTop, int userKey)
        {
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.Write(Colors.Text + "╭───────────────────────────────────────────────╮");
            Console.SetCursorPosition(cursorLeft, Console.CursorTop + 1);
            Console.Write("│ ");
            for (int i = 0; i < 23; i++)
            {
                if (i == grandPrix)
                    Console.Write(Colors.Teams(userKey / 2)+ "● " + Colors.Text);
                else if (i < CareerManager.CareerGP)
                    Console.Write("● ");
                else
                    Console.Write("⃝ ");
            }
            Console.Write("│");
            Console.SetCursorPosition(cursorLeft, Console.CursorTop + 1);
            Console.Write("╰───────────────────────────────────────────────╯");
        }
        public static int[] PosToArray(Position position)
        {
            var posList = new List<int>();
            for (int i = 0; i < position.P1; i++)
                posList.Add(1);
            for (int i = 0; i < position.P2; i++)
                posList.Add(2);
            for (int i = 0; i < position.P3; i++)
                posList.Add(3);
            for (int i = 0; i < position.P4; i++)
                posList.Add(4);
            for (int i = 0; i < position.P5; i++)
                posList.Add(5);
            for (int i = 0; i < position.P6; i++)
                posList.Add(6);
            for (int i = 0; i < position.P7; i++)
                posList.Add(7);
            for (int i = 0; i < position.P8; i++)
                posList.Add(8);
            for (int i = 0; i < position.P9; i++)
                posList.Add(9);
            for (int i = 0; i < position.P10; i++)
                posList.Add(10);
            for (int i = 0; i < position.P11; i++)
                posList.Add(11);
            for (int i = 0; i < position.P12; i++)
                posList.Add(12);
            for (int i = 0; i < position.P13; i++)
                posList.Add(13);
            for (int i = 0; i < position.P14; i++)
                posList.Add(14);
            for (int i = 0; i < position.P15; i++)
                posList.Add(15);
            for (int i = 0; i < position.P16; i++)
                posList.Add(16);
            for (int i = 0; i < position.P17; i++)
                posList.Add(17);
            for (int i = 0; i < position.P18; i++)
                posList.Add(18);
            for (int i = 0; i < position.P19; i++)
                posList.Add(19);
            for (int i = 0; i < position.P20; i++)
                posList.Add(20);
            var posArray = posList.ToArray();
            return posArray;
        }
        private static string MenuTabs(int userKey, int menu) => menu switch
        {
            0 => "" + Colors.Gray +
           $" <     > │ {Colors.Teams(userKey / 2)}Dashboard{Colors.Gray} │ {Colors.White}Standings{Colors.Gray} │ {Colors.White}Calendar{Colors.Gray} │ {Colors.White}Settings{Colors.Gray} │" +
           $"\n {Colors.Red}F1 {Colors.White}2023{Colors.Gray} │           ╰───────────┴──────────┴──────────╯" +
            "\n─────────╯",
            1 => "" + Colors.Gray +
           $" <     > │ {Colors.White}Dashboard{Colors.Gray} │ {Colors.Teams(userKey / 2)}Standings{Colors.Gray} │ {Colors.White}Calendar{Colors.Gray} │ {Colors.White}Settings{Colors.Gray} │" +
           $"\n {Colors.Red}F1 {Colors.White}2023{Colors.Gray} ├───────────╯           ╰──────────┴──────────╯" +
            "\n─────────╯",
            2 => "" + Colors.Gray +
           $" <     > │ {Colors.White}Dashboard{Colors.Gray} │ {Colors.White}Standings{Colors.Gray} │ {Colors.Teams(userKey / 2)}Calendar{Colors.Gray} │ {Colors.White}Settings{Colors.Gray} │" +
           $"\n {Colors.Red}F1 {Colors.White}2023{Colors.Gray} ├───────────┴───────────╯          ╰──────────╯" +
            "\n─────────╯",
            3 => "" + Colors.Gray +
           $" <     > │ {Colors.White}Dashboard{Colors.Gray} │ {Colors.White}Standings{Colors.Gray} │ {Colors.White}Calendar{Colors.Gray} │ {Colors.Teams(userKey / 2)}Settings{Colors.Gray} │" +
           $"\n {Colors.Red}F1 {Colors.White}2023{Colors.Gray} ├───────────┴───────────┴──────────╯          ╵" +
            "\n─────────╯",
            _ => ""
        };
        private static List<CareerSave<int, int, Position, short[], short[]>> SortDrivers => CareerManager.CareerSave
                .OrderByDescending(x => x.Points)
                .ThenByDescending(x => x.Positions.P1)
                .ThenByDescending(x => x.Positions.P2)
                .ThenByDescending(x => x.Positions.P3)
                .ThenByDescending(x => x.Positions.P4)
                .ThenByDescending(x => x.Positions.P5)
                .ThenByDescending(x => x.Positions.P6)
                .ThenByDescending(x => x.Positions.P7)
                .ThenByDescending(x => x.Positions.P8)
                .ThenByDescending(x => x.Positions.P9)
                .ThenByDescending(x => x.Positions.P10)
                .ThenByDescending(x => x.Positions.P11)
                .ThenByDescending(x => x.Positions.P12)
                .ThenByDescending(x => x.Positions.P13)
                .ThenByDescending(x => x.Positions.P14)
                .ThenByDescending(x => x.Positions.P15)
                .ThenByDescending(x => x.Positions.P16)
                .ThenByDescending(x => x.Positions.P17)
                .ThenByDescending(x => x.Positions.P18)
                .ThenByDescending(x => x.Positions.P19)
                .ThenByDescending(x => x.Positions.P20)
                .ToList();
        private static List<Tuple<int, int, Position>> SortConstructors()
        {
            var sortConstructors = new List<Tuple<int, int, Position>>();
            for (int team = 0; team < 20; team += 2) 
            {
                sortConstructors.Add(new Tuple<int, int, Position>(team / 2, CareerManager.CareerSave[team].Points + CareerManager.CareerSave[team + 1].Points, 
                    new Position(
                    (short)(CareerManager.CareerSave[team].Positions.P1 + CareerManager.CareerSave[team + 1].Positions.P1),
                    (short)(CareerManager.CareerSave[team].Positions.P2 + CareerManager.CareerSave[team + 1].Positions.P2),
                    (short)(CareerManager.CareerSave[team].Positions.P3 + CareerManager.CareerSave[team + 1].Positions.P3),
                    (short)(CareerManager.CareerSave[team].Positions.P4 + CareerManager.CareerSave[team + 1].Positions.P4),
                    (short)(CareerManager.CareerSave[team].Positions.P5 + CareerManager.CareerSave[team + 1].Positions.P5),
                    (short)(CareerManager.CareerSave[team].Positions.P6 + CareerManager.CareerSave[team + 1].Positions.P6),
                    (short)(CareerManager.CareerSave[team].Positions.P7 + CareerManager.CareerSave[team + 1].Positions.P7),
                    (short)(CareerManager.CareerSave[team].Positions.P8 + CareerManager.CareerSave[team + 1].Positions.P8),
                    (short)(CareerManager.CareerSave[team].Positions.P9 + CareerManager.CareerSave[team + 1].Positions.P9),
                    (short)(CareerManager.CareerSave[team].Positions.P10 + CareerManager.CareerSave[team + 1].Positions.P10),
                    (short)(CareerManager.CareerSave[team].Positions.P11 + CareerManager.CareerSave[team + 1].Positions.P11),
                    (short)(CareerManager.CareerSave[team].Positions.P12 + CareerManager.CareerSave[team + 1].Positions.P12),
                    (short)(CareerManager.CareerSave[team].Positions.P13 + CareerManager.CareerSave[team + 1].Positions.P13),
                    (short)(CareerManager.CareerSave[team].Positions.P14 + CareerManager.CareerSave[team + 1].Positions.P14),
                    (short)(CareerManager.CareerSave[team].Positions.P15 + CareerManager.CareerSave[team + 1].Positions.P15),
                    (short)(CareerManager.CareerSave[team].Positions.P16 + CareerManager.CareerSave[team + 1].Positions.P16),
                    (short)(CareerManager.CareerSave[team].Positions.P17 + CareerManager.CareerSave[team + 1].Positions.P17),
                    (short)(CareerManager.CareerSave[team].Positions.P18 + CareerManager.CareerSave[team + 1].Positions.P18),
                    (short)(CareerManager.CareerSave[team].Positions.P19 + CareerManager.CareerSave[team + 1].Positions.P19),
                    (short)(CareerManager.CareerSave[team].Positions.P20 + CareerManager.CareerSave[team + 1].Positions.P20))));
            }
            sortConstructors = sortConstructors.OrderByDescending(x => x.Item2)
                .ThenByDescending(x => x.Item3.P1)
                .ThenByDescending(x => x.Item3.P2)
                .ThenByDescending(x => x.Item3.P3)
                .ThenByDescending(x => x.Item3.P4)
                .ThenByDescending(x => x.Item3.P5)
                .ThenByDescending(x => x.Item3.P6)
                .ThenByDescending(x => x.Item3.P7)
                .ThenByDescending(x => x.Item3.P8)
                .ThenByDescending(x => x.Item3.P9)
                .ThenByDescending(x => x.Item3.P10)
                .ThenByDescending(x => x.Item3.P11)
                .ThenByDescending(x => x.Item3.P12)
                .ThenByDescending(x => x.Item3.P13)
                .ThenByDescending(x => x.Item3.P14)
                .ThenByDescending(x => x.Item3.P15)
                .ThenByDescending(x => x.Item3.P16)
                .ThenByDescending(x => x.Item3.P17)
                .ThenByDescending(x => x.Item3.P18)
                .ThenByDescending(x => x.Item3.P19)
                .ThenByDescending(x => x.Item3.P20)
                .ToList();
            return sortConstructors;
        }
        public static void Updater()
        {
            for(int i = 0; i < Data.DriverData().Count; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    if (Data.DriverData()[i].Item4 == Lineup[j].Key)
                    {
                        CareerManager.CareerSave[i].Points += PointDistribution(j);
                        CareerManager.CareerSave[i].Points += Data.DriverData()[i].Item4 == FastestLapPoint && j < 10 ? 1 : 0;
                        if (Data.DriverData()[i].Item4 == FastestLapPoint)
                        {
                            var flArray = CareerManager.CareerSave[i].FastestLaps;
                            Array.Resize(ref flArray, flArray.Length + 1);
                            flArray[^1] = (short)(CareerManager.CareerGP + 1);
                            CareerManager.CareerSave[i].FastestLaps = flArray;
                        }
                        if (DNFList.Contains(Data.DriverData()[i].Item4))
                        {
                            var dnfArray = CareerManager.CareerSave[i].DNFs;
                            Array.Resize(ref dnfArray, dnfArray.Length + 1);
                            dnfArray[^1] = (short)(CareerManager.CareerGP + 1);
                            CareerManager.CareerSave[i].DNFs = dnfArray;
                        }
                        PlaceCount(i, j);
                    }
                }
            }
        }
        public static int PointDistribution(int place) => place switch
        {
            0 => 25,
            1 => 18,
            2 => 15,
            3 => 12,
            4 => 10,
            5 => 8,
            6 => 6,
            7 => 4,
            8 => 2,
            9 => 1,
            _ => 0,
        };
        public static void PlaceCount(int driver ,int place)
        {
            switch (place)
            {
                case 0: CareerManager.CareerSave[driver].Positions.P1 += 1; break;
                case 1: CareerManager.CareerSave[driver].Positions.P2 += 1; break;
                case 2: CareerManager.CareerSave[driver].Positions.P3 += 1; break;
                case 3: CareerManager.CareerSave[driver].Positions.P4 += 1; break;
                case 4: CareerManager.CareerSave[driver].Positions.P5 += 1; break;
                case 5: CareerManager.CareerSave[driver].Positions.P6 += 1; break;
                case 6: CareerManager.CareerSave[driver].Positions.P7 += 1; break;
                case 7: CareerManager.CareerSave[driver].Positions.P8 += 1; break;
                case 8: CareerManager.CareerSave[driver].Positions.P9 += 1; break;
                case 9: CareerManager.CareerSave[driver].Positions.P10 += 1; break;
                case 10: CareerManager.CareerSave[driver].Positions.P11 += 1; break;
                case 11: CareerManager.CareerSave[driver].Positions.P12 += 1; break;
                case 12: CareerManager.CareerSave[driver].Positions.P13 += 1; break;
                case 13: CareerManager.CareerSave[driver].Positions.P14 += 1; break;
                case 14: CareerManager.CareerSave[driver].Positions.P15 += 1; break;
                case 15: CareerManager.CareerSave[driver].Positions.P16 += 1; break;
                case 16: CareerManager.CareerSave[driver].Positions.P17 += 1; break;
                case 17: CareerManager.CareerSave[driver].Positions.P18 += 1; break;
                case 18: CareerManager.CareerSave[driver].Positions.P19 += 1; break;
                case 19: CareerManager.CareerSave[driver].Positions.P20 += 1; break;
            }
        }
        public static void GrandPrixStatsUpdater()
        {
            List<List<int>?>? grandPrixStats = CareerManager.GrandPrixStats;
            int pos;
            for (int driver = 0; driver < 20; driver++)
            {
                for (int grid = 0; grid < 20; grid++)
                {
                    if (Data.DriverData()[driver].Item4 == Lineup[grid].Key)
                    {
                        if (DNFList.Contains(Data.DriverData()[driver].Item4) && Data.DriverData()[driver].Item4 == FastestLapPoint)
                            pos = (grid + 100) * -1;
                        else if (DNFList.Contains(Data.DriverData()[driver].Item4))
                            pos = grid * -1;
                        else if (Data.DriverData()[driver].Item4 == FastestLapPoint)
                            pos = grid + 100;
                        else
                            pos = grid;
                        grandPrixStats[driver].Add(pos);
                    }
                }
            }
            Util.ClearKey();
            CareerManager.GrandPrixStats = grandPrixStats;
        }
        public static int? CheckIfTheresChampion =>
            SortDrivers[0].Points > SortDrivers[1].Points + 26 * (Data.CircuitData().Count - CareerManager.CareerGP) 
            ? SortDrivers[0].Number : null;
        public static int? CheckIfTheresChampionConstructor =>
            SortConstructors()[0].Item2 > SortConstructors()[1].Item2 + 51 * (Data.CircuitData().Count - CareerManager.CareerGP)
            ? SortConstructors()[0].Item1 : null;
        public static void ClearGraph(int left, int top)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write("                                                   ");
            }
        }
        public static void DriverPerformanceGraph(int driver, int left, int top)
        {
            int pos, posNext, offset;
            string dot, lineStart, lineEnd;
            string[] table = { " ᴾ¹┃", " ᴾ²┃", " ᴾ³┃", " ᴾ⁴┃", " ᴾ⁵┃", " ᴾ⁶┃", " ᴾ⁷┃", " ᴾ⁸┃", " ᴾ⁹┃", "ᴾ¹⁰┃", "ᴾ¹¹┃", "ᴾ¹²┃", "ᴾ¹³┃", "ᴾ¹⁴┃", "ᴾ¹⁵┃", "ᴾ¹⁶┃", "ᴾ¹⁷┃", "ᴾ¹⁸┃", "ᴾ¹⁹┃", "ᴾ²⁰┃", "   ┗━" };
            Console.Write(Colors.LessGray);
            for (int i = 0; i < table.Length; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write(table[i]);
            }
            Console.SetCursorPosition(left + 5, top + 20);
            for (int i = 0; i < 23; i++)
            {
                if (i < CareerManager.CareerGP)
                    Console.Write(Colors.Teams(driver / 2) + $"●{Colors.LessGray}━");
                else
                    Console.Write(Colors.LessGray + "⃝━");
            }
            for (int i = 0; i < CareerManager.CareerGP; i++)
            {
                if (CareerManager.GrandPrixStats[driver][i] < -99)
                {
                    dot = Colors.Magenta + '◊';
                    pos = CareerManager.GrandPrixStats[driver][i] * -1 - 100;
                }
                else if (CareerManager.GrandPrixStats[driver][i] < 0)
                {
                    dot = Colors.LessGray + '◦';
                    pos = CareerManager.GrandPrixStats[driver][i] * -1;
                }
                else if (CareerManager.GrandPrixStats[driver][i] > 19)
                {
                    dot = Colors.Magenta + '♦';
                    pos = CareerManager.GrandPrixStats[driver][i] - 100;
                }
                else
                {
                    dot = Colors.Teams(driver / 2) + '•';
                    pos = CareerManager.GrandPrixStats[driver][i];
                }
                Console.SetCursorPosition(left + 5 + i * 2, top + pos);
                Console.Write(dot);
                if (CareerManager.CareerGP > 1 && i < CareerManager.CareerGP - 1)
                {
                    if (CareerManager.GrandPrixStats[driver][i + 1] < -99)
                        posNext = CareerManager.GrandPrixStats[driver][i + 1] * -1 - 100;
                    else if (CareerManager.GrandPrixStats[driver][i + 1] < 0)
                        posNext = CareerManager.GrandPrixStats[driver][i + 1] * -1;
                    else if (CareerManager.GrandPrixStats[driver][i + 1] > 19)
                        posNext = CareerManager.GrandPrixStats[driver][i + 1] - 100;
                    else
                        posNext = CareerManager.GrandPrixStats[driver][i + 1];

                    if (pos == posNext)
                    { lineStart = lineEnd = Colors.LessGray + '─'; offset = 0; }
                    else if (pos < posNext)
                    {
                        lineStart = Colors.LessGray + '╮';
                        lineEnd = Colors.LessGray + '╰';
                        offset = 1;
                    }
                    else
                    {
                        lineStart = Colors.LessGray + '╯';
                        lineEnd = Colors.LessGray + '╭';
                        offset = -1;
                    }
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                    Console.Write(lineStart);
                    for (int j = 0; 
                        (pos > posNext && j < (pos - posNext)) || 
                        (pos < posNext && j < (posNext - pos)); j++) {
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop + offset);
                        Console.Write(Colors.LessGray + '│');
                    }
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(lineEnd);
                }
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
            Console.OutputEncoding = Encoding.UTF8;
            CustomColor.Color();
            Console.Write("\x1b[48;2;0;0;0m" + Colors.Text);
            Console.Clear();
            Data.LoadDifficulty();
            Data data = new();
            data.UserData();
            Util.ClearPart(0);
            Intro.IntroLogo();
            while (true)
            {
                Display.Logo();
                Util.ClearKey();
                short mode = Menu.MainMenu();
                switch (mode)
                {
                    case 0:
                        RaceSetup.NormalRace(true);
                        break;
                    case 1:
                        RaceSetup.NormalRace(false);
                        break;
                    case 2:
                        if (CareerMode.OverwriteSaveWarrning())
                        {
                            CareerMode.NewCareer();
                            CareerMode.Career();
                        }
                        break;
                    case 3:
                        CareerMode.Career();
                        break;
                    default:
                        break;
                }
                Util.ClearPart(0);
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
        public static List<List<int>?>? GrandPrixStats { get; set; }
        public static void InitializeGrandPrixStats()
        {
            List<List<int>?>? Initialize = new();
            for (int i = 0; i < 20; i++)
                Initialize.Add(new List<int>());
            GrandPrixStats = Initialize;
        }
        public static void LoadGrandPrixStats() 
        {
            try
            {
                InitializeGrandPrixStats();
                string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                using var careerGPReader = new StreamReader(@$"{path}\UserData\CareerGPs.txt");
                List<List<int>?>? driverPositions = new();
                for (int i = 0; i < 20; i++)
                {
                    driverPositions.Add(new List<int>());
                    var posStrings = careerGPReader.ReadLine().Split(',');
                    for (int j = 0; j < posStrings.Length; j++)
                        driverPositions[i].Add(Convert.ToInt32(posStrings[j]));
                }
                GrandPrixStats = driverPositions;
            }
            catch
            {
                Console.WriteLine("Can't load career GP data\nCheck save directory or copy original [CareerGPs.txt] from Github");
                Util.KeyAdvance(ConsoleKey.Enter);
            }
        }
        public static void ClearGrandPrixStats()
        {
            try
            {
                string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                using var careerGPWriter = new StreamWriter(@$"{path}\UserData\CareerGPs.txt");
                StringBuilder sb = new();
                foreach (var dirver in GrandPrixStats)
                {
                    sb.Append('\n');
                }
                careerGPWriter.WriteLine(sb);
            }
            catch
            {
                Console.WriteLine("Can't save career GP data\nCheck save directory or copy original [CareerGPs.txt] from Github");
                Util.KeyAdvance(ConsoleKey.Enter);
            }
        }
        public static void SaveGrandPrixStats()
        {
            try
            {
                string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                using var careerGPWriter = new StreamWriter(@$"{path}\UserData\CareerGPs.txt");
                StringBuilder sb = new();
                foreach (var dirver in GrandPrixStats)
                {
                    for (int i = 0; i < dirver.Count; i++)
                    {
                        sb.Append(dirver[i]);
                        if (i < dirver.Count - 1)
                        {
                            sb.Append(',');
                        }
                    }
                    sb.Append('\n');
                }
                careerGPWriter.WriteLine(sb);
            }
            catch
            {
                Console.WriteLine("Can't save career GP data\nCheck save directory or copy original [CareerGPs.txt] from Github");
                Util.KeyAdvance(ConsoleKey.Enter);
            }
        }
        public static int CareerGP { get; set; }
        public static int UserKey { get; set; }
        public static int UserNumber { get; set; }
        public static List<CareerSave<int, int, Position, short[], short[]>>? CareerSave { get; set; }
        public static void InitializeSave()
        {
            List<CareerSave<int, int, Position, short[], short[]>> Initialize = new();
            for (int i = 0; i < 20; i++)
                Initialize.Add(new CareerSave<int, int, Position, short[], short[]>(0, 0, new Position(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0), new short[] { 0 }, new short[] { 0 }));
            CareerSave = Initialize;
        }
        public static void LoadCareer()
        {
            InitializeSave();
            try
            {
                string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                using var careerReader = new StreamReader(@$"{path}\UserData\CareerMode.txt");
                CareerGP = Convert.ToInt32(careerReader.ReadLine());
                UserKey = Convert.ToInt32(careerReader.ReadLine());
                UserNumber = Convert.ToInt32(careerReader.ReadLine());
                short[] wins = new short[20];
                for (int i = 0; i < Data.DriverData().Count; i++)
                {
                    var points = Convert.ToInt32(careerReader.ReadLine());

                    var winStrings = careerReader.ReadLine().Split(',');
                    for (int j = 0; j < 20; j++)
                        wins[j] = Convert.ToInt16(winStrings[j]);

                    var fastestLapStrings = careerReader.ReadLine().Split(',').ToList();
                    short[] fastestLaps = new short[fastestLapStrings.Count];
                    for (int j = 0; j < fastestLapStrings.Count; j++)
                        fastestLaps[j] = Convert.ToInt16(fastestLapStrings[j]);

                    var dnfStrings = careerReader.ReadLine().Split(',').ToList();
                    short[] dnfs = new short[dnfStrings.Count];
                    for (int j = 0; j < dnfStrings.Count; j++)
                        dnfs[j] = Convert.ToInt16(dnfStrings[j]);

                    CareerSave[i] = new CareerSave<int, int, Position, short[], short[]>(Data.DriverData()[i].Item4, points, 
                        new Position(wins[0], wins[1], wins[2], wins[3], wins[4], wins[5], wins[6], wins[7], wins[8], wins[9], wins[10], wins[11], wins[12], wins[13], wins[14], wins[15], wins[16], wins[17], wins[18], wins[19]),
                        fastestLaps, dnfs);
                }
            }
            catch
            {
                Console.WriteLine("Can't load career save data\nCheck save directory or copy original [CareerMode.txt] from Github");
                Util.KeyAdvance(ConsoleKey.Enter);
            }
        }
        public static void SaveCareer()
        {
            try
            {
                /*var userDataPath = Path.Combine(Environment.CurrentDirectory, "UserData");
                var careerModePath = Path.Combine(userDataPath, "CareerMode.txt");*/
                string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                using var careerWriter = new StreamWriter(@$"{path}\UserData\CareerMode.txt");
                careerWriter.WriteLine(CareerGP);
                careerWriter.WriteLine(UserKey);
                careerWriter.WriteLine(UserNumber);
                foreach (var careerSave in CareerSave)
                {
                    var posArray = new object[] { careerSave.Positions.P1, careerSave.Positions.P2, careerSave.Positions.P3, careerSave.Positions.P4, careerSave.Positions.P5, careerSave.Positions.P6, careerSave.Positions.P7, careerSave.Positions.P8, careerSave.Positions.P9, careerSave.Positions.P10, careerSave.Positions.P11, careerSave.Positions.P12, careerSave.Positions.P13, careerSave.Positions.P14, careerSave.Positions.P15, careerSave.Positions.P16, careerSave.Positions.P17, careerSave.Positions.P18, careerSave.Positions.P19, careerSave.Positions.P20 };
                    var posString = string.Join(",", posArray);
                    var flString = string.Join(",", careerSave.FastestLaps);
                    var dnfString = string.Join(",", careerSave.DNFs);
                    careerWriter.WriteLine($"{careerSave.Points}\n{posString}\n{flString}\n{dnfString}");
                }
            }
            catch
            {
                Console.WriteLine("Can't save career save data\nCheck save directory or copy original [CareerMode.txt] from Github");
                Util.KeyAdvance(ConsoleKey.Enter);
            }
        }
    }
}