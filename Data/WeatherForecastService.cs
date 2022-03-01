namespace MasaBlazorStandardTablePage.Data
{
    public class WeatherForecastService
    {
        private readonly List<WeatherForecast> _data = new()
        {
            new() { Date = DateTime.Now.AddDays(-1), TemperatureC = 23, Summary = "Freezing" },
            new() { Date = DateTime.Now.AddDays(-1), TemperatureC = -10, Summary = "Bracing" },
            new() { Date = DateTime.Now.AddDays(-1), TemperatureC = 37, Summary = "Chilly" },
            new() { Date = DateTime.Now.AddDays(-2), TemperatureC = 29, Summary = "Cool" },
            new() { Date = DateTime.Now.AddDays(-3), TemperatureC = 11, Summary = "Mild" },
            new() { Date = DateTime.Now.AddDays(-4), TemperatureC = 35, Summary = "Warm" },
            new() { Date = DateTime.Now.AddDays(-5), TemperatureC = 41, Summary = "Balmy" },
            new() { Date = DateTime.Now.AddDays(-5), TemperatureC = -13, Summary = "Hot" },
            new() { Date = DateTime.Now.AddDays(-6), TemperatureC = 23, Summary = "Sweltering" },
            new() { Date = DateTime.Now.AddDays(-7), TemperatureC = 2, Summary = "Scorching" },
        };
        
        public Task<WeatherForecast[]> GetForecastAsync(string? summary)
        {
            IEnumerable<WeatherForecast> res = _data.ToList();

            if (!string.IsNullOrEmpty(summary))
            {
                res = res.Where(item => item.Summary.Contains(summary));
            }

            return Task.FromResult(res.ToArray());
        }
    }
}