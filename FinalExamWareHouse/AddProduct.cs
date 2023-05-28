using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamWareHouse
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        public static ListViewItem lwproduct = new ListViewItem();


        public void CreateProduct()
        {


            Product product = new Product();
            product.Name = textBoxproductname.Text;

            double.TryParse(productpricetextbox.Text, out double price);
            product.Price = price;
            int.TryParse(quantitynumericupdown.Text, out int quan);
            product.Quantity = quan;
            product.Description = productrichTextBox.Text;


            string path = @$"../../../../Products\\{product.Name}.json";

            Product temp = new Product();




            if (File.Exists(path))
            {
                temp = MainForm.GetProduct(product.Name);
                product.Quantity += temp.Quantity;
                File.Delete(path);

            }

                var myfile = File.Create(path);

                myfile.Close();

                string userreg = JsonConvert.SerializeObject(product);

                using (StreamWriter writer = new StreamWriter(path))
                {

                    writer.WriteLine(userreg);
                    writer.Close();
                }

            





        }

        private void saveprductbtn_Click(object sender, EventArgs e)
        {
            if (textBoxproductname.Text != "" && productpricetextbox.Text != "" && productrichTextBox.Text != "" && quantitynumericupdown.Text != "")
            {

                CreateProduct();
                lwproduct = new ListViewItem(textBoxproductname.Text);
                lwproduct.SubItems.Add(productpricetextbox.Text);
                lwproduct.SubItems.Add(quantitynumericupdown.Text);
                lwproduct.SubItems.Add(productrichTextBox.Text);

                this.Close();
                MessageBox.Show("Product has added succesfully");
            }
            else
            {
                MessageBox.Show("All fields have to fill");
            }

        }


    }
}
