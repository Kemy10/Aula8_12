﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8_12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            imput2.AppendText("\r\n" + "Pressionei a tecla: " + e.KeyCode);
            imput2.AppendText("\r\n" + "\t" + "Código da tecla: " + ((int) e.KeyCode));
        }

        private void botao1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
