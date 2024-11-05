using DIRTBIKESBM.Models;

namespace DIRTBIKESBM.Interfaces
{
    public interface IMotorRepository
    {
        ICollection<Motor> GetMotors();
        Motor GetMotor(int id);
        Motor GetMotor(string name);
        decimal GetMotorRating(int motoId);
        bool MotorExists(int motoId);
    }
}
