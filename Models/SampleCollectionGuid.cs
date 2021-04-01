using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class SampleCollectionGuid<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];
        private Guid[] arr2 = new Guid[100];
        int nextIndex = 0;
        private Guid index = new Guid();
        // Define the indexer to allow client code to use [] notation.
        //public T this[Guid i] = arr1[arr2[i]]
        //{
        //    arr [i];
        //}

        public void Add(T value)
        {
            //if (nextIndex >= arr.Length)
            //    throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
            //arr[] = value;
            //nextIndex++;
        }
    }
}
