﻿﻿using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Merge change from user1");
            var runner = new Runner();
            runner.Run();
        }
    }
}
