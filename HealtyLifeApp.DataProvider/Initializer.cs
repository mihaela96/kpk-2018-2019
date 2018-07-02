using HealtyLifeApp.DataProvider.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyLifeApp.DataProvider
{
    public class Initializer : MigrateDatabaseToLatestVersion<HealthyLifeAppContext, Configuration>
    {
    }
}
