namespace GroceryStoreApp
{
    partial class Menu
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AddItemMenubtn = new System.Windows.Forms.Button();
            this.Displaybtn = new System.Windows.Forms.Button();
            this.RemoveItemMenubtn = new System.Windows.Forms.Button();
            this.ExitAppbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TitleLabel.Location = new System.Drawing.Point(301, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(177, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Grocery Store Inventory";
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddItemMenubtn
            // 
            this.AddItemMenubtn.Location = new System.Drawing.Point(328, 197);
            this.AddItemMenubtn.Name = "AddItemMenubtn";
            this.AddItemMenubtn.Size = new System.Drawing.Size(128, 37);
            this.AddItemMenubtn.TabIndex = 1;
            this.AddItemMenubtn.Text = "Add Item";
            this.AddItemMenubtn.UseVisualStyleBackColor = true;
            this.AddItemMenubtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Displaybtn
            // 
            this.Displaybtn.Location = new System.Drawing.Point(328, 121);
            this.Displaybtn.Name = "Displaybtn";
            this.Displaybtn.Size = new System.Drawing.Size(128, 37);
            this.Displaybtn.TabIndex = 2;
            this.Displaybtn.Text = "View Inventory";
            this.Displaybtn.UseVisualStyleBackColor = true;
            this.Displaybtn.Click += new System.EventHandler(this.Displaybtn_Click);
            // 
            // RemoveItemMenubtn
            // 
            this.RemoveItemMenubtn.Location = new System.Drawing.Point(328, 273);
            this.RemoveItemMenubtn.Name = "RemoveItemMenubtn";
            this.RemoveItemMenubtn.Size = new System.Drawing.Size(128, 37);
            this.RemoveItemMenubtn.TabIndex = 3;
            this.RemoveItemMenubtn.Text = "Remove Item";
            this.RemoveItemMenubtn.UseVisualStyleBackColor = true;
            this.RemoveItemMenubtn.Click += new System.EventHandler(this.RemoveItemMenubtn_Click);
            // 
            // ExitAppbtn
            // 
            this.ExitAppbtn.Location = new System.Drawing.Point(328, 396);
            this.ExitAppbtn.Name = "ExitAppbtn";
            this.ExitAppbtn.Size = new System.Drawing.Size(128, 23);
            this.ExitAppbtn.TabIndex = 4;
            this.ExitAppbtn.Text = "Exit";
            this.ExitAppbtn.UseVisualStyleBackColor = true;
            this.ExitAppbtn.Click += new System.EventHandler(this.ExitAppbtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 476);
            this.Controls.Add(this.ExitAppbtn);
            this.Controls.Add(this.RemoveItemMenubtn);
            this.Controls.Add(this.Displaybtn);
            this.Controls.Add(this.AddItemMenubtn);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AddItemMenubtn;
        private System.Windows.Forms.Button Displaybtn;
        private System.Windows.Forms.Button RemoveItemMenubtn;
        private System.Windows.Forms.Button ExitAppbtn;
    }
}

