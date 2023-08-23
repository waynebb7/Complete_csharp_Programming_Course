using System.Windows;

namespace _09_WPF_Tutorial_v3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your message here",
                            "ERROR",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);

        }

        private void btnFireWithResponse_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you agree?",
                                                      "Agreement",
                                                      MessageBoxButton.YesNo,
                                                      MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tbInfo.Text = "Agreed";
            }
            else
            {
                tbInfo.Text = "Not Agreed";
            }
        }
    }
}
