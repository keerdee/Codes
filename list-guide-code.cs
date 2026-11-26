using System;
using System.Collections.Generic;

namespace Task
{
    public class Item
    {
        public string Name;
        public int Value;

        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }   
        
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> item = new List<Item>();
            item.Add(new Item("Монетка", 1));
            item.Add(new Item("Кубик", 100));
            item.Add(new Item("Чертеж", 333));
            
            foreach (Item currentItem in item)
            {
                Console.WriteLine("Предмет: " + currentItem.Name + ", Цена: " + currentItem.Value);
            }
        }
    }
}