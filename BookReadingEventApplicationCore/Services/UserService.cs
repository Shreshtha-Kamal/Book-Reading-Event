using DataAccessLayer;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserDataAccess userDataAccess;
        public UserService(IUserDataAccess userDataAccess)
        {
            this.userDataAccess = userDataAccess;
        }

        // user register and email exist or not.
        public bool Exist(User user)
        {
            DataAccessLayer.DatabaseModels.User userEmail = new DataAccessLayer.DatabaseModels.User()
            {
                Email = user.Email
            };
            return userDataAccess.Exist(userEmail);
        }
        public void RegisterUser(User user)
        {
            DataAccessLayer.DatabaseModels.User userData = new DataAccessLayer.DatabaseModels.User()
            {
                Email = user.Email,
                FullName = user.FullName,
                Password = user.Password

            };
            userDataAccess.RegisterUser(userData);

        }

        //Is valid user for login or not
        public bool Login(User user)
        {
            DataAccessLayer.DatabaseModels.User userData = new DataAccessLayer.DatabaseModels.User()
            {
                Email = user.Email,
                Password = user.Password
            };
            return userDataAccess.Login(userData);
        }

        // GetUserID of user
        public int GetUserID(string email)
        {
            return userDataAccess.GetUserID(email);
        }

        //To Get Roles
        public string GetRole(string email)
        {
            return userDataAccess.GetRole(email);
        }

        // IS Valid Role
        public bool IsValidRole(string role)
        {
            return userDataAccess.IsValidRole(role);
        }
    }
}
