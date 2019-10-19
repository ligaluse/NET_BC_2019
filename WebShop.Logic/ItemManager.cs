using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
   public class ItemManager
    {
        
        public int itemId = 1;
        public List<Item> Items;
        public List<Item> GetAll()
        {
            return Items;
        }
        public ItemManager()
        {
            Items = new List<Item>();
        }
        public List<Item> GetByCategory(int categoryId)
        {
            var categoryById = Items.FindAll(u => u.CategoryId == categoryId);
            return categoryById;
        }
        public Item Create(Item item)
        {
            item.Id = itemId;
            Items.Add(item);
            itemId++;
            return item;
        }
        public void Update(Item item)
        {
            var currentItem = Items.Find(u => u.Id == item.Id);
            //properties to update
            currentItem.Id = item.Id;
            currentItem.Price = item.Price;
            currentItem.Description = item.Description;
            currentItem.Title = item.Title;
            currentItem.Photo = item.Photo;
            currentItem.CategoryId = item.CategoryId;    
        }
        public void Delete(int id)
        {
            var item = Items.Find(u => u.Id == id);
            Items.Remove(item);
        }
        public Item Get(int id)
        {
            var item = Items.Find(u => u.Id == id);
            return item;
        }
        public void Seed()
        {
            Items.Add(new Item()
            {
                Id = 1,
                Title = "Samsung phone",
                CategoryId = 1
            });
            Items.Add(new Item()
            {
                Id = 2,
                Title = "Nokia tv",
                CategoryId = 1
            });
        }
    }
}
