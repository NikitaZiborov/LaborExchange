using System;
using System.Threading;
namespace ManagementVacanciesAndResume
{
    public class OutPutInformation : ChoiceAction
    {
        public void OutPut()
        {
            while (true)
            {
                Console.Write("Enter the action: " +
                "\n1 - AdditionVacancies" +
                "\n2 - DeleteVacancies" +
                "\n3 - ChangeDataVacancies" +
                "\n4 - ExactDataVacancies" +
                "\n5 - SortVacancies" +
                "\n\nChoice: ");

                string text = Console.ReadLine();

                switch (text)
                {
                    case "1":
                        {
                            ChoiceAction instance = new ChoiceAction();
                            instance.AdditionVacancies();
                            Thread.Sleep(1000);
                            break;
                        }
                    case "2":
                        {
                            ChoiceAction instance = new ChoiceAction();
                            instance.DeleteVacancies();
                            break;
                        }
                    case "3":
                        {
                            ChoiceAction instance = new ChoiceAction();
                            instance.ChangeDataVacancies();
                            break;
                        }
                    case "4":
                        {
                            ChoiceAction instance = new ChoiceAction();
                            instance.ExactDataVacancies();
                            break;
                        }
                    case "5":
                        {
                            ChoiceAction instance = new ChoiceAction();
                            instance.SortVacancies();
                            break;
                        }
                    default:
                        {
                            Console.Write("This action does not exist");
                            break;
                        }
                }
            }
        }
    }
}
