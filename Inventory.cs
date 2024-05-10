using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreApp
{
    public class Inventory
    {

        private Dictionary<ItemCategories, List<InventoryItem>> itemDictionary = new Dictionary<ItemCategories, List<InventoryItem>>();

        


        public void ProcessInput(string nameInput, double priceInput, int quantityInput, string categoryInputStr)
        {
            ItemCategories categoryInput;
            Enum.TryParse(categoryInputStr, out categoryInput);

            InventoryItem item = new InventoryItem(nameInput, priceInput, quantityInput, categoryInput);
            AddItemToCategory(item);
        }


        private void AddItemToCategory(InventoryItem item)
        {
            if (!itemDictionary.ContainsKey(item.Category))
            {
                itemDictionary[item.Category] = new List<InventoryItem>();
            }
            itemDictionary[item.Category].Add(item);
        }

        public List<InventoryItem> GetItemsByCategory(ItemCategories category)
        {
            if (itemDictionary.ContainsKey(category))
            {
                return itemDictionary[category];
            }
            else
            {
                return new List<InventoryItem>(); // Returns an empty list if the category is not found
            }
        }

    }
}
