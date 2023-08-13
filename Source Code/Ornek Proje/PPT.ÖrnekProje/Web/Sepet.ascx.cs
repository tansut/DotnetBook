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
using ��Katman�.��Varl�klar�;
using ��Katman�.��Nesneleri;
using System.ComponentModel;

namespace Web
{
    public partial class Sepet : System.Web.UI.UserControl
    {
        public event EventHandler SepetDegisti;
        private bool baglantiGozukebilir = true;

        protected void Page_Load(object sender, EventArgs e)
        {
            ctlBaglanti.Visible = baglantiGozukebilir;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Sil")
            {
                SepetY�neticisi.Sil(int.Parse(e.CommandArgument.ToString()));
                GridView1.DataBind();
                if (SepetDegisti != null)
                    SepetDegisti(this, EventArgs.Empty);
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ��Katman�.��Varl�klar�.Sepet sepet = ((��Katman�.��Varl�klar�.Sepet)e.Row.DataItem);
                ImageButton silBtn = e.Row.FindControl("ctlSil") as ImageButton;
                silBtn.CommandArgument = sepet.�r�nId.ToString();

                Label toplam = e.Row.FindControl("ctlToplam") as Label;
                silBtn.Visible = baglantiGozukebilir;

                
            }

        }

        protected void GridView1_DataBinding(object sender, EventArgs e)
        {

        }

        [DefaultValue(true)]
        [Browsable(true)]
        public bool BaglantiGoster
        {
            get
            {
                return baglantiGozukebilir;
            }

            set
            {
                baglantiGozukebilir = value;
            }
        }
    }
}