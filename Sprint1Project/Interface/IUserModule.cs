using Sprint1Project.Models;
using System.Collections.Generic;

namespace Sprint1Project.Interface
{
    public interface IUserModule
    {

        List<UserModule> GetAllUsers();
        UserModule GetUserById(int id);
        UserModule AddUser(UserModule user);
        UserModule UpdateUser(int id);
        void DeleteUser(int id);


    }
}
