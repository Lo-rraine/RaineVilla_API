using RaineVilla_VillaApi.Models;
using System.Linq.Expressions;

namespace RaineVilla_VillaApi.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);      
    }
}
