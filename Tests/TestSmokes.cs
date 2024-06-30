using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Test.Tests
{
    public class TestSmokes : ITest
        
    {        
        public TestResult Test(Person person)
        {          
            if (person.PersonSmoke == 0)
            {
                return new TestResult(Grade.Good);
            }          
            if (person.PersonSmoke == 1)
            {
                return new TestResult(Grade.Unsatisfactory,"Курит");
            }
            return new TestResult(Grade.Satisfactorily);
        }
    }
    
      
}
