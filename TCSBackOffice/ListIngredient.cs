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
    public partial class ListIngredient : Form
    {
        public ListIngredient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackMainMenu_Click(object sender, EventArgs e)
        {
            //redirect to the the main menu 
            IngredientMenu redirect = new IngredientMenu();
            redirect.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //redirect to the the main menu 
            FilterIngredient redirect = new FilterIngredient();
            redirect.Show();
            this.Hide();
        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            //redirect to the the main menu 
            DeleteIngredient redirect = new DeleteIngredient();
            redirect.Show();
            this.Hide();
        }
    }
}
