using System.Windows;

namespace WPFMessageBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Could not open file.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            
            MessageBoxResult result = MessageBox.Show("Do you agree", "AGREEMENT",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                // Do something
                tbInfo.Text = "Agreed";
            }
            else
            {
                // Do something else
                tbInfo.Text = "Not agreed";
            }
        }
    }
}
