namespace WebApplication2.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string YearOfProduction { get; set; }
        public string BodyType { get; set; }
        public double Price { get; set; }
        public double EngineVolume { get; set; }
        public bool CustomsClear { get; set; }
        public string Comment { get; set; }
    }
}
