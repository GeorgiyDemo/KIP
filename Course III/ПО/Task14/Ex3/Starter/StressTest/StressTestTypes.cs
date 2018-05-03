using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StressTest
{
    // Enumerations Exercise 1

    /// <summary>
    /// Enumeration of girder material types
    /// </summary>
    public enum Material { StainlessSteel, Aluminium, ReinforcedConcrete, Composite, Titanium }

    /// <summary>
    /// Enumeration of girder cross-sections
    /// </summary>
    public enum CrossSection { IBeam, Box, ZShaped, CShaped }

    /// <summary>
    /// Enumeration of test results
    /// </summary>
    public enum TestResult { Pass, Fail }

    // Structures Exercise 2

    /// <summary>
    /// Structure containing test results
    /// </summary>
    public struct TestCaseResult
    {
        /// <summary>
        /// Test result (enumeration type)
        /// </summary>
        public TestResult Result;

        /// <summary>
        /// Description of reason for failure
        /// </summary>
        public string ReasonForFailure;
    }   

    // TODO - Add the StressTestCase class 
}
