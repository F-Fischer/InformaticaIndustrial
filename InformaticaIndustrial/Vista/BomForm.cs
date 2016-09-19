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
    public partial class BomForm : Form
    {
        public BomForm()
        {
            InitializeComponent();
            BomsGrid.AutoGenerateColumns = false;
            this.loadBomGrid();

        }

        private void agregarBom_Click(object sender, EventArgs e)
        {
            AgregarBom agregarBom = new AgregarBom(this);
            agregarBom.Show();
        }

        private void btnEliminarBom_Click(object sender, EventArgs e)
        {
            int rowindex = BomsGrid.CurrentCell.RowIndex;
            int id = (int)BomsGrid.Rows[rowindex].Cells["bom_id"].Value;

            BomDAO bDAO = new BomDAO();
            bDAO.deleteBom(id);
            loadBomGrid();
        }

        public void loadBomGrid()
        {
            BomDAO bDAO = new BomDAO();
            BomsGrid.DataSource = null;
            BomsGrid.DataSource = bDAO.getBoms();
        }

       
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int rowindex = BomsGrid.CurrentCell.RowIndex;
            ModificarBomForm mbf = new ModificarBomForm((int)BomsGrid.Rows[rowindex].Cells["bom_id"].Value,this);
            mbf.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
