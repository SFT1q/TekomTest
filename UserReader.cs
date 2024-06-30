using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Test.Tests;

namespace Test
{
    public class UserReader : IUserReader
    {
        public Person ReadPersonFromConsole()
        {
            Console.Write("Name: ");
            string? name = Console.ReadLine();
            Console.Write("Weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height: ");           
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Vision: ");
            int vision = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Курение:\n 1-Да\n 0-Нет");
            int smoke = Convert.ToInt32(Console.ReadLine());           
            List<string> habits = new List<string>();

            return new Person(name!, weight, height, age, vision, smoke, habits);
        }
    }
}



