﻿using System;

namespace for3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i > b; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}