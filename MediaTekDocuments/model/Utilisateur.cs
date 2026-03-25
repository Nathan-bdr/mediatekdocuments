
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Utilisateur
    /// </summary>
    public class Utilisateur
    {
        public string Login { get; }
        public string Pwd { get; }
        public string IdService { get; }
        public string Libelle { get; }

        public Utilisateur(string login, string pwd, string idService, string libelle)
        {
            Login = login;
            Pwd = pwd;
            IdService = idService;
            Libelle = libelle;
        }
    }
}
