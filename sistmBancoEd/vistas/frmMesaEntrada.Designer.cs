namespace sistemaHospital
{
    partial class frmMesaEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesaEntrada));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.rdAtencionClientes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdCajas = new System.Windows.Forms.RadioButton();
            this.dgvCajas = new System.Windows.Forms.DataGridView();
            this.dgvAtencionCliente = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClienteCajas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDniEntrada = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombreEntrada = new System.Windows.Forms.TextBox();
            this.dgvIngreso = new System.Windows.Forms.DataGridView();
            this.Ingreso = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNombreClientes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDniClientes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CAJAS = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCaja = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDniAtencion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClienteAtencion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtenderAC = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnAceptarClient = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtencionCliente)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).BeginInit();
            this.Ingreso.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.CAJAS.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.chkCliente);
            this.groupBox1.Controls.Add(this.rdAtencionClientes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdCajas);
            this.groupBox1.Location = new System.Drawing.Point(42, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Location = new System.Drawing.Point(37, 107);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(88, 17);
            this.chkCliente.TabIndex = 2;
            this.chkCliente.Text = "ES CLIENTE";
            this.chkCliente.UseVisualStyleBackColor = true;
            // 
            // rdAtencionClientes
            // 
            this.rdAtencionClientes.AutoSize = true;
            this.rdAtencionClientes.Location = new System.Drawing.Point(37, 68);
            this.rdAtencionClientes.Name = "rdAtencionClientes";
            this.rdAtencionClientes.Size = new System.Drawing.Size(144, 17);
            this.rdAtencionClientes.TabIndex = 3;
            this.rdAtencionClientes.TabStop = true;
            this.rdAtencionClientes.Text = "ATENCION AL CLIENTE";
            this.rdAtencionClientes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TRAMITE";
            // 
            // rdCajas
            // 
            this.rdCajas.AutoSize = true;
            this.rdCajas.Location = new System.Drawing.Point(37, 38);
            this.rdCajas.Name = "rdCajas";
            this.rdCajas.Size = new System.Drawing.Size(58, 17);
            this.rdCajas.TabIndex = 2;
            this.rdCajas.TabStop = true;
            this.rdCajas.Text = "CAJAS";
            this.rdCajas.UseVisualStyleBackColor = true;
            // 
            // dgvCajas
            // 
            this.dgvCajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajas.Location = new System.Drawing.Point(3, 67);
            this.dgvCajas.Name = "dgvCajas";
            this.dgvCajas.Size = new System.Drawing.Size(274, 182);
            this.dgvCajas.TabIndex = 2;
            // 
            // dgvAtencionCliente
            // 
            this.dgvAtencionCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtencionCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtencionCliente.Location = new System.Drawing.Point(6, 75);
            this.dgvAtencionCliente.Name = "dgvAtencionCliente";
            this.dgvAtencionCliente.Size = new System.Drawing.Size(274, 182);
            this.dgvAtencionCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, -11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CAJAS";
            // 
            // txtClienteCajas
            // 
            this.txtClienteCajas.Location = new System.Drawing.Point(134, 37);
            this.txtClienteCajas.Name = "txtClienteCajas";
            this.txtClienteCajas.Size = new System.Drawing.Size(90, 20);
            this.txtClienteCajas.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dni";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.btnSiguiente);
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.dgvIngreso);
            this.groupBox3.Location = new System.Drawing.Point(310, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 189);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mesa de Entrada";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.txtDniEntrada);
            this.groupBox7.Controls.Add(this.btnIngresar);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.txtNombreEntrada);
            this.groupBox7.Location = new System.Drawing.Point(6, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(165, 161);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, -11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "CAJAS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nombre";
            // 
            // txtDniEntrada
            // 
            this.txtDniEntrada.Location = new System.Drawing.Point(30, 71);
            this.txtDniEntrada.Name = "txtDniEntrada";
            this.txtDniEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtDniEntrada.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Dni";
            // 
            // txtNombreEntrada
            // 
            this.txtNombreEntrada.Location = new System.Drawing.Point(30, 32);
            this.txtNombreEntrada.Name = "txtNombreEntrada";
            this.txtNombreEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEntrada.TabIndex = 1;
            // 
            // dgvIngreso
            // 
            this.dgvIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngreso.Location = new System.Drawing.Point(194, 22);
            this.dgvIngreso.Name = "dgvIngreso";
            this.dgvIngreso.Size = new System.Drawing.Size(255, 162);
            this.dgvIngreso.TabIndex = 0;
            // 
            // Ingreso
            // 
            this.Ingreso.Controls.Add(this.btnAceptarClient);
            this.Ingreso.Controls.Add(this.groupBox4);
            this.Ingreso.Controls.Add(this.groupBox1);
            this.Ingreso.Location = new System.Drawing.Point(360, 216);
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.Size = new System.Drawing.Size(265, 341);
            this.Ingreso.TabIndex = 11;
            this.Ingreso.TabStop = false;
            this.Ingreso.Text = "Ingreso";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNombreClientes);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtDniClientes);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(42, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 106);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente";
            // 
            // txtNombreClientes
            // 
            this.txtNombreClientes.Location = new System.Drawing.Point(57, 26);
            this.txtNombreClientes.Name = "txtNombreClientes";
            this.txtNombreClientes.Size = new System.Drawing.Size(100, 20);
            this.txtNombreClientes.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nombre";
            // 
            // txtDniClientes
            // 
            this.txtDniClientes.Location = new System.Drawing.Point(57, 56);
            this.txtDniClientes.Name = "txtDniClientes";
            this.txtDniClientes.Size = new System.Drawing.Size(100, 20);
            this.txtDniClientes.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "DNI";
            // 
            // CAJAS
            // 
            this.CAJAS.Controls.Add(this.groupBox2);
            this.CAJAS.Controls.Add(this.btnAtender);
            this.CAJAS.Controls.Add(this.dgvCajas);
            this.CAJAS.Location = new System.Drawing.Point(30, 216);
            this.CAJAS.Name = "CAJAS";
            this.CAJAS.Size = new System.Drawing.Size(283, 341);
            this.CAJAS.TabIndex = 12;
            this.CAJAS.TabStop = false;
            this.CAJAS.Text = "CAJAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtClienteCajas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNombreCaja);
            this.groupBox2.Location = new System.Drawing.Point(6, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 70);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atendiendo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            // 
            // txtNombreCaja
            // 
            this.txtNombreCaja.Location = new System.Drawing.Point(6, 37);
            this.txtNombreCaja.Name = "txtNombreCaja";
            this.txtNombreCaja.Size = new System.Drawing.Size(90, 20);
            this.txtNombreCaja.TabIndex = 10;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.btnAtenderAC);
            this.groupBox6.Controls.Add(this.dgvAtencionCliente);
            this.groupBox6.Location = new System.Drawing.Point(654, 216);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(283, 341);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ATENCION AL CLIENTE";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtDniAtencion);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtClienteAtencion);
            this.groupBox5.Location = new System.Drawing.Point(26, 265);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 70);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Atendiendo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cliente";
            // 
            // txtDniAtencion
            // 
            this.txtDniAtencion.Location = new System.Drawing.Point(134, 37);
            this.txtDniAtencion.Name = "txtDniAtencion";
            this.txtDniAtencion.Size = new System.Drawing.Size(90, 20);
            this.txtDniAtencion.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dni";
            // 
            // txtClienteAtencion
            // 
            this.txtClienteAtencion.Location = new System.Drawing.Point(6, 37);
            this.txtClienteAtencion.Name = "txtClienteAtencion";
            this.txtClienteAtencion.Size = new System.Drawing.Size(90, 20);
            this.txtClienteAtencion.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::sistmBancoEd.Properties.Resources.logoBanco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 189);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtenderAC
            // 
            this.btnAtenderAC.Image = global::sistmBancoEd.Properties.Resources._285641_id_user_icon1;
            this.btnAtenderAC.Location = new System.Drawing.Point(104, 19);
            this.btnAtenderAC.Name = "btnAtenderAC";
            this.btnAtenderAC.Size = new System.Drawing.Size(106, 52);
            this.btnAtenderAC.TabIndex = 10;
            this.btnAtenderAC.Text = "Atender";
            this.btnAtenderAC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtenderAC.UseVisualStyleBackColor = true;
            this.btnAtenderAC.Click += new System.EventHandler(this.btnAtenderAC_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Image = global::sistmBancoEd.Properties.Resources._285641_id_user_icon1;
            this.btnAtender.Location = new System.Drawing.Point(92, 9);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(106, 56);
            this.btnAtender.TabIndex = 9;
            this.btnAtender.Text = "Atender";
            this.btnAtender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnAceptarClient
            // 
            this.btnAceptarClient.Image = global::sistmBancoEd.Properties.Resources.icoBuscar;
            this.btnAceptarClient.Location = new System.Drawing.Point(99, 278);
            this.btnAceptarClient.Name = "btnAceptarClient";
            this.btnAceptarClient.Size = new System.Drawing.Size(100, 57);
            this.btnAceptarClient.TabIndex = 15;
            this.btnAceptarClient.Text = "Aceptar";
            this.btnAceptarClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAceptarClient.UseVisualStyleBackColor = true;
            this.btnAceptarClient.Click += new System.EventHandler(this.btnAceptarClient_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = global::sistmBancoEd.Properties.Resources.imgUsuarios;
            this.btnIngresar.Location = new System.Drawing.Point(30, 101);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 54);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = global::sistmBancoEd.Properties.Resources.icoAgregr;
            this.btnSiguiente.Location = new System.Drawing.Point(495, 36);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 54);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::sistmBancoEd.Properties.Resources.icoSalir;
            this.btnSalir.Location = new System.Drawing.Point(495, 117);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 54);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMesaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 569);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.CAJAS);
            this.Controls.Add(this.Ingreso);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMesaEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesa de Entrada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtencionCliente)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).EndInit();
            this.Ingreso.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.CAJAS.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.RadioButton rdAtencionClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdCajas;
        private System.Windows.Forms.DataGridView dgvCajas;
        private System.Windows.Forms.DataGridView dgvAtencionCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClienteCajas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtNombreEntrada;
        private System.Windows.Forms.DataGridView dgvIngreso;
        private System.Windows.Forms.GroupBox Ingreso;
        private System.Windows.Forms.TextBox txtDniEntrada;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNombreClientes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDniClientes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox CAJAS;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnAtenderAC;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptarClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCaja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDniAtencion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClienteAtencion;
    }
}