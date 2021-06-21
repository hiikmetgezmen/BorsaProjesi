
namespace BorsaProjesi
{
    partial class İstekUrun
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
            this.urunsec = new System.Windows.Forms.ComboBox();
            this.Don = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.miktar = new System.Windows.Forms.TextBox();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.SatinAl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.urunsec.Location = new System.Drawing.Point(209, 119);
            this.urunsec.Name = "urunsec";
            this.urunsec.Size = new System.Drawing.Size(121, 21);
            this.urunsec.TabIndex = 13;
            // 
            // Don
            // 
            this.Don.Location = new System.Drawing.Point(260, 259);
            this.Don.Name = "Don";
            this.Don.Size = new System.Drawing.Size(79, 30);
            this.Don.TabIndex = 12;
            this.Don.Text = "Geri dön";
            this.Don.UseVisualStyleBackColor = true;
            this.Don.Click += new System.EventHandler(this.Don_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Miktar:(Kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "İstediğiniz Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ürün adı:";
            // 
            // miktar
            // 
            this.miktar.Location = new System.Drawing.Point(209, 202);
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(121, 20);
            this.miktar.TabIndex = 7;
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(209, 164);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(121, 20);
            this.fiyat.TabIndex = 8;
            // 
            // SatinAl
            // 
            this.SatinAl.Location = new System.Drawing.Point(171, 259);
            this.SatinAl.Name = "SatinAl";
            this.SatinAl.Size = new System.Drawing.Size(82, 31);
            this.SatinAl.TabIndex = 6;
            this.SatinAl.Text = "Satın Al";
            this.SatinAl.UseVisualStyleBackColor = true;
            this.SatinAl.Click += new System.EventHandler(this.SatinAl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(205, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "İstek Ürün";
            // 
            // İstekUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urunsec);
            this.Controls.Add(this.Don);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.miktar);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.SatinAl);
            this.Name = "İstekUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstek Ürün";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox urunsec;
        private System.Windows.Forms.Button Don;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox miktar;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Button SatinAl;
        private System.Windows.Forms.Label label4;
    }
}