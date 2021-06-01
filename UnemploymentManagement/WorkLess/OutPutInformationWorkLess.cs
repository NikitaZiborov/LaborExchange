using System;
using System.Threading;

namespace UnemploymentManagement
{
    class OutPutInformationWorkLess : ChoiceActionWorkLess
    {
        public void OutPut()
        {
            while (true)
            {
                Console.Write("Enter the action: " +
                "\n1 - AdditionWorkLess" +
                "\n2 - DeleteWorkLess" +
                "\n3 - ChangeDataWorkLess" +
                "\n4 - ExactDataWorkLess" +
                "\n5 - ViewList" +
                "\n6 - SortWorkLess" +
                "\n\nChoice: ");

                string text = Console.ReadLine();

                switch (text)
                {
                    case "1":
                        {
                            ChoiceActionWorkLess instance = new ChoiceActionWorkLess();
                            instance.AdditionWorkLess();
                            Thread.Sleep(1000);
                            break;
                        }
                    case "2":
                        {
                            ChoiceActionWorkLess instance = new ChoiceActionWorkLess();
                            instance.DeleteWorkLess();
                            Thread.Sleep(1000);
                            break;
                        }
                    case "3":
                        {
                            ChoiceActionWorkLess instance = new ChoiceActionWorkLess();
                            instance.ChangeDataWorkLess();
                            Thread.Sleep(1000);
                            break;
                        }
                    case "4":
                        {
                            ChoiceActionWorkLess instance = new ChoiceActionWorkLess();
                            instance.ExactDataWorkLess();
                            Thread.Sleep(1000);
                            break;
                        }
                    case "5":
                        {
                            ChoiceActionWorkLess instance = new ChoiceActionWorkLess();
                            instance.ViewList();
                            Thread.Sleep(1000);
                            break;
                        }
                    case "6":
                        {
                            ChoiceActionWorkLess instance = new ChoiceActionWorkLess();
                            instance.SortWorkLess();
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
