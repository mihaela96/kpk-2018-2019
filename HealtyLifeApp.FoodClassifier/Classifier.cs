using HealtyLifeApp.FoodClassifier.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyLifeApp.FoodClassifier
{
    // This class use Naive Bayes algorithm to classify data
    public class Classifier
    {
        private readonly Dictionary<string, List<DataFeature>> categoryFeather;
        private List<DataModel> trainigData;

        public Classifier()
        {
            this.categoryFeather = new Dictionary<string, List<DataFeature>>();
            this.trainigData = new List<DataModel>();
        }

        public void Teach(List<DataModel> trainigDataSets)
        {
            this.trainigData = trainigDataSets;

            foreach (var model in trainigDataSets)
            {
                if (!categoryFeather.ContainsKey(model.Label))
                {
                    categoryFeather.Add(model.Label, model.Features);
                }
                else
                {
                    categoryFeather[model.Label].AddRange(model.Features);
                }
            }
        }

        private double CalculateProbablity(string label, IEnumerable<DataFeature> featuresOfObject)
        {
            double countOfGivenLabel = this.trainigData.Count(x => x.Label == label);
            double allDataCount = Convert.ToDouble(trainigData.Count);

            double labelProbablity = countOfGivenLabel / allDataCount;

            List<double> featuresProbablity = new List<double>();

            foreach (var feature in featuresOfObject)
            {
                foreach (var property in feature.GetType().GetProperties())
                {
                    int featuresOccurency = this.categoryFeather[label]
                        ?.FindAll(prop => (prop.Name == feature.Name && prop.Value == feature.Value))
                        ?.Count ?? 0;
                    double posteriorProbablity = featuresOccurency / Convert.ToDouble(countOfGivenLabel);

                    if (!posteriorProbablity.Equals(0))
                    {
                        featuresProbablity.Add(posteriorProbablity);
                    }
                }
            }

            double result = featuresProbablity.Aggregate(1.0, (current, item) => current * item) * labelProbablity;

            return result;
        }

        public Dictionary<string, double> Classify(List<DataFeature> features)
        {
            if (features.Count <= 0)
            {
                throw new ArgumentException("Missing any feature");
            }

            if (categoryFeather.Count <= 0)
            {
                throw new ArgumentException("Classifier has not been trained");
            }

            return categoryFeather.ToDictionary(item => item.Key, item => CalculateProbablity(item.Key, features));

        }
    }
}
