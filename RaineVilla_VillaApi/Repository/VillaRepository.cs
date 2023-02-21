using Microsoft.EntityFrameworkCore;
using RaineVilla_VillaApi.Data;
using RaineVilla_VillaApi.Models;
using RaineVilla_VillaApi.Repository.IRepository;
using System.Linq.Expressions;

namespace RaineVilla_VillaApi.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
