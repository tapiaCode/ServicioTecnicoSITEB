using ServicioTecnicoSITEB.Datos;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            CustomizePanel();
        }
        private void CustomizePanel()
        {
            // Establecer estilo redondeado
            int borderRadius = 15; // Ajusta este valor según tus preferencias
            panel1.BorderStyle = BorderStyle.None;
            panel1.BackColor = Color.Transparent;
            panel1.Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, borderRadius, borderRadius));

            // Establecer color de fondo transparente
            int alpha = 255; // Ajusta este valor para la opacidad
            panel1.BackColor = Color.FromArgb(alpha, Color.LightBlue);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cargo = "";
            string usuario = txtUser.Text;
            string contraseña = txtPassword.Text;
            using (var contexto = new DBSITEPEntities())
            {
                var usuarioBD = contexto.inicio_sesion.FirstOrDefault(u => u.usuario == usuario);
                if (usuarioBD != null && usuarioBD.clave_acceso == BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(contraseña))).Replace("-", ""))
                {
                    cargo = usuarioBD.cargo;
                    MessageBox.Show("Inicio de sesión exitoso, cargo: " + cargo);
                    this.Hide();
                    FrmMainMenu frmMainMenu = new FrmMainMenu();
                    frmMainMenu.CargoEntreVentanas = cargo;
                    frmMainMenu.ShowDialog();
                    this.Close();

                }
                else
                {
                    txtPassword.Text = "";
                    MessageBox.Show("Usuario o contraseña incorrectos"); //mejorar esto basic
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }

    public static class Utils
    {
        // Función para crear una región de rectángulo redondeado
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);
    }
}
