using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Eventures.Data
{ 
    public class UserServiceModel : IdentityUser, IMapWith<User>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UniqueCitizenNumber { get; set; }

        public ICollection<OrderServiceModel> Orders { get; set; }
    }
}
