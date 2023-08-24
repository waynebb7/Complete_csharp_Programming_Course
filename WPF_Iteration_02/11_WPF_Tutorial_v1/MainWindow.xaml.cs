using System.Windows;
using WinForms = System.Windows.Forms;

namespace _11_WPF_Tutorial_v1
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
            dialog.InitialDirectory = "C:\\_csc_projects\\Complete_csharp_Programming_Course\\WPF_Iteration_02\\11_WPF_Tutorial_v1";
            WinForms.DialogResult result = dialog.ShowDialog();

            if(result == WinForms.DialogResult.OK)
            {
                // Do something with the result (OK)
                string folder = dialog.SelectedPath;

                // Returns the folder string and displays in MessageBox
                WinForms.MessageBox.Show(folder);
            }
            else
            {
                // Do something else if Cancelled
            }
        }
    }
}