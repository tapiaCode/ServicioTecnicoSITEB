using RNUtilitarios;
using ServicioTecnicoSITEB.Datos;
using ServicioTecnicoSITEB.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioTecnicoSITEB
{
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }

        public static string CalcularHashSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertir el texto en bytes
                byte[] bytes = Encoding.UTF8.GetBytes(texto);

                // Calcular el hash
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Convertir el hash en una cadena hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Int64 id = Convert.ToInt64(selectedRow.Cells["id"].Value);

                Utilitarios.id = id;
            }
        }

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            RNUsuario objRNUsuario = new RNUsuario();
            if (this.txtBuscar.Text == "")
            {
                this.dataGridView1.DataSource = (objRNUsuario.TraerUsuarios(0));
                Utilitarios.id = 0;
            }
            else
            {
                if (objRNUsuario.TraerUsuariosPorNombre(this.txtBuscar.Text).Count > 0)
                {
                    this.dataGridView1.DataSource = (objRNUsuario.TraerUsuariosPorNombre(this.txtBuscar.Text));
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            RNUsuario objRNUsuario = new RNUsuario();
            inicio_sesion usuario = new inicio_sesion();
            usuario.id = objRNUsuario.GenerarID();
            usuario.usuario = this.TxtNombreUsuario.Text;
            usuario.clave_acceso = CalcularHashSHA256((this.TxtContraseña.Text).ToUpper());
            usuario.cargo = this.cbCargoUsuario.Text;
            if (objRNUsuario.InsertarUsuario(usuario))
            {
                MessageBox.Show("Usuario creado con éxito.");
                this.dataGridView1.DataSource = objRNUsuario.TraerUsuarios(usuario.id);
                Utilitarios.id = usuario.id;
            }
            else
            {
                MessageBox.Show("Error al crear usuario.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Int64 id = Convert.ToInt64(selectedRow.Cells["id"].Value);

                RNUsuario objRNUsuario = new RNUsuario();
                inicio_sesion usuario = objRNUsuario.TraerUsuarios(id).FirstOrDefault();

                if (usuario != null)
                {
                    DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar este Usuario?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bool deletionSuccessful = objRNUsuario.EliminarUsuario(usuario);

                        if (deletionSuccessful)
                        {
                            dataGridView1.DataSource = null;
                            MessageBox.Show("Usuario eliminado excitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al intentar eliminar el Usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una columna por favor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
