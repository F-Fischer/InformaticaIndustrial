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
    public partial class Stock : Form
    {

        private ArticuloDAO aDAO;
        private MenuPrincipal mp;

        public Stock(MenuPrincipal mp)
        {
            InitializeComponent();
            this.aDAO = new ArticuloDAO();
            this.mp = mp;

            cbArticulos.DataSource = aDAO.getArticuloDescripcion();
            cbArticulos.ValueMember = "articulo_id";
            cbArticulos.DisplayMember = "descripcion_str";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mp.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
