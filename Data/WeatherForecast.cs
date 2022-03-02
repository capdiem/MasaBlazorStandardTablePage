namespace MasaBlazorStandardTablePage.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public WarningSigns? WarningSigns
        {
            get
            {
                return TemperatureC switch
                {
                    >= 39 => Data.WarningSigns.Red,
                    >= 37 => Data.WarningSigns.Orange,
                    >= 35 => Data.WarningSigns.Yellow,
                    _ => null
                };
            }
        }
    }
}