using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FitnessTracker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtSteps.Text, out int steps))
            {
                // Save steps to a data store (e.g., a file or a database)
                // For demonstration purposes, we'll just display the steps
                lblResult.Content = $"You have entered {steps} steps today.";
            }
            else
            {
                MessageBox.Show("Please enter a valid number of steps.", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
        