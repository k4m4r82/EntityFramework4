﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityFramework4.Models;

namespace EntityFramework4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new RetailContext())
            {
                var noUrut = 1;

                var daftarSupplier = db.Suppliers.ToList();
                foreach (var supplier in daftarSupplier)
                {
                    Console.WriteLine("{0}. {1}, {2}", noUrut, supplier.NamaSupplier, supplier.Jalan);

                    noUrut++;
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
