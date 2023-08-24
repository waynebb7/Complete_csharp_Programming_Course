using Microsoft.Win32;
using System.Windows;

namespace _10_WPF_Tutorial_v2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "C# Source Files | *.cs";
            fileDialog.InitialDirectory = "C:\\temp";
            fileDialog.Title = "Please select C# Source File(s)...";
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();

            if (success == true)
            {
                // Do something
                string[] paths = fileDialog.FileNames;
                string[] fileNames = fileDialog.SafeFileNames;

                //tbInfo.Text = fileName;
            }
            else
            {
                // They didn't pick anything
            }
        }
    }
}