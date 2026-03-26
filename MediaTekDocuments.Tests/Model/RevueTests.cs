using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;

namespace MediaTekDocuments.Tests
{
    [TestClass]
    public class RevueTests
    {
        private const string id = "00001";
        private const string titre = "titre test";
        private const string image = "image test";
        private const string idGenre = "10001";
        private const string genre = "genre test";
        private const string idPublic = "00001";
        private const string lePublic = "public test";
        private const string idRayon = "RV001";
        private const string rayon = "rayon test";
        private const string periodicite = "mensuelle";
        private const int delaiMiseADispo = 10;
        private static readonly Revue revue = new Revue(id, titre, image, idGenre, genre,
            idPublic, lePublic, idRayon, rayon, periodicite, delaiMiseADispo);

        [TestMethod]
        public void RevueTest()
        {
            Assert.AreEqual(id, revue.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(titre, revue.Titre, "devrait réussir : titre valorisé");
            Assert.AreEqual(image, revue.Image, "devrait réussir : image valorisé");
            Assert.AreEqual(idGenre, revue.IdGenre, "devrait réussir : idGenre valorisé");
            Assert.AreEqual(genre, revue.Genre, "devrait réussir : genre valorisé");
            Assert.AreEqual(idPublic, revue.IdPublic, "devrait réussir : idPublic valorisé");
            Assert.AreEqual(lePublic, revue.Public, "devrait réussir : public valorisé");
            Assert.AreEqual(idRayon, revue.IdRayon, "devrait réussir : idRayon valorisé");
            Assert.AreEqual(rayon, revue.Rayon, "devrait réussir : rayon valorisé");
            Assert.AreEqual(periodicite, revue.Periodicite, "devrait réussir : periodicite valorisé");
            Assert.AreEqual(delaiMiseADispo, revue.DelaiMiseADispo, "devrait réussir : delaiMiseADispo valorisé");
        }
    }
}