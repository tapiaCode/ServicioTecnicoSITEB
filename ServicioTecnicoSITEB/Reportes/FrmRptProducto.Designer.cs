namespace ServicioTecnicoSITEB.Reportes
{
    partial class FrmRptProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportes = new ServicioTecnicoSITEB.Reportes.Informes.Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteProductosTableAdapter = new ServicioTecnicoSITEB.Reportes.Informes.ReportesTableAdapters.ReporteProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteProductosBindingSource
            // 
            this.reporteProductosBindingSource.DataMember = "ReporteProductos";
            this.reporteProductosBindingSource.DataSource = this.reportes;
            // 
            // reportes
            // 
            this.reportes.DataSetName = "Reportes";
            this.reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "ReporteProducto";
            reportDataSource2.Value = this.reporteProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ServicioTecnicoSITEB.Reportes.Informes.ReporteProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1412, 771);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteProductosTableAdapter
            // 
            this.reporteProductosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRptProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 771);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRptProducto";
            this.Load += new System.EventHandler(this.FrmRptProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Informes.Reportes reportes;
        private System.Windows.Forms.BindingSource reporteProductosBindingSource;
        private Informes.ReportesTableAdapters.ReporteProductosTableAdapter reporteProductosTableAdapter;
    }
}