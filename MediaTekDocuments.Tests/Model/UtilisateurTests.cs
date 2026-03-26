using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;

namespace MediaTekDocuments.Tests
{
    [TestClass]
    public class UtilisateurTests
    {
        private const string login = "admin";
        private const string pwd = "adminpwd";
        private const string idService = "00001";
        private const string libelle = "Administratif";
        private static readonly Utilisateur utilisateur = new Utilisateur(login, pwd, idService, libelle);

        [TestMethod]
        public void UtilisateurTest()
        {
            Assert.AreEqual(login, utilisateur.Login, "devrait réussir : login valorisé");
            Assert.AreEqual(pwd, utilisateur.Pwd, "devrait réussir : pwd valorisé");
            Assert.AreEqual(idService, utilisateur.IdService, "devrait réussir : idService valorisé");
            Assert.AreEqual(libelle, utilisateur.Libelle, "devrait réussir : libelle valorisé");
        }
    }
}