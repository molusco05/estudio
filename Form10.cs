﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudio
{
    public partial class Form10 : Form
    {
        public Form10(int op)
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modadlidade m = new Modadlidade();
            m.atualizarModalidade();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
