using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Test.Tests
{
    public class TestСlinicus : ITest
    {           
        public TestResult Test(Person person)
        {
            Console.WriteLine("Терапевт проверяет наличие следующих болезней:\r\nНасморк (cold)\r\nБронхит (bronchitis)\r\nВирусы (virus)\r\nАллергия (allergy)\r\nАнгина (quinsy)\r\nБессонница (insomnia)");
            Console.WriteLine("Если вы не больны, нажмите 0");

            string input = Console.ReadLine();
            if(input == "0")
            {
                person.PersonBadHabits = new List<string>();
            }          
            else if(input != null)
            {
                person.PersonBadHabits = new List<string>(input.Split(","));
            }

            if (person.PersonBadHabits.Count <= 2)
            {
                return new TestResult(Grade.Good);
            }
            if (person.PersonBadHabits.Count == 3)
            {
                return new TestResult(Grade.Satisfactorily, "3 болезни");
            }
            return new TestResult(Grade.Unsatisfactory, "Больше 3 болезней");
        }                
    }
}
