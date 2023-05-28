namespace FinalExamWareHouse
{
    partial class AddOrder
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
            this.orderlabelclientname = new System.Windows.Forms.Label();
            this.orderclientcombobox = new System.Windows.Forms.ComboBox();
            this.orderlabelproductname = new System.Windows.Forms.Label();
            this.ordercomboBoxproduct = new System.Windows.Forms.ComboBox();
            this.labelQuantityorder = new System.Windows.Forms.Label();
            this.ordernumericUpDownquantity = new System.Windows.Forms.NumericUpDown();
            this.LabelArriveTime = new System.Windows.Forms.Label();
            this.orderarrivetimepicker = new System.Windows.Forms.DateTimePicker();
            this.SubmitOrderbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordernumericUpDownquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // orderlabelclientname
            // 
            this.orderlabelclientname.AutoSize = true;
            this.orderlabelclientname.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderlabelclientname.Location = new System.Drawing.Point(65, 69);
            this.orderlabelclientname.Name = "orderlabelclientname";
            this.orderlabelclientname.Size = new System.Drawing.Size(63, 29);
            this.orderlabelclientname.TabIndex = 0;
            this.orderlabelclientname.Text = "Name";
            // 
            // orderclientcombobox
            // 
            this.orderclientcombobox.FormattingEnabled = true;
            this.orderclientcombobox.Location = new System.Drawing.Point(177, 73);
            this.orderclientcombobox.Name = "orderclientcombobox";
            this.orderclientcombobox.Size = new System.Drawing.Size(151, 28);
            this.orderclientcombobox.TabIndex = 1;
            // 
            // orderlabelproductname
            // 
            this.orderlabelproductname.AutoSize = true;
            this.orderlabelproductname.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderlabelproductname.Location = new System.Drawing.Point(65, 120);
            this.orderlabelproductname.Name = "orderlabelproductname";
            this.orderlabelproductname.Size = new System.Drawing.Size(79, 29);
            this.orderlabelproductname.TabIndex = 2;
            this.orderlabelproductname.Text = "Product";
            // 
            // ordercomboBoxproduct
            // 
            this.ordercomboBoxproduct.FormattingEnabled = true;
            this.ordercomboBoxproduct.Location = new System.Drawing.Point(177, 121);
            this.ordercomboBoxproduct.Name = "ordercomboBoxproduct";
            this.ordercomboBoxproduct.Size = new System.Drawing.Size(151, 28);
            this.ordercomboBoxproduct.TabIndex = 3;
            // 
            // labelQuantityorder
            // 
            this.labelQuantityorder.AutoSize = true;
            this.labelQuantityorder.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuantityorder.Location = new System.Drawing.Point(63, 171);
            this.labelQuantityorder.Name = "labelQuantityorder";
            this.labelQuantityorder.Size = new System.Drawing.Size(88, 29);
            this.labelQuantityorder.TabIndex = 4;
            this.labelQuantityorder.Text = "Quantity";
            // 
            // ordernumericUpDownquantity
            // 
            this.ordernumericUpDownquantity.Location = new System.Drawing.Point(177, 171);
            this.ordernumericUpDownquantity.Name = "ordernumericUpDownquantity";
            this.ordernumericUpDownquantity.Size = new System.Drawing.Size(150, 27);
            this.ordernumericUpDownquantity.TabIndex = 5;
            // 
            // LabelArriveTime
            // 
            this.LabelArriveTime.AutoSize = true;
            this.LabelArriveTime.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelArriveTime.Location = new System.Drawing.Point(65, 225);
            this.LabelArriveTime.Name = "LabelArriveTime";
            this.LabelArriveTime.Size = new System.Drawing.Size(115, 29);
            this.LabelArriveTime.TabIndex = 6;
            this.LabelArriveTime.Text = "Arrive Time";
            // 
            // orderarrivetimepicker
            // 
            this.orderarrivetimepicker.Location = new System.Drawing.Point(177, 225);
            this.orderarrivetimepicker.Name = "orderarrivetimepicker";
            this.orderarrivetimepicker.Size = new System.Drawing.Size(250, 27);
            this.orderarrivetimepicker.TabIndex = 7;
            // 
            // SubmitOrderbtn
            // 
            this.SubmitOrderbtn.BackColor = System.Drawing.Color.SeaShell;
            this.SubmitOrderbtn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitOrderbtn.Location = new System.Drawing.Point(306, 286);
            this.SubmitOrderbtn.Name = "SubmitOrderbtn";
            this.SubmitOrderbtn.Size = new System.Drawing.Size(121, 56);
            this.SubmitOrderbtn.TabIndex = 8;
            this.SubmitOrderbtn.Text = "Submit";
            this.SubmitOrderbtn.UseVisualStyleBackColor = false;
            this.SubmitOrderbtn.Click += new System.EventHandler(this.SubmitOrderbtn_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(475, 397);
            this.Controls.Add(this.SubmitOrderbtn);
            this.Controls.Add(this.orderarrivetimepicker);
            this.Controls.Add(this.LabelArriveTime);
            this.Controls.Add(this.ordernumericUpDownquantity);
            this.Controls.Add(this.labelQuantityorder);
            this.Controls.Add(this.ordercomboBoxproduct);
            this.Controls.Add(this.orderlabelproductname);
            this.Controls.Add(this.orderclientcombobox);
            this.Controls.Add(this.orderlabelclientname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrder";
            ((System.ComponentModel.ISupportInitialize)(this.ordernumericUpDownquantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label orderlabelclientname;
        private ComboBox orderclientcombobox;
        private Label orderlabelproductname;
        private ComboBox ordercomboBoxproduct;
        private Label labelQuantityorder;
        private NumericUpDown ordernumericUpDownquantity;
        private Label LabelArriveTime;
        private DateTimePicker orderarrivetimepicker;
        private Button SubmitOrderbtn;
    }
}