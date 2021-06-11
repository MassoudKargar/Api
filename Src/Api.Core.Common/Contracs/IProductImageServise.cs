using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Api.Core.Common.Contracs
{
    public interface IProductImageServise
    {
        Task<string> SaveImageAcync(IFormFile file);
    }
}
