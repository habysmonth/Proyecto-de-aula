using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.GUI___FACTURACIONES
{
    public partial class Consultar_Factura : Form
    {
        public Consultar_Factura()
        {
            InitializeComponent();
        }

        private void btnVolverConsultarFactura_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
