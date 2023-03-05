
using RaineVilla_VillaApi.Models;
using RaineVilla_VillaApi.Models.Dto;

namespace RaineVilla_VillaApi.Repository.IRepository
{
    public interface IUserRepository
    {
        bool isUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDTO);
    }
}
