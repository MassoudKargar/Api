using System.Threading.Tasks;
using Api.Domain.Models.Users;

namespace Api.Domain.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<AppUser> Get(int userId);
        void Save(AppUser appUser);
    }
}
