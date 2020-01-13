using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioManager.Models.ViewModels
{
    public class IndexViewModel
    {
        public PostViewModel RecentPost { get; set; } = new PostViewModel();

        public NewsViewModel RecentNews { get; set; } = new NewsViewModel();

        public List<PostViewModel> PostItems { get; set; }

        public List<NewsViewModel> NewsItems { get; set; }
    }
}
