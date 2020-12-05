using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson20Homewrok3
{
    class ArrayList<T>
    {
        private T[] array = new T[10];
        int i = 0;
        int j = 0;
        public int Count
        {
            get { return array.Length; }
        }

        public void Enqueue(T item)
        {
            array[i] = item;
            i++;
            if (i >= array.Length)
            {
                Console.WriteLine("Max count of items in the stack");
                return;
            }
        }
        public T Denqueue()
        {
            if (j >= i)
            {
                Console.WriteLine("there is no elements");
                j = 0;
                i = 0;
                return default;
            }
            T temp = array[j];
            array[j] = default;
            j++;
            return temp;
        }
        public void Clear()
        {
            array = new T[array.Length];
        }
        public bool Contains(T arr)
        {
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i].Equals(arr))
                {
                    return true;
                }
            }
            return false;
        }
    }
}