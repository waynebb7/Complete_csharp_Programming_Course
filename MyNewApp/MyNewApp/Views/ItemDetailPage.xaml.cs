using MyNewApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyNewApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}