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
    public partial class ModificarBomForm : Form
    {

        private int bomId;
        private int idArticuloPadre;
        private BomDAO bDAO;
        private ArticuloDAO aDAO;
        private DescripcionDAO dDAO;
        private UnidadMedidaDAO umDAO;
        private BomForm bform;


        public ModificarBomForm(int bomId, BomForm bform)
        {
            InitializeComponent();
            this.bomId = bomId;
            this.bDAO = new BomDAO();
            this.aDAO = new ArticuloDAO();
            this.dDAO = new DescripcionDAO();
            this.umDAO = new UnidadMedidaDAO();
            this.bform = bform;

            System.Collections.IList listBoms = bDAO.getBomsById(bomId);
            idArticuloPadre = ((bom)(listBoms[0])).articulo_padre;
            System.Collections.IList listArticulos = aDAO.getArticuloById(idArticuloPadre);
            int articuloPadreDescripcionId = ((articulo)(listArticulos[0])).descripcion_id;

            System.Collections.IList listDescripcion = dDAO.getDescripcionById(articuloPadreDescripcionId);
            txtArticuloPadre.Text = ((descripcion)(listDescripcion[0])).descripcion_str;
            txtCantidad.Text = (((bom)(listBoms[0])).cantidad).ToString();
            dpFechaCreacion.Value = ((bom)(listBoms[0])).fecha_inicio;

            cbArticulos.DataSource = aDAO.getArticuloDescripcion();
            cbArticulos.DisplayMember = "descripcion_str";
            cbArticulos.ValueMember = "articulo_id";
            cbArticulos.SelectedIndex = ((bom)(listBoms[0])).articulo_hijo;

            cbUnidadMedida.DataSource = umDAO.getDescripcionUM();
            cbUnidadMedida.DisplayMember = "descripcion_str";
            cbUnidadMedida.ValueMember = "unidad_id";
            cbUnidadMedida.SelectedIndex = ((bom)(listBoms[0])).um_id;

        }

        private void ModificarBomForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bDAO.updateBom(bomId, (int)cbArticulos.SelectedIndex, (float)(Convert.ToDouble(txtCantidad.Text)), (int)cbUnidadMedida.SelectedIndex);
            bform.loadBomGrid();
            this.Close();
        }
    }
}
