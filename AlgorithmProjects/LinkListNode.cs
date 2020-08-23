using System;
namespace Algorithms
{
    public class LinkListNode<T>
    {
        private T item;
        private LinkListNode<T> nextnode;

        public LinkListNode(T item,LinkListNode<T> node)
        {
            this.Item = item;
            this.Nextnode = node;
        }

        public T Item { get => item; set => item = value; }
        public LinkListNode<T> Nextnode { get => nextnode; set => nextnode = value; }
    }
}
