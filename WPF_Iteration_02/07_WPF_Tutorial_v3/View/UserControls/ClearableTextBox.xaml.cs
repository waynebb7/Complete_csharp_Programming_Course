using System.Windows;
using System.Windows.Controls;

namespace _07_WPF_Tutorial_v3.View.UserControls
{
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string _placeholder;

        public string Placeholder
        {
            get { return _placeholder; }
            set
            {
                _placeholder = value;
                tbPlaceholder.Text = _placeholder;  // Not the recommended method. This needs to be changed.
            }
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput.Text))
            {
                tbPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }
    }
}
