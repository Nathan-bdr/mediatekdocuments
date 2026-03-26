using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using System;

namespace MediaTekDocuments.Tests
{
    [TestClass]
    public class CommandeTests
    {
        private const string id = "00001";
        private static readonly DateTime dateCommande = new DateTime(2024, 1, 1);
        private const double montant = 25.50;
        private static readonly Commande commande = new Commande(id, dateCommande, montant);

        [TestMethod]
        public void CommandeTest()
        {
            Assert.AreEqual(id, commande.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(dateCommande, commande.DateCommande, "devrait réussir : dateCommande valorisé");
            Assert.AreEqual(montant, commande.Montant, "devrait réussir : montant valorisé");
        }
    }
}