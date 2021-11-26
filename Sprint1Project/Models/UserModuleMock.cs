using Sprint1Project.Interface;
using System.Collections.Generic;
using Microsoft.OData.Edm;
using System.Linq;

namespace Sprint1Project.Models
{
    public class UserModuleMock : IUserModule
    {

        private static List<UserModule> users = new List<UserModule>(); 
        private int count=4;
        public UserModuleMock()
        {
            users.Add(new UserModule() { Id = 1, FirstName = "John", LastName = "Snow", Email = "john@gmail.com", Password = "abcd" });
            users.Add(new UserModule() { Id = 2, FirstName = "sansa", LastName = "Stark", Email = "sansa@gmail.com", Password = "abcd" });
            users.Add(new UserModule() { Id = 3, FirstName = "arya", LastName = "Stark", Email = "arya@gmail.com", Password = "abcd" });
            users.Add(new UserModule() { Id = 4, FirstName = "rob", LastName = "Stark", Email = "rob@gmail.com", Password = "abcd" });
        }
        public UserModule AddUser(UserModule user)
        {
            user.Id = ++count;
            users.Add(user);
            return user;
        }

        public void DeleteUser(int id)
        {
          UserModule user = GetUserById(id);
          users.Remove(user);
        }

        public List<UserModule> GetAllUsers()
        {
            return users;
        }

        public UserModule GetUserById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }

        public UserModule UpdateUser(int id)
        {
            
            UserModule user = GetUserById(id);
            user.Id = id;
            users.Remove(user);
            users.Add(user);
            return user;
        }
    }
}
