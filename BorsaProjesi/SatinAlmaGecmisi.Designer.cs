
namespace BorsaProjesi
{
    partial class SatinAlmaGecmisi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AlisRaporu = new System.Windows.Forms.Button();
            this.SatisRaporu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(291, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alım-Satım Geçmişi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlisRaporu
            // 
            this.AlisRaporu.Location = new System.Drawing.Point(543, 129);
            this.AlisRaporu.Name = "AlisRaporu";
            this.AlisRaporu.Size = new System.Drawing.Size(96, 23);
            this.AlisRaporu.TabIndex = 3;
            this.AlisRaporu.Text = "Alış Raporu";
            this.AlisRaporu.UseVisualStyleBackColor = true;
            this.AlisRaporu.Click += new System.EventHandler(this.AlisRaporu_Click);
            // 
            // SatisRaporu
            // 
            this.SatisRaporu.Location = new System.Drawing.Point(645, 129);
            this.SatisRaporu.Name = "SatisRaporu";
            this.SatisRaporu.Size = new System.Drawing.Size(94, 23);
            this.SatisRaporu.TabIndex = 4;
            this.SatisRaporu.Text = "Satış Raporu";
            this.SatisRaporu.UseVisualStyleBackColor = true;
            this.SatisRaporu.Click += new System.EventHandler(this.SatisRaporu_Click);
            // 
            // SatinAlmaGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SatisRaporu);
            this.Controls.Add(this.AlisRaporu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SatinAlmaGecmisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatinAlmaGecmisi";
            this.Load += new System.EventHandler(this.SatinAlmaGecmisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AlisRaporu;
        private System.Windows.Forms.Button SatisRaporu;
    }
}