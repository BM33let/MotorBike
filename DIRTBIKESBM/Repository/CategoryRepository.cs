using DIRTBIKESBM.Data;
using DIRTBIKESBM.Interfaces;
using DIRTBIKESBM.Models;
namespace DIRTBIKESBM.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context;
        public CategoryRepository(DataContext context)
        {
            _context = context;

        }
        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(e = c => e.Id == id).FirstOrDefault();
        }

        public ICollection<Motor> GetMotorByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
