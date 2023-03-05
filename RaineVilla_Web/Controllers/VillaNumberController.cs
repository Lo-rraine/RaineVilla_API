using Microsoft.AspNetCore.Mvc;
using RaineVilla_Web.Services.IServices;
using AutoMapper;
using Newtonsoft.Json;
using RaineVilla_Web.Services;
using RaineVilla_Web.Models.Dto;
using RaineVilla_Web.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using RaineVilla_Web.Models.VM;

namespace RaineVilla_Web.Controllers
{
    public class VillaNumberController : Controller
    {
        private readonly IVillaNumberService _villaNumberService;
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;

        public VillaNumberController(IVillaNumberService villaNumberService, IMapper mapper, IVillaService villaService)
        {
            _villaNumberService = villaNumberService;
            _mapper = mapper;
            _villaService = villaService;
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

        public async Task<IActionResult> CreateVillaNumber()
        {
            VillaNumberCreate villaNumberVM = new();
            var response = await _villaService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                villaNumberVM.VillaList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result)).Select(i=> new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString(),
                });
            }
            return View(villaNumberVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> createVillaNumber(VillaNumberCreate model)
        {
            if (ModelState.IsValid)
            {
                var response = await _villaNumberService.CreateAsync<APIResponse>(model.VillaNumber);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexVillaNumber));
                }
            }
            
            return View(model);
        }

        //public async Task<IActionResult> UpdateVillaNumber(int villaId)
        //{
        //    var response = await _villaService.GetAsync<APIResponse>(villaId);
        //    if (response != null && response.IsSuccess)
        //    {
        //        List<VillaDTO> models = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
        //        VillaDTO model = models.FirstOrDefault(x => x.Id == villaId);
        //        if (model != null)
        //        {
        //            return View(_mapper.Map<VillaUpdateDTO>(model));
        //        }

        //    }

        //    return NotFound();

        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> UpdateVilla(VillaUpdateDTO model)
        //{
        //    var response = await _villaService.UpdateAsync<APIResponse>(model);
        //    if (response != null && response.IsSuccess)
        //    {
        //        return RedirectToAction(nameof(IndexVilla));
        //    }
        //    return View(model);
        //}

        //public async Task<IActionResult> DeleteVilla(int villaId)
        //{
        //    var response = await _villaService.GetAsync<APIResponse>(villaId);
        //    if (response != null && response.IsSuccess)
        //    {
        //        List<VillaDTO> models = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
        //        VillaDTO model = models.FirstOrDefault(x => x.Id == villaId);
        //        if (model != null)
        //        {
        //            return View(model);
        //        }

        //    }

        //    return NotFound();

        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteVilla(VillaDTO model)
        //{
        //    var response = await _villaService.DeleteAsync<APIResponse>(model.Id);
        //    if (response != null && response.IsSuccess)
        //    {
        //        return RedirectToAction(nameof(IndexVilla));
        //    }
        //    return View(model);
        //}
    }
}
