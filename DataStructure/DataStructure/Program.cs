﻿using System;
using System.Collections.Generic;

namespace DataStructure
{
    public class Program
    {
        static void Main( string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList<string> list = new LinkedList<string>();
            list.Add("70");
            list.Add("30");
            list.Add("56");
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.Search("Size"));
            list.Insert(2, "40");
            list.Remove("40");
            list.Size();
            list.display();

        }
    }
}
