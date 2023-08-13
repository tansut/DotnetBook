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
using Kütüphane.ÝstisnaYönetimi;

namespace Web
{
    public partial class PptMaster : TemelAnaSayfa
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "PPT.NET Mühendis Uygulamasý";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            HttpContext.Current.Response.Cookies["Rol"].Expires = DateTime.MinValue;
            Response.Redirect("~/");
        }

        public override ScriptManager ScriptManager
        {
            get
            {
                return this.ctlScriptManager;
            }
        }

        public override void MesajGöster(string mesaj)
        {
            ctlMesaj.Text = mesaj;
        }

        protected void ctlScriptManager_AsyncPostBackError(object sender, AsyncPostBackErrorEventArgs e)
        {
            ctlScriptManager.AsyncPostBackErrorMessage = ÝstisnaYöneticisi.Yonet(e.Exception).Message;           
        }
    }
}
