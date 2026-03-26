using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using System;

namespace MediaTekDocuments.Tests
{
    [TestClass]
    public class AbonnementTests
    {
        private const string id = "00001";
        private static readonly DateTime dateCommande = new DateTime(2024, 1, 1);
        private const double montant = 50.00;
        private static readonly DateTime dateFinAbonnement = new DateTime(2024, 12, 31);
        private const string idRevue = "00001";
        private const string titre = "titre test";
        private static readonly Abonnement abonnement = new Abonnement(id, dateCommande, montant,
            dateFinAbonnement, idRevue, titre);

        [TestMethod]
        public void AbonnementTest()
        {
            Assert.AreEqual(id, abonnement.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(dateCommande, abonnement.DateCommande, "devrait réussir : dateCommande valorisé");
            Assert.AreEqual(montant, abonnement.Montant, "devrait réussir : montant valorisé");
            Assert.AreEqual(dateFinAbonnement, abonnement.DateFinAbonnement, "devrait réussir : dateFinAbonnement valorisé");
            Assert.AreEqual(idRevue, abonnement.IdRevue, "devrait réussir : idRevue valorisé");
            Assert.AreEqual(titre, abonnement.Titre, "devrait réussir : titre valorisé");
        }
    }
}