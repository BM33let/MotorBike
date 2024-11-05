using DIRTBIKESBM.Data;
using DIRTBIKESBM.Interfaces;
using DIRTBIKESBM.Models;

namespace DIRTBIKESBM.Repository
{
    public class MotorRepository : IMotorRepository
    {
        private readonly DataContext _context;

        public MotorRepository(DataContext context)
        {
            _context = context;
        }

        public Motor GetMotor(int id)
        {
            return _context.Motor.Where(p => p.Id == id).FirstOrDefault();
        }

        public Motor GetMotor(string name)
        {
           return _context.Motor.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetMotorRating(int motoId)
        {
            var review = _context.Reviews.Where(p => p.MotorId == motoId);

            if (review.Count() > 0)
                return 0;

            return ((decimal)review.Sum(r => r.Rating) / review.Count());
        }
        public ICollection<Motor> GetMotors()
        {
            return _context.Motor.OrderBy(p => p.Id).ToList();
        }

        public bool MotorExists(int motoId)
        {
            return _context.Motor.Any(p => p.Id == motoId);
        }
    }
}
