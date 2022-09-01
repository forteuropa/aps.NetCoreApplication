using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TemperatureApp.Models;


namespace TemperatureApp.Pages
{
    public class TemperatureModel : PageModel
    {
        public double TemperatureCelsius;
        public double TemperatureFahrenheit;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            TemperatureCelsius = Convert.ToDouble(Request.Form["TemperatureCelsius"]);
            TemperatureFahrenheit = Temperature.CelciusToFahrenheit(TemperatureCelsius);
        }
    }
}
