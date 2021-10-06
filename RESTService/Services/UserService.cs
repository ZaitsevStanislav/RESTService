using RESTService.DataAccess.Repository;
using RESTService.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RESTService.Services
{
    public class UserService : IUserService
    {
        private readonly IUsersRepository userRepository;

        //List<User> _users = new List<User>
        //{
        //    new User
        //    {
        //        Id = 0,
        //        Name = "User1"
        //    },
        //    new User
        //    {
        //        Id = 1,
        //        Name = "User2"
        //    },
        //    new User
        //    {
        //        Id = 2,
        //        Name = "User3"
        //    }
        //};

        //public IEnumerable<User> GetUsers()
        //{
        //    return _users;
        //}

        //public void AddUser(User user)
        //{
        //    _users.Add(user);
        //}

        //public void UpdateUser(User user)
        //{
        //    var old = _users.FirstOrDefault(i => i.Id == user.Id);

        //    if(old == null)
        //    {
        //        throw new ArgumentException();
        //    }

        //    old.Name = user.Name;
        //}

        //public void DeleteUser(int id)
        //{
        //    var user = _users.FirstOrDefault(i => i.Id == id);

        //    if (user == null)
        //    {
        //        throw new ArgumentException();
        //    }

        //    _users.Remove(user);
        //}

        public UserService(IUsersRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            userRepository.AddUser(new DataAccess.Models.User { Id = user.Id, Name = user.Name }) ;
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetUsers().Select(i => new User { Id = i.Id, Name = i.Name }).ToArray();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
