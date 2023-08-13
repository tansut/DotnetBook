using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using ÝþKatmaný.ÝþNesneleri;

namespace Web.Controls
{

    [ToolboxData("<{0}:SepetDataSource runat=server></{0}:SepetDataSource>")]
    public class SepetDataSource: DataSourceControl
    {
        private SepetDataSourceView gorunum = null;

        protected override DataSourceView GetView(string viewName)
        {
            if (gorunum == null)
                gorunum = new SepetDataSourceView(this);

            return gorunum;
        }

        public SepetDataSource()
            : base()
        {
        }
    }

    public class SepetDataSourceView : DataSourceView
    {
        internal SepetDataSourceView(IDataSource kaynak)
            : base(kaynak, "sepet")
        {
        }



        protected override System.Collections.IEnumerable ExecuteSelect(DataSourceSelectArguments arguments)
        {
            return SepetYöneticisi.Liste;
        }
    }
}
