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

namespace ToDoApp.View
{
    public partial class UsersManagementForm : Form
    {
        private UserController userController;

        public UsersManagementForm(UserController controller)
        {
            InitializeComponent();
            this.userController = controller;
            LoadUsers();
        }

        public UsersManagementForm()
        {
        }

        private void UsersManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {
            List<User> users = userController.GetAllUsers();

            dataGridView1.Rows.Clear();

            foreach (User user in users)
            {
                dataGridView1.Rows.Add(user.Id, user.Username);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm(userController);
            if (createUserForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers(); // Reload users data into DataGridView
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if a user is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            // Get the selected user ID
            int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            // Open a form or dialog to edit the selected user
            EditUserForm editUserForm = new EditUserForm(userController, userId);
            if (editUserForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers(); // Reload users data into DataGridView
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            // Get the selected user ID
            int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            // Confirm deletion with the user
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Call the DeleteUser method
                userController.DeleteUser(userId);

                // Display success message
                MessageBox.Show("User deleted successfully.");

                // Reload users data into DataGridView
                LoadUsers();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
