namespace GroceryStoreApp
{
    partial class DisplayMenu
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
            this.DisplayInfoTextBox = new System.Windows.Forms.TextBox();
            this.DisplayFruitsbtn = new System.Windows.Forms.Button();
            this.DisplayVegbtn = new System.Windows.Forms.Button();
            this.DisplayDairybtn = new System.Windows.Forms.Button();
            this.DisplayMeatbtn = new System.Windows.Forms.Button();
            this.DisplayBakerybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayInfoTextBox
            // 
            this.DisplayInfoTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisplayInfoTextBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayInfoTextBox.Multiline = true;
            this.DisplayInfoTextBox.Name = "DisplayInfoTextBox";
            this.DisplayInfoTextBox.ReadOnly = true;
            this.DisplayInfoTextBox.Size = new System.Drawing.Size(355, 426);
            this.DisplayInfoTextBox.TabIndex = 0;
            this.DisplayInfoTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DisplayFruitsbtn
            // 
            this.DisplayFruitsbtn.Location = new System.Drawing.Point(559, 79);
            this.DisplayFruitsbtn.Name = "DisplayFruitsbtn";
            this.DisplayFruitsbtn.Size = new System.Drawing.Size(113, 23);
            this.DisplayFruitsbtn.TabIndex = 1;
            this.DisplayFruitsbtn.Text = "Fruits";
            this.DisplayFruitsbtn.UseVisualStyleBackColor = true;
            this.DisplayFruitsbtn.Click += new System.EventHandler(this.DisplayFruitsbtn_Click);
            // 
            // DisplayVegbtn
            // 
            this.DisplayVegbtn.Location = new System.Drawing.Point(559, 133);
            this.DisplayVegbtn.Name = "DisplayVegbtn";
            this.DisplayVegbtn.Size = new System.Drawing.Size(113, 23);
            this.DisplayVegbtn.TabIndex = 2;
            this.DisplayVegbtn.Text = "Vegetables";
            this.DisplayVegbtn.UseVisualStyleBackColor = true;
            this.DisplayVegbtn.Click += new System.EventHandler(this.DisplayVegbtn_Click);
            // 
            // DisplayDairybtn
            // 
            this.DisplayDairybtn.Location = new System.Drawing.Point(559, 190);
            this.DisplayDairybtn.Name = "DisplayDairybtn";
            this.DisplayDairybtn.Size = new System.Drawing.Size(113, 23);
            this.DisplayDairybtn.TabIndex = 3;
            this.DisplayDairybtn.Text = "Dairy Products";
            this.DisplayDairybtn.UseVisualStyleBackColor = true;
            this.DisplayDairybtn.Click += new System.EventHandler(this.DisplayDairybtn_Click);
            // 
            // DisplayMeatbtn
            // 
            this.DisplayMeatbtn.Location = new System.Drawing.Point(559, 249);
            this.DisplayMeatbtn.Name = "DisplayMeatbtn";
            this.DisplayMeatbtn.Size = new System.Drawing.Size(113, 23);
            this.DisplayMeatbtn.TabIndex = 4;
            this.DisplayMeatbtn.Text = "Meat Products";
            this.DisplayMeatbtn.UseVisualStyleBackColor = true;
            this.DisplayMeatbtn.Click += new System.EventHandler(this.DisplayMeatbtn_Click);
            // 
            // DisplayBakerybtn
            // 
            this.DisplayBakerybtn.Location = new System.Drawing.Point(559, 310);
            this.DisplayBakerybtn.Name = "DisplayBakerybtn";
            this.DisplayBakerybtn.Size = new System.Drawing.Size(113, 23);
            this.DisplayBakerybtn.TabIndex = 5;
            this.DisplayBakerybtn.Text = "Bakery Products";
            this.DisplayBakerybtn.UseVisualStyleBackColor = true;
            this.DisplayBakerybtn.Click += new System.EventHandler(this.DisplayBakerybtn_Click);
            // 
            // DisplayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayBakerybtn);
            this.Controls.Add(this.DisplayMeatbtn);
            this.Controls.Add(this.DisplayDairybtn);
            this.Controls.Add(this.DisplayVegbtn);
            this.Controls.Add(this.DisplayFruitsbtn);
            this.Controls.Add(this.DisplayInfoTextBox);
            this.Name = "DisplayMenu";
            this.Text = "DisplayMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayInfoTextBox;
        private System.Windows.Forms.Button DisplayFruitsbtn;
        private System.Windows.Forms.Button DisplayVegbtn;
        private System.Windows.Forms.Button DisplayDairybtn;
        private System.Windows.Forms.Button DisplayMeatbtn;
        private System.Windows.Forms.Button DisplayBakerybtn;
    }
}