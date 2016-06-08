namespace _02.GenericList
{
    using System;
    using System.Text;

    // problem 5
    public class GenericList<T>
        where T : IComparable, new()          // added constrains
    {
        private const int DefaultCapacity = 20;
        private T[] elements;
        private int count = 0;
        private int capacity;

        public GenericList(int capacity)
        {
            this.elements = new T[this.capacity];
            this.Capacity = capacity;
        }

        public GenericList()
            : this(DefaultCapacity)
        {
        }

        public int Count
        {
            get { return this.count; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }

        // accessing element by index
        public T this[int index]
        {
            get
            {
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException(string.Format("Invalid index {0}!", index));
                }

                T result = this.elements[index];

                return result;
            }
        }

        // adding element
        public void AddElement(T element)
        {
            if (this.count >= this.elements.Length)
            {
                this.DoubleSize();                   // add in problem 6
            }

            this.elements[this.count] = element;
            this.count++;
        }

        // removing element by index
        public T RemoveElementAtIndex(int index)
        {
            if (index >= this.count || index < 0)
            {
                throw new IndexOutOfRangeException(string.Format("Invalid index {0}!", index));
            }

            T result = this.elements[index];

            for (int i = index; i < this.count; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[this.count - 1] = new T();

            this.count--;

            return result;
        }

        // inserting element at given position
        public void InsertElementAtIndex(int index, T element)
        {
            if (index > this.count || index < 0)
            {
                throw new IndexOutOfRangeException(string.Format("Invalid index {0}!", index));
            }

            if (index == this.count)
            {
                this.AddElement(element);
            }

            if (index >= this.elements.Length - 1)
            {
                this.DoubleSize();                             // add in problem 6
            }

            this.count++;

            for (int i = this.count; i >= index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = element;
        }

        // clearing the list
        public void Clear()
        {
            this.elements = new T[DefaultCapacity];
            this.count = 0;
            this.Capacity = DefaultCapacity;
        }

        // finding element by its value 
        public int FindElementByValue(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;  // if not equals
        }
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.count; i++)
            {
                result.Append(this.elements[i]);

                if (i < this.count - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }

        // problem 6
        public void DoubleSize()
        {
            int doubleSize = this.elements.Length * 2;
            T[] newArray = new T[doubleSize];

            for (int i = 0; i < this.count; i++)
            {
                newArray[i] = this.elements[i];
            }

            this.elements = newArray;
            this.Capacity *= 2;
        }

        // problem 7
        public T Min()
        {
            T min = this.elements[0];

            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.elements[0];

            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }
    }
}