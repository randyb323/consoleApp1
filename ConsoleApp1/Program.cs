﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Comment added 
                Console.WriteLine("Finally Block");
            }
        }
    }
}
