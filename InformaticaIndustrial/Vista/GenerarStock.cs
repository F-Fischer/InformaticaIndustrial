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
    public partial class GenerarStock : Form
    {
        private ArticuloDAO aDAO;
        private Deposito d;

        public GenerarStock(Deposito d)
        {
            InitializeComponent();
            aDAO = new ArticuloDAO();
            this.d = d;
            cbArticulos.DataSource = aDAO.getProductoFinalDescripcion();
            cbArticulos.DisplayMember = "descripcion_str";
            cbArticulos.ValueMember = "articulo_id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse((txtCantidad.Text).ToString());
            System.Collections.IList articulosStock = new List<string>();
            for (int i = 0; i < cantidad; i++)
            {
                System.Collections.IList list = aDAO.getCodigoArticuloById(int.Parse((cbArticulos.SelectedValue).ToString()));
                string codigo = list[0].ToString();
                codigo += generateCode();
                codigo += generateVerificationCode(codigo);
                articulosStock.Add(codigo);
            }

            d.loadGrid(articulosStock);


        }

        private int generateCode()
        {
            DateTime date = DateTime.Now;
            long milis = (long)(date - new DateTime(1970, 1, 1)).TotalMilliseconds;
            string code = milis.ToString();
            return int.Parse(code.Substring(6, 7));

        }

        private string generateVerificationCode(string codigo)
        {
            int suma = 0;
            for (int x = codigo.Length - 1; x >= 0; x--)
                suma += int.Parse(char.IsDigit(codigo[x]) ? codigo[x].ToString() : "0") * (((codigo.Length - (x + 1)) % 6) + 2);
            int numericDigito = (11 - suma % 11);
            string digito = numericDigito == 11 ? "0" : numericDigito == 10 ? "K" : numericDigito.ToString();
            return digito;
        }
    }
}
