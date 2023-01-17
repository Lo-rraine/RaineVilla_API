using RaineVilla_VillaApi.Models.Dto;

namespace RaineVilla_VillaApi.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList= new List<VillaDTO>
            {
                new VillaDTO { Id=1, Name="Uvongo Beach", Occupancy=100, SquareFeet=1000},
                new VillaDTO {Id=2, Name="Shelly Beach", Occupancy=69, SquareFeet=5000}
            };
    }
}
