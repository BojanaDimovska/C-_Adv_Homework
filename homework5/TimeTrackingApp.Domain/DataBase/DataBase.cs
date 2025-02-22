﻿using System.Collections.Generic;
using TimeTrackingApp.Domain.Classes;
using System.Linq;

namespace TimeTrackingApp.Domain.DataBase
{
    public class Database<T> : IDataBase<T> where T : User
    {
        private List<T> _users { get; set; }
        public int Id { get; set; }
        public Database()
        {
            _users = new List<T>();
            Id = 1;
        }
        public void InsertUser(T user)
        {
            user.Id = Id++;
            _users.Add(user);
        }

        public User RemoveUser(User removedUser)
        {
            User user = _users.FirstOrDefault(x => x.Id == removedUser.Id);
            user.AccountActivity = false;
            return user;
        }
        public User ActivateAccount(User activatedUser)
        {
            User user = _users.FirstOrDefault(x => x.Id == activatedUser.Id);
            user.AccountActivity = true;
            return user;
        }

        public void UpdateUser(T user)
        {
            User oldUser = _users.FirstOrDefault(u => u.Id == user.Id);
            oldUser = user;
        }

        public User CheckUser(string username, string password)
        {
            User user = _users.FirstOrDefault(x => x.Username == username && x.Password == password);
            return user;
        }
    }
}
