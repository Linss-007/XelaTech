namespace XelaTech
{
    partial class Colas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUrgente = new System.Windows.Forms.Label();
            this.lstUrgente = new System.Windows.Forms.ListBox();
            this.lblNormal = new System.Windows.Forms.Label();
            this.lstNormal = new System.Windows.Forms.ListBox();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnFicha = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxDiagnostico = new System.Windows.Forms.GroupBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txbDiagnostico = new System.Windows.Forms.TextBox();
            this.lblManoObra = new System.Windows.Forms.Label();
            this.txbManoObra = new System.Windows.Forms.TextBox();
            this.btnDiagnostico = new System.Windows.Forms.Button();
            this.gbxRepuesto = new System.Windows.Forms.GroupBox();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.txbRepuesto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.btnRepuesto = new System.Windows.Forms.Button();
            this.lblProceso = new System.Windows.Forms.Label();
            this.cbxEnProceso = new System.Windows.Forms.ComboBox();
            this.lblAtencion = new System.Windows.Forms.Label();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.txbCalificacion = new System.Windows.Forms.TextBox();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.lblFlujo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbxDiagnostico.SuspendLayout();
            this.gbxRepuesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("LEMON MILK Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ATENCION DE COLAS";
            // 
            // lblUrgente
            // 
            this.lblUrgente.AutoSize = true;
            this.lblUrgente.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrgente.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUrgente.Location = new System.Drawing.Point(20, 55);
            this.lblUrgente.Name = "lblUrgente";
            this.lblUrgente.Size = new System.Drawing.Size(155, 20);
            this.lblUrgente.TabIndex = 1;
            this.lblUrgente.Text = "Cola urgente (FIFO)";
            // 
            // lstUrgente
            // 
            this.lstUrgente.BackColor = System.Drawing.Color.White;
            this.lstUrgente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstUrgente.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUrgente.FormattingEnabled = true;
            this.lstUrgente.HorizontalScrollbar = true;
            this.lstUrgente.IntegralHeight = false;
            this.lstUrgente.Location = new System.Drawing.Point(20, 78);
            this.lstUrgente.Name = "lstUrgente";
            this.lstUrgente.Size = new System.Drawing.Size(450, 190);
            this.lstUrgente.TabIndex = 2;
            this.lstUrgente.SelectedIndexChanged += new System.EventHandler(this.LstUrgente_SelectedIndexChanged);
            // 
            // lblNormal
            // 
            this.lblNormal.AutoSize = true;
            this.lblNormal.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormal.ForeColor = System.Drawing.Color.Navy;
            this.lblNormal.Location = new System.Drawing.Point(480, 55);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(149, 20);
            this.lblNormal.TabIndex = 3;
            this.lblNormal.Text = "Cola normal (FIFO)";
            // 
            // lstNormal
            // 
            this.lstNormal.BackColor = System.Drawing.Color.White;
            this.lstNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNormal.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNormal.FormattingEnabled = true;
            this.lstNormal.HorizontalScrollbar = true;
            this.lstNormal.IntegralHeight = false;
            this.lstNormal.Location = new System.Drawing.Point(480, 78);
            this.lstNormal.Name = "lstNormal";
            this.lstNormal.Size = new System.Drawing.Size(450, 190);
            this.lstNormal.TabIndex = 4;
            this.lstNormal.SelectedIndexChanged += new System.EventHandler(this.LstNormal_SelectedIndexChanged);
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtender.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtender.ForeColor = System.Drawing.Color.White;
            this.btnAtender.Location = new System.Drawing.Point(20, 282);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(220, 40);
            this.btnAtender.TabIndex = 5;
            this.btnAtender.Text = "Atender siguiente";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.BtnAtender_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnIniciar.Location = new System.Drawing.Point(250, 282);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(160, 40);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar reparacion";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnFicha
            // 
            this.btnFicha.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFicha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFicha.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFicha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnFicha.Location = new System.Drawing.Point(420, 282);
            this.btnFicha.Name = "btnFicha";
            this.btnFicha.Size = new System.Drawing.Size(140, 40);
            this.btnFicha.TabIndex = 7;
            this.btnFicha.Text = "Ver resumen";
            this.btnFicha.UseVisualStyleBackColor = false;
            this.btnFicha.Click += new System.EventHandler(this.BtnFicha_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorial.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHistorial.Location = new System.Drawing.Point(570, 282);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(150, 40);
            this.btnHistorial.TabIndex = 8;
            this.btnHistorial.Text = "Historial (pila)";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeshacer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshacer.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshacer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeshacer.Location = new System.Drawing.Point(730, 282);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(100, 40);
            this.btnDeshacer.TabIndex = 9;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = false;
            this.btnDeshacer.Click += new System.EventHandler(this.BtnDeshacer_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(840, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 40);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // gbxDiagnostico
            // 
            this.gbxDiagnostico.Controls.Add(this.btnDiagnostico);
            this.gbxDiagnostico.Controls.Add(this.txbManoObra);
            this.gbxDiagnostico.Controls.Add(this.lblManoObra);
            this.gbxDiagnostico.Controls.Add(this.txbDiagnostico);
            this.gbxDiagnostico.Controls.Add(this.lblDiagnostico);
            this.gbxDiagnostico.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDiagnostico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbxDiagnostico.Location = new System.Drawing.Point(20, 335);
            this.gbxDiagnostico.Name = "gbxDiagnostico";
            this.gbxDiagnostico.Size = new System.Drawing.Size(600, 135);
            this.gbxDiagnostico.TabIndex = 11;
            this.gbxDiagnostico.TabStop = false;
            this.gbxDiagnostico.Text = "Diagnostico";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.Location = new System.Drawing.Point(12, 20);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(190, 15);
            this.lblDiagnostico.TabIndex = 0;
            this.lblDiagnostico.Text = "Diagnostico y acciones realizadas:";
            // 
            // txbDiagnostico
            // 
            this.txbDiagnostico.AcceptsReturn = true;
            this.txbDiagnostico.BackColor = System.Drawing.Color.PowderBlue;
            this.txbDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDiagnostico.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiagnostico.Location = new System.Drawing.Point(12, 42);
            this.txbDiagnostico.Multiline = true;
            this.txbDiagnostico.Name = "txbDiagnostico";
            this.txbDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDiagnostico.Size = new System.Drawing.Size(410, 72);
            this.txbDiagnostico.TabIndex = 1;
            // 
            // lblManoObra
            // 
            this.lblManoObra.AutoSize = true;
            this.lblManoObra.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManoObra.Location = new System.Drawing.Point(432, 20);
            this.lblManoObra.Name = "lblManoObra";
            this.lblManoObra.Size = new System.Drawing.Size(98, 15);
            this.lblManoObra.TabIndex = 2;
            this.lblManoObra.Text = "Mano de obra (Q):";
            // 
            // txbManoObra
            // 
            this.txbManoObra.BackColor = System.Drawing.Color.PowderBlue;
            this.txbManoObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbManoObra.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbManoObra.Location = new System.Drawing.Point(432, 42);
            this.txbManoObra.Name = "txbManoObra";
            this.txbManoObra.Size = new System.Drawing.Size(150, 22);
            this.txbManoObra.TabIndex = 3;
            // 
            // btnDiagnostico
            // 
            this.btnDiagnostico.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiagnostico.Font = new System.Drawing.Font("Roboto Bk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnostico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDiagnostico.Location = new System.Drawing.Point(432, 78);
            this.btnDiagnostico.Name = "btnDiagnostico";
            this.btnDiagnostico.Size = new System.Drawing.Size(150, 32);
            this.btnDiagnostico.TabIndex = 4;
            this.btnDiagnostico.Text = "Guardar diagnostico";
            this.btnDiagnostico.UseVisualStyleBackColor = false;
            this.btnDiagnostico.Click += new System.EventHandler(this.BtnDiagnostico_Click);
            // 
            // gbxRepuesto
            // 
            this.gbxRepuesto.Controls.Add(this.btnRepuesto);
            this.gbxRepuesto.Controls.Add(this.txbCantidad);
            this.gbxRepuesto.Controls.Add(this.lblCantidad);
            this.gbxRepuesto.Controls.Add(this.txbRepuesto);
            this.gbxRepuesto.Controls.Add(this.lblRepuesto);
            this.gbxRepuesto.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRepuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbxRepuesto.Location = new System.Drawing.Point(640, 335);
            this.gbxRepuesto.Name = "gbxRepuesto";
            this.gbxRepuesto.Size = new System.Drawing.Size(290, 135);
            this.gbxRepuesto.TabIndex = 12;
            this.gbxRepuesto.TabStop = false;
            this.gbxRepuesto.Text = "Repuesto";
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuesto.Location = new System.Drawing.Point(12, 20);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(48, 15);
            this.lblRepuesto.TabIndex = 0;
            this.lblRepuesto.Text = "Codigo:";
            // 
            // txbRepuesto
            // 
            this.txbRepuesto.BackColor = System.Drawing.Color.PowderBlue;
            this.txbRepuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRepuesto.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRepuesto.Location = new System.Drawing.Point(12, 42);
            this.txbRepuesto.Name = "txbRepuesto";
            this.txbRepuesto.Size = new System.Drawing.Size(120, 22);
            this.txbRepuesto.TabIndex = 1;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(142, 20);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(58, 15);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txbCantidad
            // 
            this.txbCantidad.BackColor = System.Drawing.Color.PowderBlue;
            this.txbCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCantidad.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(142, 42);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(60, 22);
            this.txbCantidad.TabIndex = 3;
            // 
            // btnRepuesto
            // 
            this.btnRepuesto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRepuesto.Font = new System.Drawing.Font("Roboto Bk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRepuesto.Location = new System.Drawing.Point(212, 40);
            this.btnRepuesto.Name = "btnRepuesto";
            this.btnRepuesto.Size = new System.Drawing.Size(65, 32);
            this.btnRepuesto.TabIndex = 4;
            this.btnRepuesto.Text = "Usar";
            this.btnRepuesto.UseVisualStyleBackColor = false;
            this.btnRepuesto.Click += new System.EventHandler(this.BtnRepuesto_Click);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblProceso.Location = new System.Drawing.Point(20, 476);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(210, 18);
            this.lblProceso.TabIndex = 13;
            this.lblProceso.Text = "Solicitudes asignadas / en proceso:";
            // 
            // cbxEnProceso
            // 
            this.cbxEnProceso.BackColor = System.Drawing.Color.PowderBlue;
            this.cbxEnProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnProceso.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEnProceso.FormattingEnabled = true;
            this.cbxEnProceso.Location = new System.Drawing.Point(20, 498);
            this.cbxEnProceso.Name = "cbxEnProceso";
            this.cbxEnProceso.Size = new System.Drawing.Size(610, 23);
            this.cbxEnProceso.TabIndex = 14;
            this.cbxEnProceso.SelectedIndexChanged += new System.EventHandler(this.CbxEnProceso_SelectedIndexChanged);
            // 
            // lblAtencion
            // 
            this.lblAtencion.AutoEllipsis = true;
            this.lblAtencion.BackColor = System.Drawing.Color.White;
            this.lblAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAtencion.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtencion.Location = new System.Drawing.Point(20, 530);
            this.lblAtencion.Name = "lblAtencion";
            this.lblAtencion.Size = new System.Drawing.Size(610, 35);
            this.lblAtencion.TabIndex = 15;
            this.lblAtencion.Text = "En atencion: (ninguna)";
            this.lblAtencion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCalificacion.Location = new System.Drawing.Point(645, 476);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(118, 18);
            this.lblCalificacion.TabIndex = 16;
            this.lblCalificacion.Text = "Calificacion (1-5):";
            // 
            // txbCalificacion
            // 
            this.txbCalificacion.BackColor = System.Drawing.Color.PowderBlue;
            this.txbCalificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCalificacion.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCalificacion.Location = new System.Drawing.Point(645, 498);
            this.txbCalificacion.Name = "txbCalificacion";
            this.txbCalificacion.Size = new System.Drawing.Size(70, 22);
            this.txbCalificacion.TabIndex = 17;
            // 
            // btnEntregar
            // 
            this.btnEntregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntregar.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregar.ForeColor = System.Drawing.Color.White;
            this.btnEntregar.Location = new System.Drawing.Point(725, 500);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(205, 38);
            this.btnEntregar.TabIndex = 18;
            this.btnEntregar.Text = "Entregar equipo";
            this.btnEntregar.UseVisualStyleBackColor = false;
            this.btnEntregar.Click += new System.EventHandler(this.BtnEntregar_Click);
            // 
            // lblFlujo
            // 
            this.lblFlujo.AutoSize = true;
            this.lblFlujo.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlujo.ForeColor = System.Drawing.Color.DimGray;
            this.lblFlujo.Location = new System.Drawing.Point(20, 574);
            this.lblFlujo.Name = "lblFlujo";
            this.lblFlujo.Size = new System.Drawing.Size(450, 15);
            this.lblFlujo.TabIndex = 19;
            this.lblFlujo.Text = "Flujo: Atender -> Iniciar reparacion -> Diagnostico -> Repuestos -> Entregar.";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolver.Location = new System.Drawing.Point(830, 565);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 36);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Colas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(960, 645);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblFlujo);
            this.Controls.Add(this.btnEntregar);
            this.Controls.Add(this.txbCalificacion);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.lblAtencion);
            this.Controls.Add(this.cbxEnProceso);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.gbxRepuesto);
            this.Controls.Add(this.gbxDiagnostico);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnFicha);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.lstNormal);
            this.Controls.Add(this.lblNormal);
            this.Controls.Add(this.lstUrgente);
            this.Controls.Add(this.lblUrgente);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Colas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atencion de colas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Colas_FormClosed);
            this.gbxDiagnostico.ResumeLayout(false);
            this.gbxDiagnostico.PerformLayout();
            this.gbxRepuesto.ResumeLayout(false);
            this.gbxRepuesto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUrgente;
        private System.Windows.Forms.ListBox lstUrgente;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.ListBox lstNormal;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnFicha;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbxDiagnostico;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.TextBox txbDiagnostico;
        private System.Windows.Forms.Label lblManoObra;
        private System.Windows.Forms.TextBox txbManoObra;
        private System.Windows.Forms.Button btnDiagnostico;
        private System.Windows.Forms.GroupBox gbxRepuesto;
        private System.Windows.Forms.Label lblRepuesto;
        private System.Windows.Forms.TextBox txbRepuesto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Button btnRepuesto;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.ComboBox cbxEnProceso;
        private System.Windows.Forms.Label lblAtencion;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.TextBox txbCalificacion;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.Label lblFlujo;
        private System.Windows.Forms.Button btnVolver;
    }
}
