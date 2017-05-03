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
                        Sjávardýr ELDFISKUR = new Sjávardýr("ELDFISKUR","3","16","2","13","ÓS","");
                        Sjávardýr SÆOTUR = new Sjávardýr("Sæotur","4","10","4","14","4","");
                        Sjávardýr BEINHÁKARL = new Sjávardýr("BEINHÁKARL", "5", "0", "2", "21", "3","");
                        Sjávardýr SLÉTTBAKUR = new Sjávardýr("SLÉTTBAKUR", "8", "0", "3", "34", "4", "");
                        Sjávardýr SANDTÍGRISHÁFUR = new Sjávardýr("SANDTÍGRISHÁFUR", "6", "13", "2", "25", "3", "");
                        Sjávardýr GOLÍATVARTARI = new Sjávardýr("GOLÍATVARTARI", "3","4", "4", "13", "5","");
                        Sjávardýr STÓRI_HVÍTHÁFUR = new Sjávardýr("STÓRI HVÍTHÁFUR", "6", "1", "2", "25", "3", "");
                        Sjávardýr FLJÓTASAGSKATA = new Sjávardýr("FLJÓTASAGSKATA", "5", "2", "8", "21", "5","");
                        Sjávardýr HÁFUR = new Sjávardýr("HÁFUR", "3", "2", "2", "13", "3", "");
                        Sjávardýr HVALHÁKARL = new Sjávardýr("HVALHÁKARL", "6", "0", "2", "27", "3", "");
                        Sjávardýr BRÚNI_KANI = new Sjávardýr("BRÚNI KANI", "3", "18", "4", "10", "1", "");
                        Sjávardýr SÆSTEINSUGA = new Sjávardýr("SÆSTEINSUGA", "4", "0", "5", "20", "1", "");
                        Sjávardýr FLÓÐMANATA = new Sjávardýr("FLÓÐMANATA", "5", "5", "10", "19", "3", "");
                        Sjávardýr DJÖFLASKATA = new Sjávardýr("DJÖFLASKATA", "6", "0", "3", "26", "2", "");
                        //búinn með 18261166 á rest eftir
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
