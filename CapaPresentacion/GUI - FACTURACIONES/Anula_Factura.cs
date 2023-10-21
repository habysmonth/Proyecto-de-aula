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
    public partial class Anula_Factura : Form
    {
        public Anula_Factura()
        {
            InitializeComponent();
        }

        private void btnVolverAnularFactura_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
