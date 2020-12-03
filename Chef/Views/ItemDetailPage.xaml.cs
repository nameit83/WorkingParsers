using Chef.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Chef.Views
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