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
    public partial class Crear_Factura : Form
    {
        public Crear_Factura()
        {
            InitializeComponent();
        }

        private void btnVolverFacturacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
