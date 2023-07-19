using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Category
    {
        public static List<Category> _instances = new List<Category> { };
        public string Name { get; set; }
        public int Id { get; }
        public List<Item> Items = new List<Item> { };
        // public Category
        // {

        // }
}
}