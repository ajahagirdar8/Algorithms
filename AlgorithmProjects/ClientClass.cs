using System;
namespace AlgorithmsProjects
{
   
    public class ArrayStackClient
    {
        public void TestClinet()
        {
            ArrayStack<string> astk = new ArrayStack<string>(3);
            Console.WriteLine("pushed C");
            Console.WriteLine("pushed B");
            Console.WriteLine("pushed A");
            astk.push("C");
            astk.push("B");
            astk.push("A");
            Console.WriteLine("popped " + astk.pop());
            Console.WriteLine("popped " + astk.pop());
            Console.WriteLine("popped " + astk.pop());
        }
    }

   public class LinkedListStackClient
    {
        public void TestClient()
        {
            LinkedListStack<string> lls = new LinkedListStack<string>();
            Console.WriteLine("pushed C");
            Console.WriteLine("pushed B");
            Console.WriteLine("pushed A");
            lls.push("C");
            lls.push("B");
            lls.push("A");

            Console.WriteLine("popped " + lls.pop());
            Console.WriteLine("popped " + lls.pop());
            Console.WriteLine("popped " + lls.pop());

            LinkedListStack<int> lls1 = new LinkedListStack<int>();
            Console.WriteLine("pushed 3");
            Console.WriteLine("pushed 3");
            Console.WriteLine("pushed 1");
            lls1.push(3);
            lls1.push(2);
            lls1.push(1);

            Console.WriteLine("popped " + lls1.pop());
            Console.WriteLine("popped " + lls1.pop());
            Console.WriteLine("popped " + lls1.pop());
        }
    }
}
