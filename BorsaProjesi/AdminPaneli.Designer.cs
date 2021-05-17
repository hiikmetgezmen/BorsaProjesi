
namespace BorsaProjesi
{
    partial class AdminPaneli
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
            this.BakiyeOnay = new System.Windows.Forms.Button();
            this.UrunOnay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BakiyeOnay
            // 
            this.BakiyeOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BakiyeOnay.Location = new System.Drawing.Point(41, 66);
            this.BakiyeOnay.Name = "BakiyeOnay";
            this.BakiyeOnay.Size = new System.Drawing.Size(83, 73);
            this.BakiyeOnay.TabIndex = 0;
            this.BakiyeOnay.Text = "Bakiye Onay";
            this.BakiyeOnay.UseVisualStyleBackColor = true;
            this.BakiyeOnay.Click += new System.EventHandler(this.BakiyeOnay_Click);
            // 
            // UrunOnay
            // 
            this.UrunOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunOnay.Location = new System.Drawing.Point(156, 66);
            this.UrunOnay.Name = "UrunOnay";
            this.UrunOnay.Size = new System.Drawing.Size(83, 73);
            this.UrunOnay.TabIndex = 0;
            this.UrunOnay.Text = "Ürün \r\nOnay";
            this.UrunOnay.UseVisualStyleBackColor = true;
            this.UrunOnay.Click += new System.EventHandler(this.UrunOnay_Click);
            // 
            // AdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 212);
            this.Controls.Add(this.UrunOnay);
            this.Controls.Add(this.BakiyeOnay);
            this.Name = "AdminPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BakiyeOnay;
        private System.Windows.Forms.Button UrunOnay;
    }
}