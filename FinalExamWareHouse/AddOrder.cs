using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamWareHouse
{
    public partial class AddOrder : Form
    {


        public AddOrder()
        {
            InitializeComponent();

            List<Client> list = MainForm.user.clients;
            List<string> temp = new List<string>();
            foreach (var item in list)
            {
                temp.Add(item.Name);
            }


            orderclientcombobox.Items.AddRange(temp.ToArray());
            ordercomboBoxproduct.Items.AddRange(MainForm.listFileNames("Products", "*.json").ToArray());


        }


        public static ListViewItem lworder = new ListViewItem();

        public static bool changeorder = false;

        public static decimal currentcount;





        public void CreateOrder()
        {

            Random rand = new Random();
            Order order = new Order();
            order.OrderProductName = ordercomboBoxproduct.SelectedItem.ToString();

            order.OrderClientName = orderclientcombobox.SelectedItem.ToString();
            order.OrderProductQuantity = ordernumericUpDownquantity.Value;
            order.OrderDate = orderarrivetimepicker.Value.ToShortDateString();
            order.Id = rand.Next(1000000);
            MainForm.user.orders.Add(order);


            string path = @$"../../../../Users\\{MainForm.user.Name}.json";


            if(File.Exists(path))
            File.Delete(path);


            var myfile = File.Create(path);

            myfile.Close();

            string orderreg = JsonConvert.SerializeObject(MainForm.user);

            using (StreamWriter writer = new StreamWriter(path))
            {

                writer.WriteLine(orderreg);
                writer.Close();
            }







        }


        private void SubmitOrderbtn_Click(object sender, EventArgs e)
        {
            if (orderclientcombobox.SelectedIndex > -1 && ordercomboBoxproduct.SelectedIndex > -1 && ordernumericUpDownquantity.Text != "" && orderarrivetimepicker.Text != "")
            {

                Product product = MainForm.GetProduct(ordercomboBoxproduct.SelectedItem.ToString());
                if (product.Quantity >= ordernumericUpDownquantity.Value)
                {
                    product.Quantity -=ordernumericUpDownquantity.Value;
                    string path = @$"../../../../Products\\{product.Name}.json";
                    File.Delete(path);
                    string userreg = JsonConvert.SerializeObject(product);

                    using (StreamWriter writer = new StreamWriter(path))
                    {

                        writer.WriteLine(userreg);
                        writer.Close();
                    }
                    CreateOrder();
                    lworder = new ListViewItem(orderclientcombobox.SelectedItem.ToString());
                    lworder.SubItems.Add(ordercomboBoxproduct.SelectedItem.ToString());
                    lworder.SubItems.Add(ordernumericUpDownquantity.ToString());
                    lworder.SubItems.Add(orderarrivetimepicker.ToString());
                    MessageBox.Show("Order added succesfully");
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Not enough products to order");
                    return;
                }

            }
            else
            {
                MessageBox.Show("All fields have to fill");
                return;
            }




        }

        
    }
}
