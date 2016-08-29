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
    public partial class AgregarBom : Form
    {
        private BomForm bform;

        public AgregarBom(BomForm bform)
        {
            InitializeComponent();

            this.bform = bform;
            ArticuloDAO aDAO = new ArticuloDAO();
            UnidadMedidaDAO umDAO = new UnidadMedidaDAO();
            DescripcionDAO dDAO = new DescripcionDAO();

            cbArticuloPadre.DataSource = aDAO.getArticuloDescripcion();
            cbArticuloPadre.DisplayMember = "descripcion_str";
            cbArticuloPadre.ValueMember = "articulo_id";

            cbArticuloHijo.DataSource = aDAO.getArticuloDescripcion();
            cbArticuloHijo.DisplayMember = "descripcion_str";
            cbArticuloHijo.ValueMember = "articulo_id";

            cbUnidadMedida.DataSource = umDAO.getDescripcionUM();
            cbUnidadMedida.ValueMember = "unidad_id";
            cbUnidadMedida.DisplayMember = "descripcion_str";

            dpFechaFin.ShowCheckBox = true;
            dpFechaFin.Checked = false;
            dpFechaFin.Enabled = false;
            dpFechaFin.Format = DateTimePickerFormat.Custom;
            dpFechaFin.CustomFormat = " ";
        }

        private void btnAgregarBom_Click(object sender, EventArgs e)
        {
            BomDAO bDAO = new BomDAO();
            bom bom = new bom();

            bom.articulo_padre = (int)cbArticuloPadre.SelectedValue;
            bom.articulo_hijo = (int)cbArticuloHijo.SelectedValue;
            bom.cantidad = (float)Convert.ToDouble(txtCantidad.Text);
            bom.fecha_inicio = dpFechaInicio.Value;
            if (dpFechaFin.Checked)
                bom.fecha_fin = dpFechaFin.Value;
            bom.um_id = (int)cbUnidadMedida.SelectedValue;
            bDAO.addBom(bom);
            bform.loadBomGrid();
            this.Close();
        }

        private void chkFechaFin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
