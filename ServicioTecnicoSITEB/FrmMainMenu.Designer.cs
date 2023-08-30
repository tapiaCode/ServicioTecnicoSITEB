namespace ServicioTecnicoSITEB
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnRegistroUsuario = new System.Windows.Forms.Button();
            this.btnRegistroEmpleado = new System.Windows.Forms.Button();
            this.btnRegistroCliente = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(96)))), ((int)(((byte)(141)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnInformes);
            this.panelMenu.Controls.Add(this.btnRegistroUsuario);
            this.panelMenu.Controls.Add(this.btnRegistroEmpleado);
            this.panelMenu.Controls.Add(this.btnRegistroCliente);
            this.panelMenu.Controls.Add(this.btnProducto);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 771);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(96)))), ((int)(((byte)(141)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(300, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1112, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(355, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(300, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1112, 691);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 80);
            this.button1.TabIndex = 6;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnInformes.ForeColor = System.Drawing.Color.White;
            this.btnInformes.Image = ((System.Drawing.Image)(resources.GetObject("btnInformes.Image")));
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(0, 480);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(300, 80);
            this.btnInformes.TabIndex = 5;
            this.btnInformes.Text = "   INFORMES";
            this.btnInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnRegistroUsuario
            // 
            this.btnRegistroUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroUsuario.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistroUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRegistroUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroUsuario.Image")));
            this.btnRegistroUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroUsuario.Location = new System.Drawing.Point(0, 400);
            this.btnRegistroUsuario.Name = "btnRegistroUsuario";
            this.btnRegistroUsuario.Size = new System.Drawing.Size(300, 80);
            this.btnRegistroUsuario.TabIndex = 4;
            this.btnRegistroUsuario.Text = "   REGISTRO USUARIO";
            this.btnRegistroUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistroUsuario.UseVisualStyleBackColor = true;
            this.btnRegistroUsuario.Click += new System.EventHandler(this.btnRegistroUsuario_Click);
            // 
            // btnRegistroEmpleado
            // 
            this.btnRegistroEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroEmpleado.FlatAppearance.BorderSize = 0;
            this.btnRegistroEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroEmpleado.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistroEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnRegistroEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroEmpleado.Image")));
            this.btnRegistroEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroEmpleado.Location = new System.Drawing.Point(0, 320);
            this.btnRegistroEmpleado.Name = "btnRegistroEmpleado";
            this.btnRegistroEmpleado.Size = new System.Drawing.Size(300, 80);
            this.btnRegistroEmpleado.TabIndex = 3;
            this.btnRegistroEmpleado.Text = "   REGISTRO EMPLEADO";
            this.btnRegistroEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistroEmpleado.UseVisualStyleBackColor = true;
            this.btnRegistroEmpleado.Click += new System.EventHandler(this.btnRegistroEmpleado_Click);
            // 
            // btnRegistroCliente
            // 
            this.btnRegistroCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroCliente.FlatAppearance.BorderSize = 0;
            this.btnRegistroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroCliente.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistroCliente.ForeColor = System.Drawing.Color.White;
            this.btnRegistroCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroCliente.Image")));
            this.btnRegistroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroCliente.Location = new System.Drawing.Point(0, 240);
            this.btnRegistroCliente.Name = "btnRegistroCliente";
            this.btnRegistroCliente.Size = new System.Drawing.Size(300, 80);
            this.btnRegistroCliente.TabIndex = 2;
            this.btnRegistroCliente.Text = "   REGISTRO CLIENTE";
            this.btnRegistroCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistroCliente.UseVisualStyleBackColor = true;
            this.btnRegistroCliente.Click += new System.EventHandler(this.btnRegistroCliente_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(0, 160);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(300, 80);
            this.btnProducto.TabIndex = 1;
            this.btnProducto.Text = "   PRODUCTOS";
            this.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(96)))), ((int)(((byte)(141)))));
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Bold);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 80);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(300, 80);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "   VENTAS";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(96)))), ((int)(((byte)(141)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(300, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 771);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainMenu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnRegistroUsuario;
        private System.Windows.Forms.Button btnRegistroEmpleado;
        private System.Windows.Forms.Button btnRegistroCliente;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button button1;
    }
}