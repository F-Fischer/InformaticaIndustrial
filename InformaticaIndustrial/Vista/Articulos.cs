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
    public partial class Articulos : Form
    {
        private ArticuloDAO aDAO;
        private DescripcionDAO dDAO;
        private MenuPrincipal mp;
        private TipoArticuloDAO taDAO;
        private UnidadMedidaDAO umDAO;

        public Articulos(MenuPrincipal mp)
        {
            InitializeComponent();
            aDAO = new ArticuloDAO();
            dDAO = new DescripcionDAO();
            taDAO = new TipoArticuloDAO();
            umDAO = new UnidadMedidaDAO();
            this.mp = mp;

            loadListBox();
        }

        public void loadListBox()
        {
            lbArticulos.DataSource = aDAO.getArticuloDescripcion();
            lbArticulos.ValueMember = "articulo_id";
            lbArticulos.DisplayMember = "descripcion_str";
        }

        private void lbArticulos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbArticulos.IndexFromPoint(e.Location);
            System.Collections.IList list = aDAO.getArticuloById(index +1);
            System.Collections.IList listDesc = dDAO.getDescripcionById(((articulo)(list[0])).descripcion_id);
            System.Collections.IList listTipoArticulo = taDAO.getTipoArticulosById(((articulo)(list[0])).tipo_articulo);
            System.Collections.IList listUnidadMedida = umDAO.getDescripcionUMById(((articulo)(list[0])).unidad_med);

            //cbUnidadMedida.DataSource = umDAO.getDescripcionUM();
            //cbUnidadMedida.ValueMember = "unidad_id";
            //cbUnidadMedida.DisplayMember = "descripcion_str";



            txtPre.Text = (((articulo)(list[0])).precio_std).ToString();
            txtDescripcion.Text = ((descripcion)(listDesc[0])).descripcion_str;
            txtTipoArticulo.Text = listTipoArticulo[0].ToString();
            txtUnidadMedida.Text = listUnidadMedida[0].ToString();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaArticulo aa = new AltaArticulo(this);
            aa.Show();
        }

        private void Articulos_Leave(object sender, EventArgs e)
        {
            mp.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnExplosion_Click(object sender, EventArgs e)
        {
            ArticuloDAO aDAO = new ArticuloDAO();
            int index = (int)this.lbArticulos.SelectedValue;
            List<int> lista = new List<int>();
            lista.Add(index);
            aDAO.Explosion(lista);
        }
    }
}
