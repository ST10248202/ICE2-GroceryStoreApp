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

    public partial class Menu : Form
    {
        private Inventory inventory;
    
        public Menu(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemMenu displayAddform = new AddItemMenu(inventory);
            displayAddform.ShowDialog();
        }

        private void Displaybtn_Click(object sender, EventArgs e)
        {
                DisplayMenu displayForm = new DisplayMenu(inventory);
            displayForm.ShowDialog();
        }

        private void RemoveItemMenubtn_Click(object sender, EventArgs e)
        {
            RemoveItemMenu displayRemoveform = new RemoveItemMenu();
            displayRemoveform.ShowDialog();
        }

        private void ExitAppbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
