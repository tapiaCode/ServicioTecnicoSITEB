namespace ServicioTecnicoSITEB
{
    partial class FrmRegistroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroCliente));
            this.label6 = new System.Windows.Forms.Label();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailPersonal = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.cbRubro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefonoFijo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbMaculino = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocumentoIdentidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailCoorporativo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtTelefonoPersonal = new System.Windows.Forms.TextBox();
            this.cbZona = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.errorEmaiPersonal = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombreCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellidoPaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellidoMaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCarnetIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRubro = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelefonoPersonal = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelefonFijo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCorportativo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorEmaiPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellidoPaterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellidoMaterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCarnetIdentidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefonoPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefonFijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorportativo)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(431, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 24);
            this.label6.TabIndex = 161;
            this.label6.Text = "       Codigo Cliente:";
            // 
            // BntCancelar
            // 
            this.BntCancelar.BackColor = System.Drawing.Color.White;
            this.BntCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BntCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntCancelar.ForeColor = System.Drawing.Color.Black;
            this.BntCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BntCancelar.Image")));
            this.BntCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BntCancelar.Location = new System.Drawing.Point(561, 461);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(140, 36);
            this.BntCancelar.TabIndex = 175;
            this.BntCancelar.Text = "       Cancelar";
            this.BntCancelar.UseVisualStyleBackColor = false;
            this.BntCancelar.Click += new System.EventHandler(this.BntCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(561, 401);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(140, 36);
            this.BtnGuardar.TabIndex = 163;
            this.BtnGuardar.Text = "       Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(635, 215);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCliente.Multiline = true;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(66, 24);
            this.txtIdCliente.TabIndex = 157;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.AliceBlue;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(27, 471);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 24);
            this.label12.TabIndex = 174;
            this.label12.Text = "Email corporativo:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(40, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 165;
            this.label1.Text = "Apellido Paterno:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmailPersonal
            // 
            this.txtEmailPersonal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPersonal.Location = new System.Drawing.Point(244, 429);
            this.txtEmailPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailPersonal.Multiline = true;
            this.txtEmailPersonal.Name = "txtEmailPersonal";
            this.txtEmailPersonal.Size = new System.Drawing.Size(207, 30);
            this.txtEmailPersonal.TabIndex = 160;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(245, 170);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoPaterno.Multiline = true;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(165, 28);
            this.txtApellidoPaterno.TabIndex = 150;
            // 
            // cbRubro
            // 
            this.cbRubro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRubro.FormattingEnabled = true;
            this.cbRubro.Location = new System.Drawing.Point(536, 124);
            this.cbRubro.Margin = new System.Windows.Forms.Padding(2);
            this.cbRubro.Name = "cbRubro";
            this.cbRubro.Size = new System.Drawing.Size(165, 30);
            this.cbRubro.TabIndex = 153;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.AliceBlue;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(57, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 24);
            this.label10.TabIndex = 173;
            this.label10.Text = "Email personal:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefonoFijo
            // 
            this.txtTelefonoFijo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoFijo.Location = new System.Drawing.Point(244, 385);
            this.txtTelefonoFijo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoFijo.Multiline = true;
            this.txtTelefonoFijo.Name = "txtTelefonoFijo";
            this.txtTelefonoFijo.Size = new System.Drawing.Size(165, 30);
            this.txtTelefonoFijo.TabIndex = 159;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.AliceBlue;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(83, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 24);
            this.label9.TabIndex = 172;
            this.label9.Text = "Teléfono fijo:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbMaculino
            // 
            this.rbMaculino.AutoSize = true;
            this.rbMaculino.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaculino.Location = new System.Drawing.Point(244, 257);
            this.rbMaculino.Margin = new System.Windows.Forms.Padding(2);
            this.rbMaculino.Name = "rbMaculino";
            this.rbMaculino.Size = new System.Drawing.Size(119, 26);
            this.rbMaculino.TabIndex = 155;
            this.rbMaculino.TabStop = true;
            this.rbMaculino.Text = "Masculino";
            this.rbMaculino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(34, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 24);
            this.label7.TabIndex = 171;
            this.label7.Text = "Teléfono personal:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(367, 257);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(2);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(116, 26);
            this.rbFemenino.TabIndex = 156;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(111, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 36);
            this.label5.TabIndex = 170;
            this.label5.Text = "Genero:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDocumentoIdentidad
            // 
            this.txtDocumentoIdentidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoIdentidad.Location = new System.Drawing.Point(536, 168);
            this.txtDocumentoIdentidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumentoIdentidad.Multiline = true;
            this.txtDocumentoIdentidad.Name = "txtDocumentoIdentidad";
            this.txtDocumentoIdentidad.Size = new System.Drawing.Size(165, 30);
            this.txtDocumentoIdentidad.TabIndex = 152;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(143, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 169;
            this.label4.Text = "Zona:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmailCoorporativo
            // 
            this.txtEmailCoorporativo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCoorporativo.Location = new System.Drawing.Point(244, 471);
            this.txtEmailCoorporativo.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailCoorporativo.Multiline = true;
            this.txtEmailCoorporativo.Name = "txtEmailCoorporativo";
            this.txtEmailCoorporativo.Size = new System.Drawing.Size(207, 28);
            this.txtEmailCoorporativo.TabIndex = 164;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(431, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 168;
            this.label3.Text = "Rubro:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(245, 215);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoMaterno.Multiline = true;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(164, 30);
            this.txtApellidoMaterno.TabIndex = 151;
            // 
            // txtTelefonoPersonal
            // 
            this.txtTelefonoPersonal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoPersonal.Location = new System.Drawing.Point(244, 344);
            this.txtTelefonoPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoPersonal.Multiline = true;
            this.txtTelefonoPersonal.Name = "txtTelefonoPersonal";
            this.txtTelefonoPersonal.Size = new System.Drawing.Size(165, 28);
            this.txtTelefonoPersonal.TabIndex = 158;
            // 
            // cbZona
            // 
            this.cbZona.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZona.FormattingEnabled = true;
            this.cbZona.Location = new System.Drawing.Point(244, 298);
            this.cbZona.Margin = new System.Windows.Forms.Padding(2);
            this.cbZona.Name = "cbZona";
            this.cbZona.Size = new System.Drawing.Size(384, 30);
            this.cbZona.TabIndex = 154;
            this.cbZona.Text = "Departamento / Zona / Barrio";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(456, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 167;
            this.label2.Text = "CI:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(244, 124);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.Multiline = true;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(164, 28);
            this.txtNombreCliente.TabIndex = 149;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.AliceBlue;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(33, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 24);
            this.label11.TabIndex = 166;
            this.label11.Text = "Apellido Materno:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(116, 123);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(122, 29);
            this.label8.TabIndex = 176;
            this.label8.Text = "Nombre:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(227, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(284, 31);
            this.label13.TabIndex = 177;
            this.label13.Text = "Registro De Clientes";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorEmaiPersonal
            // 
            this.errorEmaiPersonal.ContainerControl = this;
            this.errorEmaiPersonal.Icon = ((System.Drawing.Icon)(resources.GetObject("errorEmaiPersonal.Icon")));
            // 
            // errorNombreCliente
            // 
            this.errorNombreCliente.ContainerControl = this;
            this.errorNombreCliente.Icon = ((System.Drawing.Icon)(resources.GetObject("errorNombreCliente.Icon")));
            // 
            // errorApellidoPaterno
            // 
            this.errorApellidoPaterno.ContainerControl = this;
            this.errorApellidoPaterno.Icon = ((System.Drawing.Icon)(resources.GetObject("errorApellidoPaterno.Icon")));
            // 
            // errorApellidoMaterno
            // 
            this.errorApellidoMaterno.ContainerControl = this;
            this.errorApellidoMaterno.Icon = ((System.Drawing.Icon)(resources.GetObject("errorApellidoMaterno.Icon")));
            // 
            // errorCarnetIdentidad
            // 
            this.errorCarnetIdentidad.ContainerControl = this;
            this.errorCarnetIdentidad.Icon = ((System.Drawing.Icon)(resources.GetObject("errorCarnetIdentidad.Icon")));
            // 
            // errorRubro
            // 
            this.errorRubro.ContainerControl = this;
            this.errorRubro.Icon = ((System.Drawing.Icon)(resources.GetObject("errorRubro.Icon")));
            // 
            // errorTelefonoPersonal
            // 
            this.errorTelefonoPersonal.ContainerControl = this;
            this.errorTelefonoPersonal.Icon = ((System.Drawing.Icon)(resources.GetObject("errorTelefonoPersonal.Icon")));
            // 
            // errorTelefonFijo
            // 
            this.errorTelefonFijo.ContainerControl = this;
            this.errorTelefonFijo.Icon = ((System.Drawing.Icon)(resources.GetObject("errorTelefonFijo.Icon")));
            // 
            // errorCorportativo
            // 
            this.errorCorportativo.ContainerControl = this;
            this.errorCorportativo.Icon = ((System.Drawing.Icon)(resources.GetObject("errorCorportativo.Icon")));
            // 
            // FrmRegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(730, 545);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BntCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailPersonal);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.cbRubro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTelefonoFijo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbMaculino);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbFemenino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDocumentoIdentidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailCoorporativo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtTelefonoPersonal);
            this.Controls.Add(this.cbZona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroCliente";
            this.Text = "FrmRegistroCliente";
            this.Load += new System.EventHandler(this.FrmRegistroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorEmaiPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellidoPaterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellidoMaterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCarnetIdentidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefonoPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefonFijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorportativo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailPersonal;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.ComboBox cbRubro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefonoFijo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbMaculino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocumentoIdentidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailCoorporativo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtTelefonoPersonal;
        private System.Windows.Forms.ComboBox cbZona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorEmaiPersonal;
        private System.Windows.Forms.ErrorProvider errorNombreCliente;
        private System.Windows.Forms.ErrorProvider errorApellidoPaterno;
        private System.Windows.Forms.ErrorProvider errorApellidoMaterno;
        private System.Windows.Forms.ErrorProvider errorCarnetIdentidad;
        private System.Windows.Forms.ErrorProvider errorRubro;
        private System.Windows.Forms.ErrorProvider errorTelefonoPersonal;
        private System.Windows.Forms.ErrorProvider errorTelefonFijo;
        private System.Windows.Forms.ErrorProvider errorCorportativo;
    }
}