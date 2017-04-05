using System;

namespace SimpleLinearDataStructures.Stack
{
    /// <summary>
    /// Stack implemented with resizable array.
    /// </summary>
    public class Stack<T>
    {
        private T[] items;
        private int capacity;
        private int usedCapacity;

        public Stack()
        {
            this.capacity = 8;
            this.items = new T[this.capacity];
        }

        public int Count
        {
            get
            {
                return this.usedCapacity;
            }
        }

        public void Push(T value)
        {
            if (value == null)
            {
                throw new InvalidOperationException("Passed value cannot be null!");
            }

            if (this.usedCapacity == capacity)
            {
                this.capacity *= 2;
                var newArray = new T[this.capacity];
                this.items.CopyTo(newArray, 0);
                this.items = newArray;
            }

            this.items[this.usedCapacity] = value;
            this.usedCapacity++;
        }

        public T Pop()
        {
            if (this.usedCapacity == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            this.usedCapacity--;
            var item = this.items[this.usedCapacity];
            return item;
        }

        public T Peek()
        {
            if (this.usedCapacity == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            var item = this.items[this.usedCapacity - 1];
            return item;
        }

        public void Clear()
        {
            this.capacity = 8;
            this.usedCapacity = 0;
            this.items = new T[this.capacity];
        }
    }
}
