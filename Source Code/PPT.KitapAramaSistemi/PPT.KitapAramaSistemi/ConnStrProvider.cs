using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.IO;

namespace PPT.KitapAramaSistemi
{
    class ConnStrProvider : SettingsProvider
    {
        public override string ApplicationName
        {
            get
            {
                return "PPT.NET";
            }
            set
            {
            }
        }

        public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection)
        {
            SettingsPropertyValueCollection degerler;
            degerler = new SettingsPropertyValueCollection();
            foreach (SettingsProperty ozellik in collection)
            {
                SettingsPropertyValue deger = new SettingsPropertyValue(ozellik);
                deger.SerializedValue = Oku(ozellik.Name);
                degerler.Add(deger);
            }
            return degerler;
        }

        private object Oku(string ad)
        {
            string database = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"Data\ppt.add");
            return string.Format("Data Source=\"{0}\";Pooling=True;TrimTrailingSpaces=True;TableType=ADT;ShowDeleted=False;ServerType=LOCAL;SecurityMode=IGNORERIGHTS;ReadOnly=True",
                database);
        }

        public override void SetPropertyValues(SettingsContext context,
                                   SettingsPropertyValueCollection collection)
        {
            foreach (SettingsPropertyValue ozellikDegeri in collection)
            {
                if (!ozellikDegeri.IsDirty || (ozellikDegeri.SerializedValue == null))
                {
                    continue;
                }
                Kaydet(ozellikDegeri.Name, ozellikDegeri.SerializedValue);
            }
        }

        private void Kaydet(string ad, object deger)
        {

        }

        public override void Initialize(string name,
                        System.Collections.Specialized.NameValueCollection config)
        {
            base.Initialize(ApplicationName, config);
        }
    }

}
