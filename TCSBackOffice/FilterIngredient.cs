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
    public partial class FilterIngredient : Form
    {
        public FilterIngredient()
        {
            InitializeComponent();
        }

        private void btnBackMainMenu2_Click(object sender, EventArgs e) 
        {
            //redirect to the the main menu 
            IngredientMenu redirect = new IngredientMenu();
            redirect.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //redirect to the the main menu 
            ListIngredient redirect = new ListIngredient();
            redirect.Show();
            this.Hide();
        }
    }
}
