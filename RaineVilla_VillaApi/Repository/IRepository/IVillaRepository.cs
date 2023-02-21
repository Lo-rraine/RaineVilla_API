using RaineVilla_VillaApi.Models;
using System.Linq.Expressions;

namespace RaineVilla_VillaApi.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);      
    }
}
