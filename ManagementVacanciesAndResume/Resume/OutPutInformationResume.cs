using System;
using System.Threading;

namespace ManagementVacanciesAndResume
{
    class OutPutInformationResume : ChoiceActionResume
    {
        public void OutPut()
        {
            while (true)
            {
                Console.Write("Enter the action: " +
                "\n1 - AdditionResume" +
                "\n2 - DeleteResume" +
                "\n3 - ChangeDataResume" +
                "\n4 - ExactDataResume" +
                "\n5 - SortResume" +
                "\n\nChoice: ");

                string text = Console.ReadLine();

                switch (text)
                {
                    case "1":
                        {
                            ChoiceActionResume instance = new ChoiceActionResume();
                            instance.AdditionResume();
                            Thread.Sleep(1000);
                            break;
                        }
                    case "2":
                        {
                            ChoiceActionResume instance = new ChoiceActionResume();
                            instance.DeleteResume();
                            Thread.Sleep(1000);
                            break;
                        }
                    case "3":
                        {
                            ChoiceActionResume instance = new ChoiceActionResume();
                            instance.ChangeDataResume();
                            Thread.Sleep(1000);
                            break;
                        }
                    case "4":
                        {
                            ChoiceActionResume instance = new ChoiceActionResume();
                            instance.ExactDataResume();
                            Thread.Sleep(1000);
                            break;
                        }
                    case "5":
                        {
                            ChoiceActionResume instance = new ChoiceActionResume();
                            instance.SortResume();
                            Thread.Sleep(1000);
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

