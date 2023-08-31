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
    public partial class FrmRptEmpleado : Form
    {
        public FrmRptEmpleado()
        {
            InitializeComponent();
        }

        private void FrmRptEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportes.ReporteEmpleados' Puede moverla o quitarla según sea necesario.
            this.reporteEmpleadosTableAdapter.Fill(this.reportes.ReporteEmpleados);

            this.reportViewer1.RefreshReport();
        }
    }
}
