﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004.ketszamosszege
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            int osszeg = szam1 + szam2;
            Console.WriteLine("A két szám összege: " + osszeg + "." + "\n");

            Console.ReadKey();
        }
    }
}
