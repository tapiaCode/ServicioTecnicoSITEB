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
    public partial class FrmRegistroCliente : Form
    {
        public string CargoEntreVentanas { get; set; }
        public FrmRegistroCliente()
        {
            InitializeComponent();
        }
        private void GenerarIDCliente()
        {
            RNCtrlCliente ObjRNCliente = new RNCtrlCliente();
            txtIdCliente.Text = ObjRNCliente.GenerarId().ToString();
        }
        private void CargarComboRubro()
        {
            RNRubro ObjRnRubro = new RNRubro();
            cbRubro.DataSource = ObjRnRubro.TraerRubro(0);
            cbRubro.DisplayMember = "Nombre_Rubro";
            cbRubro.ValueMember = "Id_Rubro";
        }
        private void CargarComboZonaBarrio()
        {
            DataTable dta = new DataTable();
            dta.Columns.Add(new DataColumn("Id_Barrio"));
            dta.Columns.Add(new DataColumn("Nombre_Barrio"));
            RNDepartamento ObjRnDepartamento = new RNDepartamento();
            RNZona ObjRnZona = new RNZona();
            RNBarrio ObjRnBarrio = new RNBarrio();

            var ObjDepartamento = ObjRnDepartamento.TraerDepartamento(0);
            var ObjZona = ObjRnZona.TraerZona(0);

            foreach (Departamento dep in ObjDepartamento)
            {
                long depId = dep.Id_Departamento;
                var zonas = ObjRnZona.TraerZonaPorDepartamento(depId);

                foreach (Zona zona in zonas)
                {
                    long zonaId = zona.Id_Zona;
                    var barrios = ObjRnBarrio.TraerBarrioPorZona(zonaId);

                    foreach (Barrio barrio in barrios)
                    {
                        DataRow row = dta.NewRow();
                        row["Id_Barrio"] = barrio.Id_Barrio.ToString();
                        row["Nombre_Barrio"] = dep.Nombre_Departamento + "/" + zona.Nombre_Zona + "/" + barrio.Nombre_Barrio;
                        dta.Rows.Add(row);
                    }
                }
            }

            this.cbZona.DataSource = dta;
            this.cbZona.DisplayMember = "Nombre_Barrio";
            this.cbZona.ValueMember = "Id_Barrio";
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
            if (txtNombreCliente.Text == "")
            {
                validar = false;
                errorNombreCliente.SetError(txtNombreCliente, "Ingrese el nombre");
            }
            if (txtApellidoPaterno.Text == "")
            {
                validar = false;
                errorApellidoPaterno.SetError(txtApellidoPaterno, "Ingrese el apellido paterno");
            }
            if (txtApellidoMaterno.Text == "")
            {
                validar = false;
                errorApellidoMaterno.SetError(txtApellidoMaterno, "Ingrese el apellido materno");
            }
            if (txtDocumentoIdentidad.Text == "")
            {
                validar = false;
                errorCarnetIdentidad.SetError(txtDocumentoIdentidad, "Ingrese el carnet de identidad");
            }
            if (cbRubro.SelectedIndex == -1)
            {
                validar = false;
                errorRubro.SetError(cbRubro, "Selecciona un rubro.");
            }
            if (txtTelefonoPersonal.Text == "")
            {
                validar = false;
                errorTelefonoPersonal.SetError(txtTelefonoPersonal, "Ingrese su telefono personal");
            }
            if (txtTelefonoFijo.Text == "")
            {
                validar = false;
                errorTelefonFijo.SetError(txtTelefonoFijo, "Ingrese el carnet de identidad");
            }
            if (txtEmailPersonal.Text == "")
            {
                validar = false;
                errorEmaiPersonal.SetError(txtEmailPersonal, "Ingrese el carnet de identidad");
            }
            if (txtEmailCoorporativo.Text == "")
            {
                validar = false;
                errorCorportativo.SetError(txtEmailCoorporativo, "Ingrese el carnet de identidad");
            }
            return validar;
        }
        //BorrarMensajesDeErro
        private void BorrarErroProvider()
        {
            errorNombreCliente.SetError(txtNombreCliente, "");
            errorApellidoPaterno.SetError(txtApellidoPaterno, "");
            errorApellidoMaterno.SetError(txtApellidoMaterno, "");
            errorCarnetIdentidad.SetError(txtDocumentoIdentidad, "");
            errorRubro.SetError(cbRubro, "");

            errorTelefonoPersonal.SetError(txtTelefonoPersonal, "");
            errorTelefonFijo.SetError(txtTelefonoFijo, "");
            errorEmaiPersonal.SetError(txtEmailPersonal, "");
            errorCorportativo.SetError(txtEmailCoorporativo, "");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BorrarErroProvider();
            if (ValidarCampo())
            {
                RNCtrlCliente ObjRNCliente = new RNCtrlCliente();
                Cliente ObjCliente = new Cliente();
                ObjCliente.Id_Cliente = ObjRNCliente.GenerarId();
                ObjCliente.Telefono_Personal = this.txtTelefonoPersonal.Text;
                ObjCliente.Telefono_Fijo = this.txtTelefonoFijo.Text;
                ObjCliente.Email_Personal = this.txtEmailPersonal.Text;
                ObjCliente.Email_Coorporativo = this.txtEmailCoorporativo.Text;
                ObjCliente.IdRubro = long.Parse(this.cbRubro.SelectedValue.ToString()); ;
                ObjCliente.IdBarrio = long.Parse(this.cbZona.SelectedValue.ToString()); ;

                Natural ObjNatural = new Natural();
                ObjNatural.Id_Natural = ObjCliente.Id_Cliente;
                ObjNatural.Nombre = this.txtNombreCliente.Text;
                ObjNatural.Apellido_Paterno = this.txtApellidoPaterno.Text;
                ObjNatural.Apellido_Materno = this.txtApellidoMaterno.Text;
                RNUtilitarios.Utilitarios.id = ObjNatural.Id_Natural;
                if (rbMaculino.Checked)
                {
                    ObjNatural.Genero = "Masculino";
                }
                else
                {
                    ObjNatural.Genero = "Femenino";
                }
                ObjNatural.Carnet_Identidad = this.txtDocumentoIdentidad.Text;
                ObjNatural.IdCliente = ObjCliente.Id_Cliente;
                //this.BtnInformeCliente.Visible = true;
                if (ObjRNCliente.InsertarClienteNatural(ObjCliente, ObjNatural))
                {
                    MessageBox.Show("El cliente natural registrado con exito");
                    //this.BtnInformeCliente.Visible = true;
                    //Reportes.FrmReporteClientes frmReporteClientes = new Reportes.FrmReporteClientes();
                    //frmReporteClientes.ShowDialog();
                    LimpiarCuadrosTexto();

                }
                else
                {
                    MessageBox.Show("Error en el registro de clientes naturales");
                }
            }
        }

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.CargoEntreVentanas = CargoEntreVentanas;
            this.Hide();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {
            this.GenerarIDCliente();
            this.CargarComboRubro();
            this.CargarComboZonaBarrio();
        }
    }
}
