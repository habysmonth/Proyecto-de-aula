using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.INFORMES
{
    public partial class Informe_Facturacion : Form
    {
        public Informe_Facturacion()
        {
            InitializeComponent();
        }

        private void btnVolverInformeFacturacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
