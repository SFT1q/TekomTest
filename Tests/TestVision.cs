using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    public class TestVision : ITest
    {
        public TestResult Test(Person person)
        {
            if (person.PersonVision >= 1)
            {
                return new TestResult(Grade.Good);
            }
            if (person.PersonVision <= 0)
            {
            return new TestResult(Grade.Unsatisfactory, "< 1");
            }
            return new TestResult(Grade.Satisfactorily);
        }
    }
}
