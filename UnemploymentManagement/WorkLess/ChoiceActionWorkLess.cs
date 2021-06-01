using System;
using System.Linq;

namespace UnemploymentManagement
{
    public class ChoiceActionWorkLess
    {
        public void AdditionWorkLess()
        {
            using (ContextApp context = new ContextApp())
            {
                WorkLess work = new WorkLess
                {
                    Name = "Vlad",
                    SurName = "Pupkin",
                    Age = 25,
                    Phone = "+380987465213",
                    Email = "vlad005puplin@ukr.net",
                    Position = "Middle",
                    Skills = "HardSkill",
                };
                WorkLess work1 = new WorkLess
                {
                    Name = "Vasya",
                    SurName = "Blox",
                    Age = 42,
                    Phone = "+380974565879",
                    Email = "vladBloxa@ukr.net",
                    Position = "Junior",
                    Skills = "HardSkill",
                };

                context.WorkLesses.AddRange(work, work1);
                context.SaveChanges();
            }
            using (ContextApp context = new ContextApp())
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("WorkLess after addition");
                Console.ForegroundColor = ConsoleColor.White;
                var resumes = context.WorkLesses.ToList();
                foreach (WorkLess item in resumes)
                {
                    Console.Write("ID: " + item.ID +
                        "\nName: " + item.Name +
                        "\nSurName: " + item.SurName +
                        "\nAge: " + item.Age +
                        "\nPhone: " + item.Phone +
                        "\nEmail: " + item.Email +
                        "\nPosition: " + item.Position +
                        "\nSkill: " + item.Skills);
                    Console.WriteLine("\n");
                }
            }
        }
        public void DeleteWorkLess()
        {
            using (ContextApp context = new ContextApp())
            {
                WorkLess work = context.WorkLesses
                    .Where(v => v.ID == 2)
                    .FirstOrDefault();
                context.WorkLesses.Remove(work);
                context.SaveChanges();
            }
            using (ContextApp context = new ContextApp())
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("WorkLess after delete");
                Console.ForegroundColor = ConsoleColor.White;
                var resumes = context.WorkLesses.ToList();
                foreach (WorkLess item in resumes)
                {
                    Console.Write("ID: " + item.ID +
                        "\nName: " + item.Name +
                        "\nSurName: " + item.SurName +
                        "\nAge: " + item.Age +
                        "\nPhone: " + item.Phone +
                        "\nEmail: " + item.Email +
                        "\nPosition: " + item.Position +
                        "\nSkill: " + item.Skills);
                    Console.WriteLine("\n");
                }
            }
        }
        public void ChangeDataWorkLess()
        {
            using (ContextApp context = new ContextApp())
            {
                WorkLess resume = context.WorkLesses
                    .Where(i => i.ID == 2)
                    .FirstOrDefault();
                resume.Position = "Senior";
                context.SaveChanges();
            }
            using (ContextApp context = new ContextApp())
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("WorkLess is changed");
                Console.ForegroundColor = ConsoleColor.White;
                var works = context.WorkLesses.ToList();
                foreach (WorkLess item in works)
                {
                    Console.Write("ID: " + item.ID +
                        "\nName: " + item.Name +
                        "\nSurName: " + item.SurName +
                        "\nAge: " + item.Age +
                        "\nPhone: " + item.Phone +
                        "\nEmail: " + item.Email +
                        "\nPosition: " + item.Position +
                        "\nSkill: " + item.Skills);
                    Console.WriteLine("\n");
                }
            }
        }
        public void ExactDataWorkLess()
        {
            using (ContextApp context = new ContextApp())
            {
                var work = context.WorkLesses;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Exact Data WorkLess");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (WorkLess item in work.Where(s => s.SurName.StartsWith("B")))
                {
                    Console.Write("ID: " + item.ID +
                         "\nName: " + item.Name +
                         "\nSurName: " + item.SurName +
                         "\nAge: " + item.Age +
                         "\nPhone: " + item.Phone +
                         "\nEmail: " + item.Email +
                         "\nPosition: " + item.Position +
                         "\nSkill: " + item.Skills);
                    Console.WriteLine("\n");
                }
            }
        }
        public void ViewList()
        {
            using (ContextApp context = new ContextApp())
            {
                var work = context.WorkLesses;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("ViewList WorkLess");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (WorkLess item in work)
                {
                    Console.Write("ID: " + item.ID +
                         "\nName: " + item.Name +
                         "\nSurName: " + item.SurName +
                         "\nAge: " + item.Age +
                         "\nPhone: " + item.Phone +
                         "\nEmail: " + item.Email +
                         "\nPosition: " + item.Position +
                         "\nSkill: " + item.Skills);
                    Console.WriteLine("\n");
                }
            }
        }
        public void SortWorkLess()
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
                    var resume = context.WorkLesses.OrderBy(n => n.Name);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("SortWorkLess Name");
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (WorkLess item in resume)
                    {
                        Console.Write("ID: " + item.ID +
                             "\nName: " + item.Name +
                             "\nSurName: " + item.SurName +
                             "\nAge: " + item.Age +
                             "\nPhone: " + item.Phone +
                             "\nEmail: " + item.Email +
                             "\nPosition: " + item.Position +
                             "\nSkill: " + item.Skills);
                        Console.WriteLine("\n");
                    }
                }
                else if(text == "SurName")
                {
                    var resume = context.WorkLesses.OrderBy(s => s.SurName);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("SortWorkLess SurName");
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (WorkLess item in resume)
                    {
                        Console.Write("ID: " + item.ID +
                             "\nName: " + item.Name +
                             "\nSurName: " + item.SurName +
                             "\nAge: " + item.Age +
                             "\nPhone: " + item.Phone +
                             "\nEmail: " + item.Email +
                             "\nPosition: " + item.Position +
                             "\nSkill: " + item.Skills);
                        Console.WriteLine("\n");
                    }
                }
            }
        }
    }
}
