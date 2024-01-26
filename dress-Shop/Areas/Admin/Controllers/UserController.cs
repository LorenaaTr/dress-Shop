﻿using DressShop.DataAccess.Data;
using DressShop.DataAccess.Repository.IRepository;
using DressShop.Models;
using DressShop.Models.ViewModels;
using DressShop.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

//////
namespace dress_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserController( ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// ////
        /// </summary>
        /// <returns></returns>
        
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<ApplicationUser> objUserList = _db.ApplicationUsers.Include(u=>u.Company).ToList();
            return Json(new { data = objUserList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            
            
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}
/// <summary>
/// ////
/// </summary>
/// <returns></returns>
