using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisces.Model;

namespace Pisces.Services.Users
{
    public interface IUserService
    {
        void AddUser(User model);
    }
}
