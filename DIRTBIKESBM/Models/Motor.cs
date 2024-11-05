namespace DIRTBIKESBM.Models
{
    public class Motor
    {
        internal string? Name;
        public int Id { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public int Kilometers { get; set; }
        public string? EngineSpecifications { get; set; }
        public string? ImageUrl { get; set; }
    }
}