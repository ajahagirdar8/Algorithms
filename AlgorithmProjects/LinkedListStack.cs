using System;
namespace AlgorithmsProjects
{

    /***
     * Generic Stack class using linked list as data structure
     ***/
    public class LinkedListStack<T>
    {
        private LinkListNode<T> firstnode;
        public LinkedListStack()
        {
        }

        public Boolean isEmpty()
        {
            return firstnode == null;
        }

        public void push(T item)
        {
            LinkListNode<T> oldfirst = firstnode;
            firstnode = new LinkListNode<T>(item, oldfirst);
        }

        public T pop()
        {
            T item = firstnode.Item;
            firstnode = firstnode.Nextnode;
            return item;

        }
    }
}
