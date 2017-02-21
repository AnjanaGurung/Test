using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCSBackOffice
{
    public partial class AddIngredient : Form
    {
        public AddIngredient()
        {
            InitializeComponent();
        }

        private void btnBackMainMenu5_Click(object sender, EventArgs e)
        {
            //redirect to the the main menu 
            IngredientMenu redirect = new IngredientMenu();
            redirect.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect to the the main menu 
            IngredientMenu redirect = new IngredientMenu();
            redirect.Show();
            this.Hide();
        }
    }
}
