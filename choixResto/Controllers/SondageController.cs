using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using choixResto.Models;
using System.Web.Mvc;

namespace choixResto.Controllers
{
    public class SondageController : Controller
    {
        private IDal dal;

        public SondageController() : this(new Dal())
        {
        }

        public SondageController(IDal dalIoc)
        {
            dal = dalIoc;
        }


        public ActionResult CreerSondage()
        {
            int idNouveauSondage = dal.CreerUnSondage();
            return RedirectToAction( "Index", "Vote" , new { @id = idNouveauSondage });
        }
    }
}