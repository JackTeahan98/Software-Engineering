﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoneFixSYS
{
    public partial class frmStockEnquiry : Form
    {
        public frmStockEnquiry()
        {
            InitializeComponent();
        }

        private void StockEnquiry_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageStock ms = new ManageStock();
            ms.Show();
            this.Close();
        }
    }
}
