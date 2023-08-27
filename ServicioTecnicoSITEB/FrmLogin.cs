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
    }

    public static class Utils
    {
        // Función para crear una región de rectángulo redondeado
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);
    }
}
