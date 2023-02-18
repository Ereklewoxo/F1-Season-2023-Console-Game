
namespace F1_Season_2023_Ew
{
    public class Intro
    {
        public static void IntroLogo()
        {
            string r = "\x1b[38;2;255;0;0m", w = Colors.White;
            for (int i = 15; i < 256; i++)
            {
                Console.WriteLine($"\x1b[38;2;{i};0;0m" +
                "     ______________  __" + '\n' +
                "   /  ____________//  /" + '\n' +
                "  /  /  _________//  /" + '\n' +
                " /__/__/         /__/");
                Console.SetCursorPosition(0, Console.CursorTop - 4);
                Task.Delay(1).Wait();
            }
            string line1 = @$"{r}     ______________  __{w}   ___   ____  ___  ____  ",
                   line2 = @$"{r}   /  ____________//  /{w}  |__ \ / __ \|__ \ \__ \ ",
                   line3 = @$"{r}  /  /  _________//  / {w}  / __// /_/ // __//__  / ",
                   line4 = @$"{r} /__/__/         /__/  {w} /____/\____//____/____/  ";
            for (int i = 24; i > 0; i -= 2)
            {
                Console.WriteLine(line1.Remove(line1.Length - i, line1.Length - (line1.Length - i)) + '\n' + line2.Remove(line1.Length - i, line1.Length - (line1.Length - i)) + '\n' + line3.Remove(line1.Length - i, line1.Length - (line1.Length - i)) + '\n' + line4.Remove(line1.Length - i, line1.Length - (line1.Length - i)));
                Console.SetCursorPosition(0, Console.CursorTop - 4);
                Task.Delay(1).Wait();
            }
        }
    }
    public class Display
    {
        public static void Logo()
        {
            string r = "\x1b[38;2;255;0;0m", w = Colors.White;
            Console.WriteLine("" +
            @$"{r}     ______________  __{w}   ___   ____  ___  ____  " + '\n' +
            @$"{r}   /  ____________//  /{w}  |__ \ / __ \|__ \ \__ \ " + '\n' +
            @$"{r}  /  /  _________//  / {w}  / __// /_/ // __//__  / " + '\n' +
            @$"{r} /__/__/         /__/  {w} /____/\____//____/____/  " + '\n');
        }
        public static void DifficultyBar()
        {
            for (int i = 0; i < Data.Difficulty; i++)
                Console.Write(Colors.Teams()[2] + "▐");
            for (int i = 0; i < 5 - Data.Difficulty; i++)
                Console.Write(Colors.Gray + "▐");
        }
        public static void MenuDefault()
        {
            Console.WriteLine(Colors.Teams()[2] + "\r      /Quick Race        " + '\n' + Colors.White + "     /Career Mode                                             \n    /Settings            \n   /Exit Game                                 ");
        }
        public static void MenuReset()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.White + "\r      /Quick Race                                       \n     /Career Mode                                        \n    /Settings                  \n   /Exit Game                 ");
        }
        public static void QuickRaceSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Teams()[2] + "      /Quick Race" + '\n' + Colors.White + "     /Career Mode\n    /Settings\n   /Exit Game");
        }
        public static void CareerModeSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.White + "      /Quick Race" + Colors.Teams()[2] + '\n' + "     /Career Mode" + Colors.White + '\n' + "    /Settings\n   /Exit Game");
        }
        public static void SettingsSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.White + "      /Quick Race\n     /Career Mode" + '\n' + Colors.Teams()[2] + "    /Settings" + '\n' + Colors.White + "   /Exit Game");
        }
        public static void ExitGameSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.White + "      /Quick Race\n     /Career Mode\n    /Settings" + '\n' + Colors.Teams()[2] + "   /Exit Game");
        }
        public static void QuickRaceDefault()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.Write(Colors.Teams()[2] + "      /Quick Race");
            Menu.MenuAnimOne();
            Console.WriteLine(Colors.Teams()[2] + "/Start Random Race" + '\n' + Colors.Gray + "     /Career Mode      " + Colors.White + "/Choose a Circuit" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
        }
        public static void StartRandomSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Teams()[2] + "      /Quick Race_______/Start Random Race" + '\n' + Colors.Gray + "     /Career Mode      " + Colors.White + "/Choose a Circuit" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
        }
        public static void ChooseCircuitSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Teams()[2] + "      /Quick Race_______" + Colors.White + "/Start Random Race" + '\n' + Colors.Gray + "     /Career Mode      " + Colors.Teams()[2] + "/Choose a Circuit" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
        }
        public static void CareerModeDefault()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.Write(Colors.White + "      /Quick Race" + '\n' + Colors.Teams()[2] + "     /Career Mode");
            Menu.MenuAnimTwo();
            Console.WriteLine(Colors.Teams()[2] + "/New Game" + '\n' + "     /Career Mode___/  " + Colors.White + "/Load Game" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
        }
        public static void NewGameSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Gray + "      /Quick Race    " + Colors.Teams()[2] + "___/New Game" + '\n' + "     /Career Mode___/  " + Colors.White + "/Load Game" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
        }
        public static void LoadGameSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Gray + "      /Quick Race    " + Colors.Teams()[2] + "___" + Colors.White + "/New Game" + '\n' + Colors.Teams()[2] + "     /Career Mode___/  /Load Game" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
        }
        public static void SettingsDefault()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.Write(Colors.White + "      /Quick Race\n     /Career Mode" + '\n' + Colors.Teams()[2] + "    /Settings");
            Menu.MenuAnimThree();
            Console.WriteLine("/Difficulty" + Colors.Gray + '\n' + "     /Career Mode  " + '\n' + Colors.Teams()[2] + '/' + '\n' + Colors.Gray + "   /Exit Game");
        }
        public static void DifficultySelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.Write(Colors.Gray + "      /Quick Race   " + Colors.Teams()[2] + "____/Difficulty");
            Display.DifficultyBar();
            Console.WriteLine('\n' + Colors.Gray + "     /Career Mode  " + Colors.Teams()[2] + '/' + Colors.White + "   /Change User Data" + '\n' + Colors.Teams()[2] + "    /Settings" + '\n' + Colors.Gray + "   /Exit Game");
        }
        public static void ChangeUserDataSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Gray + "      /Quick Race   " + Colors.Teams()[2] + "____" + Colors.White + "/Difficulty               " + '\n' + Colors.Gray + "     /Career Mode  " + Colors.Teams()[2] + '/' + "   /Change User Data" + '\n' + "    /Settings" + '\n' + Colors.Gray + "   /Exit Game");
        }
        public static void ChangeingUserData()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Gray + "      /Quick Race   " + Colors.Teams()[2] + "____" + Colors.Gray + "/Difficulty               " + '\n' + "     /Career Mode  " + Colors.Teams()[2] + '/' + "   /Change User Data");
            Menu.MenuAnimFour();
        }
    }
    public class Menu
    {
        private static readonly int AnimSpeed = 30;
        public static void MenuAnimOne()
        {
            Console.Write(Colors.Teams()[2]);
            for (int i = 0; i < 7; i++)
            {
                Console.Write("_");
                Task.Delay(AnimSpeed).Wait();
            }
        }
        public static void MenuAnimTwo()
        {
            Console.Write(Colors.Teams()[2]);
            for (int i = 0; i < 7; i++)
            {
                if (i == 3)
                {
                    Console.Write("/");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(Colors.White + "      /Quick Race    " + Colors.Teams()[2]);
                }
                else
                    Console.Write("_");
                if (i == 6)
                    Console.Write(Colors.White + "\r      /Quick Race    " + Colors.Teams()[2] + "___");
                Task.Delay(AnimSpeed).Wait();
            }
        }
        public static void MenuAnimThree()
        {
            Console.Write(Colors.Teams()[2]);
            for (int i = 0; i < 11; i++)
            {
                if (i == 5)
                {
                    Console.Write("/");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
                else if (i == 6)
                {
                    Console.Write(Colors.White + "     /Career Mode  " + Colors.Teams()[2] + '/');
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
                else if (i == 7)
                    Console.Write(Colors.White + "      /Quick Race   " + Colors.Teams()[2] + '_');
                else
                    Console.Write("_");
                Task.Delay(AnimSpeed).Wait();
            }
        }
        public static void MenuAnimFour()
        {
            Console.Write(Colors.Teams()[2] + "    /Settings_____/   /" + '\n' + Colors.Gray + "   /Exit Game        ");
            Task.Delay(AnimSpeed).Wait();
            Console.WriteLine(Colors.Teams()[2] + '/');
            Task.Delay(AnimSpeed).Wait();
            Console.Write("                    /" + Colors.White);
            Task.Delay(AnimSpeed).Wait();
        }
        public static void MenuAnimFourClear()
        {
            Console.WriteLine(Colors.Teams()[2] + "    /Settings_____/                   " + '\n' + Colors.Gray + "   /Exit Game                         " + Colors.White);
        }
        public static short MainMenu()
        {
            ConsoleKeyInfo key;
            short outcome = 4;
            int selMenu = 0, selMenuQuick = 0, selMenuCarrer = 0, selMenuSettings = 0;
            bool firstTime = true;
            Display.MenuDefault();
            key = Console.ReadKey(true);
            do
            {
                Display.MenuReset();
                do
                {
                    while (selMenu == 0)
                    {
                        Display.QuickRaceSelected();
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
                        Display.CareerModeSelected();
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
                        Display.SettingsSelected();
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
                        Display.ExitGameSelected();
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
                        Display.QuickRaceDefault();
                        selMenuQuick = 1;
                    }
                    while (selMenuQuick == 1)
                    {
                        Display.StartRandomSelected();
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
                        Display.ChooseCircuitSelected();
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
                        Display.CareerModeDefault();
                        selMenuCarrer = 1;
                    }
                    while (selMenuCarrer == 1)
                    {
                        Display.NewGameSelected();
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
                        Display.LoadGameSelected();
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
                        Display.SettingsDefault();
                        selMenuSettings = 1;
                    }
                    while (selMenuSettings == 1)
                    {
                        Display.DifficultySelected();
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A)
                        { Data.Difficulty = Math.Max(Data.Difficulty - 1, 1); Data.SaveDifficulty(); }
                        else if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D)
                        { Data.Difficulty = Math.Min(Data.Difficulty + 1, 5); Data.SaveDifficulty(); }
                        else if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenuSettings = 2;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    while (selMenuSettings == 2)
                    {
                        Display.ChangeUserDataSelected();
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenuSettings = 1;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            Data data = new()
                            { ChangeUserData = true };
                            Display.ChangeingUserData();
                            data.UserData();
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.WriteLine("" +
                                "                                                                       \n" +
                                "                                                                       \n" +
                                "                                                                       \n" +
                                "                                                                       \n" +
                                "                                                                       ");
                            data.ChangeUserData = false;
                            Console.SetCursorPosition(0, Console.CursorTop - 7);
                            MenuAnimFourClear();
                            break;
                        }
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        selMenuSettings = 0;
                        break;
                    }
                }
                if (selMenu == 3)
                    break;
            } while (outcome > 3);
            return outcome;
        }
    }
}