using static DIRTBIKESBM.Models.Motor;

namespace DIRTBIKESBM.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int MotorId { get; set; }
        public int ReviewerId { get; set; }
        public string? Comment { get; set; }
        public int Rating { get; set; }
    }
}