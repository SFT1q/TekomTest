using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    public class TestAge : ITest
    {
        public TestResult Test(Person person)
        {

            if (person.PersonAge >= 25 && person.PersonAge <= 35)
            {
                return new TestResult(Grade.Good);
            }
            if (person.PersonAge >= 23 && person.PersonAge <= 24 || person.PersonAge >= 36 && person.PersonAge <= 37)
            {
                return new TestResult(Grade.Satisfactorily, "[23-25) лет, (35-37] лет");
            }
            return new TestResult(Grade.Unsatisfactory, "> 37 лет, < 23 лет");
        }
    }
}
