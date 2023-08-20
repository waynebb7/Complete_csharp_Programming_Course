using Microsoft.Win32;
using System.Windows;

namespace WPFOpenFileDialog
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
            // Add a filter
            fileDialog.Filter = "C# Source Files | *.cs";
            //fileDialog.InitialDirectory = "C:\\temp";
            fileDialog.Title = "Please pick CS source file(s)...";
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();

            if(success == true)
            {
                // Do something
                //string path = fileDialog.FileName;
                //string fileName = fileDialog.SafeFileName;
                
                string[] paths = fileDialog.FileNames;
                string[] fileNames = fileDialog.SafeFileNames;

                //tbInfo.Text = path;
                //tbInfo.Text = fileName;
            }
            else
            {
                // They didn't pick anything
            }
        }
    }
}
