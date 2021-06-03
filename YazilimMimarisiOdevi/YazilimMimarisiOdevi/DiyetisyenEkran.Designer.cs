
namespace YazilimMimarisiOdevi
{
    partial class DiyetisyenEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiyetisyenEkran));
            this.btnCikis = new System.Windows.Forms.Button();
            this.gbxHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.gbxDiyetBilgileri = new System.Windows.Forms.GroupBox();
            this.gbxHastaEkleme = new System.Windows.Forms.GroupBox();
            this.cmbHastalik = new System.Windows.Forms.ComboBox();
            this.lblHastalik = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.cmbDiyet = new System.Windows.Forms.ComboBox();
            this.lblDiyet = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxHastaEkleme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(984, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(34, 34);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // gbxHastaBilgileri
            // 
            this.gbxHastaBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gbxHastaBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxHastaBilgileri.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxHastaBilgileri.Location = new System.Drawing.Point(20, 29);
            this.gbxHastaBilgileri.Name = "gbxHastaBilgileri";
            this.gbxHastaBilgileri.Size = new System.Drawing.Size(436, 220);
            this.gbxHastaBilgileri.TabIndex = 1;
            this.gbxHastaBilgileri.TabStop = false;
            this.gbxHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // gbxDiyetBilgileri
            // 
            this.gbxDiyetBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gbxDiyetBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDiyetBilgileri.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxDiyetBilgileri.Location = new System.Drawing.Point(20, 255);
            this.gbxDiyetBilgileri.Name = "gbxDiyetBilgileri";
            this.gbxDiyetBilgileri.Size = new System.Drawing.Size(436, 144);
            this.gbxDiyetBilgileri.TabIndex = 2;
            this.gbxDiyetBilgileri.TabStop = false;
            this.gbxDiyetBilgileri.Text = "Diyet Bilgileri";
            // 
            // gbxHastaEkleme
            // 
            this.gbxHastaEkleme.BackColor = System.Drawing.Color.Transparent;
            this.gbxHastaEkleme.Controls.Add(this.cmbHastalik);
            this.gbxHastaEkleme.Controls.Add(this.lblHastalik);
            this.gbxHastaEkleme.Controls.Add(this.txtTCNo);
            this.gbxHastaEkleme.Controls.Add(this.btnHastaEkle);
            this.gbxHastaEkleme.Controls.Add(this.txtSoyisim);
            this.gbxHastaEkleme.Controls.Add(this.txtIsim);
            this.gbxHastaEkleme.Controls.Add(this.cmbDiyet);
            this.gbxHastaEkleme.Controls.Add(this.lblDiyet);
            this.gbxHastaEkleme.Controls.Add(this.lblTCNo);
            this.gbxHastaEkleme.Controls.Add(this.lblSoyisim);
            this.gbxHastaEkleme.Controls.Add(this.lblIsim);
            this.gbxHastaEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxHastaEkleme.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxHastaEkleme.Location = new System.Drawing.Point(713, 87);
            this.gbxHastaEkleme.Name = "gbxHastaEkleme";
            this.gbxHastaEkleme.Size = new System.Drawing.Size(281, 411);
            this.gbxHastaEkleme.TabIndex = 2;
            this.gbxHastaEkleme.TabStop = false;
            this.gbxHastaEkleme.Text = "Hasta Ekleme";
            // 
            // cmbHastalik
            // 
            this.cmbHastalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHastalik.FormattingEnabled = true;
            this.cmbHastalik.Location = new System.Drawing.Point(104, 225);
            this.cmbHastalik.Name = "cmbHastalik";
            this.cmbHastalik.Size = new System.Drawing.Size(154, 28);
            this.cmbHastalik.TabIndex = 12;
            // 
            // lblHastalik
            // 
            this.lblHastalik.AutoSize = true;
            this.lblHastalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastalik.Location = new System.Drawing.Point(7, 224);
            this.lblHastalik.Name = "lblHastalik";
            this.lblHastalik.Size = new System.Drawing.Size(92, 25);
            this.lblHastalik.TabIndex = 11;
            this.lblHastalik.Text = "Hastalık :";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCNo.Location = new System.Drawing.Point(104, 177);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(154, 26);
            this.txtTCNo.TabIndex = 10;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyisim.Location = new System.Drawing.Point(104, 129);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(154, 26);
            this.txtSoyisim.TabIndex = 9;
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(104, 81);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(154, 26);
            this.txtIsim.TabIndex = 8;
            // 
            // cmbDiyet
            // 
            this.cmbDiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDiyet.FormattingEnabled = true;
            this.cmbDiyet.Location = new System.Drawing.Point(104, 273);
            this.cmbDiyet.Name = "cmbDiyet";
            this.cmbDiyet.Size = new System.Drawing.Size(154, 28);
            this.cmbDiyet.TabIndex = 7;
            // 
            // lblDiyet
            // 
            this.lblDiyet.AutoSize = true;
            this.lblDiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiyet.Location = new System.Drawing.Point(31, 272);
            this.lblDiyet.Name = "lblDiyet";
            this.lblDiyet.Size = new System.Drawing.Size(67, 25);
            this.lblDiyet.TabIndex = 6;
            this.lblDiyet.Text = "Diyet :";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCNo.Location = new System.Drawing.Point(18, 176);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(81, 25);
            this.lblTCNo.TabIndex = 5;
            this.lblTCNo.Text = "TC No :";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyisim.Location = new System.Drawing.Point(6, 128);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(92, 25);
            this.lblSoyisim.TabIndex = 4;
            this.lblSoyisim.Text = "Soyisim :";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsim.Location = new System.Drawing.Point(40, 80);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(58, 25);
            this.lblIsim.TabIndex = 3;
            this.lblIsim.Text = "İsim :";
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHastaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHastaEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHastaEkle.Location = new System.Drawing.Point(165, 323);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(93, 58);
            this.btnHastaEkle.TabIndex = 3;
            this.btnHastaEkle.Text = "Hasta Ekleme";
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.gbxHastaBilgileri);
            this.groupBox1.Controls.Add(this.gbxDiyetBilgileri);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Location = new System.Drawing.Point(32, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 411);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapor";
            // 
            // DiyetisyenEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxHastaEkleme);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiyetisyenEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkran";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DiyetisyenEkran_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DiyetisyenEkran_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DiyetisyenEkran_MouseUp);
            this.gbxHastaEkleme.ResumeLayout(false);
            this.gbxHastaEkleme.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox gbxHastaBilgileri;
        private System.Windows.Forms.GroupBox gbxDiyetBilgileri;
        private System.Windows.Forms.GroupBox gbxHastaEkleme;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.ComboBox cmbDiyet;
        private System.Windows.Forms.Label lblDiyet;
        private System.Windows.Forms.ComboBox cmbHastalik;
        private System.Windows.Forms.Label lblHastalik;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}