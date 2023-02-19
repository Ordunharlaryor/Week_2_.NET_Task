using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Collections;
using Week_2.EnumeratorClass;
using Week_2.DataStructures_Implementation.NodeClass;

namespace Week_2.DataStructures_Implementation.Stack_n_Queue
{
    // The Queue class is a generic class and implements the IEnumerable interface
   public class Queue<T> : IEnumerable<T>
    {
        private readonly Enumerable<T> _enumerable; // Private readonly variable that stores an Enumerable object of type T
        private Node<T> front; // Private variable that represents the front of the queue
        private Node<T> rear; // Private variable that represents the rear of the queue
        private int size; // Private variable that stores the size of the queue

        // Constructor that initializes the queue
        public Queue(Enumerable<T> enumerable)
        {
            _enumerable = enumerable;
            front = null;
            rear = null;
            size = 0;
        }

        // Method that checks if the queue is empty
        public bool IsEmpty()
        {
            return size == 0;
        }

        // Method that adds a new element to the end of the queue
        public void Enqueue(T value)
        {
            Node<T> newest = new Node<T>(value, null);
            if (IsEmpty())
            {
                // If the queue is empty, the new element becomes both the front and rear
                front = newest;
                rear = newest;
            }
            else
            {
                // Otherwise, the new element becomes the new rear
                rear.next = newest;
                rear = newest;
            }
            // Increase the size of the queue by 1
            size++;
        }

        // Method that removes and returns the front element of the queue
        public T Dequeue()
        {
            if (IsEmpty())
            {
                // If the queue is empty, throw an exception
                throw new InvalidOperationException("Queue is empty");
            }
            // Remove the front element and update the front pointer
            T value = front.data;
            front = front.next;
            size--;
            if (IsEmpty())
            {
                // If the queue is now empty, set the rear pointer to null
                rear = null;
            }
            // Return the removed element
            return value;
        }

        // Method that returns the size of the queue
        public int Size()
        {
            return size;
        }

        // Method that returns an enumerator for iterating over the queue elements
        public IEnumerator<T> GetEnumerator()
        {
            return _enumerable.GetEnumerator();
        }

        // Method that returns an enumerator for iterating over the queue elements
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
