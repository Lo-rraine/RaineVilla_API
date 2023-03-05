using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using RaineVilla_Web.Models.Dto;

namespace RaineVilla_Web.Models.VM
{
    public class VillaNumberCreate
    {
        public VillaNumberCreate() {
            VillaNumber = new VillaNumberCreateDTO();
        }

        public VillaNumberCreateDTO VillaNumber { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> VillaList { get; set; }
    }
}
