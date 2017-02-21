namespace TCSBackOffice
{
    partial class FilterIngredient
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
            this.btnBackMainMenu = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txtFind = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackMainMenu
            // 
            this.btnBackMainMenu.Location = new System.Drawing.Point(151, 227);
            this.btnBackMainMenu.Name = "btnBackMainMenu";
            this.btnBackMainMenu.Size = new System.Drawing.Size(121, 23);
            this.btnBackMainMenu.TabIndex = 3;
            this.btnBackMainMenu.Text = "Back to MainMenu";
            this.btnBackMainMenu.UseVisualStyleBackColor = true;
            this.btnBackMainMenu.Click += new System.EventHandler(this.btnBackMainMenu2_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(21, 57);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(251, 20);
            this.txt1.TabIndex = 4;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(21, 100);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(84, 34);
            this.txtFind.TabIndex = 5;
            this.txtFind.Text = "Find";
            this.txtFind.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(18, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(266, 16);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Please enter the ingredient you want to find. ";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(128, 100);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(144, 34);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View Ingredients list";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // FilterIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 262);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnBackMainMenu);
            this.Name = "FilterIngredient";
            this.Text = "FilterIngredient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackMainMenu;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button txtFind;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnView;
    }
}