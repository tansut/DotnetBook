using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Kütüphane.İstisnaYönetimi;

namespace Kütüphane.Web
{
    public class İstisnaModülü: IHttpModule
    {
        #region IHttpModule Members
        private HttpApplication context;

        public void Dispose()
        {
            
        }

        public void Init(HttpApplication context)
        {
            this.context = context;
            context.Error += new EventHandler(context_Error);
        }

        void context_Error(object sender, EventArgs e)
        {
            Exception exc = context.Server.GetLastError();
            if (exc is HttpException && ((System.Web.HttpException)(exc)).GetHttpCode() == 404)
                context.Response.Redirect("~/Hata404.aspx");
            else
            {                
                HttpContext.Current.Items.Clear();
                HttpContext.Current.Items.Add("Hata", İstisnaYöneticisi.Yonet(exc));
                context.Server.Transfer("~/Hata.aspx");
            }
        }

        #endregion
    }
}
