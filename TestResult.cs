using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestResult
    {
        public Grade Grade { get; set; }


        public string Message { get; set; }
        public TestResult(Grade grade, string message = "")
        {
            Grade = grade;
            Message = message;
        }

    }
}
