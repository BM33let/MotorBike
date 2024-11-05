using DIRTBIKESBM.Models;

namespace DIRTBIKESBM.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Motor> GetMotorByCategory(int categoryId);
        bool CategoryExists(int id);
     }
}
