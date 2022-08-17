namespace Ekran_Goruntusu_Alma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGoruntu = new System.Windows.Forms.Button();
            this.pbKayit = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnGoruntu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayarlar";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(198, 21);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(183, 32);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kayıt Et";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGoruntu
            // 
            this.btnGoruntu.Location = new System.Drawing.Point(9, 21);
            this.btnGoruntu.Name = "btnGoruntu";
            this.btnGoruntu.Size = new System.Drawing.Size(183, 32);
            this.btnGoruntu.TabIndex = 0;
            this.btnGoruntu.Text = "Ekran Görüntüsü Al";
            this.btnGoruntu.UseVisualStyleBackColor = true;
            this.btnGoruntu.Click += new System.EventHandler(this.btnGoruntu_Click);
            // 
            // pbKayit
            // 
            this.pbKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbKayit.Location = new System.Drawing.Point(0, 64);
            this.pbKayit.Name = "pbKayit";
            this.pbKayit.Size = new System.Drawing.Size(972, 423);
            this.pbKayit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKayit.TabIndex = 1;
            this.pbKayit.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 487);
            this.Controls.Add(this.pbKayit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ekran Görüntüsü Al";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbKayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGoruntu;
        private System.Windows.Forms.PictureBox pbKayit;
    }
}

