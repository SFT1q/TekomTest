using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    public class TestWeight : ITest
    {
        public TestResult Test(Person person)
        {

            if (person.PersonWeight >= 75 && person.PersonWeight <= 90)
            {
                return new TestResult(Grade.Good);
            }
            if (person.PersonWeight >= 70 && person.PersonWeight <= 74 || person.PersonWeight >= 91 && person.PersonWeight <= 100)
            {
                return new TestResult(Grade.Satisfactorily, "[70-75) кг, (90-100] кг");
            }
            return new TestResult(Grade.Unsatisfactory, "> 100 кг, < 70 кг");
        }
    }
}
