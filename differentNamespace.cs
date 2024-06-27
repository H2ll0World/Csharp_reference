using System;

namespace FirstNamespace
{
    public class ClassA
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello from FirstNamespace.ClassA!");
        }
    }
}

namespace SecondNamespace
{
    public class ClassB
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello from SecondNamespace.ClassB!");
        }
    }
}

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // FirstNamespace의 ClassA 사용
            FirstNamespace.ClassA classA = new FirstNamespace.ClassA();
            classA.PrintMessage();

            // SecondNamespace의 ClassB 사용
            SecondNamespace.ClassB classB = new SecondNamespace.ClassB();
            classB.PrintMessage();
        }
    }
}
