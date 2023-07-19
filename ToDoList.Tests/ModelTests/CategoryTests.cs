using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void CategoryClass_MakeCategory_Category()
        {
            Category testCategory = new Category();
            Assert.AreEqual(testCategory.GetType(), typeof(Category));
        }
    }
}