namespace ServicioTecnicoSITEB
{
    partial class FrmRegistroProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroProducto));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDesMarca = new System.Windows.Forms.ComboBox();
            this.CodigoEjemplar = new System.Windows.Forms.TextBox();
            this.txDesNroSerie = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txNroSerie = new System.Windows.Forms.TextBox();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.FechaActualizacion = new System.Windows.Forms.DateTimePicker();
            this.DescripcionProducto = new System.Windows.Forms.TextBox();
            this.txNombreProducto = new System.Windows.Forms.TextBox();
            this.CodigoProducto = new System.Windows.Forms.TextBox();
            this.errorNombreProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcionProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNroSerie = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcionNroSerie = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrecioProducto = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcionProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNroSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcionNroSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecioProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(618, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 177;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.AliceBlue;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(493, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(311, 48);
            this.label10.TabIndex = 176;
            this.label10.Text = "Descripcion número de serie";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.AliceBlue;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(48, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(219, 24);
            this.label14.TabIndex = 175;
            this.label14.Text = "Número de serie:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.AliceBlue;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(48, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 24);
            this.label9.TabIndex = 174;
            this.label9.Text = "Codigo ejemplar:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(79, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 173;
            this.label4.Text = "Subcategoria:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(115, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 172;
            this.label5.Text = "Categoria:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.btnGuardarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarProducto.Image")));
            this.btnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProducto.Location = new System.Drawing.Point(605, 408);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(131, 49);
            this.btnGuardarProducto.TabIndex = 171;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(79, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 24);
            this.label3.TabIndex = 170;
            this.label3.Text = "Fecha de actualización";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.AliceBlue;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(149, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 24);
            this.label12.TabIndex = 169;
            this.label12.Text = "Precio:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(23, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 24);
            this.label7.TabIndex = 168;
            this.label7.Text = "Descripcion marca:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(153, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 167;
            this.label6.Text = "Marca:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(520, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 24);
            this.label2.TabIndex = 166;
            this.label2.Text = "Descripcion producto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(35, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 165;
            this.label1.Text = "Nombre producto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(-151, -48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 24);
            this.label13.TabIndex = 164;
            this.label13.Text = "Código producto:";
            // 
            // BntCancelar
            // 
            this.BntCancelar.BackColor = System.Drawing.Color.AliceBlue;
            this.BntCancelar.FlatAppearance.BorderSize = 0;
            this.BntCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BntCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntCancelar.ForeColor = System.Drawing.Color.Black;
            this.BntCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BntCancelar.Image")));
            this.BntCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BntCancelar.Location = new System.Drawing.Point(605, 475);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(131, 49);
            this.BntCancelar.TabIndex = 163;
            this.BntCancelar.Text = "Cancelar";
            this.BntCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BntCancelar.UseVisualStyleBackColor = false;
            this.BntCancelar.Click += new System.EventHandler(this.BntCancelar_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(203, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(464, 44);
            this.label8.TabIndex = 162;
            this.label8.Text = "Registro De Un Nuevo Producto";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDesMarca
            // 
            this.cbDesMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDesMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDesMarca.FormattingEnabled = true;
            this.cbDesMarca.Location = new System.Drawing.Point(273, 175);
            this.cbDesMarca.Name = "cbDesMarca";
            this.cbDesMarca.Size = new System.Drawing.Size(201, 30);
            this.cbDesMarca.TabIndex = 161;
            // 
            // CodigoEjemplar
            // 
            this.CodigoEjemplar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CodigoEjemplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodigoEjemplar.Enabled = false;
            this.CodigoEjemplar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoEjemplar.Location = new System.Drawing.Point(273, 359);
            this.CodigoEjemplar.Multiline = true;
            this.CodigoEjemplar.Name = "CodigoEjemplar";
            this.CodigoEjemplar.Size = new System.Drawing.Size(93, 31);
            this.CodigoEjemplar.TabIndex = 160;
            // 
            // txDesNroSerie
            // 
            this.txDesNroSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txDesNroSerie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDesNroSerie.Location = new System.Drawing.Point(515, 286);
            this.txDesNroSerie.Multiline = true;
            this.txDesNroSerie.Name = "txDesNroSerie";
            this.txDesNroSerie.Size = new System.Drawing.Size(279, 86);
            this.txDesNroSerie.TabIndex = 159;
            // 
            // cbMarca
            // 
            this.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(273, 139);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(201, 30);
            this.cbMarca.TabIndex = 158;
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(273, 249);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(201, 30);
            this.cbSubCategoria.TabIndex = 157;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(273, 211);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(201, 30);
            this.cbCategoria.TabIndex = 156;
            // 
            // txNroSerie
            // 
            this.txNroSerie.BackColor = System.Drawing.SystemColors.Window;
            this.txNroSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txNroSerie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNroSerie.Location = new System.Drawing.Point(273, 287);
            this.txNroSerie.Multiline = true;
            this.txNroSerie.Name = "txNroSerie";
            this.txNroSerie.Size = new System.Drawing.Size(201, 30);
            this.txNroSerie.TabIndex = 155;
            // 
            // txPrecio
            // 
            this.txPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrecio.Location = new System.Drawing.Point(273, 323);
            this.txPrecio.Multiline = true;
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(131, 30);
            this.txPrecio.TabIndex = 154;
            // 
            // FechaActualizacion
            // 
            this.FechaActualizacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaActualizacion.Location = new System.Drawing.Point(83, 469);
            this.FechaActualizacion.Name = "FechaActualizacion";
            this.FechaActualizacion.Size = new System.Drawing.Size(388, 29);
            this.FechaActualizacion.TabIndex = 153;
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescripcionProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionProducto.Location = new System.Drawing.Point(515, 138);
            this.DescripcionProducto.Multiline = true;
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.Size = new System.Drawing.Size(269, 82);
            this.DescripcionProducto.TabIndex = 152;
            // 
            // txNombreProducto
            // 
            this.txNombreProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txNombreProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombreProducto.Location = new System.Drawing.Point(273, 103);
            this.txNombreProducto.Multiline = true;
            this.txNombreProducto.Name = "txNombreProducto";
            this.txNombreProducto.Size = new System.Drawing.Size(201, 30);
            this.txNombreProducto.TabIndex = 151;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CodigoProducto.Enabled = false;
            this.CodigoProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoProducto.Location = new System.Drawing.Point(44, -49);
            this.CodigoProducto.Multiline = true;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Size = new System.Drawing.Size(119, 30);
            this.CodigoProducto.TabIndex = 150;
            // 
            // errorNombreProducto
            // 
            this.errorNombreProducto.ContainerControl = this;
            this.errorNombreProducto.Icon = ((System.Drawing.Icon)(resources.GetObject("errorNombreProducto.Icon")));
            // 
            // errorDescripcionProducto
            // 
            this.errorDescripcionProducto.ContainerControl = this;
            this.errorDescripcionProducto.Icon = ((System.Drawing.Icon)(resources.GetObject("errorDescripcionProducto.Icon")));
            // 
            // errorNroSerie
            // 
            this.errorNroSerie.ContainerControl = this;
            this.errorNroSerie.Icon = ((System.Drawing.Icon)(resources.GetObject("errorNroSerie.Icon")));
            // 
            // errorDescripcionNroSerie
            // 
            this.errorDescripcionNroSerie.ContainerControl = this;
            this.errorDescripcionNroSerie.Icon = ((System.Drawing.Icon)(resources.GetObject("errorDescripcionNroSerie.Icon")));
            // 
            // errorPrecioProducto
            // 
            this.errorPrecioProducto.ContainerControl = this;
            this.errorPrecioProducto.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPrecioProducto.Icon")));
            // 
            // FrmRegistroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(830, 545);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BntCancelar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbDesMarca);
            this.Controls.Add(this.CodigoEjemplar);
            this.Controls.Add(this.txDesNroSerie);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbSubCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txNroSerie);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.FechaActualizacion);
            this.Controls.Add(this.DescripcionProducto);
            this.Controls.Add(this.txNombreProducto);
            this.Controls.Add(this.CodigoProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroProducto";
            this.Text = "FrmRegistroProducto";
            this.Load += new System.EventHandler(this.FrmRegistroProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcionProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNroSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcionNroSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecioProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDesMarca;
        private System.Windows.Forms.TextBox CodigoEjemplar;
        private System.Windows.Forms.TextBox txDesNroSerie;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txNroSerie;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.DateTimePicker FechaActualizacion;
        private System.Windows.Forms.TextBox DescripcionProducto;
        private System.Windows.Forms.TextBox txNombreProducto;
        private System.Windows.Forms.TextBox CodigoProducto;
        private System.Windows.Forms.ErrorProvider errorNombreProducto;
        private System.Windows.Forms.ErrorProvider errorDescripcionProducto;
        private System.Windows.Forms.ErrorProvider errorNroSerie;
        private System.Windows.Forms.ErrorProvider errorDescripcionNroSerie;
        private System.Windows.Forms.ErrorProvider errorPrecioProducto;
    }
}