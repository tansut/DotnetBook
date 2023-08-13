using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class YetkiAttribute: Attribute
    {
        private string operasyon;

        public YetkiAttribute(string yetki)
        {
            this.operasyon = yetki;
        }
        public string Operasyon
        {
            get
            {
                return operasyon;
            }
        }
    }
}
