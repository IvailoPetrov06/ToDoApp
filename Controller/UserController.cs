using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Model;

namespace ToDoApp.Controller
{
    public class UserController
    {
        private List<User> users;
        public bool IsAdmin { get; private set; }

        public bool ValidateCredentials(string username, string password)
        {

            bool isValid = (username == "admin" && password == "adminpass");
            IsAdmin = isValid;
            return isValid;
        }
        public UserController()
        {
            // Initialize the list of users (simulate data from a database)
            users = new List<User>();
        }

        // Method to retrieve all users
        public List<User> GetAllUsers()
        {
            return users;
        }

        // Method to retrieve a user by ID
        public User GetUserById(int userId)
        {
            return users.Find(u => u.Id == userId);
        }

        // Method to create a new user
        public void CreateUser(string username, string password, string firstName, string lastName)
        {
            // Generate a unique ID for the new user
            int newUserId = users.Count + 1;

            // Create the new user object
            User newUser = new User
            {
                Id = newUserId,
                Username = username,
                Password = password,
               
            };

            // Add the new user to the list
            users.Add(newUser);
        }

        // Method to update an existing user
        public void UpdateUser(int userId, string username, string password, string firstName, string lastName)
        {
            // Find the user by ID
            User userToUpdate = users.Find(u => u.Id == userId);
            if (userToUpdate != null)
            {
                // Update the user's properties
                userToUpdate.Username = username;
                userToUpdate.Password = password;
                
            }
        }

        // Method to delete a user by ID
        public void DeleteUser(int userId)
        {
            // Find the index of the user in the list
            int index = users.FindIndex(u => u.Id == userId);
            if (index != -1)
            {
                // Remove the user from the list
                users.RemoveAt(index);
            }
        }
    }
}
