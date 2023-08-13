using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Principal;

namespace Kütüphane.Güvenlik
{
    class PptIdentity: IIdentity
    {

        #region IIdentity Members

        string ad;

        public string AuthenticationType
        {
            get
            {
                return "";
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return true;
            }
        }

        public string Name
        {
            get
            {
                return ad;
            }
        }

        internal PptIdentity(string ad)
        {
            this.ad = ad;
        }

        #endregion
    }
}
