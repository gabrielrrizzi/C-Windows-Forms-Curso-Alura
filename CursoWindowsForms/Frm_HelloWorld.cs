﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = txt_ConteudoLabel.Text;
        }
    }
}
