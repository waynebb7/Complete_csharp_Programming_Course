using System.Windows;

namespace WPFListView
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("a");
            lvEntries.Items.Add("b");
            lvEntries.Items.Add("c");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //// Index removal version
            //int index = lvEntries.SelectedIndex;
            //lvEntries.Items.RemoveAt(index);

            // Item removal version
            object item = lvEntries.SelectedItem;
            var result = MessageBox.Show($"Are you sure you want to delete: {(string)item}?", "Sure?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                lvEntries.Items.Remove(item);
            }
            else
            {
                // Do nothing
            }




        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}
