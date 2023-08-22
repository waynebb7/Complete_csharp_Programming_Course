using System.Windows;
using System.Windows.Controls;

namespace _06_WPF_Tutorial_v6.View.UserControls
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
                tbPlaceholder.Text = _placeholder;
            }
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtinput.Clear();
            txtinput.Focus();
        }

        private void txtinput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtinput.Text))
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
