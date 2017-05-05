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
                        List<Risaedluspilid> chrispratt = new List<Risaedluspilid>();

                        chrispratt.Add(new Risaedluspilid("Þvengeðla", "0.7", "3", "1.4", "5", "7", "145"));
                        chrispratt.Add(new Risaedluspilid("Miðhyrna", "2", "1000", "6", "2", "4", "76"));
                        chrispratt.Add(new Risaedluspilid("Bageðla", "0.8", "50", "2", "1", "6", "125"));
                        chrispratt.Add(new Risaedluspilid("Blakeðla", "0.25", "4", "0.25", "4", "0", "200"));
                        chrispratt.Add(new Risaedluspilid("Finngálkn", "16", "80000", "26", "3", "2", "156"));
                        chrispratt.Add(new Risaedluspilid("Skegla", "5", "4500", "10", "3", "6", "135"));
                        chrispratt.Add(new Risaedluspilid("Kjálkeðla", "1", "350", "5", "7", "6", "230"));
                        chrispratt.Add(new Risaedluspilid("Eintönnungur", "0.5", "10", "1.2", "1", "5", "208"));
                        chrispratt.Add(new Risaedluspilid("Öglir", "0.3", "6", "0.3", "6", "5", "150"));
                        chrispratt.Add(new Risaedluspilid("Freyjueðla", "2.5", "3000", "9", "2", "3", "80"));
                        chrispratt.Add(new Risaedluspilid("Gaddygli", "1.8", "2000", "6", "3", "3", "76"));
                        chrispratt.Add(new Risaedluspilid("Grameðla", "5.6", "6000", "12", "9", "9", "67"));
                        chrispratt.Add(new Risaedluspilid("Þykkhöfði", "6", "3000", "8", "2", "7", "76"));
                        chrispratt.Add(new Risaedluspilid("Nashyrningseðla", "3", "5500", "9", "2", "4", "72"));
                        chrispratt.Add(new Risaedluspilid("Íguleðla", "2", "3000", "5", "2", "3", "77"));
                        chrispratt.Add(new Risaedluspilid("Kambeðla", "3", "3100", "9", "2", "1", "76"));
                        chrispratt.Add(new Risaedluspilid("Sagtanni", "1.8", "60", "0", "7", "10", "76"));
                        chrispratt.Add(new Risaedluspilid("Breiðnasi", "3", "0", "6", "2", "4", "70"));
                        chrispratt.Add(new Risaedluspilid("Trölgarmur", "6", "8000", "16", "10", "7", "100"));
                        chrispratt.Add(new Risaedluspilid("Frumhyrna", "1.5", "400", "2", "2", "4", "72"));
                        chrispratt.Add(new Risaedluspilid("Drísileðla", "2", "27", "3", "4", "7", "225"));
                        chrispratt.Add(new Risaedluspilid("Snareðla", "1", "15", "2", "9", "10", "85"));
                        chrispratt.Add(new Risaedluspilid("Rumeðla", "3", "1000", "9", "9", "8", "175"));
                        chrispratt.Add(new Risaedluspilid("Eggjagrípur", "0.8", "20", "1.8", "5", "8", "70"));
                        chrispratt.Add(new Risaedluspilid("Krókódílaeðla", "4", "0", "12", "8", "7", "100"));
                        chrispratt.Add(new Risaedluspilid("Kúfeðla", "5", "5000", "8", "2", "5", "80"));
                        chrispratt.Add(new Risaedluspilid("Hænsneðla", "3", "200", "5.6", "5", "7", "74"));
                        chrispratt.Add(new Risaedluspilid("Fimmhyrna", "3", "8000", "8", "3", "5", "75"));
                        chrispratt.Add(new Risaedluspilid("Gíraffaeðla", "9", "20000", "18", "3", "2", "150"));
                        break;
                    case "2":

                        Random randomSjavardyr = new Random();

                        List<Sjávardýr> sjavardyr = new List<Sjávardýr>();
                        List<Sjávardýr> spilTolvu = new List<Sjávardýr>();
                        List<Sjávardýr> SpilNotanda = new List<Sjávardýr>();
                        List<int> valStokkur = new List<int>();

                        int teljariSpil = 0;
                        //int val2 = 0;

                        sjavardyr.Add(new Sjávardýr("ELDFISKUR", "3", "16", "2", "13", "0", ""));
                        sjavardyr.Add(new Sjávardýr("Sæotur", "4", "10", "4", "14", "4", ""));
                        sjavardyr.Add(new Sjávardýr("BEINHÁKARL", "5", "0", "2", "21", "3", ""));
                        sjavardyr.Add(new Sjávardýr("SLÉTTBAKUR", "8", "0", "3", "34", "4", ""));
                        sjavardyr.Add(new Sjávardýr("SANDTÍGRISHÁFUR", "6", "13", "2", "25", "3", ""));
                        sjavardyr.Add(new Sjávardýr("GOLÍATVARTARI", "3", "4", "4", "13", "5", ""));
                        sjavardyr.Add(new Sjávardýr("STÓRI HVÍTHÁFUR", "6", "1", "2", "25", "3", ""));
                        sjavardyr.Add(new Sjávardýr("FLJÓTASAGSKATA", "5", "2", "8", "21", "5", ""));
                        sjavardyr.Add(new Sjávardýr("HÁFUR", "3", "2", "2", "13", "3", ""));
                        sjavardyr.Add(new Sjávardýr("HVALHÁKARL", "6", "0", "2", "27", "3", ""));
                        sjavardyr.Add(new Sjávardýr("BRÚNI KANI", "3", "18", "4", "10", "1", ""));
                        sjavardyr.Add(new Sjávardýr("SÆSTEINSUGA", "4", "0", "5", "20", "1", ""));
                        sjavardyr.Add(new Sjávardýr("FLÓÐMANATA", "5", "5", "10", "19", "3", ""));
                        sjavardyr.Add(new Sjávardýr("DJÖFLASKATA", "6", "0", "3", "26", "2", ""));
                        sjavardyr.Add(new Sjávardýr("RÁKASÆHESTUR", "2", "13", "4", "8", "3", ""));
                        sjavardyr.Add(new Sjávardýr("ROSTUNGUR", "3", "4", "3", "12", "1", ""));
                        sjavardyr.Add(new Sjávardýr("STUTTNEFSSTYRJA", "4", "2", "7", "21", "3", ""));
                        sjavardyr.Add(new Sjávardýr("SEBRAHÁFUR", "5", "9", "4", "23", "3", ""));
                        sjavardyr.Add(new Sjávardýr("DISKASLEGGJUHÁFUR", "4", "8", "2", "19", "1", ""));
                        sjavardyr.Add(new Sjávardýr("LANGREYÐUR", "4", "0", "3", "17", "4", ""));
                        sjavardyr.Add(new Sjávardýr("ÆGISFÁLA", "7", "9", "6", "30", "5", ""));
                        sjavardyr.Add(new Sjávardýr("MJALDUR", "4", "4", "5", "15", "3", ""));
                        sjavardyr.Add(new Sjávardýr("kYRRAHAFSTÚNFISKUR", "5", "2", "3", "22", "ÓS", ""));
                        sjavardyr.Add(new Sjávardýr("KEISARAMÖRGÆS", "3", "8", "4", "13", "1", ""));
                        sjavardyr.Add(new Sjávardýr("BLÖÐKUHESTUR", "3", "5", "6", "13", "2", ""));
                        sjavardyr.Add(new Sjávardýr("STÖKKULL", "1", "6", "4", "3", "1", ""));
                        sjavardyr.Add(new Sjávardýr("HÁHYRNINGUR", "5", "4", "5", "20", "1", ""));
                        sjavardyr.Add(new Sjávardýr("NEFBARÐASKATA", "3", "8", "3", "13", "2", ""));
                        sjavardyr.Add(new Sjávardýr("BLETTAGAMMSKATA", "4", "2", "2", "21", "2", ""));
                        sjavardyr.Add(new Sjávardýr("HNÚFUBAKUR", "4", "0", "5", "17", "3", ""));

                        while (sjavardyr.Count() > 0)
                            {
                            int randtala = randomSjavardyr.Next(0, sjavardyr.Count());
                            if (teljariSpil % 2 == 0)
                                {
                                
                                    SpilNotanda.Add(sjavardyr[randtala]);
                            
                                }//end if
                            else
                            {
                                spilTolvu.Add(sjavardyr[randtala]);
                            }//end 
                            
                                teljariSpil++;
                                sjavardyr.Remove(sjavardyr[randtala]);
                            }
                        //seta hérna inn textan sem eg sendi þér
                        
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
