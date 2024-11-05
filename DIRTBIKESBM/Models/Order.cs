using static DIRTBIKESBM.Models.Motor;

namespace DIRTBIKESBM.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int MotorsId { get; set; }
        public int MotorId { get; set; }
        public int DirtBikeId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int UserId { get; set; }

        public User? User { get; set; }
        public DirtBike? DirtBike { get; set; }
    }
}