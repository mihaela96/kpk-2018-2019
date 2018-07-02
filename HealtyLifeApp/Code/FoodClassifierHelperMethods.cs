using HealtyLifeApp.DataProvider;
using HealtyLifeApp.DataProvider.Enums;
using HealtyLifeApp.DataProvider.POCOs.FoodClassifier;
using HealtyLifeApp.FoodClassifier.DataProvider;
using HealtyLifeApp.Models.FoodClassifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HealtyLifeApp.Code
{
    public static class FoodClassifierHelperMethods
    {
        private const string RESULT_BY_CLASSIFICATION_TEXT = "Your food is classified as";

        public static List<DataFeature> MakeTestDataFromUserInput(FoodAdditives model)
        {
            var inputData = new ParseTestData();
            var resultData = inputData.ParseInputDataToTestData(model);
            return resultData;
        }

        public static string Classify(List<DataFeature> testFoodFeatures)
        {
            var foodClassifierData = new FoodClassifier.DataProvider.DataProvider();
            var foodClassifier = new FoodClassifier.Classifier();

            var teachData = foodClassifierData.GetTrainingData()?.ToList();

            foodClassifier.Teach(teachData);

            var resultByClassification = new StringBuilder();
            resultByClassification.Clear();

            if (foodClassifier != null)
            {
                var results = foodClassifier.Classify(testFoodFeatures);
                var bestResult = results.OrderByDescending(x => x.Value).FirstOrDefault();

                resultByClassification.AppendLine($"{RESULT_BY_CLASSIFICATION_TEXT} {bestResult.Key}!");
            }

            return resultByClassification.ToString();

        }
    }
}