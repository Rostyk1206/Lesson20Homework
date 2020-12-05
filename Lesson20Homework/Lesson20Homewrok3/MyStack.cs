using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson20Homewrok3
{
    class MyStack<T> where T : struct
    {
        private T[] array = new T[10];
        int i = 0;
        public int Count
        {
            get { return array.Length; }
        }

        public void Push(T item)
        {
            array[i] = item;
            i++;
            if (i >= array.Length)
            {
                Console.WriteLine("Max count of items in the stack");
                return;
            }
        }
        public T Pop()//повертає елемент і видаляє
        {
            int j = --i;
            if (j == -1)
            {
                i = 0;
                Console.WriteLine("There is no such position in the stack");
                return default;
            }
            T temp = array[j];
            array[j] = default;
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