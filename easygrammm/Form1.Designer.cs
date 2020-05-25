namespace easygrammm
{
    partial class Dilavergram
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
            this.mailBox = new System.Windows.Forms.TextBox();
            this.adBox = new System.Windows.Forms.TextBox();
            this.sifreBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.baslaButon = new System.Windows.Forms.Button();
            this.randomYazi = new System.Windows.Forms.CheckBox();
            this.randomSayi = new System.Windows.Forms.CheckBox();
            this.rastgeleMax = new System.Windows.Forms.TextBox();
            this.listeGoster = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listeGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(12, 18);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(100, 20);
            this.mailBox.TabIndex = 0;
            // 
            // adBox
            // 
            this.adBox.Location = new System.Drawing.Point(12, 44);
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(100, 20);
            this.adBox.TabIndex = 1;
            // 
            // sifreBox
            // 
            this.sifreBox.Location = new System.Drawing.Point(12, 70);
            this.sifreBox.Name = "sifreBox";
            this.sifreBox.Size = new System.Drawing.Size(100, 20);
            this.sifreBox.TabIndex = 2;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(12, 96);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 3;
            // 
            // baslaButon
            // 
            this.baslaButon.Location = new System.Drawing.Point(22, 122);
            this.baslaButon.Name = "baslaButon";
            this.baslaButon.Size = new System.Drawing.Size(75, 23);
            this.baslaButon.TabIndex = 4;
            this.baslaButon.Text = "basla";
            this.baslaButon.UseVisualStyleBackColor = true;
            this.baslaButon.Click += new System.EventHandler(this.basla_Click);
            // 
            // randomYazi
            // 
            this.randomYazi.AutoSize = true;
            this.randomYazi.Location = new System.Drawing.Point(118, 36);
            this.randomYazi.Name = "randomYazi";
            this.randomYazi.Size = new System.Drawing.Size(89, 17);
            this.randomYazi.TabIndex = 5;
            this.randomYazi.Text = "Random Yazi";
            this.randomYazi.UseVisualStyleBackColor = true;
            // 
            // randomSayi
            // 
            this.randomSayi.AutoSize = true;
            this.randomSayi.Location = new System.Drawing.Point(118, 60);
            this.randomSayi.Name = "randomSayi";
            this.randomSayi.Size = new System.Drawing.Size(89, 17);
            this.randomSayi.TabIndex = 6;
            this.randomSayi.Text = "Random Sayi";
            this.randomSayi.UseVisualStyleBackColor = true;
            // 
            // rastgeleMax
            // 
            this.rastgeleMax.Location = new System.Drawing.Point(118, 100);
            this.rastgeleMax.Name = "rastgeleMax";
            this.rastgeleMax.Size = new System.Drawing.Size(100, 20);
            this.rastgeleMax.TabIndex = 9;
            this.rastgeleMax.Text = "1";
            // 
            // listeGoster
            // 
            this.listeGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeGoster.Location = new System.Drawing.Point(12, 169);
            this.listeGoster.Name = "listeGoster";
            this.listeGoster.Size = new System.Drawing.Size(391, 150);
            this.listeGoster.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Random Uzunluk";
            // 
            // Dilavergram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeGoster);
            this.Controls.Add(this.rastgeleMax);
            this.Controls.Add(this.randomSayi);
            this.Controls.Add(this.randomYazi);
            this.Controls.Add(this.baslaButon);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.sifreBox);
            this.Controls.Add(this.adBox);
            this.Controls.Add(this.mailBox);
            this.Name = "Dilavergram";
            ((System.ComponentModel.ISupportInitialize)(this.listeGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.TextBox adBox;
        private System.Windows.Forms.TextBox sifreBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button baslaButon;
        private System.Windows.Forms.CheckBox randomYazi;
        private System.Windows.Forms.CheckBox randomSayi;
        private System.Windows.Forms.TextBox rastgeleMax;
        private System.Windows.Forms.DataGridView listeGoster;
        private System.Windows.Forms.Label label1;
    }
}

