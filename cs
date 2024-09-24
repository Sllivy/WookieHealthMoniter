using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WookieHealthMonitor
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

        private void CalculateBMI_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double height = double.Parse(txtHeight.Text);
                double weight = double.Parse(txtweight.Text);


                double bmi = weight / (height * height);

                // MessageBox.Show(bmi.ToString());
                string bmiCategory = GetBMICategory(bmi);

                lblResult.Content = $"Wookie {txtName.Text} BMI:{bmi:F2}({bmiCategory})";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }

        }
    }
}
