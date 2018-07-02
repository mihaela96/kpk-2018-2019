using HealtyLifeApp.DataProvider.POCOs.FoodClassifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyLifeApp.DataProvider.Repositories.Interfaces
{
    public  interface IAdditiveRepository : IDisposable
    {
        ICollection<Additive> GetAllAdditive();

        Additive GetAdditiveByCode(string Code);

    }
}
