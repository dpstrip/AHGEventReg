using AHGEventReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AHGEventReg.ViewModel
{
    public class SessionViewModel
    {
        public IEnumerable<Session> sessions { get; set; }
    }
}