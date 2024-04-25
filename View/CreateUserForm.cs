using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.Controller;

namespace ToDoApp.View
{
    public partial class CreateUserForm : Form
    {
        private UserController userController;

        public CreateUserForm(UserController controller)
        {
            InitializeComponent();
            this.userController = controller;
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {

        }

        private void saves_Click(object sender, EventArgs e)
        {
            
            string username = textBox1.Text;
            string password = textBox2.Text;
            string firstName = textBox3.Text;
            string lastName = textBox4.Text;

        
            userController.CreateUser(username, password, firstName, lastName);

            MessageBox.Show("User is created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
