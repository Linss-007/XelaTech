namespace XelaTech
{
    partial class ActualizarSolicitud
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
            this.txtActuSoli = new System.Windows.Forms.Label();
            this.btnBuscarSoli = new System.Windows.Forms.Button();
            this.txbBuscarSoli = new System.Windows.Forms.TextBox();
            this.lblInfoSoli = new System.Windows.Forms.Label();
            this.txtTecnicoSoli = new System.Windows.Forms.Label();
            this.txbTecnicoSoli = new System.Windows.Forms.TextBox();
            this.btnAsignarSoli = new System.Windows.Forms.Button();
            this.btnIniciarSoli = new System.Windows.Forms.Button();
            this.btnCancelarSoli = new System.Windows.Forms.Button();
            this.btnDeshacerSoli = new System.Windows.Forms.Button();
            this.txtDiagSoli = new System.Windows.Forms.Label();
            this.txbDiagSoli = new System.Windows.Forms.TextBox();
            this.txtManoSoli = new System.Windows.Forms.Label();
            this.txbManoSoli = new System.Windows.Forms.TextBox();
            this.btnDiagSoli = new System.Windows.Forms.Button();
            this.txtRepSoli = new System.Windows.Forms.Label();
            this.txbRepuestoSoli = new System.Windows.Forms.TextBox();
            this.txtCantSoli = new System.Windows.Forms.Label();
            this.txbCantRepSoli = new System.Windows.Forms.TextBox();
            this.btnRepSoli = new System.Windows.Forms.Button();
            this.txtCalifSoli = new System.Windows.Forms.Label();
            this.txbCalifSoli = new System.Windows.Forms.TextBox();
            this.btnEntregarSoli = new System.Windows.Forms.Button();
            this.btnVolverSoli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtActuSoli
            // 
            this.txtActuSoli.AutoSize = true;
            this.txtActuSoli.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActuSoli.ForeColor = System.Drawing.Color.Navy;
            this.txtActuSoli.Location = new System.Drawing.Point(26, 9);
            this.txtActuSoli.Name = "txtActuSoli";
            this.txtActuSoli.Size = new System.Drawing.Size(570, 57);
            this.txtActuSoli.TabIndex = 0;
            this.txtActuSoli.Text = "Actualizar Solicitud";
            // 
            // btnBuscarSoli
            // 
            this.btnBuscarSoli.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarSoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarSoli.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscarSoli.Location = new System.Drawing.Point(51, 69);
            this.btnBuscarSoli.Name = "btnBuscarSoli";
            this.btnBuscarSoli.Size = new System.Drawing.Size(127, 34);
            this.btnBuscarSoli.TabIndex = 1;
            this.btnBuscarSoli.Text = "Buscar";
            this.btnBuscarSoli.UseVisualStyleBackColor = false;
            this.btnBuscarSoli.Click += new System.EventHandler(this.btnBuscarSoli_Click);
            // 
            // txbBuscarSoli
            // 
            this.txbBuscarSoli.BackColor = System.Drawing.Color.PowderBlue;
            this.txbBuscarSoli.Location = new System.Drawing.Point(207, 83);
            this.txbBuscarSoli.Name = "txbBuscarSoli";
            this.txbBuscarSoli.Size = new System.Drawing.Size(203, 20);
            this.txbBuscarSoli.TabIndex = 2;
            // 
            // lblInfoSoli
            // 
            this.lblInfoSoli.BackColor = System.Drawing.Color.PowderBlue;
            this.lblInfoSoli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoSoli.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblInfoSoli.Location = new System.Drawing.Point(30, 125);
            this.lblInfoSoli.Name = "lblInfoSoli";
            this.lblInfoSoli.Size = new System.Drawing.Size(410, 235);
            this.lblInfoSoli.TabIndex = 3;
            this.lblInfoSoli.Text = "Busque una solicitud por su código.";
            // 
            // txtTecnicoSoli
            // 
            this.txtTecnicoSoli.AutoSize = true;
            this.txtTecnicoSoli.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTecnicoSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTecnicoSoli.Location = new System.Drawing.Point(30, 385);
            this.txtTecnicoSoli.Name = "txtTecnicoSoli";
            this.txtTecnicoSoli.Size = new System.Drawing.Size(150, 20);
            this.txtTecnicoSoli.TabIndex = 4;
            this.txtTecnicoSoli.Text = "Técnico (código)";
            // 
            // txbTecnicoSoli
            // 
            this.txbTecnicoSoli.BackColor = System.Drawing.Color.PowderBlue;
            this.txbTecnicoSoli.Location = new System.Drawing.Point(200, 387);
            this.txbTecnicoSoli.Name = "txbTecnicoSoli";
            this.txbTecnicoSoli.Size = new System.Drawing.Size(120, 20);
            this.txbTecnicoSoli.TabIndex = 5;
            // 
            // btnAsignarSoli
            // 
            this.btnAsignarSoli.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAsignarSoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignarSoli.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAsignarSoli.Location = new System.Drawing.Point(340, 378);
            this.btnAsignarSoli.Name = "btnAsignarSoli";
            this.btnAsignarSoli.Size = new System.Drawing.Size(100, 34);
            this.btnAsignarSoli.TabIndex = 6;
            this.btnAsignarSoli.Text = "Asignar";
            this.btnAsignarSoli.UseVisualStyleBackColor = false;
            this.btnAsignarSoli.Click += new System.EventHandler(this.btnAsignarSoli_Click);
            // 
            // btnIniciarSoli
            // 
            this.btnIniciarSoli.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIniciarSoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarSoli.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnIniciarSoli.Location = new System.Drawing.Point(30, 430);
            this.btnIniciarSoli.Name = "btnIniciarSoli";
            this.btnIniciarSoli.Size = new System.Drawing.Size(200, 34);
            this.btnIniciarSoli.TabIndex = 7;
            this.btnIniciarSoli.Text = "Iniciar Reparación";
            this.btnIniciarSoli.UseVisualStyleBackColor = false;
            this.btnIniciarSoli.Click += new System.EventHandler(this.btnIniciarSoli_Click);
            // 
            // btnCancelarSoli
            // 
            this.btnCancelarSoli.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarSoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarSoli.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelarSoli.Location = new System.Drawing.Point(240, 430);
            this.btnCancelarSoli.Name = "btnCancelarSoli";
            this.btnCancelarSoli.Size = new System.Drawing.Size(200, 34);
            this.btnCancelarSoli.TabIndex = 8;
            this.btnCancelarSoli.Text = "Cancelar Solicitud";
            this.btnCancelarSoli.UseVisualStyleBackColor = false;
            this.btnCancelarSoli.Click += new System.EventHandler(this.btnCancelarSoli_Click);
            // 
            // btnDeshacerSoli
            // 
            this.btnDeshacerSoli.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeshacerSoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshacerSoli.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshacerSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeshacerSoli.Location = new System.Drawing.Point(30, 475);
            this.btnDeshacerSoli.Name = "btnDeshacerSoli";
            this.btnDeshacerSoli.Size = new System.Drawing.Size(410, 34);
            this.btnDeshacerSoli.TabIndex = 9;
            this.btnDeshacerSoli.Text = "Deshacer Último Cambio";
            this.btnDeshacerSoli.UseVisualStyleBackColor = false;
            this.btnDeshacerSoli.Click += new System.EventHandler(this.btnDeshacerSoli_Click);
            // 
            // txtDiagSoli
            // 
            this.txtDiagSoli.AutoSize = true;
            this.txtDiagSoli.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDiagSoli.Location = new System.Drawing.Point(470, 125);
            this.txtDiagSoli.Name = "txtDiagSoli";
            this.txtDiagSoli.Size = new System.Drawing.Size(400, 20);
            this.txtDiagSoli.TabIndex = 10;
            this.txtDiagSoli.Text = "Diagnóstico y acciones (una por línea)";
            // 
            // txbDiagSoli
            // 
            this.txbDiagSoli.BackColor = System.Drawing.Color.PowderBlue;
            this.txbDiagSoli.Multiline = true;
            this.txbDiagSoli.Location = new System.Drawing.Point(470, 155);
            this.txbDiagSoli.Name = "txbDiagSoli";
            this.txbDiagSoli.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDiagSoli.Size = new System.Drawing.Size(420, 90);
            this.txbDiagSoli.TabIndex = 11;
            // 
            // txtManoSoli
            // 
            this.txtManoSoli.AutoSize = true;
            this.txtManoSoli.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManoSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtManoSoli.Location = new System.Drawing.Point(470, 262);
            this.txtManoSoli.Name = "txtManoSoli";
            this.txtManoSoli.Size = new System.Drawing.Size(150, 20);
            this.txtManoSoli.TabIndex = 12;
            this.txtManoSoli.Text = "Mano de obra (Q)";
            // 
            // txbManoSoli
            // 
            this.txbManoSoli.BackColor = System.Drawing.Color.PowderBlue;
            this.txbManoSoli.Location = new System.Drawing.Point(650, 264);
            this.txbManoSoli.Name = "txbManoSoli";
            this.txbManoSoli.Size = new System.Drawing.Size(100, 20);
            this.txbManoSoli.TabIndex = 13;
            // 
            // btnDiagSoli
            // 
            this.btnDiagSoli.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDiagSoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiagSoli.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDiagSoli.Location = new System.Drawing.Point(470, 295);
            this.btnDiagSoli.Name = "btnDiagSoli";
            this.btnDiagSoli.Size = new System.Drawing.Size(420, 34);
            this.btnDiagSoli.TabIndex = 14;
            this.btnDiagSoli.Text = "Guardar Diagnóstico";
            this.btnDiagSoli.UseVisualStyleBackColor = false;
            this.btnDiagSoli.Click += new System.EventHandler(this.btnDiagSoli_Click);
            // 
            // txtRepSoli
            // 
            this.txtRepSoli.AutoSize = true;
            this.txtRepSoli.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtRepSoli.Location = new System.Drawing.Point(470, 352);
            this.txtRepSoli.Name = "txtRepSoli";
            this.txtRepSoli.Size = new System.Drawing.Size(160, 20);
            this.txtRepSoli.TabIndex = 15;
            this.txtRepSoli.Text = "Repuesto (código)";
            // 
            // txbRepuestoSoli
            // 
            this.txbRepuestoSoli.BackColor = System.Drawing.Color.PowderBlue;
            this.txbRepuestoSoli.Location = new System.Drawing.Point(650, 354);
            this.txbRepuestoSoli.Name = "txbRepuestoSoli";
            this.txbRepuestoSoli.Size = new System.Drawing.Size(110, 20);
            this.txbRepuestoSoli.TabIndex = 16;
            // 
            // txtCantSoli
            // 
            this.txtCantSoli.AutoSize = true;
            this.txtCantSoli.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCantSoli.Location = new System.Drawing.Point(775, 352);
            this.txtCantSoli.Name = "txtCantSoli";
            this.txtCantSoli.Size = new System.Drawing.Size(50, 20);
            this.txtCantSoli.TabIndex = 17;
            this.txtCantSoli.Text = "Cant.";
            // 
            // txbCantRepSoli
            // 
            this.txbCantRepSoli.BackColor = System.Drawing.Color.PowderBlue;
            this.txbCantRepSoli.Location = new System.Drawing.Point(835, 354);
            this.txbCantRepSoli.Name = "txbCantRepSoli";
            this.txbCantRepSoli.Size = new System.Drawing.Size(55, 20);
            this.txbCantRepSoli.TabIndex = 18;
            // 
            // btnRepSoli
            // 
            this.btnRepSoli.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRepSoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRepSoli.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRepSoli.Location = new System.Drawing.Point(470, 385);
            this.btnRepSoli.Name = "btnRepSoli";
            this.btnRepSoli.Size = new System.Drawing.Size(420, 34);
            this.btnRepSoli.TabIndex = 19;
            this.btnRepSoli.Text = "Usar Repuesto";
            this.btnRepSoli.UseVisualStyleBackColor = false;
            this.btnRepSoli.Click += new System.EventHandler(this.btnRepSoli_Click);
            // 
            // txtCalifSoli
            // 
            this.txtCalifSoli.AutoSize = true;
            this.txtCalifSoli.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalifSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCalifSoli.Location = new System.Drawing.Point(470, 442);
            this.txtCalifSoli.Name = "txtCalifSoli";
            this.txtCalifSoli.Size = new System.Drawing.Size(170, 20);
            this.txtCalifSoli.TabIndex = 20;
            this.txtCalifSoli.Text = "Calificación (1 a 5)";
            // 
            // txbCalifSoli
            // 
            this.txbCalifSoli.BackColor = System.Drawing.Color.PowderBlue;
            this.txbCalifSoli.Location = new System.Drawing.Point(650, 444);
            this.txbCalifSoli.Name = "txbCalifSoli";
            this.txbCalifSoli.Size = new System.Drawing.Size(60, 20);
            this.txbCalifSoli.TabIndex = 21;
            // 
            // btnEntregarSoli
            // 
            this.btnEntregarSoli.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEntregarSoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntregarSoli.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregarSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEntregarSoli.Location = new System.Drawing.Point(470, 475);
            this.btnEntregarSoli.Name = "btnEntregarSoli";
            this.btnEntregarSoli.Size = new System.Drawing.Size(420, 34);
            this.btnEntregarSoli.TabIndex = 22;
            this.btnEntregarSoli.Text = "Entregar Solicitud";
            this.btnEntregarSoli.UseVisualStyleBackColor = false;
            this.btnEntregarSoli.Click += new System.EventHandler(this.btnEntregarSoli_Click);
            // 
            // btnVolverSoli
            // 
            this.btnVolverSoli.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolverSoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverSoli.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolverSoli.Location = new System.Drawing.Point(396, 560);
            this.btnVolverSoli.Name = "btnVolverSoli";
            this.btnVolverSoli.Size = new System.Drawing.Size(127, 34);
            this.btnVolverSoli.TabIndex = 23;
            this.btnVolverSoli.Text = "VOLVER";
            this.btnVolverSoli.UseVisualStyleBackColor = false;
            this.btnVolverSoli.Click += new System.EventHandler(this.btnVolverSoli_Click);
            // 
            // ActualizarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(920, 615);
            this.Controls.Add(this.btnVolverSoli);
            this.Controls.Add(this.btnEntregarSoli);
            this.Controls.Add(this.txbCalifSoli);
            this.Controls.Add(this.txtCalifSoli);
            this.Controls.Add(this.btnRepSoli);
            this.Controls.Add(this.txbCantRepSoli);
            this.Controls.Add(this.txtCantSoli);
            this.Controls.Add(this.txbRepuestoSoli);
            this.Controls.Add(this.txtRepSoli);
            this.Controls.Add(this.btnDiagSoli);
            this.Controls.Add(this.txbManoSoli);
            this.Controls.Add(this.txtManoSoli);
            this.Controls.Add(this.txbDiagSoli);
            this.Controls.Add(this.txtDiagSoli);
            this.Controls.Add(this.btnDeshacerSoli);
            this.Controls.Add(this.btnCancelarSoli);
            this.Controls.Add(this.btnIniciarSoli);
            this.Controls.Add(this.btnAsignarSoli);
            this.Controls.Add(this.txbTecnicoSoli);
            this.Controls.Add(this.txtTecnicoSoli);
            this.Controls.Add(this.lblInfoSoli);
            this.Controls.Add(this.txbBuscarSoli);
            this.Controls.Add(this.btnBuscarSoli);
            this.Controls.Add(this.txtActuSoli);
            this.Name = "ActualizarSolicitud";
            this.Text = "ActualizarSolicitud";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarSolicitud_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtActuSoli;
        private System.Windows.Forms.Button btnBuscarSoli;
        private System.Windows.Forms.TextBox txbBuscarSoli;
        private System.Windows.Forms.Label lblInfoSoli;
        private System.Windows.Forms.Label txtTecnicoSoli;
        private System.Windows.Forms.TextBox txbTecnicoSoli;
        private System.Windows.Forms.Button btnAsignarSoli;
        private System.Windows.Forms.Button btnIniciarSoli;
        private System.Windows.Forms.Button btnCancelarSoli;
        private System.Windows.Forms.Button btnDeshacerSoli;
        private System.Windows.Forms.Label txtDiagSoli;
        private System.Windows.Forms.TextBox txbDiagSoli;
        private System.Windows.Forms.Label txtManoSoli;
        private System.Windows.Forms.TextBox txbManoSoli;
        private System.Windows.Forms.Button btnDiagSoli;
        private System.Windows.Forms.Label txtRepSoli;
        private System.Windows.Forms.TextBox txbRepuestoSoli;
        private System.Windows.Forms.Label txtCantSoli;
        private System.Windows.Forms.TextBox txbCantRepSoli;
        private System.Windows.Forms.Button btnRepSoli;
        private System.Windows.Forms.Label txtCalifSoli;
        private System.Windows.Forms.TextBox txbCalifSoli;
        private System.Windows.Forms.Button btnEntregarSoli;
        private System.Windows.Forms.Button btnVolverSoli;
    }
}