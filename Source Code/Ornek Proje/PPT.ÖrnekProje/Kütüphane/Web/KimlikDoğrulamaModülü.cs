using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Security.Cryptography;
using System.Security.Authentication;
using System.Web.Security;
using System.Threading;
using Kütüphane.Güvenlik;

namespace Kütüphane.Web
{
    public class KimlikDoğrulamaModülü: IHttpModule
    {
        #region IHttpModule Members

        private HttpApplication context;

        public void Dispose()
        {
            
        }

        public void Init(HttpApplication context)
        {
            this.context = context;
            context.AuthenticateRequest += new EventHandler(context_AuthenticateRequest);
        }

        void context_AuthenticateRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.User != null)
            {
                HttpCookie cookie = context.Request.Cookies["Rol"];
                PrincipalOlustur(HttpContext.Current.User.Identity.Name, cookie.Value);
            }
        }

        private void PrincipalOlustur(string kullanıcıAd, string rol)
        {
            PptIdentity identity = new PptIdentity(kullanıcıAd);
            PptPrincipal principal = new PptPrincipal(identity, rol);
            Thread.CurrentPrincipal = principal;
            HttpContext.Current.User = principal;
            
        }

        public void KullanıcıDoğrula(string ad, string belirtilenSifre, string ozetSifre, string tuz, string rol, bool kalıcı)
        {
            SHA256Managed sha = new SHA256Managed();
            belirtilenSifre = belirtilenSifre + tuz;
            byte[] sifreBytes = Encoding.UTF8.GetBytes(belirtilenSifre);
            byte[] ozetBytes = sha.ComputeHash(sifreBytes);
            string hesaplananOzetSifre = Convert.ToBase64String(ozetBytes);
            if (hesaplananOzetSifre != ozetSifre)
                throw new AuthenticationException("Geçersiz kullanıcı / şifre");
            PrincipalOlustur(ad, rol);
            HttpCookie roller = new HttpCookie("Rol", rol);
            if (kalıcı)
                roller.Expires = DateTime.MaxValue;
            HttpContext.Current.Response.Cookies.Add(roller);
        }

        public void OzetHesapla(string sifre, out string ozetSifre, out string tuz)
        {
            SHA256Managed sha = new SHA256Managed();
            tuz = DateTime.Now.ToString("yyMMddhhmmss");
            sifre = sifre + tuz;
            byte [] sifreBytes = Encoding.UTF8.GetBytes(sifre);
            byte [] ozetBytes = sha.ComputeHash(sifreBytes);
            ozetSifre = Convert.ToBase64String(ozetBytes);
        }

        #endregion
    }
}
