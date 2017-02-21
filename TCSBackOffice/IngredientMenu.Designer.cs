namespace TCSBackOffice
{
    partial class IngredientMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ListIngredient = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnUpdateIngredient = new System.Windows.Forms.Button();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnFilterIngredient = new System.Windows.Forms.Button();
            this.lstIngredient = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ListIngredient
            // 
            this.btn_ListIngredient.Location = new System.Drawing.Point(45, 260);
            this.btn_ListIngredient.Name = "btn_ListIngredient";
            this.btn_ListIngredient.Size = new System.Drawing.Size(191, 28);
            this.btn_ListIngredient.TabIndex = 0;
            this.btn_ListIngredient.Text = "Display All Ingredient";
            this.btn_ListIngredient.UseVisualStyleBackColor = true;
            this.btn_ListIngredient.Click += new System.EventHandler(this.btn_ListIngredient_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(45, 303);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(80, 28);
            this.btnAddIngredient.TabIndex = 1;
            this.btnAddIngredient.Text = "Add ";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnUpdateIngredient
            // 
            this.btnUpdateIngredient.Location = new System.Drawing.Point(156, 304);
            this.btnUpdateIngredient.Name = "btnUpdateIngredient";
            this.btnUpdateIngredient.Size = new System.Drawing.Size(80, 27);
            this.btnUpdateIngredient.TabIndex = 2;
            this.btnUpdateIngredient.Text = "Update ";
            this.btnUpdateIngredient.UseVisualStyleBackColor = true;
            this.btnUpdateIngredient.Click += new System.EventHandler(this.btnUpdateIngredient_Click);
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Location = new System.Drawing.Point(251, 304);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(80, 27);
            this.btnDeleteIngredient.TabIndex = 3;
            this.btnDeleteIngredient.Text = "Delete ";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // btnFilterIngredient
            // 
            this.btnFilterIngredient.Location = new System.Drawing.Point(251, 260);
            this.btnFilterIngredient.Name = "btnFilterIngredient";
            this.btnFilterIngredient.Size = new System.Drawing.Size(80, 28);
            this.btnFilterIngredient.TabIndex = 4;
            this.btnFilterIngredient.Text = "Filter ";
            this.btnFilterIngredient.UseVisualStyleBackColor = true;
            this.btnFilterIngredient.Click += new System.EventHandler(this.btnFilterIngredient_Click);
            // 
            // lstIngredient
            // 
            this.lstIngredient.FormattingEnabled = true;
            this.lstIngredient.Location = new System.Drawing.Point(45, 78);
            this.lstIngredient.Name = "lstIngredient";
            this.lstIngredient.Size = new System.Drawing.Size(286, 173);
            this.lstIngredient.TabIndex = 5;
            this.lstIngredient.SelectedIndexChanged += new System.EventHandler(this.lstIngredient_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(50, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 25);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "List of Cake Ingredients\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 407);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstIngredient);
            this.Controls.Add(this.btnFilterIngredient);
            this.Controls.Add(this.btnDeleteIngredient);
            this.Controls.Add(this.btnUpdateIngredient);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.btn_ListIngredient);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ListIngredient;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnUpdateIngredient;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button btnFilterIngredient;
        private System.Windows.Forms.ListBox lstIngredient;
        private System.Windows.Forms.Label lblTitle;
    }
}