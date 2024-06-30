using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    public class TestMathematical : ITest
    {
        public TestResult Test(Person person)
        {
            if (person.PersonHeight % 2 == 0)
            {
                return new TestResult(Grade.Good);
            }
            if (person.PersonHeight % 3 == 0 && person.PersonBadHabits.Contains("Насморк (cold)"))
            {
            return new TestResult(Grade.Unsatisfactory, "Все случаи, кроме того, что описано в «хорошо» и «неудовлетворительно»");
            }
             return new TestResult(Grade.Satisfactorily, "Рост делится нацело на 3, и у кандидата насморк");
        }
    }
}
