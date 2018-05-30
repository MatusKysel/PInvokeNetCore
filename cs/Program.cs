using System;
using System.Runtime.InteropServices;

namespace dev
{
    public static class Program
    {
        [DllImport("libtest.so")]

        public static extern void print(string message);

        public static void Main(string[] args)
        {
                print("Hello World C# => C++");
        }
    }
}
