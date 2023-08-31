using System.Windows;

namespace WPFExpander
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
