using System.Collections.ObjectModel;
using System.Windows;

namespace WPFObservableCollections
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            entries = new ObservableCollection<string>();
            InitializeComponent();
        }

        private ObservableCollection<string> entries;

        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
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
