
namespace YazilimMimarisiOdevi
{
    partial class frmHastaEklemeEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaEklemeEkran));
            this.gbxHastaEkleme = new System.Windows.Forms.GroupBox();
            this.cmbHastalik = new System.Windows.Forms.ComboBox();
            this.lblHastalik = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.gbxHastaEkleme.SuspendLayout();
            this.SuspendLayout();
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
            this.gbxHastaEkleme.Controls.Add(this.lblTCNo);
            this.gbxHastaEkleme.Controls.Add(this.lblSoyisim);
            this.gbxHastaEkleme.Controls.Add(this.lblIsim);
            this.gbxHastaEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxHastaEkleme.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxHastaEkleme.Location = new System.Drawing.Point(12, 52);
            this.gbxHastaEkleme.Name = "gbxHastaEkleme";
            this.gbxHastaEkleme.Size = new System.Drawing.Size(378, 296);
            this.gbxHastaEkleme.TabIndex = 3;
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
            this.cmbHastalik.SelectedIndexChanged += new System.EventHandler(this.cmbHastalik_SelectedIndexChanged);
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
            this.btnHastaEkle.Location = new System.Drawing.Point(245, 224);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(93, 58);
            this.btnHastaEkle.TabIndex = 3;
            this.btnHastaEkle.Text = "Hasta Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
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
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(361, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(34, 34);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Location = new System.Drawing.Point(321, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(34, 34);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmHastaEklemeEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 365);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.gbxHastaEkleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHastaEklemeEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaEklemeEkrancs";
            this.Load += new System.EventHandler(this.frmHastaEklemeEkran_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HastaEklemeEkran_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HastaEklemeEkran_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HastaEklemeEkran_MouseUp);
            this.gbxHastaEkleme.ResumeLayout(false);
            this.gbxHastaEkleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHastaEkleme;
        private System.Windows.Forms.ComboBox cmbHastalik;
        private System.Windows.Forms.Label lblHastalik;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeri;
    }
}