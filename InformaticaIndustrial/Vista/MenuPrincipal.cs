﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformaticaIndustrial.Vista
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnBOM_Click(object sender, EventArgs e)
        {
            BomForm bf = new BomForm();
            bf.Show();
            this.Hide();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Articulos a = new Articulos(this);
            a.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Deposito d = new Deposito(this);
            d.Show();
            this.Hide();
        }
    }
}
