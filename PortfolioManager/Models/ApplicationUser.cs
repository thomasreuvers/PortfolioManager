using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PortfolioManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsApproved { get; set; }

        public string UserKey { get; set; }

        public string ImageFileName { get; set; }

        public string ImageFilePath { get; set; }
    }
}
