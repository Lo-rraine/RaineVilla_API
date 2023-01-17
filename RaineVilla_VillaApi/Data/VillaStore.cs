using RaineVilla_VillaApi.Models.Dto;

namespace RaineVilla_VillaApi.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList= new List<VillaDTO>
            {
                new VillaDTO { Id=1, Name="Uvongo Beach"},
                new VillaDTO {Id=2, Name="Shelly Beach"}
            };
    }
}
