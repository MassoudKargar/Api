using System.Threading.Tasks;
using Api.Core.Common.Models;
using Api.Domain.Commands.Products;

namespace Api.Application.Contracts
{
    public interface IAddProductCommandFactory
    {
        Task<AddProductCommand> CreateAsync(AddProductCommandModels model);
    }
}
