using Microsoft.AspNetCore.Identity;

namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class User : IdentityUser<int>
    {

        // Navigation Properties
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;
        public Applicant Applicant { get; set; } = null!;
    }
}
