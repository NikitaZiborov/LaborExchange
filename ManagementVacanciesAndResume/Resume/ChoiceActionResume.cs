using System;
using System.Linq;

namespace ManagementVacanciesAndResume
{
    public class ChoiceActionResume
    {
        public void AdditionResume()
        {
            using (ContextApp context = new ContextApp())
            {
                Resume resume = new Resume
                {
                    Name = "Nikita",
                    SurName = "Ziborov",
                    Age = 19,
                    Phone = "+380951218444",
                    Email = "ziborovna@ukr.net",
                    Position = "Junior",
                    Skills = "HardSkill",
                    VacanciesID = 16,
                };
                Resume resume1 = new Resume
                {
                    Name = "Inna",
                    SurName = "Balabon",
                    Age = 19,
                    Phone = "+380677770754",
                    Email = "1innabalabon@ukr.net",
                    Position = "Junior",
                    Skills = "HardSkill",
                    VacanciesID = 14,
                };

                context.Resumes.AddRange(resume, resume1);
                context.SaveChanges();
            }
            using (ContextApp context = new ContextApp())
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Vacancies after addition");
                Console.ForegroundColor = ConsoleColor.White;
                var resumes = context.Resumes.ToList();
                foreach (Resume item in resumes)
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
        public void DeleteResume()
        {
            using (ContextApp context = new ContextApp())
            {
                Resume resume = context.Resumes
                    .Where(v => v.ID == 2)
                    .FirstOrDefault();
                context.Resumes.Remove(resume);
                context.SaveChanges();
            }
            using (ContextApp context = new ContextApp())
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Vacancies after addition");
                Console.ForegroundColor = ConsoleColor.White;
                var resumes = context.Resumes.ToList();
                foreach (Resume item in resumes)
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
        public void ChangeDataResume()
        {
            using (ContextApp context = new ContextApp())
            {
                Resume resume = context.Resumes
                    .Where(i => i.ID == 3)
                    .FirstOrDefault();
                resume.Position = "Senior";
                context.SaveChanges();
            }
            using (ContextApp context = new ContextApp())
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Resume is changed");
                Console.ForegroundColor = ConsoleColor.White;
                var resumes = context.Resumes.ToList();
                foreach (Resume item in resumes)
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
        public void ExactDataResume()
        {
            using (ContextApp context = new ContextApp())
            {
                var resume = context.Resumes;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Exact Data Resume");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (Resume item in resume.Where(n => n.Name.StartsWith("N")))
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
        public void SortResume()
        {
            using (ContextApp context = new ContextApp())
            {
                var resume = context.Resumes.OrderBy(n => n.Name);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Sort Vacancies");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (Resume item in resume)
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
