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
            Console.OutputEncoding = Encoding.Unicode;
            /*int counter = 0;
            do
            {
                Logo();
                Loading(counter);
                counter++;
                System.Threading.Thread.Sleep(500);
                Console.Clear();
            } while (counter != 12);*/

            Console.ForegroundColor = ConsoleColor.White;
            string val = "0";
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Risaedlu spilið");
                    Console.WriteLine("2. Sjávardýra spilið");
                    Console.WriteLine("0. HÆTTA");

                    val = Console.ReadLine();
                Console.Clear();
                switch (val)
                {
                    case "1":
                        Risaedluspilid risaedlanr1 = new Risaedluspilid("Þvengeðla", "0.7", "3", "1.4", "5", "7", "145");
                        Risaedluspilid risaedlanr2 = new Risaedluspilid("Miðhyrna", "2", "1000", "6", "2", "4", "76");
                        Risaedluspilid risaedlanr3 = new Risaedluspilid("Bageðla", "0.8", "50", "2", "1", "6", "125");
                        Risaedluspilid risaedlanr4 = new Risaedluspilid("Blakeðla", "0.25", "4", "0.25", "4", "0", "200");
                        Risaedluspilid risaedlanr5 = new Risaedluspilid("Finngálkn", "16", "80000", "26", "3", "2", "156");
                        Risaedluspilid risaedlanr6 = new Risaedluspilid("Skegla", "5", "4500", "10", "3", "6", "135");
                        Risaedluspilid risaedlanr7 = new Risaedluspilid("Kjálkeðla", "1", "350", "5", "7", "6", "230");
                        Risaedluspilid risaedlanr8 = new Risaedluspilid("Eintönnungur", "0.5", "10", "1.2", "1", "5", "208");
                        Risaedluspilid risaedlanr9 = new Risaedluspilid("Öglir", "0.3", "6", "0.3", "6", "5", "150");
                        Risaedluspilid risaedlanr10 = new Risaedluspilid("Freyjueðla", "2.5", "3000", "9", "2", "3", "80");
                        Risaedluspilid risaedlanr11 = new Risaedluspilid("Gaddygli", "1.8", "2000", "6", "3", "3", "76");
                        Risaedluspilid risaedlanr12 = new Risaedluspilid("Grameðla", "5.6", "6000", "12", "9", "9", "67");
                        Risaedluspilid risaedlanr13 = new Risaedluspilid("Þykkhöfði", "6", "3000", "8", "2", "7", "76");
                        Risaedluspilid risaedlanr14 = new Risaedluspilid("Nashyrningseðla", "3", "5500", "9", "2", "4", "72");
                        Risaedluspilid risaedlanr15 = new Risaedluspilid("Íguleðla", "2", "3000", "5", "2", "3", "77");
                        Risaedluspilid risaedlanr16 = new Risaedluspilid("Kambeðla", "3", "3100", "9", "2", "1", "76");
                        Risaedluspilid risaedlanr17 = new Risaedluspilid("Sagtanni", "1.8", "60", "0", "7", "10", "76");
                        Risaedluspilid risaedlanr18 = new Risaedluspilid("Breiðnasi", "3", "0", "6", "2", "4", "70");
                        Risaedluspilid risaedlanr19 = new Risaedluspilid("Tröllgarmur", "6", "8000", "16", "10", "7", "100");
                        Risaedluspilid risaedlanr20 = new Risaedluspilid("Trölleðla", "26", "40000", "26", "3", "2", "156");
                        Risaedluspilid risaedlanr21 = new Risaedluspilid("Frumhyrna", "1.5", "400", "2", "2", "4", "72");
                        Risaedluspilid risaedlanr22 = new Risaedluspilid("Drísileðla", "2", "27", "3", "4", "7", "225");
                        Risaedluspilid risaedlanr23 = new Risaedluspilid("Snareðla", "1", "15", "2", "9", "10", "85");
                        Risaedluspilid risaedlanr24 = new Risaedluspilid("Rumeðla", "3", "1000", "9", "9", "8", "175");
                        Risaedluspilid risaedlanr25 = new Risaedluspilid("Eggjagrípur", "0.8", "20", "1.8", "5", "8", "70");
                        Risaedluspilid risaedlanr26 = new Risaedluspilid("Krókódílaeðla", "4", "0", "12", "8", "7", "100");
                        Risaedluspilid risaedlanr27 = new Risaedluspilid("Kúfeðla", "5", "5000", "8", "2", "5", "80");
                        Risaedluspilid risaedlanr28 = new Risaedluspilid("Hænsneðla", "3", "200", "5.6", "5", "7", "74");
                        Risaedluspilid risaedlanr29 = new Risaedluspilid("Fimmhyrna", "3", "8000", "8", "3", "5", "75");
                        Risaedluspilid risaedlanr30 = new Risaedluspilid("Gíraffaeðla", "9", "20000", "18", "3", "2", "150");
                        Risaedluspilid[] risaedlufylki = new Risaedluspilid[30];
                        risaedlufylki[0] = risaedlanr1;
                        risaedlufylki[1] = risaedlanr2;
                        risaedlufylki[2] = risaedlanr3;
                        risaedlufylki[3] = risaedlanr4;
                        risaedlufylki[4] = risaedlanr5;
                        risaedlufylki[5] = risaedlanr6;
                        risaedlufylki[6] = risaedlanr7;
                        risaedlufylki[7] = risaedlanr8;
                        risaedlufylki[8] = risaedlanr9;
                        risaedlufylki[9] = risaedlanr10;
                        risaedlufylki[10] = risaedlanr11;
                        risaedlufylki[11] = risaedlanr12;
                        risaedlufylki[12] = risaedlanr13;
                        risaedlufylki[13] = risaedlanr14;
                        risaedlufylki[14] = risaedlanr15;
                        risaedlufylki[15] = risaedlanr16;
                        risaedlufylki[16] = risaedlanr17;
                        risaedlufylki[17] = risaedlanr18;
                        risaedlufylki[18] = risaedlanr19;
                        risaedlufylki[19] = risaedlanr20;
                        risaedlufylki[20] = risaedlanr21;
                        risaedlufylki[21] = risaedlanr22;
                        risaedlufylki[22] = risaedlanr23;
                        risaedlufylki[23] = risaedlanr24;
                        risaedlufylki[24] = risaedlanr25;
                        risaedlufylki[25] = risaedlanr26;
                        risaedlufylki[26] = risaedlanr27;
                        risaedlufylki[27] = risaedlanr28;
                        risaedlufylki[28] = risaedlanr29;
                        risaedlufylki[29] = risaedlanr30;
                        int[] öllSpil = new int[30] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        int[] spilari1 = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        int[] spilari2 = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        Random randomRisaedla = new Random();
                        int random = 0;
                        int m = 0;
                        int n = 0;
                        for (int i = 0; i < 30; i++)
                        {
                            random = randomRisaedla.Next(1, 31);
                            int l = 30;
                            for (int k = 0; k < l; k++)
                            {
                                if (random == öllSpil[k])
                                {
                                    random = randomRisaedla.Next(0, 31);
                                    k = 0;
                                }
                                else if (k == 30)
                                {
                                    break;
                                }
                            }
                            if (i % 2 == 0 || i == 0)
                            {
                                spilari2[m] = random;
                                m++;
                            }
                            else
                            {
                                spilari2[n] = random;
                                n++;
                            }
                            öllSpil[i] = random;
                        }
                        Console.WriteLine("Þín spil:");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine();
                        int tala = 0;
                        for (int i = 0; i < spilari1.GetLength(0) - 1; i++)
                        {
                            tala = spilari1[i];
                            Console.WriteLine(risaedlufylki[tala]);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Spil tölvu:");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        for (int i = 0; i < spilari2.GetLength(0) - 1; i++)
                        {
                            tala = spilari2[i];
                            Console.WriteLine(risaedlufylki[tala]);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;
                    case "2":

                        


                        Sjávardýr sjavardyr0 = new Sjávardýr("ELDFISKUR", "3", "16", "2", "13", "0", "");
                        Sjávardýr sjavardyr1 = new Sjávardýr("Sæotur", "4", "10", "4", "14", "4", "");
                        Sjávardýr sjavardyr2 = new Sjávardýr("BEINHÁKARL", "5", "0", "2", "21", "3", "");
                        Sjávardýr sjavardyr3 = new Sjávardýr("SLÉTTBAKUR", "8", "0", "3", "34", "4", "");
                        Sjávardýr sjavardyr4 = new Sjávardýr("SANDTÍGRISHÁFUR", "6", "13", "2", "25", "3", "");
                        Sjávardýr sjavardyr5 = new Sjávardýr("GOLÍATVARTARI", "3", "4", "4", "13", "5", "");
                        Sjávardýr sjavardyr6 = new Sjávardýr("STÓRI HVÍTHÁFUR", "6", "1", "2", "25", "3", "");
                        Sjávardýr sjavardyr7 = new Sjávardýr("FLJÓTASAGSKATA", "5", "2", "8", "21", "5", "");
                        Sjávardýr sjavardyr8 = new Sjávardýr("HÁFUR", "3", "2", "2", "13", "3", "");
                        Sjávardýr sjavardyr9 = new Sjávardýr("HVALHÁKARL", "6", "0", "2", "27", "3", "");
                        Sjávardýr sjavardyr10 = new Sjávardýr("BRÚNI KANI", "3", "18", "4", "10", "1", "");
                        Sjávardýr sjavardyr11 = new Sjávardýr("SÆSTEINSUGA", "4", "0", "5", "20", "1", "");
                        Sjávardýr sjavardyr12 = new Sjávardýr("FLÓÐMANATA", "5", "5", "10", "19", "3", "");
                        Sjávardýr sjavardyr13 = new Sjávardýr("DJÖFLASKATA", "6", "0", "3", "26", "2", "");
                        Sjávardýr sjavardyr14 = new Sjávardýr("RÁKASÆHESTUR", "2", "13", "4", "8", "3", "");
                        Sjávardýr sjavardyr15 = new Sjávardýr("STUTTNEFSSTYRJA", "4", "2", "7", "21", "3", "");
                        Sjávardýr sjavardyr16 = new Sjávardýr("SEBRAHÁFUR", "5", "9", "4", "23", "3", "");
                        Sjávardýr sjavardyr17 = new Sjávardýr("DISKASLEGGJUHÁFUR", "4", "8", "2", "19", "1", "");
                        Sjávardýr sjavardyr18 = new Sjávardýr("LANGREYÐUR", "4", "0", "3", "17", "4", "");
                        Sjávardýr sjavardyr19 = new Sjávardýr("ÆGISFÁLA", "7", "9", "6", "30", "5", "");
                        Sjávardýr sjavardyr20 = new Sjávardýr("MJALDUR", "4", "4", "5", "15", "3", "");
                        Sjávardýr sjavardyr21 = new Sjávardýr("kYRRAHAFSTÚNFISKUR", "5", "2", "3", "22", "ÓS", "");
                        Sjávardýr sjavardyr22 = new Sjávardýr("KEISARAMÖRGÆS", "3", "8", "4", "13", "1", "");
                        Sjávardýr sjavardyr23 = new Sjávardýr("BLÖÐKUHESTUR", "3", "5", "6", "13", "2", "");
                        Sjávardýr sjavardyr24 = new Sjávardýr("STÖKKULL", "1", "6", "4", "3", "1", "");
                        Sjávardýr sjavardyr25 = new Sjávardýr("HÁHYRNINGUR", "5", "4", "5", "20", "1", "");
                        Sjávardýr sjavardyr26 = new Sjávardýr("NEFBARÐASKATA", "3", "8", "3", "13", "2", "");
                        Sjávardýr sjavardyr27 = new Sjávardýr("BLETTAGAMMSKATA", "4", "2", "2", "21", "2", "");
                        Sjávardýr sjavardyr28 = new Sjávardýr("HNÚFUBAKUR", "4", "0", "5", "17", "3", "");
                        Sjávardýr sjavardyr29 = new Sjávardýr("ROSTUNGUR", "3", "4", "3", "12", "1", "");
                        Sjávardýr[] sjavardyrfylki = new Sjávardýr[30];

                        sjavardyrfylki[0] = sjavardyr0;
                        sjavardyrfylki[1] = sjavardyr1;
                        sjavardyrfylki[2] = sjavardyr2;
                        sjavardyrfylki[3] = sjavardyr3;
                        sjavardyrfylki[4] = sjavardyr4;
                        sjavardyrfylki[5] = sjavardyr5;
                        sjavardyrfylki[6] = sjavardyr6;
                        sjavardyrfylki[7] = sjavardyr7;
                        sjavardyrfylki[8] = sjavardyr8;
                        sjavardyrfylki[9] = sjavardyr9;
                        sjavardyrfylki[10] = sjavardyr10;
                        sjavardyrfylki[11] = sjavardyr11;
                        sjavardyrfylki[12] = sjavardyr12;
                        sjavardyrfylki[13] = sjavardyr13;
                        sjavardyrfylki[14] = sjavardyr14;
                        sjavardyrfylki[15] = sjavardyr15;
                        sjavardyrfylki[16] = sjavardyr16;
                        sjavardyrfylki[17] = sjavardyr17;
                        sjavardyrfylki[18] = sjavardyr18;
                        sjavardyrfylki[19] = sjavardyr19;
                        sjavardyrfylki[20] = sjavardyr20;
                        sjavardyrfylki[21] = sjavardyr21;
                        sjavardyrfylki[22] = sjavardyr22;
                        sjavardyrfylki[23] = sjavardyr23;
                        sjavardyrfylki[24] = sjavardyr24;
                        sjavardyrfylki[25] = sjavardyr25;
                        sjavardyrfylki[26] = sjavardyr26;
                        sjavardyrfylki[27] = sjavardyr27;
                        sjavardyrfylki[28] = sjavardyr28;
                        sjavardyrfylki[29] = sjavardyr29;
                        foreach (var item in sjavardyrfylki)
                        {
                            Console.WriteLine(item.ToString());
                        }

                        int[] öllSpil1 = new int[30] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        int[] spilari3 = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        int[] spilari4 = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        Random randomSjavardyr = new Random();
                        int random1 = 0;
                        int m1 = 0;
                        int n1 = 0;
                        for (int i = 0; i < 30; i++)
                        {
                            random1 = randomSjavardyr.Next(1, 31);
                            int l = 30;
                            for (int k = 0; k < l; k++)
                            {
                                if (random1 == öllSpil1[k])
                                {
                                    random1 = randomSjavardyr.Next(0, 31);
                                    k = 0;
                                }
                                else if (k == 30)
                                {
                                    break;
                                }
                            }
                            if (i % 2 == 0 || i == 0)
                            {
                                spilari3[m1] = random1;
                                m1++;
                            }
                            else
                            {
                                spilari4[n1] = random1;
                                n1++;
                            }
                            öllSpil1[i] = random1;
                        }
                        Console.WriteLine("Þín spil:");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine();
                        int tala1 = 0;
                        for (int i = 0; i < spilari3.GetLength(0) - 1; i++)
                        {
                            tala1 = spilari3[i];
                            Console.WriteLine(sjavardyrfylki[tala1]);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Spil tölvu:");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        for (int i = 0; i < spilari4.GetLength(0) - 1; i++)
                        {
                            tala1 = spilari4[i];
                            Console.WriteLine(sjavardyrfylki[tala1]);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;
                    case "0":

                        break;
                        default:
                        Console.WriteLine("ekki til");
                        Console.ReadKey();
                        break;
                    }

                } while (val != "0");
            Console.WriteLine("takk fyrir að nota forritið");
            System.Threading.Thread.Sleep(500);
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
