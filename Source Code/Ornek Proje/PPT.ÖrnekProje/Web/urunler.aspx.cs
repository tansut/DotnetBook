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
using ÝþKatmaný.ÝþVarlýklarý;
using ÝþKatmaný.ÝþNesneleri;
using Kütüphane.ÝstisnaYönetimi;

namespace Web
{
    public partial class urunler : TemelSayfa
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctlSepet.SepetDegisti += new EventHandler(ctlSepet_SepetDegisti);
        }

        void ctlSepet_SepetDegisti(object sender, EventArgs e)
        {
            ctlÜrünGrid.DataBind();
        }

        protected void ctlÜrünGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label uyarý = e.Row.FindControl("ctlUyarý") as Label;
                Ürün.ÜrünRow ürün = (Ürün.ÜrünRow)((DataRowView)e.Row.DataItem).Row;
                Button ekleBtn = e.Row.FindControl("ctlSepetEkleBtn") as Button;
                ekleBtn.CommandArgument = string.Format("{0},{1}",  ürün.Id, e.Row.RowIndex);
                uyarý.Visible = SepetYöneticisi.ÜrünVarmý(ürün.Id);
                ekleBtn.Enabled = ürün.StokAdet > 0;
            }
        }

        protected void ctlÜrünGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SepetEkle")
            {
                string[] veriler = e.CommandArgument.ToString().Split(',');
                int ürünId = int.Parse(veriler[0]);
                int satirSirasi = int.Parse(veriler[1]);
                TextBox adetBox = ctlÜrünGrid.Rows[satirSirasi].FindControl("ctlAdet") as TextBox;
                int adet = int.Parse(adetBox.Text);
                if (adet > 0)
                {
                    SepetYöneticisi.Ekle(ürünId, adet);
                    ctlSepet.DataBind();
                    ctlÜrünGrid.DataBind();
                    AnaSayfa.MesajGöster("Sepete eklendi");
                }
                else
                {
                    throw new KullanýcýException("Adet deðeri hatalýdýr.");
                }

            }
        }

        protected void ctlFilterBtn_Click(object sender, EventArgs e)
        {
            if (ctlFiltreAd.Text.Length > 0)
                AnaSayfa.MesajGöster("Filtreleme yapýldý");
        }
    }
}
