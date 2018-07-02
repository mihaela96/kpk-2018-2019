using HealtyLifeApp.DataProvider.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyLifeApp.DataProvider.POCOs.FoodClassifier
{
    public class FoodClassificationByAdditives
    {
        public int Id { get; set; }

        public ClassificationValue? ColoringAdditiveValue { get; set; }

        public ClassificationValue? PreservativeValue { get; set; }

        public ClassificationValue? AntioxidantValue { get; set; }

        public ClassificationValue? AcidRegulatorValue { get; set; }

        public ClassificationValue? EmulsiferValue { get; set; }

        public ClassificationValue? ImprovingAgentValue { get; set; }

        public ClassificationValue? FoodValue { get; set; }

    }
}
