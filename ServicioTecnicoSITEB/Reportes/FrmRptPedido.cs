using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioTecnicoSITEB.Reportes
{
    public partial class FrmRptPedido : Form
    {
        public FrmRptPedido()
        {
            InitializeComponent();
        }

        private void FrmRptPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportes.GenerarInformePedidosGenerales' Puede moverla o quitarla según sea necesario.
            this.generarInformePedidosGeneralesTableAdapter.Fill(this.reportes.GenerarInformePedidosGenerales);

            this.reportViewer1.RefreshReport();
        }
    }
}
