using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PPT.KitapAramaSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void ActivateFilter()
        {
            if (ctlStilFiltre.SelectedIndex == 0)
                wordsBindingSource.Filter = string.Empty;
            else
                wordsBindingSource.Filter = string.Format("Style='{0}'", ctlStilFiltre.Items[ctlStilFiltre.SelectedIndex]);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.wordsTableAdapter.Fill(this.kitap.Words, wordToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (wordToolStripTextBox.Text.Length > 2)
                    this.wordsTableAdapter.Fill(this.kitap.Words, wordToolStripTextBox.Text);
                else
                    MessageBox.Show("En az 3 karakter giriniz");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ctlStilFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivateFilter();
        }

        private void wordToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                fillToolStripButton_Click_1(this, EventArgs.Empty);
                e.Handled = true;
            }

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            ctlStilFiltre.SelectedIndex = 0;
            

        }
    }
}