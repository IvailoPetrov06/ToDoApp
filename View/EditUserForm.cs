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
using ToDoApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDoApp.View
{
    public partial class EditUserForm : Form
    {
        private UserController userController;
        private int userId;

        public EditUserForm(UserController controller, int userId)
        {
            InitializeComponent();
            this.userController = controller;
            this.userId = userId;
            LoadUserData();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {

            LoadUserData();
        }


        private void save_Click(object sender, EventArgs e)
        {
            // Get user input from the form
            string username = textBox1.Text;
            // Get other input fields as needed
            string password = textBox2.Text;
            string firstName = textBox3.Text;
            string lastName = textBox4.Text;

            // Update the user
            userController.UpdateUser(userId, username, password, firstName, lastName);

            MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form with OK result
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        private void LoadUserData()
        {
            User user = userController.GetUserById(userId);
            if (user != null)
            {
                textBox1.Text = user.Username;
                // Set other fields as needed
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
