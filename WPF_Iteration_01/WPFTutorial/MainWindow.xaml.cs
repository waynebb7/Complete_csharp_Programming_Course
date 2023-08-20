using System.Windows;

namespace WPFTutorial
{
    public partial class MainWindow : Window
    {
        bool running = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                running = false;
                tbStatus.Text = "Not Running...";
            }
            else
            {
                running = true;
                tbStatus.Text = "Running...";
            }
        }
    }
}
