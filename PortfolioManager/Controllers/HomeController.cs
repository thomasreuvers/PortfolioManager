using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Query.ExpressionTranslators.Internal;
using PortfolioManager.Data;
using PortfolioManager.Models;
using PortfolioManager.Models.ViewModels;
using Remotion.Linq.Utilities;

namespace PortfolioManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly PasswordHasher<ApplicationUser> _passwordHasher;
        private readonly Random _random = new Random();

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, PasswordHasher<ApplicationUser> passwordHasher)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _passwordHasher = passwordHasher;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IActionResult Index()
        {
            var mostRecentPost = _context.Posts.OrderByDescending(p => p.PublishDate)
                .FirstOrDefault(p => p.UserId.Equals(this.User.FindFirstValue(ClaimTypes.NameIdentifier)));

            var mostRecentNews = _context.News.OrderByDescending(n => n.NewsPublishDate).FirstOrDefault();

            var indexViewModel = new IndexViewModel();

            //! Check if the most recent post is null if so, return a example post
            if (mostRecentPost != null)
            {
                indexViewModel.RecentPost.PostName = mostRecentPost.PostName;
                indexViewModel.RecentPost.Content = mostRecentPost.Content;
                indexViewModel.RecentPost.PublishDate = mostRecentPost.PublishDate;
            }
            else
            {
                indexViewModel.RecentPost.PostName = "Example Post";
                indexViewModel.RecentPost.Content = "You don't have any posts to display. Go ahead and create one!";
                indexViewModel.RecentPost.PublishDate = DateTime.Now;
            }

            //! Check if the most recent news is null if so, return example news
            if (mostRecentNews != null)
            {
                indexViewModel.RecentNews.NewsTitle = mostRecentNews.NewsTitle;
                indexViewModel.RecentNews.NewsContent = mostRecentNews.NewsContent;
                indexViewModel.RecentNews.NewsPublishDate = mostRecentNews.NewsPublishDate;
                indexViewModel.RecentNews.WrittenBy = mostRecentNews.WrittenBy;
            }
            else
            {
                indexViewModel.RecentNews.NewsTitle = "Example News";
                indexViewModel.RecentNews.NewsContent = "Why do you see this? Probably because there is no news yet, OR something went terribly wrong.";
                indexViewModel.RecentNews.NewsPublishDate = DateTime.Now;
                indexViewModel.RecentNews.WrittenBy = "TCMS";
            }

            ViewBag.IsApproved = IsUserApproved();

            return View(indexViewModel);
        }

        #region Posts

        /*
         * Get posts by userid and display them on page
         */
        public IActionResult Posts()
        {
            if (IsUserApproved())
            {
                var postModels = _context.Posts.Where(p => p.UserId.Equals(this.User.FindFirstValue(ClaimTypes.NameIdentifier))).ToList();
                var viewModels = postModels.Select(post => new PostViewModel { Id = post.Id, Content = post.Content.Replace("<br />", "\r\n"), PostName = post.PostName, PublishDate = post.PublishDate, MainImageFilePath = post.MainImageFilePath != null ? post.MainImageFilePath.Replace($"{Request.Host}", "") : "" }).ToList();

                return View(viewModels);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Posts(PostViewModel viewModel)
        {
            if (IsUserApproved())
            {
                if (ModelState.IsValid)
                {

                    if (viewModel.Action.Equals("delete"))
                    {
                        var model = _context.Posts.FirstOrDefault(p =>
                            p.Id == viewModel.Id && p.UserId == this.User.FindFirstValue(ClaimTypes.NameIdentifier));

                        if (model != null)
                        {
                            _context.Posts.Remove(model);

                            // Delete old profile picture if exists
                            if (!string.IsNullOrWhiteSpace(model.MainImageUrl))
                            {
                                if (System.IO.File.Exists(model.MainImageFilePath))
                                {
                                    System.IO.File.Delete(model.MainImageFilePath);
                                }
                            }

                            _context.SaveChanges();
                            ViewBag.IsSuccess = true;
                        }
                        else
                        {
                            ViewBag.IsSuccess = false;
                        }
                    }
                    else if (viewModel.Action.Equals("create"))
                    {
                        if (!string.IsNullOrWhiteSpace(viewModel.PostName) && !string.IsNullOrWhiteSpace(viewModel.Content))
                        {

                            var model = new PostModel
                            {
                                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                                UserName = User.Identity.Name,
                                PostName = viewModel.PostName,
                                Content = viewModel.Content.Replace("\r\n", "<br />"),
                                PublishDate = DateTime.Now
                            };

                            if (viewModel.MainImage != null)
                            {
                                if (!UploadedFileIsImage(viewModel.MainImage))
                                {
                                    ViewBag.isSuccess = false;
                                    return View();
                                }

                                var extension = viewModel.MainImage.FileName.Split('.')[1];
                                var imageName = RandomString(8) + $".{extension}";

                                var savePath = Path.Combine(@"C:\Userdata\images", imageName);

                                using (var stream = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                                {
                                    viewModel.MainImage.CopyTo(stream);
                                }

                                model.MainImageUrl = $"{Request.Host}/Userdata/images/{imageName}";
                                model.MainImageFilePath = savePath;
                            }

                            _context.Posts.Add(model);
                            _context.SaveChanges();
                            ViewBag.IsSuccess = true;
                        }
                        else
                        {
                            // If we got here both required strings are empty or whitespace
                            ViewBag.IsSuccess = false;
                        }
                    }
                    else if (viewModel.Action.Equals("edit"))
                    {
                        var postInDb = _context.Posts.FirstOrDefault(p =>
                            p.Id == viewModel.Id && p.UserId == this.User.FindFirstValue(ClaimTypes.NameIdentifier));

                        if (postInDb != null)
                        {
                            postInDb.PostName = viewModel.PostName;
                            postInDb.Content = viewModel.Content.Replace("\r\n", "<br />");

                            #region MainImage

                            if (viewModel.MainImage != null)
                            {
                                if (!UploadedFileIsImage(viewModel.MainImage))
                                {
                                    ViewBag.isSuccess = false;
                                    return View();
                                }

                                // Delete old profile picture if exists
                                if (!string.IsNullOrWhiteSpace(postInDb.MainImageUrl))
                                {
                                    if (System.IO.File.Exists(postInDb.MainImageFilePath))
                                    {
                                        System.IO.File.Delete(postInDb.MainImageFilePath);
                                    }
                                }

                                var extension = viewModel.MainImage.FileName.Split('.')[1];
                                var imageName = RandomString(8) + $".{extension}";

                                var savePath = Path.Combine(@"C:\Userdata\images", imageName);

                                using (var stream = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                                {
                                    viewModel.MainImage.CopyTo(stream);
                                }

                                postInDb.MainImageUrl = $"{Request.Host}/Userdata/images/{imageName}";
                                postInDb.MainImageFilePath = savePath;
                            }


                            #endregion

                            _context.SaveChanges();
                            ViewBag.IsSuccess = true;
                        }
                        else
                        {
                            ViewBag.IsSuccess = false;
                        }
                    }
                }
                var postModels = _context.Posts.Where(p => p.UserId.Equals(this.User.FindFirstValue(ClaimTypes.NameIdentifier))).ToList();
                var viewModels = postModels.Select(post => new PostViewModel { Id = post.Id, Content = post.Content.Replace("<br />", "\r\n"), PostName = post.PostName, PublishDate = post.PublishDate, MainImageFilePath = post.MainImageFilePath != null ? post.MainImageFilePath.Replace($"{Request.Host}", "") : "" }).ToList();

                return View(viewModels);
            }

            return RedirectToAction("Index", "Home");
        }

        #endregion

        #region News

        [Authorize(Roles = "Admin")]
        public IActionResult News()
        {
            if (IsUserApproved())
            {
                var newsModels = _context.News.ToList();
                var viewModels = newsModels.Select(news => new NewsViewModel() { Id = news.Id, NewsTitle = news.NewsTitle, NewsContent = news.NewsContent.Replace("<br />", "\r\n"), WrittenBy = news.WrittenBy, NewsPublishDate = news.NewsPublishDate }).OrderByDescending(n => n.NewsPublishDate).ToList();

                return View(viewModels);
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult News(NewsViewModel viewModel)
        {
            if (IsUserApproved())
            {
                if (ModelState.IsValid)
                {
                    if (viewModel.Action.Equals("delete"))
                    {
                        var model = _context.News.FirstOrDefault(n => n.Id.Equals(viewModel.Id));

                        if (model != null)
                        {
                            _context.News.Remove(model);
                            _context.SaveChanges();
                            ViewBag.IsSuccess = true;
                        }
                        else
                        {
                            ViewBag.IsSuccess = false;
                        }
                    }
                    else if (viewModel.Action.Equals("create"))
                    {
                        if (!string.IsNullOrWhiteSpace(viewModel.NewsTitle) && !string.IsNullOrWhiteSpace(viewModel.NewsContent))
                        {
                            var model = new NewsModel
                            {
                                WrittenBy = User.Identity.Name,
                                NewsTitle = viewModel.NewsTitle,
                                NewsContent = viewModel.NewsContent.Replace("\r\n", "<br />"),
                                NewsPublishDate = DateTime.Now
                            };
                            _context.News.Add(model);
                            _context.SaveChanges();
                            ViewBag.IsSuccess = true;
                        }
                        else
                        {
                            // If we got here both required strings are empty or whitespace
                            ViewBag.IsSuccess = false;
                        }
                    }
                    else if (viewModel.Action.Equals("edit"))
                    {
                        var newsInDb = _context.News.FirstOrDefault(n => n.Id.Equals(viewModel.Id));

                        if (newsInDb != null)
                        {
                            newsInDb.NewsTitle = viewModel.NewsTitle;
                            newsInDb.NewsContent = viewModel.NewsContent.Replace("\r\n", "<br />");
                            _context.SaveChanges();
                            ViewBag.IsSuccess = true;
                        }
                        else
                        {
                            ViewBag.IsSuccess = false;
                        }
                    }
                }
                var newsModels = _context.News.ToList();
                var viewModels = newsModels.Select(news => new NewsViewModel() {Id = news.Id, NewsTitle = news.NewsTitle, NewsContent = news.NewsContent.Replace("<br />", "\r\n"), WrittenBy = news.WrittenBy, NewsPublishDate = news.NewsPublishDate }).OrderByDescending(n => n.NewsPublishDate).ToList();

                return View(viewModels);
            }

            return RedirectToAction("Index", "Home");
        }

        #endregion

        #region Users

        [Authorize(Roles = "Admin")]
        public IActionResult Users()
        {
            var usersInDb = _context.Users.Where(x => x.Id != this.User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList();
            ViewBag.Roles = _roleManager.Roles.ToList();

            var listOfUsers = new List<UserViewModel>();

            foreach (var user in usersInDb)
            {
                listOfUsers.Add(new UserViewModel
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    UserRoles = _userManager.GetRolesAsync(user),
                    IsApproved = user.IsApproved
                });
            }

            return View(listOfUsers);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Users(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Action.Equals("approval"))
                {
                    var userInDb = _context.Users.FirstOrDefault(x => x.Id == model.Id);

                    if (userInDb != null)
                    {
                        userInDb.IsApproved = true;

                        _context.SaveChanges();

                        ViewBag.IsSuccess = true;
                    }
                    else
                    {
                        ViewBag.IsSuccess = false;
                    }
                    
                }
                else if (model.Action.Equals("unapproval"))
                {
                    var userInDb = _context.Users.FirstOrDefault(x => x.Id == model.Id);

                    if (userInDb != null)
                    {
                        userInDb.IsApproved = false;

                        _context.SaveChanges();

                        ViewBag.IsSuccess = true;
                    }
                    else
                    {
                        ViewBag.IsSuccess = false;
                    }
                }
                else if (model.Action.Equals("delete"))
                {
                    var userInDb = _context.Users.FirstOrDefault(x => x.Id == model.Id);
                    var userPosts = _context.Posts.Where(x => x.UserId.Equals(model.Id)).ToList();

                    if (userInDb != null)
                    {
                        // Delete old profile picture if exists
                        if (!string.IsNullOrWhiteSpace(userInDb.ImageFileName))
                        {
                            if (System.IO.File.Exists(userInDb.ImageFilePath))
                            {
                                System.IO.File.Delete(userInDb.ImageFilePath);
                            }
                        }

                        if (userPosts != null && userPosts.Count > 0)
                        {
                            foreach (var post in userPosts)
                            {
                                _context.Posts.Remove(post);
                            }
                        }

                        _context.Users.Remove(userInDb);

                        _context.SaveChanges();
                        ViewBag.IsSuccess = true;
                    }
                    else
                    {
                        ViewBag.IsSuccess = false;
                    }
                }
                else if (model.Action.Equals("edit"))
                {
                    var userInDb = _context.Users.FirstOrDefault(x => x.Id == model.Id);

                    if (userInDb != null)
                    {

                        if (model.NewRole != null)
                        {
                            if (_roleManager.FindByIdAsync(model.NewRole).Result != null)
                            {
                                var role = _roleManager.FindByIdAsync(model.NewRole).Result;
                               await _userManager.AddToRoleAsync(userInDb, role.Name);
                            }
                            else if (model.NewRole.Equals("None"))
                            {
                                await _userManager.RemoveFromRolesAsync(userInDb, _userManager.GetRolesAsync(userInDb).Result);
                            }
                        }

                        userInDb.UserName = model.UserName;
                        userInDb.Email = model.Email;

                        _context.SaveChanges();
                        ViewBag.IsSuccess = true;
                    }
                    else
                    {
                        ViewBag.IsSuccess = false;
                    }
                }
            }

            var usersInDb = _context.Users.Where(x => x.Id != this.User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList();

            var listOfUsers = new List<UserViewModel>();
            ViewBag.Roles = _roleManager.Roles.ToList();

            foreach (var user in usersInDb)
            {
                listOfUsers.Add(new UserViewModel
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    UserRoles = _userManager.GetRolesAsync(user),
                    IsApproved = user.IsApproved
                });
            }

            return View(listOfUsers);
        }

        #endregion

        #region Settings

        public IActionResult Settings()
        {
            var user = _context.Users.FirstOrDefault(x => x.Id.Equals(this.User.FindFirstValue(ClaimTypes.NameIdentifier)));
            var model = new SettingsViewModel();

            if (user == null) return View(model);

            model.Username = user.UserName;
            model.Email = user.Email;

            if (!string.IsNullOrWhiteSpace(user.ImageFileName))
            {
                model.ImageFileName = user.ImageFileName;
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Settings(SettingsViewModel viewModel)
        {
            var model = new SettingsViewModel();
            var user = _context.Users.FirstOrDefault(x => x.Id.Equals(this.User.FindFirstValue(ClaimTypes.NameIdentifier)));

            if (user != null)
            {
                if (viewModel.ProfilePicture != null)
                {
                    // Delete old profile picture if exists
                    if (!string.IsNullOrWhiteSpace(user.ImageFileName))
                    {
                        if (System.IO.File.Exists(user.ImageFilePath))
                        {
                            System.IO.File.Delete(user.ImageFilePath);
                        }
                    }

                    var extension = viewModel.ProfilePicture.FileName.Split('.')[1];
                    var imageName = RandomString(8) + $".{extension}";

                    if (!UploadedFileIsImage(viewModel.ProfilePicture))
                    {
                        return View(model);
                    }

                    var savePath = Path.Combine(@"C:\Userdata\images", imageName);

                    using (var stream = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                    {
                        viewModel.ProfilePicture.CopyTo(stream);
                    }

                    user.ImageFileName = $"Userdata/images/{imageName}";
                    user.ImageFilePath = savePath;
                    _context.SaveChanges();
                }

                if (viewModel.Email != null)
                {
                    user.Email = viewModel.Email;
                    _context.SaveChanges();
                }

                model.Username = user.UserName;

                if (!string.IsNullOrWhiteSpace(user.ImageFileName))
                {
                    model.ImageFileName = user.ImageFileName;
                }

                ViewBag.IsSuccess = true;

                if (viewModel.OldPassword == null || viewModel.NewPassword == null) return View(model);

                if (_passwordHasher.VerifyHashedPassword(new ApplicationUser(), user.PasswordHash, viewModel.OldPassword) == PasswordVerificationResult.Success)
                {
                    user.PasswordHash = _passwordHasher.HashPassword(new ApplicationUser(), viewModel.NewPassword);
                    //TODO: SEND MAIL
                    _context.SaveChanges();
                }
                else
                {
                    ViewBag.IsSuccess = false;
                }
            }

            return View(model);
        }

        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /*
         * This method checks if the current user is approved
         */
        public bool IsUserApproved()
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == this.User.FindFirstValue(ClaimTypes.NameIdentifier));
            return user != null && user.IsApproved;
        }

        /*
         * This method returns a random string with a length of given
         */
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }

        /*
         * This method checks if a uploaded file is an image
         */
        public bool UploadedFileIsImage(IFormFile file)
        {
            // check file mimetype
            if (!string.Equals(file.ContentType, "image/jpg", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(file.ContentType, "image/jpeg", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(file.ContentType, "image/pjpeg", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(file.ContentType, "image/gif", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(file.ContentType, "image/x-png", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(file.ContentType, "image/png", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            // Check file extension
            var postedFileExtension = Path.GetExtension(file.FileName);
            if (!string.Equals(postedFileExtension, ".jpg", StringComparison.OrdinalIgnoreCase)
                && !string.Equals(postedFileExtension, ".png", StringComparison.OrdinalIgnoreCase)
                && !string.Equals(postedFileExtension, ".gif", StringComparison.OrdinalIgnoreCase)
                && !string.Equals(postedFileExtension, ".jpeg", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            return true;
        }
    }
}
