using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StressTest
{
    public static class TestManager
    {
        public static TestCaseResult GenerateResult()
        {            
            int resultCode;
            TestCaseResult result = new TestCaseResult();
            if ((resultCode = Utility.Rand.Next(10)) < 8)
            {
                result.Result = TestResult.Pass;
            }
            else
            {
                result.Result = TestResult.Fail;
                if (resultCode == 8)
                {
                    result.ReasonForFailure = "Beam Snapped";
                }
                else
                {
                    result.ReasonForFailure = "Fractures Detected";
                }
            }

            return result;
        }
    }
}
