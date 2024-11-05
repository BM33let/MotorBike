using DIRTBIKESBM.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIRTBIKESBM.Models
{
    public class DirtBike
    {
        [Key]
        public int Id { get; set; }

        public int MotorsId { get; set; }
        public int UserId { get; set; }
        public string? Model { get; set; }
        public decimal Price { get; set; }
        public int Kilometers { get; set; }
        public string? EngineSpecifications { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }

        [ForeignKey("MotorsId")]
        public Motors? Motors { get; set; }
    }
}
