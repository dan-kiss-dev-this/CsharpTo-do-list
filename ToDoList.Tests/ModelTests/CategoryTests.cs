using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
    [TestClass]
    public class CategoryTests : IDisposable
    {
        public void Dispose()
        {
            Category.ClearAll();
        }
        [TestMethod]
        public void CategoryClass_MakeCategory_Category()
        {
            string name = "Test Cateogry";
            Category newCategory = new Category(name);
            Assert.AreEqual(newCategory.GetType(), typeof(Category));
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "Test Category";
            Category newCategory = new Category(name);
            Assert.AreEqual(newCategory.Name, name);
        }

        [TestMethod]
        public void GetId_ReturnIds_Int()
        {
            int testId = 2;
            string name = "Test Category";
            string name2 = "Test Category2";
            Category newCategory = new Category(name);
            Category newCategory2 = new Category(name2);
            Assert.AreEqual(newCategory2.Id, testId);
        }

        [TestMethod]
        public void GetAll_GetAllCategories_ListOfCategory()
        {
            string name = "Test Category";
            string name2 = "Test Category2";
            Category newCategory = new Category(name);
            Category newCategory2 = new Category(name2);
            List<Category> expectedCategory = new List<Category> { newCategory, newCategory2 };
            List<Category> allCategories = Category.GetAll();
            CollectionAssert.AreEqual(allCategories, expectedCategory);
        }

        [TestMethod]
        public void Find_GetCategoryById_Category()
        {
            string name = "Test Category";
            string name2 = "Test Category2";
            Category newCategory = new Category(name);
            Category newCategory2 = new Category(name2);
            Assert.AreEqual(Category.Find(2), newCategory2);
        }


    }
}