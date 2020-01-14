using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PortfolioManager.Models
{
    public class PostModel
    {
        public int Id { get; set; }

        public  string UserId { get; set; }

        public string UserName { get; set; }

        public string PostName { get; set; }

        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public string UserKey { get; set; }

        public string MainImageFilePath { get; set; }

        public string MainImagePath { get; set; }
    }
}
