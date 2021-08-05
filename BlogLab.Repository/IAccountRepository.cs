using System;
using System.Threading;
using System.Threading.Tasks;
using BlogLab.models.Account;
using Microsoft.AspNetCore.Identity;

namespace BlogLab.Repository
{
    public interface IAccountRepository
    {

        public Task<IdentityResult> CreateAsync(ApplicationUserIdentity user,
            CancellationToken cancellationToken);

        public Task<ApplicationUserIdentity> GetByUsernameAscync(string normalizedUsername,
            CancellationToken cancellationToken);

    }
}
