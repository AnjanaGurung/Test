﻿using System;
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
    public partial class mdiBackend : Form
    {
        private int childFormNumber = 0;

        public mdiBackend()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

   
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create an object based on frmMain
            StaffLogin Staff = new StaffLogin();
            //to make the object a child of the mdi parent
            Staff.MdiParent = this;
            //to make the form visible 
            Staff.Visible = true;    
        }

        private void mdiBackend_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filterIngredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create an object based on frmMain
            FilterIngredient FilterIngredient = new FilterIngredient();
            //to make the object a child of the mdi parent
            FilterIngredient.MdiParent = this;
            //to make the form visible 
            FilterIngredient.Visible = true;  
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create an object based on frmMain
            IngredientMenu Mainmenu = new IngredientMenu();
            //to make the object a child of the mdi parent
            Mainmenu.MdiParent = this;
            //to make the form visible 
            Mainmenu.Visible = true; 
        }

        private void listIngredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create an object based on frmMain
            ListIngredient listIngredient = new ListIngredient();
            //to make the object a child of the mdi parent
            listIngredient.MdiParent = this;
            //to make the form visible 
            listIngredient.Visible = true; 
        }

        private void deleteIngredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create an object based on frmMain
           DeleteIngredient DeleteIngredient = new DeleteIngredient();
            //to make the object a child of the mdi parent
            DeleteIngredient.MdiParent = this;
            //to make the form visible 
            DeleteIngredient.Visible = true; 
        }

        private void updateIngredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create an object based on frmMain
            UpdateIngredient UpdateIngredient = new UpdateIngredient();
            //to make the object a child of the mdi parent
            UpdateIngredient.MdiParent = this;
            //to make the form visible 
            UpdateIngredient.Visible = true;
        }

        private void addIngredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create an object based on frmMain
            AddIngredient AddIngredient = new AddIngredient();
            //to make the object a child of the mdi parent
            AddIngredient.MdiParent = this;
            //to make the form visible 
            AddIngredient.Visible = true; 
        }
    }

}

