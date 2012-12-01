using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisces.Model;

namespace Pisces.Repository.NHibernate.Repositories
{
    public class UserRepository : Repository<User, int>, IUserRepository
    {
    }
}
