
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
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.cmbDiyet = new System.Windows.Forms.ComboBox();
            this.lblDiyet = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.gbxRapor = new System.Windows.Forms.GroupBox();
            this.cdrDiyetTakvim = new System.Windows.Forms.MonthCalendar();
            this.lblDiyetBaslangic = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblDiyetBitis = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.gbxHastaEkleme.SuspendLayout();
            this.gbxRapor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(1142, 12);
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
            this.gbxHastaBilgileri.Location = new System.Drawing.Point(20, 43);
            this.gbxHastaBilgileri.Name = "gbxHastaBilgileri";
            this.gbxHastaBilgileri.Size = new System.Drawing.Size(504, 333);
            this.gbxHastaBilgileri.TabIndex = 1;
            this.gbxHastaBilgileri.TabStop = false;
            this.gbxHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // gbxDiyetBilgileri
            // 
            this.gbxDiyetBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gbxDiyetBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDiyetBilgileri.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxDiyetBilgileri.Location = new System.Drawing.Point(20, 382);
            this.gbxDiyetBilgileri.Name = "gbxDiyetBilgileri";
            this.gbxDiyetBilgileri.Size = new System.Drawing.Size(504, 201);
            this.gbxDiyetBilgileri.TabIndex = 2;
            this.gbxDiyetBilgileri.TabStop = false;
            this.gbxDiyetBilgileri.Text = "Diyet Bilgileri";
            // 
            // gbxHastaEkleme
            // 
            this.gbxHastaEkleme.BackColor = System.Drawing.Color.Transparent;
            this.gbxHastaEkleme.Controls.Add(this.lblBitis);
            this.gbxHastaEkleme.Controls.Add(this.lblDiyetBitis);
            this.gbxHastaEkleme.Controls.Add(this.lblBaslangic);
            this.gbxHastaEkleme.Controls.Add(this.lblDiyetBaslangic);
            this.gbxHastaEkleme.Controls.Add(this.cdrDiyetTakvim);
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
            this.gbxHastaEkleme.Location = new System.Drawing.Point(765, 87);
            this.gbxHastaEkleme.Name = "gbxHastaEkleme";
            this.gbxHastaEkleme.Size = new System.Drawing.Size(378, 601);
            this.gbxHastaEkleme.TabIndex = 2;
            this.gbxHastaEkleme.TabStop = false;
            this.gbxHastaEkleme.Text = "Hasta Ekleme";
            // 
            // cmbHastalik
            // 
            this.cmbHastalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHastalik.FormattingEnabled = true;
            this.cmbHastalik.Location = new System.Drawing.Point(104, 179);
            this.cmbHastalik.Name = "cmbHastalik";
            this.cmbHastalik.Size = new System.Drawing.Size(234, 28);
            this.cmbHastalik.TabIndex = 12;
            // 
            // lblHastalik
            // 
            this.lblHastalik.AutoSize = true;
            this.lblHastalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastalik.Location = new System.Drawing.Point(7, 178);
            this.lblHastalik.Name = "lblHastalik";
            this.lblHastalik.Size = new System.Drawing.Size(92, 25);
            this.lblHastalik.TabIndex = 11;
            this.lblHastalik.Text = "Hastalık :";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCNo.Location = new System.Drawing.Point(104, 135);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(234, 26);
            this.txtTCNo.TabIndex = 10;
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHastaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHastaEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHastaEkle.Location = new System.Drawing.Point(245, 525);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(93, 58);
            this.btnHastaEkle.TabIndex = 3;
            this.btnHastaEkle.Text = "Hasta Ekleme";
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyisim.Location = new System.Drawing.Point(104, 91);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(234, 26);
            this.txtSoyisim.TabIndex = 9;
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(104, 44);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(234, 26);
            this.txtIsim.TabIndex = 8;
            // 
            // cmbDiyet
            // 
            this.cmbDiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDiyet.FormattingEnabled = true;
            this.cmbDiyet.Location = new System.Drawing.Point(104, 223);
            this.cmbDiyet.Name = "cmbDiyet";
            this.cmbDiyet.Size = new System.Drawing.Size(234, 28);
            this.cmbDiyet.TabIndex = 7;
            // 
            // lblDiyet
            // 
            this.lblDiyet.AutoSize = true;
            this.lblDiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiyet.Location = new System.Drawing.Point(31, 222);
            this.lblDiyet.Name = "lblDiyet";
            this.lblDiyet.Size = new System.Drawing.Size(67, 25);
            this.lblDiyet.TabIndex = 6;
            this.lblDiyet.Text = "Diyet :";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCNo.Location = new System.Drawing.Point(18, 134);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(81, 25);
            this.lblTCNo.TabIndex = 5;
            this.lblTCNo.Text = "TC No :";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyisim.Location = new System.Drawing.Point(7, 90);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(92, 25);
            this.lblSoyisim.TabIndex = 4;
            this.lblSoyisim.Text = "Soyisim :";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsim.Location = new System.Drawing.Point(40, 43);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(58, 25);
            this.lblIsim.TabIndex = 3;
            this.lblIsim.Text = "İsim :";
            // 
            // gbxRapor
            // 
            this.gbxRapor.BackColor = System.Drawing.Color.Transparent;
            this.gbxRapor.Controls.Add(this.gbxHastaBilgileri);
            this.gbxRapor.Controls.Add(this.gbxDiyetBilgileri);
            this.gbxRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxRapor.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxRapor.Location = new System.Drawing.Point(32, 87);
            this.gbxRapor.Name = "gbxRapor";
            this.gbxRapor.Size = new System.Drawing.Size(704, 601);
            this.gbxRapor.TabIndex = 3;
            this.gbxRapor.TabStop = false;
            this.gbxRapor.Text = "Rapor";
            // 
            // cdrDiyetTakvim
            // 
            this.cdrDiyetTakvim.Location = new System.Drawing.Point(104, 263);
            this.cdrDiyetTakvim.Name = "cdrDiyetTakvim";
            this.cdrDiyetTakvim.TabIndex = 0;
            this.cdrDiyetTakvim.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cdrDiyetTakvim_DateChanged);
            // 
            // lblDiyetBaslangic
            // 
            this.lblDiyetBaslangic.AutoSize = true;
            this.lblDiyetBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiyetBaslangic.Location = new System.Drawing.Point(6, 446);
            this.lblDiyetBaslangic.Name = "lblDiyetBaslangic";
            this.lblDiyetBaslangic.Size = new System.Drawing.Size(126, 20);
            this.lblDiyetBaslangic.TabIndex = 13;
            this.lblDiyetBaslangic.Text = "Diyet Başlangıç :";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangic.Location = new System.Drawing.Point(138, 446);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(177, 20);
            this.lblBaslangic.TabIndex = 14;
            this.lblBaslangic.Text = "..........................................";
            // 
            // lblDiyetBitis
            // 
            this.lblDiyetBitis.AutoSize = true;
            this.lblDiyetBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiyetBitis.Location = new System.Drawing.Point(45, 481);
            this.lblDiyetBitis.Name = "lblDiyetBitis";
            this.lblDiyetBitis.Size = new System.Drawing.Size(87, 20);
            this.lblDiyetBitis.TabIndex = 15;
            this.lblDiyetBitis.Text = "Diyet Bitiş :";
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitis.Location = new System.Drawing.Point(138, 481);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(177, 20);
            this.lblBitis.TabIndex = 16;
            this.lblBitis.Text = "..........................................";
            // 
            // DiyetisyenEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 721);
            this.Controls.Add(this.gbxRapor);
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
            this.gbxRapor.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbxRapor;
        private System.Windows.Forms.MonthCalendar cdrDiyetTakvim;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblDiyetBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblDiyetBaslangic;
    }
}