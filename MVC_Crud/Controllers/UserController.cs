using Microsoft.AspNetCore.Mvc;
using MVC_Crud.DataContext;
using MVC_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Crud.Controllers
{
    public class UserController : Controller
    {
        private readonly CrudDbContext _cruddbcontext;

        public UserController(CrudDbContext crudDbContext)
        {
            _cruddbcontext = crudDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User r)
        {
            if (ModelState.IsValid)
            {
                _cruddbcontext.Users.Add(r);
                _cruddbcontext.SaveChanges();
                return RedirectToAction("RegisteredUsers");
            }
            return View("Index");
        }
        public IActionResult RegisteredUsers()
        {
            return View(_cruddbcontext.Users.ToList());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var registerUser = _cruddbcontext.Users.FirstOrDefault(r => r.UserId == id);
            return View(registerUser);
        }
        [HttpPost]
        public IActionResult Edit(User r)
        {
            if (r == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _cruddbcontext.Update(r);
                _cruddbcontext.SaveChanges();
                return RedirectToAction("RegisteredUsers");

            }
            return View("Edit");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var register = _cruddbcontext.Users.FirstOrDefault(r => r.UserId == id);
            _cruddbcontext.Remove(register);
            _cruddbcontext.SaveChanges();
            return RedirectToAction("RegisteredUsers");
        }
    }
}
