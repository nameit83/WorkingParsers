using System;
using System.Collections.Generic;
using System.Text;

namespace Chef
{
    public class Ingredients
    {
        public object name { get; set; }
    }

    public class FridgeList
    {
        public int id { get; set; }
        public Ingredients ingredients { get; set; }
        public string name { get; set; }
        public string img_url { get; set; }
        public string author { get; set; }
        public string prepare_time { get; set; }
        public string cook_time { get; set; }
        public string total_time { get; set; }
        public string directions { get; set; }
        public string ingredients_list { get; set; }
    }

    public class FridgeListCol
    {
        private List<FridgeList> fridge; 
        public List<FridgeList> Fridge { get; set; }
    }
}
