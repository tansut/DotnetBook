using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Reflection;

namespace UI
{
    internal sealed class İşlemYöneticisi
    {
        private İşlemYöneticisi()
        {
        }

    
        private static bool kullanıcıYetkisiVarMı(string operasyonAd)
        {
            return true;
        }

        private static void YetkiKontrol(MemberInfo m)
        {
            object[] attrList = m.GetCustomAttributes(false);
            YetkiAttribute yetki = null;
            foreach (object o in attrList)
            {
                if (o is YetkiAttribute)
                {
                    yetki = (YetkiAttribute)o;
                    if (!kullanıcıYetkisiVarMı(yetki.Operasyon))
                        throw new ApplicationException(string.Format("{0} yetkiniz bulunmamaktadır", yetki.Operasyon));

                }
            }
            if (yetki == null)
                throw new ApplicationException("Metot yetki tanımı yapılmamıştır");
        }

        public static object İşlemYap(string operasyonKodu, params object[] parametreler) {

            Operasyon operasyon = OperasyonListesi.Liste[operasyonKodu];

            Assembly a = Assembly.Load(operasyon.Assembly);

            Type işSınıfı = a.GetType(operasyon.Sınıf, true);            

            MethodInfo işMetodu = işSınıfı.GetMethod(operasyon.Metot);


            YetkiKontrol(işMetodu);

            object işNesnesi = Activator.CreateInstance(işSınıfı);

            try
            {
                return işMetodu.Invoke(işNesnesi, parametreler);
            }
            catch (TargetInvocationException exc)
            {
                throw exc.InnerException;
            }

        }
    }
}
