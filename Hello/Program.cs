using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine("dotnet 5!");

            while (true)
            {
                HelloRef.HelloName helloName = new HelloRef.HelloName();
                Console.WriteLine($"{DateTime.Now.ToString()}   {helloName.GetName()}");
                System.Threading.Thread.Sleep(1000);
            }


            //Console.Write("any key to close.");
            //Console.ReadLine();
        }
    }
}
