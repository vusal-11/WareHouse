namespace FinalExamWareHouse
{
    partial class AddProduct
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
            this.productnamelabel = new System.Windows.Forms.Label();
            this.textBoxproductname = new System.Windows.Forms.TextBox();
            this.Priceproductlabel = new System.Windows.Forms.Label();
            this.productpricetextbox = new System.Windows.Forms.TextBox();
            this.QuantityproductLabel = new System.Windows.Forms.Label();
            this.Descriptionproductlabel = new System.Windows.Forms.Label();
            this.productrichTextBox = new System.Windows.Forms.RichTextBox();
            this.saveprductbtn = new System.Windows.Forms.Button();
            this.quantitynumericupdown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantitynumericupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // productnamelabel
            // 
            this.productnamelabel.AutoSize = true;
            this.productnamelabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productnamelabel.Location = new System.Drawing.Point(83, 75);
            this.productnamelabel.Name = "productnamelabel";
            this.productnamelabel.Size = new System.Drawing.Size(63, 29);
            this.productnamelabel.TabIndex = 0;
            this.productnamelabel.Text = "Name";
            // 
            // textBoxproductname
            // 
            this.textBoxproductname.Location = new System.Drawing.Point(190, 75);
            this.textBoxproductname.Name = "textBoxproductname";
            this.textBoxproductname.Size = new System.Drawing.Size(125, 27);
            this.textBoxproductname.TabIndex = 1;
            // 
            // Priceproductlabel
            // 
            this.Priceproductlabel.AutoSize = true;
            this.Priceproductlabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Priceproductlabel.Location = new System.Drawing.Point(83, 124);
            this.Priceproductlabel.Name = "Priceproductlabel";
            this.Priceproductlabel.Size = new System.Drawing.Size(55, 29);
            this.Priceproductlabel.TabIndex = 2;
            this.Priceproductlabel.Text = "Price";
            // 
            // productpricetextbox
            // 
            this.productpricetextbox.Location = new System.Drawing.Point(190, 128);
            this.productpricetextbox.Name = "productpricetextbox";
            this.productpricetextbox.Size = new System.Drawing.Size(125, 27);
            this.productpricetextbox.TabIndex = 3;
            // 
            // QuantityproductLabel
            // 
            this.QuantityproductLabel.AutoSize = true;
            this.QuantityproductLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuantityproductLabel.Location = new System.Drawing.Point(81, 171);
            this.QuantityproductLabel.Name = "QuantityproductLabel";
            this.QuantityproductLabel.Size = new System.Drawing.Size(88, 29);
            this.QuantityproductLabel.TabIndex = 4;
            this.QuantityproductLabel.Text = "Quantity";
            // 
            // Descriptionproductlabel
            // 
            this.Descriptionproductlabel.AutoSize = true;
            this.Descriptionproductlabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Descriptionproductlabel.Location = new System.Drawing.Point(74, 227);
            this.Descriptionproductlabel.Name = "Descriptionproductlabel";
            this.Descriptionproductlabel.Size = new System.Drawing.Size(110, 29);
            this.Descriptionproductlabel.TabIndex = 6;
            this.Descriptionproductlabel.Text = "Description";
            // 
            // productrichTextBox
            // 
            this.productrichTextBox.Location = new System.Drawing.Point(190, 231);
            this.productrichTextBox.Name = "productrichTextBox";
            this.productrichTextBox.Size = new System.Drawing.Size(261, 171);
            this.productrichTextBox.TabIndex = 7;
            this.productrichTextBox.Text = "";
            // 
            // saveprductbtn
            // 
            this.saveprductbtn.BackColor = System.Drawing.Color.SeaShell;
            this.saveprductbtn.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveprductbtn.Location = new System.Drawing.Point(346, 427);
            this.saveprductbtn.Name = "saveprductbtn";
            this.saveprductbtn.Size = new System.Drawing.Size(105, 45);
            this.saveprductbtn.TabIndex = 8;
            this.saveprductbtn.Text = "Save";
            this.saveprductbtn.UseVisualStyleBackColor = false;
            this.saveprductbtn.Click += new System.EventHandler(this.saveprductbtn_Click);
            // 
            // quantitynumericupdown
            // 
            this.quantitynumericupdown.Location = new System.Drawing.Point(190, 176);
            this.quantitynumericupdown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quantitynumericupdown.Name = "quantitynumericupdown";
            this.quantitynumericupdown.Size = new System.Drawing.Size(150, 27);
            this.quantitynumericupdown.TabIndex = 9;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(518, 498);
            this.Controls.Add(this.quantitynumericupdown);
            this.Controls.Add(this.saveprductbtn);
            this.Controls.Add(this.productrichTextBox);
            this.Controls.Add(this.Descriptionproductlabel);
            this.Controls.Add(this.QuantityproductLabel);
            this.Controls.Add(this.productpricetextbox);
            this.Controls.Add(this.Priceproductlabel);
            this.Controls.Add(this.textBoxproductname);
            this.Controls.Add(this.productnamelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.quantitynumericupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label productnamelabel;
        private TextBox textBoxproductname;
        private Label Priceproductlabel;
        private TextBox productpricetextbox;
        private Label QuantityproductLabel;
        private Label Descriptionproductlabel;
        private RichTextBox productrichTextBox;
        private Button saveprductbtn;
        private NumericUpDown quantitynumericupdown;
    }
}