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
                Description = "Learn how to tie a square knot and others",
                Location = "Room 101"
            };

            return View(session);
        }
    }
}