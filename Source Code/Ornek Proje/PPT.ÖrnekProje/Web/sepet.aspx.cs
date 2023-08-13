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

namespace Web
{
    public partial class sepet : TemelSayfa
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                ctlToplam.Text = string.Format("{0:c}", SepetYöneticisi.Liste.ToplamUcret);
        }

        protected void ctlFilterBtn_Click(object sender, EventArgs e)
        {

        }

        protected void ctlEkleBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
