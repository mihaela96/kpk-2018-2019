using HealtyLifeApp.DataProvider;
using HealtyLifeApp.DataProvider.Repositories;
using HealtyLifeApp.DataProvider.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyLifeApp.FoodClassifier.DataProvider
{
    public class DataProvider : IDataProvider
    {
        private IFoodClassificationByAdditivesRepository foodRepository;

        public DataProvider()
        {
            this.foodRepository = new FoodClassificationByAdditivesRepository(new HealthyLifeAppContext());
        }

        public ICollection<DataModel> GetTrainingData()
        {
            ICollection<DataModel> trainingData = null;

            //using (HealthyLifeAppContext context = new HealthyLifeAppContext())
            //{
                trainingData = foodRepository.GetAllFoodClassifications()
                    ?.AsEnumerable()
                    ?.Select(x =>
                    {
                        var currentClassificationFeatures = new List<DataFeature>()
                        {
                            new DataFeature { Name = nameof(x.AcidRegulatorValue), Value = (int?)x?.AcidRegulatorValue },
                            new DataFeature { Name = nameof(x.ColoringAdditiveValue), Value = (int?)x?.ColoringAdditiveValue },
                            new DataFeature { Name = nameof(x.AntioxidantValue), Value = (int?)x?.AntioxidantValue },
                            new DataFeature { Name = nameof(x.EmulsiferValue), Value = (int?)x?.EmulsiferValue },
                            new DataFeature { Name = nameof(x.PreservativeValue), Value = (int?)x?.PreservativeValue },
                            new DataFeature { Name = nameof(x.ImprovingAgentValue), Value = (int?)x?.ImprovingAgentValue }

                        };
                        
                        var currentClassificationLabel = x.FoodValue?.ToString();

                        return new DataModel
                        {
                            Label = currentClassificationLabel,
                            Features = currentClassificationFeatures
                        };

                    })
                    ?.ToList();
            //}
            return trainingData;
        }
    }
}
