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
 
            return View(makeData());
        }

        public ActionResult Details(int sessionId)
        {
            List<Session> s = makeData();

            Session session = s[sessionId];
            return View(session);
        }

        private List<Session> makeData()
        {
            var session = new Session()
            {
                Id = 0,
                Name = "Knot Tying",
                Description = "Learn how to tie a square knot and others",
                Location = "Room 101"
            };

            var session1 = new Session()
            {
                Id = 1,
                Name = "Cooking",
                Description = "The crock pot has nothing over a ducth oven",
                Location = "Room 102"
            };

            List<Session> sessions = new List<Session>();
            sessions.Add(session);
            sessions.Add(session1);

            return sessions;
        }
    }

     
}