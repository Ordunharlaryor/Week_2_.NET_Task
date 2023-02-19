using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2.DataStructures_Implementation.NodeClass
{
        // This class represents a node in a linked list and is implemented as a generic class.
        public class Node<T>
        {
            // This field holds the data stored in the node.
            public T data;
            // This field holds a reference to the next node in the list.
            public Node<T> next;
            // This constructor initializes the data and next fields of a node.
            public Node(T value, Node<T> link)
            {
                data = value;
                next = link;
            }
        }
    }
