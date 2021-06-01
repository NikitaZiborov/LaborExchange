using System;
using System.Linq;
using UnemploymentManagement;

namespace SearchInformation
{
    public class SearchWorkLess
    {
        public void KeyWordSearchWorkLess()
        {
            using (ContextApp context = new ContextApp())
            {
                var work = context.WorkLesses;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Exact Data WorkLess");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (WorkLess item in work.Where(s => s.SurName.StartsWith("Blox")))
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
