using System;
using System.Linq;

namespace ManagementVacanciesAndResume
{
    public class ChoiceAction
    {
        public void AdditionVacancies()
        {
            using (ContextApp context = new ContextApp())
            {
                Vacancie vacancie = new Vacancie { Name = ".NET Developer", Position = "Junior" };
                Vacancie vacancie1 = new Vacancie { Name = "C# Developer", Position = "Senior" };
                Vacancie vacancie2 = new Vacancie { Name = "Java Developer", Position = "Middle" };

                context.Vacancies.AddRange(vacancie, vacancie1, vacancie2);
                context.SaveChanges();
            }

            using (ContextApp context = new ContextApp())
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Vacancies after addition");
                Console.ForegroundColor = ConsoleColor.White;
                var vacancies = context.Vacancies.ToList();
                foreach (Vacancie item in vacancies)
                {
                    Console.Write("ID: " + item.ID +
                        "\nName: " + item.Name +
                        "\nPosition" + item.Position);
                    Console.WriteLine("\n");
                }
            }
        }
        public void DeleteVacancies()
        {
            using (ContextApp context = new ContextApp())
            {
                Vacancie vacancie = context.Vacancies
                    .Where(v => v.ID == 10)
                    .FirstOrDefault();
                context.Vacancies.Remove(vacancie);
                context.SaveChanges();
            }
            using (ContextApp context = new ContextApp())
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Vacancies after delete");
                Console.ForegroundColor = ConsoleColor.White;
                var vacancies = context.Vacancies.ToList();
                foreach (Vacancie item in vacancies)
                {
                    Console.Write("ID: " + item.ID +
                        "\nName: " + item.Name +
                        "\nPosition" + item.Position);
                    Console.WriteLine("\n");
                }
            }
        }
        public void ChangeDataVacancies()
        {
            using (ContextApp context = new ContextApp())
            {
                Vacancie vacancie = context.Vacancies.FirstOrDefault();
                vacancie.Name = "Python Developer";
                vacancie.Position = "Senior";
                context.SaveChanges();
            }
            using (ContextApp context = new ContextApp())
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Vacancies is changed by Name");
                Console.ForegroundColor = ConsoleColor.White;
                var vacancies = context.Vacancies.ToList();
                foreach (Vacancie item in vacancies)
                {
                    Console.Write("ID: " + item.ID +
                        "\nName: " + item.Name +
                        "\nPosition: " + item.Position);
                    Console.WriteLine("\n");
                }
            }
        }
        public void ExactDataVacancies()
        {
            using (ContextApp context = new ContextApp())
            {
                var vacancies = context.Vacancies;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Exact Data Vacancies");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (Vacancie item in vacancies.Where(n => n.Name.StartsWith("J")))
                {
                    Console.Write("ID: " + item.ID +
                        "\nName: " + item.Name +
                        "\nPosition: " + item.Position);
                    Console.WriteLine("\n");
                }
            }
        }
        public void SortVacancies()
        {
            using (ContextApp context = new ContextApp())
            {
                var vacancies = context.Vacancies.OrderBy(n => n.Name);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Sort Vacancies");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (Vacancie item in vacancies)
                {
                    Console.Write("ID: " + item.ID +
                        "\nName: " + item.Name +
                        "\nPosition: " + item.Position);
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
