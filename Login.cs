﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Kel5_Manajemen_Travel_Customer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBuatAcc_Click(object sender, EventArgs e)
        {
            BuatAcc buatAcc = new BuatAcc();
            buatAcc.ShowDialog();
            this.Close();
        }

        
    }
}
