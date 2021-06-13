
namespace BorsaProjesi
{
    partial class Doviz
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
            this.components = new System.ComponentModel.Container();
            this.GeriDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Miktar = new System.Windows.Forms.TextBox();
            this.ParaEkle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ParaBirimi = new System.Windows.Forms.Label();
            this.guncel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Toplam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Komisyon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GeriDon
            // 
            this.GeriDon.Location = new System.Drawing.Point(199, 311);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(74, 22);
            this.GeriDon.TabIndex = 9;
            this.GeriDon.Text = "Geri dön";
            this.GeriDon.UseVisualStyleBackColor = true;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Para Ekle - Döviz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Miktar:(tl)";
            // 
            // Miktar
            // 
            this.Miktar.Location = new System.Drawing.Point(86, 103);
            this.Miktar.Name = "Miktar";
            this.Miktar.Size = new System.Drawing.Size(107, 20);
            this.Miktar.TabIndex = 6;
            // 
            // ParaEkle
            // 
            this.ParaEkle.Location = new System.Drawing.Point(199, 282);
            this.ParaEkle.Name = "ParaEkle";
            this.ParaEkle.Size = new System.Drawing.Size(75, 23);
            this.ParaEkle.TabIndex = 5;
            this.ParaEkle.Text = "Para Ekle";
            this.ParaEkle.UseVisualStyleBackColor = true;
            this.ParaEkle.Click += new System.EventHandler(this.ParaEkle_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP"});
            this.comboBox1.Location = new System.Drawing.Point(199, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(53, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Eklenilecek Para:";
            // 
            // ParaBirimi
            // 
            this.ParaBirimi.AutoSize = true;
            this.ParaBirimi.Location = new System.Drawing.Point(38, 199);
            this.ParaBirimi.Name = "ParaBirimi";
            this.ParaBirimi.Size = new System.Drawing.Size(58, 13);
            this.ParaBirimi.TabIndex = 13;
            this.ParaBirimi.Text = "Para birimi:";
            // 
            // guncel
            // 
            this.guncel.AutoSize = true;
            this.guncel.Location = new System.Drawing.Point(102, 199);
            this.guncel.Name = "guncel";
            this.guncel.Size = new System.Drawing.Size(0, 13);
            this.guncel.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Eklenilecek Para:";
            // 
            // Toplam
            // 
            this.Toplam.AutoSize = true;
            this.Toplam.Location = new System.Drawing.Point(134, 256);
            this.Toplam.Name = "Toplam";
            this.Toplam.Size = new System.Drawing.Size(0, 13);
            this.Toplam.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Komisyon:";
            // 
            // Komisyon
            // 
            this.Komisyon.AutoSize = true;
            this.Komisyon.Location = new System.Drawing.Point(95, 226);
            this.Komisyon.Name = "Komisyon";
            this.Komisyon.Size = new System.Drawing.Size(0, 13);
            this.Komisyon.TabIndex = 18;
            // 
            // Doviz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 345);
            this.Controls.Add(this.Komisyon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Toplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guncel);
            this.Controls.Add(this.ParaBirimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GeriDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Miktar);
            this.Controls.Add(this.ParaEkle);
            this.Name = "Doviz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz";
            this.Load += new System.EventHandler(this.Doviz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeriDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Miktar;
        private System.Windows.Forms.Button ParaEkle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ParaBirimi;
        private System.Windows.Forms.Label guncel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Toplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Komisyon;
    }
}