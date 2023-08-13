namespace Sample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlResXCreate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctlFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.ctlResourceCreate = new System.Windows.Forms.Button();
            this.ctlResourceRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlResXCreate
            // 
            this.ctlResXCreate.Location = new System.Drawing.Point(12, 12);
            this.ctlResXCreate.Name = "ctlResXCreate";
            this.ctlResXCreate.Size = new System.Drawing.Size(139, 23);
            this.ctlResXCreate.TabIndex = 0;
            this.ctlResXCreate.Text = "ResX Dosyası Oluştur";
            this.ctlResXCreate.UseVisualStyleBackColor = true;
            this.ctlResXCreate.Click += new System.EventHandler(this.ctlResXCreate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ResX Dosyası Oku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctlFileOpen
            // 
            this.ctlFileOpen.FileName = "*.*";
            this.ctlFileOpen.Filter = "Tüm Dosyalar|*.*";
            // 
            // ctlResourceCreate
            // 
            this.ctlResourceCreate.Location = new System.Drawing.Point(13, 96);
            this.ctlResourceCreate.Name = "ctlResourceCreate";
            this.ctlResourceCreate.Size = new System.Drawing.Size(138, 23);
            this.ctlResourceCreate.TabIndex = 2;
            this.ctlResourceCreate.Text = "Kaynak Dosyası Oluştur";
            this.ctlResourceCreate.UseVisualStyleBackColor = true;
            this.ctlResourceCreate.Click += new System.EventHandler(this.ctlResourceCreate_Click);
            // 
            // ctlResourceRead
            // 
            this.ctlResourceRead.Location = new System.Drawing.Point(13, 126);
            this.ctlResourceRead.Name = "ctlResourceRead";
            this.ctlResourceRead.Size = new System.Drawing.Size(138, 23);
            this.ctlResourceRead.TabIndex = 3;
            this.ctlResourceRead.Text = "Kaynak Dosyası Oku";
            this.ctlResourceRead.UseVisualStyleBackColor = true;
            this.ctlResourceRead.Click += new System.EventHandler(this.ctlResourceRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 271);
            this.Controls.Add(this.ctlResourceRead);
            this.Controls.Add(this.ctlResourceCreate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctlResXCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ctlResXCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ctlFileOpen;
        private System.Windows.Forms.Button ctlResourceCreate;
        private System.Windows.Forms.Button ctlResourceRead;
    }
}

