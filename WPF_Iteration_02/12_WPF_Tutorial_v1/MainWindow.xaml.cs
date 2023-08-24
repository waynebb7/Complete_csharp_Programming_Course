using System.Collections;
using System.Windows;

namespace _12_WPF_Tutorial_v1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
            txtEntry.Focus();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            //object item = lvEntries.SelectedItem;
            var items = lvEntries.SelectedItems;

            var result = MessageBox.Show($"Are you sure you want to delete {items.Count} items?", "Sure", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var itemsList = new ArrayList(items);
                foreach (var item in itemsList)
                {
                    lvEntries.Items.Remove(item);
                }
            }
            else
            {

            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}
