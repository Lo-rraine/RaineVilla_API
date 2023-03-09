using Microsoft.AspNetCore.Identity;

namespace RaineVilla_VillaApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
