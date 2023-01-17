using System.ComponentModel.DataAnnotations;

namespace RaineVilla_VillaApi.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
