using System.Windows;

namespace _16_WPF_Tutorial_v1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            expanderDetails.IsExpanded = !expanderDetails.IsExpanded;
        }
    }
}
