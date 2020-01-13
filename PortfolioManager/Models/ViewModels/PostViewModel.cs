using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioManager.Models.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }

        public string PostName { get; set; }

        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public string Action { get; set; }
    }
}
