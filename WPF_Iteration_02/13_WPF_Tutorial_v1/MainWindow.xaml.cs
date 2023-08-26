using System.Collections.ObjectModel;
using System.Windows;

namespace _13_WPF_Tutorial_v1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            Entries = new ObservableCollection<string>();
            InitializeComponent();
        }

        private ObservableCollection<string> _entries;

        public ObservableCollection<string> Entries
        {
            get { return _entries; }
            set { _entries = value; }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(txtEntry.Text);
            txtEntry.Clear();
            txtEntry.Focus();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem = (string)lvEntries.SelectedItem;
            Entries.Remove(selectedItem);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Entries.Clear();
        }
    }
}
