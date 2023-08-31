using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioTecnicoSITEB
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptEmpleado frmReporteEmpleado = new Reportes.FrmRptEmpleado();
            frmReporteEmpleado.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptCliente frmReporteCliente = new Reportes.FrmRptCliente();
            frmReporteCliente.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptProducto frmReporteProducto = new Reportes.FrmRptProducto();
            frmReporteProducto.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptPedido frmPedido = new Reportes.FrmRptPedido();
            frmPedido.ShowDialog();
        }
    }
}
