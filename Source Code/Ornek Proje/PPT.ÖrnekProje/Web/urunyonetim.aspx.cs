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
    public partial class urunyonetim : TemelSayfa
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ctlFilterBtn_Click(object sender, EventArgs e)
        {

        }

        protected void ctlEkleBtn_Click(object sender, EventArgs e)
        {
            int id = 0;
            new ÜrünÝþSýnýfý().Ekle(ref id, ctlAd.Text, int.Parse(ctlAdet.Text), ctlResim.Text, decimal.Parse(ctlUcret.Text));
            ctlÜrünGrid.DataBind();
            
        }

        protected void odsÜrün_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            AnaSayfa.MesajGöster("Ürün silindi");
        }

        protected void odsÜrün_Inserted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            AnaSayfa.MesajGöster("Ürün eklendi");
        }

        protected void odsÜrün_Updated(object sender, ObjectDataSourceStatusEventArgs e)
        {
            AnaSayfa.MesajGöster("Ürün güncellendi");
        }
    }
}
