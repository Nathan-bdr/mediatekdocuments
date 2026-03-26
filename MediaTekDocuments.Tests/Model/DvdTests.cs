using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;

namespace MediaTekDocuments.Tests
{
    [TestClass]
    public class DvdTests
    {
        private const string id = "00001";
        private const string titre = "titre test";
        private const string image = "image test";
        private const int duree = 120;
        private const string synopsis = "synopsis test";
        private const string realisateur = "realisateur test";
        private const string idGenre = "10001";
        private const string genre = "genre test";
        private const string idPublic = "00001";
        private const string lePublic = "public test";
        private const string idRayon = "DV001";
        private const string rayon = "rayon test";
        private static readonly Dvd dvd = new Dvd(id, titre, image, duree, realisateur, synopsis,
            idGenre, genre, idPublic, lePublic, idRayon, rayon);

        [TestMethod]
        public void DvdTest()
        {
            Assert.AreEqual(id, dvd.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(titre, dvd.Titre, "devrait réussir : titre valorisé");
            Assert.AreEqual(image, dvd.Image, "devrait réussir : image valorisé");
            Assert.AreEqual(duree, dvd.Duree, "devrait réussir : duree valorisé");
            Assert.AreEqual(synopsis, dvd.Synopsis, "devrait réussir : synopsis valorisé");
            Assert.AreEqual(realisateur, dvd.Realisateur, "devrait réussir : realisateur valorisé");
            Assert.AreEqual(idGenre, dvd.IdGenre, "devrait réussir : idGenre valorisé");
            Assert.AreEqual(genre, dvd.Genre, "devrait réussir : genre valorisé");
            Assert.AreEqual(idPublic, dvd.IdPublic, "devrait réussir : idPublic valorisé");
            Assert.AreEqual(lePublic, dvd.Public, "devrait réussir : public valorisé");
            Assert.AreEqual(idRayon, dvd.IdRayon, "devrait réussir : idRayon valorisé");
            Assert.AreEqual(rayon, dvd.Rayon, "devrait réussir : rayon valorisé");
        }
    }
}