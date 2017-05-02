using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
