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
using ��Katman�.��Varl�klar�;
using ��Katman�.��Nesneleri;
using K�t�phane.�stisnaY�netimi;

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
            ctl�r�nGrid.DataBind();
        }

        protected void ctl�r�nGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label uyar� = e.Row.FindControl("ctlUyar�") as Label;
                �r�n.�r�nRow �r�n = (�r�n.�r�nRow)((DataRowView)e.Row.DataItem).Row;
                Button ekleBtn = e.Row.FindControl("ctlSepetEkleBtn") as Button;
                ekleBtn.CommandArgument = string.Format("{0},{1}",  �r�n.Id, e.Row.RowIndex);
                uyar�.Visible = SepetY�neticisi.�r�nVarm�(�r�n.Id);
                ekleBtn.Enabled = �r�n.StokAdet > 0;
            }
        }

        protected void ctl�r�nGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SepetEkle")
            {
                string[] veriler = e.CommandArgument.ToString().Split(',');
                int �r�nId = int.Parse(veriler[0]);
                int satirSirasi = int.Parse(veriler[1]);
                TextBox adetBox = ctl�r�nGrid.Rows[satirSirasi].FindControl("ctlAdet") as TextBox;
                int adet = int.Parse(adetBox.Text);
                if (adet > 0)
                {
                    SepetY�neticisi.Ekle(�r�nId, adet);
                    ctlSepet.DataBind();
                    ctl�r�nGrid.DataBind();
                    AnaSayfa.MesajG�ster("Sepete eklendi");
                }
                else
                {
                    throw new Kullan�c�Exception("Adet de�eri hatal�d�r.");
                }

            }
        }

        protected void ctlFilterBtn_Click(object sender, EventArgs e)
        {
            if (ctlFiltreAd.Text.Length > 0)
                AnaSayfa.MesajG�ster("Filtreleme yap�ld�");
        }
    }
}
