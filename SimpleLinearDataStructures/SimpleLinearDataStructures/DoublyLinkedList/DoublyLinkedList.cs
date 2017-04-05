namespace SimpleLinearDataStructures.DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public ListItem<T> First { get; private set; }

        public ListItem<T> Last { get; private set; }

        public void AddFirst(T value)
        {
            var newItem = new ListItem<T>(value);

            if (this.First == null)
            {                
                this.First = newItem;
                this.Last = newItem;
            }
            else
            {
                this.First.Previous = newItem;
                var tempValue = this.First;
                this.First = newItem;
                this.First.Next = tempValue;
            }
        }

        public void AddLast(T value)
        {
            var newItem = new ListItem<T>(value);

            if (this.Last == null)
            {
                this.First = newItem;
                this.Last = newItem;
            }
            else
            {
                this.Last.Next = newItem;
                var tempValue = this.Last;
                this.Last = newItem;
                this.Last.Previous = tempValue;
            }
        }

        public void AddBefore(T referenceValue, T value)
        {
            var current = this.First;
            while (current != null)
            {
                if (current.Value.Equals(referenceValue))
                {
                    var newItem = new ListItem<T>(value);

                    if (current.Previous == null)
                    {
                        this.First.Previous = newItem;
                        newItem.Next = this.First;
                        this.First = newItem;
                    }
                    else
                    {
                        current.Previous.Next = newItem;
                        newItem.Previous = current.Previous;
                        current.Previous = newItem;
                        newItem.Next = current;
                    }

                    break;
                }

                current = current.Next;
            }
        }

        public void AddAfter(T referenceValue, T value)
        {
            var current = this.First;
            while (current != null)
            {
                if (current.Value.Equals(referenceValue))
                {
                    var newItem = new ListItem<T>(value);
                    
                    if (current.Next == null)
                    {
                        this.Last.Next = newItem;
                        newItem.Previous = this.Last;
                        this.Last = newItem;
                    }
                    else
                    {
                        newItem.Next = current.Next;
                        newItem.Next.Previous = newItem;
                        current.Next = newItem;
                        newItem.Previous = current;
                    }

                    break;
                }

                current = current.Next;
            }
        }

        public void RemoveFirst()
        {
            if (this.First == null)
            {
                return;
            }

            this.First = this.First.Next;
            this.First.Previous = null;
        }

        public void RemoveLast()
        {
            if (this.Last == null)
            {
                return;
            }

            this.Last = this.Last.Previous;
            this.Last.Next = null;
        }
        
        public void Remove(T value)
        {
            var current = this.First;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (current.Previous == null && current.Next == null)
                    {
                        this.Clear();
                    }
                    else if (current.Previous == null)
                    {
                        this.First = this.First.Next;
                        this.First.Previous = null;
                    }
                    else if (current.Next == null)
                    {
                        this.Last = this.Last.Previous;
                        this.Last.Next = null;
                    }
                    else
                    {
                        var next = current.Next;
                        var prev = current.Previous;

                        prev.Next = next;
                        next.Previous = prev;       
                    }

                    break;                
                }

                current = current.Next;
            }
        }

        public int GetCount()
        {
            var count = 0;
            var current = this.First;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        public void Clear()
        {
            this.First = null;
            this.Last = null;
        }
    }
}
