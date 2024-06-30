using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    public class TestWeird: ITest
    {
        public TestResult Test(Person person)
        {
            if (person.PersonName.StartsWith("П"))
            {
                return new TestResult(Grade.Good);
            }
            if (person.PersonAge < 68)
            {
                return new TestResult(Grade.Satisfactorily, "Не удовлетворяет критерию из «хорошо» и возраст кандидата больше 68 лет");

            }
            else
            {
                return new TestResult(Grade.Unsatisfactory, "Если не удовлетворяет критериям из «хорошо» и «удовлетворительно»");
            }
        }
    }
}
