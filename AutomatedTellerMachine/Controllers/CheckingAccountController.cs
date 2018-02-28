using AutomatedTellerMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class CheckingAccountController : Controller
    {
        // GET: CheckingAccountModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: CheckingAccountModel/Details/5
        public ActionResult Details()
        {
            var checkingAccount = new CheckingAccountModel { AccountNumber = "000213245", FirstName = "Holger", LastName = "Trankjær", Balance = 453 };
            return View(checkingAccount);
        }

        // GET: CheckingAccountModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckingAccountModel/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckingAccountModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckingAccountModel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckingAccountModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckingAccountModel/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
