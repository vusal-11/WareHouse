using Microsoft.VisualBasic.ApplicationServices;
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



    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

       

        public static ListViewItem lzd = new ListViewItem();
    
        

        public void CreateClient()
        {

            

            Client client = new Client();
            client.Name=ClientNameTextbox.Text;
            client.SurName=ClientSurnameTextbox.Text;
            client.Email = ClientEmailTextbox.Text;
            client.PhoneNumber=ClientNumMaskedTextBox.Text;
            client.Adress = AdressRichTextbox.Text;
            MainForm.user.clients.Add(client);

            string path = @$"../../../../Users\\{MainForm.user.Name}.json";

                if (File.Exists(path));
                File.Delete(path);
                var myfile = File.Create(path);

                myfile.Close();

                string userreg = JsonConvert.SerializeObject(MainForm.user);

                using (StreamWriter writer = new StreamWriter(path))
                {

                    writer.WriteLine(userreg);
                    writer.Close();
                }
            


        }


        private void ClientSaveBtn_Click(object sender, EventArgs e)
        {
            if(ClientNameTextbox.Text!=""&&ClientSurnameTextbox.Text!=""&&ClientNumMaskedTextBox.Text!=""&&ClientEmailTextbox.Text!=""&&AdressRichTextbox.Text!="")
            {
                lzd = new ListViewItem(ClientNameTextbox.Text);

                var surname = ClientSurnameTextbox.Text;
                var email = ClientEmailTextbox.Text;
                var phone = ClientNumMaskedTextBox.Text;
                var adress = AdressRichTextbox.Text;
                lzd.SubItems.Add(surname);
                lzd.SubItems.Add(email);
                lzd.SubItems.Add(phone);
                lzd.SubItems.Add(adress);
                CreateClient();
                this.Close();   
                
                MessageBox.Show("Client has added succesfully");
                

                
             

            }
            else
            {
                MessageBox.Show("All fields have to fill");
            }
            
        }
    }
}
