using HealtyLifeApp.DataProvider.Mappings;
using HealtyLifeApp.DataProvider.POCOs.FoodClassifier;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyLifeApp.DataProvider
{
    public class HealthyLifeAppContext : DbContext
    {
        public HealthyLifeAppContext() : base("name=HealthyLifeAppContext")
        {
        }

        public System.Data.Entity.DbSet<Additive> Additives { get; set; }

        public System.Data.Entity.DbSet<FoodClassificationByAdditives> FoodsClassificationByAdditives { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdditiveMapping());
            modelBuilder.Configurations.Add(new FoodClassificationByAdditivesMapping());
        }
    }
}
