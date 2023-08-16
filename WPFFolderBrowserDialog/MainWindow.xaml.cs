using System.Windows;
using WinForms = System.Windows.Forms;

namespace WPFFolderBrowserDialog
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            WinForms.FolderBrowserDialog dialog = new WinForms.FolderBrowserDialog();
            dialog.InitialDirectory = "C:\\_csc_projects\\Complete_csharp_Programming_Course\\WPFFolderBrowserDialog";
            WinForms.DialogResult result = dialog.ShowDialog();

            if(result == WinForms.DialogResult.OK)
            {
                string folder = dialog.SelectedPath;
            }
            else
            {

            }
        }
    }
}
