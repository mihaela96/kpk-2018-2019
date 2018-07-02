using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyLifeApp.FoodClassifier.DataProvider
{
    public interface IDataProvider
    {
         ICollection<DataModel> GetTrainingData();
    }
}
