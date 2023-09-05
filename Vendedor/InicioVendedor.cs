using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaborACielo.Vendedor
{
    public partial class InicioV : Form
    {
        public InicioV()
        {
            InitializeComponent();
        }


        private void BAgregarCliente_Click(object sender, EventArgs e)
        {
            //open formulario de lista de clientes
        }

        private void BListarVentas_Click(object sender, EventArgs e)
        {
            //Open formulario de ventas realizadas
        }

        private void BListaProd_Click(object sender, EventArgs e)
        {
            //Open Lista de productos
        }

        private void BFactura_Click(object sender, EventArgs e)
        {
            //open generar factura y lista de facturas del cliente
        }
    }
}
