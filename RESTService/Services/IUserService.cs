using RESTService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTService.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
