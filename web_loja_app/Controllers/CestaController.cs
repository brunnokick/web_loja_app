﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_loja_app.Controllers
{
    public class CestaController : Controller
    {
        // GET: Cesta
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cesta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cesta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cesta/Create
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

        // GET: Cesta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cesta/Edit/5
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

        // GET: Cesta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cesta/Delete/5
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
