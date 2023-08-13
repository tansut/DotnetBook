using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Principal;

namespace Kütüphane.Güvenlik
{
    class PptPrincipal: IPrincipal
    {
        #region IPrincipal Members

        IIdentity identity;
        string rol;

        public IIdentity Identity
        {
            get
            {
                return identity;
            }
        }

        public bool IsInRole(string role)
        {
            return role == rol;
        }

        internal PptPrincipal(IIdentity identity, string rol)
        {
            this.identity = identity;
            this.rol = rol;
        }

        #endregion
    }
}
