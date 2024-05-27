using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class CreateAccountForm : Form
    {
        DataBaseConnection connect = new DataBaseConnection();
        CreateAccountClass account = new CreateAccountClass();
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text.Trim().Equals("") || textBox_password.Text == "" ||
                textBox_password.Text.Trim().Equals("") || textBox_password.Text == "" ||
                textBox_guestID.Text.Trim().Equals("") || textBox_guestID.Text == "" ||
                textBox_firstName.Text.Trim().Equals("") || textBox_firstName.Text == "" ||
                textBox_lastName.Text.Trim().Equals("") || textBox_lastName.Text == "" ||
                textBox_city.Text.Trim().Equals("") || textBox_city.Text == "" ||
                textBox_phone.Text.Trim().Equals("") || textBox_phone.Text == "" ||
                textBox_userID.Text.Trim().Equals("") || textBox_userID.Text == "")
            {
                MessageBox.Show("Enter all information", "Missing Create Account Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox_username.Text.Contains("Manager")|| textBox_username.Text.Contains("manager"))
                {
                    MessageBox.Show("Retry! You can't create a manager account!!!", "Ilegal Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button_clean.PerformClick();
                    return;
                }
                else
                {
                    try
                    {
                        if (account.insertGuest(textBox_guestID.Text,textBox_firstName.Text,textBox_lastName.Text,textBox_phone.Text,textBox_city.Text)==true && account.insertUser(textBox_userID.Text,textBox_username.Text,textBox_password.Text)==true)
                        {
                            MessageBox.Show("Account Created Successfully And Now Please Login With This Credentials", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button_clean.PerformClick();
                            this.Hide();
                            LoginForm login = new LoginForm();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Account Not Created Successfully", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                            button_clean.PerformClick();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_guestID.Clear();
            textBox_firstName.Clear();
            textBox_lastName.Clear();
            textBox_phone.Clear();
            textBox_city.Clear();
            textBox_userID.Clear();
            textBox_username.Clear();
            textBox_password.Clear();
        }
    }
}
