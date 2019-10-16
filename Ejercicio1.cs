using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3B
{
    class Ejercicio1
    {
        public static void nummayor() {
            Console.Write("\tIngrese le Primer termino: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tIngrese le Primer termino: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tIngrese le Primer termino: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("\t\t" + n1 + " es el numero mayor");
            }
            if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("\t\t" + n2 + " es el numero mayor");
            }
            if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("\t\t" + n3 + " es el numero mayor");
            }
            Console.ReadKey();
            Program.menu();

        }

    }
}
