﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BoardGamesDirectory.Models;

namespace BoardGamesDirectory.Controllers
{
    public class SpeedsController : Controller
    {
        private BoardGamesDBMk3Entities db = new BoardGamesDBMk3Entities();

        // GET: Speeds
        public ActionResult Index()
        {
            return View(db.Speeds.ToList());
        }

        // GET: Speeds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Speed speed = db.Speeds.Find(id);
            if (speed == null)
            {
                return HttpNotFound();
            }
            return View(speed);
        }

        // GET: Speeds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Speeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SpeedId,SpeedName,SpeedDescription,MinTime,MaxTime,SpeedImg")] Speed speed)
        {
            if (speed.SpeedImg== null)
            {
                speed.SpeedImg = "https://www.shareicon.net/data/2015/10/20/130824_exit_256x256.png";
            }
            if (ModelState.IsValid)
            {
                db.Speeds.Add(speed);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(speed);
        }

        // GET: Speeds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Speed speed = db.Speeds.Find(id);
            if (speed == null)
            {
                return HttpNotFound();
            }
            return View(speed);
        }

        // POST: Speeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SpeedId,SpeedName,SpeedDescription,MinTime,MaxTime,SpeedImg")] Speed speed)
        {
            if (speed.SpeedImg == null)
            {
                speed.SpeedImg = "https://www.shareicon.net/data/2015/10/20/130824_exit_256x256.png";
            }
            if (ModelState.IsValid)
            {
                db.Entry(speed).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(speed);
        }

        // GET: Speeds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Speed speed = db.Speeds.Find(id);
            if (speed == null)
            {
                return HttpNotFound();
            }
            return View(speed);
        }

        // POST: Speeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Speed speed = db.Speeds.Find(id);
            db.Speeds.Remove(speed);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
