using ServicioTecnicoSITEB.Datos;
using ServicioTecnicoSITEB.Negocios;
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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            this.GenerarIDProducto();
            this.GenerarIDEjemplar();
            this.CargarCategoria();
            this.CargarSubCategoria();
            this.CargarComboMarca();
        }

        private void GenerarIDProducto()
        {
            RNCtrlProducto ObjRNCrlProducto = new RNCtrlProducto();

            CodigoProducto.Text = ObjRNCrlProducto.GenerarID().ToString();
        }
        private void GenerarIDEjemplar()
        {

            RNEjemplar ObjRNejemplar = new RNEjemplar();

            CodigoEjemplar.Text = ObjRNejemplar.GenerarIDEjemplar().ToString();

        }
        private void CargarCategoria()
        {
            RNCategoria ObjCategoria = new RNCategoria();
            cbCategoria.DataSource = ObjCategoria.TraerCategoria(0);
            cbCategoria.DisplayMember = "Nombre_Categoria";
            cbCategoria.ValueMember = "Id_Categoria";
        }
        
        private void CargarSubCategoria()
        {
            RNSubCategoria ObjRnSubCategoria = new RNSubCategoria();
            cbSubCategoria.DataSource = ObjRnSubCategoria.TraerSubCategoria(0);
            cbSubCategoria.DisplayMember = "Nombre_SubCategoria";
            cbSubCategoria.ValueMember = "Id_SubCategoria";
        }
        private void CargarComboMarca()
        {
            RNMarca ObjMarca = new RNMarca();
            cbMarca.DataSource = ObjMarca.TraerMarca(0);
            cbMarca.DisplayMember = "Nombre_Marca";
            cbMarca.ValueMember = "Id_Marca";
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Marca ObjMarca = (Marca)cbMarca.SelectedItem;
            RNMarca ObjRNMarca = new RNMarca();
            List<Marca> DescripcionFiltrar = ObjRNMarca.TraerMarca(0).Where(s => s.Id_Marca == ObjMarca.Id_Marca).ToList();
            cbDesMarca.DataSource = DescripcionFiltrar;
            cbDesMarca.DisplayMember = "Descripcion_Marca";
            cbDesMarca.ValueMember = "Id_Marca";
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria categoriaSeleccionada = (Categoria)cbCategoria.SelectedItem;
            RNSubCategoria ObjRnSubCategoria = new RNSubCategoria();
            List<Sub_Categoria> subcategoriasFiltradas = ObjRnSubCategoria.TraerSubCategoria(0).Where(s => s.IdCategoria == categoriaSeleccionada.Id_Categoria).ToList();
            cbSubCategoria.DataSource = subcategoriasFiltradas;
            cbSubCategoria.DisplayMember = "Nombre_SubCategoria";
            cbSubCategoria.ValueMember = "Id_SubCategoria";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                //Guardando el Producto
                RNCtrlProducto ObjRNCrlProducto = new RNCtrlProducto();
                Producto ObjProducto = new Producto();
                ObjProducto.Id_Producto = ObjRNCrlProducto.GenerarID();
                ObjProducto.Nombre_Producto = this.txNombreProducto.Text;
                ObjProducto.Descripcion_Producto = this.DescripcionProducto.Text;
                ObjProducto.IdMarca = long.Parse(this.cbMarca.SelectedValue.ToString());
                ObjProducto.IdSubCategoria = long.Parse(this.cbSubCategoria.SelectedValue.ToString());

                //Guardando el Ejemplar
                RNEjemplar ObjRNEjemplar = new RNEjemplar();
                Ejemplar ObjEjemplar = new Ejemplar();
                ObjEjemplar.Id_Ejemplar = ObjRNEjemplar.GenerarIDEjemplar();
                ObjEjemplar.Nro_Serie = this.txNroSerie.Text;
                ObjEjemplar.Descripcion_Ejemplar = this.txDesNroSerie.Text;
                ObjEjemplar.IdProducto = ObjProducto.Id_Producto;
                ObjEjemplar.Disponible = true;

                //Guardando el Precio
                RNPrecio ObjRNPrecio = new RNPrecio();
                Precio ObjPrecio = new Precio();
                ObjPrecio.Id_Precio = ObjRNPrecio.GenerarIDPrecio();

                float precio;
                if (float.TryParse(txPrecio.Text, out precio))
                {
                    ObjPrecio.Precio_Unitario = float.Parse(precio.ToString("0.00"));
                }
                ObjPrecio.Fecha_actualizacion = DateTime.Parse(this.FechaActualizacion.Value.ToShortDateString());
                ObjPrecio.IdEjemplar = long.Parse(ObjEjemplar.Id_Ejemplar.ToString());
                RNUtilitarios.Utilitarios.id = ObjEjemplar.IdProducto;
                //insertando los Datos 
                LimpiarCuadrosTexto();
                if (ObjRNCrlProducto.InsertarDatosProducto(ObjProducto)
                    && ObjRNEjemplar.InsertarDatosEjemplar(ObjEjemplar)
                    && ObjRNPrecio.InsertarDatosPrecio(ObjPrecio))
                {
                    //this.BtnInformeProducto.Visible = true;
                    MessageBox.Show("Producto registrado con exito ");
                    //Reportes.FrmReporteProducto frmReporteProducto = new Reportes.FrmReporteProducto();
                    //frmReporteProducto.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error hubo un Problema en Producto");
                }
            }
        }

        private bool cleanCampo(TextBox campo, string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                errorProvider1.SetError(campo, mensajeError);
                return false;
            }

            errorProvider1.SetError(campo, ""); // Borrar el mensaje de error si el campo está lleno
            return true;
        }

        private bool ValidarCampos()
        {
            bool todosLosCamposValidos = true;

            todosLosCamposValidos &= cleanCampo(txDesNroSerie, "Este Campo Es Requerido");
            todosLosCamposValidos &= cleanCampo(txNombreProducto, "Este Campo Es Requerido");
            todosLosCamposValidos &= cleanCampo(txNroSerie, "Este Campo Es Requerido");
            todosLosCamposValidos &= cleanCampo(txPrecio, "Este Campo Es Requerido");
            todosLosCamposValidos &= cleanCampo(CodigoEjemplar, "Este Campo Es Requerido");
            todosLosCamposValidos &= cleanCampo(CodigoProducto, "Este Campo Es Requerido");
            todosLosCamposValidos &= cleanCampo(DescripcionProducto, "Este Campo Es Requerido");

            return todosLosCamposValidos;
        }
        private void LimpiarCuadrosTexto()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty; // Establece el texto del cuadro a una cadena vacía
                }
                else if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false; // Establece la propiedad Checked en false para el control CheckBox
                }
            }
        }
    }
}
