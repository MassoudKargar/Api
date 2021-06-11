using System.Threading.Tasks;
using Api.Domain.Contracts.Repositories;
using Api.Domain.Models.Users;
using Api.Infrastructure.SqlContext;

namespace Api.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(Context context)
        {
            Context = context;
        }

        private Context Context { get; }
        async Task<AppUser> IUserRepository.Get(int userId)
        {
            return await Context.AppUsers.FindAsync(userId);
        }

        void IUserRepository.Save(AppUser appUser)
        {
            Context.AppUsers.Update(appUser);
        }
    }
}
