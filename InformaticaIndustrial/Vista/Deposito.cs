using System;
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
    public partial class Deposito : Form
    {
        private MenuPrincipal mp;

        public Deposito(MenuPrincipal mp)
        {
            InitializeComponent();
            this.mp = mp;
        }

        public void loadGrid(System.Collections.IList list)
        {
            stockGrid.DataSource = list;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            mp.Show();
            this.Close();
        }

        

        private void btnGenerarStock_Click(object sender, EventArgs e)
        {
            GenerarStock gs = new GenerarStock(this);
            gs.Show();
        }
    }
}
