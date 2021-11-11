using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ManagerRepo:IManagerContract
    {
        private readonly RepoContext _repoContext;
        private IUserContract userContract;
        public ManagerRepo(RepoContext repoContext)
        {
            this._repoContext = repoContext ?? throw new ArgumentNullException(nameof(repoContext));
        }

        public IUserContract UserContract
        { 
            get
            {
                if(userContract == null)
                {
                    userContract = new UserRepo(_repoContext);
                }
                return userContract;
        }   }
    }
}
