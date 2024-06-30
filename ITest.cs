using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test
{
    public interface ITest
    {
        public TestResult Test(Person person);

    }
}
