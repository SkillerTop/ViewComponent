using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

public class WeatherController : Controller
{
    public async Task<ActionResult> Index(string city)
    {
        using (HttpClient client = new HttpClient())
        {
            string apiKey = "your_openweathermap_api_key";
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(data);
                return View(weather);
            }
            else
            {
                return View("Error");
            }
        }
    }
}
