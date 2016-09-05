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
    public partial class AltaArticulo : Form
    {
        private ArticuloDAO aDAO;
        private UnidadMedidaDAO umDAO;
        private TipoArticuloDAO taDAO;
        private Articulos art;

        public AltaArticulo(Articulos art)
        {
            InitializeComponent();
            this.aDAO = new ArticuloDAO();
            this.umDAO = new UnidadMedidaDAO();
            this.taDAO = new TipoArticuloDAO();
            this.art = art;

            cbUnidadMedida.DataSource = umDAO.getDescripcionUM();
            cbUnidadMedida.ValueMember = "unidad_id";
            cbUnidadMedida.DisplayMember = "descripcion_str";

            cbTipoArticulo.DataSource = taDAO.getTipoArticulos();
            cbTipoArticulo.ValueMember = "tipo_id";
            cbTipoArticulo.DisplayMember = "descripcion_str";
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            aDAO.addArticulo((float)Convert.ToDouble(txtPrecio.Text), txtDescripcion.Text, (int)cbTipoArticulo.SelectedValue, (int)cbUnidadMedida.SelectedValue);
            art.loadListBox();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
