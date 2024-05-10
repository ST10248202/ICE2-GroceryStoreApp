using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreApp
{

    //enum class to easily index categories
    public enum ItemCategories
    {
        Fruits, //0
        Vegetables, //1
        DairyProducts, //2
        MeatProducts, //3
        BakeryProducts //4

    }
    public class InventoryItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public ItemCategories Category { get; set; }

        public InventoryItem(string name, double price, int quantity, ItemCategories category)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;
        }
    }
}
