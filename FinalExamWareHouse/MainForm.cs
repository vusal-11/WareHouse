using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace FinalExamWareHouse
{
    public partial class MainForm : Form
    {

        ListViewItem lsttemp = new ListViewItem();

        public static User user = new User();

        public static Order order = new Order();

        public static Product product = new Product();

        public void UpdateData(User user)
        {
            string path = @$"../../../../Users\\{user.UserName}.json";
            File.Delete(path);
            var myfile = File.Create(path);
            myfile.Close();
            string userreg = JsonConvert.SerializeObject(user);
            using (StreamWriter writer = new StreamWriter(path))
            {

                writer.WriteLine(userreg);
                writer.Close();
            }
        }
        

        public MainForm()
        {
            InitializeComponent();
            mainpanel.Show();
            this.Height = 500;
            this.Width = 858;
            clientpanel.Hide();
            ProductPanel.Hide();
            OrderPanel.Hide();
            OrderPanel.Dock = DockStyle.Fill;
            mainpanel.Dock = DockStyle.Fill;
            clientpanel.Dock = DockStyle.Fill;
            ProductPanel.Dock = DockStyle.Fill;
            Filterlabel.Visible = false;
            filtertextBox.Visible = false;
            OrderPanel.Size = new Size(600, 600);
            ProductPanel.Size = new Size(600, 600);
            clientpanel.Size = new Size(600, 600);
            mainmenuStrip.Visible = false;
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
        public User GetUser(string fileName)
        {
            User user = new User();
            using (StreamReader r = new StreamReader($"../../../../Users\\{fileName}.json"))
            {
                string json = r.ReadToEnd();

                user = JsonConvert.DeserializeObject<User>(json);
            }
            return user;
        }




        public Client GetClient(string fileName)
        {
            Client client = new Client();
            using (StreamReader r = new StreamReader($"../../../../Clients\\{fileName}.json"))
            {
                string json = r.ReadToEnd();

                client = JsonConvert.DeserializeObject<Client>(json);
            }
            return client;
        }

        public static Product GetProduct(string fileName)
        {
            Product product = new Product();
            using (StreamReader r = new StreamReader($"../../../../Products\\{fileName}.json"))
            {
                string json = r.ReadToEnd();

                product = JsonConvert.DeserializeObject<Product>(json);
            }
            return product;
        }

        public static Order GetOrder(string fileName)
        {

            Order order = new Order();

            using (StreamReader r = new StreamReader($"../../../../Orders\\{fileName}.json"))
            {
                string json = r.ReadToEnd();

                order = JsonConvert.DeserializeObject<Order>(json);
            }
            return order;


        }

      

        private void signinbtn_Click(object sender, EventArgs e)
        {

            if (usernametextboxenter.Text != "" && passwordtextboxentering.Text != "")
            {
                try
                {
                    user = GetUser(usernametextboxenter.Text);
                    if (passwordtextboxentering.Text == user.PassWord)
                    {
                        showclient();
                        showproductlist();
                        mainpanel.Hide();
                        mainmenuStrip.Visible = true;
                        clientpanel.Show();

                    }
                    else
                    {
                        MessageBox.Show("Login or Password is wrong");

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Login or Password is wrong");

                }



            }
        }



        public static List<string> listFileNames(string dirName, string extention)
        {
            DirectoryInfo d = new DirectoryInfo("../../../../" + dirName); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles(extention); //Getting Text files

            List<string> fileNames = new List<string>();
            foreach (FileInfo file in Files)
            {
                fileNames.Add(file.Name.Replace(".json", ""));
            }

            return fileNames;
        }








            
        private void addclientmenustrip_Click(object sender, EventArgs e)
        {
            AddClientForm addClient = new AddClientForm();
            addClient.ShowDialog();
            //if(addClient.ShowDialog())
            listViewclient.Items.Add(AddClientForm.lzd);
        }
        private void listclientsmenustrip_Click(object sender, EventArgs e)
        {
            Filterlabel.Visible = false;
            filtertextBox.Visible = false;
            listViewclient.Items.Clear();
            showclient();
            clientpanel.Show();
            ProductPanel.Hide();
            OrderPanel.Hide();
        }


        List<Client> temp = user.clients;

        private void showclient()
        {

            List<Client> client = user.clients;

            foreach (var item in client)
            {
                ListViewItem mainitem = new ListViewItem(item.Name.ToString());
                var surname = item.SurName.ToString();
                var email = item.Email.ToString();
                var phone = item.PhoneNumber.ToString();
                var adress = item.Adress.ToString();
                mainitem.SubItems.Add(surname);
                mainitem.SubItems.Add(email);
                mainitem.SubItems.Add(phone);
                mainitem.SubItems.Add(adress);
                listViewclient.Items.Add(mainitem);


            }



        }

        public void showproductlist()
        {
            Product products = new Product();

            List<string> FileNames = listFileNames("Products", "*.json");


            foreach (var item in FileNames)
            {


                products = GetProduct(item);


                ListViewItem mainitem = new ListViewItem(products.Name.ToString());
                var price = products.Price.ToString();
                var quantity = products.Quantity.ToString();
                var description = products.Description.ToString();
                mainitem.SubItems.Add(price);
                mainitem.SubItems.Add(quantity);
                mainitem.SubItems.Add(description);
                listViewproduct.Items.Add(mainitem);
                

            }

        }



        public List<Order> showorderlist()
        {
           

            List<Order> order = user.orders;



            foreach (var item in order)
            {
                ListViewItem mainitem = new ListViewItem(item.OrderClientName.ToString());
                var orderprodname = item.OrderProductName.ToString();
                var orderprodquan = item.OrderProductQuantity.ToString();
                var orderdate = item.OrderDate.ToString();
                mainitem.SubItems.Add(orderprodname);
                mainitem.SubItems.Add(orderprodquan);
                mainitem.SubItems.Add(orderdate);
                listVieworder.Items.Add(mainitem);
            }
            return order;

        }


        private void addproductmenustrip_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            if(addProduct.ShowDialog()==DialogResult.OK)
            listViewproduct.Items.Add(AddProduct.lwproduct);
        }

        private void listproductmenustrip_Click(object sender, EventArgs e)
        {
            Filterlabel.Visible = false;
            filtertextBox.Visible = false;
            clientpanel.Hide();
            listViewproduct.Items.Clear();
            showproductlist();
            ProductPanel.Show();
            OrderPanel.Hide();
        }

        private void listordersmenustrip_Click(object sender, EventArgs e)
        {
            filtertextBox.Visible = true;
            Filterlabel.Visible = true;
            OrderPanel.Show();
            listVieworder.Items.Clear();
            showorderlist();
            clientpanel.Hide();
            ProductPanel.Hide();
        }

        private void acceptordermenustrip_Click(object sender, EventArgs e)
        {
            AddOrder addOrder= new AddOrder();
            if(addOrder.ShowDialog()==DialogResult.None)
            listVieworder.Items.Add(AddOrder.lworder);
        }

        private void filtertextBox_TextChanged(object sender, EventArgs e)
        {
            List<FilterClass> filtes = new List<FilterClass>();
            List<Order> orders= showorderlist();

            Order[] orderclass = new Order[orders.Count];
            orderclass = orders.ToArray(); 
             orderclass=orders.ToArray();
     
         
            if(filtertextBox.Text !="")
            {
                listVieworder.Items.Clear();
                for (int i = 0; i < orderclass.Length; i++)
                {
                    if (orderclass[i].OrderClientName.Contains(filtertextBox.Text) || orderclass[i].OrderProductName.Contains(filtertextBox.Text))
                    {
                        ListViewItem listView = new ListViewItem(orders[i].OrderClientName);
                        listView.SubItems.Add(orders[i].OrderProductName);
                        listView.SubItems.Add(orders[i].OrderProductQuantity.ToString());
                        listView.SubItems.Add(orders[i].OrderDate.ToString());
                        listVieworder.Items.Add(listView);

                    }
                            
                }

                

            }
            
        }                 
        private void exitToolStripMenu_Click(object sender, EventArgs e)
        {
            clientpanel.Hide();
            ProductPanel.Hide();
            OrderPanel.Hide();
            mainpanel.Show();
        }
        


        private void clientbuttonremove_Click(object sender, EventArgs e)
        {
            List<Client> templist = new List<Client>();
            templist = user.clients;
            foreach (var item in templist.ToList())
            {
                if (item.Name == listViewclient.SelectedItems[0].Text)
                {
                    user.clients.Remove(item);
                }
            }
            UpdateData(user);
            listViewclient.Items.Remove(listViewclient.SelectedItems[0]);
        }

        private void deleteproductbutton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product = GetProduct(listViewproduct.SelectedItems[0].Text);
            string path = @$"../../../../Products\\{product.Name}.json";
            File.Delete(path);
            listViewproduct.Items.Remove(listViewproduct.SelectedItems[0]);
        }

        private void deleteorderbutton_Click(object sender, EventArgs e)
        {
            List<Order> templist = new List<Order>();
            templist = user.orders;
            foreach (var item in templist.ToList())
            {
                if (item.OrderClientName == listVieworder.SelectedItems[0].Text)
                {
                    user.orders.Remove(item);
                }
            }
            UpdateData(user);
            listVieworder.Items.Remove(listVieworder.SelectedItems[0]);
        }
    }




}