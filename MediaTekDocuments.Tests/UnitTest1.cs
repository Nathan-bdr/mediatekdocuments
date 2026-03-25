using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;

namespace MediaTekDocuments.Tests
{
    [TestClass]
    public class TestParutionDansAbonnement
    {
        [TestMethod]
        public void ParutionDansAbonnement_DateDedans()
        {
            DateTime dateCommande = new DateTime(2024, 1, 1);
            DateTime dateFinAbonnement = new DateTime(2024, 12, 31);
            DateTime dateParution = new DateTime(2024, 6, 15);
            bool resultat = GestionAbonnement.ParutionDansAbonnement(dateCommande, dateFinAbonnement, dateParution);
            Assert.IsTrue(resultat);
        }

        [TestMethod]
        public void ParutionDansAbonnement_DateAvant()
        {
            DateTime dateCommande = new DateTime(2024, 1, 1);
            DateTime dateFinAbonnement = new DateTime(2024, 12, 31);
            DateTime dateParution = new DateTime(2023, 12, 31);
            bool resultat = GestionAbonnement.ParutionDansAbonnement(dateCommande, dateFinAbonnement, dateParution);
            Assert.IsFalse(resultat);
        }

        [TestMethod]
        public void ParutionDansAbonnement_DateApres()
        {
            DateTime dateCommande = new DateTime(2024, 1, 1);
            DateTime dateFinAbonnement = new DateTime(2024, 12, 31);
            DateTime dateParution = new DateTime(2025, 1, 1);
            bool resultat = GestionAbonnement.ParutionDansAbonnement(dateCommande, dateFinAbonnement, dateParution);
            Assert.IsFalse(resultat);
        }
    }
}