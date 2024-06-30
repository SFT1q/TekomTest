using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    public class TestPsychologist : ITest
    {
        public TestResult Test(Person person)
        {
            Console.WriteLine("Введите ваши вредные привычки через запятую:");
            Console.WriteLine("Алкоголизм (alcoholism)\r\nБессонница (insomnia)\r\nНаркомания (narcomania)\r\nТравмы (injury)");
            Console.WriteLine("Если вы не больны, нажмите 0");

            string input = Console.ReadLine();            
            if (input == "0")
            {
                person.PersonBadHabits = new List<string>();
            }
            else if (input != null)
            {
                person.PersonBadHabits = new List<string>(input.Split(','));
            }

            if (person.PersonBadHabits.Count == 0)
            {
                return new TestResult(Grade.Good);
            }
            if (person.PersonBadHabits.Count == 1)
            {
                return new TestResult(Grade.Satisfactorily, "1 болезнь");
            }
            return new TestResult(Grade.Unsatisfactory, "Более 1 болезни");
        }
    }
}
