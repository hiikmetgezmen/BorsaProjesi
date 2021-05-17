
namespace BorsaProjesi
{
    partial class UrunEkle
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
            this.urun_ekle = new System.Windows.Forms.Button();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.miktar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Don = new System.Windows.Forms.Button();
            this.urunsec = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // urun_ekle
            // 
            this.urun_ekle.Location = new System.Drawing.Point(181, 254);
            this.urun_ekle.Name = "urun_ekle";
            this.urun_ekle.Size = new System.Drawing.Size(82, 31);
            this.urun_ekle.TabIndex = 0;
            this.urun_ekle.Text = "Ürün Ekle";
            this.urun_ekle.UseVisualStyleBackColor = true;
            this.urun_ekle.Click += new System.EventHandler(this.urun_ekle_Click);
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(219, 159);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(121, 20);
            this.fiyat.TabIndex = 1;
            // 
            // miktar
            // 
            this.miktar.Location = new System.Drawing.Point(219, 197);
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(121, 20);
            this.miktar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Satış Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miktar:(Kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(198, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Ekle";
            // 
            // Don
            // 
            this.Don.Location = new System.Drawing.Point(270, 254);
            this.Don.Name = "Don";
            this.Don.Size = new System.Drawing.Size(79, 30);
            this.Don.TabIndex = 4;
            this.Don.Text = "Geri dön";
            this.Don.UseVisualStyleBackColor = true;
            this.Don.Click += new System.EventHandler(this.Don_Click);
            // 
            // urunsec
            // 
            this.urunsec.FormattingEnabled = true;
            this.urunsec.Items.AddRange(new object[] {
            "Elma",
            "Armut",
            "Karpuz",
            "Buğday",
            "Arpa",
            "Yulaf",
            "Pamuk",
            "Üzüm",
            "Erik",
            "Bilgisayar",
            "Telefon"});
            this.urunsec.Location = new System.Drawing.Point(219, 114);
            this.urunsec.Name = "urunsec";
            this.urunsec.Size = new System.Drawing.Size(121, 21);
            this.urunsec.TabIndex = 5;
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 399);
            this.Controls.Add(this.urunsec);
            this.Controls.Add(this.Don);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.miktar);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.urun_ekle);
            this.Name = "UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button urun_ekle;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.TextBox miktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Don;
        private System.Windows.Forms.ComboBox urunsec;
    }
}