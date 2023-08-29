using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicioTecnicoSITEB.Datos;
using ServicioTecnicoSITEB.Negocios;

namespace ServicioTecnicoSITEB
{
    public partial class FrmRegistroProducto : Form
    {
        public string CargoEntreVentanas { get; set; }
        public FrmRegistroProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistroProducto_Load(object sender, EventArgs e)
        {
            this.GenerarIDProducto();
            this.GenerarIDEjemplar();
            this.CargarCategoria();
            this.CargarSubCategoria();
            this.CargarComboMarca();
        }
        private void GenerarIDProducto()
        {
            RNCrlProducto ObjRNCrlProducto = new RNCrlProducto();

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
        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria categoriaSeleccionada = (Categoria)cbCategoria.SelectedItem;
            RNSubcategoria ObjRnSubCategoria = new RNSubcategoria();
            List<Sub_Categoria> subcategoriasFiltradas = ObjRnSubCategoria.TraerSubCategoria(0).Where(s => s.IdCategoria == categoriaSeleccionada.Id_Categoria).ToList();
            cbSubCategoria.DataSource = subcategoriasFiltradas;
            cbSubCategoria.DisplayMember = "Nombre_SubCategoria";
            cbSubCategoria.ValueMember = "Id_SubCategoria";
        }
        private void CargarSubCategoria()
        {
            RNSubcategoria ObjRnSubCategoria = new RNSubcategoria();
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
        //Validar campos
        private bool ValidarCampo()
        {
            bool validar = true;
            if (txNombreProducto.Text == "")
            {
                validar = false;
                errorNombreProducto.SetError(txNombreProducto, "Ingrese el nombre del producto");
            }
            if (DescripcionProducto.Text == "")
            {
                validar = false;
                errorDescripcionProducto.SetError(DescripcionProducto, "Ingrese la descripcion del producto");
            }
            if (txNroSerie.Text == "")
            {
                validar = false;
                errorNroSerie.SetError(txNroSerie, "Ingrese el número de serie");
            }
            if (txDesNroSerie.Text == "")
            {
                validar = false;
                errorDescripcionNroSerie.SetError(txDesNroSerie, "Ingrese la descripcion del número de serie");
            }
            int precio;
            if (!int.TryParse(txPrecio.Text, out precio))
            {
                validar = false;
                errorDescripcionNroSerie.SetError(txPrecio, "Ingrese un número en el campo de precio");
            }
            else if (precio <= 0)
            {
                validar = false;
                errorDescripcionNroSerie.SetError(txPrecio, "Ingrese un precio válido mayor a cero");
            }
            return validar;
        }
        //BorrarMensajesDeErro
        private void BorrarErroProvider()
        {
            errorNombreProducto.SetError(txNombreProducto, "");
            errorDescripcionProducto.SetError(DescripcionProducto, "");
            errorNroSerie.SetError(txNroSerie, "");
            errorDescripcionNroSerie.SetError(txDesNroSerie, "");
            errorPrecioProducto.SetError(txPrecio, "");
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            BorrarErroProvider();
            if (ValidarCampo())
            {
                //Guardando el Producto
                RNCrlProducto ObjRNCrlProducto = new RNCrlProducto();
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

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Hide();
            frmMenu.CargoEntreVentanas = CargoEntreVentanas;
            frmMenu.ShowDialog();
            this.Close();
        }
    }
}
