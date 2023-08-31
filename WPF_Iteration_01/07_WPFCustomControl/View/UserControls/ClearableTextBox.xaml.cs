using System.Windows;
using System.Windows.Controls;

namespace WPFCustomControl.View.UserControls
{
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set
            {
                placeholder = value;
                // Do not do this!!
                tbPlaceholder.Text = placeholder;
                // Use OnPropertyChanged()
            }
        }


        private void btnClear_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))

                tbPlaceholder.Visibility = System.Windows.Visibility.Visible;
            else
                tbPlaceholder.Visibility = System.Windows.Visibility.Hidden;

        }
    }
}
