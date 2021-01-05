using System.ComponentModel;
using Xamarin.Forms;
using Colta_Iulia_Lab12.ViewModels;

namespace Colta_Iulia_Lab12.Views
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