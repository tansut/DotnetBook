using System;
using System.Collections.Generic;
using System.Text;

namespace Kütüphane.İstisnaYönetimi
{

    [global::System.Serializable]
    public class KullanıcıException : ApplicationException
    {
        public KullanıcıException()
        {
        }
        public KullanıcıException(string message) : base(message)
        {
        }
        public KullanıcıException(string message, Exception inner) : base(message, inner)
        {
        }
        protected KullanıcıException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }

    
    [global::System.Serializable]
    public class TeknikException : ApplicationException
    {

        public TeknikException()
        {

        }
        public TeknikException(Exception inner)
            : base("Teknik hata oluştu, lütfen daha sonra deneyiniz", inner)
        {
        }
        protected TeknikException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }
}
