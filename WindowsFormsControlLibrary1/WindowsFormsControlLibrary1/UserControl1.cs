﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Sayı1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
