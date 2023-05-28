namespace FinalExamWareHouse
{
    partial class AddClientForm
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
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientSurnameLabel = new System.Windows.Forms.Label();
            this.ClientEmailLabel = new System.Windows.Forms.Label();
            this.ClientPhoneLabel = new System.Windows.Forms.Label();
            this.AdressRichTextbox = new System.Windows.Forms.RichTextBox();
            this.ClientAdressLabel = new System.Windows.Forms.Label();
            this.ClientNameTextbox = new System.Windows.Forms.TextBox();
            this.ClientSurnameTextbox = new System.Windows.Forms.TextBox();
            this.ClientEmailTextbox = new System.Windows.Forms.TextBox();
            this.ClientNumMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ClientSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientNameLabel.Location = new System.Drawing.Point(55, 56);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(63, 29);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Name";
            // 
            // ClientSurnameLabel
            // 
            this.ClientSurnameLabel.AutoSize = true;
            this.ClientSurnameLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientSurnameLabel.Location = new System.Drawing.Point(55, 97);
            this.ClientSurnameLabel.Name = "ClientSurnameLabel";
            this.ClientSurnameLabel.Size = new System.Drawing.Size(90, 29);
            this.ClientSurnameLabel.TabIndex = 1;
            this.ClientSurnameLabel.Text = "Surname";
            // 
            // ClientEmailLabel
            // 
            this.ClientEmailLabel.AutoSize = true;
            this.ClientEmailLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientEmailLabel.Location = new System.Drawing.Point(55, 139);
            this.ClientEmailLabel.Name = "ClientEmailLabel";
            this.ClientEmailLabel.Size = new System.Drawing.Size(64, 29);
            this.ClientEmailLabel.TabIndex = 2;
            this.ClientEmailLabel.Text = "Email";
            // 
            // ClientPhoneLabel
            // 
            this.ClientPhoneLabel.AutoSize = true;
            this.ClientPhoneLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientPhoneLabel.Location = new System.Drawing.Point(55, 179);
            this.ClientPhoneLabel.Name = "ClientPhoneLabel";
            this.ClientPhoneLabel.Size = new System.Drawing.Size(139, 29);
            this.ClientPhoneLabel.TabIndex = 3;
            this.ClientPhoneLabel.Text = "Phone Number";
            // 
            // AdressRichTextbox
            // 
            this.AdressRichTextbox.Location = new System.Drawing.Point(211, 231);
            this.AdressRichTextbox.Name = "AdressRichTextbox";
            this.AdressRichTextbox.Size = new System.Drawing.Size(265, 168);
            this.AdressRichTextbox.TabIndex = 4;
            this.AdressRichTextbox.Text = "";
            // 
            // ClientAdressLabel
            // 
            this.ClientAdressLabel.AutoSize = true;
            this.ClientAdressLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientAdressLabel.Location = new System.Drawing.Point(55, 227);
            this.ClientAdressLabel.Name = "ClientAdressLabel";
            this.ClientAdressLabel.Size = new System.Drawing.Size(69, 29);
            this.ClientAdressLabel.TabIndex = 5;
            this.ClientAdressLabel.Text = "Adress";
            // 
            // ClientNameTextbox
            // 
            this.ClientNameTextbox.Location = new System.Drawing.Point(211, 56);
            this.ClientNameTextbox.Name = "ClientNameTextbox";
            this.ClientNameTextbox.Size = new System.Drawing.Size(265, 27);
            this.ClientNameTextbox.TabIndex = 6;
            // 
            // ClientSurnameTextbox
            // 
            this.ClientSurnameTextbox.Location = new System.Drawing.Point(211, 97);
            this.ClientSurnameTextbox.Name = "ClientSurnameTextbox";
            this.ClientSurnameTextbox.Size = new System.Drawing.Size(265, 27);
            this.ClientSurnameTextbox.TabIndex = 7;
            // 
            // ClientEmailTextbox
            // 
            this.ClientEmailTextbox.Location = new System.Drawing.Point(211, 139);
            this.ClientEmailTextbox.Name = "ClientEmailTextbox";
            this.ClientEmailTextbox.Size = new System.Drawing.Size(265, 27);
            this.ClientEmailTextbox.TabIndex = 8;
            // 
            // ClientNumMaskedTextBox
            // 
            this.ClientNumMaskedTextBox.Location = new System.Drawing.Point(211, 179);
            this.ClientNumMaskedTextBox.Mask = "(999) 000-00-00";
            this.ClientNumMaskedTextBox.Name = "ClientNumMaskedTextBox";
            this.ClientNumMaskedTextBox.Size = new System.Drawing.Size(265, 27);
            this.ClientNumMaskedTextBox.TabIndex = 9;
            // 
            // ClientSaveBtn
            // 
            this.ClientSaveBtn.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSaveBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientSaveBtn.Location = new System.Drawing.Point(376, 419);
            this.ClientSaveBtn.Name = "ClientSaveBtn";
            this.ClientSaveBtn.Size = new System.Drawing.Size(101, 48);
            this.ClientSaveBtn.TabIndex = 10;
            this.ClientSaveBtn.Text = "Save";
            this.ClientSaveBtn.UseVisualStyleBackColor = false;
            this.ClientSaveBtn.Click += new System.EventHandler(this.ClientSaveBtn_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(553, 481);
            this.Controls.Add(this.ClientSaveBtn);
            this.Controls.Add(this.ClientNumMaskedTextBox);
            this.Controls.Add(this.ClientEmailTextbox);
            this.Controls.Add(this.ClientSurnameTextbox);
            this.Controls.Add(this.ClientNameTextbox);
            this.Controls.Add(this.ClientAdressLabel);
            this.Controls.Add(this.AdressRichTextbox);
            this.Controls.Add(this.ClientPhoneLabel);
            this.Controls.Add(this.ClientEmailLabel);
            this.Controls.Add(this.ClientSurnameLabel);
            this.Controls.Add(this.ClientNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ClientNameLabel;
        private Label ClientSurnameLabel;
        private Label ClientEmailLabel;
        private Label ClientPhoneLabel;
        private RichTextBox AdressRichTextbox;
        private Label ClientAdressLabel;
        private TextBox ClientNameTextbox;
        private TextBox ClientSurnameTextbox;
        private TextBox ClientEmailTextbox;
        private MaskedTextBox ClientNumMaskedTextBox;
        private Button ClientSaveBtn;
    }
}