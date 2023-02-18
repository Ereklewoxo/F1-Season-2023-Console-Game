namespace F1_Season_2023_Ew
{
    public class DisplayCircuit
    {
        public static void Circuits(int circuit)
        {
            Console.WriteLine("\r                                                                                   ");
            string circuitMap, lapRecord;
            double lenght;
            int drsZones;
            switch (circuit)
            {
                case 0:
                    lenght = 5.41;
                    lapRecord = "1:31.238 Pedro de la Rosa (2005)  ";
                    drsZones = 3;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                    F1F1F                                                          " +
                    "\n\r                   F1   F1                          BAHRAIN                        " +
                    "\n\r                   F1     F1                      F1       F1                      " +
                    "\n\r                  F1        F1F1F                F1         F1                     " +
                    "\n\r                  F1             F1F1           F1           F1                    " +
                    "\n\r                  F1                F1          F1            F1                   " +
                    "\n\r                 F1                 F1           F1             F1                 " +
                    "\n\r                 F1                  F1F1          F1F1F1        F1                " +
                    "\n\r                F1                       F1F1            F1F      F1               " +
                    "\n\r                F1     F1F1F1F1F1F1F         F1             F1     F1              " +
                    "\n\r                F1    F1           F1F1F1F1F1F               F1      F1            " +
                    "\n\r               F1    F1F1F1FF1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1        F1           " +
                    "\n\r              F1                                                       F1          " +
                    "\n\r                F1F                                                     F1         " +
                    "\n\r              F1                                                     F1F1          " +
                    "\n\r                F1F1F1-57-LAPS-15-TURNS-F1F1F1F1F1START1F1F1F1F1F1F1F1             " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 1:
                    lenght = 6.17;
                    lapRecord = "1:30.734 Lewis Hamilton (2021)    ";
                    drsZones = 3;
                    circuitMap = Colors.LessGray +
                      "\r                                                                      F1F1F1       " +
                    "\n\r                                                                  T1F1    F1       " +
                    "\n\r                                                              R1F1       F1        " +
                    "\n\r                                                           A1F           F1        " +
                    "\n\r                                                        T1F            F1F         " +
                    "\n\r                                                     S1F            F1F            " +
                    "\n\r                                                 F1F1            F1F               " +
                    "\n\r                                               F1    SAUDI-ARABIA                  " +
                    "\n\r                                          F1F1F1F1 F1                              " +
                    "\n\r                                       F1F1    F1F1F1F1                            " +
                    "\n\r                                    F1F1    F1F1                                   " +
                    "\n\r                             F1F1F1F     F1F1                                      " +
                    "\n\r                            F1       F1F1                                          " +
                    "\n\r            F1-50-LAPS-F1  F1   F1F1F1                                             " +
                    "\n\r        F1F1             F1   F1F                                                  " +
                    "\n\r     F1F1    F-27-TURNS-1    F1                                                    " +
                    "\n\r   F1     F1F          F1F1F1                                                      " +
                    "\n\r    F1F1F1                                                                         " +
                    "\n\r                                                                                   ";
                    break;
                case 2:
                    lenght = 5.28;
                    lapRecord = "1:20.260 Charles Leclerc (2022)   ";
                    drsZones = 2;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                  F1F1F1F1                                                         " +
                    "\n\r             F1F1F1      F1F1F1                                                    " +
                    "\n\r            F1               F1F1                                                  " +
                    "\n\r           F1                  F1F                                                 " +
                    "\n\r          F1                   F1F                                                 " +
                    "\n\r         F1                      F1F                                               " +
                    "\n\r         F1                        F1               F1F1F1F1F1F1F1F1               " +
                    "\n\r         F1                          F1F-AUSTRALIA-F1F              F1F1           " +
                    "\n\r          F1F1                                                          F1F1       " +
                    "\n\r              F1                                                         F1        " +
                    "\n\r             F1                                               F1F1F1    F1         " +
                    "\n\r            F1F1F1                                            F1   F1F1F1          " +
                    "\n\r                  58-LAPS-14-TURNS                            F1                   " +
                    "\n\r                                 F1F1F1F1START1F1F1F1F1F1F1F1F1                    " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 3:
                    lenght = 6.01;
                    lapRecord = "1:43.009 Charles Leclerc (2019)   ";
                    drsZones = 2;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                               F1F1F1F1-AZERBAIJAN-F1F1F1F1        " +
                    "\n\r           F1F1F1F1F1F1                       F1                          F1       " +
                    "\n\r         F1           F1                      F1                          F1       " +
                    "\n\r       F1               F1                    F1                          F1       " +
                    "\n\r      F1                F1           F1F1F1F1F1                           F1       " +
                    "\n\r     F1                 F1F1F1F1F1F1F1                                    F1       " +
                    "\n\r    F1                   51-LAPS-20-TURNS-F1F1F1F1F1F1F1F1F1STARTF1F1F1F1F1        " +
                    "\n\r    F1            F1F1F1F                                                          " +
                    "\n\r      F1      F1F1F                                                                " +
                    "\n\r        F1F1F1                                                                     " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 4:
                    lenght = 5.41;
                    lapRecord = "1:31.361 Max Verstappen (2022)    ";
                    drsZones = 3;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r            F1F1F1F1F1F1-MIAMI-F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1          " +
                    "\n\r              F1F1    F1F1F1F1F1F1                                    F1           " +
                    "\n\r                  F1F1           F1F1F1F1F1                            F1          " +
                    "\n\r                                          F1F1F1                  F1F1F1           " +
                    "\n\r                                                F1F              F1                " +
                    "\n\r                       F1F1                   F1F                  F1F1            " +
                    "\n\r        F1F1F1F1    F1F1  F1F1                F1                F1F1               " +
                    "\n\r      F1       F1F1F1         F1F1F1         F1F            F1F1                   " +
                    "\n\r      F1                            F1F1F1F1F1          F1F1                       " +
                    "\n\r       F1F1F1-57-LAPS-19-TURNS-F1F1F1F1F1           F1F1                           " +
                    "\n\r                                        F1F1F1F1F1F1                               " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 5:
                    lenght = 4.91;
                    lapRecord = "1:15.484 Lewis Hamilton (2020)    ";
                    drsZones = 1;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                      F1F          " +
                    "\n\r                           F1-EMILIA-ROMAGNA-F1F1                  F1F   F1        " +
                    "\n\r                          F1                     F1F1F1F1START1F1F1       F1F      " +
                    "\n\r                       F1F1                                            F1F         " +
                    "\n\r                      F1                                            F1F            " +
                    "\n\r                     F1                                          F1F               " +
                    "\n\r                    F1                                        F1F1                 " +
                    "\n\r                   F1              F-63-LAPS-19-TURNS-F1 F1F1F                     " +
                    "\n\r                  F1              F1                   F1                          " +
                    "\n\r                 F1               F1                                               " +
                    "\n\r                  F1             F1                                                " +
                    "\n\r                   F1             F1                                               " +
                    "\n\r               F1F1                F1                                              " +
                    "\n\r             F1F1                 F1                                               " +
                    "\n\r            F1F1F1F1F1F1F1F1F1F1F1F                                                " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 6:
                    lenght = 3.34;
                    lapRecord = "1:12.909 Lewis Hamilton (2021)    ";
                    drsZones = 1;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                              F1F1F1F1             " +
                    "\n\r                                                            F1F1    F1  F1F1       " +
                    "\n\r                                                        F1F1        F1 F1  F1      " +
                    "\n\r                     MONACO                             F1           F1   F1       " +
                    "\n\r                   F1     F1F1F1F1                       F1             F1         " +
                    "\n\r                  T1             F1F1-19-TURNS-F1F1      F1           F1           " +
                    "\n\r                 R1   F1F1F1F1F1                  F1F1F1F1        F1F1             " +
                    "\n\r                A1   F1        F1F1F1F1 F1F1F1F1F1           F1F1F1                " +
                    "\n\r               T1    F1                F1        F1-78-LAPS-F1                     " +
                    "\n\r              S1    F1                                                             " +
                    "\n\r             F1    F1                                                              " +
                    "\n\r            F1   F1F1                                                              " +
                    "\n\r            F1  F1                                                                 " +
                    "\n\r            F1   F1                                                                " +
                    "\n\r             F1   F1F                                                              " +
                    "\n\r            F1F1F1F1F1                                                             " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 7:
                    lenght = 4.68;
                    lapRecord = "1:18.149 Max Verstappen (2021)    ";
                    drsZones = 2;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r            F1-66-LAPS-16-TURNS-F1        F1F1                SPAIN                " +
                    "\n\r          F1F                   F1      F1F   F1F1          F1     F1F1            " +
                    "\n\r         F1        F1F1F1F1F1F1F1     F1F         F1F1        F1F1    F1           " +
                    "\n\r         F1       F1                F1F               F1F1        F1  F1           " +
                    "\n\r          F1F1F1    F1F            F1                     F1F1     F1  F1F1        " +
                    "\n\r               F1F1   F1F1F1F1F1F1F1                          F1F1F1      F1       " +
                    "\n\r                  F1                                                     F1        " +
                    "\n\r                  F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START1F1F1F1F1F1F1F1F1         " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 8:
                    lenght = 4.36;
                    lapRecord = "1:13.078 Valtteri Bottas (2019)   ";
                    drsZones = 3;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r     F1-CANADA-1F1F1F1F1F1                                                         " +
                    "\n\r      F1F1F1F1           F-70-LAPS-1                                               " +
                    "\n\r             F1F1F1F1              F-14-TURNS-1                                    " +
                    "\n\r                    F1F1                      F1F1F1F1                             " +
                    "\n\r                       F1F                          F1F1F1F1FSTART                 " +
                    "\n\r                         F1                                      F1F1F1  F1F       " +
                    "\n\r                         F1F1                                          F1  F1      " +
                    "\n\r                            F1F1                                          F1       " +
                    "\n\r                                F1F1F1                       F1F1     F1F1         " +
                    "\n\r                                     F1F1F1   F1F1   F1F1F1F1   F1F1F1             " +
                    "\n\r                                          F1F1F1  F1F1                             " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 9:
                    lenght = 4.31;
                    lapRecord = "1:10.540 Valtteri Bottas (2018)   ";
                    drsZones = 2;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r           F1F1-AUSTRIA-1F1F1F1F1F1                                                " +
                    "\n\r            F1F                   F1F1F1F1F1F1F1F1F1                               " +
                    "\n\r              F1F                                  F1                              " +
                    "\n\r                 F1F                            F1F1                               " +
                    "\n\r                   F1F         F1F1F1F1F1F1F1F1F1                                  " +
                    "\n\r                     F1F     F1F                                                   " +
                    "\n\r                       F1    F1                                                    " +
                    "\n\r                        F1    F1          F1-71-LAPS-10-TURNS-F1F1F1F1F1F1         " +
                    "\n\r                         F1     F1      F1                               F1        " +
                    "\n\r                          F1      F1F1F1                                  F1       " +
                    "\n\r                           F1F                                             F1      " +
                    "\n\r                             F1F                                         F1F1      " +
                    "\n\r                               F1F                               F1F1F1F1          " +
                    "\n\r                                 F1F                     F1F1F1F1                  " +
                    "\n\r                                   F1          F1F1FSTART                          " +
                    "\n\r                                     F1F1F1F1F1                                    " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 10:
                    lenght = 5.89;
                    lapRecord = "1:27.369 Lewis Hamilton (2019)    ";
                    drsZones = 2;
                    circuitMap = Colors.LessGray +
                      "\r                    F1F1F1F1F1                                                     " +
                    "\n\r                   F1        START                                                 " +
                    "\n\r                    F1F          F1F1                         F-UK-1               " +
                    "\n\r                  F1                F1F1                     F1    F1F1            " +
                    "\n\r              F1F1                     F1F1                   F1F1    F1F          " +
                    "\n\r          F1F1                            F1                     F1     F1         " +
                    "\n\r        F1                                F1                     F1     F1         " +
                    "\n\r        F1                                F1                  F1F1      F1         " +
                    "\n\r          F1F1                            F1                F1F         F1         " +
                    "\n\r             F1F1                          F1             F1F           F1         " +
                    "\n\r                 F1F1F1                      F1         F1F              F1        " +
                    "\n\r                       F1F1                    F1     F1F                F1        " +
                    "\n\r                           F1F1            F1F1     F1F                  F1        " +
                    "\n\r                               F1F1F         F1F1F1F1                    F1        " +
                    "\n\r                                    F1F                        F-52-LAPS-1         " +
                    "\n\r                                      F1F1   F1F1   F-18-TURNS-1                   " +
                    "\n\r                                         F1F1   F1F1                               " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 11:
                    lenght = 4.38;
                    lapRecord = "1:16.627 Lewis Hamilton (2020)    ";
                    drsZones = 2;
                    circuitMap = Colors.LessGray +
                      "\r                   1F1                                                             " +
                    "\n\r                 F1  F1                                       F1F1                 " +
                    "\n\r                 F1   F1                                    F1    F1               " +
                    "\n\r                 F1    F1                                 F1       F1              " +
                    "\n\r                 F1    F1                                F1        F1              " +
                    "\n\r                 F1    F1                 HUNGRAY-F1F1F1F1         F1              " +
                    "\n\r                 F1    F1      F1F1F1F1F1F1                       F1               " +
                    "\n\r                 F1    F1     F1                                 F1                " +
                    "\n\r                 T1    F1    F1                              F1F1F                 " +
                    "\n\r                 R1     F1F1F1                             F1F                     " +
                    "\n\r                 A1                                       F1                       " +
                    "\n\r                 T1                                        F1                      " +
                    "\n\r                 S1                                         F1                     " +
                    "\n\r                 F1     F1F1F                              F1                      " +
                    "\n\r                 F1    F1   F1                        F1F1F1                       " +
                    "\n\r                 F1    F1  F1                      F1F1                            " +
                    "\n\r                 F1    F1  F1                     F1                               " +
                    "\n\r                  F1F1F1   F1F1-70-LAPS-14-TURNS-F1                                " +
                    "\n\r                                                                                   ";
                    break;
                case 12:
                    lenght = 7.01;
                    lapRecord = "1:46.286 Valtteri Bottas (2018)   ";
                    drsZones = 2;
                    circuitMap = Colors.LessGray +
                      "\r                                                 F1F1F1F1F1F1   F1F1F1             " +
                    "\n\r                                          BELGIUM           F1F1     F1            " +
                    "\n\r                                   F1F1F1F                            F1           " +
                    "\n\r                               F1F1                        F1F1F1F1F1  F1          " +
                    "\n\r                           F1F1                   F1F1F1F1F1         F1F           " +
                    "\n\r                       F1F1                      F1                                " +
                    "\n\r                   F1F1                          F1                                " +
                    "\n\r                 F1                               F1                               " +
                    "\n\r               F1                                  F1F1F1                          " +
                    "\n\r             F1                         F1F1F1           F1F1F1F1                  " +
                    "\n\r           F1      F1             F1F1F1      F1F1              F1                 " +
                    "\n\r         F1       F1F1-44-LAPS-F1F               F1           F1                   " +
                    "\n\r       F1       F1                                 F1           F1F1               " +
                    "\n\r      F1    START                                    F1             F1F1           " +
                    "\n\r     F1  F1F1                                          F1              F1          " +
                    "\n\r     F1F1                                                F1F1F1       F1           " +
                    "\n\r                                                              18-TURNS             " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 13:
                    Console.SetCursorPosition(0, 0);
                    lenght = 4.26;
                    lapRecord = "1:11.097 Lewis Hamilton (2021)    ";
                    drsZones = 2;
                    circuitMap = Colors.LessGray +
                      "\r                   F-NETHERLANDS-1                                                 " +
                    "\n\r                  F1              F1F1F1F1                                         " +
                    "\n\r                 F1                      F1                                        " +
                    "\n\r                 F1       F1F1F1F1        F1                                       " +
                    "\n\r                  F1      F1      F1      F1                                       " +
                    "\n\r                   F1      F1       F1   F1                                        " +
                    "\n\r                    F1      F1        F1F1                                         " +
                    "\n\r                     F1F     F1                                                    " +
                    "\n\r                        F1F    F1                                                  " +
                    "\n\r                           F1F   F1F                                               " +
                    "\n\r                             F1    F1F1                                            " +
                    "\n\r                               F1      F1F1                   F1F1                 " +
                    "\n\r                                F1        F1F1           F1F1F1   F1               " +
                    "\n\r                                 F1          F1       F1F1         F1              " +
                    "\n\r                                  F1F      F1      F1F1             F1             " +
                    "\n\r                                    F1F1    F1F1F1F1                 F1            " +
                    "\n\r                            F1F1F1     F1                            F1            " +
                    "\n\r           F1F1F1F1F1F1F1F1F1    F1F1   F1                           F1            " +
                    "\n\r          F1                        F1F1                            F1             " +
                    "\n\r           F1F1F1F1F1F1F1F1F1F1START1F1-72-LAPS-14-TURNS-F1F1F1F1F1F1              ";
                    break;
                case 14:
                    lenght = 5.79;
                    lapRecord = "1:21.046 Rubens Barrichello (2004)";
                    drsZones = 2;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r        F1-ITALY-F1                                                                " +
                    "\n\r       F1         F1                                                               " +
                    "\n\r        F1          F1                                                             " +
                    "\n\r         F1           F1                                                           " +
                    "\n\r         F1F            F1                                                         " +
                    "\n\r          F1              F1F                                                      " +
                    "\n\r          F1                 F1F                                                   " +
                    "\n\r          F1                    F1F1                                               " +
                    "\n\r          F1                        F1F1-53-LAPS-11-TURNS-F1F1F1F1F1F1F1F1         " +
                    "\n\r          F1                                                             F1        " +
                    "\n\r           F1                                                           F1F        " +
                    "\n\r             F1F1          F1F                                 F1F1F1F1F1          " +
                    "\n\r                 F1F1F1F1F1  F1F1F1F1F1F1F1F1F1F1F1F1F1F1STARTF1                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 15:
                    lenght = 5.03;
                    lapRecord = "1:41.905 Kevin Magnussen (2018)   ";
                    drsZones = 3;
                    circuitMap = Colors.LessGray +
                      "\r                                                               F1                  " +
                    "\n\r                                                             F1  F1F1              " +
                    "\n\r                                                             F1      F1            " +
                    "\n\r                                                              F1     F1            " +
                    "\n\r                           F1F1F1                              F1    F1            " +
                    "\n\r               F1F1F1     F1    F1F1F1                         F1     T1           " +
                    "\n\r              F1    F1   F1          F1F                        F1    R1           " +
                    "\n\r             F1       F1F1             F1F1F1F-SINGAPORE-F1F1F1F1     A1           " +
                    "\n\r            F1          F1F1                                           T1          " +
                    "\n\r           F1          F1   F1F1                                       S1          " +
                    "\n\r          F1           F1       F1F1                                   F1          " +
                    "\n\r         F1           F1            F1F           F1F1F1F1            F1           " +
                    "\n\r        F1            F1              F1         F1      F1-23-TURNS-F1            " +
                    "\n\r         F1F1        F1                F-61-LAPS-F1                                " +
                    "\n\r            F1      F1                                                             " +
                    "\n\r             F1F   F1                                                              " +
                    "\n\r               F1 F1                                                               " +
                    "\n\r                 F1                                                                " +
                    "\n\r                                                                                   ";
                    break;
                case 20:
                    lenght = 4.31;
                    lapRecord = "1:10.540 Valtteri Bottas (2018)   ";
                    drsZones = 2;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                    F1F1F1F1-BRAZIL-F1F1F1                         " +
                    "\n\r                                 F1F                F1F   F1                       " +
                    "\n\r                              F1F      F1F1F1    F1F  F1    F1                     " +
                    "\n\r                          START     F1F1   F1  F1F   F1F      F1                   " +
                    "\n\r                        F1F        F1       F1F1   F1          F1                  " +
                    "\n\r                     F1F           F1F            F1           F1                  " +
                    "\n\r                  F1F                 F1F1F         F1F1F      F1                  " +
                    "\n\r                F1F                        F1F1F1F       F1F1F1                    " +
                    "\n\r                 F1F                             F1F1                              " +
                    "\n\r                  F1                                 F1                            " +
                    "\n\r                  F1                                  F1                           " +
                    "\n\r                   F1                                F1                            " +
                    "\n\r                     F1F1F1F-71-LAPS-15-TURNS-F1F1F1F1                             " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                case 22:
                    lenght = 5.28;
                    lapRecord = "1:26.103 Max Verstappen (2021)    ";
                    drsZones = 2;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                F1F1                                               " +
                    "\n\r                                F1 F1F1F1                                          " +
                    "\n\r                       ABU-DHABI       F1F1F1                                      " +
                    "\n\r                    F1F1         F1F1F1F    F1F1F1                                 " +
                    "\n\r                 F1F1       F1F1F1    F1          F1F1F1                           " +
                    "\n\r               F1F          F1        S1               F1F1F1                      " +
                    "\n\r             F1F F1F1F1     F1        T1                    F1F1F1                 " +
                    "\n\r          F1F F1F     F1    F1        A1                         F1F1F1            " +
                    "\n\r        F1F F1F       F1    F1        R1                              F1F1F1       " +
                    "\n\r      F1F  F1          F1F1F1         T1              F1F1F1               F1F1F1  " +
                    "\n\r     F1    F1                         F1            F1F    F-16-TURNS-1         F1 " +
                    "\n\r   F1F    F1                          F1           F1                  F1F1F1F1F1  " +
                    "\n\r  F1F    F1F                           F1-58-LAPS-F1                               " +
                    "\n\r    F1F1F1                                                                         " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                default:
                    lenght = 0.01;
                    lapRecord = "0:00.000 N/A (0000)               ";
                    drsZones = 0;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
            }
            string circuitInfo = $"\n\r{Colors.White}  Length - {lenght}KM | {Colors.Green}DRS {Colors.White}Zones - {drsZones} | {Colors.Magenta}Lap record {Colors.White}- {lapRecord}";
            Console.WriteLine(circuitMap + circuitInfo);
            Console.SetCursorPosition(0, 0);
        }
        public static void BonusCircuits(int circuit)
        {
            Console.WriteLine("\r                                                                                   ");
            string circuitMap, lapRecord;
            double lenght;
            int drsZones;
            switch (circuit)
            {
                case 0:
                    lenght = 4.65;
                    lapRecord = "1:18.750 Lewis Hamilton (2020)    ";
                    drsZones = 2;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                 F1F1F1                            " +
                    "\n\r                                               F1     F1    F1F1F1                 " +
                    "\n\r                      F1F1F1F1F1             F1       F1   F1     F1               " +
                    "\n\r                      F1       F1-PORTUGAL-F1         F1     F1     F1             " +
                    "\n\r              F1F1     F1                             F1       F1     F1           " +
                    "\n\r             F1  F1     F1F1F1F1F1F1F1F1F1F1           F1F1F1    F1     F1         " +
                    "\n\r            F1    F1                        F1F1            F1F1F1       F1        " +
                    "\n\r           F1      F1F1-66-LAPS-15-TURNS-F1F1F1F1                        F1        " +
                    "\n\r            F1                                                          F1         " +
                    "\n\r             F1                                                        F1          " +
                    "\n\r              F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START1F1F1F1F1F1F1F1F1F1F1           " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
                default:
                    lenght = 0.01;
                    lapRecord = "0:00.000 N/A (0000)               ";
                    drsZones = 0;
                    circuitMap = Colors.LessGray +
                      "\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   " +
                    "\n\r                                                                                   ";
                    break;
            }
            string circuitInfo = $"\n\r{Colors.White}  Length - {lenght}KM | {Colors.Green}DRS {Colors.White}Zones - {drsZones} | {Colors.Magenta}Lap record {Colors.White}- {lapRecord}";
            Console.WriteLine(circuitMap + circuitInfo);
            Console.SetCursorPosition(0, 0);
        }
    }
    public class DisplayCircuitRace
    {
        public static readonly string R = "\x1b[38;5;196m", B = "\x1b[38;5;33m", Y = "\x1b[38;5;226m", G = Colors.Green, P = Colors.Magenta, W = Colors.White, N = Colors.LessGray;
        public static int SelMap;
        public static void CircuitsRace(int circuit)
        {
            ConsoleKeyInfo key;
            switch (circuit)
            {
                case 0:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                            $"\n{pad}       F1F1F " + pad +
                            $"\n{pad}      F1   F1                          BAHRAIN " + pad +
                            $"\n{pad}      F1     F1                      F1       F1 " + pad +
                            $"\n{pad}     F1        F1F1F                F1         F1 " + pad +
                            $"\n{pad}     F1             F1F1           F1           F1 " + pad +
                            $"\n{pad}     F1                F1          F1            F1 " + pad +
                            $"\n{pad}    F1                 F1           F1             F1 " + pad +
                            $"\n{pad}    F1                  F1F1          F1F1F1        F1 " + pad +
                            $"\n{pad}   F1                       F1F1            F1F      F1 " + pad +
                            $"\n{pad}   F1     F1F1F1F1F1F1F         F1             F1     F1 " + pad +
                            $"\n{pad}   F1    F1           F1F1F1F1F1F               F1      F1 " + pad +
                            $"\n{pad}  F1    F1F1F1FF1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1        F1 " + pad +
                            $"\n{pad} F1                                                       F1 " + pad +
                            $"\n{pad}   F1F                                                     F1 " + pad +
                            $"\n{pad} F1                                                     F1F1 " + pad +
                            $"\n{pad}   F1F1F1-57-LAPS-15-TURNS-F1F1F1F1F1START1F1F1F1F1F1F1F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                    < Length - 5.41KM >                                   \n" +
                                      P + "\n        Lap record" + W + " - 1:31.238 Pedro de la Rosa (2005)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                "\n       F1F1F " +
                                "\n      F1   F1                          BAHRAIN " +
                                "\n      F1     F1                      F1       F1 " +
                                "\n     F1        F1F1F                F1         F1 " +
                                "\n     F1             F1F1           F1           F1 " +
                                "\n     F1                F1          F1            F1 " +
                                "\n    F1                 F1           F1             F1 " +
                                "\n    F1                  F1F1          F1F1F1        F1 " +
                                "\n   F1                       F1F1            F1F      F1 " +
                                "\n   F1     F1F1F1F1F1F1F         F1             F1     F1 " +
                                "\n   F1    F1           F1F1F1F1F1F               F1      F1 " +
                                "\n  F1    F1F1F1FF1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1        F1 " +
                                "\n F1                                                       F1 " +
                                "\n   F1F                                                     F1 " +
                                "\n F1                                                     F1F1 " +
                                "\n   F1F1F1-57-LAPS-15-TURNS-F1F1F1F1F1START1F1F1F1F1F1F1F1 " + W +
                                "\n\n                    < Length - 5.41KM >                                          ");
                                break;
                            case 1:
                                Console.WriteLine("" +
                                $"\n{N}       F1F1F " +
                                $"\n{G}      F1{N}   F1                          BAHRAIN " +
                                $"\n{G}      F1{N}     F1                      F1       F1 " +
                                $"\n{G}     F1{N}        F1F1F                F1         F1 " +
                                $"\n{G}     F1{N}             F1F1           F1           F1 " +
                                $"\n{G}     F1{N}                F1          F1            F1 " +
                                $"\n{G}    F1{N}                 F1           F1             F1 " +
                                $"\n{G}    F1{N}                  F1F1          F1F1F1        F1 " +
                                $"\n{G}   F1{N}                       F1F1            F1F      F1 " +
                                $"\n{G}   F1{N}     F({G}DZ{N})1F1F1F1F         F1             F1     F1 " +
                                $"\n{G}   F1{N}    F1           F1F1F1F1F1F               F1      F1 " +
                                $"\n{G}  F1{N}    F1{G}F1F1FF1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1{N}F1        F1 " +
                                $"\n F1                                                       F1 " +
                                $"\n   F1F                                                    ({G}DZ{N}) " +
                                $"\n F1                                                     F1F1 " +
                                $"\n   F({G}DZ{N}){G}1-57-LAPS-15-TURNS-F1F1F1F1F1START1F1F1F1F1{N}F1F1F1 " + W +
                                "\n\n                     < " + G + "DRS " + W + "Zones - 3 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" +
                                $"\n{R}       F1F1F " +
                                $"\n      F1   F1{N}                          BAHRAIN " +
                                $"\n{R}      F1     F1{N}                      F1       F1 " +
                                $"\n{R}     F1        F1{N}F1F                F1         F1 " +
                                $"\n{R}     F1{N}             F1F1           F1           F1 " +
                                $"\n{R}     F1{N}                F1          F1            F1 " +
                                $"\n{R}    F1{N}                 F1           F1             F1 " +
                                $"\n{R}    F1{N}                  F1F1          F1F1F1        F1 " +
                                $"\n{R}   F1{N}                       F1F1            F1F      F1 " +
                                $"\n{R}   F1{N}     F1F1F1F1F1F1F         F1             F1     F1 " +
                                $"\n{R}   F1{N}    F1           F1F1F1F1F1F               F1      F1 " +
                                $"\n{R}  F1{N}    F1F1F1FF1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1        F1 " +
                                $"\n{R} F1{N}                                                       F1 " +
                                $"\n{R}   F1F{N}                                                     F1 " +
                                $"\n{R} F1{N}                                                     F1F1 " +
                                $"\n{R}   F1F1F1-57-LAPS-15-TURNS-F1F1F1F1F1START{N}1F1F1F1F1F1F1F1 " + W +
                                "\n\n                       < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" +
                                $"\n{N}       F1F1F " +
                                $"\n      F1   F1                          BAHRAIN " +
                                $"\n      F1     F1                      F1       F1 " +
                                $"\n     F1        F1{B}F1F{N}                F1         F1 " +
                                $"\n     F1{B}             F1F1           F1{N}           F1 " +
                                $"\n     F1{B}                F1          F1{N}            F1 " +
                                $"\n    F1{B}                 F1           F1{N}             F1 " +
                                $"\n    F1{B}                  F1F1          F1F1F1{N}        F1 " +
                                $"\n   F1{B}                       F1F1            F1F{N}      F1 " +
                                $"\n   F1{B}     F1F1F1F1F1F1F         F1             F1{N}     F1 " +
                                $"\n   F1{B}    F1           F1F1F1F1F1F               F1{N}      F1 " +
                                $"\n  F1{B}    F1F1F1FF1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1{N}        F1 " +
                                $"\n F1                                                       F1 " +
                                $"\n   F1F                                                     F1 " +
                                $"\n F1                                                     F1F1 " +
                                $"\n   F1F1F1-57-LAPS-15-TURNS-F1F1F1F1F1START1F1F1F1F1F1F1F1 " + W +
                                "\n\n                       < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" +
                                $"\n{N}       F1F1F " +
                                $"\n      F1   F1                          {Y}BAHRAIN " +
                                $"\n{N}      F1     F1                      {Y}F1       F1 " +
                                $"\n{N}     F1        F1F1F                {Y}F1         F1 " +
                                $"\n{N}     F1             F1F1           F1{Y}           F1 " +
                                $"\n{N}     F1                F1          F1{Y}            F1 " +
                                $"\n{N}    F1                 F1           F1{Y}             F1 " +
                                $"\n{N}    F1                  F1F1          F1F1F1{Y}        F1 " +
                                $"\n{N}   F1                       F1F1            F1F{Y}      F1 " +
                                $"\n{N}   F1     F1F1F1F1F1F1F         F1             F1{Y}     F1 " +
                                $"\n{N}   F1    F1           F1F1F1F1F1F               F1{Y}      F1 " +
                                $"\n{N}  F1    F1F1F1FF1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1{Y}        F1 " +
                                $"\n{N} F1{Y}                                                       F1 " +
                                $"\n{N}   F1F{Y}                                                     F1 " +
                                $"\n{N} F1{Y}                                                     F1F1 " +
                                $"\n{N}   F1F1F1-57-LAPS-15-TURNS-F1F1F1F1F1START{Y}1F1F1F1F1F1F1F1 " + W +
                                "\n\n                       < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 1:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                                $"\n{pad}                                                                    F1F1F1 " + pad +
                                $"\n{pad}                                                                T1F1    F1 " + pad +
                                $"\n{pad}                                                            R1F1       F1 " + pad +
                                $"\n{pad}                                                         A1F           F1 " + pad +
                                $"\n{pad}                                                      T1F            F1F " + pad +
                                $"\n{pad}                                                   S1F            F1F " + pad +
                                $"\n{pad}                                               F1F1            F1F " + pad +
                                $"\n{pad}                                             F1    SAUDI-ARABIA " + pad +
                                $"\n{pad}                                        F1F1F1F1 F1 " + pad +
                                $"\n{pad}                                     F1F1    F1F1F1F1 " + pad +
                                $"\n{pad}                                  F1F1    F1F1 " + pad +
                                $"\n{pad}                           F1F1F1F     F1F1 " + pad +
                                $"\n{pad}                          F1       F1F1 " + pad +
                                $"\n{pad}          F1-50-LAPS-F1  F1   F1F1F1 " + pad +
                                $"\n{pad}      F1F1             F1   F1F " + pad +
                                $"\n{pad}  F1F1    F-27-TURNS-1    F1 " + pad +
                                $"\n{pad} F1     F1F          F1F1F1 " + pad +
                                $"\n{pad}  F1F1F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                          < Length - 6.17KM >                      \n" +
                                      P + "\n               Lap record" + W + " - 1:30.734 Lewis Hamilton (2021)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                        $"\n                                                                    F1F1F1 " +
                                        $"\n                                                                T1F1    F1 " +
                                        $"\n                                                            R1F1       F1 " +
                                        $"\n                                                         A1F           F1 " +
                                        $"\n                                                      T1F            F1F " +
                                        $"\n                                                   S1F            F1F " +
                                        $"\n                                               F1F1            F1F " +
                                        $"\n                                             F1    SAUDI-ARABIA " +
                                        $"\n                                        F1F1F1F1 F1 " +
                                        $"\n                                     F1F1    F1F1F1F1 " +
                                        $"\n                                  F1F1    F1F1 " +
                                        $"\n                           F1F1F1F     F1F1 " +
                                        $"\n                          F1       F1F1 " +
                                        $"\n          F1-50-LAPS-F1  F1   F1F1F1 " +
                                        $"\n      F1F1             F1   F1F " +
                                        $"\n  F1F1    F-27-TURNS-1    F1 " +
                                        $"\n F1     F1F          F1F1F1 " +
                                        $"\n  F1F1F1 " + W +
                                        "\n\n                          < Length - 6.17KM >              ");
                                break;
                            case 1:
                                Console.WriteLine("" +
                                        $"\n                                                                    {N}F1F1F1 " +
                                        $"\n                                                                {G}T1F1{N}    F1 " +
                                        $"\n                                                            {G}R1F1      {N}({G}DZ{N}) " +
                                        $"\n                                                         {G}A1F           F1 " +
                                        $"\n                                                      {G}T1F            F1F " +
                                        $"\n                                                   {G}S1F            F1F " +
                                        $"\n                                               {G}F1F1            F1F " +
                                        $"\n                                             {G}F1{N}    SAUDI-{G}ARABIA " +
                                        $"\n                                        {N}F1F1F1F1 F1 " +
                                        $"\n                                     F1F1{G}    F1F1{N}({G}DZ{N}) " +
                                        $"\n                                  F1F1{G}    F1F1 " +
                                        $"\n                           {N}F1F1F1F{G}     F1F1 " +
                                        $"\n                          {N}F1{G}       F1F1 " +
                                        $"\n          {N}F1-50-LAPS-F1  F1   F1F1{G}F1 " +
                                        $"\n      {N}F1F1             F1   F1F " +
                                        $"\n  F1F1    F-27-TURNS-1    F1 " +
                                        $"\n F1     F1F          F({G}DZ{N})1 " +
                                        $"\n  F1F1F1 " + W +
                                        "\n\n                           < " + G + "DRS " + W + "Zones - 3 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" +
                                        $"\n                                                                    {N}F1F1F1 " +
                                        $"\n                                                                T1F1    F1 " +
                                        $"\n                                                            R1F1       F1 " +
                                        $"\n                                                         A1F           F1 " +
                                        $"\n                                                      {R}T1F{N}            F1F " +
                                        $"\n                                                   {R}S1F{N}            F1F " +
                                        $"\n                                               {R}F1F1{N}            F1F " +
                                        $"\n                                             {R}F1{N}    SAUDI-ARABIA " +
                                        $"\n                                        {R}F1F1F1F1{N} F1 " +
                                        $"\n                                     {R}F1F1{N}    F1F1F1F1 " +
                                        $"\n                                  {R}F1F1{N}    F1F1 " +
                                        $"\n                           {R}F1F1F1F{N}     F1F1 " +
                                        $"\n                          {R}F1{N}       F1F1 " +
                                        $"\n          {R}F1-50-LAPS-F1  F1{N}   F1F1F1 " +
                                        $"\n      F1F1             {R}F1{N}   F1F " +
                                        $"\n  F1F1    F-27-TURNS-1    F1 " +
                                        $"\n F1     F1F          F1F1F1 " +
                                        $"\n  F1F1F1 " + W +
                                        "\n\n                             < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" +
                                        $"\n                                                                    {N}F1F1F1 " +
                                        $"\n                                                                T1F1    F1 " +
                                        $"\n                                                            R1F1       F1 " +
                                        $"\n                                                         A1F           F1 " +
                                        $"\n                                                      T1F            F1F " +
                                        $"\n                                                   S1F            F1F " +
                                        $"\n                                               F1F1            F1F " +
                                        $"\n                                             F1    SAUDI-ARABIA " +
                                        $"\n                                        F1F1F1F1 F1 " +
                                        $"\n                                     F1F1    {B}F1{N}F1F1F1 " +
                                        $"\n                                  F1F1{B}    F1F1 " +
                                        $"\n                           {N}F1F1F1F{B}     F1F1 " +
                                        $"\n                          {N}F1{B}       F1F1 " +
                                        $"\n          {N}F1-50-LAPS-F1  F1{B}   F1F1F1 " +
                                        $"\n      F1F1{N}             F1{B}   F1F " +
                                        $"\n  F1F1    F-27-TURNS-1    F1 " +
                                        $"\n F1     F1F          F1F1F1 " +
                                        $"\n  F1F1F1 " + W +
                                        "\n\n                             < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" +
                                        $"\n                                                                    {Y}F1F1F1 " +
                                        $"\n                                                                T1F1    F1 " +
                                        $"\n                                                            R1F1       F1 " +
                                        $"\n                                                         A1F           F1 " +
                                        $"\n                                                      {N}T1F{Y}            F1F " +
                                        $"\n                                                   {N}S1F{Y}            F1F " +
                                        $"\n                                               {N}F1F1{Y}            F1F " +
                                        $"\n                                             {N}F1{Y}    SAUDI-ARABIA " +
                                        $"\n                                        {N}F1F1F1F1{Y} F1 " +
                                        $"\n                                     {N}F1F1    F1{Y}F1F1F1 " +
                                        $"\n                                  {N}F1F1    F1F1 " +
                                        $"\n                           F1F1F1F     F1F1 " +
                                        $"\n                          F1       F1F1 " +
                                        $"\n          F1-50-LAPS-F1  F1   F1F1F1 " +
                                        $"\n      F1F1             F1   F1F " +
                                        $"\n  F1F1    F-27-TURNS-1    F1 " +
                                        $"\n F1     F1F          F1F1F1 " +
                                        $"\n  F1F1F1 " + W +
                                        "\n\n                             < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 2:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                            $"\n{pad}          F1F1F1F1 " + pad +
                            $"\n{pad}     F1F1F1      F1F1F " + pad +
                            $"\n{pad}    F1               F1F1 " + pad +
                            $"\n{pad}   F1                  F1F " + pad +
                            $"\n{pad}  F1                   F1F " + pad +
                            $"\n{pad} F1                      F1F " + pad +
                            $"\n{pad} F1                        F1               F1F1F1F1F1F1F1F1 " + pad +
                            $"\n{pad} F1                          F1F-AUSTRALIA-F1F              F1F1 " + pad +
                            $"\n{pad}  F1F1                                                          F1F1 " + pad +
                            $"\n{pad}      F1                                                         F1 " + pad +
                            $"\n{pad}     F1                                               F1F1F1    F1  " + pad +
                            $"\n{pad}    F1F1F1                                            F1   F1F1F1 " + pad +
                            $"\n{pad}          58-LAPS-14-TURNS                            F1 " + pad +
                            $"\n{pad}                         F1F1F1F1START1F1F1F1F1F1F1F1F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                       < Length - 5.28KM >                                              \n" +
                                      P + "\n           Lap record" + W + " - 1:20.260 Charles Lecler (2022)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                    $"\n          F1F1F1F1" +
                                    $"\n     F1F1F1      F1F1F" +
                                    $"\n    F1               F1F1" +
                                    $"\n   F1                  F1F" +
                                    $"\n  F1                   F1F" +
                                    $"\n F1                      F1F" +
                                    $"\n F1                        F1               F1F1F1F1F1F1F1F1" +
                                    $"\n F1                          F1F-AUSTRALIA-F1F              F1F1" +
                                    $"\n  F1F1                                                          F1F1" +
                                    $"\n      F1                                                         F1 " +
                                    $"\n     F1                                               F1F1F1    F1  " +
                                    $"\n    F1F1F1                                            F1   F1F1F1" +
                                    $"\n          58-LAPS-14-TURNS                            F1" +
                                    $"\n                         F1F1F1F1START1F1F1F1F1F1F1F1F1" + W +
                                    "\n\n                       < Length - 5.28KM >                                          ");
                                break;
                            case 1:
                                Console.WriteLine("" +
                                    $"\n{N}          F1F1F1F1" +
                                    $"\n     F1F1F1      F1F1F" +
                                    $"\n    F1               F1F1" +
                                    $"\n   F1                  F1F" +
                                    $"\n  F1                   F1F" +
                                    $"\n F1                      F1F" +
                                    $"\n F1                        F1               F1{G}F1F1F1F1F1F1F1" +
                                    $"\n{N} F1                          ({G}DZ{N})AUSTRALIA-F1F{G}              F1F1" +
                                    $"\n{N}  F1F1{G}                                                          F1{N}F1" +
                                    $"\n      F1                                                         F1 " +
                                    $"\n     F1                                               F({G}DZ{N})1    F1  " +
                                    $"\n    F1{G}F1F1{N}                                            F1   F1F1F1" +
                                    $"\n{G}          58-LAPS-14-TUR{N}NS                            F1" +
                                    $"\n                         F1{G}F1F1F1START1F1F1F1F1F1F1F1{N}F1" + W +
                                    "\n\n                        < " + G + "DRS " + W + "Zones - 3 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" +
                                    $"\n{N}          F1F1F1F1" +
                                    $"\n     F1F1F1      F1F1F" +
                                    $"\n{R}    F1{N}               F1F1" +
                                    $"\n{R}   F1{N}                  F1F" +
                                    $"\n{R}  F1{N}                   F1F" +
                                    $"\n{R} F1{N}                      F1F" +
                                    $"\n{R} F1{N}                        F1               F1F1F1F1F1F1F1F1" +
                                    $"\n{R} F1{N}                          F1F-AUSTRALIA-F1F              F1F1" +
                                    $"\n{R}  F1F1{N}                                                          F1F1" +
                                    $"\n{R}      F1{N}                                                         F1 " +
                                    $"\n{R}     F1{N}                                               F1F1F1    F1  " +
                                    $"\n{R}    F1F1F1{N}                                            F1   F1F1F1" +
                                    $"\n{R}          58-LAPS-14-TURNS{N}                            F1" +
                                    $"\n{R}                         F1F1F1F1START{N}1F1F1F1F1F1F1F1F1" + W +
                                    "\n\n                          < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" +
                                    $"\n{B}          F1F1F1F1" +
                                    $"\n{B}     F1F1F1      F1F1F" +
                                    $"\n{N}    F1{B}               F1F1" +
                                    $"\n{N}   F1{B}                  F1F" +
                                    $"\n{N}  F1{B}                   F1F" +
                                    $"\n{N} F1{B}                      F1F" +
                                    $"\n{N} F1{B}                        F1{N}               F1F1F1F1F1F1F1F1" +
                                    $"\n{N} F1{B}                          F1F-AUSTR{N}ALIA-F1F              F1F1" +
                                    $"\n  F1F1                                                          F1F1" +
                                    $"\n      F1                                                         F1 " +
                                    $"\n     F1                                               F1F1F1    F1  " +
                                    $"\n    F1F1F1                                            F1   F1F1F1" +
                                    $"\n          58-LAPS-14-TURNS                            F1" +
                                    $"\n                         F1F1F1F1START1F1F1F1F1F1F1F1F1" + W +
                                    "\n\n                          < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" +
                                    $"\n{N}          F1F1F1F1" +
                                    $"\n     F1F1F1      F1F1F" +
                                    $"\n    F1               F1F1" +
                                    $"\n   F1                  F1F" +
                                    $"\n  F1                   F1F" +
                                    $"\n F1                      F1F" +
                                    $"\n F1                        F1{Y}               F1F1F1F1F1F1F1F1" +
                                    $"\n{N} F1                          F1F-AUSTR{Y}ALIA-F1F              F1F1" +
                                    $"\n{N}  F1F1{Y}                                                          F1F1" +
                                    $"\n{N}      F1{Y}                                                         F1 " +
                                    $"\n{N}     F1{Y}                                               F1F1F1    F1  " +
                                    $"\n{N}    F1F1F1{Y}                                            F1   F1F1F1" +
                                    $"\n{N}          58-LAPS-14-TURNS{Y}                            F1" +
                                    $"\n{N}                         F1F1F1F1START{Y}1F1F1F1F1F1F1F1F1" + W +
                                    "\n\n                          < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 3:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                            $"\n{pad}                                            F1F1F1F1-AZERBAIJAN-F1F1F1F1 " + pad +
                            $"\n{pad}        F1F1F1F1F1F1                       F1                          F1 " + pad +
                            $"\n{pad}      F1           F1                      F1                          F1 " + pad +
                            $"\n{pad}    F1               F1                    F1                          F1 " + pad +
                            $"\n{pad}   F1                F1           F1F1F1F1F1                           F1 " + pad +
                            $"\n{pad}  F1                 F1F1F1F1F1F1F1                                    F1 " + pad +
                            $"\n{pad} F1                   51-LAPS-20-TURNS-F1F1F1F1F1F1F1F1F1STARTF1F1F1F1F1 " + pad +
                            $"\n{pad} F1            F1F1F1F " + pad +
                            $"\n{pad}   F1      F1F1F " + pad +
                            $"\n{pad}     F1F1F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                            < Length - 6.01KM >                                              \n" +
                                      P + "\n                Lap record" + W + " - 1:43.009 Charles Leclerc (2019)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                    $"\n                                            F1F1F1F1-AZERBAIJAN-F1F1F1F1" +
                                    $"\n        F1F1F1F1F1F1                       F1                          F1" +
                                    $"\n      F1           F1                      F1                          F1 " +
                                    $"\n    F1               F1                    F1                          F1" +
                                    $"\n   F1                F1           F1F1F1F1F1                           F1" +
                                    $"\n  F1                 F1F1F1F1F1F1F1                                    F1" +
                                    $"\n F1                   51-LAPS-20-TURNS-F1F1F1F1F1F1F1F1F1STARTF1F1F1F1F1" +
                                    $"\n F1            F1F1F1F" +
                                    $"\n   F1      F1F1F" +
                                    $"\n     F1F1F1" + W +
                                    "\n\n                            < Length - 6.01KM >           ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                    $"\n                                            F{G}1F1F1F1-AZERBAIJAN-F1F1F1F{N}1" +
                                    $"\n        F1F1F1F1F1F1                       F1                          F1" +
                                    $"\n      F1           F1                      F1                         ({G}DZ{N})" +
                                    $"\n    F1               F1                    F1                          F1" +
                                    $"\n   F1                F1           F1F1F1F1F1                           F1" +
                                    $"\n  F1                 F1F1F1F1F1F1F1                                    F1" +
                                    $"\n F1                   51-LAPS-20-T({G}DZ{N})-F1{G}F1F1F1F1F1F1F1F1STARTF1F1F1F1F{N}1" +
                                    $"\n F1            F1F1F1F" +
                                    $"\n   F1      F1F1F" +
                                    $"\n     F1F1F1" + W +
                                    "\n\n                             < " + G + "DRS " + W + "Zones - 2 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" + R +
                                    $"\n                                            F1F1F1F1-AZERBAIJAN-F1F1F1F1" +
                                    $"\n{N}        F1F1F1F1F1F1{R}                       F1                          F1" +
                                    $"\n{N}      F1           F1{R}                      F1                          F1 " +
                                    $"\n{N}    F1               F1{R}                    F1                          F1" +
                                    $"\n{N}   F1                F1           F1{R}F1F1F1F1                           F1" +
                                    $"\n{N}  F1                 F1F1F1F1F1F1F1{R}                                    F1" +
                                    $"\n{N} F1                   51-LAPS-20-TURNS-F1F1F1F1F1F1F1F1F1{R}STARTF1F1F1F1F1" +
                                    $"\n{N} F1            F1F1F1F" +
                                    $"\n   F1      F1F1F" +
                                    $"\n     F1F1F1" + W +
                                    "\n\n                               < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" + N +
                                    $"\n                                            F1F1F1F1-AZERBAIJAN-F1F1F1F1" +
                                    $"\n{B}        F1F1F1F1F1F1{N}                       F1                          F1" +
                                    $"\n{B}      F1           F1{N}                      F1                          F1" +
                                    $"\n{B}    F1               F1{N}                    F1                          F1" +
                                    $"\n{B}   F1                F1           F1{N}F1F1F1F1                           F1" +
                                    $"\n{B}  F1                 F1F1F1F1F1F1F1{N}                                    F1" +
                                    $"\n{B} F1{N}                   51-LAPS-20-TURNS-F1F1F1F1F1F1F1F1F1STARTF1F1F1F1F1" +
                                    $"\n{B} F1{N}            F1F1F1F" +
                                    $"\n{B}   F1{N}      F1F1F" +
                                    $"\n     F1F1F1" + W +
                                    "\n\n                               < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" + N +
                                    $"\n                                            F1F1F1F1-AZERBAIJAN-F1F1F1F1" +
                                    $"\n        F1F1F1F1F1F1                       F1                          F1" +
                                    $"\n      F1           F1                      F1                          F1" +
                                    $"\n    F1               F1                    F1                          F1" +
                                    $"\n   F1                F1           F1F1F1F1F1                           F1" +
                                    $"\n  F1                 F1F1F1F1F1F1F1                                    F1" +
                                    $"\n F1{Y}                   51-LAPS-20-TURNS-F1F1F1F1F1F1F1F1F1{N}STARTF1F1F1F1F1" +
                                    $"\n F1{Y}            F1F1F1F" +
                                    $"\n{N}   F1{Y}      F1F1F" +
                                    $"\n     F1F1F1" + W +
                                    "\n\n                               < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 4:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                                      $"\n{pad}       F1F1F1F1F1F1-MIAMI-F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1 " + pad +
                                      $"\n{pad}         F1F1    F1F1F1F1F1F1                                    F1 " + pad +
                                      $"\n{pad}             F1F1           F1F1FSTART                            F1 " + pad +
                                      $"\n{pad}                                     F1F1F1                  F1F1F1 " + pad +
                                      $"\n{pad}                                           F1F              F1 " + pad +
                                      $"\n{pad}                  F1F1                   F1F                  F1F1 " + pad +
                                      $"\n{pad}   F1F1F1F1    F1F1  F1F1                F1                F1F1 " + pad +
                                      $"\n{pad} F1       F1F1F1         F1F1F1         F1F            F1F1 " + pad +
                                      $"\n{pad} F1                            F1F1F1F1F1          F1F1 " + pad +
                                      $"\n{pad}  F1F1F1-57-LAPS-19-TURNS-F1F1F1F1F1           F1F1 " + pad +
                                      $"\n{pad}                                   F1F1F1F1F1F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                      < Length - 5.41KM >                                              \n" +
                                      P + "\n           Lap record" + W + " - 1:31.361 Max Verstappen (2022)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                              $"\n       F1F1F1F1F1F1-MIAMI-F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1" +
                                              $"\n         F1F1    F1F1F1F1F1F1                                    F1" +
                                              $"\n             F1F1           F1F1FSTART                            F1" +
                                              $"\n                                     F1F1F1                  F1F1F1" +
                                              $"\n                                           F1F              F1" +
                                              $"\n                  F1F1                   F1F                  F1F1" +
                                              $"\n   F1F1F1F1    F1F1  F1F1                F1                F1F1" +
                                              $"\n F1       F1F1F1         F1F1F1         F1F            F1F1" +
                                              $"\n F1                            F1F1F1F1F1          F1F1" +
                                              $"\n  F1F1F1-57-LAPS-19-TURNS-F1F1F1F1F1           F1F1" +
                                              $"\n                                   F1F1F1F1F1F1" + W +
                                              "\n\n                      < Length - 5.41KM >     ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                              $"\n       F1{G}F1F1F1F1F1-MIAMI-F1F1F1F1F1F1F1F1F1F1{N}F1F1F1F1F1F1F({G}DZ{N})1F1F1" +
                                              $"\n        ({G}DZ{N})1    F1F1F1{G}F1F1F1{N}                                    F1" +
                                              $"\n             F1F1           {G}F1F1FSTART{N}                            F1" +
                                              $"\n                                     {G}F1F1F1{N}                  F1F1F1" +
                                              $"\n                                           {G}F1F{N}              F1" +
                                              $"\n                  F1F1                   F1F{G}                  F1F1" +
                                              $"\n{N}   F1F1F1F1    F1F1  F1F1                F1{G}                F1F1" +
                                              $"\n{N} F1       F1F1F1         F1F1F1         F1F{G}            F1F1" +
                                              $"\n{N} F1                            F1F1F1F1F1{G}          F1F1" +
                                              $"\n{N}  F({G}DZ{N})1-57-LAPS-19-TURNS-F1F1{G}F1F1F1           F1F1" +
                                              $"\n                                   F1F1F1F1F1F1" + W +
                                              "\n\n                       < " + G + "DRS " + W + "Zones - 3 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" + N +
                                              $"\n       F1F1F1F1F1F1-MIAMI-F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1" +
                                              $"\n         F1F1    F1F1F1F1F1F1                                    F1" +
                                              $"\n             F1F1           F1F1F{R}START{N}                            F1" +
                                              $"\n                                     {R}F1F1F1{N}                  F1F1F1" +
                                              $"\n                                           {R}F1F{N}              F1" +
                                              $"\n                  {R}F1F1                   F1F{N}                  F1F1" +
                                              $"\n{R}   F1F1F1F1    F1F1  F1F1                F1{N}                F1F1" +
                                              $"\n{R} F1       F1F1F1         F1F1F1         F1F{N}            F1F1" +
                                              $"\n{R} F1                            F1F1F1F1F1{N}          F1F1" +
                                              $"\n{R}  F1F1F1{N}-57-LAPS-19-TURNS-F1F1F1F1F1           F1F1" +
                                              $"\n                                   F1F1F1F1F1F1" + W +
                                              "\n\n                         < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" + N +
                                              $"\n       F1F1F1F1F1F1-MIAMI-F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1{B}F1F1F1" +
                                              $"\n{N}         F1F1    F1F1F1F1F1F1{B}                                    F1" +
                                              $"\n{N}             F1F1           F1F1FSTART{B}                            F1" +
                                              $"\n{N}                                     F1F1F1{B}                  F1F1F1" +
                                              $"\n{N}                                           F1F{B}              F1" +
                                              $"\n{N}                  F1F1                   F1F{B}                  F1F1" +
                                              $"\n{N}   F1F1F1F1    F1F1  F1F1                F1{B}                F1F1" +
                                              $"\n{N} F1       F1F1F1         F1F1F1         F1F{B}            F1F1" +
                                              $"\n{N} F1                            F1F1F1F1F1{B}          F1F1" +
                                              $"\n{N}  F1F1F1{B}-57-LAPS-19-TURNS-F1F1F1F1F1           F1F1" +
                                              $"\n                                   F1F1F1F1F1F1" + W +
                                              "\n\n                         < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" + N +
                                              $"\n{Y}       F1F1F1F1F1F1-MIAMI-F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1{N}F1F1F1" +
                                              $"\n{Y}         F1F1    F1F1F1F1F1F1{N}                                    F1" +
                                              $"\n{Y}             F1F1           F1F1F{N}START                            F1" +
                                              $"\n                                     F1F1F1                  F1F1F1" +
                                              $"\n                                           F1F              F1" +
                                              $"\n                  F1F1                   F1F                  F1F1" +
                                              $"\n   F1F1F1F1    F1F1  F1F1                F1                F1F1" +
                                              $"\n F1       F1F1F1         F1F1F1         F1F            F1F1" +
                                              $"\n F1                            F1F1F1F1F1          F1F1" +
                                              $"\n  F1F1F1-57-LAPS-19-TURNS-F1F1F1F1F1           F1F1" +
                                              $"\n                                   F1F1F1F1F1F1" + W +
                                              "\n\n                         < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 5:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                                      $"\n{pad}                                                           F1F " + pad +
                                      $"\n{pad}                F1-EMILIA-ROMAGNA-F1F1                  F1F   F1 " + pad +
                                      $"\n{pad}               F1                     F1F1F1F1STAR1TF1F1       F1F " + pad +
                                      $"\n{pad}            F1F1                                            F1F " + pad +
                                      $"\n{pad}           F1                                            F1F " + pad +
                                      $"\n{pad}          F1                                          F1F " + pad +
                                      $"\n{pad}         F1                                        F1F1 " + pad +
                                      $"\n{pad}        F1              F-63-LAPS-19-TURNS-F1 F1F1F " + pad +
                                      $"\n{pad}       F1              F1                   F1 " + pad +
                                      $"\n{pad}      F1               F1 " + pad +
                                      $"\n{pad}       F1             F1 " + pad +
                                      $"\n{pad}        F1             F1 " + pad +
                                      $"\n{pad}    F1F1                F1 " + pad +
                                      $"\n{pad}  F1F                  F1 " + pad +
                                      $"\n{pad} F1F1F1F1F1F1F1F1F1F1F1F " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                      < Length - 4.91KM >                      \n" +
                                      P + "\n          Lap record" + W + " - 1:15.484 Lewis Hamilton (2020)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                              $"\n                                                           F1F " +
                                              $"\n                F1-EMILIA-ROMAGNA-F1F1                  F1F   F1 " +
                                              $"\n               F1                     F1F1F1F1START1F1F1       F1F " +
                                              $"\n            F1F1                                            F1F " +
                                              $"\n           F1                                            F1F " +
                                              $"\n          F1                                          F1F " +
                                              $"\n         F1                                        F1F1 " +
                                              $"\n        F1              F-63-LAPS-19-TURNS-F1 F1F1F " +
                                              $"\n       F1              F1                   F1 " +
                                              $"\n      F1               F1 " +
                                              $"\n       F1             F1 " +
                                              $"\n        F1             F1 " +
                                              $"\n    F1F1                F1 " +
                                              $"\n  F1F                  F1 " +
                                              $"\n F1F1F1F1F1F1F1F1F1F1F1F " + W +
                                              "\n\n                      < Length - 4.91KM >        ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                              $"\n                                                           F1F " +
                                              $"\n                F{G}1-EMILIA-ROMAGNA-F1F1{N}                  F1F   F1 " +
                                              $"\n               F1{G}                     F1F1F1F1START1F1{N}F1       F1F " +
                                              $"\n            F1F1                                            F1F " +
                                              $"\n           F1                                            F1F " +
                                              $"\n          F1                                          ({G}DZ{N}) " +
                                              $"\n         F1                                        F1F1 " +
                                              $"\n        F1              F-63-LAPS-19-TURNS-F1 F1F1F " +
                                              $"\n       F1              F1                   F1 " +
                                              $"\n      F1               F1 " +
                                              $"\n       F1             F1 " +
                                              $"\n        F1             F1 " +
                                              $"\n    F1F1                F1 " +
                                              $"\n  F1F                  F1 " +
                                              $"\n F1F1F1F1F1F1F1F1F1F1F1F " + W +
                                              "\n\n                       < " + G + "DRS " + W + "Zones - 1 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" + N +
                                              $"\n                                                           F1F " +
                                              $"\n{R}                F1-EMILIA-ROMAGNA-F1F1{N}                  F1F   F1 " +
                                              $"\n{R}               F1                     F1F1F1F1START{N}1F1F1       F1F " +
                                              $"\n{R}            F1F1{N}                                            F1F " +
                                              $"\n{R}           F1{N}                                            F1F " +
                                              $"\n{R}          F1{N}                                          F1F " +
                                              $"\n{R}         F1{N}                                        F1F1 " +
                                              $"\n{R}        F1{N}              F-63-LAPS-19-TURNS-F1 F1F1F " +
                                              $"\n{R}       F1{N}              F1                   F1 " +
                                              $"\n{R}      F1{N}               F1 " +
                                              $"\n{R}       F1{N}             F1 " +
                                              $"\n{R}        F1{N}             F1 " +
                                              $"\n{R}    F1F1{N}                F1 " +
                                              $"\n  F1F                  F1 " +
                                              $"\n F1F1F1F1F1F1F1F1F1F1F1F " + W +
                                              "\n\n                         < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" + N +
                                              $"\n                                                           F1F " +
                                              $"\n                F1-EMILIA-ROMAGNA-F1F1                  F1F   F1 " +
                                              $"\n               F1                     F1F1F1F1START1F1F1       F1F " +
                                              $"\n            F1F1                                            F1F " +
                                              $"\n           F1                                            F1F " +
                                              $"\n          F1                                          F1F " +
                                              $"\n         F1                                        F1F1 " +
                                              $"\n        F1{B}              F-63-LAPS-19-{N}TURNS-F1 F1F1F " +
                                              $"\n       F1{B}              F1{N}                   F1 " +
                                              $"\n      F1{B}               F1{N} " +
                                              $"\n       F1{B}             F1{N} " +
                                              $"\n        F1{B}             F1{N} " +
                                              $"\n    F1F1{B}                F1 " +
                                              $"\n  F1F                  F1 " +
                                              $"\n F1F1F1F1F1F1F1F1F1F1F1F " + W +
                                              "\n\n                         < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" + Y +
                                              $"\n                                                           F1F{N} " +
                                              $"\n                F1-EMILIA-ROMAGNA-F1F1{Y}                  F1F   F1{N} " +
                                              $"\n               F1                     F1F1F1F1START{Y}1F1F1       F1F{N} " +
                                              $"\n            F1F1{Y}                                            F1F{N} " +
                                              $"\n           F1{Y}                                            F1F{N} " +
                                              $"\n          F1{Y}                                          F1F{N} " +
                                              $"\n         F1{Y}                                        F1F1{N} " +
                                              $"\n        F1              F-63-LAPS-19-{Y}TURNS-F1 F1F1F{N} " +
                                              $"\n       F1              F1{Y}                   F1{N} " +
                                              $"\n      F1               F1 " +
                                              $"\n       F1             F1 " +
                                              $"\n        F1             F1 " +
                                              $"\n    F1F1                F1 " +
                                              $"\n  F1F                  F1 " +
                                              $"\n F1F1F1F1F1F1F1F1F1F1F1F " + W +
                                              "\n\n                         < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 6:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                                      $"\n{pad}                                                    F1F1F1F1 " + pad +
                                      $"\n{pad}                                                 F1F1    F1  F1F1 " + pad +
                                      $"\n{pad}                                             F1F1        F1 F1  F1 " + pad +
                                      $"\n{pad}          MONACO                             F1           F1   F1 " + pad +
                                      $"\n{pad}        F1     F1F1F1F1                       F1             F1 " + pad +
                                      $"\n{pad}       T1             F1F1-19-TURNS-F1F1      F1           F1 " + pad +
                                      $"\n{pad}      R1   F1F1F1F1F1                  F1F1F1F1        F1F1 " + pad +
                                      $"\n{pad}     A1   F1        F1F1F1F1 F1F1F1F1F1           F1F1F1 " + pad +
                                      $"\n{pad}    T1    F1                F1        F1-78-LAPS-F1 " + pad +
                                      $"\n{pad}   S1    F1 " + pad +
                                      $"\n{pad}  F1    F1 " + pad +
                                      $"\n{pad} F1   F1F1 " + pad +
                                      $"\n{pad} F1  F1 " + pad +
                                      $"\n{pad} F1   F1 " + pad +
                                      $"\n{pad}  F1   F1F " + pad +
                                      $"\n{pad} F1F1F1F1F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                      < Length - 3.34KM >                                              \n" +
                                      P + "\n          Lap record" + W + " - 1:12.909 Lewis Hamilton (2021)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                              $"\n                                                    F1F1F1F1 " +
                                              $"\n                                                 F1F1    F1  F1F1 " +
                                              $"\n                                             F1F1        F1 F1  F1 " +
                                              $"\n          MONACO                             F1           F1   F1 " +
                                              $"\n        F1     F1F1F1F1                       F1             F1 " +
                                              $"\n       T1             F1F1-19-TURNS-F1F1      F1           F1 " +
                                              $"\n      R1   F1F1F1F1F1                  F1F1F1F1        F1F1 " +
                                              $"\n     A1   F1        F1F1F1F1 F1F1F1F1F1           F1F1F1 " +
                                              $"\n    T1    F1                F1        F1-78-LAPS-F1 " +
                                              $"\n   S1    F1 " +
                                              $"\n  F1    F1 " +
                                              $"\n F1   F1F1 " +
                                              $"\n F1  F1 " +
                                              $"\n F1   F1 " +
                                              $"\n  F1   F1F " +
                                              $"\n F1F1F1F1F1 " + W +
                                              "\n\n                      < Length - 3.34KM >  ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                              $"\n                                                    F1F1F1F1 " +
                                              $"\n                                                 F1F1    F1  F1F1 " +
                                              $"\n                                             F1F1        F1 F1  F1 " +
                                              $"\n          MONACO                             F1           F1   F1 " +
                                              $"\n{G}        F1{N}     F1F1F1F1                       F1             F1 " +
                                              $"\n{G}       T1{N}             F1F1-19-TURNS-F1F1      F1           F1 " +
                                              $"\n{G}      R1{N}   F1F1F1F1F1                  F1F1F1F1        F1F1 " +
                                              $"\n{G}     A1{N}   F1        F1F1F1F1 F1F1F1F1F1           F1F1F1 " +
                                              $"\n{G}    T1{N}    F1                F1        F1-78-LAPS-F1 " +
                                              $"\n{G}   S1{N}    F1 " +
                                              $"\n{G}  F1{N}    F1 " +
                                              $"\n{G} F1{N}   F1F1 " +
                                              $"\n{G} F1{N}  F1 " +
                                              $"\n{G} F1{N}  ({G}DZ{N}) " +
                                              $"\n  F1   F1F " +
                                              $"\n F1F1F1F1F1 " + W +
                                              "\n\n                       < " + G + "DRS " + W + "Zones - 1 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" + R +
                                              $"\n                                                    F1F1{N}F1F1 " +
                                              $"\n{R}                                                 F1F1{N}    F1  F1F1 " +
                                              $"\n{R}                                             F1F1{N}        F1 F1  F1 " +
                                              $"\n{R}          MONACO                             F1{N}           F1   F1 " +
                                              $"\n{R}        F1     F1F1F1F1                       F1{N}             F1 " +
                                              $"\n{R}       T1             F1F1-19-TURNS-F1F1      F1{N}           F1 " +
                                              $"\n{R}      R1{N}   F1F1F1F1F1{R}                  F1F1F1F1{N}        F1F1 " +
                                              $"\n{R}     A1{N}   F1        F1F1F1F1 F1F1F1F1F1           F1F1F1 " +
                                              $"\n{R}    T1{N}    F1                F1        F1-78-LAPS-F1 " +
                                              $"\n{R}   S1{N}    F1 " +
                                              $"\n  F1    F1 " +
                                              $"\n F1   F1F1 " +
                                              $"\n F1  F1 " +
                                              $"\n F1   F1 " +
                                              $"\n  F1   F1F " +
                                              $"\n F1F1F1F1F1 " + W +
                                              "\n\n                         < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" +
                                              $"\n                                                    F1F1{B}F1F1{N} " +
                                              $"\n                                                 F1F1{B}    F1  F1F1{N} " +
                                              $"\n                                             F1F1{B}        F1 F1  F1{N} " +
                                              $"\n          MONACO                             F1{B}           F1   F1{N} " +
                                              $"\n        F1     F1F1F1F1                       F1{B}             F1{N} " +
                                              $"\n       T1             F1F1-19-TURNS-F1F1      F1{B}           F1{N} " +
                                              $"\n      R1{B}   F1F1F1F1F1{N}                  F1F1F1F1{B}        F1F1{N} " +
                                              $"\n     A1   F1{B}        F1F1F1F1 F1F1F1F1F1           F1F1F1{N} " +
                                              $"\n    T1    F1{B}                F1        F1-78-LAPS-F1{N} " +
                                              $"\n   S1    F1 " +
                                              $"\n  F1    F1 " +
                                              $"\n F1   F1F1 " +
                                              $"\n F1  F1 " +
                                              $"\n F1   F1 " +
                                              $"\n  F1   F1F " +
                                              $"\n F1F1F1F1F1 " + W +
                                              "\n\n                         < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" + N +
                                              $"\n                                                    F1F1F1F1 " +
                                              $"\n                                                 F1F1    F1  F1F1 " +
                                              $"\n                                             F1F1        F1 F1  F1 " +
                                              $"\n          MONACO                             F1           F1   F1 " +
                                              $"\n        F1     F1F1F1F1                       F1             F1 " +
                                              $"\n       T1             F1F1-19-TURNS-F1F1      F1           F1 " +
                                              $"\n      R1   F1F1F1F1F1                  F1F1F1F1        F1F1 " +
                                              $"\n     A1{Y}   F1{N}        F1F1F1F1 F1F1F1F1F1           F1F1F1 " +
                                              $"\n    T1{Y}    F1{N}                F1        F1-78-LAPS-F1 " +
                                              $"\n   S1{Y}    F1 " +
                                              $"\n  F1    F1 " +
                                              $"\n F1   F1F1 " +
                                              $"\n F1  F1 " +
                                              $"\n F1   F1 " +
                                              $"\n  F1   F1F " +
                                              $"\n F1F1F1F1F1 " + W +
                                              "\n\n                         < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 7:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                            $"\n{pad}    F1-66-LAPS-16-TURNS-F1        F1F1                SPAIN " + pad +
                            $"\n{pad}  F1F                   F1      F1F   F1F1          F1     F1F1 " + pad +
                            $"\n{pad} F1        F1F1F1F1F1F1F1     F1F         F1F1        F1F1    F1 " + pad +
                            $"\n{pad} F1       F1                F1F               F1F1        F1  F1 " + pad +
                            $"\n{pad}  F1F1F1    F1F            F1                     F1F1     F1  F1F1 " + pad +
                            $"\n{pad}       F1F1   F1F1F1F1F1F1F1                          F1F1F1      F1 " + pad +
                            $"\n{pad}          F1                                                     F1 " + pad +
                            $"\n{pad}          F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START1F1F1F1F1F1F1F1F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                         < Length - 4.68KM >                                              \n" +
                                      P + "\n             Lap record" + W + " - 1:18.149 Max Verstappen (2021)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                    "\n    F1-66-LAPS-16-TURNS-F1        F1F1                SPAIN " +
                                    "\n  F1F                   F1      F1F   F1F1          F1     F1F1 " +
                                    "\n F1        F1F1F1F1F1F1F1     F1F         F1F1        F1F1    F1 " +
                                    "\n F1       F1                F1F               F1F1        F1  F1 " +
                                    "\n  F1F1F1    F1F            F1                     F1F1     F1  F1F1 " +
                                    "\n       F1F1   F1F1F1F1F1F1F1                          F1F1F1      F1 " +
                                    "\n          F1                                                     F1 " +
                                    "\n          F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START1F1F1F1F1F1F1F1F1 " + W +
                                    "\n\n                         < Length - 4.68KM >               ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                    $"\n    F1-66-LAPS-16-TURNS-F1        F1F1                SPAIN " +
                                    $"\n  F1F                   F1      F1F{G}   F1F1{N}          F1     F1F1 " +
                                    $"\n F1        F1F1F1F1F1F1F1    ({G}DZ{N}){G}         F1F1{N}        F1F1    F1 " +
                                    $"\n F1       F1                F1F{G}               F1F1{N}        F1  F1 " +
                                    $"\n  F1F1F1    F1F            F1{G}                     F1F1{N}     F1  F1F1 " +
                                    $"\n       F1F1   F1F1F1F1F1F1F1{G}                          F1F{N}1F1     ({G}DZ{N}) " +
                                    $"\n          F1                                                     F1 " +
                                    $"\n          F1F1{G}F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START1F1F1F1F1{N}F1F1F1F1 " + W +
                                    "\n\n                          < " + G + "DRS " + W + "Zones - 2 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" + R +
                                    $"\n    F1-66-LAPS-16-{N}TURNS-F1        F1F1                SPAIN " +
                                    $"\n{R}  F1F{N}                   F1      F1F   F1F1          F1     F1F1 " +
                                    $"\n{R} F1{N}        F1F1F1F1F1F1F1     F1F         F1F1        F1F1    F1 " +
                                    $"\n{R} F1{N}       F1                F1F               F1F1        F1  F1 " +
                                    $"\n{R}  F1F1F1{N}    F1F            F1                     F1F1     F1  F1F1 " +
                                    $"\n{R}       F1F1{N}   F1F1F1F1F1F1F1                          F1F1F1      F1 " +
                                    $"\n{R}          F1{N}                                                     F1 " +
                                    $"\n{R}          F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START{N}1F1F1F1F1F1F1F1F1 " + W +
                                    "\n\n                            < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" + N +
                                    $"\n    F1-66-LAPS-16-{B}TURNS-F1        F1F1{N}                SPAIN " +
                                    $"\n  F1F{B}                   F1      F1F   F1F1{N}          F1     F1F1 " +
                                    $"\n F1{B}        F1F1F1F1F1F1F1     F1F         F1F1{N}        F1F1    F1 " +
                                    $"\n F1{B}       F1                F1F               F1F1{N}        F1  F1 " +
                                    $"\n  F1F1F1{B}    F1F            F1                     F1F1{N}     F1  F1F1 " +
                                    $"\n       F1F1{B}   F1F1F1F1F1F1F1{N}                          F1F1F1      F1 " +
                                    $"\n          F1                                                     F1 " +
                                    $"\n          F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START1F1F1F1F1F1F1F1F1 " + W +
                                    "\n\n                            < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" +
                                    $"\n    F1-66-LAPS-16-TURNS-F1        F1F1{Y}                SPAIN {N}" +
                                    $"\n  F1F                   F1      F1F   F1F1{Y}          F1     F1F1 {N}" +
                                    $"\n F1        F1F1F1F1F1F1F1     F1F         F1F1{Y}        F1F1    F1 {N}" +
                                    $"\n F1       F1                F1F               F1F1{Y}        F1  F1 {N}" +
                                    $"\n  F1F1F1    F1F            F1                     F1F1{Y}     F1  F1F1 {N}" +
                                    $"\n       F1F1   F1F1F1F1F1F1F1{Y}                          F1F1F1      F1 {N}" +
                                    $"\n          F1{Y}                                                     F1 {N}" +
                                    $"\n          F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START{Y}1F1F1F1F1F1F1F1F1 " + W +
                                    "\n\n                            < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 8:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                            $"\n{pad} F1-CANADA-1F1F1F1F1F1 " + pad +
                            $"\n{pad}  F1F1F1F1           F-70-LAPS-1 " + pad +
                            $"\n{pad}         F1F1F1F1              F-14-TURNS-1 " + pad +
                            $"\n{pad}                F1F1                      F1F1F1F1 " + pad +
                            $"\n{pad}                   F1F                          F1F1F1F1FSTART " + pad +
                            $"\n{pad}                     F1                                      F1F1F1  F1F " + pad +
                            $"\n{pad}                     F1F1                                          F1  F1 " + pad +
                            $"\n{pad}                        F1F1                                          F1 " + pad +
                            $"\n{pad}                            F1F1F1                       F1F1     F1F1 " + pad +
                            $"\n{pad}                                 F1F1F1   F1F1   F1F1F1F1   F1F1F1 " + pad +
                            $"\n{pad}                                      F1F1F1  F1F1 " + pad);

                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                          < Length - 4.36KM >                                              \n" +
                                      P + "\n              Lap record" + W + " - 1:13.078 Valtteri Bottas (2019)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                    $"\n F1-CANADA-1F1F1F1F1F1 " +
                                    $"\n  F1F1F1F1           F-70-LAPS-1 " +
                                    $"\n         F1F1F1F1              F-14-TURNS-1 " +
                                    $"\n                F1F1                      F1F1F1F1 " +
                                    $"\n                   F1F                          F1F1F1F1FSTART " +
                                    $"\n                     F1                                      F1F1F1  F1F " +
                                    $"\n                     F1F1                                          F1  F1 " +
                                    $"\n                        F1F1                                          F1 " +
                                    $"\n                            F1F1F1                       F1F1     F1F1 " +
                                    $"\n                                 F1F1F1   F1F1   F1F1F1F1   F1F1F1 " +
                                    $"\n                                      F1F1F1  F1F1 " + W +
                                    "\n\n                          < Length - 4.36KM >      ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                    $"\n F1-CANADA-1F1{G}F1F1F1F1{N} " +
                                    $"\n  F1F1F1F1{G}           F-70-LAPS-1{N} " +
                                    $"\n         F1F1F1F1{G}              F-14-TURNS{N}-1 " +
                                    $"\n                ({G}DZ{N})                      F1{G}F1F1F1{N} " +
                                    $"\n                   F1F{G}                          F1F1F1F1FSTART{N} " +
                                    $"\n                     F1{G}                                      F1F1{N}F1  F1F " +
                                    $"\n{G}                     F1F1{N}                                          F1  F1 " +
                                    $"\n{G}                        F1F1{N}                                          F1 " +
                                    $"\n{G}                            F1F1F1{N}                       F1F1     F1F1 " +
                                    $"\n{G}                                 F1F1F1{N}   F1F1   F({G}DZ{N})1F1   F1F1F1 " +
                                    $"\n{G}                                      F1F1{N}F1  F1F1 " + W +
                                    "\n\n                           < " + G + "DRS " + W + "Zones - 3 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" + N +
                                    $"\n F1-CANADA-1F1F1F1F1F1 " +
                                    $"\n  F1F1F1F1           F-70-LAPS-1 " +
                                    $"\n         F1F1F1F1              F-14-TURNS-1 " +
                                    $"\n                F1F1                      F1F1F1F1 " +
                                    $"\n                   F1F                          F1F1F1F1F{R}START{N} " +
                                    $"\n                     F1{R}                                      F1F1F1  F1F{N} " +
                                    $"\n                     F1F1{R}                                          F1  F1{N} " +
                                    $"\n                        F1F1{R}                                          F1{N} " +
                                    $"\n                            F1F1F1{R}                       F1F1     F1F1{N} " +
                                    $"\n                                 F1F1F1   F1{R}F1   F1F1F1F1   F1F1F1{N} " +
                                    $"\n                                      F1F1F1{R}  F1F1 " + W +
                                    "\n\n                             < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" + N +
                                    $"\n F1-CANADA-1F1F1F1F1F1 " +
                                    $"\n  F1F1F1F1           F-70-LAPS-1 " +
                                    $"\n{B}         F1F1F1F1{N}              F-14-TURNS-1 " +
                                    $"\n{B}                F1F1{N}                      F1F1F1F1 " +
                                    $"\n{B}                   F1F{N}                          F1F1F1F1FSTART " +
                                    $"\n{B}                     F1{N}                                      F1F1F1  F1F " +
                                    $"\n{B}                     F1F1{N}                                          F1  F1 " +
                                    $"\n{B}                        F1F1{N}                                          F1 " +
                                    $"\n{B}                            F1F1F1{N}                       F1F1     F1F1 " +
                                    $"\n{B}                                 F1F1F1   F1{N}F1   F1F1F1F1   F1F1F1 " +
                                    $"\n{B}                                      F1F1F1{N}  F1F1 " + W +
                                    "\n\n                             < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" + Y +
                                    $"\n F1-CANADA-1F1F1F1F1F1{N} " +
                                    $"\n{Y}  F1F1F1F1           F-70-LAPS-1{N} " +
                                    $"\n         F1F1F1F1{Y}              F-14-TURNS-1{N} " +
                                    $"\n                F1F1{Y}                      F1F1F1F1{N} " +
                                    $"\n                   F1F{Y}                          F1F1F1F1F{N}START " +
                                    $"\n                     F1                                      F1F1F1  F1F " +
                                    $"\n                     F1F1                                          F1  F1 " +
                                    $"\n                        F1F1                                          F1 " +
                                    $"\n                            F1F1F1                       F1F1     F1F1 " +
                                    $"\n                                 F1F1F1   F1F1   F1F1F1F1   F1F1F1 " +
                                    $"\n                                      F1F1F1  F1F1 " + W +
                                    "\n\n                             < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 9:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                            $"\n{pad} F1F1-AUSTRIA-1F1F1F1F1F1 " + pad +
                            $"\n{pad}  F1F                   F1F1F1F1F1F1F1F1F1 " + pad +
                            $"\n{pad}    F1F                                  F1 " + pad +
                            $"\n{pad}       F1F                            F1F1 " + pad +
                            $"\n{pad}         F1F         F1F1F1F1F1F1F1F1F1 " + pad +
                            $"\n{pad}           F1F     F1F " + pad +
                            $"\n{pad}             F1    F1 " + pad +
                            $"\n{pad}              F1    F1          F1-71-LAPS-10-TURNS-F1F1F1F1F1F1 " + pad +
                            $"\n{pad}               F1     F1      F1                               F1 " + pad +
                            $"\n{pad}                F1      F1F1F1                                  F1 " + pad +
                            $"\n{pad}                 F1F                                             F1 " + pad +
                            $"\n{pad}                   F1F                                         F1F1 " + pad +
                            $"\n{pad}                     F1F                               F1F1F1F1 " + pad +
                            $"\n{pad}                       F1F                     F1F1F1F1 " + pad +
                            $"\n{pad}                         F1          F1F1FSTART " + pad +
                            $"\n{pad}                           F1F1F1F1F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                    < Length - 4.32KM >\n" +
                                      P + "\n        Lap record" + W + " - 1:06.957 Kimi Raikkonen (2018)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                    $"\n F1F1-AUSTRIA-1F1F1F1F1F1 " +
                                    $"\n  F1F                   F1F1F1F1F1F1F1F1F1 " +
                                    $"\n    F1F                                  F1 " +
                                    $"\n       F1F                            F1F1 " +
                                    $"\n         F1F         F1F1F1F1F1F1F1F1F1 " +
                                    $"\n           F1F     F1F " +
                                    $"\n             F1    F1 " +
                                    $"\n              F1    F1          F1-71-LAPS-10-TURNS-F1F1F1F1F1F1 " +
                                    $"\n               F1     F1      F1                               F1 " +
                                    $"\n                F1      F1F1F1                                  F1 " +
                                    $"\n                 F1F                                             F1 " +
                                    $"\n                   F1F                                         F1F1 " +
                                    $"\n                     F1F                               F1F1F1F1 " +
                                    $"\n                       F1F                     F1F1F1F1 " +
                                    $"\n                         F1          F1F1FSTART " +
                                    $"\n                           F1F1F1F1F1 " + W +
                                    "\n\n                    < Length - 4.32KM >  ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                    $"\n F1F1{G}-AUSTRIA-1F1F1F1F1F1{N} " +
                                    $"\n  F1F{G}                   F1F1F1F1F1F1F1F1{N}F1 " +
                                    $"\n    ({G}DZ{N})                                 F1 " +
                                    $"\n{G}       F1F{N}                            F1F1 " +
                                    $"\n{G}         F1F{N}         F1F1F1F1F1F1F1F1F1 " +
                                    $"\n{G}           F1F{N}     F1F " +
                                    $"\n{G}             F1{N}    F1 " +
                                    $"\n{G}              F1{N}    F1          F1-71-LAPS-10-TURNS-F1F1F1F1F1F1 " +
                                    $"\n{G}               F1{N}     F1      F1                              ({G}DZ{N}) " +
                                    $"\n{G}                F1{N}      F1F1F1                                  F1 " +
                                    $"\n{G}                 F1F{N}                                             F1 " +
                                    $"\n{G}                   F1F{N}                                         F1F1 " +
                                    $"\n{G}                     F1F                               F1F1F1F1 " +
                                    $"\n                       F1F                     F1F1F1F1 " +
                                    $"\n{N}                         F1{G}          F1F1FSTART{N} " +
                                    $"\n                           F1{G}F1{N}({G}DZ{N}){G}F1 " + W +
                                    "\n\n                     < " + G + "DRS " + W + "Zones - 3 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" + N +
                                    $"\n F1F1-AUSTRIA-1F1F1F1F1F1 " +
                                    $"\n  F1F                   F1F1F1F1F1F1F1F1F1 " +
                                    $"\n    F1F                                  F1 " +
                                    $"\n{R}       F1F{N}                            F1F1 " +
                                    $"\n{R}         F1F{N}         F1F1F1F1F1F1F1F1F1 " +
                                    $"\n{R}           F1F{N}     F1F " +
                                    $"\n{R}             F1{N}    F1 " +
                                    $"\n{R}              F1{N}    F1          F1-71-LAPS-10-TURNS-F1F1F1F1F1F1 " +
                                    $"\n{R}               F1{N}     F1      F1                               F1 " +
                                    $"\n{R}                F1{N}      F1F1F1                                  F1 " +
                                    $"\n{R}                 F1F{N}                                             F1 " +
                                    $"\n{R}                   F1F{N}                                         F1F1 " +
                                    $"\n{R}                     F1F{N}                               F1F1F1F1 " +
                                    $"\n{R}                       F1F{N}                     F1F1F1F1 " +
                                    $"\n{R}                         F1          F1F1FSTART " +
                                    $"\n                           F1F1F1F1F1 " + W +
                                    "\n\n                       < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" + B +
                                    $"\n F1F1-AUSTRIA-1F1F1F1F1F1 " +
                                    $"\n  F1F                   F1F1F1F1F1F1F1F1F1 " +
                                    $"\n    F1F                                  F1 " +
                                    $"\n{N}       F1F{B}                            F1F1 " +
                                    $"\n{N}         F1F{B}         F1F1F1F1F1F1F1F1F1 " +
                                    $"\n{N}           F1F{B}     F1F " +
                                    $"\n{N}             F1{B}    F1 " +
                                    $"\n{N}              F1{B}    F1{N}          F1-71-LAPS-10-TURNS-F1F1F1F1F1F1 " +
                                    $"\n               F1{B}     F1{N}      F1                               F1 " +
                                    $"\n                F1      F1F1F1                                  F1 " +
                                    $"\n                 F1F                                             F1 " +
                                    $"\n                   F1F                                         F1F1 " +
                                    $"\n                     F1F                               F1F1F1F1 " +
                                    $"\n                       F1F                     F1F1F1F1 " +
                                    $"\n                         F1          F1F1FSTART " +
                                    $"\n                           F1F1F1F1F1 " + W +
                                    "\n\n                       < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" + N +
                                    $"\n F1F1-AUSTRIA-1F1F1F1F1F1 " +
                                    $"\n  F1F                   F1F1F1F1F1F1F1F1F1 " +
                                    $"\n    F1F                                  F1 " +
                                    $"\n       F1F                            F1F1 " +
                                    $"\n         F1F         F1F1F1F1F1F1F1F1F1 " +
                                    $"\n           F1F     F1F " +
                                    $"\n             F1    F1 " +
                                    $"\n              F1    F1{Y}          F1-71-LAPS-10-TURNS-F1F1F1F1F1F1{N} " +
                                    $"\n               F1     F1{Y}      F1                               F1{N} " +
                                    $"\n                F1{Y}      F1F1F1                                  F1{N} " +
                                    $"\n                 F1F{Y}                                             F1{N} " +
                                    $"\n                   F1F{Y}                                         F1F1{N} " +
                                    $"\n                     F1F{Y}                               F1F1F1F1{N} " +
                                    $"\n                       F1F{Y}                     F1F1F1F1{N} " +
                                    $"\n                         F1          F1F1FSTART " +
                                    $"\n                           F1F1F1F1F1 " + W +
                                    "\n\n                       < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 10:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                        $"\n{pad}             F1F1F1F1F1 " + pad +
                        $"\n{pad}            F1        START " + pad +
                        $"\n{pad}             F1F          F1F1                         F-UK-1 " + pad +
                        $"\n{pad}           F1                F1F1                     F1    F1F1 " + pad +
                        $"\n{pad}       F1F1                     F1F1                   F1F1    F1F " + pad +
                        $"\n{pad}   F1F1                            F1                     F1     F1 " + pad +
                        $"\n{pad} F1                                F1                     F1     F1 " + pad +
                        $"\n{pad} F1                                F1                  F1F1      F1 " + pad +
                        $"\n{pad}   F1F1                            F1                F1F         F1 " + pad +
                        $"\n{pad}      F1F1                          F1             F1F           F1 " + pad +
                        $"\n{pad}          F1F1F1                      F1         F1F              F1 " + pad +
                        $"\n{pad}                F1F1                    F1     F1F                F1 " + pad +
                        $"\n{pad}                    F1F1            F1F1     F1F                  F1 " + pad +
                        $"\n{pad}                        F1F1F         F1F1F1F1                    F1 " + pad +
                        $"\n{pad}                             F1F                        F-52-LAPS-1 " + pad +
                        $"\n{pad}                               F1F1   F1F1   F-18-TURNS-1 " + pad +
                        $"\n{pad}                                  F1F1   F1F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                             < Length - 5.89KM >                  \n" +
                                      P + "\n                 Lap record" + W + " - 1:27.369 Lewis Hamilton (2019)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                $"\n             F1F1F1F1F1 " +
                                $"\n            F1        START " +
                                $"\n             F1F          F1F1                         F-UK-1 " +
                                $"\n           F1                F1F1                     F1    F1F1 " +
                                $"\n       F1F1                     F1F1                   F1F1    F1F " +
                                $"\n   F1F1                            F1                     F1     F1 " +
                                $"\n F1                                F1                     F1     F1 " +
                                $"\n F1                                F1                  F1F1      F1 " +
                                $"\n   F1F1                            F1                F1F         F1 " +
                                $"\n      F1F1                          F1             F1F           F1 " +
                                $"\n          F1F1F1                      F1         F1F              F1 " +
                                $"\n                F1F1                    F1     F1F                F1 " +
                                $"\n                    F1F1            F1F1     F1F                  F1 " +
                                $"\n                        F1F1F         F1F1F1F1                    F1 " +
                                $"\n                             F1F                        F-52-LAPS-1 " +
                                $"\n                               F1F1   F1F1   F-18-TURNS-1 " +
                                $"\n                                  F1F1   F1F1  " + W +
                                "\n\n                             < Length - 5.89KM >                        ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                $"\n             F1F1F1F1F1 " +
                                $"\n            F1        START " +
                                $"\n             F1F          F1F1                         F-UK-1 " +
                                $"\n           F1                F1F1                     F1    F1F1 " +
                                $"\n       F1F1                     F1F1                   F1F1    F1F " +
                                $"\n   F1F1                            F1                     F1     F1 " +
                                $"\n F1                                F1                     F1     F1 " +
                                $"\n F1                                F1                  {G}F1F1{N}      F1 " +
                                $"\n   {G}F1F1{N}                            F1                {G}F1F{N}         F1 " +
                                $"\n      {G}F1F1{N}                          F1             {G}F1F{N}           F1 " +
                                $"\n          {G}F1F1F1{N}                     ({G}DZ{N})        {G}F1F{N}              F1 " +
                                $"\n                {G}F1F1{N}                    F1     {G}F1F{N}                F1 " +
                                $"\n                    {G}F1F1{N}            F1F1     {G}F1F{N}                  F1 " +
                                $"\n                        {G}F1F1F{N}         F1F1F1{G}F1{N}                    F1 " +
                                $"\n                             {G}F1F{N}                        F-52-LAPS-1 " +
                                $"\n                               F1F1   F1F1   F-18-TURNS-1 " +
                                $"\n                                  F1F1   ({G}DZ{N}) " + W +
                                "\n\n                              < " + G + "DRS " + W + "Zones - 2 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" + N +
                                $"\n             F1F1F1F1F1 " +
                                $"\n            F1        {R}START{N} " +
                                $"\n             F1F          {R}F1F1                         {N}F-UK-1 " +
                                $"\n           F1                {R}F1F1                     {N}F1    F1F1 " +
                                $"\n       F1F1                     {R}F1F1                   {N}F1F1    F1F " +
                                $"\n   F1F1                            {R}F1                     {N}F1     F1 " +
                                $"\n F1                                {R}F1                     {N}F1     F1 " +
                                $"\n F1                                {R}F1                  {N}F1F1      F1 " +
                                $"\n   F1F1                            {R}F1                {N}F1F         F1 " +
                                $"\n      F1F1                          {R}F1             {N}F1F           F1 " +
                                $"\n          F1F1F1                      {R}F1         F1F{N}              F1 " +
                                $"\n                F1F1                    {R}F1     F1F{N}                F1 " +
                                $"\n                    F1F1            {R}F1F1     F1F{N}                  F1 " +
                                $"\n                        F1F1F         {R}F1F1F1F1{N}                    F1 " +
                                $"\n                             F1F                        F-52-LAPS-1 " +
                                $"\n                               F1F1   F1F1   F-18-TURNS-1 " +
                                $"\n                                  F1F1   F1F1  " + W +
                                "\n\n                                < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" + N +
                                $"\n             F1F1F1F1F1 " +
                                $"\n            F1        START " +
                                $"\n             F1F          F1F1                         {B}F-UK-1{N} " +
                                $"\n           F1                F1F1                     {B}F1    F1F1{N} " +
                                $"\n       F1F1                     F1F1                   {B}F1F1    F1F{N} " +
                                $"\n   F1F1                            F1                     {B}F1     F1{N} " +
                                $"\n F1                                F1                     {B}F1     F1{N} " +
                                $"\n F1                                F1                  {B}F1F1      F1{N} " +
                                $"\n   F1F1                            F1                {B}F1F         F1{N} " +
                                $"\n      F1F1                          F1             {B}F1F           F1{N} " +
                                $"\n          F1F1F1                      F1         F1F              {B}F1{N} " +
                                $"\n                F1F1                    F1     F1F                {B}F1{N} " +
                                $"\n                    F1F1            F1F1     F1F                  {B}F1{N} " +
                                $"\n                        F1{B}F1F         {N}F1F1F1F1{B}                    F1 " +
                                $"\n                             F1F                        F-52-LAPS-1 " +
                                $"\n                               F1F1   F1F1   F-18-TURNS-1 " +
                                $"\n                                  F1F1   F1F1 " + W +
                                "\n\n                                < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" + Y +
                                $"\n             F1F1F1F1F1 " +
                                $"\n            F1        {N}START " +
                                $"\n{Y}             F1F          {N}F1F1                         F-UK-1 " +
                                $"\n{Y}           F1                {N}F1F1                     F1    F1F1 " +
                                $"\n{Y}       F1F1                     {N}F1F1                   F1F1    F1F " +
                                $"\n{Y}   F1F1                            {N}F1                     F1     F1 " +
                                $"\n{Y} F1                                {N}F1                     F1     F1 " +
                                $"\n{Y} F1                                {N}F1                  F1F1      F1 " +
                                $"\n{Y}   F1F1                            {N}F1                F1F         F1 " +
                                $"\n{Y}      F1F1                          {N}F1             F1F           F1 " +
                                $"\n{Y}          F1F1F1                      {N}F1         F1F              F1 " +
                                $"\n{Y}                F1F1                    {N}F1     F1F                F1 " +
                                $"\n{Y}                    F1F1            {N}F1F1     F1F                  F1 " +
                                $"\n{Y}                        F1{N}F1F         F1F1F1F1                    F1 " +
                                $"\n                             F1F                        F-52-LAPS-1 " +
                                $"\n                               F1F1   F1F1   F-18-TURNS-1 " +
                                $"\n                                  F1F1   F1F1 " + W +
                                "\n\n                                < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 11:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                        $"\n{pad}  F1F1 " + pad +
                        $"\n{pad} F1  F1                                       F1F1 " + pad +
                        $"\n{pad} F1   F1                                    F1    F1 " + pad +
                        $"\n{pad} F1    F1                                 F1       F1 " + pad +
                        $"\n{pad} F1    F1                                F1        F1 " + pad +
                        $"\n{pad} F1    F1                 HUNGRAY-F1F1F1F1         F1 " + pad +
                        $"\n{pad} F1    F1      F1F1F1F1F1F1                       F1 " + pad +
                        $"\n{pad} F1    F1     F1                                 F1 " + pad +
                        $"\n{pad} T1    F1    F1                              F1F1F " + pad +
                        $"\n{pad} R1     F1F1F1                             F1F " + pad +
                        $"\n{pad} A1                                       F1 " + pad +
                        $"\n{pad} T1                                        F1 " + pad +
                        $"\n{pad} S1                                         F1 " + pad +
                        $"\n{pad} F1     F1F1F                              F1 " + pad +
                        $"\n{pad} F1    F1   F1                        F1F1F1 " + pad +
                        $"\n{pad} F1    F1  F1                      F1F1 " + pad +
                        $"\n{pad} F1    F1  F1                     F1 " + pad +
                        $"\n{pad}  F1F1F1   F1F1-70-LAPS-14-TURNS-F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n             < Length - 4.38KM >                          \n" +
                                      P + "\n  Lap record" + W + " - 1:16.627 Lewis Hamilton (2020)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                    "\n  F1F1 " +
                                    "\n F1  F1                                       F1F1 " +
                                    "\n F1   F1                                    F1    F1 " +
                                    "\n F1    F1                                 F1       F1 " +
                                    "\n F1    F1                                F1        F1 " +
                                    "\n F1    F1                 HUNGRAY-F1F1F1F1         F1 " +
                                    "\n F1    F1      F1F1F1F1F1F1                       F1 " +
                                    "\n F1    F1     F1                                 F1 " +
                                    "\n T1    F1    F1                              F1F1F " +
                                    "\n R1     F1F1F1                             F1F " +
                                    "\n A1                                       F1 " +
                                    "\n T1                                        F1 " +
                                    "\n S1                                         F1 " +
                                    "\n F1     F1F1F                              F1 " +
                                    "\n F1    F1   F1                        F1F1F1 " +
                                    "\n F1    F1  F1                      F1F1 " +
                                    "\n F1    F1  F1                     F1 " +
                                    "\n  F1F1F1   F1F1-70-LAPS-14-TURNS-F1 " + W +
                                    "\n\n             < Length - 4.38KM >                   ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                    $"\n  F1F1 " +
                                    $"\n F1  {G}F1{N}                                       F1F1 " +
                                    $"\n {G}F1   F1{N}                                    F1    F1 " +
                                    $"\n {G}F1    F1{N}                                 F1       F1 " +
                                    $"\n {G}F1    F1{N}                                F1        F1 " +
                                    $"\n {G}F1    F1{N}                 HUNGRAY-F1F1F1F1         F1 " +
                                    $"\n {G}F1    F1{N}      F1F1F1F1F1F1                       F1 " +
                                    $"\n {G}F1    F1{N}     F1                                 F1 " +
                                    $"\n {G}T1{N}    F1    F1                              F1F1F " +
                                    $"\n {G}R1{N}     F1F1F1                             F1F " +
                                    $"\n {G}A1{N}                                       F1 " +
                                    $"\n {G}T1{N}                                        F1 " +
                                    $"\n {G}S1{N}                                         F1 " +
                                    $"\n {G}F1{N}     F1F1F                              F1 " +
                                    $"\n {G}F1{N}    F1   F1                        F1F1F1 " +
                                    $"\n {G}F1{N}    F1  F1                      F1F1 " +
                                    $"\n {G}F1{N}   ({G}DZ{N}) F1                     F1 " +
                                    $"\n  F1F1F1   F1F1-70-LAPS-14-TURNS-F1 " + W +
                                    "\n\n              < " + G + "DRS " + W + "Zones - 2 >           ");
                                break;
                            case 2:
                                Console.WriteLine("" + R +
                                    $"\n  F1F1 " +
                                    $"\n F1  F1{N}                                       F1F1 " +
                                    $"\n {R}F1   F1{N}                                    F1    F1 " +
                                    $"\n {R}F1    F1{N}                                 F1       F1 " +
                                    $"\n {R}F1    F1{N}                                F1        F1 " +
                                    $"\n {R}F1    F1                 HUNGRAY-{N}F1F1F1F1         F1 " +
                                    $"\n {R}F1    F1      F1F1F1F1F1F1{N}                       F1 " +
                                    $"\n {R}F1    F1     F1{N}                                 F1 " +
                                    $"\n {R}T1    F1    F1{N}                              F1F1F " +
                                    $"\n {R}R1     F1F1F1{N}                             F1F " +
                                    $"\n {R}A1{N}                                       F1 " +
                                    $"\n {R}T1{N}                                        F1 " +
                                    $"\n {R}S1{N}                                         F1 " +
                                    $"\n F1     F1F1F                              F1 " +
                                    $"\n F1    F1   F1                        F1F1F1 " +
                                    $"\n F1    F1  F1                      F1F1 " +
                                    $"\n F1    F1  F1                     F1 " +
                                    $"\n  F1F1F1   F1F1-70-LAPS-14-TURNS-F1 " + W +
                                    "\n\n                < " + R + "Sector 1" + W + " >                ");
                                break;
                            case 3:
                                Console.WriteLine("" + N +
                                    $"\n  F1F1 " +
                                    $"\n F1  F1{B}                                       F1F1{N} " +
                                    $"\n F1   F1{B}                                    F1    F1{N} " +
                                    $"\n F1    F1{B}                                 F1       F1{N} " +
                                    $"\n F1    F1{B}                                F1        F1{N} " +
                                    $"\n F1    F1                 HUNGRAY-{B}F1F1F1F1         F1{N} " +
                                    $"\n F1    F1      F1F1F1F1F1F1                       {B}F1{N} " +
                                    $"\n F1    F1     F1                                 {B}F1{N} " +
                                    $"\n T1    F1    F1                              {B}F1F1F{N} " +
                                    $"\n R1     F1F1F1                             {B}F1F{N} " +
                                    $"\n A1                                       {B}F1{N} " +
                                    $"\n T1                                        {B}F1{N} " +
                                    $"\n S1                                         {B}F1{N} " +
                                    $"\n F1     F1F1F                              {B}F1{N} " +
                                    $"\n F1    F1   F1                        {B}F1F1F1{N} " +
                                    $"\n F1    F1  F1                      {B}F1F1{N} " +
                                    $"\n F1    F1  F1                     {B}F1{N} " +
                                    $"\n  F1F1F1   F1F1-70-LAPS-14-{B}TURNS-F1{N} " + W +
                                    "\n\n                < " + B + "Sector 2" + W + " >                ");
                                break;
                            case 4:
                                Console.WriteLine("" + N +
                                    $"\n  F1F1 " +
                                    $"\n F1  F1                                       F1F1 " +
                                    $"\n F1   F1                                    F1    F1 " +
                                    $"\n F1    F1                                 F1       F1 " +
                                    $"\n F1    F1                                F1        F1 " +
                                    $"\n F1    F1                 HUNGRAY-F1F1F1F1         F1 " +
                                    $"\n F1    F1      F1F1F1F1F1F1                       F1 " +
                                    $"\n F1    F1     F1                                 F1 " +
                                    $"\n T1    F1    F1                              F1F1F " +
                                    $"\n R1     F1F1F1                             F1F " +
                                    $"\n A1                                       F1 " +
                                    $"\n T1                                        F1 " +
                                    $"\n S1                                         F1 " +
                                    $"\n{Y} F1     F1F1F{N}                              F1 " +
                                    $"\n{Y} F1    F1   F1{N}                        F1F1F1 " +
                                    $"\n{Y} F1    F1  F1{N}                      F1F1 " +
                                    $"\n{Y} F1    F1  F1{N}                     F1 " +
                                    $"\n{Y}  F1F1F1   F1F1-70-LAPS-14-{N}TURNS-F1 " + W +
                                    "\n\n                < " + Y + "Sector 3" + W + " >                ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 12:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                        $"\n{pad}                                            F1F1F1F1F1F1   F1F1F1  " + pad +
                        $"\n{pad}                                     BELGIUM           F1F1     F1 " + pad +
                        $"\n{pad}                               F1F1F1F                            F1 " + pad +
                        $"\n{pad}                           F1F1                        F1F1F1F1F1  F1 " + pad +
                        $"\n{pad}                       F1F1                   F1F1F1F1F1         F1F " + pad +
                        $"\n{pad}                   F1F1                      F1 " + pad +
                        $"\n{pad}               F1F1                          F1 " + pad +
                        $"\n{pad}             F1                               F1 " + pad +
                        $"\n{pad}           F1                                  F1F1F1 " + pad +
                        $"\n{pad}         F1                         F1F1F1           F1F1F1F1 " + pad +
                        $"\n{pad}       F1      F1             F1F1F1      F1F1              F1 " + pad +
                        $"\n{pad}     F1       F1F1-44-LAPS-F1F               F1           F1 " + pad +
                        $"\n{pad}   F1       F1                                 F1           F1F1 " + pad +
                        $"\n{pad}  F1    START                                    F1             F1F1 " + pad +
                        $"\n{pad} F1  F1F1                                          F1              F1 " + pad +
                        $"\n{pad} F1F1                                                F1F1F1       F1 " + pad +
                        $"\n{pad}                                                          18-TURNS " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                          < Length - 7.01KM >                                              \n" +
                                      P + "\n              Lap record" + W + " - 1:46.286 Valtteri Bottas (2018)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                $"\n                                            F1F1F1F1F1F1   F1F1F1  " +
                                $"\n                                     BELGIUM           F1F1     F1 " +
                                $"\n                               F1F1F1F                            F1 " +
                                $"\n                           F1F1                        F1F1F1F1F1  F1 " +
                                $"\n                       F1F1                   F1F1F1F1F1         F1F " +
                                $"\n                   F1F1                      F1 " +
                                $"\n               F1F1                          F1 " +
                                $"\n             F1                               F1 " +
                                $"\n           F1                                  F1F1F1 " +
                                $"\n         F1                         F1F1F1           F1F1F1F1 " +
                                $"\n       F1      F1             F1F1F1      F1F1              F1 " +
                                $"\n     F1       F1F1-44-LAPS-F1F               F1           F1 " +
                                $"\n   F1       F1                                 F1           F1F1 " +
                                $"\n  F1    START                                    F1             F1F1 " +
                                $"\n F1  F1F1                                          F1              F1 " +
                                $"\n F1F1                                                F1F1F1       F1 " +
                                $"\n                                                          18-TURNS " + W +
                                "\n\n                          < Length - 7.01KM >                   ");
                                break;
                            case 1:
                                Console.WriteLine("" + G +
                                $"\n                                            F1F1F1F1F1{N}F1   F1F1F1  " + G +
                                $"\n                                     BELGIUM{N}           F1F1     F1 " + G +
                                $"\n                               F1F1F1F{N}                            F1 " +
                                $"\n                           {G}F1F1{N}                        F1F1F1F1F1  F1 " +
                                $"\n                       F1F1                   F1F1F1F1F1         F1F " +
                                $"\n                   F1F1                      F1 " +
                                $"\n               F1F1                          F1 " +
                                $"\n             F1                               F1 " +
                                $"\n           F1                                  F1F1F1 " +
                                $"\n        ({G}DZ{N})                        F1F1F1           F1F1F1F1 " +
                                $"\n       F1      F1             F1F1F1      F1F1              F1 " +
                                $"\n     F1       {G}F1{N}F1({G}DZ{N})LAPS-F1F               F1           F1 " +
                                $"\n   F1       {G}F1{N}                                 F1           F1F1 " +
                                $"\n  F1    {G}START{N}                                    F1             F1F1 " +
                                $"\n F1  {G}F1F1{N}                                          F1              F1 " +
                                $"\n F1{G}F1{N}                                                F1F1F1       F1 " +
                                $"\n                                                          18-TURNS " + W +
                                "\n\n                           < " + G + "DRS " + W + "Zones - 2 >           ");
                                break;
                            case 2:
                                Console.WriteLine("" + R +
                                $"\n                                            F1F1F1F1F1{N}F1   F1F1F1  " + R +
                                $"\n                                     BELGIUM{N}           F1F1     F1 " + R +
                                $"\n                               F1F1F1F{N}                            F1 " + R +
                                $"\n                           F1F1{N}                        F1F1F1F1F1  F1 " + R +
                                $"\n                       F1F1{N}                   F1F1F1F1F1         F1F " + R +
                                $"\n                   F1F1{N}                      F1 " + R +
                                $"\n               F1F1{N}                          F1 " + R +
                                $"\n             F1{N}                               F1 " + R +
                                $"\n           F1{N}                                  F1F1F1 " + R +
                                $"\n         F1{N}                         F1F1F1           F1F1F1F1 " + R +
                                $"\n       F1{N}      F1             F1F1F1      F1F1              F1 " + R +
                                $"\n     F1{N}       F1F1-44-LAPS-F1F               F1           F1 " + R +
                                $"\n   F1{N}       F1                                 F1           F1F1 " + R +
                                $"\n  F1    START{N}                                    F1             F1F1 " + R +
                                $"\n F1  F1F1{N}                                          F1              F1 " + R +
                                $"\n F1F1{N}                                                F1F1F1       F1 " +
                                $"\n                                                          18-TURNS " + W +
                                "\n\n                             < " + R + "Sector 1" + W + " >                ");
                                break;
                            case 3:
                                Console.WriteLine("" + N +
                                $"\n                                            F1F1F1F1F1{B}F1   F1F1F1  " + N +
                                $"\n                                     BELGIUM           {B}F1F1     F1 " + N +
                                $"\n                               F1F1F1F                            {B}F1 " + N +
                                $"\n                           F1F1                        {B}F1F1F1F1F1  F1 " + N +
                                $"\n                       F1F1                   {B}F1F1F1F1F1         F1F " + N +
                                $"\n                   F1F1                      {B}F1 " + N +
                                $"\n               F1F1                          {B}F1 " + N +
                                $"\n             F1                               {B}F1 " + N +
                                $"\n           F1                                  {B}F1F1F1 " + N +
                                $"\n         F1                         F1F1F1           {B}F1F1F1F1 " + N +
                                $"\n       F1      F1             F1F1F1      F1F1              {B}F1 " + N +
                                $"\n     F1       F1F1-44-LAPS-F1F               F1           {B}F1 " + N +
                                $"\n   F1       F1                                 F1           {B}F1F1 " + N +
                                $"\n  F1    START                                    F1             {B}F1F1 " + N +
                                $"\n F1  F1F1                                          F1              {B}F1 " + N +
                                $"\n F1F1                                                F1F1F1       F1 " +
                                $"\n                                                          18-TURNS " + W +
                                "\n\n                             < " + B + "Sector 2" + W + " >                ");
                                break;
                            case 4:
                                Console.WriteLine("" + N +
                                $"\n                                            F1F1F1F1F1F1   F1F1F1  " +
                                $"\n                                     BELGIUM           F1F1     F1 " +
                                $"\n                               F1F1F1F                            F1 " +
                                $"\n                           F1F1                        F1F1F1F1F1  F1 " +
                                $"\n                       F1F1                   F1F1F1F1F1         F1F " +
                                $"\n                   F1F1                      F1 " +
                                $"\n               F1F1                          F1 " +
                                $"\n             F1                               F1 " +
                                $"\n           F1                                  F1F1F1 " +
                                $"\n         F1                         {Y}F1F1F1{N}           F1F1F1F1 " +
                                $"\n       F1      {Y}F1             F1F1F1      F1F1{N}              F1 " +
                                $"\n     F1       {Y}F1F1-44-LAPS-F1F               F1{N}           F1 " +
                                $"\n   F1       {Y}F1                                 F1{N}           F1F1 " +
                                $"\n  F1    START                                    {Y}F1{N}             F1F1 " +
                                $"\n F1  F1F1                                          {Y}F1{N}              F1 " +
                                $"\n F1F1                                                {Y}F1F1F1       F1 " + N +
                                $"\n                                                          {Y}18-TURNS " + W +
                                "\n\n                             < " + Y + "Sector 3" + W + " >                ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 13:
                    Console.SetCursorPosition(0, 0);
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                        $"\n{pad}          F-NETHERLANDS-1 " + pad +
                        $"\n{pad}         F1              F1F1F1F1 " + pad +
                        $"\n{pad}        F1                      F1 " + pad +
                        $"\n{pad}        F1       F1F1F1F1        F1 " + pad +
                        $"\n{pad}         F1      F1      F1      F1 " + pad +
                        $"\n{pad}          F1      F1       F1   F1 " + pad +
                        $"\n{pad}           F1      F1        F1F1 " + pad +
                        $"\n{pad}            F1F     F1 " + pad +
                        $"\n{pad}               F1F    F1 " + pad +
                        $"\n{pad}                  F1F   F1F " + pad +
                        $"\n{pad}                    F1    F1F1 " + pad +
                        $"\n{pad}                      F1      F1F1                   F1F1 " + pad +
                        $"\n{pad}                       F1        F1F1           F1F1F1   F1 " + pad +
                        $"\n{pad}                        F1          F1       F1F1         F1 " + pad +
                        $"\n{pad}                         F1F      F1      F1F1             F1 " + pad +
                        $"\n{pad}                           F1F1    F1F1F1F1                 F1 " + pad +
                        $"\n{pad}                   F1F1F1     F1                            F1 " + pad +
                        $"\n{pad}  F1F1F1F1F1F1F1F1F1    F1F1   F1                           F1 " + pad +
                        $"\n{pad} F1                        F1F1                            F1 " + pad +
                        $"\n{pad}  F1F1F1F1F1F1F1F1F1F1START1F1-72-LAPS-14-TURNS-F1F1F1F1F1F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                       < Length - 4.26KM >                                              \n" +
                                      P + "\n           Lap record" + W + " - 1:11.097 Lewis Hamilton (2021)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                "\n          F-NETHERLANDS-1 " +
                                "\n         F1              F1F1F1F1 " +
                                "\n        F1                      F1 " +
                                "\n        F1       F1F1F1F1        F1 " +
                                "\n         F1      F1      F1      F1 " +
                                "\n          F1      F1       F1   F1 " +
                                "\n           F1      F1        F1F1 " +
                                "\n            F1F     F1 " +
                                "\n               F1F    F1 " +
                                "\n                  F1F   F1F " +
                                "\n                    F1    F1F1 " +
                                "\n                      F1      F1F1                   F1F1 " +
                                "\n                       F1        F1F1           F1F1F1   F1 " +
                                "\n                        F1          F1       F1F1         F1 " +
                                "\n                         F1F      F1      F1F1             F1 " +
                                "\n                           F1F1    F1F1F1F1                 F1 " +
                                "\n                   F1F1F1     F1                            F1 " +
                                "\n  F1F1F1F1F1F1F1F1F1    F1F1   F1                           F1 " +
                                "\n F1                        F1F1                            F1 " +
                                "\n  F1F1F1F1F1F1F1F1F1F1START1F1-72-LAPS-14-TURNS-F1F1F1F1F1F1 " + W +
                                "\n\n                       < Length - 4.26KM >                   ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                $"\n          F-NETHERLANDS-1 " +
                                $"\n         F1              F1F1F1F1 " +
                                $"\n        F1                      F1 " +
                                $"\n        F1       F1F({G}DZ{W})1        F1 " +
                                $"\n         F1      F1      F1      F1 " +
                                $"\n          F1      {G}F1{N}       F1   F1 " +
                                $"\n           F1      {G}F1{N}        F1F1 " +
                                $"\n            F1F     {G}F1{N} " +
                                $"\n               F1F    {G}F1{N} " +
                                $"\n                  F1F   {G}F1F{N} " +
                                $"\n                    F1    {G}F1F1{N} " +
                                $"\n                      F1      {G}F1F1{N}                   F1F1 " +
                                $"\n                       F1        {G}F1{N}F1           F1F1F1   F1 " +
                                $"\n                        F1          F1       F1F1         F1 " +
                                $"\n                         F1F      F1      F1F1             {G}F1{N} " +
                                $"\n                           F1F1    F1F({G}DZ{N})1                 {G}F1{N} " +
                                $"\n                   F1F1F1     F1                            {G}F1{N} " +
                                $"\n  F1F1F1F1F1F1F1F1F1    F1F1   F1                           {G}F1{N} " +
                                $"\n F1                        F1F1                            {G}F1{N} " +
                                $"\n  F1{G}F1F1F1F1F1F1F1F1F1START1F1-72-LAPS-14-TURNS-F1F1F1F1F1F1 " + W +
                                "\n\n                        < " + G + "DRS " + W + "Zones - 2 >           ");
                                break;
                            case 2:
                                Console.WriteLine("" + N +
                                $"\n          F-NETHERLANDS-1 " +
                                $"\n         F1              F1F1F1F1 " +
                                $"\n        F1                      F1 " +
                                $"\n        F1       F1F1F1F1        F1 " +
                                $"\n         F1      F1      F1      F1 " +
                                $"\n          F1      F1       F1   F1 " +
                                $"\n           F1      F1        F1F1 " +
                                $"\n            {R}F1F{N}     F1 " +
                                $"\n               {R}F1F{N}    F1 " +
                                $"\n                  {R}F1F{N}   F1F " +
                                $"\n                    {R}F1{N}    F1F1 " +
                                $"\n                      {R}F1{N}      F1F1                   F1F1 " +
                                $"\n                       {R}F1{N}        F1F1           F1F1F1   F1 " +
                                $"\n                        {R}F1{N}          F1       F1F1         F1 " +
                                $"\n                         {R}F1F{N}      F1      F1F1             F1 " +
                                $"\n                           {R}F1F1{N}    F1F1F1F1                 F1 " +
                                $"\n                   {R}F1F1F1     F1{N}                            F1 " +
                                $"\n  {R}F1F1F1F1F1F1F1F1F1    F1F1   F1{N}                           F1 " +
                                $"\n {R}F1                        F1F1{N}                            F1 " +
                                $"\n  {R}F1F1F1F1F1F1F1F1F1F1START{N}1F1-72-LAPS-14-TURNS-F1F1F1F1F1F1 " + W +
                                "\n\n                          < " + R + "Sector 1" + W + " >                ");
                                break;
                            case 3:
                                Console.WriteLine("" + B +
                                $"\n          F-NETHERLANDS-1 " +
                                $"\n         F1              F1F1F1F1 " +
                                $"\n        F1                      F1 " +
                                $"\n        F1       F1F1F1F1        F1 " +
                                $"\n         F1      F1      F1      F1 " +
                                $"\n          F1      F1       F1   F1 " +
                                $"\n           F1      F1        F1F1 " + N +
                                $"\n            F1F     {B}F1 " + N +
                                $"\n               F1F    {B}F1 " + N +
                                $"\n                  F1F   {B}F1F " + N +
                                $"\n                    F1    {B}F1F1 " + N +
                                $"\n                      F1      {B}F1F1{N}                   F1F1 " +
                                $"\n                       F1        F1F1           F1F1F1   F1 " +
                                $"\n                        F1          F1       F1F1         F1 " +
                                $"\n                         F1F      F1      F1F1             F1 " +
                                $"\n                           F1F1    F1F1F1F1                 F1 " +
                                $"\n                   F1F1F1     F1                            F1 " +
                                $"\n  F1F1F1F1F1F1F1F1F1    F1F1   F1                           F1 " +
                                $"\n F1                        F1F1                            F1 " +
                                $"\n  F1F1F1F1F1F1F1F1F1F1START1F1-72-LAPS-14-TURNS-F1F1F1F1F1F1 " + W +
                                "\n\n                          < " + B + "Sector 2" + W + " >                ");
                                break;
                            case 4:
                                Console.WriteLine("" + N +
                                $"\n          F-NETHERLANDS-1 " +
                                $"\n         F1              F1F1F1F1 " +
                                $"\n        F1                      F1 " +
                                $"\n        F1       F1F1F1F1        F1 " +
                                $"\n         F1      F1      F1      F1 " +
                                $"\n          F1      F1       F1   F1 " +
                                $"\n           F1      F1        F1F1 " +
                                $"\n            F1F     F1 " +
                                $"\n               F1F    F1 " +
                                $"\n                  F1F   F1F " +
                                $"\n                    F1    F1F1 " +
                                $"\n                      F1      F1F1                   {Y}F1F1 " + N +
                                $"\n                       F1        {Y}F1F1           F1F1F1   F1 " + N +
                                $"\n                        F1          {Y}F1       F1F1         F1 " + N +
                                $"\n                         F1F      {Y}F1      F1F1             F1 " + N +
                                $"\n                           F1F1    {Y}F1F1F1F1                 F1 " + N +
                                $"\n                   F1F1F1     F1                            {Y}F1 " + N +
                                $"\n  F1F1F1F1F1F1F1F1F1    F1F1   F1                           {Y}F1 " + N +
                                $"\n F1                        F1F1                            {Y}F1 " + N +
                                $"\n  F1F1F1F1F1F1F1F1F1F1START{Y}1F1-72-LAPS-14-TURNS-F1F1F1F1F1F1 " + W +
                                "\n\n                          < " + Y + "Sector 3" + W + " >                ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 14:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                        $"\n{pad}  F1-ITALY-F1 " + pad +
                        $"\n{pad} F1         F1 " + pad +
                        $"\n{pad}  F1          F1 " + pad +
                        $"\n{pad}   F1           F1 " + pad +
                        $"\n{pad}   F1F            F1 " + pad +
                        $"\n{pad}    F1              F1F " + pad +
                        $"\n{pad}    F1                 F1F " + pad +
                        $"\n{pad}    F1                    F1F1 " + pad +
                        $"\n{pad}    F1                        F1F1-53-LAPS-11-TURNS-F1F1F1F1F1F1F1F1 " + pad +
                        $"\n{pad}    F1                                                             F1 " + pad +
                        $"\n{pad}     F1                                                           F1F " + pad +
                        $"\n{pad}       F1F1          F1F                                 F1F1F1F1F1 " + pad +
                        $"\n{pad}           F1F1F1F1F1  F1F1F1F1F1F1F1F1F1F1F1F1F1F1STARTF1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                       < Length - 5.79KM >                                              \n" +
                                      P + "\n         Lap record" + W + " - 1:21.046 - Rubens Barrichello (2004)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                "\n  F1-ITALY-F1 " +
                                "\n F1         F1 " +
                                "\n  F1          F1 " +
                                "\n   F1           F1 " +
                                "\n   F1F            F1 " +
                                "\n    F1              F1F " +
                                "\n    F1                 F1F " +
                                "\n    F1                    F1F1 " +
                                "\n    F1                        F1F1-53-LAPS-11-TURNS-F1F1F1F1F1F1F1F1 " +
                                "\n    F1                                                             F1 " +
                                "\n     F1                                                           F1F " +
                                "\n       F1F1          F1F                                 F1F1F1F1F1 " +
                                "\n           F1F1F1F1F1  F1F1F1F1F1F1F1F1F1F1F1F1F1F1STARTF1 " + W +
                                "\n\n                       < Length - 5.79KM >                   ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                $"\n  F1-IT({G}DZ{N})F1 " +
                                $"\n F1         {G}F1 " + N +
                                $"\n  F1          {G}F1 " + N +
                                $"\n   F1           {G}F1 " + N +
                                $"\n   F1F            {G}F1 " + N +
                                $"\n    F1              {G}F1F " + N +
                                $"\n    F1                 {G}F1F " + N +
                                $"\n    F1                    {G}F1{N}F1 " +
                                $"\n    F1                        F1F1-53-LAPS-11-TURNS-F1F1F1F1F1F1F1F1 " +
                                $"\n    F1                                                             F1 " +
                                $"\n     F1                                                           F1F " +
                                $"\n       F1F1          F1F                                 F({G}DZ{N})1F1F1 " +
                                $"\n           F1F1F1F1F1  F{G}1F1F1F1F1F1F1F1F1F1F1F1F1F1{N}STARTF1 " + W +
                                "\n\n                        < " + G + "DRS " + W + "Zones - 2 >           ");
                                break;
                            case 2:
                                Console.WriteLine("" + N +
                                $"\n  F1-ITALY-F1 " +
                                $"\n F1         F1 " +
                                $"\n  F1          F1 " +
                                $"\n   F1           F1 " +
                                $"\n   F1F            F1 " +
                                $"\n    F1              F1F " +
                                $"\n    {R}F1{N}                 F1F " +
                                $"\n    {R}F1{N}                    F1F1 " +
                                $"\n    {R}F1{N}                        F1F1-53-LAPS-11-TURNS-F1F1F1F1F1F1F1F1 " +
                                $"\n    {R}F1{N}                                                             F1 " +
                                $"\n     {R}F1{N}                                                           F1F " +
                                $"\n       {R}F1F1          F1F{N}                                 F1F1F1F1F1 " +
                                $"\n           {R}F1F1F1F1F1  F1F1F1F1F1F1F1F1F1F1F1F1F1F1START{N}F1 " + W +
                                "\n\n                          < " + R + "Sector 1" + W + " >                ");
                                break;
                            case 3:
                                Console.WriteLine("" + B +
                                $"\n  F1-ITALY-F1 " +
                                $"\n F1         F1 " +
                                $"\n  F1          F1 " +
                                $"\n   F1           F1 " +
                                $"\n   F1F            F1 " +
                                $"\n    F1              F1F " + N +
                                $"\n    F1                 {B}F1F " + N +
                                $"\n    F1                    F1F1 " +
                                $"\n    F1                        F1F1-53-LAPS-11-TURNS-F1F1F1F1F1F1F1F1 " +
                                $"\n    F1                                                             F1 " +
                                $"\n     F1                                                           F1F " +
                                $"\n       F1F1          F1F                                 F1F1F1F1F1 " +
                                $"\n           F1F1F1F1F1  F1F1F1F1F1F1F1F1F1F1F1F1F1F1STARTF1 " + W +
                                "\n\n                          < " + B + "Sector 2" + W + " >                ");
                                break;
                            case 4:
                                Console.WriteLine("" + N +
                                $"\n  F1-ITALY-F1 " +
                                $"\n F1         F1 " +
                                $"\n  F1          F1 " +
                                $"\n   F1           F1 " +
                                $"\n   F1F            F1 " +
                                $"\n    F1              F1F " +
                                $"\n    F1                 F1F " +
                                $"\n    F1                    {Y}F1F1 " + N +
                                $"\n    F1                        {Y}F1F1-53-LAPS-11-TURNS-F1F1F1F1F1F1F1F1 " + N +
                                $"\n    F1                                                             {Y}F1 " + N +
                                $"\n     F1                                                           {Y}F1F " + N +
                                $"\n       F1F1          F1F                                 {Y}F1F1F1F1F1 " + N +
                                $"\n           F1F1F1F1F1  F1F1F1F1F1F1F1F1F1F1F1F1F1F1START{Y}F1 " + W +
                                "\n\n                          < " + Y + "Sector 3" + W + " >                ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 15:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                        $"\n{pad}                                                        F1 " + pad +
                        $"\n{pad}                                                      F1  F1F1 " + pad +
                        $"\n{pad}                                                      F1      F1 " + pad +
                        $"\n{pad}                                                       F1     F1 " + pad +
                        $"\n{pad}                    F1F1F1                              F1    F1 " + pad +
                        $"\n{pad}        F1F1F1     F1    F1F1F1                         F1     T1 " + pad +
                        $"\n{pad}       F1    F1   F1          F1F                        F1    R1 " + pad +
                        $"\n{pad}      F1       F1F1             F1F1F1F-SINGAPORE-F1F1F1F1     A1 " + pad +
                        $"\n{pad}     F1          F1F1                                           T1 " + pad +
                        $"\n{pad}    F1          F1   F1F1                                       S1 " + pad +
                        $"\n{pad}   F1           F1       F1F1                                   F1 " + pad +
                        $"\n{pad}  F1           F1            F1F           F1F1F1F1            F1 " + pad +
                        $"\n{pad} F1            F1              F1         F1      F1-23-TURNS-F1 " + pad +
                        $"\n{pad}  F1F1        F1                F-61-LAPS-F1 " + pad +
                        $"\n{pad}     F1      F1 " + pad +
                        $"\n{pad}      F1F   F1 " + pad +
                        $"\n{pad}        F1 F1 " + pad +
                        $"\n{pad}          F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                         < Length - 5.03KM >                                              \n" +
                                      P + "\n             Lap record" + W + " - 1:41.905 Kevin Magnussen (2018)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                "\n                                                        F1 " +
                                "\n                                                      F1  F1F1 " +
                                "\n                                                      F1      F1 " +
                                "\n                                                       F1     F1 " +
                                "\n                    F1F1F1                              F1    F1 " +
                                "\n        F1F1F1     F1    F1F1F1                         F1     T1 " +
                                "\n       F1    F1   F1          F1F                        F1    R1 " +
                                "\n      F1       F1F1             F1F1F1F-SINGAPORE-F1F1F1F1     A1 " +
                                "\n     F1          F1F1                                           T1 " +
                                "\n    F1          F1   F1F1                                       S1 " +
                                "\n   F1           F1       F1F1                                   F1 " +
                                "\n  F1           F1            F1F           F1F1F1F1            F1 " +
                                "\n F1            F1              F1         F1      F1-23-TURNS-F1 " +
                                "\n  F1F1        F1                F-61-LAPS-F1 " +
                                "\n     F1      F1 " +
                                "\n      F1F   F1 " +
                                "\n        F1 F1 " +
                                "\n          F1 " + W +
                                "\n\n                         < Length - 5.03KM >            ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                $"\n                                                        F1 " +
                                $"\n                                                      F1  F1F1 " +
                                $"\n                                                     ({G}DZ{N})     {G}F1 " + N +
                                $"\n                                                       F1     {G}F1 " + N +
                                $"\n                    F1F{G}1F1{N}                              F1    {G}F1 " + N +
                                $"\n        F1F1F1     F1    {G}F1F1F1{N}                         F1     {G}T1 " + N +
                                $"\n       F1    F1   F1          {G}F1F{N}                        F1    {G}R1 " + N +
                                $"\n      F1       F1F1             {G}F1F1F1F-SINGAPORE-F1F1F1{N}F1     {G}A1 " + N +
                                $"\n     F1          F1F1                                           {G}T1 " + N +
                                $"\n    F1          F1   F1F1                                       {G}S1 " + N +
                                $"\n   F1           {G}F1{N}       F1F1                                   {G}F1 " + N +
                                $"\n  F1           {G}F1{N}            F1F           F1F1F1F1            F1 " +
                                $"\n F1            {G}F1{N}              F1         F1      F1({G}DZ{N})TURNS-F1 " +
                                $"\n  F1F1        {G}F1{N}                F-61-LAPS-F1 " +
                                $"\n     F1      {G}F1 " + N +
                                $"\n     ({G}DZ{N})   {G}F1 " + N +
                                $"\n        F1 {G}F1 " + N +
                                $"\n          F1 " + W +
                                "\n\n                          < " + G + "DRS " + W + "Zones - 3 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" + R +
                                $"\n                                                        F1 " +
                                $"\n                                                      F1  F1F1 " +
                                $"\n                                                      F1      F1 " +
                                $"\n                                                       F1     F1 " +
                                $"\n                    {N}F1F1F1{R}                              F1    F1 " + N +
                                $"\n        F1F1F1     F1    F1F{R}1F1                         F1     T1 " + N +
                                $"\n       F1    F1   F1          {R}F1F                        F1    R1 " + N +
                                $"\n      F1       F1F1             {R}F1F1F1F-SINGAPORE-F1F1F1F1     A1 " + N +
                                $"\n     F1          F1F1                                           {R}T1 " + N +
                                $"\n    F1          F1   F1F1                                       {R}S1 " + N +
                                $"\n   F1           F1       F1F1                                   F1 " +
                                $"\n  F1           F1            F1F           F1F1F1F1            F1 " +
                                $"\n F1            F1              F1         F1      F1-23-TURNS-F1 " +
                                $"\n  F1F1        F1                F-61-LAPS-F1 " +
                                $"\n     F1      F1 " +
                                $"\n      F1F   F1 " +
                                $"\n        F1 F1 " +
                                $"\n          F1 " + W +
                                "\n\n                            < " + R + "Sector 1" + W + " >                   ");
                                break;
                            case 3:
                                Console.WriteLine("" + N +
                                $"\n                                                        F1 " +
                                $"\n                                                      F1  F1F1 " +
                                $"\n                                                      F1      F1 " +
                                $"\n                                                       F1     F1 " +
                                $"\n                    {B}F1F1F1{N}                              F1    F1 " +
                                $"\n        {B}F1F1F1     F1    F1F{N}1F1                         F1     T1 " +
                                $"\n       {B}F1    F1   F1{N}          F1F                        F1    R1 " +
                                $"\n      {B}F1       F1F1{N}             F1F1F1F-SINGAPORE-F1F1F1F1     A1 " +
                                $"\n     {B}F1{N}          F1F1                                           T1 " +
                                $"\n    {B}F1{N}          F1   F1F1                                       S1 " +
                                $"\n   {B}F1           F1{N}       F1F1                                   F1 " +
                                $"\n  {B}F1           F1{N}            F1F           F1F1F1F1            F1 " +
                                $"\n {B}F1            F1{N}              F1         F1      F1-23-TURNS-F1 " +
                                $"\n  {B}F1F1        F1{N}                F-61-LAPS-F1 " +
                                $"\n     {B}F1      F1 " +
                                $"\n      F1F   F1 " +
                                $"\n        F1 F1 " +
                                $"\n          F1 " + W +
                                "\n\n                            < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" + N +
                                $"\n                                                        F1 " +
                                $"\n                                                      F1  F1F1 " +
                                $"\n                                                      F1      F1 " +
                                $"\n                                                       F1     F1 " +
                                $"\n                    F1F1F1                              F1    F1 " +
                                $"\n        F1F1F1     F1    F1F1F1                         F1     T1 " +
                                $"\n       F1    F1   F1          F1F                        F1    R1 " +
                                $"\n      F1       F1F1             F1F1F1F-SINGAPORE-F1F1F1F1     A1 " +
                                $"\n     F1          {Y}F1F1{N}                                           T1 " +
                                $"\n    F1          {Y}F1   F1F1{N}                                       S1 " +
                                $"\n   F1           F1       {Y}F1F1                                   F1 " + N +
                                $"\n  F1           F1            {Y}F1F           F1F1F1F1            F1 " + N +
                                $"\n F1            F1              {Y}F1         F1      F1-23-TURNS-F1 " + N +
                                $"\n  F1F1        F1                {Y}F-61-LAPS-F1 " + N +
                                $"\n     F1      F1 " +
                                $"\n      F1F   F1 " +
                                $"\n        F1 F1 " +
                                $"\n          F1 " + W +
                                "\n\n                            < " + Y + "Sector 3" + W + " >                     ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 20:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                        $"\n{pad}                     F1F1F1F-BRAZILI-F1F1F1 " + pad +
                        $"\n{pad}                  F1F                F1F   F1 " + pad +
                        $"\n{pad}               F1F      F1F1F1    F1F  F1    F1 " + pad +
                        $"\n{pad}           START     F1F1   F1  F1F   F1F      F1 " + pad +
                        $"\n{pad}         F1F        F1       F1F1   F1          F1 " + pad +
                        $"\n{pad}      F1F           F1F            F1           F1 " + pad +
                        $"\n{pad}   F1F                 F1F1F         F1F1F      F1 " + pad +
                        $"\n{pad} F1F                        F1F1F1F       F1F1F1 " + pad +
                        $"\n{pad}  F1F                             F1F1 " + pad +
                        $"\n{pad}   F1                                 F1 " + pad +
                        $"\n{pad}   F1                                  F1 " + pad +
                        $"\n{pad}    F1                                F1 " + pad +
                        $"\n{pad}      F1F1F1F-71-LAPS-15-TURNS-F1F1F1F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n               < Length - 4.31KM >                                              \n" +
                                      P + "\n   Lap record" + W + " - 1:10.540 Valtteri Bottas (2018)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                              $"\n                     F1F1F1F-BRAZILI-F1F1F1" +
                                              $"\n                  F1F                F1F   F1" +
                                              $"\n               F1F      F1F1F1    F1F  F1    F1" +
                                              $"\n           START     F1F1   F1  F1F   F1F      F1 " +
                                              $"\n         F1F        F1       F1F1   F1          F1" +
                                              $"\n      F1F           F1F            F1           F1" +
                                              $"\n   F1F                 F1F1F         F1F1F      F1" +
                                              $"\n F1F                        F1F1F1F       F1F1F1" +
                                              $"\n  F1F                             F1F1" +
                                              $"\n   F1                                 F1" +
                                              $"\n   F1                                  F1" +
                                              $"\n    F1                                F1" +
                                              $"\n      F1F1F1F-71-LAPS-15-TURNS-F1F1F1F1 " + W +
                                              "\n\n               < Length - 4.31KM >            ");
                                break;
                            case 1:
                                Console.WriteLine("" + G +
                                              $"\n                     F1F1F1F{N}-BRAZILI-F1F1F1{G}" +
                                              $"\n                  F1F{N}                F1F   F1{G}" +
                                              $"\n               F1F{N}      F1F1F1    F1F  F1    F1{G}" +
                                              $"\n           START{N}     F1F1   F1  F1F   F1F     ({G}DZ{N}){G}" +
                                              $"\n         F1F{N}        F1       F1F1   F1          F1{G}" +
                                              $"\n      F1F{N}           F1F            F1           F1{G}" +
                                              $"\n   F1F{N}                 F1F1F         F1F1F      F1" +
                                              $"\n F1F                        F1F1F1F       F1F1F1" +
                                              $"\n ({G}DZ{N})                             F1F1" +
                                              $"\n   F1                                 F1" +
                                              $"\n   F1                                  F1" +
                                              $"\n    F1                                F1" +
                                              $"\n      F1F{G}1F1F-71-LAPS-15-TURNS-F1F1F1{N}F1" + W +
                                              "\n\n                < " + G + "DRS " + W + "Zones - 2 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" + N +
                                              $"\n                     F1F1F1F-BRAZILI-F1F1F1" +
                                              $"\n                  F1F                F1F   F1" +
                                              $"\n               F1F      F1F1F1    F1F  F1    F1{R}" +
                                              $"\n           START{N}     F1F1   F1  F1F   F1F      F1{R} " +
                                              $"\n         F1F{N}        F1       F1F1   F1          F1{R}" +
                                              $"\n      F1F{N}           F1F            F1           F1{R}" +
                                              $"\n   F1F{N}                 F1F1F         F1F1F      F1{R}" +
                                              $"\n F1F{N}                        F1F1F1F       F1F1F1{R}" +
                                              $"\n  F1F{N}                             F1F1{R}" +
                                              $"\n   F1{N}                                 F1{R}" +
                                              $"\n   F1{N}                                  F1{R}" +
                                              $"\n    F1{N}                                F1{R}" +
                                              $"\n      F1F1F1F-71-LAPS-15-TURNS-F1F{N}1F1F1" + W +
                                              "\n\n                  < " + R + "Sector 1" + W + " >                   ");
                                break;
                            case 3:
                                Console.WriteLine("" + N +
                                              $"\n                     F1F1F1F-BRAZILI-F1F1F1" +
                                              $"\n                  F1F                {B}F1F{N}   F1" +
                                              $"\n               F1F      {B}F1F1F1    F1F  F1{N}    F1" +
                                              $"\n           START     {B}F1F1   F1  F1F   F1F{N}      F1" +
                                              $"\n         F1F        {B}F1       F1F1   F1{N}          F1" +
                                              $"\n      F1F           {B}F1F            F1{N}           F1" +
                                              $"\n   F1F                 {B}F1F1F         F1F1F{N}      F1" +
                                              $"\n F1F                        {B}F1F1F1F{N}       F1F1F1" +
                                              $"\n  F1F                             {B}F1F1{N}" +
                                              $"\n   F1                                 {B}F1{N}" +
                                              $"\n   F1                                  {B}F1{N}" +
                                              $"\n    F1                                {B}F1{N}" +
                                              $"\n      F1F1F1F-71-LAPS-15-TURNS-F1F{B}1F1F1" + W +
                                              "\n\n                  < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" + Y +
                                              $"\n                     F1F1F1F-BRAZILI-F1F1F1" +
                                              $"\n                  F1F{N}                F1F   {Y}F1{N}" +
                                              $"\n               {Y}F1F{N}      F1F1F1    F1F  F1    {Y}F1{N}" +
                                              $"\n           START     F1F1   F1  F1F   F1F      {Y}F1{N}" +
                                              $"\n         F1F        F1       F1F1   F1          {Y}F1{N}" +
                                              $"\n      F1F           F1F            F1           {Y}F1{N}" +
                                              $"\n   F1F                 F1F1F         F1F1F      {Y}F1{N}" +
                                              $"\n F1F                        F1F1F1F       {Y}F1F1F1{N}" +
                                              $"\n  F1F                             F1F1" +
                                              $"\n   F1                                 F1" +
                                              $"\n   F1                                  F1" +
                                              $"\n    F1                                F1" +
                                              $"\n      F1F1F1F-71-LAPS-15-TURNS-F1F1F1F1" + W +
                                              "\n\n                  < " + Y + "Sector 3" + W + " >                     ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 22:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                        $"\n{pad}                               F1F1 " + pad +
                        $"\n{pad}                               F1 F1F1F1 " + pad +
                        $"\n{pad}                      ABU-DHABI       F1F1F1 " + pad +
                        $"\n{pad}                   F1F1         F1F1F1F    F1F1F1 " + pad +
                        $"\n{pad}                F1F1       F1F1F1    F1          F1F1F1 " + pad +
                        $"\n{pad}              F1F          F1        S1               F1F1F1 " + pad +
                        $"\n{pad}            F1F F1F1F1     F1        T1                    F1F1F1 " + pad +
                        $"\n{pad}         F1F F1F     F1    F1        A1                         F1F1F1 " + pad +
                        $"\n{pad}       F1F F1F       F1    F1        R1                              F1F1F1 " + pad +
                        $"\n{pad}     F1F  F1          F1F1F1         T1              F1F1F1               F1F1F1 " + pad +
                        $"\n{pad}    F1    F1                         F1            F1F    F-16-TURNS-1         F1 " + pad +
                        $"\n{pad}  F1F    F1                          F1           F1                  F1F1F1F1F1 " + pad +
                        $"\n{pad} F1F    F1F                           F1-58-LAPS-F1 " + pad +
                        $"\n{pad}   F1F1F1 " + pad);
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                            < Length - 5.28KM >                                 \n" +
                                      P + "\n                Lap record" + W + " - 1:26.103 Max Verstappen (2021)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                "\n                               F1F1" +
                                "\n                               F1 F1F1F1" +
                                "\n                      ABU-DHABI       F1F1F1" +
                                "\n                   F1F1         F1F1F1F    F1F1F1" +
                                "\n                F1F1       F1F1F1    F1          F1F1F1" +
                                "\n              F1F          F1        S1               F1F1F1" +
                                "\n            F1F F1F1F1     F1        T1                    F1F1F1" +
                                "\n         F1F F1F     F1    F1        A1                         F1F1F1" +
                                "\n       F1F F1F       F1    F1        R1                              F1F1F1" +
                                "\n     F1F  F1          F1F1F1         T1              F1F1F1               F1F1F1" +
                                "\n    F1    F1                         F1            F1F    F-16-TURNS-1         F1" +
                                "\n  F1F    F1                          F1           F1                  F1F1F1F1F1" +
                                "\n F1F    F1F                           F1-58-LAPS-F1" +
                                "\n   F1F1F1" + W +
                                "\n\n                            < Length - 5.28KM >                                 ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                $"\n                               F1{G}F1{N}" +
                                $"\n                               F1 {G}F1F1F1{N}" +
                                $"\n                      ABU({G}DZ{N})BI       {G}F1F1F1" +
                                $"\n                   F1F1{N}         F1F1F1F    {G}F1F1F1" +
                                $"\n                F1F1{N}       F1F1F1    F1          {G}F1F1F1" +
                                $"\n              F1F{N}          F1        S1               {G}F1F1F1" +
                                $"\n            F1F{N} F1F1F1     F1        T1                    {G}F1F1F1" +
                                $"\n         F1F{N} F1F     F1    F1        A1                         {G}F1F1F1" +
                                $"\n       F1F{N} F1F       F1    F1        R1                              {G}F1F1{N}F1{G}" +
                                $"\n     F1F{N}  F1          F1F1F1         T1              F1F1F1               F1F1F1{G}" +
                                $"\n    F1{N}    F1                         F1            F1F    F-16-TURNS-1         F1{G}" +
                                $"\n  F1F{N}    F1                          F1           F1                 ({G}DZ{N})1F1F1F1" +
                                $"\n F1F    F1F                           F1-58-LAPS-F1" +
                                $"\n   F1F1F1" + W +
                                "\n\n                             < " + G + "DRS " + W + "Zones - 2 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" + N +
                                $"\n                               F1F1" +
                                $"\n                               F1 F1F1F1" +
                                $"\n                      ABU-DHABI       F1F1F1" +
                                $"\n                   F1F1         F1F1F1F    F1F1F1" +
                                $"\n                F1F1       F1F1F1    F1          F1F1F1" +
                                $"\n              F1F          F1        {R}S1{N}               F1F1F1" +
                                $"\n            F1F F1F1F1     F1        {R}T1{N}                    F1F1F1" +
                                $"\n         F1F F1F     F1    F1        {R}A1{N}                         F1F1F1" +
                                $"\n       F1F F1F       F1    F1        {R}R1{N}                              F1F1F1" +
                                $"\n     F1F  F1          F1F1F1         {R}T1              F1F1F1{N}               F1F1F1" +
                                $"\n    F1    F1                         {R}F1            F1F    F-16-TURNS-1{N}         F1" +
                                $"\n  F1F    F1                          {R}F1           F1{N}                  F1F1F1F1F1" +
                                $"\n F1F    F1F                           {R}F1-58-LAPS-F1{N}" +
                                $"\n   F1F1F1" + W +
                                "\n\n                               < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" + B +
                                $"\n                               F1F1" +
                                $"\n                               F1 F1F1F1" +
                                $"\n                      ABU-DHABI       F1F1F1" +
                                $"\n                   F1F1{N}         F1F1F1F    {B}F1F1F1" +
                                $"\n                F1F1{N}       F1F1F1    F1          {B}F1F1F1" +
                                $"\n              F1F{N}          F1        S1               {B}F1F1F1" +
                                $"\n            F1F{N} F1F1F1     F1        T1                    {B}F1F1F1" +
                                $"\n         F1F{N} F1F     F1    F1        A1                         {B}F1F1F1" +
                                $"\n       F1F{N} F1F       F1    F1        R1                              {B}F1F1F1" +
                                $"\n     F1F{N}  F1          F1F1F1         T1              F1F1F1               {B}F1F1F1" +
                                $"\n    F1{N}    F1                         F1            F1F    F-16-TURNS-1         {B}F1{N}" +
                                $"\n  F1F    F1                          F1           F1                  {B}F1F1F1F1F1{N}" +
                                $"\n F1F    F1F                           F1-58-LAPS-F1" +
                                $"\n   F1F1F1" + W +
                                "\n\n                               < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" + N +
                                $"\n                               F1F1" +
                                $"\n                               F1 F1F1F1" +
                                $"\n                      ABU-DHABI       F1F1F1" +
                                $"\n                   F1F1         {Y}F1F1F1F{N}    F1F1F1" +
                                $"\n                F1F1       {Y}F1F1F1    F1{N}          F1F1F1" +
                                $"\n              F1F          {Y}F1{N}        S1               F1F1F1" +
                                $"\n            F1F {Y}F1F1F1     F1{N}        T1                    F1F1F1" +
                                $"\n         F1F {Y}F1F     F1    F1{N}        A1                         F1F1F1" +
                                $"\n       F1F {Y}F1F       F1    F1{N}        R1                              F1F1F1" +
                                $"\n     F1F  {Y}F1          F1F1F1{N}         T1              F1F1F1               F1F1F1" +
                                $"\n    F1    {Y}F1{N}                         F1            F1F    F-16-TURNS-1         F1" +
                                $"\n  {Y}F1F    F1{N}                          F1           F1                  F1F1F1F1F1" +
                                $"\n {Y}F1F    F1F{N}                           F1-58-LAPS-F1" +
                                $"\n   {Y}F1F1F1" + W +
                                "\n\n                               < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                case 23:
                    SelMap = 0;
                    for (int i = 17; i > -1; --i)
                    {
                        Console.SetCursorPosition(0, 3);
                        Console.Write($"\x1b[38;5;{234 + (17 - i)}m");
                        string pad = "".PadLeft(i);
                        Console.WriteLine("" +
                        $"\n{pad}                                       F1F1F1 " + pad +
                        $"\n{pad}                                     F1     F1    F1F1F1 " + pad +
                        $"\n{pad}            F1F1F1F1F1             F1       F1   F1     F1 " + pad +
                        $"\n{pad}            F1       F1-PORTUGAL-F1         F1     F1     F1 " + pad +
                        $"\n{pad}    F1F1     F1                             F1       F1     F1 " + pad +
                        $"\n{pad}   F1  F1     F1F1F1F1F1F1F1F1F1F1           F1F1F1    F1     F1 " + pad +
                        $"\n{pad}  F1    F1                        F1F1            F1F1F1       F1 " + pad +
                        $"\n{pad} F1      F1F1-66-LAPS-15-TURNS-F1F1F1F1                        F1 " + pad +
                        $"\n{pad}  F1                                                          F1 " + pad +
                        $"\n{pad}   F1                                                        F1 " + pad +
                        $"\n{pad}    F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START1F1F1F1F1F1F1F1F1F1F1 ");
                        Task.Delay(2).Wait();
                    }
                    Console.WriteLine(W + "\n                      < Length - 4.65KM >             \n" +
                                      P + "\n          Lap record" + W + " - 1:18.750 Lewis Hamilton (2020)");
                    do
                    {
                        Console.SetCursorPosition(0, 3);
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow && SelMap == 0)
                            SelMap = 4;
                        else if (key.Key == ConsoleKey.LeftArrow && SelMap != 0)
                            SelMap--;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap == 4)
                            SelMap = 0;
                        else if (key.Key == ConsoleKey.RightArrow && SelMap != 4)
                            SelMap++;
                        switch (SelMap)
                        {
                            case 0:
                                Console.WriteLine("" + N +
                                    $"\n                                       F1F1F1 " +
                                    $"\n                                     F1     F1    F1F1F1 " +
                                    $"\n            F1F1F1F1F1             F1       F1   F1     F1 " +
                                    $"\n            F1       F1-PORTUGAL-F1         F1     F1     F1 " +
                                    $"\n    F1F1     F1                             F1       F1     F1 " +
                                    $"\n   F1  F1     F1F1F1F1F1F1F1F1F1F1           F1F1F1    F1     F1 " +
                                    $"\n  F1    F1                        F1F1            F1F1F1       F1 " +
                                    $"\n F1      F1F1-66-LAPS-15-TURNS-F1F1F1F1                        F1 " +
                                    $"\n  F1                                                          F1 " +
                                    $"\n   F1                                                        F1 " +
                                    $"\n    F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START1F1F1F1F1F1F1F1F1F1F1 " + W +
                                    "\n\n                      < Length - 4.65KM > ");
                                break;
                            case 1:
                                Console.WriteLine("" + N +
                                    $"\n                                       F1F1F1 " +
                                    $"\n                                     F1     F1    F1F1F1 " +
                                    $"\n            F1F1F1F1F1             F1       F1   F1     F1 " +
                                    $"\n            F1       F1-PORTUGAL-F1         F1     F1     F1 " +
                                    $"\n    F1F1     F1                             F1       F1     F1 " +
                                    $"\n   F1 ({G}DZ{N})    F1F1F1F1F1F1F1F1F1F1           F1F1F1    F1     F1 " +
                                    $"\n  F1    F1                        F1F1            F1F1F1      ({G}DZ{N}) " +
                                    $"\n F1      F1F1-{G}66-LAPS-15-TURNS-F1F1F1{N}F1                        F1 " +
                                    $"\n  F1                                                          F1 " +
                                    $"\n   F1                                                        F1 " +
                                    $"\n    F1F1{G}F1F1F1F1F1F1F1F1F1F1F1F1F1F1START1F1{N}F1F1F1F1F1F1F1F1F1 " + W +
                                    "\n\n                       < " + G + "DRS " + W + "Zones - 2 >                 ");
                                break;
                            case 2:
                                Console.WriteLine("" + N +
                                    $"\n                                       F1F1F1 " +
                                    $"\n                                     F1     F1    F1F1F1 " +
                                    $"\n            F1F1F1F1F1             F1       F1   F1     F1 " +
                                    $"\n            F1       F1-PORTUGAL-F1         F1     F1     F1 " +
                                    $"\n{R}    F1F1{N}     F1                             F1       F1     F1 " +
                                    $"\n{R}   F1  F1{N}     F1F1F1F1F1F1F1F1F1F1           F1F1F1    F1     F1 " +
                                    $"\n{R}  F1    F1{N}                        F1F1            F1F1F1       F1 " +
                                    $"\n{R} F1      F1F1-66-LAPS{N}-15-TURNS-F1F1F1F1                        F1 " +
                                    $"\n{R}  F1{N}                                                          F1 " +
                                    $"\n{R}   F1{N}                                                        F1 " +
                                    $"\n{R}    F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START{N}1F1F1F1F1F1F1F1F1F1F1 " + W +
                                    "\n\n                         < " + R + "Sector 1" + W + " >                      ");
                                break;
                            case 3:
                                Console.WriteLine("" + B +
                                    $"\n                                       F1F1F1 " +
                                    $"\n                                     F1     F1{N}    F1F1F1 " +
                                    $"\n{B}            F1F1F1F1F1             F1       F1{N}   F1     F1 " +
                                    $"\n{B}            F1       F1-PORTUGAL-F1{N}         F1     F1     F1 " +
                                    $"\n    F1F1{B}     F1{N}                             F1       F1     F1 " +
                                    $"\n   F1  F1{B}     F1F1F1F1F1F1F1F1F1F1{N}           F1F1F1    F1     F1 " +
                                    $"\n  F1    F1{B}                        F1F1{N}            F1F1F1       F1 " +
                                    $"\n F1      F1F1-66-LAPS{B}-15-TURNS-F1F1F1F1{N}                        F1 " +
                                    $"\n  F1                                                          F1 " +
                                    $"\n   F1                                                        F1 " +
                                    $"\n    F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START1F1F1F1F1F1F1F1F1F1F1 " + W +
                                    "\n\n                         < " + B + "Sector 2" + W + " >                     ");
                                break;
                            case 4:
                                Console.WriteLine("" + N +
                                    $"\n                                       F1F1F1 " +
                                    $"\n                                     F1     F1{Y}    F1F1F1{N} " +
                                    $"\n            F1F1F1F1F1             F1       F1{Y}   F1     F1{N} " +
                                    $"\n            F1       F1-PORTUGAL-F1{Y}         F1     F1     F1{N} " +
                                    $"\n    F1F1     F1{Y}                             F1       F1     F1{N} " +
                                    $"\n   F1  F1     F1F1F1F1F1F1F1F1F1F1{Y}           F1F1F1    F1     F1{N} " +
                                    $"\n  F1    F1                        F1F1{Y}            F1F1F1       F1{N} " +
                                    $"\n F1      F1F1-66-LAPS-15-TURNS-F1F1F1F1{Y}                        F1{N} " +
                                    $"\n  F1{Y}                                                          F1{N} " +
                                    $"\n   F1{Y}                                                        F1{N} " +
                                    $"\n    F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1F1START{Y}1F1F1F1F1F1F1F1F1F1F1 " + W +
                                    "\n\n                         < " + Y + "Sector 3" + W + " >                   ");
                                break;
                        }
                    } while (key.Key != ConsoleKey.Escape);
                    break;
                default:
                    break;
            }
        }
    }
}
