using System;

namespace SearchInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ChoiceInformation: " +
                "\n1 - SearchVacancies" +
                "\n2 - SearchWorkLess" +
                "\n\nChoice: ");
            string text = Console.ReadLine();
            switch (text)
            {
                case "1":
                    {
                        SearchVacancies instance = new SearchVacancies();
                        instance.KeyWordSearchVacancies();
                        break;
                    }
                case "2":
                    {
                        SearchWorkLess instance = new SearchWorkLess();
                        instance.KeyWordSearchWorkLess();
                        break;
                    }
            }
            //Delay
            Console.ReadKey();
        }
    }
}
