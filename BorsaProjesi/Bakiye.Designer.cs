
namespace BorsaProjesi
{
    partial class Bakiye
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
            this.ParaEkle = new System.Windows.Forms.Button();
            this.Miktar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParaEkle
            // 
            this.ParaEkle.Location = new System.Drawing.Point(81, 146);
            this.ParaEkle.Name = "ParaEkle";
            this.ParaEkle.Size = new System.Drawing.Size(75, 23);
            this.ParaEkle.TabIndex = 0;
            this.ParaEkle.Text = "Para Ekle";
            this.ParaEkle.UseVisualStyleBackColor = true;
            this.ParaEkle.Click += new System.EventHandler(this.ParaEkle_Click);
            // 
            // Miktar
            // 
            this.Miktar.Location = new System.Drawing.Point(69, 108);
            this.Miktar.Name = "Miktar";
            this.Miktar.Size = new System.Drawing.Size(100, 20);
            this.Miktar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miktar:(tl)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Para Ekle";
            // 
            // GeriDon
            // 
            this.GeriDon.Location = new System.Drawing.Point(142, 229);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(74, 22);
            this.GeriDon.TabIndex = 4;
            this.GeriDon.Text = "Geri dön";
            this.GeriDon.UseVisualStyleBackColor = true;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // Bakiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 263);
            this.Controls.Add(this.GeriDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Miktar);
            this.Controls.Add(this.ParaEkle);
            this.Name = "Bakiye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakiye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ParaEkle;
        private System.Windows.Forms.TextBox Miktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GeriDon;
    }
}