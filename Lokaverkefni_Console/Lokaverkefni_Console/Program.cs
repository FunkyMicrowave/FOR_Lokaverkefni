using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1_BAJ_MB;

/*
 * Brynjólfur Axel Jóhannesson
 * Matthías Birgisson
 */
namespace Lokaverkefni_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                Logo();
                Loading(counter);
                counter++;
                System.Threading.Thread.Sleep(500);
                Console.Clear();
            } while (counter != 12);

            Console.ForegroundColor = ConsoleColor.White;
            string val = "0";
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Risaedlu spilið");
                    Console.WriteLine("2. Sjávardýra spilið");
                    Console.WriteLine("0. HÆTTA");

                    val = Console.ReadLine();
                    switch (val)
                    {
                    case "1":
                        Risaedluspilid Þvengeðla = new Risaedluspilid("Þvengeðla", "0.7", "3", "1.4", "5", "7", "145");
                        Risaedluspilid Miðhyrna = new Risaedluspilid("Miðhyrna", "2", "1000", "6", "2", "4", "76");
                        Risaedluspilid Bageðla = new Risaedluspilid("Bageðla", "0.8", "50", "2", "1", "6", "125");
                        Risaedluspilid Blakeðla = new Risaedluspilid("Blakeðla", "0.25", "4", "0.25", "4", "0", "200");
                        Risaedluspilid Finngálkn = new Risaedluspilid("Finngálkn", "16", "80000", "26", "3", "2", "156");
                        Risaedluspilid Skegla = new Risaedluspilid("Skegla", "5", "4500", "10", "3", "6", "135");
                        Risaedluspilid Kjálkeðla = new Risaedluspilid("Kjálkeðla", "1", "350", "5", "7", "6", "230");
                        Risaedluspilid Eintönnungur = new Risaedluspilid("Eintönnungur", "0.5", "10", "1.2", "1", "5", "208");
                        Risaedluspilid Öglir = new Risaedluspilid("Öglir", "0.3", "6", "0.3", "6", "5", "150");
                        Risaedluspilid Freyjueðla = new Risaedluspilid("Freyjueðla", "2.5", "3000", "9", "2", "3", "80");
                        Risaedluspilid Gaddygli = new Risaedluspilid("Gaddygli", "1.8", "2000", "6", "3", "3", "76");
                        Risaedluspilid Grameðla = new Risaedluspilid("Grameðla", "5.6", "6000", "12", "9", "9", "67");
                        Risaedluspilid Þykkhöfði = new Risaedluspilid("Þykkhöfði", "6", "3000", "8", "2", "7", "76");
                        Risaedluspilid Nashyrningseðla = new Risaedluspilid("Nashyrningseðla", "3", "5500", "9", "2", "4", "72");
                        Risaedluspilid Íguleðla = new Risaedluspilid("Íguleðla", "2", "3000", "5", "2", "3", "77");
                        Risaedluspilid Kambeðla = new Risaedluspilid("Kambeðla", "3", "3100", "9", "2", "1", "76");
                        Risaedluspilid Sagtanni = new Risaedluspilid("Sagtanni", "1.8", "60", "0", "7", "10", "76");
                        Risaedluspilid Breiðnasi = new Risaedluspilid("Breiðnasi", "3", "0", "6", "2", "4", "70");
                        Risaedluspilid Tröllgarmur = new Risaedluspilid("Trölgarmur", "6", "8000", "16", "10", "7", "100");
                        Risaedluspilid Frumhyrna = new Risaedluspilid("Frumhyrna", "1.5", "400", "2", "2", "4", "72");
                        Risaedluspilid Drísileðla = new Risaedluspilid("Drísileðla", "2", "27", "3", "4", "7", "225");
                        Risaedluspilid Snareðla = new Risaedluspilid("Snareðla", "1", "15", "2", "9", "10", "85");
                        Risaedluspilid Rumeðla = new Risaedluspilid("Rumeðla", "3", "1000", "9", "9", "8", "175");
                        Risaedluspilid Eggjagrípur = new Risaedluspilid("Eggjagrípur", "0.8", "20", "1.8", "5", "8", "70");
                        Risaedluspilid Krókódílaeðla = new Risaedluspilid("Krókódílaeðla", "4", "0", "12", "8", "7", "100");
                        Risaedluspilid Kúfeðla = new Risaedluspilid("Kúfeðla", "5", "5000", "8", "2", "5", "80");
                        Risaedluspilid Hænsneðla = new Risaedluspilid("Hænsneðla", "3", "200", "5.6", "5", "7", "74");
                        Risaedluspilid Fimmhyrna = new Risaedluspilid("Fimmhyrna", "3", "8000", "8", "3", "5", "75");
                        Risaedluspilid Gíraffaeðla = new Risaedluspilid("Gíraffaeðla", "9", "20000", "18", "3", "2", "150");
                        break;
                    case "2":
                        Sjávardýr ELDFISKUR = new Sjávardýr("ELDFISKUR","3","16","2","13","0","");
                        Sjávardýr SÆOTUR = new Sjávardýr("Sæotur", "4", "10", "4", "14", "4", "");
                        Sjávardýr BEINHÁKARL = new Sjávardýr("BEINHÁKARL", "5", "0", "2", "21", "3", "");
                        Sjávardýr SLÉTTBAKUR = new Sjávardýr("SLÉTTBAKUR", "8", "0", "3", "34", "4", "");
                        Sjávardýr SANDTÍGRISHÁFUR = new Sjávardýr("SANDTÍGRISHÁFUR", "6", "13", "2", "25", "3", "");
                        Sjávardýr GOLÍATVARTARI = new Sjávardýr("GOLÍATVARTARI", "3", "4", "4", "13", "5", "");
                        Sjávardýr STÓRI_HVÍTHÁFUR = new Sjávardýr("STÓRI HVÍTHÁFUR", "6", "1", "2", "25", "3", "");
                        Sjávardýr FLJÓTASAGSKATA = new Sjávardýr("FLJÓTASAGSKATA", "5", "2", "8", "21", "5", "");
                        Sjávardýr HÁFUR = new Sjávardýr("HÁFUR", "3", "2", "2", "13", "3", "");
                        Sjávardýr HVALHÁKARL = new Sjávardýr("HVALHÁKARL", "6", "0", "2", "27", "3", "");
                        Sjávardýr BRÚNI_KANI = new Sjávardýr("BRÚNI KANI", "3", "18", "4", "10", "1", "");
                        Sjávardýr SÆSTEINSUGA = new Sjávardýr("SÆSTEINSUGA", "4", "0", "5", "20", "1", "");
                        Sjávardýr FLÓÐMANATA = new Sjávardýr("FLÓÐMANATA", "5", "5", "10", "19", "3", "");
                        Sjávardýr DJÖFLASKATA = new Sjávardýr("DJÖFLASKATA", "6", "0", "3", "26", "2", "");
                        Sjávardýr RÁKASÆHESTUR = new Sjávardýr("RÁKASÆHESTUR", "2", "13", "4", "8", "3", "");
                        Sjávardýr ROSTUNGUR = new Sjávardýr("ROSTUNGUR", "3", "4", "3", "12", "1", "");
                        Sjávardýr STUTTNEFSSTYRJA = new Sjávardýr("STUTTNEFSSTYRJA", "4", "2", "7", "21", "3", "");
                        Sjávardýr SEBRAHÁFUR = new Sjávardýr("SEBRAHÁFUR", "5", "9", "4", "23", "3", "");
                        Sjávardýr DISKASLEGGJUHÁFUR = new Sjávardýr("DISKASLEGGJUHÁFUR", "4", "8", "2", "19", "1", "");
                        Sjávardýr LANGREYÐUR = new Sjávardýr("LANGREYÐUR", "4", "0", "3", "17", "4", "");
                        Sjávardýr ÆGISFÁLA = new Sjávardýr("ÆGISFÁLA", "7", "9", "6", "30", "5", "");
                        Sjávardýr MJALDUR = new Sjávardýr("MJALDUR", "4", "4", "5", "15", "3", "");
                        Sjávardýr kYRRAHAFSTÚNFISKUR = new Sjávardýr("kYRRAHAFSTÚNFISKUR", "5", "2", "3", "22", "ÓS", "");
                        Sjávardýr KEISARAMÖRGÆS = new Sjávardýr("KEISARAMÖRGÆS", "3", "8", "4", "13", "1", "");
                        Sjávardýr BLÖÐKUSÆHESTUR = new Sjávardýr("BLÖÐKUHESTUR", "3", "5", "6", "13", "2", "");
                        Sjávardýr STÖKKULL = new Sjávardýr("STÖKKULL", "1", "6", "4", "3", "1", "");
                        Sjávardýr HÁHYNRINGUR = new Sjávardýr("HÁHYRNINGUR", "5", "4", "5", "20", "1", "");
                        Sjávardýr NEFBARÐASKATA = new Sjávardýr("NEFBARÐASKATA", "3", "8", "3", "13", "2", "");
                        Sjávardýr BLETTAGAMMSKATA = new Sjávardýr("BLETTAGAMMSKATA", "4", "2", "2", "21", "2", "");
                        Sjávardýr HNÚFUBAKUR = new Sjávardýr("HNÚFUBAKUR", "4", "0", "5", "17", "3", "");

                        break;
                        default:
                            break;
                    }
                    Console.ReadKey();
                } while (val != "0");
            Console.ReadKey();
        }


        static void Loading(int counter)
        {
            for (int i = 0; i < 7; i++)
            {
                Svartur();
            }
            for (int i = 0; i <= counter; i++)
            {
                Blar();
            }
            for (int i = 0; i <= (10 - counter); i++)
            {
                Hvitur();
            }
            Console.WriteLine();
        }
        static void Gulur()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Raudur()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("__");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Graenn()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("__");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Blar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("__");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Svartur()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("__");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Hvitur()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("__");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Grar()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("__");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static void Logo()
        {
            Console.WriteLine();
            Svartur();
            Svartur();
            Svartur();
            Svartur();
            Raudur();
            Raudur();
            Raudur();
            Console.WriteLine();

            Svartur();
            Svartur();
            for (int i = 0; i < 7; i++)
            {
                Raudur();
            }
            Console.WriteLine();

            Svartur();
            for (int i = 0; i < 9; i++)
            {
                Raudur();
            }
            Console.WriteLine();

            Svartur();
            for (int i = 0; i < 10; i++)
            {
                Raudur();
            }
            Svartur();
            Graenn();
            for (int i = 0; i < 7; i++)
            {
                Svartur();
            }
            Graenn();
            Graenn();
            Console.WriteLine();

            Svartur();
            for (int i = 0; i < 10; i++)
            {
                Raudur();
            }
            Svartur();
            Graenn();
            Graenn();
            Graenn();
            Svartur();
            Svartur();
            Svartur();
            for (int i = 0; i < 4; i++)
            {
                Graenn();
            }
            Console.WriteLine();

            for (int k = 0; k < 4; k++)
            {
                Svartur();
                for (int i = 0; i < 10; i++)
                {
                    Raudur();
                }
                Svartur();
                for (int i = 0; i < 10; i++)
                {
                    Graenn();
                }
                Console.WriteLine();
            }


            Svartur();
            Raudur();
            Raudur();
            Raudur();
            Svartur();
            Svartur();
            Svartur();
            Raudur();
            Raudur();
            Raudur();
            Raudur();
            Svartur();
            for (int i = 0; i < 10; i++)
            {
                Graenn();
            }
            Console.WriteLine();

            Svartur();
            Raudur();
            Svartur();
            Svartur();
            Blar();
            Blar();
            Blar();
            Svartur();
            Svartur();
            Raudur();
            Raudur();
            Svartur();
            for (int i = 0; i < 10; i++)
            {
                Graenn();
            }
            Console.WriteLine();

            Svartur();
            Svartur();
            for (int i = 0; i < 7; i++)
            {
                Blar();
            }
            Svartur();
            Svartur();
            Svartur();
            for (int i = 0; i < 10; i++)
            {
                Graenn();
            }
            Console.WriteLine();

            Svartur();
            for (int i = 0; i < 10; i++)
            {
                Blar();
            }
            Svartur();
            Svartur();
            for (int i = 0; i < 7; i++)
            {
                Graenn();
            }
            Console.WriteLine();

            Svartur();
            for (int i = 0; i < 10; i++)
            {
                Blar();
            }
            Svartur();
            Gulur();
            Svartur();
            Svartur();
            Graenn();
            Graenn();
            Graenn();
            Svartur();
            Svartur();
            Gulur();
            Gulur();
            Console.WriteLine();

            Svartur();
            for (int i = 0; i < 10; i++)
            {
                Blar();
            }
            Svartur();
            Gulur();
            Gulur();
            Gulur();
            Svartur();
            Svartur();
            Svartur();
            for (int i = 0; i < 4; i++)
            {
                Gulur();
            }
            Console.WriteLine();

            for (int k = 0; k < 4; k++)
            {
                Svartur();
                for (int i = 0; i < 10; i++)
                {
                    Blar();
                }
                Svartur();
                for (int i = 0; i < 10; i++)
                {
                    Gulur();
                }
                Console.WriteLine();
            }

            Svartur();
            Blar();
            Blar();
            Blar();
            Svartur();
            Svartur();
            Svartur();
            for (int i = 0; i < 4; i++)
            {
                Blar();
            }
            Svartur();
            for (int i = 0; i < 10; i++)
            {
                Gulur();
            }
            Console.WriteLine();

            Svartur();
            Blar();
            for (int i = 0; i < 7; i++)
            {
                Svartur();
            }
            Blar();
            Blar();
            Svartur();
            for (int i = 0; i < 10; i++)
            {
                Gulur();
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Svartur();
            }
            Blar();
            Svartur();
            for (int i = 0; i < 10; i++)
            {
                Gulur();
            }
            Console.WriteLine();

            for (int i = 0; i < 13; i++)
            {
                Svartur();
            }
            for (int i = 0; i < 8; i++)
            {
                Gulur();
            }
            Console.WriteLine();

            for (int i = 0; i < 15; i++)
            {
                Svartur();
            }
            for (int i = 0; i < 4; i++)
            {
                Gulur();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
