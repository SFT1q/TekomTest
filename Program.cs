using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Test.Tests;
using static System.Net.Mime.MediaTypeNames;

namespace Test
{
    public class Program
    {

        public static void Main(string[] args)
        {

            IUserReader userReader = new UserReader();

            while (true)
            {

                Person person = userReader.ReadPersonFromConsole();

                var allTests = new List<ITest>
                {
                    new Tests.TestAge(),
                    new Tests.TestHeight(),
                    new Tests.TestMathematical(),
                    new Tests.TestPsychologist(),
                    new Tests.TestSmokes(),
                    new Tests.TestVision(),
                    new Tests.TestWeight(),
                    new Tests.TestWeightAndBadHabits(),
                    new Tests.TestWeird(),
                    new Tests.TestСlinicus()

                };
                var results = new List<TestResult>();

                foreach (var test in allTests)
                {
                    results.Add(test.Test(person));
                }

                bool passed = true;
                var problems = new List<string>();

                foreach (var result in results)
                {
                    if (result.Grade == Grade.Unsatisfactory)
                    {
                        passed = false;
                        problems.Add(result.Message);
                    }
                }

                if (passed)
                {
                    Console.WriteLine($"Кандидат {person.PersonName} подходит");
                }
                else
                {
                    Console.WriteLine($"Кандидат {person.PersonName} не прошел тестирование. Проблемы:");
                    foreach (var problem in problems)
                    {
                        Console.WriteLine($"- {problem}");
                    }
                }
               
                Console.WriteLine("Хотите протестировать следущего кандидата?");
                Console.WriteLine("Да/Нет");
                string? next = Console.ReadLine();               
                if (next == "нет".ToLower())
                {
                    break;
                }
                
            }
        }

    }
}
