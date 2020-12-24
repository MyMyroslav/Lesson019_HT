using System;
namespace Lesson019_HT_Task4
{
    public class MyList<T>
    {
       T [] array = null;
        int i = 0;
        int j = 0;
        public MyList(T[] array)
        {
            this.array = array;
        }
        public T GetList(int index) { return array[i]; }
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

        //public int Count()
        //{
        //    return array.Length;
        //}

        public int Count {
            get
            {
                return array.Length;
            }
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
    public static class MyExstension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var arr = new T[list.Count];
            for(int i =0; i < arr.Length; i++)
            {
                arr[i] = list.GetList(i);
            }

            return arr;
        }
    }
}
