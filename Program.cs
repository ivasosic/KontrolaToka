using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napišite program koji će od korisnika uzeti string, te definirajte i ispišite 
            // novi string koji će sadržavati sve znakove unešenog stringa osim prva dva i zadnja dva znaka.
            // Ako je niz dužine manje od 5 znakova treba ispisati cijeli niz.
            Console.WriteLine("-- 1. zadatak --: ");
            Console.WriteLine("Unesite string: ");
            string str1 = Console.ReadLine();
            int a = str1.Length;
            if (a <= 5)
            {
                Console.WriteLine(str1);
            }
            else
            {
                Console.WriteLine(str1.Substring(2, (a - 4)));
            }
            Console.WriteLine(" -- 3. zadatak --");
            Console.WriteLine("Unesite jedan broj: ");
            double number = Convert.ToInt32(Console.ReadLine());
            if (number % 4 == 0 && number % 6 != 0)
            {
                Console.WriteLine("Broj se može podijeliti s 4.");
            }
            if (number % 6 == 0 && number % 4 != 0)
            {
                Console.WriteLine("Broj se može podijeliti s 6.");
            }
            if (number % 6 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Broj se može podijeliti s 4 i 6.");
            }
            if (number % 4 != 0 && number % 6 != 0)
            {
                Console.WriteLine("Broj se ne može podijeliti s 4 i 6.");
            }
            Console.WriteLine("Unesite 1. cijenu: ");
            double prvacijena = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite 2. cijenu: ");
            double drugacijena = Convert.ToInt32(Console.ReadLine());
            if (prvacijena > drugacijena)
            {
                Console.WriteLine("PDV: " + (((prvacijena / drugacijena) - 1) * 100) + "%.");
            }
            if (prvacijena < drugacijena)
            {
                Console.WriteLine("PDV: " + (((drugacijena / prvacijena) - 1) * 100) + "%.");
            }
            Console.ReadKey();
        }
    }
}
