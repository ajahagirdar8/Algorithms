using System;

namespace AlgorithmsProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*LinkedListStack<string> lls = new LinkedListStack<string>();
            lls.push("A");
            lls.push("B");
            lls.push("C");

            Console.WriteLine("popped "+lls.pop());
            Console.WriteLine("popped "+lls.pop());
            Console.WriteLine("popped "+lls.pop());

            LinkedListStack<int> lls1 = new LinkedListStack<int>();
            lls1.push(3);
            lls1.push(2);
            lls1.push(1);

            Console.WriteLine("popped " + lls1.pop());
            Console.WriteLine("popped " + lls1.pop());
            Console.WriteLine("popped " + lls1.pop());*/

            ArrayStack<string> astk = new ArrayStack<string>(3);
            astk.push("C");
            astk.push("B");
            astk.push("A");
            Console.WriteLine("popped " + astk.pop());
            Console.WriteLine("popped " + astk.pop());
            Console.WriteLine("popped " + astk.pop());



        }
    }
}
