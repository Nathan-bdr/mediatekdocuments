using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using System;

namespace MediaTekDocuments.Tests
{
    [TestClass]
    public class ExemplaireTests
    {
        private const int numero = 1;
        private static readonly DateTime dateAchat = new DateTime(2024, 1, 1);
        private const string photo = "photo test";
        private const string idEtat = "00001";
        private const string idDocument = "00001";
        private const string libelle = "neuf";
        private static readonly Exemplaire exemplaire = new Exemplaire(numero, dateAchat, photo, idEtat, idDocument, libelle);

        [TestMethod]
        public void ExemplaireTest()
        {
            Assert.AreEqual(numero, exemplaire.Numero, "devrait réussir : numero valorisé");
            Assert.AreEqual(dateAchat, exemplaire.DateAchat, "devrait réussir : dateAchat valorisé");
            Assert.AreEqual(photo, exemplaire.Photo, "devrait réussir : photo valorisé");
            Assert.AreEqual(idEtat, exemplaire.IdEtat, "devrait réussir : idEtat valorisé");
            Assert.AreEqual(idDocument, exemplaire.Id, "devrait réussir : idDocument valorisé");
            Assert.AreEqual(libelle, exemplaire.Libelle, "devrait réussir : libelle valorisé");
        }
    }
}