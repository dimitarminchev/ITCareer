using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ArrayCreator
{
    public static class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            // Create Array
            T[] array = new T[length];

            // Initialize the Array
            for (int i = 0; i < length; i++)
            {
                array[i] = item;
            }

            // Return the Array
            return array;
        }
    }
}
