
namespace YazilimMimarisiOdevi
{
    partial class AdminEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEkran));
            this.btnCikis = new System.Windows.Forms.Button();
            this.gbxDiyetisyenEkleme = new System.Windows.Forms.GroupBox();
            this.btnDiyetisyenEkleme = new System.Windows.Forms.Button();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.gbxDiyetisyenEkleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(291, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(34, 34);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbxDiyetisyenEkleme
            // 
            this.gbxDiyetisyenEkleme.BackColor = System.Drawing.Color.Transparent;
            this.gbxDiyetisyenEkleme.Controls.Add(this.btnDiyetisyenEkleme);
            this.gbxDiyetisyenEkleme.Controls.Add(this.txtTCNo);
            this.gbxDiyetisyenEkleme.Controls.Add(this.txtSoyisim);
            this.gbxDiyetisyenEkleme.Controls.Add(this.txtIsim);
            this.gbxDiyetisyenEkleme.Controls.Add(this.lblTCNo);
            this.gbxDiyetisyenEkleme.Controls.Add(this.lblSoyisim);
            this.gbxDiyetisyenEkleme.Controls.Add(this.lblIsim);
            this.gbxDiyetisyenEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDiyetisyenEkleme.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxDiyetisyenEkleme.Location = new System.Drawing.Point(12, 52);
            this.gbxDiyetisyenEkleme.Name = "gbxDiyetisyenEkleme";
            this.gbxDiyetisyenEkleme.Size = new System.Drawing.Size(299, 360);
            this.gbxDiyetisyenEkleme.TabIndex = 1;
            this.gbxDiyetisyenEkleme.TabStop = false;
            this.gbxDiyetisyenEkleme.Text = "Diyetisyen Ekleme";
            // 
            // btnDiyetisyenEkleme
            // 
            this.btnDiyetisyenEkleme.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDiyetisyenEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiyetisyenEkleme.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDiyetisyenEkleme.Location = new System.Drawing.Point(157, 260);
            this.btnDiyetisyenEkleme.Name = "btnDiyetisyenEkleme";
            this.btnDiyetisyenEkleme.Size = new System.Drawing.Size(113, 65);
            this.btnDiyetisyenEkleme.TabIndex = 5;
            this.btnDiyetisyenEkleme.Text = "Diyetisyen Ekleme";
            this.btnDiyetisyenEkleme.UseVisualStyleBackColor = false;
            // 
            // txtTCNo
            // 
            this.txtTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCNo.Location = new System.Drawing.Point(104, 200);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(166, 26);
            this.txtTCNo.TabIndex = 4;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyisim.Location = new System.Drawing.Point(104, 140);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(166, 26);
            this.txtSoyisim.TabIndex = 3;
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(104, 80);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(166, 26);
            this.txtIsim.TabIndex = 2;
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(17, 199);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(81, 25);
            this.lblTCNo.TabIndex = 2;
            this.lblTCNo.Text = "TC No :";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(6, 139);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(92, 25);
            this.lblSoyisim.TabIndex = 1;
            this.lblSoyisim.Text = "Soyisim :";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(40, 79);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(58, 25);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "İsim :";
            // 
            // AdminEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.gbxDiyetisyenEkleme);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEkran";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminEkran_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminEkran_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminEkran_MouseUp);
            this.gbxDiyetisyenEkleme.ResumeLayout(false);
            this.gbxDiyetisyenEkleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox gbxDiyetisyenEkleme;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnDiyetisyenEkleme;
    }
}