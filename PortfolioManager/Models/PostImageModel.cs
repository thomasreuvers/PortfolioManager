using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioManager.Models
{
    public class PostImageModel
    {
        public int Id { get; set; }

        public string PostId { get; set; }

        public string UserId { get; set; }

        public string ImageUrl { get; set; }

        public string ImageFilePath { get; set; }
    }
}
