using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ServicioTecnicoSITEB.Reportes;

namespace ServicioTecnicoSITEB
{
    public partial class FrmMenu : Form
    {
        //para dar bordes a la ventana

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public string CargoEntreVentanas { get; set; }

        public FrmMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //if (CargoEntreVentanas == "Administrador")
            //{
            //    //MessageBox.Show("Bienvenido Administrador");
            //}
            //else if (CargoEntreVentanas == "Empleado")
            //{
            //    btnRegistroEmpleado.Visible = false;
            //    btnRegistroProducto.Visible = false;
            //}
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistroProducto_Click(object sender, EventArgs e)
        {
            //FrmRegistroProducto frmRegistroProducto = new FrmRegistroProducto();
            //this.Hide();
            //frmRegistroProducto.ShowDialog();
            //this.Close();
        }

        private void btnRegistroPedido_Click(object sender, EventArgs e)
        {
            //FrmRegistrarPedido frmFrmRegistrarPedido = new FrmRegistrarPedido();
            //frmFrmRegistrarPedido.CargoEntreVentanas = CargoEntreVentanas;
            //this.Hide();
            //frmFrmRegistrarPedido.ShowDialog();
            //this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //FrmRegistroCliente frmRegistroCliente = new FrmRegistroCliente();
            //frmRegistroCliente.CargoEntreVentanas = CargoEntreVentanas;
            //this.Hide();
            //frmRegistroCliente.ShowDialog();
            //this.Close();
        }

        private void btnRegistroEmpleado_Click(object sender, EventArgs e)
        {
            FrmRegistroEmpleados frmRegistroEmpleado = new FrmRegistroEmpleados();
            this.Hide();
            frmRegistroEmpleado.ShowDialog();
            this.Close();
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            //FrmCrearUsuario frmCrearUsuario = new FrmCrearUsuario();
            //frmCrearUsuario.ShowDialog();
            //this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //FrmInicioSesion frmInicioSesion = new FrmInicioSesion();
            //this.Hide();
            //frmInicioSesion.ShowDialog();
            //this.Close();
        }

        private void MoverVentana(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible=true;
        }

        private void btnrptA_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;

            FrmReporteCliente frmReporteCliente = new FrmReporteCliente();
            //this.Hide();
            frmReporteCliente.ShowDialog();
            //this.Close();

        }
    }
}
