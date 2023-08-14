using _39._473.XamarinMobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace _39._473.XamarinMobileApp.Views
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