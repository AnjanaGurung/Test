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
    public partial class IngredientMenu : Form
    {
        public IngredientMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            //redirect to the the main menu 
            DeleteIngredient redirect = new DeleteIngredient();
            redirect.Show();
            this.Hide(); 
        }

        private void btn_ListIngredient_Click(object sender, EventArgs e)
        {
            //redirect to the the main menu 
            ListIngredient redirect = new ListIngredient(); 
            redirect.Show();
            this.Hide();
        }

        private void btnUpdateIngredient_Click(object sender, EventArgs e)
        {
            //redirect to the the main menu 
            UpdateIngredient redirect = new UpdateIngredient();
            redirect.Show();
            this.Hide();
        }

        private void btnFilterIngredient_Click(object sender, EventArgs e)
        {
            //redirect to the the main menu 
            FilterIngredient redirect = new FilterIngredient();
            redirect.Show();
            this.Hide();
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            //redirect to the the main menu 
            AddIngredient redirect = new AddIngredient(); 
            redirect.Show();
            this.Hide();
        }

        private void lstIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
