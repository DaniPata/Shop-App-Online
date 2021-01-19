using AccesAut1.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesAut1.Services
{


    public interface IAuthenticationServicee
    {
        public User CreateUser(string username, string email, string phonenumber, string firstname, string lastname, string city, string country, string county /*IFormFile photo*/);
        public Task<SignInResult> Login(string username, string password, bool rememberMe, bool lockoutOnFailure);
        public Task<IdentityResult> Register(User user, string password);
        public Task Logout();


    }

}
