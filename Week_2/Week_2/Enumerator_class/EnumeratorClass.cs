using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_2.DataStructures_Implementation.Stack_n_Queue;
using Week_2.DataStructures_Implementation;


namespace Week_2.EnumeratorClass
{
    public class Enumerable<T> : IEnumerable<T>
    {
        private readonly T[] _items; // private field to hold the array of items of type T (which is generic)

        public Enumerable(T[] items) // constructor to initialize the private field
        {
            _items = items;
        }

        public IEnumerator<T> GetEnumerator() // implementation of the generic GetEnumerator method
        {
            for (int i = 0; i < _items.Length; i++) // loop over the items in the array
            {
                yield return _items[i]; // yield the current item
            }
        }

        IEnumerator IEnumerable.GetEnumerator() // implementation of the non-generic GetEnumerator method
        {
            return GetEnumerator(); // call the generic GetEnumerator method
        }
    }
}
