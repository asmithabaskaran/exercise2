using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;
            //Max heart rate is equal to 220 - age
            int heart;
            age = 26;
            height = 170;
            heart = 220 - age;

            //Write I am ## years old, my max heart rate is ## and I am ## cms tall
            Console.WriteLine("I am " + age  + " years old and my max heart rate is " + heart  + " and I am " + height  + " cms tall");
            Console.ReadLine();
        }
    }
}
