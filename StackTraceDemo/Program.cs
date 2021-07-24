using System;

namespace StackTraceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            new A().MethodA(new B());
        }
    }
}
