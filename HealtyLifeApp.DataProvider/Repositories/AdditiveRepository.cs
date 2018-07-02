using HealtyLifeApp.DataProvider.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealtyLifeApp.DataProvider.POCOs.FoodClassifier;

namespace HealtyLifeApp.DataProvider.Repositories
{
    public class AdditiveRepository : IAdditiveRepository, IDisposable
    {
        private HealthyLifeAppContext context;

        public AdditiveRepository(HealthyLifeAppContext context)
        {
            this.context = context;
        }

        public ICollection<Additive> GetAllAdditive()
        {
            return context.Additives?.ToList();
        }


        public Additive GetAdditiveByCode(string code)
        {
            var result = context.Additives.Where(x => x.Code == code)?.FirstOrDefault();
            return result;
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
