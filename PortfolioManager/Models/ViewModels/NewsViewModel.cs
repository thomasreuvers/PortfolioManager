using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioManager.Models.ViewModels
{
    public class NewsViewModel
    {
        public int Id { get; set; }

        public string NewsTitle { get; set; }

        public string NewsContent { get; set; }

        public DateTime NewsPublishDate { get; set; }

        public string WrittenBy { get; set; }

        public string Action { get; set; }
    }
}
