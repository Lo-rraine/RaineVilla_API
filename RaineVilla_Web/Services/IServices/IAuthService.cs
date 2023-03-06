using RaineVilla_Web.Models.Dto;

namespace RaineVilla_Web.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO objTocreate);
        Task<T> RegisterAsync<T>(RegistrationRequestDTO objTocreate);
    }
}
