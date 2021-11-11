using Entities.Model.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RepoContext:DbContext
    {
        public RepoContext(DbContextOptions<RepoContext> dbContextOptions)
            :base(dbContextOptions)
        {

        }

        public DbSet<User> User { get; set; }
    }
}
