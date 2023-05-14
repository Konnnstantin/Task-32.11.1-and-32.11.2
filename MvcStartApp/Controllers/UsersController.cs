﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcStartApp.Models;
using MvcStartApp.Models.Repository;
using MvcStartApp.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IBlogRepository _repo;
      
        public UsersController(IBlogRepository repo)
        {
            _repo = repo;
        }
       
        public async Task<IActionResult> Index()
        {
            var authors = await _repo.GetUsers();
           
            return View(authors);
        }
        [HttpPost]
        public async Task<IActionResult> Register(User newUser)
        {
            await _repo.AddUser(newUser);
            return View(newUser);
        }
        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }
    }
}
