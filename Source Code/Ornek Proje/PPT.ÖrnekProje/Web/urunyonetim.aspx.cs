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
using ��Katman�.��Nesneleri;

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
            new �r�n��S�n�f�().Ekle(ref id, ctlAd.Text, int.Parse(ctlAdet.Text), ctlResim.Text, decimal.Parse(ctlUcret.Text));
            ctl�r�nGrid.DataBind();
            
        }

        protected void ods�r�n_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            AnaSayfa.MesajG�ster("�r�n silindi");
        }

        protected void ods�r�n_Inserted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            AnaSayfa.MesajG�ster("�r�n eklendi");
        }

        protected void ods�r�n_Updated(object sender, ObjectDataSourceStatusEventArgs e)
        {
            AnaSayfa.MesajG�ster("�r�n g�ncellendi");
        }
    }
}
