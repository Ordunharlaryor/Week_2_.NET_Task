using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_2.EnumeratorClass;
using Week_2.DataStructures_Implementation.NodeClass;


namespace Week_2.DataStructures_Implementation
{
    public class SinglyLinkedList<T>
    {
        // Declare private variables for the head, tail, and size of the list.
        private Node<T> head;
        private Node<T> tail;
        private int size;

        // The class constructor initializes the head, tail, and size variables to null, null, and 0, respectively.
        public SinglyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        // This method returns true if the list is empty, otherwise it returns false.
        public bool IsEmpty()
        {
            return size == 0;
        }

        // This method adds a new node to the end of the list with the provided value.
        public void Add(T value)
        {
            // Create a new node with the provided value and null as the next node.
            Node<T> newest = new Node<T>(value, null);
            if (IsEmpty())
            {
                // If the list is empty, set the head and tail to the new node.
                head = newest;
                tail = newest;
            }
            else
            {
                // Otherwise, add the new node to the end of the list and update the tail.
                tail.next = newest;
                tail = newest;
            }
            // Increase the size of the list by 1.
            size++;
        }

        // This method removes the first node from the list.
        public bool Remove()
        {
            if (IsEmpty())
            {
                // If the list is empty, print a message and return false.
                Console.WriteLine("List is empty");
                return false;
            }
            else
            {
                // Otherwise, update the head to the next node and decrease the size of the list by 1.
                head = head.next;
                size--;
                return true;
            }
        }

        // This method checks if a node with the provided value is in the list and returns true if it is, otherwise it returns false.
        public bool Check(T value)
        {
            // Initialize a node pointer to the head of the list.
            Node<T> p = head;
            while (p != null)
            {
                if (p.data.Equals(value))
                {
                    // If the node with the value is found, return true.
                    return true;
                }
                // Move the pointer to the next node in the list.
                p = p.next;
            }
            // If the value is not found, return false.
            return false;
        }

        // This method returns the index of the first node with the provided value. If the value is not in the list, it returns -1.
        public int Index(T value)
        {
            // Initialize a node pointer to the head of the list and an index variable to 0.
            Node<T> p = head;
            int index = 0;
            while (p != null)
            {
                if (p.data.Equals(value))
                {
                    // If the node with the value is found, return the index.
                    return index;
                }
                // Move the pointer to the next node in the list and increment the index.
                p = p.next;
                index++;
            }
            // If the value is not found, return -1.
            return -1;
        }

    }
}
