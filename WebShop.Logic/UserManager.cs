using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{

    public class UserManager
    {
        private int currentId = 1;
        private List<User> User;
        public List<User> GetAll()
        {
            return User;
        }
        public UserManager()
        {
            User = new List<User>();
        }
        public User Get(int id)
        {
            var user = User.Find(u => u.Id == id);
            return user;
        }
        public User GetByEmailAndPassword(string email, string password)
        {
            var user = User.Find(u => u.Email == email && u.Password == password);
            return user;
        }
        public User Create(User user)
        {
            user.Id = currentId;
            User.Add(user);
            currentId++;
            return user;
        }
        public User GetByEmail(string email)
        {
            var user = User.Find(u => u.Email == email);
            return user;
        }
        public void Delete(int id)
        {
            var user = User.Find(u => u.Id == id);
            User.Remove(user);
        }
        public void Update(User user)
        {
            var currentUser = User.Find(u => u.Id == user.Id);
            //properties to update
            currentUser.Email = user.Email;
            currentUser.Password = user.Password;
        }
        public void Seed()
        {
            User.Add(new User()
            {
                Id = 1,
                Email = "antons@gmail.com",
                Password = "12345"
            });
            User.Add(new User()
            {
                Id = 2,
                Email = "anna@gmail.com",
                Password = "12345"
            });

        }
    }
}
