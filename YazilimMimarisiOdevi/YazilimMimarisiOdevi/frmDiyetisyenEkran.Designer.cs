
namespace YazilimMimarisiOdevi
{
    partial class frmDiyetisyenEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiyetisyenEkran));
            this.btnCikis = new System.Windows.Forms.Button();
            this.gbxHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.lblHastalikGoster = new System.Windows.Forms.Label();
            this.lblTCNoGoster = new System.Windows.Forms.Label();
            this.lblSoyisimGoster = new System.Windows.Forms.Label();
            this.lblIsimGoster = new System.Windows.Forms.Label();
            this.lblHastalik = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.gbxDiyetBilgileri = new System.Windows.Forms.GroupBox();
            this.lblDiyetBitisDegeri = new System.Windows.Forms.Label();
            this.lblDiyetBaslangicDegeri = new System.Windows.Forms.Label();
            this.lblAktifDiyetGoster = new System.Windows.Forms.Label();
            this.lblDiyetBitis = new System.Windows.Forms.Label();
            this.lblDiyetBaslangic = new System.Windows.Forms.Label();
            this.lblAktifDiyet = new System.Windows.Forms.Label();
            this.gbxRapor = new System.Windows.Forms.GroupBox();
            this.gbxHastaGuncelleme = new System.Windows.Forms.GroupBox();
            this.cdrDiyetTakvim = new System.Windows.Forms.MonthCalendar();
            this.cmbDiyet = new System.Windows.Forms.ComboBox();
            this.lblDiyet = new System.Windows.Forms.Label();
            this.txtGuncellemeTCNo = new System.Windows.Forms.TextBox();
            this.btnHastayiGuncelle = new System.Windows.Forms.Button();
            this.lblGuncellemeTCNo = new System.Windows.Forms.Label();
            this.gbxHasta = new System.Windows.Forms.GroupBox();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.lblHastaTCNo = new System.Windows.Forms.Label();
            this.btnHastayiGoster = new System.Windows.Forms.Button();
            this.btnHastaEkleme = new System.Windows.Forms.Button();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.gbxHastaBilgileri.SuspendLayout();
            this.gbxDiyetBilgileri.SuspendLayout();
            this.gbxRapor.SuspendLayout();
            this.gbxHastaGuncelleme.SuspendLayout();
            this.gbxHasta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(892, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(34, 34);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // gbxHastaBilgileri
            // 
            this.gbxHastaBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gbxHastaBilgileri.Controls.Add(this.lblHastalikGoster);
            this.gbxHastaBilgileri.Controls.Add(this.lblTCNoGoster);
            this.gbxHastaBilgileri.Controls.Add(this.lblSoyisimGoster);
            this.gbxHastaBilgileri.Controls.Add(this.lblIsimGoster);
            this.gbxHastaBilgileri.Controls.Add(this.lblHastalik);
            this.gbxHastaBilgileri.Controls.Add(this.lblTCNo);
            this.gbxHastaBilgileri.Controls.Add(this.lblSoyisim);
            this.gbxHastaBilgileri.Controls.Add(this.lblIsim);
            this.gbxHastaBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxHastaBilgileri.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxHastaBilgileri.Location = new System.Drawing.Point(20, 29);
            this.gbxHastaBilgileri.Name = "gbxHastaBilgileri";
            this.gbxHastaBilgileri.Size = new System.Drawing.Size(453, 240);
            this.gbxHastaBilgileri.TabIndex = 1;
            this.gbxHastaBilgileri.TabStop = false;
            this.gbxHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // lblHastalikGoster
            // 
            this.lblHastalikGoster.AutoSize = true;
            this.lblHastalikGoster.Location = new System.Drawing.Point(179, 183);
            this.lblHastalikGoster.Name = "lblHastalikGoster";
            this.lblHastalikGoster.Size = new System.Drawing.Size(222, 25);
            this.lblHastalikGoster.TabIndex = 7;
            this.lblHastalikGoster.Text = "..........................................";
            // 
            // lblTCNoGoster
            // 
            this.lblTCNoGoster.AutoSize = true;
            this.lblTCNoGoster.Location = new System.Drawing.Point(179, 139);
            this.lblTCNoGoster.Name = "lblTCNoGoster";
            this.lblTCNoGoster.Size = new System.Drawing.Size(222, 25);
            this.lblTCNoGoster.TabIndex = 6;
            this.lblTCNoGoster.Text = "..........................................";
            // 
            // lblSoyisimGoster
            // 
            this.lblSoyisimGoster.AutoSize = true;
            this.lblSoyisimGoster.Location = new System.Drawing.Point(179, 93);
            this.lblSoyisimGoster.Name = "lblSoyisimGoster";
            this.lblSoyisimGoster.Size = new System.Drawing.Size(222, 25);
            this.lblSoyisimGoster.TabIndex = 5;
            this.lblSoyisimGoster.Text = "..........................................";
            // 
            // lblIsimGoster
            // 
            this.lblIsimGoster.AutoSize = true;
            this.lblIsimGoster.Location = new System.Drawing.Point(179, 47);
            this.lblIsimGoster.Name = "lblIsimGoster";
            this.lblIsimGoster.Size = new System.Drawing.Size(222, 25);
            this.lblIsimGoster.TabIndex = 4;
            this.lblIsimGoster.Text = "..........................................";
            // 
            // lblHastalik
            // 
            this.lblHastalik.AutoSize = true;
            this.lblHastalik.Location = new System.Drawing.Point(81, 183);
            this.lblHastalik.Name = "lblHastalik";
            this.lblHastalik.Size = new System.Drawing.Size(92, 25);
            this.lblHastalik.TabIndex = 3;
            this.lblHastalik.Text = "Hastalık :";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(92, 139);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(81, 25);
            this.lblTCNo.TabIndex = 2;
            this.lblTCNo.Text = "TC No :";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(81, 93);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(92, 25);
            this.lblSoyisim.TabIndex = 1;
            this.lblSoyisim.Text = "Soyisim :";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(115, 47);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(58, 25);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "İsim :";
            // 
            // gbxDiyetBilgileri
            // 
            this.gbxDiyetBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gbxDiyetBilgileri.Controls.Add(this.lblDiyetBitisDegeri);
            this.gbxDiyetBilgileri.Controls.Add(this.lblDiyetBaslangicDegeri);
            this.gbxDiyetBilgileri.Controls.Add(this.lblAktifDiyetGoster);
            this.gbxDiyetBilgileri.Controls.Add(this.lblDiyetBitis);
            this.gbxDiyetBilgileri.Controls.Add(this.lblDiyetBaslangic);
            this.gbxDiyetBilgileri.Controls.Add(this.lblAktifDiyet);
            this.gbxDiyetBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDiyetBilgileri.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxDiyetBilgileri.Location = new System.Drawing.Point(20, 275);
            this.gbxDiyetBilgileri.Name = "gbxDiyetBilgileri";
            this.gbxDiyetBilgileri.Size = new System.Drawing.Size(453, 374);
            this.gbxDiyetBilgileri.TabIndex = 2;
            this.gbxDiyetBilgileri.TabStop = false;
            this.gbxDiyetBilgileri.Text = "Diyet Bilgileri";
            // 
            // lblDiyetBitisDegeri
            // 
            this.lblDiyetBitisDegeri.AutoSize = true;
            this.lblDiyetBitisDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiyetBitisDegeri.Location = new System.Drawing.Point(222, 213);
            this.lblDiyetBitisDegeri.Name = "lblDiyetBitisDegeri";
            this.lblDiyetBitisDegeri.Size = new System.Drawing.Size(222, 25);
            this.lblDiyetBitisDegeri.TabIndex = 8;
            this.lblDiyetBitisDegeri.Text = "..........................................";
            // 
            // lblDiyetBaslangicDegeri
            // 
            this.lblDiyetBaslangicDegeri.AutoSize = true;
            this.lblDiyetBaslangicDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiyetBaslangicDegeri.Location = new System.Drawing.Point(222, 141);
            this.lblDiyetBaslangicDegeri.Name = "lblDiyetBaslangicDegeri";
            this.lblDiyetBaslangicDegeri.Size = new System.Drawing.Size(222, 25);
            this.lblDiyetBaslangicDegeri.TabIndex = 7;
            this.lblDiyetBaslangicDegeri.Text = "..........................................";
            // 
            // lblAktifDiyetGoster
            // 
            this.lblAktifDiyetGoster.AutoSize = true;
            this.lblAktifDiyetGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktifDiyetGoster.Location = new System.Drawing.Point(222, 73);
            this.lblAktifDiyetGoster.Name = "lblAktifDiyetGoster";
            this.lblAktifDiyetGoster.Size = new System.Drawing.Size(222, 25);
            this.lblAktifDiyetGoster.TabIndex = 6;
            this.lblAktifDiyetGoster.Text = "..........................................";
            // 
            // lblDiyetBitis
            // 
            this.lblDiyetBitis.AutoSize = true;
            this.lblDiyetBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiyetBitis.Location = new System.Drawing.Point(54, 213);
            this.lblDiyetBitis.Name = "lblDiyetBitis";
            this.lblDiyetBitis.Size = new System.Drawing.Size(162, 25);
            this.lblDiyetBitis.TabIndex = 2;
            this.lblDiyetBitis.Text = "Diyet Bitiş Tarihi :";
            // 
            // lblDiyetBaslangic
            // 
            this.lblDiyetBaslangic.AutoSize = true;
            this.lblDiyetBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiyetBaslangic.Location = new System.Drawing.Point(5, 141);
            this.lblDiyetBaslangic.Name = "lblDiyetBaslangic";
            this.lblDiyetBaslangic.Size = new System.Drawing.Size(211, 25);
            this.lblDiyetBaslangic.TabIndex = 1;
            this.lblDiyetBaslangic.Text = "Diyet Başlangıç Tarihi :";
            // 
            // lblAktifDiyet
            // 
            this.lblAktifDiyet.AutoSize = true;
            this.lblAktifDiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktifDiyet.Location = new System.Drawing.Point(106, 73);
            this.lblAktifDiyet.Name = "lblAktifDiyet";
            this.lblAktifDiyet.Size = new System.Drawing.Size(110, 25);
            this.lblAktifDiyet.TabIndex = 0;
            this.lblAktifDiyet.Text = "Aktif Diyet :";
            // 
            // gbxRapor
            // 
            this.gbxRapor.BackColor = System.Drawing.Color.Transparent;
            this.gbxRapor.Controls.Add(this.gbxHastaGuncelleme);
            this.gbxRapor.Controls.Add(this.gbxHastaBilgileri);
            this.gbxRapor.Controls.Add(this.gbxDiyetBilgileri);
            this.gbxRapor.Controls.Add(this.gbxHasta);
            this.gbxRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxRapor.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxRapor.Location = new System.Drawing.Point(12, 12);
            this.gbxRapor.Name = "gbxRapor";
            this.gbxRapor.Size = new System.Drawing.Size(867, 667);
            this.gbxRapor.TabIndex = 3;
            this.gbxRapor.TabStop = false;
            this.gbxRapor.Text = "Rapor";
            // 
            // gbxHastaGuncelleme
            // 
            this.gbxHastaGuncelleme.BackColor = System.Drawing.Color.Transparent;
            this.gbxHastaGuncelleme.Controls.Add(this.cdrDiyetTakvim);
            this.gbxHastaGuncelleme.Controls.Add(this.cmbDiyet);
            this.gbxHastaGuncelleme.Controls.Add(this.lblDiyet);
            this.gbxHastaGuncelleme.Controls.Add(this.txtGuncellemeTCNo);
            this.gbxHastaGuncelleme.Controls.Add(this.btnHastayiGuncelle);
            this.gbxHastaGuncelleme.Controls.Add(this.lblGuncellemeTCNo);
            this.gbxHastaGuncelleme.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxHastaGuncelleme.Location = new System.Drawing.Point(479, 275);
            this.gbxHastaGuncelleme.Name = "gbxHastaGuncelleme";
            this.gbxHastaGuncelleme.Size = new System.Drawing.Size(367, 374);
            this.gbxHastaGuncelleme.TabIndex = 4;
            this.gbxHastaGuncelleme.TabStop = false;
            this.gbxHastaGuncelleme.Text = "Hasta Güncelleme";
            // 
            // cdrDiyetTakvim
            // 
            this.cdrDiyetTakvim.Location = new System.Drawing.Point(92, 129);
            this.cdrDiyetTakvim.Name = "cdrDiyetTakvim";
            this.cdrDiyetTakvim.TabIndex = 17;
            this.cdrDiyetTakvim.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cdrDiyetTakvim_DateChanged);
            // 
            // cmbDiyet
            // 
            this.cmbDiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDiyet.FormattingEnabled = true;
            this.cmbDiyet.Location = new System.Drawing.Point(88, 87);
            this.cmbDiyet.Name = "cmbDiyet";
            this.cmbDiyet.Size = new System.Drawing.Size(238, 28);
            this.cmbDiyet.TabIndex = 4;
            this.cmbDiyet.SelectedIndexChanged += new System.EventHandler(this.cmbDiyet_SelectedIndexChanged);
            // 
            // lblDiyet
            // 
            this.lblDiyet.AutoSize = true;
            this.lblDiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiyet.Location = new System.Drawing.Point(15, 86);
            this.lblDiyet.Name = "lblDiyet";
            this.lblDiyet.Size = new System.Drawing.Size(67, 25);
            this.lblDiyet.TabIndex = 18;
            this.lblDiyet.Text = "Diyet :";
            // 
            // txtGuncellemeTCNo
            // 
            this.txtGuncellemeTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncellemeTCNo.Location = new System.Drawing.Point(88, 48);
            this.txtGuncellemeTCNo.Name = "txtGuncellemeTCNo";
            this.txtGuncellemeTCNo.Size = new System.Drawing.Size(238, 26);
            this.txtGuncellemeTCNo.TabIndex = 3;
            // 
            // btnHastayiGuncelle
            // 
            this.btnHastayiGuncelle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHastayiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHastayiGuncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHastayiGuncelle.Location = new System.Drawing.Point(220, 303);
            this.btnHastayiGuncelle.Name = "btnHastayiGuncelle";
            this.btnHastayiGuncelle.Size = new System.Drawing.Size(106, 62);
            this.btnHastayiGuncelle.TabIndex = 5;
            this.btnHastayiGuncelle.Text = "Hastayı Güncelle";
            this.btnHastayiGuncelle.UseVisualStyleBackColor = false;
            this.btnHastayiGuncelle.Click += new System.EventHandler(this.btnHastayiGuncelle_Click);
            // 
            // lblGuncellemeTCNo
            // 
            this.lblGuncellemeTCNo.AutoSize = true;
            this.lblGuncellemeTCNo.Location = new System.Drawing.Point(6, 47);
            this.lblGuncellemeTCNo.Name = "lblGuncellemeTCNo";
            this.lblGuncellemeTCNo.Size = new System.Drawing.Size(76, 25);
            this.lblGuncellemeTCNo.TabIndex = 14;
            this.lblGuncellemeTCNo.Text = "TC No:";
            // 
            // gbxHasta
            // 
            this.gbxHasta.BackColor = System.Drawing.Color.Transparent;
            this.gbxHasta.Controls.Add(this.txtTCNo);
            this.gbxHasta.Controls.Add(this.lblHastaTCNo);
            this.gbxHasta.Controls.Add(this.btnHastayiGoster);
            this.gbxHasta.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxHasta.Location = new System.Drawing.Point(479, 29);
            this.gbxHasta.Name = "gbxHasta";
            this.gbxHasta.Size = new System.Drawing.Size(367, 240);
            this.gbxHasta.TabIndex = 3;
            this.gbxHasta.TabStop = false;
            this.gbxHasta.Text = "Hasta";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCNo.Location = new System.Drawing.Point(124, 93);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(202, 26);
            this.txtTCNo.TabIndex = 1;
            // 
            // lblHastaTCNo
            // 
            this.lblHastaTCNo.AutoSize = true;
            this.lblHastaTCNo.Location = new System.Drawing.Point(42, 93);
            this.lblHastaTCNo.Name = "lblHastaTCNo";
            this.lblHastaTCNo.Size = new System.Drawing.Size(76, 25);
            this.lblHastaTCNo.TabIndex = 13;
            this.lblHastaTCNo.Text = "TC No:";
            // 
            // btnHastayiGoster
            // 
            this.btnHastayiGoster.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHastayiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHastayiGoster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHastayiGoster.Location = new System.Drawing.Point(220, 164);
            this.btnHastayiGoster.Name = "btnHastayiGoster";
            this.btnHastayiGoster.Size = new System.Drawing.Size(106, 62);
            this.btnHastayiGoster.TabIndex = 2;
            this.btnHastayiGoster.Text = "Hastayı Göster";
            this.btnHastayiGoster.UseVisualStyleBackColor = false;
            this.btnHastayiGoster.Click += new System.EventHandler(this.btnHastayiGoster_Click);
            // 
            // btnHastaEkleme
            // 
            this.btnHastaEkleme.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHastaEkleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHastaEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaEkleme.Location = new System.Drawing.Point(701, 703);
            this.btnHastaEkleme.Name = "btnHastaEkleme";
            this.btnHastaEkleme.Size = new System.Drawing.Size(116, 58);
            this.btnHastaEkleme.TabIndex = 6;
            this.btnHastaEkleme.Text = "Hasta Ekleme";
            this.btnHastaEkleme.UseVisualStyleBackColor = false;
            this.btnHastaEkleme.Click += new System.EventHandler(this.btnHastaEkleme_Click);
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRaporAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporAl.Location = new System.Drawing.Point(259, 703);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(116, 58);
            this.btnRaporAl.TabIndex = 7;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.UseVisualStyleBackColor = false;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // frmDiyetisyenEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 788);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.btnHastaEkleme);
            this.Controls.Add(this.gbxRapor);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiyetisyenEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.frmDiyetisyenEkran_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDiyetisyenEkran_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDiyetisyenEkran_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDiyetisyenEkran_MouseUp);
            this.gbxHastaBilgileri.ResumeLayout(false);
            this.gbxHastaBilgileri.PerformLayout();
            this.gbxDiyetBilgileri.ResumeLayout(false);
            this.gbxDiyetBilgileri.PerformLayout();
            this.gbxRapor.ResumeLayout(false);
            this.gbxHastaGuncelleme.ResumeLayout(false);
            this.gbxHastaGuncelleme.PerformLayout();
            this.gbxHasta.ResumeLayout(false);
            this.gbxHasta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox gbxHastaBilgileri;
        private System.Windows.Forms.GroupBox gbxDiyetBilgileri;
        private System.Windows.Forms.GroupBox gbxRapor;
        private System.Windows.Forms.Label lblHastalik;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblHastalikGoster;
        private System.Windows.Forms.Label lblTCNoGoster;
        private System.Windows.Forms.Label lblSoyisimGoster;
        private System.Windows.Forms.Label lblIsimGoster;
        private System.Windows.Forms.Label lblDiyetBitis;
        private System.Windows.Forms.Label lblDiyetBaslangic;
        private System.Windows.Forms.Label lblAktifDiyet;
        private System.Windows.Forms.Label lblDiyetBitisDegeri;
        private System.Windows.Forms.Label lblDiyetBaslangicDegeri;
        private System.Windows.Forms.Label lblAktifDiyetGoster;
        private System.Windows.Forms.GroupBox gbxHasta;
        private System.Windows.Forms.Button btnHastayiGoster;
        private System.Windows.Forms.Button btnHastaEkleme;
        private System.Windows.Forms.GroupBox gbxHastaGuncelleme;
        private System.Windows.Forms.TextBox txtGuncellemeTCNo;
        private System.Windows.Forms.Button btnHastayiGuncelle;
        private System.Windows.Forms.Label lblGuncellemeTCNo;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label lblHastaTCNo;
        private System.Windows.Forms.MonthCalendar cdrDiyetTakvim;
        private System.Windows.Forms.ComboBox cmbDiyet;
        private System.Windows.Forms.Label lblDiyet;
        private System.Windows.Forms.Button btnRaporAl;
    }
}