using System;

namespace Lesson019_HT_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            string res;
            myDictionary.Add(1, "Yellow");
            myDictionary.Add(2, "Green");
            myDictionary.Add(3, "Orange");
            myDictionary.Add(4, "Black");
            myDictionary.Add(5, "White");
            myDictionary.Add(6, "Gray");
            myDictionary.Add(7, "Purple");
            myDictionary.Add(8, "Cherry");
            myDictionary.Add(9, "Red");
            myDictionary.Add(9, "Neon");
            Console.WriteLine(" ");
            myDictionary.Index(2);
            Console.WriteLine(" ");
            res = myDictionary.myDictionaryProp;
            Console.WriteLine($"{res}");
        }
    }
}
