using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PortfolioManager.Views.Shared
{
    public class ManageNavPages
    {

            public static string Index => "Index";
            public static string News => "News";
            public static string Posts => "Posts";
            public static string Users => "Users";

            public static string Settings => "Settings";


            public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);
            public static string NewsNavClass(ViewContext viewContext) => PageNavClass(viewContext, News);
            public static string PostsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Posts);
            public static string UsersNavClass(ViewContext viewContext) => PageNavClass(viewContext, Users);
            public static string SettingsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Settings);

            public static string PageNavClass(ViewContext viewContext, string page)
            {
                var activePage = viewContext.ViewData["ActivePage"] as string
                    ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
                return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
            }
    }

}
