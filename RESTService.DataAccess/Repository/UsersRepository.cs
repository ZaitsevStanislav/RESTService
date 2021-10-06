using RESTService.DataAccess.DatabaseContexts;
using RESTService.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace RESTService.DataAccess.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UsersDatabaseContext _context;

        public UsersRepository(UsersDatabaseContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
