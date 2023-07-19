using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Category
    {
        public static List<Category> _instances = new List<Category> { };
        public string Name { get; set; }
        public int Id { get; }
        public List<Item> Items;
        public Category(string name)
        {
            Name = name;
            _instances.Add(this);
            Id = _instances.Count;
            Items = new List<Item> { };
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Category> GetAll()
        {
            return _instances;
        }

        public static Category Find(int id)
        {
            return _instances[id - 1];
        }
    }
}