using RESTService.DataAccess.Models;
using System.Collections.Generic;

namespace RESTService.DataAccess.Repository
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetUsers();
        void AddUser(User user);
    }
}
