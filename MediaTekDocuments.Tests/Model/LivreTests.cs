using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;

namespace MediaTekDocuments.Tests
{
    [TestClass]
    public class LivreTests
    {
        private const string id = "00001";
        private const string titre = "titre test";
        private const string image = "image test";
        private const string isbn = "isbn test";
        private const string auteur = "auteur test";
        private const string collection = "collection test";
        private const string idGenre = "10001";
        private const string genre = "genre test";
        private const string idPublic = "00001";
        private const string lePublic = "public test";
        private const string idRayon = "LV001";
        private const string rayon = "rayon test";
        private static readonly Livre livre = new Livre(id, titre, image, isbn, auteur, collection,
            idGenre, genre, idPublic, lePublic, idRayon, rayon);

        [TestMethod]
        public void LivreTest()
        {
            Assert.AreEqual(id, livre.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(titre, livre.Titre, "devrait réussir : titre valorisé");
            Assert.AreEqual(image, livre.Image, "devrait réussir : image valorisé");
            Assert.AreEqual(isbn, livre.Isbn, "devrait réussir : isbn valorisé");
            Assert.AreEqual(auteur, livre.Auteur, "devrait réussir : auteur valorisé");
            Assert.AreEqual(collection, livre.Collection, "devrait réussir : collection valorisé");
            Assert.AreEqual(idGenre, livre.IdGenre, "devrait réussir : idGenre valorisé");
            Assert.AreEqual(genre, livre.Genre, "devrait réussir : genre valorisé");
            Assert.AreEqual(idPublic, livre.IdPublic, "devrait réussir : idPublic valorisé");
            Assert.AreEqual(lePublic, livre.Public, "devrait réussir : public valorisé");
            Assert.AreEqual(idRayon, livre.IdRayon, "devrait réussir : idRayon valorisé");
            Assert.AreEqual(rayon, livre.Rayon, "devrait réussir : rayon valorisé");
        }
    }
}
