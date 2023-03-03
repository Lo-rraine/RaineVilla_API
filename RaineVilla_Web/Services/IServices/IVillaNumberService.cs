﻿using RaineVilla_Web.Models.Dto;

namespace RaineVilla_Web.Services.IServices
{
    public interface IVillaNumberService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(VillaNumberCreateDTO dto);
        Task<T> DeleteAsync<T>(int id);
        Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto);
    }
}
