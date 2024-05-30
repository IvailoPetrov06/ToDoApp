using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.Controller;
using ToDoApp.View;

namespace ToDoApp
{
    public partial class LoginForm : Form
    {
        private UserController userController;
        public LoginForm(UserController controller)
        {
            InitializeComponent();
            this.userController = controller;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;


            bool isAuthenticated = userController.ValidateCredentials(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful! Welcome, " + username + ".");

                if (userController.IsAdmin)
                {
                    OpenUsersManagementView();
                }
                else
                {
                    MessageBox.Show("You don't have permission to access this view.");
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void OpenUsersManagementView()
        {
            UsersManagementForm usersManagementForm = new UsersManagementForm(userController);
            usersManagementForm.ShowDialog();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
