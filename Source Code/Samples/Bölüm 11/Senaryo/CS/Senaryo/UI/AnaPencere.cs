using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class AnaPencere : Form
    {
        public AnaPencere()
        {
            InitializeComponent();
        }

        private void btnMüşteriAra_Click(object sender, EventArgs e)
        {
            try
            {
                ctlMüşteriGv.DataSource = İşlemYöneticisi.İşlemYap("MüşteriAra", ctlMüşteriAra.Text);
                MessageBox.Show("Müşteri sorgusu yapıldı");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        private void btnMüşteriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Müşteri m = new Müşteri(long.Parse(ctlMüşteriTcNo.Text), ctlMüşteriAd.Text, ctlMüşteriSoyad.Text);
                İşlemYöneticisi.İşlemYap("MüşteriEkle", m);
                MessageBox.Show("Müşteri eklendi");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btnMüşteriSil_Click(object sender, EventArgs e)
        {
            try
            {
                İşlemYöneticisi.İşlemYap("MüşteriSil", long.Parse(ctlMüşteriTcNo.Text));
                MessageBox.Show("Müşteri silindi");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ctlTümMüşteriListesi_Click(object sender, EventArgs e)
        {
            try
            {
                ctlMüşteriGv.DataSource = İşlemYöneticisi.İşlemYap("MüşteriListele");
                MessageBox.Show("Müşteri listeleme yapıldı");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    }
}