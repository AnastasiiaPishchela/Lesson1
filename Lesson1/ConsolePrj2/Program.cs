using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librprj3;
using static Librprj3.Class1;

namespace ConsolePrj2
{
    class Program
    {
        static void Main(string[] args)
        {  Console.Write("FavoriteSong: ");
            string song = Console.ReadLine();
            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            Console.WriteLine("Your favorite song {0} by {1}", song, artist);
            Console.WriteLine("It's Project ConsolePrj2");
            int a = 10, b = 6;
            Console.WriteLine(Arithmetic.Add(a, b));
            Console.WriteLine(Arithmetic.Subtract(a, b));
            Console.WriteLine(Arithmetic.Multiply(a, b));
            Console.WriteLine(Arithmetic.Divide(a, b));
            Console.ReadKey();
        }
    }
}
