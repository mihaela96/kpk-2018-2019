using HealtyLifeApp.DataProvider.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyLifeApp.DataProvider.POCOs.FoodClassifier
{
    public class Additive
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Code { get; set; }

        public ClassificationValue? Value { get; set; }
    }
}
