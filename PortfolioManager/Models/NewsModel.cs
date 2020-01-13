using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioManager.Models
{
    public class NewsModel
    {
        public int Id { get; set; }

        public string NewsTitle { get; set; }

        public string NewsContent { get; set; }

        public DateTime NewsPublishDate { get; set; }

        public string WrittenBy { get; set; }
    }
}
