using System.Text;
using System.Windows;
using System.Windows.Controls;
using StressTest;

namespace Enumerations
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
        /// Display the enumeration values in ListBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Material[] materialsList = (Material[])System.Enum.GetValues(typeof (Material));
            for (int i = 0; i < materialsList.Length; i++)
            {
                materials.Items.Add(materialsList[i]);
            } 
 
            CrossSection[] crossSectionList = (CrossSection[])System.Enum.GetValues(typeof(CrossSection));
            for (int i = 0; i < crossSectionList.Length; i++)
            {
                crosssections.Items.Add(crossSectionList[i]);
            }
 
            TestResult[] testResultsList = (TestResult[])System.Enum.GetValues(typeof(TestResult));
            for (int i = 0; i < testResultsList.Length; i++)
            {
                testresults.Items.Add(testResultsList[i]);
            }

            materials.SelectedIndex = 0;
            crosssections.SelectedIndex = 0;
            testresults.SelectedIndex = 0;
        }

        private void selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (materials.SelectedIndex == -1 || crosssections.SelectedIndex == -1 || testresults.SelectedIndex == -1) return;

            Material selectedMaterial = new Material();
            selectedMaterial = (Material) materials.SelectedItem;

            CrossSection selectedCrossSection = new CrossSection();
            selectedCrossSection = (CrossSection) crosssections.SelectedItem;

            TestResult selectedTestResult = new TestResult();
            selectedTestResult = (TestResult) testresults.SelectedItem;

            StringBuilder selectionStringBuilder = new StringBuilder();
            switch (selectedMaterial)
            {
                case Material.StainlessSteel:
                    selectionStringBuilder.Append(" Материал: " + selectedMaterial + ",");
                    break;
                case Material.Aluminum:
                    selectionStringBuilder.Append(" Материал: " + selectedMaterial + ",");
                    break;
                case Material.ReinforcedConcrete:
                    selectionStringBuilder.Append(" Материал: " + selectedMaterial + ",");
                    break;
                case Material.Composite:
                    selectionStringBuilder.Append(" Материал: " + selectedMaterial + ",");
                    break;
                case Material.Titanium:
                    selectionStringBuilder.Append(" Материал: " + selectedMaterial + ",");
                    break;
            }

            switch (selectedCrossSection)
            {
                case CrossSection.Box:
                    selectionStringBuilder.Append(" cross-section:" + selectedCrossSection);
                    break;
                case CrossSection.CShaped:
                    selectionStringBuilder.Append(" cross-section:" + selectedCrossSection);
                    break;
                case CrossSection.IBeam:
                    selectionStringBuilder.Append(" cross-section:" + selectedCrossSection);
                    break;
                case CrossSection.ZShaped:
                    selectionStringBuilder.Append(" cross-section:" + selectedCrossSection);
                    break;  
            }

            switch (selectedTestResult)
            {
                case TestResult.Fail:
                    selectionStringBuilder.Append(", результат:" + selectedTestResult);
                    break;
                case TestResult.Pass:
                    selectionStringBuilder.Append(", результат:" + selectedTestResult);
                    break;
            }

            testDetails.Content = selectionStringBuilder;
        }
    }
}
