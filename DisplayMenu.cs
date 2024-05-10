using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroceryStoreApp
{
    public partial class DisplayMenu : Form
    {
        private Inventory inventory;

        public DisplayMenu(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayFruitsbtn_Click(object sender, EventArgs e)
        {
            // Retrieve and display items for the Fruits category
            List<InventoryItem> fruits = inventory.GetItemsByCategory(ItemCategories.Fruits);
            DisplayItems(fruits);
        }

        private void DisplayVegbtn_Click(object sender, EventArgs e)
        {
            List<InventoryItem> vegetables = inventory.GetItemsByCategory(ItemCategories.Vegetables);
            DisplayItems(vegetables);
        }

        private void DisplayDairybtn_Click(object sender, EventArgs e)
        {
            List<InventoryItem> dairy = inventory.GetItemsByCategory(ItemCategories.DairyProducts);
            DisplayItems(dairy);
        }

        private void DisplayMeatbtn_Click(object sender, EventArgs e)
        {
            List<InventoryItem> meat = inventory.GetItemsByCategory(ItemCategories.MeatProducts);
            DisplayItems(meat);
        }

        private void DisplayBakerybtn_Click(object sender, EventArgs e)
        {
            List<InventoryItem> bakery = inventory.GetItemsByCategory(ItemCategories.BakeryProducts);
            DisplayItems(bakery);
        }

        // Method to display items in the text box
        private void DisplayItems(List<InventoryItem> items)
        {
            // Clear the existing content
            DisplayInfoTextBox.Text = "";

            // Append each item to the text box
            foreach (InventoryItem item in items)
            {
                //DisplayInfoTextBox.AppendText($"Name: {item.Name}\n" +
                //                   $"Category: {item.Category}\n" +
                //                   $"Price: R{item.Price}\n" +
                //                   $"Quantity: {item.Quantity}\n\n");
                DisplayInfoTextBox.AppendText($"Name: {item.Name}{Environment.NewLine}" +
                                  $"Category: {item.Category}{Environment.NewLine}" +
                                  $"Price: R{item.Price}{Environment.NewLine}" +
                                  $"Quantity: {item.Quantity}{Environment.NewLine}{Environment.NewLine}");
            }


        }
    }
}
