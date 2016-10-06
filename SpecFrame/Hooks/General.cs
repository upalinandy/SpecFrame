using SpecFrame.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFrame.Hooks
{
    [Binding]
    public sealed class General
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("Before Scenario");
        }

        [AfterScenario("scenario_outline", "excelsheet")]
        public static void TearDown()
        {
            Console.WriteLine("After Scenario");

            if (ObjectRepo.driver != null)
            {
                ObjectRepo.driver.Close();
                ObjectRepo.driver.Quit();
            }

        }
    }
}
