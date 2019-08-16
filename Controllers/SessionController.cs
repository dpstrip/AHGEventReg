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
        // GET: Session
        public ActionResult Index()
        {
            var session = new Session()
            {
                Id = 1,
                Name = "Knot Tying",
                
            };

            List<Session> sessions = new List<Session>();
            sessions.Add(session);

            SessionViewModel svm = new SessionViewModel();
            svm.sessions = sessions;
            return View(svm);
        }

        public ActionResult Details(int sessionId)
        {
            var session = new Session()
            {
                Id = 1,
                Name = "Knot Tying",
                Description = "Learn how to tie a square knot and others",
                Location = "Room 101"
            };

            return View(session);
        }
    }

     
}