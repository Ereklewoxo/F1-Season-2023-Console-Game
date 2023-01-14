using NAudio.Vorbis;
using WaveOutEvent = NAudio.Wave.WaveOutEvent;

namespace F1_Season_2023_Ew
{

    public class DisplayMenu
    {
        public static void MenuDefault()
        {
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("\r      /Quick Race        ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     /Career Mode                                             \n    /Settings            \n   /Exit Game                                 ");
        }
        public static void MenuReset()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r      /Quick Race                                       \n     /Career Mode                                        \n    /Settings                  \n   /Exit Game                 ");
        }
        public static void QuickRaceSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("      /Quick Race");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     /Career Mode\n    /Settings\n   /Exit Game");
        }
        public static void CareerModeSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      /Quick Race");
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("     /Career Mode");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    /Settings\n   /Exit Game");
        }
        public static void SettingsSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      /Quick Race\n     /Career Mode");
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("    /Settings");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   /Exit Game");
        }
        public static void ExitGameSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      /Quick Race\n     /Career Mode\n    /Settings");
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("   /Exit Game");
        }
        public static void QuickRaceDefault()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.Write(Colors.Teams()[2]);
            Console.Write("      /Quick Race");
            Menu.MenuAnim1();
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("/Start Random Race");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("     /Career Mode      ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("/Choose a Circuit");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("    /Settings\n   /Exit Game");
        }
        public static void StartRandomSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.Write(Colors.Teams()[2]);
            Console.Write("      /Quick Race_______");
            Console.WriteLine("/Start Random Race");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("     /Career Mode      ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("/Choose a Circuit");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("    /Settings\n   /Exit Game");
        }
        public static void ChooseCircuitSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.Write(Colors.Teams()[2]);
            Console.Write("      /Quick Race_______");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("/Start Random Race");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("     /Career Mode      ");
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("/Choose a Circuit");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("    /Settings\n   /Exit Game");
        }
        public static void CareerModeDefault()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      /Quick Race");
            Console.Write(Colors.Teams()[2]);
            Console.Write("     /Career Mode");
            Menu.MenuAnim2();
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("/New Game");
            Console.Write("     /Career Mode___/  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("/Load Game");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("    /Settings\n   /Exit Game");
        }
        public static void NewGameSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("      /Quick Race    ");
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("___/New Game");
            Console.Write("     /Career Mode___/  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("/Load Game");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("    /Settings\n   /Exit Game");
        }
        public static void LoadGameSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("      /Quick Race    ");
            Console.Write(Colors.Teams()[2]);
            Console.Write("___");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("/New Game");
            Console.Write(Colors.Teams()[2]);
            Console.Write("     /Career Mode___/  ");
            Console.WriteLine("/Load Game");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("    /Settings\n   /Exit Game");
        }
        public static void SettingsDefault()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      /Quick Race\n     /Career Mode");
            Console.Write(Colors.Teams()[2]);
            Console.Write("    /Settings");
            Menu.MenuAnim3();
            Console.WriteLine("/Difficulty");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("     /Career Mode  ");
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("/");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("   /Exit Game");
        }
        public static void DifficultySelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("      /Quick Race   ");
            Console.Write(Colors.Teams()[2]);
            Console.Write("____/Difficulty");
            Display.DifficultyBar();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("     /Career Mode  ");
            Console.Write(Colors.Teams()[2]);
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   /Change User Data");
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("    /Settings");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("   /Exit Game");
        }
        public static void ChangeUserDataSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("      /Quick Race   ");
            Console.Write(Colors.Teams()[2]);
            Console.Write("____");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("/Difficulty               ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("     /Career Mode  ");
            Console.Write(Colors.Teams()[2]);
            Console.Write("/");
            Console.WriteLine("   /Change User Data");
            Console.WriteLine("    /Settings");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("   /Exit Game");
        }
        public static void ChangeingUserData()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("      /Quick Race   ");
            Console.Write(Colors.Teams()[2]);
            Console.Write("____");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("/Difficulty               ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("     /Career Mode  ");
            Console.Write(Colors.Teams()[2]);
            Console.Write("/");
            Console.WriteLine("   /Change User Data");
            Menu.MenuAnim4();
        }
    }
    public class Display
    {
        public static void Logo()
        {
            string r = "\x1b[38;2;255;10;10m";
            string w = "\x1b[38;2;255;255;255m";
            Console.WriteLine("" +
            @$"{r}     ______________  __{w}   ___   ____  ___  ____  " + '\n' +
            @$"{r}   /  ____________//  /{w}  |__ \ / __ \|__ \ \__ \ " + '\n' +
            @$"{r}  /  /  _________//  / {w}  / __// /_/ // __//__  / " + '\n' +
            @$"{r} /__/__/         /__/  {w} /____/\____//____/____/  " + '\n');
        }
        public static void DifficultyBar()
        {
            Menu difficulty = new();
            for (int i = 0; i < Menu.Difficulty; i++)
            {
                Console.Write(Colors.Teams()[2]);
                Console.Write("▐");
            }
            for (int i = 0; i < 5 - Menu.Difficulty; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("▐");
            }
        }
    }
    public class Data
    {
        public bool ChangeUserData = false;
        public static List<Tuple<string, string, string, int>> CircuitData()
        {
            var circuitData = new List<Tuple<string, string, string, int>>();
            circuitData.Add(new Tuple<string, string, string, int>("Bahrain", "Sakhir", "March", 5));
            circuitData.Add(new Tuple<string, string, string, int>("Saudi Arabia", "Jeddah", "March", 19));
            circuitData.Add(new Tuple<string, string, string, int>("Australia", "Melbourne", "April", 2));
            circuitData.Add(new Tuple<string, string, string, int>("Portugal", "Portimao", "April", 16));
            circuitData.Add(new Tuple<string, string, string, int>("Azerbaijan", "Baku", "April", 30));
            circuitData.Add(new Tuple<string, string, string, int>("Miami", "Miami", "May", 7));
            circuitData.Add(new Tuple<string, string, string, int>("Emilia Romagna", "Imola", "May", 21));
            circuitData.Add(new Tuple<string, string, string, int>("Monaco", "Monaco", "May", 28));
            circuitData.Add(new Tuple<string, string, string, int>("Spain", "Barcelona", "June",4));
            circuitData.Add(new Tuple<string, string, string, int>("Canada", "Montreal", "June", 18));
            circuitData.Add(new Tuple<string, string, string, int>("Austria", "Spielberg", "July", 2));
            circuitData.Add(new Tuple<string, string, string, int>("Great Britain", "Silverstone", "July", 9));
            circuitData.Add(new Tuple<string, string, string, int>("Hungary", "Budapest", "July", 23));
            circuitData.Add(new Tuple<string, string, string, int>("Belgium", "Spa", "July", 30));
            circuitData.Add(new Tuple<string, string, string, int>("Netherlands", "Zandvoort", "August", 27));
            circuitData.Add(new Tuple<string, string, string, int>("Italy", "Monza", "September", 3));
            circuitData.Add(new Tuple<string, string, string, int>("Singapore", "Singapore", "September", 17));
            circuitData.Add(new Tuple<string, string, string, int>("Japan", "Suzuka", "September", 24));
            circuitData.Add(new Tuple<string, string, string, int>("Qatar", "Lusail", "October", 8));
            circuitData.Add(new Tuple<string, string, string, int>("USA", "Austin", "October", 22));
            circuitData.Add(new Tuple<string, string, string, int>("Mexico", "Mexico City", "October", 29));
            circuitData.Add(new Tuple<string, string, string, int>("Brazil", "Sao Paulo", "November", 5));
            circuitData.Add(new Tuple<string, string, string, int>("Las Vegas", "Las Vegas", "November", 18));
            circuitData.Add(new Tuple<string, string, string, int>("Abu Dhabi", "Yas Marina", "November", 26));
            return circuitData;
        }
        public static void LoadDifficulty()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            StreamReader difficultyR = new($"{path}\\UserData\\Difficulty.txt");
            Menu.Difficulty = Convert.ToInt32(difficultyR.ReadLine());
            difficultyR.Close();
        }
        public static void SaveDifficulty()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            StreamWriter difficultyW = new($"{path}\\UserData\\Difficulty.txt");
            difficultyW.Write(Menu.Difficulty);
            difficultyW.Close();
        }
        public List<Tuple<string, string, string, string, string>> UserData()
        {
            var userData = new List<Tuple<string, string, string, string, string>>
            {
                new Tuple<string, string, string, string, string>("John", "Doe", "John Doe", "DOE", "Sealand")
            };
            string firstName;
            string lastName;
            string fullName;
            string shortName;
            string nationality;
            string? firstNameRead;
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            StreamReader saveFileR = new($"{path}\\UserData\\SaveFile.txt");
            firstNameRead = saveFileR.ReadLine();
            if (firstNameRead != null)
            {
                firstName = firstNameRead;
                lastName = saveFileR.ReadLine();
                fullName = saveFileR.ReadLine();
                shortName = saveFileR.ReadLine();
                nationality = saveFileR.ReadLine();
                userData.Add(new Tuple<string, string, string, string, string>(firstName, lastName, fullName, shortName, nationality));
            }
            saveFileR.Close();
            if (firstNameRead == null || ChangeUserData == true)
            {
                StreamWriter saveFileW = new($"{path}\\UserData\\SaveFile.txt");
                if (ChangeUserData)
                    Console.Write("\n              ");
                Console.WriteLine("     /What's your first name?");
                Console.Write(Colors.Teams()[2]);
                if (ChangeUserData)
                    Console.Write("              ");
                Console.Write($"    /");
                Console.ForegroundColor = ConsoleColor.White;
                firstName = Console.ReadLine();
                if (firstName.Length == 1)
                {
                    firstName = firstName.ToUpper();
                }
                else if (firstName.Length == 0)
                {
                    firstName = "John";
                }
                else
                {
                    firstName = firstName.Remove(1).ToUpper() + firstName.Remove(0, 1).ToLower();
                }
                saveFileW.WriteLine(firstName);
                Console.SetCursorPosition(0, Console.CursorTop - 2);
                if (ChangeUserData)
                    Console.Write("              ");
                Console.WriteLine("     /And your last name?    ");
                Console.Write(Colors.Teams()[2]);
                if (ChangeUserData)
                    Console.Write("              ");
                Console.Write($"    /{firstName} ");
                Console.ForegroundColor = ConsoleColor.White;
                lastName = Console.ReadLine();
                if (lastName.Length == 1)
                {
                    lastName = lastName.ToUpper();
                }
                else if (lastName.Length == 0)
                {
                    lastName = "Doe";
                }
                else
                {
                    lastName = lastName.Remove(1).ToUpper() + lastName.Remove(0, 1).ToLower();
                }
                saveFileW.WriteLine(lastName);
                fullName = firstName + " " + lastName;
                saveFileW.WriteLine(fullName);
                if (lastName.Length == 3)
                {
                    shortName = lastName;
                }
                else if (firstName.Length + lastName.Length < 3)
                {
                    shortName = firstName + lastName;
                }
                else if (firstName.Length + lastName.Length == 3)
                {
                    shortName = firstName + lastName;
                }
                else if (firstName.Length > 1 && lastName.Length == 1)
                {
                    shortName = firstName.Remove(2) + lastName;
                }
                else if (firstName.Length > 1 && lastName.Length < 3)
                {
                    shortName = firstName.Remove(1) + lastName;
                }
                else
                {
                    shortName = lastName.Remove(3);
                }
                shortName = shortName.ToUpper();
                saveFileW.WriteLine(shortName);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(Colors.Teams()[2]);
                if (ChangeUserData)
                    Console.Write("              ");
                Console.WriteLine($"    /{firstName} {lastName}");
                Console.ForegroundColor = ConsoleColor.White;
                if (ChangeUserData)
                    Console.Write("              ");
                Console.WriteLine("   /Where are you from?");
                Console.Write(Colors.Teams()[2]);
                if (ChangeUserData)
                    Console.Write("              ");
                Console.Write($"  /");
                Console.ForegroundColor = ConsoleColor.White;
                nationality = Console.ReadLine();
                if (nationality.Length == 1)
                {
                    nationality = nationality.ToUpper();
                }
                else if (nationality.Length == 0)
                {
                    nationality = "Sealand";
                }
                else
                {
                    nationality = nationality.Remove(1).ToUpper() + nationality.Remove(0, 1).ToLower();
                }
                saveFileW.WriteLine(nationality);
                Console.ForegroundColor = ConsoleColor.White;
                userData.Add(new Tuple<string, string, string, string, string>(firstName, lastName, fullName, shortName, nationality));
                saveFileW.Close();
                Console.SetCursorPosition(0, Console.CursorTop - 4);
            }
            return userData;
        }
        public static List<string> TeamList()
        {
            var teamList = new List<string> { "Mercedes", "Red Bull Racing", "Ferrari", "McLaren", "Alpine", "AlphaTauri", "Aston Martin", "Williams", "Alfa Romeo", "Haas F1 Team" };
            return teamList;
        }
        public static List<Tuple<string, string, string, int, string, double>> DriverData()
        {
            var driverData = new List<Tuple<string, string, string, int, string, double>>
            {
                new Tuple<string, string, string, int, string, double>(TeamList()[0], "Lewis Hamilton", "HAM", 44, "United Kingdom", 6.41),
                new Tuple<string, string, string, int, string, double>(TeamList()[0], "George Russell", "RUS", 63, "United Kingdom", 6.45),
                new Tuple<string, string, string, int, string, double>(TeamList()[1], "Max Verstappen", "VER", 1, "Netherlands", 2.59),
                new Tuple<string, string, string, int, string, double>(TeamList()[1], "Sergio Perez", "PER", 11, "Mexico", 5),
                new Tuple<string, string, string, int, string, double>(TeamList()[2], "Charles Leclerc", "LEC", 16, "Monaco", 3),
                new Tuple<string, string, string, int, string, double>(TeamList()[2], "Carlos Sainz", "SAI", 55, "Spain", 3.82),
                new Tuple<string, string, string, int, string, double>(TeamList()[3], "Lando Norris", "NOR", 4, "United Kingdom", 8.06),
                new Tuple<string, string, string, int, string, double>(TeamList()[3], "Oscar Piastri", "PIA", 81, "Australia", 11.11),
                new Tuple<string, string, string, int, string, double>(TeamList()[4], "Esteban Ocon", "OCO", 31, "France", 10.68),
                new Tuple<string, string, string, int, string, double>(TeamList()[4], "Pierre Gasly", "GAS", 10, "France", 12.50),
                new Tuple<string, string, string, int, string, double>(TeamList()[5], "Yuki Tsunoda", "TSU", 22, "Japan", 13.73),
                new Tuple<string, string, string, int, string, double>(TeamList()[5], "Nyck de Vries", "DEV", 45, "Netherlands", 13),
                new Tuple<string, string, string, int, string, double>(TeamList()[6], "Lance Stroll", "STR", 18, "Canada", 15.77),
                new Tuple<string, string, string, int, string, double>(TeamList()[6], "Fernando Alonso", "ALO", 14, "Spain", 8.27),
                new Tuple<string, string, string, int, string, double>(TeamList()[7], "Alexander Albon", "ALB", 23, "Thailand", 15.57),
                new Tuple<string, string, string, int, string, double>(TeamList()[7], "Logan Sargeant", "SAR", 6, "United States", 16.42),
                new Tuple<string, string, string, int, string, double>(TeamList()[8], "Valtteri Bottas", "BOT", 77, "Finland", 11.78),
                new Tuple<string, string, string, int, string, double>(TeamList()[8], "Zhou Guanyu", "ZHO", 24, "China", 14.41),
                new Tuple<string, string, string, int, string, double>(TeamList()[9], "Kevin Magnussen", "MAG", 20, "Denmark", 12.36),
                new Tuple<string, string, string, int, string, double>(TeamList()[9], "Nico Hulkenberg", "HUL", 25, "Germany", 17.5)
            };
            return driverData;
        }
    }
    public class Menu
    {
        private static readonly int AnimSpeed = 23;
        public static int Difficulty = 3;
        public static void MenuAnim1()
        {
            Console.Write(Colors.Teams()[2]);
            for (int i = 0; i < 7; i++)
            {
                Task.Delay(AnimSpeed).Wait();
                Console.Write("_");
            }
        }
        public static void MenuAnim2()
        {
            Console.Write(Colors.Teams()[2]);
            for (int i = 0; i < 7; i++)
            {
                Task.Delay(AnimSpeed).Wait();
                if (i == 3)
                {
                    Console.Write("/");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("      /Quick Race    ");
                    Console.Write(Colors.Teams()[2]);
                }
                else
                    Console.Write("_");
                if (i == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\r      /Quick Race    ");
                    Console.Write(Colors.Teams()[2]);
                    Console.Write("___");
                }
            }
        }
        public static void MenuAnim3()
        {
            Console.Write(Colors.Teams()[2]);
            for (int i = 0; i < 11; i++)
            {
                Task.Delay(AnimSpeed).Wait();
                if (i == 5)
                {
                    Console.Write("/");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
                else if (i == 6)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("     /Career Mode  ");
                    Console.Write(Colors.Teams()[2]);
                    Console.Write("/");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
                else if (i == 7)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("      /Quick Race   ");
                    Console.Write(Colors.Teams()[2]);
                    Console.Write("_");
                }
                else
                    Console.Write("_");
            }
        }
        public static void MenuAnim4()
        {
            Console.Write(Colors.Teams()[2]);
            Task.Delay(AnimSpeed).Wait();
            Console.WriteLine("    /Settings_____/   /");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("   /Exit Game        ");
            Task.Delay(AnimSpeed).Wait();
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("/");
            Task.Delay(AnimSpeed).Wait();
            Console.Write("                    /");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void MenuAnim4Clear()
        {
            Console.Write(Colors.Teams()[2]);
            Console.WriteLine("    /Settings_____/                   ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("   /Exit Game                         ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int MainMenu()
        {
            ConsoleKeyInfo key;
            int outcome = 4;
            int selMenu = 0;
            int selMenuQuick = 0;
            int selMenuCarrer = 0;
            int selMenuSettings = 0;
            bool firstTime = true;
            DisplayMenu.MenuDefault();
            key = Console.ReadKey(true);
            do
            {
                DisplayMenu.MenuReset();
                do
                {
                    while (selMenu == 0)
                    {
                        DisplayMenu.QuickRaceSelected();
                        if (firstTime == false)
                            key = Console.ReadKey(true);
                        firstTime = false;
                        if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenu = 1;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    while (selMenu == 1)
                    {
                        DisplayMenu.CareerModeSelected();
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenu = 2;
                        else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenu = 0;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    while (selMenu == 2)
                    {
                        DisplayMenu.SettingsSelected();
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenu = 1;
                        else if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenu = 3;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    while (selMenu == 3)
                    {
                        DisplayMenu.ExitGameSelected();
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenu = 2;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                } while (key.Key != ConsoleKey.Enter);
                while (selMenu == 0)
                {
                    while (selMenuQuick == 0)
                    {
                        DisplayMenu.QuickRaceDefault();
                        selMenuQuick = 1;
                    }
                    while (selMenuQuick == 1)
                    {
                        DisplayMenu.StartRandomSelected();
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenuQuick = 2;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            outcome = 0;
                            break;
                        }
                    }
                    while (selMenuQuick == 2)
                    {
                        DisplayMenu.ChooseCircuitSelected();
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenuQuick = 1;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            outcome = 1;
                            break;
                        }
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        selMenuQuick = 0;
                        break;
                    }
                    else if (key.Key == ConsoleKey.Enter)
                        break;
                }
                while (selMenu == 1)
                {
                    while (selMenuCarrer == 0)
                    {
                        DisplayMenu.CareerModeDefault();
                        selMenuCarrer = 1;
                    }
                    while (selMenuCarrer == 1)
                    {
                        DisplayMenu.NewGameSelected();
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenuCarrer = 2;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            outcome = 2;
                            break;
                        }
                    }
                    while (selMenuCarrer == 2)
                    {
                        DisplayMenu.LoadGameSelected();
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenuCarrer = 1;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            outcome = 3;
                            break;
                        }
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        selMenuCarrer = 0;
                        break;
                    }
                    else if (key.Key == ConsoleKey.Enter)
                        break;
                }
                while (selMenu == 2)
                {
                    while (selMenuSettings == 0)
                    {
                        DisplayMenu.SettingsDefault();
                        selMenuSettings = 1;
                    }
                    while (selMenuSettings == 1)
                    {
                        DisplayMenu.DifficultySelected();
                        key = Console.ReadKey(true);
                        if ((key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A) && Difficulty != 1)
                        { Difficulty--; Data.SaveDifficulty(); }
                        else if ((key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D) && Difficulty != 5)
                        { Difficulty++; Data.SaveDifficulty(); }
                        else if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenuSettings = 2;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    while (selMenuSettings == 2)
                    {
                        DisplayMenu.ChangeUserDataSelected();
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenuSettings = 1;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            Data data = new()
                            {
                                ChangeUserData = true
                            };
                            DisplayMenu.ChangeingUserData();
                            data.UserData();
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.WriteLine("                                                     \n                                                                                                 \n                                                                       \n                                                                                               \n                                                ");
                            data.ChangeUserData = false;
                            Console.SetCursorPosition(0, Console.CursorTop - 7);
                            MenuAnim4Clear();
                            break;
                        }
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        selMenuSettings = 0;
                        break;
                    }
                }
            } while (outcome > 3);
            return outcome;
        }
    }
    public class CircuitSelector
    {
        public static int CircuitListing()
        {
            ConsoleKeyInfo key;
            Console.Clear();
            int selCircuit = 0;
            do
            {
                switch(selCircuit)
                { 
                    case 0:
                        DisplayCircuit.Bahrain();
                        break;
                    case 1:
                        DisplayCircuit.SaudiArabia();
                        break;
                    case 2:
                        DisplayCircuit.Australia();
                        break;
                    case 3:
                        DisplayCircuit.Portugal();
                        break;
                    case 4:
                        DisplayCircuit.Azerbaijan();
                        break;
                    case 5:
                        DisplayCircuit.Miami();
                        break;
                    case 6:
                        DisplayCircuit.EmiliaRomagna();
                        break;
                    case 7:
                        DisplayCircuit.Monaco();
                        break;
                    case 8:
                        DisplayCircuit.Spain();
                        break;
                    case 9:
                        DisplayCircuit.Canada();
                        break;
                    case 10:
                        DisplayCircuit.Austria();
                        break;
                    case 11:
                        DisplayCircuit.UK();
                        break;
                    case 12:
                        DisplayCircuit.Hungray();
                        break;
                    case 21:
                        DisplayCircuit.Brazil();
                        break;
                    case 23:
                        DisplayCircuit.AbuDhabi();
                        break;
                    default:
                        break;
                }
                for (int i = 0; i < Data.CircuitData().Count; i++)
                {
                    if (i == selCircuit)
                        Console.Write(Colors.Teams()[2]);
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    if (i < 9)
                        Console.Write("R0");
                    else
                        Console.Write("R");
                    if (i == 0)
                        Console.Write($"{i + 1}╒{Data.CircuitData()[i].Item1} ");
                    else if (i == 23)
                        Console.Write($"{i + 1}╘{Data.CircuitData()[i].Item1} ");
                    else
                        Console.Write($"{i + 1}╞{Data.CircuitData()[i].Item1} ");
                    if (i == selCircuit)
                        Console.ForegroundColor = ConsoleColor.Gray;
                    else
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"{Data.CircuitData()[i].Item2}");
                }
                int oldSelCircuit = selCircuit;
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                        selCircuit = Math.Min(selCircuit + 1, 23);
                    else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                        selCircuit = Math.Max(selCircuit - 1, 0);
                    else if (key.Key == ConsoleKey.Enter)
                        break;
                } while (oldSelCircuit == selCircuit);
                Console.SetCursorPosition(0, Console.CursorTop - 24);
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
            bool firtstDriverSeled;
            int userNumber;
            int selTeam;
            selTeam = 0;
            firtstDriverSeled = true;
            Console.Clear();
            do
            {
                userNumber = 2;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Choose a team and who to replace {data.UserData()[1].Item3}\n");
                do
                {
                    for (int i = 0; i < Data.TeamList().Count; i++)
                    {
                        Console.Write(Colors.Teams()[i] + "|");
                        if (i != selTeam)
                            Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(Data.TeamList()[i] + "                                                ");
                        if (i == selTeam)
                        {
                            Console.Write("└─┤");
                            if (firtstDriverSeled == false)
                                Console.ForegroundColor = ConsoleColor.White;
                            else if (firtstDriverSeled && i == 9)
                                Console.Write(Colors.Teams()[2]);
                            Console.Write(Data.DriverData()[i * 2].Item4 + " " + Data.DriverData()[i * 2].Item2 + "  ");
                            Console.ForegroundColor = ConsoleColor.White;
                            if (firtstDriverSeled == false && i != 9)
                                Console.Write(Colors.Teams()[i]);
                            else if (firtstDriverSeled == false && i == 9)
                                Console.Write(Colors.Teams()[2]);
                            Console.WriteLine(Data.DriverData()[i * 2 + 1].Item4 + " " + Data.DriverData()[i * 2 + 1].Item2);
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
                    Console.SetCursorPosition(0, Console.CursorTop - 11);
                } while (key.Key != ConsoleKey.Enter);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPick your number");
                bool numberPicked = false;
                while (numberPicked == false)
                {
                    Console.Write(" < ");
                    if (userNumber < 10)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("0");
                    }
                    Console.Write(Colors.Teams()[selTeam] + userNumber);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" >");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                    {
                        if (userNumber < 12)
                            userNumber = 2;
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
                    else if ((key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A) && userNumber > 2)
                        userNumber--;
                    for (int i = 0; i < Data.DriverData().Count; i++)
                    {
                        while (Data.DriverData()[i].Item4 == userNumber)
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
                        }
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        numberPicked = true;
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        Console.WriteLine("                 \n                  \n              ");
                        Console.SetCursorPosition(0, Console.CursorTop - 16);
                        break;
                    }
                }
            } while (key.Key == ConsoleKey.Escape);
            int replace;
            if (firtstDriverSeled)
                replace = selTeam * 2;
            else
                replace = selTeam * 2 + 1;
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
            int startRnd;
            int userKey = 0;
            List<KeyValuePair<int, double>> lineup = new() { };
            do
            {
                for (int i = 0; i < Data.DriverData().Count; i++)
                {
                    startRndDouble = rnd.NextDouble();
                    startRnd = rnd.Next(10);
                    if (i == user)
                    {
                        userKey = driver[i].Item4;
                        lineup.Add(new KeyValuePair<int, double>(userKey, 99));
                    }
                    else
                        lineup.Add(new KeyValuePair<int, double>(driver[i].Item4, startRnd + driver[i].Item6 - startRndDouble));
                }
            } while (lineup.Count != lineup.Distinct().Count());
            lineup.Sort((x, y) => x.Value.CompareTo(y.Value));
            for (int i = 0; i < Data.DriverData().Count; i++)
            {
                if (lineup[i].Key == userKey)
                {
                    var item = lineup[i];
                    lineup.RemoveAt(i);
                    lineup.Insert(qualification, item);
                    break;
                }
            }
            return lineup;
        }   
    }
    public class Colors
    {
        public static List<string> Teams()
        {
                                            //{ "Mercedes",      "Red Bull",      "Ferrari",        "McLaren",        "Alpine",        "AlphaTauri",             "Aston Martin",  "Williams",      "Alfa Romeo",     "Haas F1 Team" };
            var colorIndex = new List<string> { "\x1b[38;5;85m", "\x1b[38;5;27m", "\x1b[38;5;196m", "\x1b[38;5;214m", "\x1b[38;5;69m", "\x1b[38;2;110;160;175m", "\x1b[38;5;35m", "\x1b[38;5;45m", "\x1b[38;5;160m", "\x1b[38;5;251m" };
            return colorIndex;
        }
        public static string Gray = "\x1b[38;5;245m";
        public static string LessGray = "\x1b[38;5;249m";
        public static string White = "\x1b[38;5;255m";
        public static string Gold = "\x1b[38;2;245;232;3m";
    }
    public class QPlayOrSkip
    {
        public static int PlayOrSkipQ(int circuit, int userTeam)
        {
            Console.Clear();
            ConsoleKeyInfo key;
            bool selectedOption = true;
            Console.WriteLine($"{Colors.White}           Do you wish to play qualifications?\n{Colors.Gray} If you skip you'll be given a random starting position\n");
            do
            {
                switch (selectedOption)
                {
                    case true:
                        Console.WriteLine($"               {Colors.Teams()[userTeam]}Play                  {Colors.Gray}Skip");
                        break;
                    case false:
                        Console.WriteLine($"               {Colors.Gray}Play                  {Colors.Teams()[userTeam]}Skip");
                        break;
                }
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.LeftArrow)
                    selectedOption = true;
                else if (key.Key == ConsoleKey.RightArrow)
                    selectedOption = false;
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            } while (key.Key != ConsoleKey.Enter);
            Console.Clear();    
            int qualifying;
            if (selectedOption)
            {
                qualifying = Qualifying.Qualification(userTeam, circuit);
            }
            else
            {
                Random rnd = new();
                int startRnd = rnd.Next(20);
                qualifying = startRnd;
            }
            return qualifying;
        }
    }
    public class QuickRace
    {
        public static void NormalRace()
        {
            Data data = new();
            ConsoleKeyInfo key;
            int circuit = CircuitSelector.CircuitListing();
            var userChoice = TeamSelector.TeamListing();
            int qualifying = QPlayOrSkip.PlayOrSkipQ(circuit, userChoice[0].Item1 / 2);
            var startingLineup = LineupGenerator.StartingLineup(userChoice[0].Item1, qualifying);
            QGraphics.QLineup(startingLineup, userChoice);
            string userTeamColor = Colors.Teams()[userChoice[0].Item1/2];
            int selPreRace = 1;
            do
            {
                Console.Clear();
                Console.WriteLine($"{Colors.Gray}Sunday, {Data.CircuitData()[circuit].Item3 + ' ' + Data.CircuitData()[circuit].Item4}, 2023");
                Console.WriteLine(Colors.White + Data.CircuitData()[circuit].Item1 + " Grand Prix " + userTeamColor + ">" + Colors.White + " Race\n" + Colors.Gray + Data.CircuitData()[circuit].Item2 + '\n');
                do
                {
                    switch (selPreRace)
                    {
                        case 1:
                            Console.Write(userTeamColor + "Starting lineup");
                            if (userChoice[0].Item1 / 2 == 9)
                                Console.Write("\x1b[38;5;196m<");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nCircuit view \nWeather forcast \nStart the Race ");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Starting lineup ");
                            Console.Write(userTeamColor + "Circuit view");
                            if (userChoice[0].Item1 / 2 == 9)
                                Console.Write("\x1b[38;5;196m<");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nWeather forcast \nStart the Race ");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Starting lineup \nCircuit view ");
                            Console.Write(userTeamColor + "Weather forcast");
                            if (userChoice[0].Item1 / 2 == 9)
                                Console.Write("\x1b[38;5;196m<");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nStart the Race ");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Starting lineup \nCircuit view \nWeather forcast ");
                            if (userChoice[0].Item1 / 2 == 9)
                                Console.WriteLine(userTeamColor + "Start the Race\x1b[38;5;196m<");
                            else
                                Console.WriteLine(userTeamColor + "Start the Race");
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
                    Console.Clear();
                    int number = 1;
                    int delay = 1;
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
                                    if (j == userChoice[0].Item1)
                                    {
                                        Console.Write(number + Colors.Teams()[j / 2] + $"|" + $"\x1b[38;5;{i}m" + data.UserData()[1].Item4 + " ");
                                        if (userChoice[0].Item2 < 10)
                                            Console.Write(" ");
                                        Console.WriteLine(Colors.Teams()[j / 2] + userChoice[0].Item2 + $"\x1b[38;5;{i - 2}m " + data.UserData()[1].Item3 + Colors.Teams()[j / 2] + " <");
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
                    do
                    {
                        key = Console.ReadKey(true);
                    } while (key.Key != ConsoleKey.Escape);
                }
                if (selPreRace == 2)
                {
                    Console.Clear();
                    switch (circuit)
                    {
                        case 0:
                            DisplayCircuitRace.Bahrain();
                            break;
                        case 1:
                            DisplayCircuitRace.SaudiArabia();
                            break;
                        case 2:
                            DisplayCircuitRace.Australia();
                            break;
                        case 3:
                            DisplayCircuitRace.Portugal();
                            break;
                        case 4:
                            DisplayCircuitRace.Azerbaijan();
                            break;
                        case 5:
                            DisplayCircuitRace.Miami();
                            break;
                        case 6:
                            DisplayCircuitRace.EmiliaRomagna();
                            break;
                        case 7:
                            DisplayCircuitRace.Monaco();
                            break;
                        case 8:
                            DisplayCircuitRace.Spain();
                            break;
                        case 9:
                            DisplayCircuitRace.Canada();
                            break;
                        case 10:
                            DisplayCircuitRace.Austria();
                            break;
                        case 11:
                            DisplayCircuitRace.UK();
                            break;
                        case 12:
                            DisplayCircuitRace.Hungray();
                            break;
                        case 21:
                            DisplayCircuitRace.Brazil();
                            break;
                        case 23:
                            DisplayCircuitRace.AbuDhabi();
                            break;
                        default:
                            break;
                    }
                }
            } while (selPreRace != 4);
        }
    }
    public class PlayAnthem
    {
        public static void Anthem()
        {
            Random rnd = new();
            ConsoleKeyInfo key;
            int randomDriver = rnd.Next(21);
            string driverCountry;
            if (randomDriver < 20)
                driverCountry = Data.DriverData()[randomDriver].Item5;
            else
                driverCountry = "Georgia";
            int skip = 0;
            string the = "";
            bool timeout = true;
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            Console.WriteLine("Finish the race");
            Console.ReadKey();
            if (driverCountry == "United Kingdom" || driverCountry == "United States" || driverCountry == "Netherlands")
                the = "the ";
            Console.Write(Colors.White);
            if (randomDriver < 20)
                Console.WriteLine($"The winner is {Data.DriverData()[randomDriver].Item2}\nThe natonal anthem of {the}{driverCountry} is playing");
            else
                Console.WriteLine($"The winner is Erekle Woxo\nThe natonal anthem of {the}{driverCountry} is playing");
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
                        --skip;
                    Console.Write("\x1b[38;5;246m");
                    switch (skip)
                    {
                        case 0:
                        case 1:
                            Console.Write("\rHold 'Space' to skip\u001b[38;5;240m ·····");
                            break;
                        case 2:
                        case 3:
                            Console.Write("\rHold 'Space' to skip\u001b[38;5;251m ·\u001b[38;5;240m····");
                            break;
                        case 4:
                        case 5:
                            Console.Write("\rHold 'Space' to skip\u001b[38;5;251m ··\u001b[38;5;240m···");
                            break;
                        case 6:
                        case 7:
                            Console.Write("\rHold 'Space' to skip\u001b[38;5;251m ···\u001b[38;5;240m··");
                            break;
                        case 8:
                        case 9:
                            Console.Write("\rHold 'Space' to skip\u001b[38;5;251m ····\u001b[38;5;240m·");
                            break;
                        case 10:
                            Console.Write("\rHold 'Space' to skip\u001b[38;5;251m ·····");
                            break;
                    }
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(false);
                    }
                    timeout = true;
                    if (skip == 10)
                        waveOut.Stop();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No anthem available");
                do
                {
                    key = Console.ReadKey(true);
                } while (key.Key != ConsoleKey.Enter);
            }
            Console.Clear();
        }
    }
    public class Intro
    {
        public static void IntroLogo()
        {
            string r = "\x1b[38;2;255;10;10m";
            string w = Colors.White;
            for (int i = 10; i < 256; i++)
            {
                Console.WriteLine($"\x1b[38;2;{i};10;10m" +
                @$"     ______________  __" + '\n' +
                @$"   /  ____________//  /" + '\n' +
                @$"  /  /  _________//  /" + '\n' +
                @$" /__/__/         /__/");
                Console.SetCursorPosition(0, Console.CursorTop - 4);
                Task.Delay(1).Wait();
            }
            string line1 = @$"{r}     ______________  __{w}   ___   ____  ___  ____  ";
            string line2 = @$"{r}   /  ____________//  /{w}  |__ \ / __ \|__ \ \__ \ ";
            string line3 = @$"{r}  /  /  _________//  / {w}  / __// /_/ // __//__  / ";
            string line4 = @$"{r} /__/__/         /__/  {w} /____/\____//____/____/  ";
            for (int i = 24; i > 0; i--)
            {
                Console.WriteLine(line1.Remove(line1.Length - i, line1.Length - (line1.Length - i)) + '\n' + line2.Remove(line1.Length - i, line1.Length - (line1.Length - i)) + '\n' + line3.Remove(line1.Length - i, line1.Length - (line1.Length - i)) + '\n' + line4.Remove(line1.Length - i, line1.Length - (line1.Length - i)));
                Console.SetCursorPosition(0, Console.CursorTop - 4);
                Task.Delay(1).Wait();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Data.LoadDifficulty();
            Intro.IntroLogo();
            Display.Logo();
            Data data = new();
            data.UserData();
            int mode = Menu.MainMenu();
            switch (mode)
            {
                case 0: case 1: case 2: case 3:
                    QuickRace.NormalRace();
                    break;
            }
        }
    }
}