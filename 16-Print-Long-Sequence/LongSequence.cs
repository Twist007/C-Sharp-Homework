using System;
 class LongSequence
    {
        static void Main()
        {
            Console.BufferHeight = 1001;
            int mul = -1;
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(i * mul);
            }
        }
    }

