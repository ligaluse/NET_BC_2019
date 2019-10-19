using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebShop.Logic.Tests
{
    [TestClass]
    public class UnitTestCategory
    {
        [TestMethod]
        public void Test_GetAll ()
        {
            CategoryManager manager = new CategoryManager();
            manager.Seed();
            var result = manager.GetAll();

            //sagaidītā vērtība un reālā vērtība, lai tests būtu veiksmīgs
            Assert.AreEqual("Phones", result[0].Title);
            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void Test_Get()
        {
            CategoryManager manager = new CategoryManager();
            manager.Seed();
            Category category1 = manager.Get(1);
            Category category2 = manager.Get(2);
            Category category3 = manager.Get(3);

            Assert.AreEqual("Phones", category1.Title);
            Assert.AreEqual("TV", category2.Title);
            Assert.IsNull(category3);
        }
    }
}
