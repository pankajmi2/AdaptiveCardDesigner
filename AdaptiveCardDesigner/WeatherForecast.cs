namespace AdaptiveCardDesigner
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class CardDetails
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
