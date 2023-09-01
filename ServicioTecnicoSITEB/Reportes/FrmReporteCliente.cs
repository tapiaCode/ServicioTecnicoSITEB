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
    public partial class FrmReporteCliente : Form
    {
        public FrmReporteCliente()
        {
            InitializeComponent();
        }

        private void FrmReporteCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportes.GenerateClienteReport' Puede moverla o quitarla según sea necesario.
            this.generateClienteReportTableAdapter.Fill(this.reportes.GenerateClienteReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
