using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // MyClass의 인스턴스 생성 및 메서드 호출
            MyClass myClass = new MyClass();
            myClass.SayHello();
        }
    }

    class MyClass
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from MyClass!");
        }
    }
}
