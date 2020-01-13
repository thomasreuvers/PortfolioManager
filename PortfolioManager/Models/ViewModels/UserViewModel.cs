using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PortfolioManager.Models.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }

        public string Action { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public Task<IList<string>> UserRoles { get; set; }

        public string NewRole { get; set; }

        public bool IsApproved { get; set; }

    }
}
