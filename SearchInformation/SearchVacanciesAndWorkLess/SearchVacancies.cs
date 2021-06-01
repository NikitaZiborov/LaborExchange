using System;
using System.Linq;
using ManagementVacanciesAndResume;

namespace SearchInformation
{
    public class SearchVacancies
    {
        public void KeyWordSearchVacancies()
        {
            using (ContextApp context = new ContextApp())
            {
                var vacancies = context.Vacancies;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Exact Data Vacancies");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (Vacancie item in vacancies.Where(n => n.Name.StartsWith("Java")))
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
