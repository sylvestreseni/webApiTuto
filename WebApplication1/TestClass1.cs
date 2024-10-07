namespace WebApplication1
{
    public class TestClass1
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
        public string? test {  get; set; }
        public string? Summary2 { get; set; }
        public string? test2 { get; set; }
    }
}
