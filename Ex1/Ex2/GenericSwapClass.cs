using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    public class GenericSwapClass<T>
    {
        public static T[] Swap(T[] array, int index1, int index2)
        {
            if(index1 >= 0 && index2 < array.Length)
            {
                T aux = array[index1];
                array[index1] = array[index2];
                array[index2] = aux;
            }
            return array;
        }
    }
}
