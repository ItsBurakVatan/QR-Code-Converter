namespace TextToQRCode
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_donustur = new System.Windows.Forms.Button();
            this.txt_metin = new System.Windows.Forms.TextBox();
            this.pb_qrcode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_donustur
            // 
            this.btn_donustur.Location = new System.Drawing.Point(138, 173);
            this.btn_donustur.Margin = new System.Windows.Forms.Padding(4);
            this.btn_donustur.Name = "btn_donustur";
            this.btn_donustur.Size = new System.Drawing.Size(136, 40);
            this.btn_donustur.TabIndex = 0;
            this.btn_donustur.Text = "Dönüştür";
            this.btn_donustur.UseVisualStyleBackColor = true;
            this.btn_donustur.Click += new System.EventHandler(this.btn_donustur_Click);
            // 
            // txt_metin
            // 
            this.txt_metin.Location = new System.Drawing.Point(105, 114);
            this.txt_metin.Name = "txt_metin";
            this.txt_metin.Size = new System.Drawing.Size(197, 30);
            this.txt_metin.TabIndex = 0;
            // 
            // pb_qrcode
            // 
            this.pb_qrcode.Location = new System.Drawing.Point(98, 264);
            this.pb_qrcode.Name = "pb_qrcode";
            this.pb_qrcode.Size = new System.Drawing.Size(217, 145);
            this.pb_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_qrcode.TabIndex = 2;
            this.pb_qrcode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "QR CODE GENERATOR";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_donustur;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(438, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_qrcode);
            this.Controls.Add(this.txt_metin);
            this.Controls.Add(this.btn_donustur);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pb_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_donustur;
        private System.Windows.Forms.TextBox txt_metin;
        private System.Windows.Forms.PictureBox pb_qrcode;
        private System.Windows.Forms.Label label1;
    }
}

