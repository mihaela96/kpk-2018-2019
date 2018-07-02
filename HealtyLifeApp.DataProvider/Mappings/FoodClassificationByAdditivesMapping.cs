using HealtyLifeApp.DataProvider.POCOs.FoodClassifier;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyLifeApp.DataProvider.Mappings
{
    public class FoodClassificationByAdditivesMapping : EntityTypeConfiguration<FoodClassificationByAdditives>
    {
        public FoodClassificationByAdditivesMapping()
        {
            this.ToTable("FoodClassification");
            this.HasKey(f => f.Id);

            this.Property(f => f.ImprovingAgentValue).IsOptional();
            this.Property(f => f.PreservativeValue).IsOptional();
            this.Property(f => f.FoodValue).IsOptional();
            this.Property(f => f.AcidRegulatorValue).IsOptional();
            this.Property(f => f.ColoringAdditiveValue).IsOptional();
            this.Property(f => f.AntioxidantValue).IsOptional();
            this.Property(f => f.EmulsiferValue).IsOptional();
        }
             
    }
}
