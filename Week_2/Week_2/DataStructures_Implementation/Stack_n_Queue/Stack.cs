using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_2.EnumeratorClass;
using Week_2.DataStructures_Implementation.NodeClass;

namespace Week_2.DataStructures_Implementation.Stack_n_Queue
{
    public class Stack<T> : IEnumerable<T>
    {
        private readonly Enumerable<T> _enumerable; // Field to store the enumerable instance
        private Node<T> top; // Field to store the top node of the stack
        private int size; // Field to store the size of the stack

        public Stack(Enumerable<T> enumerable) // Constructor for Stack class
        {
            _enumerable = enumerable; // Assign the enumerable instance to the field
            top = null; // Initialize the top to null
            size = 0; // Initialize the size to 0
        }

        public bool IsEmpty() // Method to check if the stack is empty
        {
            return size == 0; // Returns true if size is 0, otherwise false
        }

        public void Push(T value) // Method to add an item to the tail of 'the stack
        {
            Node<T> newest = new Node<T>(value, null); // Create a new node with the given value
            if (IsEmpty()) // If the stack is empty
            {
                top = newest; // Set the top to the newest node
            }
            else // Otherwise
            {
                newest.next = top; // Set the next of the newest node to the top node
                top = newest; // Set the top to the newest node
            }
            size++; // Increment the size of the stack
        }

        public T Pop() // Method to pop an element from the stack
        {
            if (IsEmpty()) // If the stack is empty
            {
                Console.WriteLine("stack is empty"); // Print a message
                return default(T); // Return the default value of type T
            }
            T value = top.data; // Get the value of the top node
            top = top.next; // Set the top to the next node
            size--; // Decrement the size of the stack
            return value; // Return the value
        }

        public T Peek() // Method to get the value of the top element without removing it from the stack
        {
            if (IsEmpty()) // If the stack is empty
            {
                Console.WriteLine("stack is empty"); // Print a message
                return default(T); // Return the default value of type T
            }
            return top.data; // Return the value of the top node
        }

        public int Size() // Method to get the size of the stack
        {
            return size; // Return the size
        }

        public IEnumerator<T> GetEnumerator() // Method to get the enumerator for the stack
        {
            return _enumerable.GetEnumerator(); // Return the enumerator of the enumerable field
        }

        IEnumerator IEnumerable.GetEnumerator() // Explicit interface implementation for IEnumerable
        {
            return GetEnumerator(); // Return the enumerator of the stack
        }
    }
}
