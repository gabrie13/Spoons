using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EightSpoons.Models;
using EightSpoons.Services;

namespace EightSpoons.Controllers
{
    public class RegisterController : Controller
    {
        private EightSpoonsDB db = new EightSpoonsDB();
        private readonly IRegisterService _registerService = new RegisterService();

        // GET: Register
        public ActionResult Index()
        {
            return View(_registerService.GetAll());
        }

        // GET: Register/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterViewModel register = _registerService.FindById(id.Value);
            if (register == null)
            {
                return HttpNotFound();
            }
            return View(register);
        }

        // GET: Register/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Register/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RegisterId,Cash,Check,Visa,MasterCard,Discover,Amex,GiftCard,Tax,CcTotal,Total")] RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                _registerService.Create(register);
                return RedirectToAction("Index");
            }

            return View(register);
        }

        // GET: Register/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterViewModel register = _registerService.FindById(id.Value);
            if (register == null)
            {
                return HttpNotFound();
            }
            return View(register);
        }

        // POST: Register/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RegisterId,Cash,Check,Visa,MasterCard,Discover,Amex,GiftCard,Tax,CcTotal,Total")] RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                _registerService.Save(register);
                return RedirectToAction("Index");
            }
            return View(register);
        }

        // GET: Register/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterViewModel register = _registerService.FindById(id.Value);
            if (register == null)
            {
                return HttpNotFound();
            }
            return View(register);
        }

        // POST: Register/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _registerService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
