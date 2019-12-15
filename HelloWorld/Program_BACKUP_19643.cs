﻿using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
<<<<<<< .merge_file_UMcwz4
            Console.WriteLine("Merge change from user1");
=======
            Console.WriteLine("Merge change from user2");
>>>>>>> .merge_file_w5h5Gz
            var runner = new Runner();
            runner.Run();
        }
    }
}
