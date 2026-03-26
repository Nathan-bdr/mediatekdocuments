using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using System;

namespace MediaTekDocuments.Tests
{
    [TestClass]
    public class CommandeDocumentTests
    {
        private const string id = "00001";
        private static readonly DateTime dateCommande = new DateTime(2024, 1, 1);
        private const double montant = 25.50;
        private const int nbExemplaire = 3;
        private const string idLivreDvd = "00001";
        private const string idSuivi = "00001";
        private const string suivi = "en cours";
        private static readonly CommandeDocument commandeDocument = new CommandeDocument(id, dateCommande,
            montant, nbExemplaire, idLivreDvd, idSuivi, suivi);

        [TestMethod]
        public void CommandeDocumentTest()
        {
            Assert.AreEqual(id, commandeDocument.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(dateCommande, commandeDocument.DateCommande, "devrait réussir : dateCommande valorisé");
            Assert.AreEqual(montant, commandeDocument.Montant, "devrait réussir : montant valorisé");
            Assert.AreEqual(nbExemplaire, commandeDocument.NbExemplaire, "devrait réussir : nbExemplaire valorisé");
            Assert.AreEqual(idLivreDvd, commandeDocument.IdLivreDvd, "devrait réussir : idLivreDvd valorisé");
            Assert.AreEqual(idSuivi, commandeDocument.IdSuivi, "devrait réussir : idSuivi valorisé");
            Assert.AreEqual(suivi, commandeDocument.Suivi, "devrait réussir : suivi valorisé");
        }
    }
}
