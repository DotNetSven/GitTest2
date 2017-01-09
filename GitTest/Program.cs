using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het aantal keer dat u wilt printen");
            int aantal = int.Parse(Console.ReadLine());
            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine("Print nr {0}.",i+1);
            }
            Console.ReadKey();
        }
    }
}
