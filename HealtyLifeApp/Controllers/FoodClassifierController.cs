using HealtyLifeApp.Code;
using HealtyLifeApp.Models.FoodClassifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HealtyLifeApp.Controllers
{
    public class FoodClassifierController : Controller
    {
        // GET: FoodClassifier
        [HttpGet]
        public ActionResult Index()
        {
            FoodAdditives foodAdditives = new FoodAdditives();
            return View(foodAdditives);
        }

        [HttpGet]
        public ActionResult Result()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FoodAdditives model)
        {
            var parsedInputData = FoodClassifierHelperMethods.MakeTestDataFromUserInput(model);
            var resultByClassification = FoodClassifierHelperMethods.Classify(parsedInputData);

            //return Content(resultByClassification);
            return View("Result", new ResultByClassification
            {
                Message = resultByClassification
            });
        }

    }
}