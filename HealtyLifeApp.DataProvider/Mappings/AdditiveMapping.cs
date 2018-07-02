using HealtyLifeApp.DataProvider.POCOs.FoodClassifier;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyLifeApp.DataProvider.Mappings
{
    public class AdditiveMapping : EntityTypeConfiguration<Additive>
    {
        public AdditiveMapping()
        {
            this.ToTable("FoodAdditive");

            this.HasKey<int>(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.Name).IsOptional().HasMaxLength(1024);
            this.Property(a => a.Code).IsOptional().HasMaxLength(100);
            this.Property(a => a.Value).IsOptional();
        }
    }
}
