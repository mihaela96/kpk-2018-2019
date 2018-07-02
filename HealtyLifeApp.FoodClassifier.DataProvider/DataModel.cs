using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyLifeApp.FoodClassifier.DataProvider
{
    public class DataModel
    {

        //category of a object, which is going to be train
        public string Label { get; set; }

        //features of a object, which is going to be train
        public List<DataFeature> Features { get; set; }
    }
}
