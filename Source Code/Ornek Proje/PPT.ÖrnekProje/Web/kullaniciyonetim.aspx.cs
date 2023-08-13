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
using ÝþKatmaný.ÝþNesneleri;
using Web.Controls;

namespace Web
{
    public partial class kullaniciyonetim : TemelSayfa
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ctlEkleBtn_Click(object sender, EventArgs e)
        {
            int id = 0;
            new KullanýcýÝþSýnýfý().Ekle(ref id, ctlAd.Text, ctlSifre.Text, ctlRol.SelectedValue);
            ctlKullanýcýGrid.DataBind();
        }

        protected void ctlÝptalBtn_Click(object sender, EventArgs e)
        {
            CollapsiblePanelExtender1.Collapsed = true;
        }

        protected void ctlFilterBtn_Click(object sender, EventArgs e)
        {

        }

        protected void odsKullanýcý_Updated(object sender, ObjectDataSourceStatusEventArgs e)
        {
            AnaSayfa.MesajGöster("Kullanýcý güncellendi");
        }

        protected void odsKullanýcý_Inserted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            AnaSayfa.MesajGöster("Kullanýcý eklendi");
        }

        protected void odsKullanýcý_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            AnaSayfa.MesajGöster("Kullanýcý silindi");
        }


    }
}
