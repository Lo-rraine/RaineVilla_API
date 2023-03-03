using RaineVilla_Web.Models.Dto;
using RaineVilla_Web.Models;
using RaineVilla_Web.Services.IServices;
using RaineVilla_Utility;

namespace RaineVilla_Web.Services
{
    public class VillaNumberService : BaseService, IVillaNumberService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;
        public VillaNumberService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:villaAPI");
        }

        public Task<T> CreateAsync<T>(VillaNumberCreateDTO dto)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = RaineVilla_Utility.SD.ApiType.POST,
                Data = dto,
                Url = villaUrl + "api/VillaNumberApi"
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = RaineVilla_Utility.SD.ApiType.DELETE,              
                Url = villaUrl + "/api/VillaNumberApi/" + id
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = RaineVilla_Utility.SD.ApiType.GET,
                Url = villaUrl + "/api/VillaNumberApi"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = RaineVilla_Utility.SD.ApiType.GET,
                Url = villaUrl + "/api/VillaNumberApi"
            });
        }

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = RaineVilla_Utility.SD.ApiType.PUT,
                Data = dto,
                Url = villaUrl + "/api/VillaNumberApi/" + dto.VillaNo
            });
        }
    }
}
