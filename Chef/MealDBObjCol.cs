using System;
using System.Collections.Generic;
using System.Text;

namespace Chef
{
    public class MealDBObjCol
    {
        private List<MealDBObj> meals;

        public List<MealDBObj> Meals { get => meals; set => meals = value; }
    }
}
