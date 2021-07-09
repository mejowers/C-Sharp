﻿using System;
using System.Linq;
using EntityFrameworkCoreTutorial.Models;

namespace EntityFrameworkCoreTutorial {
    class Program {
        static void Main(string[] args) {

            var _context = new salesdbContext();

            var custOrders = from o in _context.Orders
                             join c in _context.Customers
                                    on o.CustomerId equals c.Id
                             select new {
                                 o, Customer = c.Name
                             };

            foreach(var oc in custOrders) {
                Console.WriteLine($"{oc.o.Description} | {oc.Customer}");
            }

            var customers = _context.Customers
                                    .Where(c => c.City == "Cincinnati" && c.Sales >= 50000)
                                    .OrderByDescending(c=> c.Name)
                                    .ToList();

            var customers2 = from c in _context.Customers
                             where c.City.Equals("Cincinnati") && c.Sales >= 50000
                             orderby c.Name descending
                             select c;

            foreach(var c in customers2) {
                Console.WriteLine($"{c.Name} | {c.City}");
            }

        }
    }
}
