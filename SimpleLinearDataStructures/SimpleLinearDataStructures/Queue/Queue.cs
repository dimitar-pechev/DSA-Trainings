using System;
using SimpleLinearDataStructures.DoublyLinkedList;

namespace SimpleLinearDataStructures.Queue
{
    public class Queue<T>
    {
        private DoublyLinkedList<T> Items { get; set; }

        public void Enqueue(T value)
        {
            if (value == null)
            {
                throw new InvalidOperationException("Cannot pass null as value!");
            }

            this.Items.AddLast(value);
        }

        public T Dequeue()
        {
            if (this.Items.First == null)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            var result = this.Items.First.Value;
            this.Items.RemoveFirst();
            return result;
        }

        public T Peek()
        {
            if (this.Items.First == null)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            return this.Items.First.Value;
        }

        public int GetCount()
        {
            var count = this.Items.GetCount();
            return count;
        }

        public void Clear()
        {
            this.Items.Clear();
        }
    }
}
