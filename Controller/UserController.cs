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
           
            users = new List<User>();
        }

       
        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserById(int userId)
        {
            return users.Find(u => u.Id == userId);
        }

     
        public void CreateUser(string username, string password, string firstName, string lastName)
        {
            
            int newUserId = users.Count + 1;

            
            User newUser = new User
            {
                Id = newUserId,
                Username = username,
                Password = password,
               
            };

            users.Add(newUser);
        }

      
        public void UpdateUser(int userId, string username, string password, string firstName, string lastName)
        {
         
            User userToUpdate = users.Find(u => u.Id == userId);
            if (userToUpdate != null)
            {
                
                userToUpdate.Username = username;
                userToUpdate.Password = password;
                
            }
        }

        public void DeleteUser(int userId)
        {
            
            int index = users.FindIndex(u => u.Id == userId);
            if (index != -1)
            {
                
                users.RemoveAt(index);
            }
        }
    }
}
