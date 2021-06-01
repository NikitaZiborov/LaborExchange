using System;
using System.Linq;

namespace ManagementVacanciesAndResume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choice: Vacancies and Resume" +
                "\n1 - Vacancies" +
                "\n2 - Resume" +
                "\n\nChoice: ");
            string text = Console.ReadLine();
            switch (text)
            {
                case "1":
                    {
                        OutPutInformation instance = new OutPutInformation();
                        instance.OutPut();
                        break;
                    }
                case "2":
                    {
                        OutPutInformationResume instance = new OutPutInformationResume();
                        instance.OutPut();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("This action does not exist");
                        break;
                    }
            }
            //Delay
            Console.ReadKey();
        }
    }
}
