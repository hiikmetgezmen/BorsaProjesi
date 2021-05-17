
namespace BorsaProjesi
{
    partial class KullaniciEkrani
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
            this.urunekle = new System.Windows.Forms.Button();
            this.satinal = new System.Windows.Forms.Button();
            this.paraekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            this.fatura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // urunekle
            // 
            this.urunekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunekle.Location = new System.Drawing.Point(179, 68);
            this.urunekle.Name = "urunekle";
            this.urunekle.Size = new System.Drawing.Size(96, 72);
            this.urunekle.TabIndex = 0;
            this.urunekle.Text = "Ürün Ekle";
            this.urunekle.UseVisualStyleBackColor = true;
            this.urunekle.Click += new System.EventHandler(this.urunekle_Click);
            // 
            // satinal
            // 
            this.satinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satinal.Location = new System.Drawing.Point(281, 68);
            this.satinal.Name = "satinal";
            this.satinal.Size = new System.Drawing.Size(96, 72);
            this.satinal.TabIndex = 0;
            this.satinal.Text = "Satın Al";
            this.satinal.UseVisualStyleBackColor = true;
            this.satinal.Click += new System.EventHandler(this.satinal_Click);
            // 
            // paraekle
            // 
            this.paraekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paraekle.Location = new System.Drawing.Point(383, 68);
            this.paraekle.Name = "paraekle";
            this.paraekle.Size = new System.Drawing.Size(96, 72);
            this.paraekle.TabIndex = 0;
            this.paraekle.Text = "Para Ekle";
            this.paraekle.UseVisualStyleBackColor = true;
            this.paraekle.Click += new System.EventHandler(this.paraekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(164, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(168, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 199);
            this.dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hoşgeldiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(167, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ürünlerim";
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(699, 415);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(75, 23);
            this.cikis.TabIndex = 0;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // fatura
            // 
            this.fatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fatura.Location = new System.Drawing.Point(486, 68);
            this.fatura.Name = "fatura";
            this.fatura.Size = new System.Drawing.Size(84, 72);
            this.fatura.TabIndex = 0;
            this.fatura.Text = "Alım-Satım Geçmişi";
            this.fatura.UseVisualStyleBackColor = true;
            this.fatura.Click += new System.EventHandler(this.fatura_Click);
            // 
            // KullaniciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fatura);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paraekle);
            this.Controls.Add(this.satinal);
            this.Controls.Add(this.urunekle);
            this.Name = "KullaniciEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciEkrani";
            this.Load += new System.EventHandler(this.KullaniciEkrani_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button urunekle;
        private System.Windows.Forms.Button satinal;
        private System.Windows.Forms.Button paraekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button fatura;
    }
}