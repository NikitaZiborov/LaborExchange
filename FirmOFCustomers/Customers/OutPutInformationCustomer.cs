using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOFCustomers
{
    class OutPutInformationCustomer : ChoiceActionCustomer
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
                            ChoiceActionCustomer instance = new ChoiceActionCustomer();
                            instance.AdditionCustomers();
                            break;
                        }
                    case "2":
                        {
                            ChoiceActionCustomer instance = new ChoiceActionCustomer();
                            instance.DeleteCustomers();
                            break;
                        }
                    case "3":
                        {
                            ChoiceActionCustomer instance = new ChoiceActionCustomer();
                            instance.ChangeDataCustomers();
                            break;
                        }
                    case "4":
                        {
                            ChoiceActionCustomer instance = new ChoiceActionCustomer();
                            instance.ExactDataCustomers();
                            break;
                        }
                    case "5":
                        {
                            ChoiceActionCustomer instance = new ChoiceActionCustomer();
                            instance.ViewList();
                            break;
                        }
                    case "6":
                        {
                            ChoiceActionCustomer instance = new ChoiceActionCustomer();
                            instance.SortCustomers();
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
