using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Collections;
using System.Reflection;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctlResXCreate_Click(object sender, EventArgs e)
        {
            using (ResXResourceWriter writer = new ResXResourceWriter(@"c:\kaynaklar.resx"))
            {
                writer.AddResource("IleriBtn", "İleri");
                Image img = Image.FromFile(@"c:\ornek.jpg");
                writer.AddResource("Resim", img);
                writer.Generate();
                writer.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ctlFileOpen.ShowDialog() == DialogResult.OK)
            {
                using (ResXResourceReader reader = new ResXResourceReader(ctlFileOpen.FileName))
                {
                    foreach (DictionaryEntry entry in reader)
                    {
                        MessageBox.Show(string.Format("{0}-{1}", entry.Key, entry.Value));
                    }
                    reader.Close();
                }
            }
        }

        private void ctlResourceCreate_Click(object sender, EventArgs e)
        {
            using (ResourceWriter writer = new ResourceWriter(@"c:\kaynaklar.resource"))
            {
                writer.AddResource("IleriBtn", "İleri");
                Image img = Image.FromFile(@"c:\ornek.jpg");
                writer.AddResource("Resim", img);
                writer.Generate();
                writer.Close();
            }
        }

        private void ctlResourceRead_Click(object sender, EventArgs e)
        {
            ResourceManager m = new ResourceManager("k", Assembly.GetExecutingAssembly());
            m.GetObject(
            
            if (ctlFileOpen.ShowDialog() == DialogResult.OK)
            {
                using (ResourceReader reader = new ResourceReader(ctlFileOpen.FileName))
                {
                    foreach (DictionaryEntry entry in reader)
                    {
                        MessageBox.Show(string.Format("{0}-{1}", entry.Key, entry.Value));
                    }
                    reader.Close();
                }
            }
        }
    }
}