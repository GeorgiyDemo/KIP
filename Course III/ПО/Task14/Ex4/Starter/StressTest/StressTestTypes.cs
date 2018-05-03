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

    // Classes Exercise 4

    /// <summary>
    /// Defines details of a complete girder stress test
    /// </summary>
    public class StressTestCase
    {
        /// <summary>
        /// Girder material type (enumeration type)
        /// </summary>
        public Material GirderMaterial;

        /// <summary>
        /// Girder cross-section (enumeration type)
        /// </summary>
        public CrossSection CrossSection;

        /// <summary>
        /// Girder length in millimeters
        /// </summary>
        public int LengthInMm;

        /// <summary>
        /// Girder height in millimeters
        /// </summary>
        public int HeightInMm;

        /// <summary>
        /// Girder width in millimeters
        /// </summary>
        public int WidthInMm;

        // TODO - Make testCaseResult nullable
        /// <summary>
        /// Details of test result (structure type)
        /// </summary>
        public TestCaseResult TestCaseResult;

        /// <summary>
        /// No argument constructor (invokes parameterised constructor passing default values)
        /// </summary>
        public StressTestCase() : this(Material.StainlessSteel, CrossSection.IBeam, 4000, 20, 15) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="girderMaterial">Girder material type (enumeration type)</param>
        /// <param name="crossSection">Girder cross-secion type (enumeration type)</param>
        /// <param name="lengthInMm">Girder length in millimeters</param>
        /// <param name="heightInMm">Girder height in millimeters</param>
        /// <param name="widthInMm">Girder width in millimeters</param>
        public StressTestCase(Material girderMaterial, CrossSection crossSection, int lengthInMm, int heightInMm, int widthInMm)
        {
            this.GirderMaterial = girderMaterial;
            this.CrossSection = crossSection;
            this.LengthInMm = lengthInMm;
            this.HeightInMm = heightInMm;
            this.WidthInMm = widthInMm;
            // TODO - Initialize TestCaseResult to null            
        }

        /// <summary>
        /// Execute a stress test and save the results in the testCaseResult field
        /// </summary>
        public void PerformStressTest()
        {
            // TODO - Update the PerformStressTest method to work with the nullable type

            // List of possible reasons for a failure
            string[] failureReasons = { "Fracture detected", "Beam snapped", "Beam dimensions wrong", "Beam warped", "Other" };
            
            // Fails 1 time in 10
            if (Utility.rand.Next(10) == 9)
            {
                TestCaseResult.Result = TestResult.Fail;
                TestCaseResult.ReasonForFailure = failureReasons[Utility.rand.Next(5)];
            }
            else
            {
                TestCaseResult.Result = TestResult.Pass;
            }
        }

        /// <summary>
        /// Return the results of the test
        /// </summary>
        /// <returns>Results of test</returns>
        public TestCaseResult GetStressTestResult()
        {
            // TODO - Update the GetStressTestResult method to work with the nullable type
            return TestCaseResult;
        }

        /// <summary>
        /// Override of ToString
        /// </summary>
        /// <returns>Formatted string</returns>
        public override string ToString()
        {
            return string.Format("Material: {0}, CrossSection: {1}, Length: {2}mm, Height: {3}mm, Width: {4}mm",
                GirderMaterial.ToString(), CrossSection.ToString(), LengthInMm, HeightInMm, WidthInMm);
        }
    }
}
