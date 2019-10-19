using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class CategoryManager
    {
        public List<Category> categories;
        public CategoryManager()
        {
            categories = new List<Category>();
        }
        public List<Category> GetAll()
        {
            return categories;
        }
        public Category Get(int id)
        {
            var category = categories.Find(u => u.Id == id);
            return category;
        }
        public void Seed()
        {
            categories.Add(new Category()
            {
                Id = 1,
                Title = "Phones"
            });
            categories.Add(new Category()
            {
                Id = 2,
                Title = "TV"
            });
        }
    }
}
