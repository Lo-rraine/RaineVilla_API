﻿using Microsoft.AspNetCore.Mvc;
using RaineVilla_Web.Services.IServices;
using AutoMapper;
using Newtonsoft.Json;
using RaineVilla_Web.Services;
using RaineVilla_Web.Models.Dto;
using RaineVilla_Web.Models;

namespace RaineVilla_Web.Controllers
{
    public class VillaNumberController : Controller
    {
        private readonly IVillaNumberService _villaNumberService;
        private readonly IMapper _mapper;

        public VillaNumberController(IVillaNumberService villaNumberService, IMapper mapper)
        {
            _villaNumberService= villaNumberService;
            _mapper= mapper;
        }

        public async Task<IActionResult> IndexVillaNumber()
        {
            List<VillaNumberDTO> list = new();

            var response = await _villaNumberService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaNumberDTO>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
    }
}
