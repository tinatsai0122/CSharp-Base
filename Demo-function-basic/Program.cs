﻿namespace Demo_function_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            d1.value = 5;

            d1.ShowIfEqual5();

            Console.WriteLine("Salut");
        }
    }
}