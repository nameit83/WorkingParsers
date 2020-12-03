using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chef
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FridgeListView : ContentPage
    {
        FridgeList f;
        public FridgeListView(FridgeList fridge)
        {
            f = fridge;
            InitializeComponent();
            BindingContext = f;
        }
    }
}