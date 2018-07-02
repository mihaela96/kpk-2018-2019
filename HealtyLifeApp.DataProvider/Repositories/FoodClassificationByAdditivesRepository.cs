using HealtyLifeApp.DataProvider.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealtyLifeApp.DataProvider.POCOs.FoodClassifier;

namespace HealtyLifeApp.DataProvider.Repositories
{
    public class FoodClassificationByAdditivesRepository : IFoodClassificationByAdditivesRepository, IDisposable
    {
        private HealthyLifeAppContext context;

        public FoodClassificationByAdditivesRepository(HealthyLifeAppContext context)
        {
            this.context = context;
        }

        public ICollection<FoodClassificationByAdditives> GetAllFoodClassifications()
        {
            return context.FoodsClassificationByAdditives?.ToList();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
