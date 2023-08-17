using System.Windows;
using WPFMVVMTest1.MVVM;

namespace WPFMVVMTest1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
        }
    }
}
