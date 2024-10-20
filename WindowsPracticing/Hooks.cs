using core;
//using core.Providers;
using Reqnroll;
using Reqnroll.BoDi;
using WindowsPracticing.Providers;

namespace WindowsPracticing
{
    [Binding]
    public sealed class Hooks
    {
        IObjectContainer container;

        Hooks(IObjectContainer container)
        {
            this.container = container;
        }
        [BeforeScenario]
        public void CreateDriver()
        {
            DriverSettings.Driver = BrowserFactory.GetBrowserInstance(ConfigurationProviders.browserConfiguration);

        }
        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://go.reqnroll.net/doc-hooks#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverSettings.Driver.Quit();
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}