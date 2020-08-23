using System;

namespace AlgorithmsProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success;
            do
            {
                Console.WriteLine("Choose the data structure/algorithm to test:");
                Console.WriteLine("1. Stack using array");
                Console.WriteLine("2. Stack using linked list");
                string input = Console.ReadLine();
                int inputno;
                success = Int32.TryParse(input, out inputno);
                if (success)
                {

                    switch(inputno)
                    {
                        case 1:
                            ArrayStackClient asc = new ArrayStackClient();
                            asc.TestClinet();
                            break;
                        case 2:
                            LinkedListStackClient a = new LinkedListStackClient();
                            a.TestClient();
                            break;
                        default:
                            Console.WriteLine("Enter a valid choice");
                            success = false;
                            break;

                    }
                    
                }
                else
                    Console.WriteLine("Enter a valid choice");
            } while (!success);


           



        }
    }
}
