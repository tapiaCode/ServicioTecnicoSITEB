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
    public partial class FrmEditarEmpleado : Form
    {
        private VistaEmpleadoCargo empleado;
        public FrmEditarEmpleado(VistaEmpleadoCargo empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
        }

        private void FrmEditarEmpleado_Load(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                txtNombreEmpleado.Text = empleado.Nombre_Empleado;
                txtApellidoPaterno.Text = empleado.Apellido_Paterno;
                txtApellidoMaterno.Text = empleado.Apellido_Materno;
                dpFechaNacimiento.Text = Convert.ToString(empleado.Fecha_Nacimiento);
                txtCI.Text = empleado.Carnet_Identidad;
                cbCargo.Text = empleado.Nombre_Cargo;
            }
            CargarComboCargo();
        }

        private void CargarComboCargo()
        {
            RNCargo ObjRnCargo = new RNCargo();
            cbCargo.DataSource = ObjRnCargo.TraerCargo(0);
            cbCargo.DisplayMember = "Nombre_Cargo";
            cbCargo.ValueMember = "Id_Cargo";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.Nombre_Empleado = txtNombreEmpleado.Text;
                empleado.Apellido_Paterno = txtApellidoPaterno.Text;
                empleado.Apellido_Materno = txtApellidoMaterno.Text;
                empleado.Fecha_Nacimiento = Convert.ToDateTime(dpFechaNacimiento.Text);
                empleado.Carnet_Identidad = txtCI.Text;
                empleado.Nombre_Cargo = cbCargo.Text;

                RNCtrlEmpleado objCtrlEmpleado = new RNCtrlEmpleado();
                bool editSuccessful = objCtrlEmpleado.EditarEmpleado(empleado);

                if (editSuccessful)
                {
                    MessageBox.Show("Cambios guardados exitosamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al intentar guardar los cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            this.Hide();
            frmMainMenu.ShowDialog();
            this.Close(); //opcional
        }
    }
}
