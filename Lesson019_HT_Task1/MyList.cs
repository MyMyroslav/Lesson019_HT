using System;
namespace Lesson019_HT_Task1
{
    public class MyList<T>
    {
        T[] array = null;
        int i = 0;
        int j = 0;
        public MyList(T[] array)
        {
            this.array = array;
        }
        public void Add(T el)
        {
            T[] arr = new T[array.Length + 1];
            array.CopyTo(arr, 0); 
            if (i >= arr.Length)
            {
                Console.WriteLine("Max Length");
                return;
            }
            array[i] = el;
            Console.WriteLine(array[i]);
            i++;
        }

        public int Count()
        {
            return i;
        }

        public void Clear()
        {
            array = new T[array.Length];
            i = 0;
        }

        public bool Contains(T el)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(el))
                {
                    return true;
                }
            }
            return false;
        }

        string res;
        public override string ToString()
        {
            for (int k = 0; k < array.Length; k++)
            {
                res += " over: " + array[k];
            }
            return res;
        }

    }
}
