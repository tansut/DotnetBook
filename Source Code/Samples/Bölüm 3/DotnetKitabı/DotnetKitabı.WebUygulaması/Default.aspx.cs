using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DotnetKitab�.Ortak��lemler;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ctlHesapla_Click(object sender, EventArgs e)
    {
        ctlSonu�.Text =  Maa���lemleri.Maa�Hesapla(int.Parse(ctlKatsay�.Text)).ToString();
    }
}
