using Microsoft.Data.SqlClient;
using Session7.Data;
using Session7.Models;
using System;

namespace Session7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            List<Order> o = new List<Order>()
            {
                new Order()
                {
                    
                    Adress = "Nablus",
                     CreatedAt = new DateTime(2024, 4, 3)
                },
                new Order()
                {
                    
                    Adress = "Tulkarm", CreatedAt = new DateTime(2024, 12,5)
                }
               
            };
            List<Product> p = new List<Product>()
            {
                new Product()
                {
                    
                    Name = "Danah",Price = 100
                },
                new Product()
                {
                    
                   Name = "Hiba",Price = 200
                }
            };
            dbContext.orders.RemoveRange(dbContext.orders.ToList());
            dbContext.products.RemoveRange(dbContext.products.ToList());

            dbContext.orders.AddRange(o);
            dbContext.products.AddRange(p);
            dbContext.SaveChanges();
            
            var e = dbContext.orders.ToList();
            foreach(var x in e)
            {
                Console.Write(x.Id);
                Console.Write(" ");
                Console.Write(x.CreatedAt);
                Console.Write(" ");
                Console.WriteLine(x.Adress);

            }
            var f = dbContext.products.ToList();
            foreach(var x in f)
            {
                Console.Write(x.Id);
                Console.Write(" ");
                Console.Write(x.Name);
                Console.Write(" ");
                Console.WriteLine(x.Price);
             
            }
            var order = dbContext.orders.FirstOrDefault(ord => ord.Id == 1);
            if(order != null)
            {
                order.CreatedAt = new DateTime(2023, 3, 6);


            }
            var Product = dbContext.products.FirstOrDefault(pro => pro.Id == 1);
            if (Product != null)
            {
                Product.Name = "Noor";

            }
            dbContext.SaveChanges();
            var h = dbContext.products.FirstOrDefault(pro => pro.Id == 2);
            if (h != null)
            {
                dbContext.products.Remove(h);

            }
            var j = dbContext.orders.FirstOrDefault(or => or.Id == 3);
            if (j != null)
            {
                dbContext.orders.Remove(j);

            }
            dbContext.SaveChanges();
           
        }
    }
}
