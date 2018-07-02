using HealtyLifeApp.DataProvider;
using HealtyLifeApp.DataProvider.Enums;
using HealtyLifeApp.DataProvider.POCOs.FoodClassifier;
using HealtyLifeApp.DataProvider.Repositories;
using HealtyLifeApp.DataProvider.Repositories.Interfaces;
using HealtyLifeApp.FoodClassifier.DataProvider;
using HealtyLifeApp.Models.FoodClassifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealtyLifeApp.Code
{
    public class ParseTestData
    {
        private IAdditiveRepository additiveRepository;

        public ParseTestData()
        {
            this.additiveRepository = new AdditiveRepository(new HealthyLifeAppContext());
        }

        public List<DataFeature> ParseInputDataToTestData(FoodAdditives model)
        {
            var testDataFeatures = new List<DataFeature>();

            var color = new DataFeature
            {
                Name = nameof(FoodClassificationByAdditives.ColoringAdditiveValue),
                Value = (int?)(additiveRepository.GetAdditiveByCode(model.Color)?.Value
                ?? ClassificationValue.Good)
            };
            testDataFeatures.Add(color);

            var acidRegulator = new DataFeature
            {
                Name = nameof(FoodClassificationByAdditives.AcidRegulatorValue),
                Value = (int?)(additiveRepository.GetAdditiveByCode(model.AcidRegulator)?.Value
                ?? ClassificationValue.Good)
            };
            testDataFeatures.Add(acidRegulator);

            var antioxidant = new DataFeature
            {
                Name = nameof(FoodClassificationByAdditives.AntioxidantValue),
                Value = (int?)(additiveRepository.GetAdditiveByCode(model.Antioxidant)?.Value
                ?? ClassificationValue.Good)
            };
            testDataFeatures.Add(antioxidant);

            var emulsifer = new DataFeature
            {
                Name = nameof(FoodClassificationByAdditives.EmulsiferValue),
                Value = (int?)(additiveRepository.GetAdditiveByCode(model.Emulsifer)?.Value
                ?? ClassificationValue.Good)
            };
            testDataFeatures.Add(emulsifer);

            var improvingAgent = new DataFeature
            {
                Name = nameof(FoodClassificationByAdditives.ImprovingAgentValue),
                Value = (int?)(additiveRepository.GetAdditiveByCode(model.ImprovingAgent)?.Value
                ?? ClassificationValue.Good)
            };
            testDataFeatures.Add(improvingAgent);

            var preservatives = new DataFeature
            {
                Name = nameof(FoodClassificationByAdditives.PreservativeValue),
                Value = (int?)(additiveRepository.GetAdditiveByCode(model.Preservative)?.Value
                ?? ClassificationValue.Good)
            };
            testDataFeatures.Add(preservatives);

            return testDataFeatures;
        }
    }
}