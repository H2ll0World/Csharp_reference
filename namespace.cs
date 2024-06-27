using System;

namespace FirstNamespace
{
    class ExampleClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello from FirstNamespace.ExampleClass!");
        }
    }
}

namespace SecondNamespace
{
    class ExampleClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello from SecondNamespace.ExampleClass!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // FirstNamespace의 ExampleClass 사용
        FirstNamespace.ExampleClass firstExample = new FirstNamespace.ExampleClass();
        firstExample.PrintMessage();

        // SecondNamespace의 ExampleClass 사용
        SecondNamespace.ExampleClass secondExample = new SecondNamespace.ExampleClass();
        secondExample.PrintMessage();
    }
}
