using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class AddItemMenu : Form
    {
        //Initialized variables for storing input from text boxes
        private string nameInput;
        private double priceInput;
        private int quantityInput;
        private string categoryInput;

        private Inventory inventory;
        public AddItemMenu(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryInput = CategoryComboBox.SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //button to proccess methods to add all entered info
        private void AddItembtn_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(categoryInput))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            inventory.ProcessInput(nameInput, priceInput, quantityInput, categoryInput);
            MessageBox.Show("Item added successfully.");

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameInput = nameTextBox.Text;
            
        }
        //attempt at input access method
        public string GetNameInput()
        {
            return nameInput;
        }

        public string GetCategoryInput()
        {
            return categoryInput;
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            priceInput = double.Parse(priceTextBox.Text);
        }

        public double GetPriceInput()
        {
            return priceInput;
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            quantityInput = int.Parse(quantityTextBox.Text);

        }

        public double GetQuantityInput()
        {
            return quantityInput;
        }

    }
}
