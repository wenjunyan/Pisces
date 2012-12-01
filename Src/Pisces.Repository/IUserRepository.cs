using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisces.Infrastructure.Domain;
using Pisces.Model;

namespace Pisces.Repository
{
    public interface IUserRepository : IRepository<User, int>
    {
    }
}
