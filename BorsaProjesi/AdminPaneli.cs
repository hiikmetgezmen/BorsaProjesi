﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaProjesi
{
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }
        private void BakiyeOnay_Click(object sender, EventArgs e)
        {
            //BakiyeOnay sayfasına git
            BakiyeOnay frm = new BakiyeOnay();
            frm.Show();
            this.Close();
        }
           
        

        private void UrunOnay_Click(object sender, EventArgs e)
        {
            UrunOnay frm = new UrunOnay();
            frm.Show();
            this.Close();
        }
    }
}
