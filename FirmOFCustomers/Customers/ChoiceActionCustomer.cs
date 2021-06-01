using System;
using System.Linq;

namespace FirmOFCustomers
{
    public class ChoiceActionCustomer
    {
        public void AdditionCustomers()
        {
            using (ContextApp context = new ContextApp())
            {
                Customer customer = new Customer
                {
                    Name = "Dima",
                    SurName = "Pupkinos",
                    Age = 35,
                    Phone = "+380987465213",
                    Email = "dima005puplin@ukr.net",
                    Country = "Ukraine",
                    City = "Kyiv",
                    Address = "Soloma"
                };
                Customer customer1 = new Customer
                {
                    Name = "Vasya",
                    SurName = "Blox",
                    Age = 42,
                    Phone = "+380974565879",
                    Email = "vladBloxa@ukr.net",
                    Country = "Ukraine",
                    City = "Kyiv",
                    Address = "Shevchenko"
                };

                context.Customers.AddRange(customer, customer1);
                context.SaveChanges();
            }
            using (ContextApp context = new ContextApp())
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Customers after addition");
                Console.ForegroundColor = ConsoleColor.White;
                var customers = context.Customers.ToList();
                foreach (Customer item in customers)
                {
                    Console.Write("ID: " + item.ID +
                        "\nName: " + item.Name +
                        "\nSurName: " + item.SurName +
                        "\nAge: " + item.Age +
                        "\nPhone: " + item.Phone +
                        "\nEmail: " + item.Email +
                        "\nCountry: " + item.Country +
                        "\nCity: " + item.City +
                        "\nAddress: " + item.Address);
                    Console.WriteLine("\n");
                }
            }
        }
        public void DeleteCustomers()
        {
            using (ContextApp context = new ContextApp())
            {
                Customer customer = context.Customers
                    .Where(v => v.ID == 2)
                    .FirstOrDefault();
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
            using (ContextApp context = new ContextApp())
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Customer after delete");
                Console.ForegroundColor = ConsoleColor.White;
                var customers = context.Customers.ToList();
                foreach (Customer item in customers)
                {
                    Console.Write("ID: " + item.ID +
                       "\nName: " + item.Name +
                       "\nSurName: " + item.SurName +
                       "\nAge: " + item.Age +
                       "\nPhone: " + item.Phone +
                       "\nEmail: " + item.Email +
                       "\nCountry: " + item.Country +
                       "\nCity: " + item.City +
                       "\nAddress: " + item.Address);
                    Console.WriteLine("\n");
                }
            }
        }
        public void ChangeDataCustomers()
        {
            using (ContextApp context = new ContextApp())
            {
                Customer resume = context.Customers
                    .Where(i => i.ID == 2)
                    .FirstOrDefault();
                resume.Phone = "+380963214598";
                context.SaveChanges();
            }
            using (ContextApp context = new ContextApp())
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Customer is changed");
                Console.ForegroundColor = ConsoleColor.White;
                var customers = context.Customers.ToList();
                foreach (Customer item in customers)
                {
                    Console.Write("ID: " + item.ID +
                       "\nName: " + item.Name +
                       "\nSurName: " + item.SurName +
                       "\nAge: " + item.Age +
                       "\nPhone: " + item.Phone +
                       "\nEmail: " + item.Email +
                       "\nCountry: " + item.Country +
                       "\nCity: " + item.City +
                       "\nAddress: " + item.Address);
                    Console.WriteLine("\n");
                }
            }
        }
        public void ExactDataCustomers()
        {
            using (ContextApp context = new ContextApp())
            {
                var work = context.Customers;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Exact Data Customer");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (Customer item in work.Where(s => s.SurName.StartsWith("D")))
                {
                    Console.Write("ID: " + item.ID +
                       "\nName: " + item.Name +
                       "\nSurName: " + item.SurName +
                       "\nAge: " + item.Age +
                       "\nPhone: " + item.Phone +
                       "\nEmail: " + item.Email +
                       "\nCountry: " + item.Country +
                       "\nCity: " + item.City +
                       "\nAddress: " + item.Address);
                    Console.WriteLine("\n");
                }
            }
        }
        public void ViewList()
        {
            using (ContextApp context = new ContextApp())
            {
                var work = context.Customers;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("ViewList Customer");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (Customer item in work)
                {
                    Console.Write("ID: " + item.ID +
                       "\nName: " + item.Name +
                       "\nSurName: " + item.SurName +
                       "\nAge: " + item.Age +
                       "\nPhone: " + item.Phone +
                       "\nEmail: " + item.Email +
                       "\nCountry: " + item.Country +
                       "\nCity: " + item.City +
                       "\nAddress: " + item.Address);
                    Console.WriteLine("\n");
                }
            }
        }
        public void SortCustomers()
        {
            using (ContextApp context = new ContextApp())
            {
                Console.Write("Enter the sort: " +
                    "\n1 - Name" +
                    "\n2 - SurName" +
                    "\n\nChoice: ");
                string text = Console.ReadLine();
                if (text == "Name")
                {
                    var resume = context.Customers.OrderBy(n => n.Name);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("SortCustomer Name");
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (Customer item in resume)
                    {
                        Console.Write("ID: " + item.ID +
                       "\nName: " + item.Name +
                       "\nSurName: " + item.SurName +
                       "\nAge: " + item.Age +
                       "\nPhone: " + item.Phone +
                       "\nEmail: " + item.Email +
                       "\nCountry: " + item.Country +
                       "\nCity: " + item.City +
                       "\nAddress: " + item.Address);
                        Console.WriteLine("\n");
                    }
                }
                else if (text == "SurName")
                {
                    var resume = context.Customers.OrderBy(s => s.SurName);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("SortCustomer SurName");
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (Customer item in resume)
                    {
                        Console.Write("ID: " + item.ID +
                       "\nName: " + item.Name +
                       "\nSurName: " + item.SurName +
                       "\nAge: " + item.Age +
                       "\nPhone: " + item.Phone +
                       "\nEmail: " + item.Email +
                       "\nCountry: " + item.Country +
                       "\nCity: " + item.City +
                       "\nAddress: " + item.Address);
                        Console.WriteLine("\n");
                    }
                }
            }
        }
    }
}
