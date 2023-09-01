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
    public partial class FrmRptProducto : Form
    {
        public FrmRptProducto()
        {
            InitializeComponent();
        }

        private void FrmRptProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportes.ReporteProductos' Puede moverla o quitarla según sea necesario.
            this.reporteProductosTableAdapter.Fill(this.reportes.ReporteProductos);

            this.reportViewer1.RefreshReport();
        }
    }
}
