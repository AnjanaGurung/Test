namespace TCSBackOffice
{
    partial class DeleteIngredient
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
            this.txtTextbox = new System.Windows.Forms.TextBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackMainMenu
            // 
            this.btnBackMainMenu.Location = new System.Drawing.Point(163, 241);
            this.btnBackMainMenu.Name = "btnBackMainMenu";
            this.btnBackMainMenu.Size = new System.Drawing.Size(121, 23);
            this.btnBackMainMenu.TabIndex = 3;
            this.btnBackMainMenu.Text = "Back to MainMenu";
            this.btnBackMainMenu.UseVisualStyleBackColor = true;
            this.btnBackMainMenu.Click += new System.EventHandler(this.btnBackMainMenu3_Click);
            // 
            // txtTextbox
            // 
            this.txtTextbox.Location = new System.Drawing.Point(12, 37);
            this.txtTextbox.Name = "txtTextbox";
            this.txtTextbox.Size = new System.Drawing.Size(260, 20);
            this.txtTextbox.TabIndex = 4;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(22, 75);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(238, 13);
            this.lblDelete.TabIndex = 5;
            this.lblDelete.Text = "Are Your sure you want to delete this ingredient? ";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(25, 102);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 6;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(151, 102);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 7;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 276);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.txtTextbox);
            this.Controls.Add(this.btnBackMainMenu);
            this.Name = "DeleteIngredient";
            this.Text = "DeleteIngredient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackMainMenu;
        private System.Windows.Forms.TextBox txtTextbox;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}