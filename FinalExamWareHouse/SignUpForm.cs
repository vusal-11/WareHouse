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
    public partial class SignUpForm : Form
    {

        bool flagpassword = false;
        bool flagrepassword =false;
        
        Size size = new Size(600, 600);
        public static User user = new User();
        public SignUpForm()
        {
            InitializeComponent();

            this.Size = size;

        }

     

        public void CreateUser()
        {

            User user = new User();
            user.UserName = textBoxsurnamesignup.Text;
            user.PassWord = textBoxpasswordsignup.Text;
            user.Name = textBoxnamesignup.Text;
            user.SurName = textBoxsurnamesignup.Text;
            user.clients = new();
            user.orders = new();
            string path = @$"../../../../Users\\{user.UserName}.json";
            if (!File.Exists(path))
            {
                var myfile = File.Create(path);

                myfile.Close();

                string userreg = JsonConvert.SerializeObject(user);

                using (StreamWriter writer = new StreamWriter(path))
                {

                    writer.WriteLine(userreg);
                    writer.Close();
                }
            }
            else
            {
                MessageBox.Show("This User is exist!!!");
                return;
            }


        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (textBoxnamesignup.Text != "" && textBoxpasswordsignup.Text != "" && textBoxusernamesignup.Text != "" && textBoxrepassword.Text != "" && textBoxsurnamesignup.Text != "")
            {
                if (textBoxpasswordsignup.Text == textBoxrepassword.Text)
                {
                    CreateUser();
                    MessageBox.Show("The user register succesfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password and Repassword have to be the same");
                    return;
                }

            }
            else
            {
                MessageBox.Show("All the fields have to be filled");
                return;
            }
        }

        private void passwordbutton_Click(object sender, EventArgs e)
        {
            if (!flagpassword)
            {
                textBoxpasswordsignup.PasswordChar -='●';
                flagpassword = true;
            }
            else if(flagpassword)
            {
                textBoxpasswordsignup.PasswordChar ='●';
                flagpassword = false;
            }
        }

        private void repasswordbutton_Click(object sender, EventArgs e)
        {
            if (!flagrepassword)
            {
                textBoxrepassword.PasswordChar -='●';
                flagrepassword = true;
            }
            else if (flagrepassword)
            {
                textBoxrepassword.PasswordChar ='●';
                flagrepassword = false;
            }
        }
    }
}
