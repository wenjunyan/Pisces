using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisces.Infrastructure.Domain;

namespace Pisces.Model
{
    public class User : EntityBase<int>
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
    }
}
