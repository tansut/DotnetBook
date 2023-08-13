using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Web.Controls;
using ÝþKatmaný.ÝþNesneleri;
using System.Security.Authentication;

namespace Web
{
    public partial class giris : TemelSayfa
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ctlLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                new KimlikDogrulamaÝþSýnýfý().GiriþYap(ctlLogin.UserName, ctlLogin.Password, ctlLogin.RememberMeSet);
                e.Authenticated = true;
                
            }
            catch (AuthenticationException)
            {
                e.Authenticated = false;
            }
            
            
        }

        protected void ctlLogin_LoggedIn(object sender, EventArgs e)
        {
                     
        }
    }
}
