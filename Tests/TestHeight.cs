using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    public class TestHeight : ITest
    {
        public TestResult Test(Person person)
        {

            if (person.PersonHeight >= 170 && person.PersonHeight <= 185)
            {
                return new TestResult(Grade.Good);
            }
            if (person.PersonHeight >= 160 && person.PersonHeight <= 169 || person.PersonHeight >= 186 && person.PersonHeight <= 190)
            {
                return new TestResult(Grade.Satisfactorily, "[160-170) см, (185-190] см");
            }
            return new TestResult(Grade.Unsatisfactory, "> 190 см, < 160 см");
        }
    }
}
