using RaineVilla_Web.Models.Dto;

namespace RaineVilla_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAync<T>();
        Task<T> GetSync<T>(int id);
        Task<T> CreateAsync<T>(VillaCreateDTO dto);
        Task<T> DeleteAsync<T>(int id);
        Task<T> UpdateAsync<T>(VillaUpdateDTO dto);
    }
}
