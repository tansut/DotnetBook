    public sealed class ProjeIdentity : IIdentity
    {
        private string kullaniciAdi;
        private string ePostaAdresi;


        public string AuthenticationType
        {
            get
            {
                return "Proje Kimlik Doðrulama Yöntemi";
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return true;
            }
        }

        public string Name
        {
            get
            {
                return kullaniciAdi;
            }
        }

        public string EPostaAdresi
        {
            get
            {
                return ePostaAdresi;
            }
        }

        internal ProjeIdentity(string kullanici, string ePosta)
        {
            this.kullaniciAdi = kullanici;
            this.ePostaAdresi = ePosta;
        }
    }

    public sealed class ProjePrincipal : IPrincipal
    {
        private ProjeIdentity identity;
        private List<string> roller;

        public IIdentity Identity
        {
            get
            {
                return identity;
            }
        }

        public bool IsInRole(string role)
        {
            return roller.IndexOf(role) >= 0;
        }

        internal ProjePrincipal(ProjeIdentity identity, string[] roller)
        {
            this.identity = identity;
            this.roller = new List<string>(roller);
        }
    }

    public static class KimlikYoneticisi
    {
        public static void Dogrula(string kullaniciAd, string sifre)
        {
            ProjeIdentity identity = new ProjeIdentity(kullaniciAd, "xxx@xxx.com");
            string [] roller = new string [] {"Yönetici"};
            IPrincipal principal = new ProjePrincipal(identity, roller);
            Thread.CurrentPrincipal = principal;
            
        }

        public static ProjePrincipal Principal
        {
            get
            {
                return (ProjePrincipal)Thread.CurrentPrincipal;
            }
        }

        public static ProjeIdentity Identity
        {
            get
            {
                return (ProjeIdentity)Principal.Identity;
            }
        }
    }