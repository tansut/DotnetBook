using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace Web.Controls
{
    public abstract class TemelSayfa: Page
    {
        protected TemelAnaSayfa AnaSayfa
        {
            get
            {
                return (TemelAnaSayfa)this.Master;
            }
        }


    }
}
