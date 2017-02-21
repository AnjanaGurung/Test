namespace TCSBackOffice
{
    partial class StaffMenu
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
            this.btnIngredientMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngredientMenu
            // 
            this.btnIngredientMenu.Location = new System.Drawing.Point(61, 45);
            this.btnIngredientMenu.Name = "btnIngredientMenu";
            this.btnIngredientMenu.Size = new System.Drawing.Size(153, 46);
            this.btnIngredientMenu.TabIndex = 0;
            this.btnIngredientMenu.Text = "Ingredient";
            this.btnIngredientMenu.UseVisualStyleBackColor = true;
            this.btnIngredientMenu.Click += new System.EventHandler(this.btnIngredientMenu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cake";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Customer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(61, 251);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(153, 45);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 376);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIngredientMenu);
            this.Name = "StaffMenu";
            this.Text = "StaffMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngredientMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOrder;
    }
}