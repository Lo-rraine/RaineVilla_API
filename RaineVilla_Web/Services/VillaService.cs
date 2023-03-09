using RaineVilla_Web.Models.Dto;
using RaineVilla_Web.Services.IServices;

namespace RaineVilla_Web.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;
        public VillaService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:villaAPI");
        }

        public Task<T> CreateAsync<T>(VillaCreateDTO dto, string token)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = RaineVilla_Utility.SD.ApiType.POST,
                Data = dto,
                Url = villaUrl + "/api/VillaApi",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = RaineVilla_Utility.SD.ApiType.DELETE,              
                Url = villaUrl + "/api/VillaApi/"+id,
                Token = token
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = RaineVilla_Utility.SD.ApiType.GET,
                Url = villaUrl + "/api/VillaApi",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = RaineVilla_Utility.SD.ApiType.GET,
                Url = villaUrl + "/api/VillaApi",
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto, string token)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = RaineVilla_Utility.SD.ApiType.PUT,
                Data = dto,
                Url = villaUrl + "/api/VillaApi/"+dto.Id,
                Token = token
            });
        }
    }
}
