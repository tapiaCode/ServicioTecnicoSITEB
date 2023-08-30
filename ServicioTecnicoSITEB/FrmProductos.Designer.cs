namespace ServicioTecnicoSITEB
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.CodigoProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDesMarca = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.DescripcionProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaActualizacion = new System.Windows.Forms.DateTimePicker();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CodigoEjemplar = new System.Windows.Forms.TextBox();
            this.txDesNroSerie = new System.Windows.Forms.TextBox();
            this.txNroSerie = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CodigoProducto.Enabled = false;
            this.CodigoProducto.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.CodigoProducto.Location = new System.Drawing.Point(193, 14);
            this.CodigoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.CodigoProducto.Multiline = true;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Size = new System.Drawing.Size(374, 36);
            this.CodigoProducto.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 174;
            this.label5.Text = "Cod. Producto:";
            // 
            // cbDesMarca
            // 
            this.cbDesMarca.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.cbDesMarca.FormattingEnabled = true;
            this.cbDesMarca.Location = new System.Drawing.Point(193, 222);
            this.cbDesMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbDesMarca.Name = "cbDesMarca";
            this.cbDesMarca.Size = new System.Drawing.Size(374, 33);
            this.cbDesMarca.TabIndex = 177;
            // 
            // cbMarca
            // 
            this.cbMarca.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(193, 182);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(374, 33);
            this.cbMarca.TabIndex = 176;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.DescripcionProducto.Location = new System.Drawing.Point(193, 98);
            this.DescripcionProducto.Margin = new System.Windows.Forms.Padding(4);
            this.DescripcionProducto.Multiline = true;
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.Size = new System.Drawing.Size(374, 77);
            this.DescripcionProducto.TabIndex = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 178;
            this.label1.Text = "Descripcioón:";
            // 
            // txNombreProducto
            // 
            this.txNombreProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txNombreProducto.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.txNombreProducto.Location = new System.Drawing.Point(193, 56);
            this.txNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txNombreProducto.Multiline = true;
            this.txNombreProducto.Name = "txNombreProducto";
            this.txNombreProducto.Size = new System.Drawing.Size(374, 36);
            this.txNombreProducto.TabIndex = 179;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 180;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 181;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 182;
            this.label4.Text = "Descripción:";
            // 
            // FechaActualizacion
            // 
            this.FechaActualizacion.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.FechaActualizacion.Location = new System.Drawing.Point(792, 261);
            this.FechaActualizacion.Margin = new System.Windows.Forms.Padding(4);
            this.FechaActualizacion.Name = "FechaActualizacion";
            this.FechaActualizacion.Size = new System.Drawing.Size(272, 34);
            this.FechaActualizacion.TabIndex = 183;
            // 
            // txPrecio
            // 
            this.txPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txPrecio.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.txPrecio.Location = new System.Drawing.Point(193, 261);
            this.txPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txPrecio.Multiline = true;
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(374, 34);
            this.txPrecio.TabIndex = 184;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 185;
            this.label6.Text = "Precio:";
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(792, 59);
            this.cbSubCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(272, 33);
            this.cbSubCategoria.TabIndex = 187;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(792, 17);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(272, 33);
            this.cbCategoria.TabIndex = 186;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(600, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 189;
            this.label7.Text = "SubCategoria:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(603, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 188;
            this.label8.Text = "Categoria:";
            // 
            // CodigoEjemplar
            // 
            this.CodigoEjemplar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CodigoEjemplar.Enabled = false;
            this.CodigoEjemplar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.CodigoEjemplar.Location = new System.Drawing.Point(792, 100);
            this.CodigoEjemplar.Margin = new System.Windows.Forms.Padding(4);
            this.CodigoEjemplar.Multiline = true;
            this.CodigoEjemplar.Name = "CodigoEjemplar";
            this.CodigoEjemplar.Size = new System.Drawing.Size(272, 37);
            this.CodigoEjemplar.TabIndex = 192;
            // 
            // txDesNroSerie
            // 
            this.txDesNroSerie.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.txDesNroSerie.Location = new System.Drawing.Point(792, 182);
            this.txDesNroSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txDesNroSerie.Multiline = true;
            this.txDesNroSerie.Name = "txDesNroSerie";
            this.txDesNroSerie.Size = new System.Drawing.Size(272, 73);
            this.txDesNroSerie.TabIndex = 191;
            // 
            // txNroSerie
            // 
            this.txNroSerie.BackColor = System.Drawing.SystemColors.Window;
            this.txNroSerie.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.txNroSerie.Location = new System.Drawing.Point(792, 139);
            this.txNroSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txNroSerie.Multiline = true;
            this.txNroSerie.Name = "txNroSerie";
            this.txNroSerie.Size = new System.Drawing.Size(272, 36);
            this.txNroSerie.TabIndex = 190;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(603, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 193;
            this.label9.Text = "Ejemplar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(603, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 194;
            this.label10.Text = "Serie:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(603, 184);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 25);
            this.label11.TabIndex = 195;
            this.label11.Text = "Descripcion:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(603, 268);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 25);
            this.label12.TabIndex = 196;
            this.label12.Text = "Fecha Registro:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.White;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.BtnGuardar.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.Location = new System.Drawing.Point(890, 581);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(191, 60);
            this.BtnGuardar.TabIndex = 197;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 379);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(824, 262);
            this.dataGridView1.TabIndex = 198;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(890, 515);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 60);
            this.button1.TabIndex = 201;
            this.button1.Text = "Imprimir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(890, 447);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(191, 60);
            this.btnEliminar.TabIndex = 200;
            this.btnEliminar.Text = " Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(890, 379);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(191, 60);
            this.btnEditar.TabIndex = 199;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 338);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(236, 25);
            this.label13.TabIndex = 202;
            this.label13.Text = "LISTA DE PRODUCTOS";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 644);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CodigoEjemplar);
            this.Controls.Add(this.txDesNroSerie);
            this.Controls.Add(this.txNroSerie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSubCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.FechaActualizacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNombreProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDesMarca);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.DescripcionProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CodigoProducto);
            this.Name = "FrmProductos";
            this.Text = "GESTION DE PRODUCTOS";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodigoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDesMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.TextBox DescripcionProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaActualizacion;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CodigoEjemplar;
        private System.Windows.Forms.TextBox txDesNroSerie;
        private System.Windows.Forms.TextBox txNroSerie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}