﻿using System;
using System.Collections.Generic;

namespace DataStructure
{
    internal class Program
    {
        static void Main( string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList<string> list = new LinkedList<string>();
            list.Add("70");
            //list.Add("30");
            list.Add("56");
            Console.WriteLine(list.ToString());
            //list.Pop(2);          
            Console.WriteLine(list.Search("30"));
            list.display();

        }
    }
}
