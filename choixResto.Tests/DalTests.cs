﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.UI.WebControls;
using choixResto.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace choixResto.Tests
{
    [TestClass]
    public class DalTests
    {
        [TestInitialize]
        public void Init_AvantChaqueTest()
        {
            IDatabaseInitializer<BddContext> init = new DropCreateDatabaseAlways<BddContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new BddContext());
        }



        [TestMethod]
        public void CreerRestaurant_AvecUnNouveauRestaurant_ObtientTousLesRestaurantsRenvoitBienLeRestaurant()
        {
            using (Dal dal = new Dal())
            {
                dal.CreerRestaurant("La bonne fourchette", "01 02 03 04 05");
                List<Resto> restos = dal.ObtientTousLesRestaurants();

                Assert.IsNotNull(restos);
                Assert.AreEqual(1, restos.Count);
                Assert.AreEqual("La bonne fourchette", restos[0].Nom);
                Assert.AreEqual("01 02 03 04 05", restos[0].Telephone);
            }
        }
    }
}
