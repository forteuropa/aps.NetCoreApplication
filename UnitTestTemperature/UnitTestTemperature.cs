using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemperatureApp.Models;


namespace UnitTestTemperature
{
    [TestClass]
    public class UnitTestTemperature
    {
        [TestMethod]
        public void TestConvertion()
        {
            double [] temperatureCelcius = { 22, 23,};
            double temperatureFahrenheitActual;
            double [] temperatureFahrenheitExpected = { 71.6, 73.4, };

            for(int i = 0; i < 2; ++i)
            {
                temperatureFahrenheitActual = Temperature.CelciusToFahrenheit(temperatureCelcius[i]);
                Assert.AreEqual(temperatureFahrenheitExpected[i], temperatureFahrenheitActual, 0.001, "Tempererature conversion is incorect");
            }

          //  temperatureFahrenheitActual = Temperature.CelciusToFahrenheit(temperatureCelcius);
          //  Assert.AreEqual(temperatureFahrenheitExpected, temperatureFahrenheitActual, 0.001, "Tempererature conversion is incorect");
        }
    }
}