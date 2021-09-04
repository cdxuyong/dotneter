using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine("dotnet 5!");

            HelloRef.HelloName helloName = new HelloRef.HelloName();
            Console.WriteLine(helloName.GetName());

            Console.Write("any key to close.");
            Console.ReadLine();
        }
    }
}
