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
            // Get user input from the form
            string username = textBox1.Text;
            // Get other input fields as needed
            string password = textBox2.Text;
            string firstName = textBox3.Text;
            string lastName = textBox4.Text;

            // Create the user
            userController.CreateUser(username, password, firstName, lastName);

            MessageBox.Show("User created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form with OK result
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
    }
}
