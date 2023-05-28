namespace FinalExamWareHouse
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelwelcome = new System.Windows.Forms.Label();
            this.labelusernameenter = new System.Windows.Forms.Label();
            this.labelpasswordenter = new System.Windows.Forms.Label();
            this.usernametextboxenter = new System.Windows.Forms.TextBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signinbtn = new System.Windows.Forms.Button();
            this.signupbtn = new System.Windows.Forms.Button();
            this.passwordtextboxentering = new System.Windows.Forms.TextBox();
            this.clientpanel = new System.Windows.Forms.Panel();
            this.clientbuttonremove = new System.Windows.Forms.Button();
            this.listViewclient = new System.Windows.Forms.ListView();
            this.ClientName = new System.Windows.Forms.ColumnHeader();
            this.ClientSurname = new System.Windows.Forms.ColumnHeader();
            this.ClientEmail = new System.Windows.Forms.ColumnHeader();
            this.ClientPhone = new System.Windows.Forms.ColumnHeader();
            this.ClientAdress = new System.Windows.Forms.ColumnHeader();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.deleteorderbutton = new System.Windows.Forms.Button();
            this.listVieworder = new System.Windows.Forms.ListView();
            this.OrderName = new System.Windows.Forms.ColumnHeader();
            this.OrderProduct = new System.Windows.Forms.ColumnHeader();
            this.OrderQuantity = new System.Windows.Forms.ColumnHeader();
            this.OrderArrive = new System.Windows.Forms.ColumnHeader();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.deleteproductbutton = new System.Windows.Forms.Button();
            this.listViewproduct = new System.Windows.Forms.ListView();
            this.ProductName = new System.Windows.Forms.ColumnHeader();
            this.ProductPrice = new System.Windows.Forms.ColumnHeader();
            this.ProductQuantity = new System.Windows.Forms.ColumnHeader();
            this.ProductDescription = new System.Windows.Forms.ColumnHeader();
            this.mainmenuStrip = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addclientmenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.listclientsmenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceptordermenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.listordersmenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addproductmenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.listproductmenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Filterlabel = new System.Windows.Forms.Label();
            this.filtertextBox = new System.Windows.Forms.TextBox();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.clientpanel.SuspendLayout();
            this.OrderPanel.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            this.mainmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelwelcome
            // 
            this.labelwelcome.AutoSize = true;
            this.labelwelcome.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelwelcome.Location = new System.Drawing.Point(241, 139);
            this.labelwelcome.Name = "labelwelcome";
            this.labelwelcome.Size = new System.Drawing.Size(375, 41);
            this.labelwelcome.TabIndex = 0;
            this.labelwelcome.Text = "Welcome to Program";
            // 
            // labelusernameenter
            // 
            this.labelusernameenter.AutoSize = true;
            this.labelusernameenter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelusernameenter.Location = new System.Drawing.Point(163, 215);
            this.labelusernameenter.Name = "labelusernameenter";
            this.labelusernameenter.Size = new System.Drawing.Size(104, 28);
            this.labelusernameenter.TabIndex = 1;
            this.labelusernameenter.Text = "Username";
            // 
            // labelpasswordenter
            // 
            this.labelpasswordenter.AutoSize = true;
            this.labelpasswordenter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelpasswordenter.Location = new System.Drawing.Point(163, 272);
            this.labelpasswordenter.Name = "labelpasswordenter";
            this.labelpasswordenter.Size = new System.Drawing.Size(97, 28);
            this.labelpasswordenter.TabIndex = 2;
            this.labelpasswordenter.Text = "Password";
            // 
            // usernametextboxenter
            // 
            this.usernametextboxenter.Location = new System.Drawing.Point(289, 215);
            this.usernametextboxenter.Name = "usernametextboxenter";
            this.usernametextboxenter.Size = new System.Drawing.Size(238, 27);
            this.usernametextboxenter.TabIndex = 3;
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.BackColor = System.Drawing.Color.SteelBlue;
            this.mainpanel.Controls.Add(this.pictureBox1);
            this.mainpanel.Controls.Add(this.signinbtn);
            this.mainpanel.Controls.Add(this.signupbtn);
            this.mainpanel.Controls.Add(this.passwordtextboxentering);
            this.mainpanel.Controls.Add(this.labelusernameenter);
            this.mainpanel.Controls.Add(this.usernametextboxenter);
            this.mainpanel.Controls.Add(this.labelwelcome);
            this.mainpanel.Controls.Add(this.labelpasswordenter);
            this.mainpanel.Location = new System.Drawing.Point(39, 87);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(658, 457);
            this.mainpanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 135);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // signinbtn
            // 
            this.signinbtn.BackColor = System.Drawing.SystemColors.Info;
            this.signinbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signinbtn.Location = new System.Drawing.Point(438, 321);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(87, 47);
            this.signinbtn.TabIndex = 6;
            this.signinbtn.Text = "Sign in";
            this.signinbtn.UseVisualStyleBackColor = false;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.SystemColors.Info;
            this.signupbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signupbtn.Location = new System.Drawing.Point(289, 321);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(87, 47);
            this.signupbtn.TabIndex = 5;
            this.signupbtn.Text = "Sign up";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // passwordtextboxentering
            // 
            this.passwordtextboxentering.Location = new System.Drawing.Point(289, 272);
            this.passwordtextboxentering.Name = "passwordtextboxentering";
            this.passwordtextboxentering.Size = new System.Drawing.Size(238, 27);
            this.passwordtextboxentering.TabIndex = 4;
            // 
            // clientpanel
            // 
            this.clientpanel.Controls.Add(this.clientbuttonremove);
            this.clientpanel.Controls.Add(this.listViewclient);
            this.clientpanel.Location = new System.Drawing.Point(836, 52);
            this.clientpanel.Name = "clientpanel";
            this.clientpanel.Size = new System.Drawing.Size(834, 545);
            this.clientpanel.TabIndex = 5;
            // 
            // clientbuttonremove
            // 
            this.clientbuttonremove.BackColor = System.Drawing.Color.SteelBlue;
            this.clientbuttonremove.Location = new System.Drawing.Point(692, 3);
            this.clientbuttonremove.Name = "clientbuttonremove";
            this.clientbuttonremove.Size = new System.Drawing.Size(94, 29);
            this.clientbuttonremove.TabIndex = 11;
            this.clientbuttonremove.Text = "Delete";
            this.clientbuttonremove.UseVisualStyleBackColor = false;
            this.clientbuttonremove.Click += new System.EventHandler(this.clientbuttonremove_Click);
            // 
            // listViewclient
            // 
            this.listViewclient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientName,
            this.ClientSurname,
            this.ClientEmail,
            this.ClientPhone,
            this.ClientAdress});
            this.listViewclient.Location = new System.Drawing.Point(30, 0);
            this.listViewclient.Name = "listViewclient";
            this.listViewclient.Size = new System.Drawing.Size(773, 613);
            this.listViewclient.TabIndex = 1;
            this.listViewclient.UseCompatibleStateImageBehavior = false;
            this.listViewclient.View = System.Windows.Forms.View.Details;
            // 
            // ClientName
            // 
            this.ClientName.Text = "Name";
            this.ClientName.Width = 100;
            // 
            // ClientSurname
            // 
            this.ClientSurname.Text = "Surname";
            this.ClientSurname.Width = 100;
            // 
            // ClientEmail
            // 
            this.ClientEmail.Text = "Email";
            this.ClientEmail.Width = 160;
            // 
            // ClientPhone
            // 
            this.ClientPhone.Text = "Phone";
            this.ClientPhone.Width = 130;
            // 
            // ClientAdress
            // 
            this.ClientAdress.Text = "Adress";
            this.ClientAdress.Width = 150;
            // 
            // OrderPanel
            // 
            this.OrderPanel.Controls.Add(this.deleteorderbutton);
            this.OrderPanel.Controls.Add(this.listVieworder);
            this.OrderPanel.Location = new System.Drawing.Point(911, 602);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(794, 644);
            this.OrderPanel.TabIndex = 6;
            // 
            // deleteorderbutton
            // 
            this.deleteorderbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.deleteorderbutton.Location = new System.Drawing.Point(535, 18);
            this.deleteorderbutton.Name = "deleteorderbutton";
            this.deleteorderbutton.Size = new System.Drawing.Size(94, 29);
            this.deleteorderbutton.TabIndex = 1;
            this.deleteorderbutton.Text = "Delete";
            this.deleteorderbutton.UseVisualStyleBackColor = false;
            this.deleteorderbutton.Click += new System.EventHandler(this.deleteorderbutton_Click);
            // 
            // listVieworder
            // 
            this.listVieworder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderName,
            this.OrderProduct,
            this.OrderQuantity,
            this.OrderArrive});
            this.listVieworder.Location = new System.Drawing.Point(34, 18);
            this.listVieworder.Name = "listVieworder";
            this.listVieworder.Size = new System.Drawing.Size(773, 613);
            this.listVieworder.TabIndex = 0;
            this.listVieworder.UseCompatibleStateImageBehavior = false;
            this.listVieworder.View = System.Windows.Forms.View.Details;
            // 
            // OrderName
            // 
            this.OrderName.Text = "Name";
            this.OrderName.Width = 100;
            // 
            // OrderProduct
            // 
            this.OrderProduct.Text = "Product";
            this.OrderProduct.Width = 120;
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.Text = "Quantity";
            this.OrderQuantity.Width = 100;
            // 
            // OrderArrive
            // 
            this.OrderArrive.Text = "Arrive Date";
            this.OrderArrive.Width = 160;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.deleteproductbutton);
            this.ProductPanel.Controls.Add(this.listViewproduct);
            this.ProductPanel.Location = new System.Drawing.Point(25, 602);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(806, 644);
            this.ProductPanel.TabIndex = 7;
            // 
            // deleteproductbutton
            // 
            this.deleteproductbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.deleteproductbutton.Location = new System.Drawing.Point(482, 3);
            this.deleteproductbutton.Name = "deleteproductbutton";
            this.deleteproductbutton.Size = new System.Drawing.Size(94, 29);
            this.deleteproductbutton.TabIndex = 3;
            this.deleteproductbutton.Text = "Delete";
            this.deleteproductbutton.UseVisualStyleBackColor = false;
            this.deleteproductbutton.Click += new System.EventHandler(this.deleteproductbutton_Click);
            // 
            // listViewproduct
            // 
            this.listViewproduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.ProductPrice,
            this.ProductQuantity,
            this.ProductDescription});
            this.listViewproduct.Location = new System.Drawing.Point(30, 3);
            this.listViewproduct.Name = "listViewproduct";
            this.listViewproduct.Size = new System.Drawing.Size(773, 613);
            this.listViewproduct.TabIndex = 2;
            this.listViewproduct.UseCompatibleStateImageBehavior = false;
            this.listViewproduct.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Name";
            this.ProductName.Width = 100;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "Price";
            this.ProductPrice.Width = 100;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.Text = "Quantity";
            this.ProductQuantity.Width = 100;
            // 
            // ProductDescription
            // 
            this.ProductDescription.Text = "Description";
            this.ProductDescription.Width = 140;
            // 
            // mainmenuStrip
            // 
            this.mainmenuStrip.BackColor = System.Drawing.Color.SteelBlue;
            this.mainmenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem2,
            this.orderToolStripMenuItem,
            this.productToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.mainmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainmenuStrip.Name = "mainmenuStrip";
            this.mainmenuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.mainmenuStrip.Size = new System.Drawing.Size(1817, 30);
            this.mainmenuStrip.TabIndex = 8;
            this.mainmenuStrip.Text = "menuStrip3";
            // 
            // clientToolStripMenuItem2
            // 
            this.clientToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addclientmenustrip,
            this.listclientsmenustrip});
            this.clientToolStripMenuItem2.Name = "clientToolStripMenuItem2";
            this.clientToolStripMenuItem2.Size = new System.Drawing.Size(61, 24);
            this.clientToolStripMenuItem2.Text = "Client";
            // 
            // addclientmenustrip
            // 
            this.addclientmenustrip.Name = "addclientmenustrip";
            this.addclientmenustrip.Size = new System.Drawing.Size(120, 26);
            this.addclientmenustrip.Text = "Add";
            this.addclientmenustrip.Click += new System.EventHandler(this.addclientmenustrip_Click);
            // 
            // listclientsmenustrip
            // 
            this.listclientsmenustrip.Name = "listclientsmenustrip";
            this.listclientsmenustrip.Size = new System.Drawing.Size(120, 26);
            this.listclientsmenustrip.Text = "List";
            this.listclientsmenustrip.Click += new System.EventHandler(this.listclientsmenustrip_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptordermenustrip,
            this.listordersmenustrip});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // acceptordermenustrip
            // 
            this.acceptordermenustrip.Name = "acceptordermenustrip";
            this.acceptordermenustrip.Size = new System.Drawing.Size(138, 26);
            this.acceptordermenustrip.Text = "Accept";
            this.acceptordermenustrip.Click += new System.EventHandler(this.acceptordermenustrip_Click);
            // 
            // listordersmenustrip
            // 
            this.listordersmenustrip.Name = "listordersmenustrip";
            this.listordersmenustrip.Size = new System.Drawing.Size(138, 26);
            this.listordersmenustrip.Text = "List";
            this.listordersmenustrip.Click += new System.EventHandler(this.listordersmenustrip_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addproductmenustrip,
            this.listproductmenustrip});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addproductmenustrip
            // 
            this.addproductmenustrip.Name = "addproductmenustrip";
            this.addproductmenustrip.Size = new System.Drawing.Size(120, 26);
            this.addproductmenustrip.Text = "Add";
            this.addproductmenustrip.Click += new System.EventHandler(this.addproductmenustrip_Click);
            // 
            // listproductmenustrip
            // 
            this.listproductmenustrip.Name = "listproductmenustrip";
            this.listproductmenustrip.Size = new System.Drawing.Size(120, 26);
            this.listproductmenustrip.Text = "List";
            this.listproductmenustrip.Click += new System.EventHandler(this.listproductmenustrip_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenu});
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(76, 24);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenu.Text = "Exit";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click);
            // 
            // Filterlabel
            // 
            this.Filterlabel.AutoSize = true;
            this.Filterlabel.Location = new System.Drawing.Point(440, 15);
            this.Filterlabel.Name = "Filterlabel";
            this.Filterlabel.Size = new System.Drawing.Size(42, 20);
            this.Filterlabel.TabIndex = 9;
            this.Filterlabel.Text = "Filter";
            // 
            // filtertextBox
            // 
            this.filtertextBox.Location = new System.Drawing.Point(488, 12);
            this.filtertextBox.Name = "filtertextBox";
            this.filtertextBox.Size = new System.Drawing.Size(262, 27);
            this.filtertextBox.TabIndex = 10;
            this.filtertextBox.TextChanged += new System.EventHandler(this.filtertextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1817, 1055);
            this.Controls.Add(this.filtertextBox);
            this.Controls.Add(this.Filterlabel);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.OrderPanel);
            this.Controls.Add(this.clientpanel);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.mainmenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WareHouse";
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.clientpanel.ResumeLayout(false);
            this.OrderPanel.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            this.mainmenuStrip.ResumeLayout(false);
            this.mainmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelwelcome;
        private Label labelusernameenter;
        private Label labelpasswordenter;
        private TextBox usernametextboxenter;
        private Panel mainpanel;
        private Button signinbtn;
        private Button signupbtn;
        private TextBox passwordtextboxentering;
        private Panel clientpanel;
        private ListView listViewclient;
        private ColumnHeader ClientName;
        private ColumnHeader ClientSurname;
        private ColumnHeader ClientEmail;
        private ColumnHeader ClientPhone;
        private ColumnHeader ClientAdress;
        private Panel OrderPanel;
        private Panel ProductPanel;
        private ListView listViewproduct;
        private ColumnHeader ProductName;
        private ColumnHeader ProductPrice;
        private ColumnHeader ProductQuantity;
        private ColumnHeader ProductDescription;
        private MenuStrip mainmenuStrip;
        private ToolStripMenuItem clientToolStripMenuItem2;
        private ToolStripMenuItem addclientmenustrip;
        private ToolStripMenuItem listclientsmenustrip;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem acceptordermenustrip;
        private ToolStripMenuItem listordersmenustrip;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem addproductmenustrip;
        private ToolStripMenuItem listproductmenustrip;
        private ToolStripMenuItem logOutToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenu;
        private ListView listVieworder;
        private ColumnHeader OrderName;
        private ColumnHeader OrderProduct;
        private ColumnHeader OrderQuantity;
        private ColumnHeader OrderArrive;
        private Label Filterlabel;
        private TextBox filtertextBox;
        private Button clientbuttonremove;
        private Button deleteproductbutton;
        private Button deleteorderbutton;
        private PictureBox pictureBox1;
    }
}