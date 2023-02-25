using Microsoft.EntityFrameworkCore;
using RaineVilla_VillaApi.Data;
using RaineVilla_VillaApi.Models;
using RaineVilla_VillaApi.Repository.IRepository;
using System.Linq.Expressions;

namespace RaineVilla_VillaApi.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaNumberRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
