using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Abc.Tipler;
using System.Collections;
using System.IO;
using System.Reflection;

namespace Abc.TestUygulama
{
    public partial class Form1 : Form
    {
        private ArrayList ortaklar = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader(@"Ortaklar.txt");
            while (!r.EndOfStream)
            {
                string line = r.ReadLine();
                if (line.StartsWith("#"))
                    continue;
                IKitapDeposu depo = Activator.CreateInstance(Type.GetType(line)) as IKitapDeposu;
                if (depo != null)
                    ortaklar.Add(depo);                
            }
            for (int i = 0; i < ortaklar.Count; i++)
                ctlPartners.Items.Add(((IKitapDeposu)ortaklar[i]).DepoAd);
        }

        private void ListeyeEkle(Kitap[] sonuclar)
        {
            foreach (Kitap sonuc in sonuclar)
              ctlResults.Items.Add(string.Format("{0}, {1}", sonuc.Ad, sonuc.Isbn));
        }

        private void ctlSearch_Click(object sender, EventArgs e)
        {
            ctlResults.Items.Clear();
            for (int i = 0; i < ortaklar.Count; i++) {
                Kitap [] sonuc = ((IKitapDeposu)ortaklar[i]).AramaYap(ctlText.Text);
                if (sonuc != null)
                {
                    ListeyeEkle(sonuc);
                }
                
            }
        }
    }
}