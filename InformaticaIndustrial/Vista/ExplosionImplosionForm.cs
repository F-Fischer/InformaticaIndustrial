using InformaticaIndustrial.Modelos;
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
    public partial class ExplosionImplosionForm : Form
    {
        public ExplosionImplosionForm()
        {
            InitializeComponent();
            ArticuloDAO aDAO = new ArticuloDAO();
            //ArticuloGrid.AutoGenerateColumns = false;
            ArticuloGrid.DataSource = null;
            ArticuloGrid.DataSource = aDAO.getArticulos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArticuloDAO aDAO = new ArticuloDAO();
            int rowindex = ArticuloGrid.CurrentCell.RowIndex;
            int id = (int)ArticuloGrid.Rows[rowindex].Cells["articulo_id"].Value;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = aDAO.mostrarPadres(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArticuloDAO aDAO = new ArticuloDAO();
            int rowindex = ArticuloGrid.CurrentCell.RowIndex;
            int id = (int)ArticuloGrid.Rows[rowindex].Cells["articulo_id"].Value;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = aDAO.mostrarHijos(id);
        }

        
    }
}
