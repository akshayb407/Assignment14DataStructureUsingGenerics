using System;
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
           list.Add("56");
            list.Add("30");
           Console.WriteLine(list.ToString());
            list.Size();
            list.display();

          
           

        }
    }
}
