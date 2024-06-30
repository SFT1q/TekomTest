using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    public class TestWeightAndBadHabits : ITest
    {
        public TestResult Test(Person person)
        {
            if (person.PersonBadHabits.Contains("Вирусы (virus)") && person.PersonWeight >= 110)
            {
                return new TestResult(Grade.Satisfactorily, "Не удовлетворяет критерию из «неудовлетворительно», и у кандидата есть простуда и/или вирусы, и его вес больше 110 кг");
            }
            if (person.PersonBadHabits.Contains("Курит (smoke)") && person.PersonBadHabits.Contains("Вирусы (virus)") && person.PersonWeight >= 120 || person.PersonWeight <= 60)
            {
                
                return new TestResult(Grade.Unsatisfactory, "Кандидат курит, у кандидата простуда и/или вирусы, и его вес больше 120 кг или меньше 60 кг");
            }
            else
            {
                return new TestResult(Grade.Good);
            }
        }
    }
}
