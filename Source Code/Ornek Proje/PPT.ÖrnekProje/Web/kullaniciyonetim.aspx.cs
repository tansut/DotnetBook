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
using ��Katman�.��Nesneleri;
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
            new Kullan�c���S�n�f�().Ekle(ref id, ctlAd.Text, ctlSifre.Text, ctlRol.SelectedValue);
            ctlKullan�c�Grid.DataBind();
        }

        protected void ctl�ptalBtn_Click(object sender, EventArgs e)
        {
            CollapsiblePanelExtender1.Collapsed = true;
        }

        protected void ctlFilterBtn_Click(object sender, EventArgs e)
        {

        }

        protected void odsKullan�c�_Updated(object sender, ObjectDataSourceStatusEventArgs e)
        {
            AnaSayfa.MesajG�ster("Kullan�c� g�ncellendi");
        }

        protected void odsKullan�c�_Inserted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            AnaSayfa.MesajG�ster("Kullan�c� eklendi");
        }

        protected void odsKullan�c�_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            AnaSayfa.MesajG�ster("Kullan�c� silindi");
        }


    }
}
