using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StressTest;

namespace Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Execute some stress tests on girders and show the results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doTests_Click(object sender, RoutedEventArgs e)
        {
            testList.Items.Clear();
            resultList.Items.Clear();
            StressTestCase[] stressTestCases = CreateTestCases();
            StressTestCase currentStressTest;
            // TODO - Modify call to GetStressTestResult method to handle nulls.
            TestCaseResult currentTestResult;
            for (int i = 0; i < stressTestCases.Length; i++)
            {
                currentStressTest = stressTestCases[i];
                currentStressTest.PerformStressTest();
                testList.Items.Add(currentStressTest.ToString());                
                currentTestResult = currentStressTest.GetStressTestResult();
                resultList.Items.Add(currentTestResult.Result.ToString() + " " + currentTestResult.ReasonForFailure);
            }
        }

        /// <summary>
        /// Create some sample stress tests
        /// </summary>
        /// <returns>Array of Stress Test Cases</returns>
        private StressTestCase[] CreateTestCases()
        {
            StressTestCase[] stressTestCases = new StressTestCase[10];
 
            stressTestCases[0] = new StressTestCase();
            stressTestCases[1] = new StressTestCase(Material.Composite, CrossSection.CShaped, 3500, 100, 20);
            stressTestCases[2] = new StressTestCase();
            stressTestCases[3] = new StressTestCase(Material.Aluminium, CrossSection.Box, 3500, 100, 20);
            stressTestCases[4] = new StressTestCase();
            stressTestCases[5] = new StressTestCase(Material.Titanium, CrossSection.CShaped, 3600, 150, 20);
            stressTestCases[6] = new StressTestCase(Material.Titanium, CrossSection.ZShaped, 4000, 80, 20);
            stressTestCases[7] = new StressTestCase(Material.Titanium, CrossSection.Box, 5000, 90, 20);
            stressTestCases[8] = new StressTestCase();
            stressTestCases[9] = new StressTestCase(Material.StainlessSteel, CrossSection.Box, 3500, 100, 20);

            return stressTestCases;
        }
    }
}
