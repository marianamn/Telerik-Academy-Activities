using System;
using System.Linq;

namespace PriorityQueueImplementation
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 5;
        private int capacity;
        private T[] queue;
        private int size;

        public PriorityQueue()
        {
            this.capacity = DefaultCapacity;
            this.queue = new T[this.capacity];
            this.size = 0;
        }

        public PriorityQueue(int size)
        {
            this.queue = new T[size];
            this.size = 0;
            this.capacity = size;
        }

        public int Count
        {
            get
            {
                return this.size;
            }
        }

        public void Enqueue(T element)
        {
            if (this.size >= this.capacity)
            {
                this.Resize();
            }

            this.queue[this.size] = element;
            this.SiftUp();
            this.size++;
        }

        public T Dequeue()
        {
            if (this.size <= 0)
            {
                throw new ArgumentOutOfRangeException("size", "Cannot dequeue from empty priority queue!");
            }

            T highestPriorityElement = this.queue[0];
            this.queue[0] = this.queue[this.size - 1];
            this.size--;
            this.SiftDown();
            return highestPriorityElement;
        }

        public T Peek()
        {
            if (this.size <= 0)
            {
                throw new ArgumentException("Cannot peek into empty priority queue!");
            }

            return this.queue[0];
        }

        public override string ToString()
        {
            return string.Format("{0}", string.Join(", ", this.queue));
        }

        private void Resize()
        {
            this.capacity = this.capacity * 2;
            T[] newArray = new T[this.capacity];
            for (int i = 0; i < this.size; i++)
            {
                newArray[i] = this.queue[i];
            }

            this.queue = newArray;
        }

        private void SiftUp()
        {
            int currentPosition = this.size;
            int parentPosition = (currentPosition - 1) / 2;
            while (currentPosition > 0)
            {
                if (this.queue[currentPosition].CompareTo(this.queue[parentPosition]) > 0)
                {
                    this.Swap(ref this.queue[currentPosition], ref this.queue[parentPosition]);
                }
                else
                {
                    return;
                }

                currentPosition = parentPosition;
                parentPosition = (currentPosition - 1) / 2;
            }
        }

        private void SiftDown()
        {
            int currentPosition = 0;
            int leftChildPosition = (currentPosition * 2) + 1;
            int rightChildPosition = leftChildPosition + 1;

            while (leftChildPosition < this.size)
            {
                int index = leftChildPosition;

                if (rightChildPosition < this.size &&
                    this.queue[leftChildPosition].CompareTo(this.queue[rightChildPosition]) < 0)
                {
                    index = rightChildPosition;
                }

                if (this.queue[currentPosition].CompareTo(this.queue[index]) > 0)
                {
                    return;
                }

                this.Swap(ref this.queue[currentPosition], ref this.queue[index]);

                leftChildPosition = (index * 2) + 1;
                rightChildPosition = leftChildPosition + 1;
                currentPosition = index;
            }
        }

        private void Swap(ref T first, ref T second)
        {
            T oldValue = first;
            first = second;
            second = oldValue;
        }
    }
}