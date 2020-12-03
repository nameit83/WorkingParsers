using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using Newtonsoft.Json;


namespace Chef
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MealDBSearch : ContentPage
    {
        public MealDBSearch()
        {
            InitializeComponent();
        }
        async void ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView lv = (ListView)sender;

            // this assumes your List is bound to a List<Club>
            MealDBObj selectedMeal = (MealDBObj)lv.SelectedItem;
            Console.WriteLine(selectedMeal);

            // assuiming Club has an Id property
            //await Navigation.PushAsync(new DetailedClub(club.Id));
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Button Pressed");
            Console.WriteLine(sakchham.Text.ToLower());
            string APIBase = "http://www.themealdb.com/api/json/v1/1/search.php?s=";
            string APIlink = APIBase + sakchham.Text.ToLower();
            JsonDeserialize(APIlink);
        }

        public void JsonSerialize(object data, string filePath)
        {

        }

        public void JsonDeserialize(string url)
        {
            WebClient client = new WebClient();

            string myJSON = client.DownloadString(url);

            MealDBObjCol mealCollection = JsonConvert.DeserializeObject<MealDBObjCol>(myJSON);
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            MealDBObj meal = JsonConvert.DeserializeObject<MealDBObj>(myJSON, settings);
            Console.WriteLine(mealCollection.Meals.Count);



            myList.ItemsSource = mealCollection.Meals;
            for (int i = 0; i < mealCollection.Meals.Count; i++)
            {
            }


        }

        private void OnItemSelected(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            MealDBObj SelectedMeal = (MealDBObj)e.Item;
            Navigation.PushAsync(new MealDBView(SelectedMeal));
        }

    }
}
