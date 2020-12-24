using System;
namespace Lesson019_HT
{
    public class MyClass<T>
    {
        public static T FacrotyMethod(T el)
        {
            MyClass<T> name = new MyClass<T>();
            return el;
        }
        public MyClass()
        {
        }
    }
}
