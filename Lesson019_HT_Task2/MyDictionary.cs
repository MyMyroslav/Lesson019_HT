using System;
namespace Lesson019_HT_Task2
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] keyArr = new TKey[10];
        TValue[] valueArr = new TValue[10];
        int i = 0;
        int j = 0;
        public MyDictionary()
        {

        }
        public MyDictionary(TKey[] keyArr, TValue[] valueArr)
        {
            this.keyArr = keyArr;
            this.valueArr = valueArr;
        }
        string res;
        public string myDictionaryProp
        {
            get
            {
                for (int i = 0; i < 10; i++)
                {
                    res += "OVER" + " " + keyArr[i]+ " " + valueArr[i] + "\n";
                }
                return res;
            }
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] arr1 = new TKey[10];
            TValue[] arr2 = new TValue[10];
            keyArr.CopyTo(arr1, 0);
            valueArr.CopyTo(arr2, 0);
            if (i >= arr1.Length || i >= arr2.Length)
            {
                Console.WriteLine("Max Length");
                return;
            }
            arr1[i] = key;
            arr2[i] = value;
            Console.WriteLine($"key: {arr1[i]}, value: {arr2[i]}");
            arr1.CopyTo(keyArr, 0);
            arr2.CopyTo(valueArr, 0);
            i++;
        }
        public void Index(TKey key)
        {
            for (int i = 0; i < 10; i++)
            {
                if (keyArr[i].Equals(key))
                {
                    Console.WriteLine($"key: {keyArr[i]}, value: {valueArr[i]}");
                }
            }
        }
    }
}
