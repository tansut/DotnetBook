using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DotnetKitabı.Ortakİşlemler;

namespace DotnetKitabı.WindowsUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctlHesapla_Click(object sender, EventArgs e)
        {
            ctlSonuç.Text = Maaşİşlemleri.MaaşHesapla(int.Parse(ctlKatsayı.Text)).ToString();
        }
    }
}