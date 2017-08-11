using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SonOfCod.Models;
using SonOfCod.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCod.Controllers
{
    public class ContactController : Controller
    {
        private SonDbContext db = new SonDbContext();

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(NewContactView model)
        {
            Contact contact = new Contact();
            contact.Name = model.Name;
            contact.Email = model.Email;
            db.Contacts.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize]
        public IActionResult Contacts()
        {
            return View(db.Contacts.ToList());
        }

    }
}
