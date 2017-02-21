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
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
        }

        private void btnIngredientMenu_Click(object sender, EventArgs e)
        {
            //redirect to the the main menu 
            IngredientMenu redirect = new IngredientMenu(); 
            redirect.Show();
            this.Hide();
        }
    }
}
