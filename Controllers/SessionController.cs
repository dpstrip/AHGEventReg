using AHGEventReg.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AHGEventReg.Models
{
    public class SessionController : Controller
    {
        private ApplicationDbContext _context;

        public SessionController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Session
        public ActionResult Index()
        {

            var sessions = _context.Sessions.ToList();
            return View(sessions);
        }

        public ActionResult Details(int id)
        {
            var session = _context.Sessions.SingleOrDefault(s => s.Id == id);
            if (session == null)
                return HttpNotFound();

            return View(session);
        }


        public ActionResult ViewNew()
        {
            return View("SessionForm");
        }

        public ActionResult ViewEdit(int id)
        {
            var session = _context.Sessions.SingleOrDefault(s => s.Id == id);
            if (session == null)
                return HttpNotFound();

            return View("SessionForm", session);
        }



        //I need to add, edit and delete a session
        [HttpPost]
        public ActionResult EditSession(Session session)
        {
            //add
            if (session.Id == 0)
                _context.Sessions.Add(session);

            //edit
            else
            {
                var _session = _context.Sessions.SingleOrDefault(s => s.Id == session.Id);
                if (session == null)
                    return HttpNotFound();
                _session.Name = session.Name;
                _session.Description = session.Description;
                _session.Location = session.Location;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Session");
        }


       
    }

     
}