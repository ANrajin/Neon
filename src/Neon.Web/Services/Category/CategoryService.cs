using Neon.Web.Data;
using Neon.Web.Entities;

namespace Neon.Web.Services.Category
{
    public class CategoryService : Service, ICategoryService
    {
        public CategoryService(ApplicationDbContext context)
            : base(context)
        {
        }

        public void CreateCategory(Category entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();
        }

        public Category GetById(int id)
        {
            var entity = _context.Categories.Find(id);
            return entity;
        }

        public List<Category> GetCategoryList()
        {
            var cat = _context.Categories.ToList();
            return cat;
        }

        public void Remove(int id)
        {
            var entity = _context.Categories.Find(id);
            _context.Categories.Remove(entity);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category entity)
        {
            _context.Categories.Update(entity);
            _context.SaveChanges();
        }
    }
}
