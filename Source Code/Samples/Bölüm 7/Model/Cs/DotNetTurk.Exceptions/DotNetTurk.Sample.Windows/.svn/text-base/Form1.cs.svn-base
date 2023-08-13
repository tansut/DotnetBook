using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DotNetTurk.Exceptions;
using System.Collections;

namespace DotNetTurk.Sample.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ManageException(Exception exc)
        {
            ApplicationException appExc = ExceptionManager.Convert(exc);
            ExceptionManager.Publish(appExc);
            MessageBox.Show(appExc.Message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnUserException_Click(object sender, EventArgs e)
        {
            try
            {
                throw new UserException("Örnek Kullanıcı Hatası");
            }
            catch (Exception exc)
            {
                ManageException(exc);
            }
        }

        private void btnTechnicalException_Click(object sender, EventArgs e)
        {
            try
            {
                throw new TechnicalException("Örnek Teknik Hata");
            }
            catch (Exception exc)
            {
                ManageException(exc);
            }
        }

        private void btnOtherException_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList list = null;
                list.Add("");
            }
            catch (Exception exc)
            {
                ManageException(exc);
            }
        }
    }
}