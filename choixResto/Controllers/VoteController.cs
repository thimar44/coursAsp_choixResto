using choixResto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace choixResto.Controllers
{
    public class VoteController : Controller
    {
        private IDal dal;

        public VoteController() : this(new Dal())
        {
        }

        public VoteController(IDal dalIoc)
        {
            dal = dalIoc;
        }

        // GET: Vote
        public ActionResult Index(int id)
        {
            ViewBag.idSondage = id;
            
            return View();
        }

        [HttpPost]
        public ActionResult EnregistrerVote()
        {

            return View();
        }
    }
}