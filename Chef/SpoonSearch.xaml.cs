using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chef
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpoonSearch : ContentPage
    {
        public SpoonSearch()
        {
            InitializeComponent();
        }

        private void onButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Button Pressed");
            string APIBase = "https://myfridgeapi.herokuapp.com/myfridge/?format=json&ingredients=";
            string APIEnd = "&search=";
            string APILink = APIBase + sakchham.Text.ToLower() + APIEnd;
            JsonDeserialize(APILink);



        }

        public void JsonDeserialize(string url) 
        {
            WebClient client = new WebClient();

            string myJSON = client.DownloadString(url);

            //create obj and obj coll classes for the incoming json

            //Console.WriteLine(myJSON);
            List<FridgeList> fridgeLists = (List<FridgeList>)JsonConvert.DeserializeObject(myJSON,typeof(List<FridgeList>));
            Console.WriteLine(fridgeLists.Count);

            myList.ItemsSource = fridgeLists;




        }
        private void OnItemSelected(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            FridgeList SelectedMeal = (FridgeList)e.Item;
            Navigation.PushAsync(new FridgeListView(SelectedMeal));
        }
    }
}