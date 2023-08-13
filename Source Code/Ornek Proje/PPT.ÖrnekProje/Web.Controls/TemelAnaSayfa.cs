using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace Web.Controls
{
    public abstract class TemelAnaSayfa: MasterPage
    {
        public abstract ScriptManager ScriptManager
        {
            get;
        }

        public abstract void MesajGöster(string mesaj);
        




       
    }
}
