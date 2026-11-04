namespace XelaTech
{
    partial class Busquedas
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txbCriterio = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("LEMON MILK Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BUSQUEDAS";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTipo.Location = new System.Drawing.Point(20, 55);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(118, 18);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo de busqueda:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.BackColor = System.Drawing.Color.PowderBlue;
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Clientes por nombre (secuencial)",
            "Solicitudes por estado (secuencial)",
            "Equipos por marca (secuencial)",
            "Solicitud por codigo (binaria)"});
            this.cbxTipo.Location = new System.Drawing.Point(20, 78);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(470, 23);
            this.cbxTipo.TabIndex = 2;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.CbxTipo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCriterio.Location = new System.Drawing.Point(510, 55);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(110, 18);
            this.lblCriterio.TabIndex = 3;
            this.lblCriterio.Text = "Nombre (parcial):";
            // 
            // txbCriterio
            // 
            this.txbCriterio.BackColor = System.Drawing.Color.PowderBlue;
            this.txbCriterio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCriterio.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCriterio.Location = new System.Drawing.Point(510, 78);
            this.txbCriterio.Name = "txbCriterio";
            this.txbCriterio.Size = new System.Drawing.Size(260, 22);
            this.txbCriterio.TabIndex = 4;
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.Color.PowderBlue;
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Asignada",
            "En Proceso",
            "Cancelada",
            "Finalizada"});
            this.cbxEstado.Location = new System.Drawing.Point(510, 78);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(260, 23);
            this.cbxEstado.TabIndex = 5;
            this.cbxEstado.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(790, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 32);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoEllipsis = true;
            this.lblEncabezado.BackColor = System.Drawing.Color.White;
            this.lblEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEncabezado.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.Navy;
            this.lblEncabezado.Location = new System.Drawing.Point(20, 120);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(920, 42);
            this.lblEncabezado.TabIndex = 7;
            this.lblEncabezado.Text = "Seleccione el tipo de busqueda, escriba el criterio y presione Buscar.";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResultados.Location = new System.Drawing.Point(20, 172);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(920, 395);
            this.dgvResultados.TabIndex = 8;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolver.Location = new System.Drawing.Point(830, 580);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 36);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Busquedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(960, 645);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.txbCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Busquedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busquedas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Busquedas_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txbCriterio;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnVolver;
    }
}
