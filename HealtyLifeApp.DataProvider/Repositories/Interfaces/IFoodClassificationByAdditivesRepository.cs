using HealtyLifeApp.DataProvider.POCOs.FoodClassifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyLifeApp.DataProvider.Repositories.Interfaces
{
    public interface IFoodClassificationByAdditivesRepository : IDisposable
    {
        ICollection<FoodClassificationByAdditives> GetAllFoodClassifications();
    }
}
