﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioManager.Data;
using PortfolioManager.Models;
using PortfolioManager.Models.ViewModels;

namespace PortfolioManager.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getall")]
        public string GetAll()
        {

            var posts = _context.Posts.FirstOrDefault(x => x.Id.Equals(14))?.PostName;
            return posts;

        }
    }
}