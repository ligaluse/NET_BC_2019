using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebShop.Logic.Tests
{
    [TestClass]
    public class UnitTestItem
    {
        [TestMethod]
        public void Test_GetByCategory()
        {
           ItemManager manager = new ItemManager();
            manager.Seed();
            var result = manager.GetByCategory(1);
            var result2 = manager.GetByCategory(2);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(0, result2.Count);
            //sagaidītā vērtība un reālā vērtība, lai tests būtu veiksmīgs
        }
        [TestMethod]
        public void Test_Create()
        {
            ItemManager manager = new ItemManager();
            Item item = manager.Create(new Item()
            {
                Price = 50,
                Description = "New Description",
                Title = "New title",
                Photo = "New photo",
                CategoryId = 1
            });
            Assert.AreEqual(50, item.Price);
            Assert.AreEqual("New Description", item.Description);
            Assert.AreEqual("New title", item.Title);
            Assert.AreEqual("New photo", item.Photo);
            Assert.AreEqual(1, item.CategoryId);
            Assert.IsTrue(item.Id > 0);
        }

        
        [TestMethod]
        public void Test_Update()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();
            manager.Update(new Item()
            {  
                Id = 2,
                Title = "New title"
            });
            var item = manager.Get(2);
            Assert.AreEqual(2, item.Id);
            Assert.AreEqual("New title", item.Title);
        }
        [TestMethod]
        public void Test_Delete()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();
            manager.Delete(1);

            var allItems = manager.GetAll();
            var deletedItem = manager.Get(1);

            Assert.AreEqual(1, allItems.Count);
            Assert.IsNull(deletedItem);
        }
        [TestMethod]
        public void Test_Get()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();
            Item item1 = manager.Get(1);
            Item item2 = manager.Get(2);
            Item item3 = manager.Get(3);

            Assert.AreEqual("Samsung phone", item1.Title);
            Assert.AreEqual("Nokia tv", item2.Title);
            Assert.IsNull(item3);
        }
    }
}
