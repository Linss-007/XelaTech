namespace XelaTech
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuTitulo = new System.Windows.Forms.Label();
            this.btnGesCliente = new System.Windows.Forms.Button();
            this.btnGesTecnico = new System.Windows.Forms.Button();
            this.btnGesEquipo = new System.Windows.Forms.Button();
            this.btnGesSolis = new System.Windows.Forms.Button();
            this.btnGesRepuestos = new System.Windows.Forms.Button();
            this.btnGesColas = new System.Windows.Forms.Button();
            this.btnOrdenamientos = new System.Windows.Forms.Button();
            this.btnBusquedas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnGenerarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = true;
            this.MenuTitulo.Font = new System.Drawing.Font("LEMON MILK Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MenuTitulo.Location = new System.Drawing.Point(131, 9);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.Size = new System.Drawing.Size(243, 53);
            this.MenuTitulo.TabIndex = 0;
            this.MenuTitulo.Text = "XELA TECH";
            // 
            // btnGesCliente
            // 
            this.btnGesCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGesCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGesCliente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGesCliente.Location = new System.Drawing.Point(33, 76);
            this.btnGesCliente.Name = "btnGesCliente";
            this.btnGesCliente.Size = new System.Drawing.Size(179, 38);
            this.btnGesCliente.TabIndex = 1;
            this.btnGesCliente.Text = "Gestión de Clientes";
            this.btnGesCliente.UseVisualStyleBackColor = false;
            this.btnGesCliente.Click += new System.EventHandler(this.btnGesCliente_Click);
            // 
            // btnGesTecnico
            // 
            this.btnGesTecnico.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGesTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGesTecnico.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGesTecnico.Location = new System.Drawing.Point(33, 130);
            this.btnGesTecnico.Name = "btnGesTecnico";
            this.btnGesTecnico.Size = new System.Drawing.Size(179, 38);
            this.btnGesTecnico.TabIndex = 2;
            this.btnGesTecnico.Text = "Gestión de Técnicos";
            this.btnGesTecnico.UseVisualStyleBackColor = false;
            this.btnGesTecnico.Click += new System.EventHandler(this.btnGesTecnico_Click);
            // 
            // btnGesEquipo
            // 
            this.btnGesEquipo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGesEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGesEquipo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGesEquipo.Location = new System.Drawing.Point(33, 183);
            this.btnGesEquipo.Name = "btnGesEquipo";
            this.btnGesEquipo.Size = new System.Drawing.Size(179, 38);
            this.btnGesEquipo.TabIndex = 3;
            this.btnGesEquipo.Text = "Gestión de Equipos";
            this.btnGesEquipo.UseVisualStyleBackColor = false;
            this.btnGesEquipo.Click += new System.EventHandler(this.btnGesEquipo_Click);
            // 
            // btnGesSolis
            // 
            this.btnGesSolis.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGesSolis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGesSolis.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesSolis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGesSolis.Location = new System.Drawing.Point(33, 236);
            this.btnGesSolis.Name = "btnGesSolis";
            this.btnGesSolis.Size = new System.Drawing.Size(179, 38);
            this.btnGesSolis.TabIndex = 4;
            this.btnGesSolis.Text = "Gestión de Solicitudes";
            this.btnGesSolis.UseVisualStyleBackColor = false;
            this.btnGesSolis.Click += new System.EventHandler(this.btnGesSolis_Click);
            // 
            // btnGesRepuestos
            // 
            this.btnGesRepuestos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGesRepuestos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGesRepuestos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesRepuestos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGesRepuestos.Location = new System.Drawing.Point(33, 290);
            this.btnGesRepuestos.Name = "btnGesRepuestos";
            this.btnGesRepuestos.Size = new System.Drawing.Size(179, 38);
            this.btnGesRepuestos.TabIndex = 5;
            this.btnGesRepuestos.Text = "Gestión de Repuestos";
            this.btnGesRepuestos.UseVisualStyleBackColor = false;
            this.btnGesRepuestos.Click += new System.EventHandler(this.btnGesRepuestos_Click);
            // 
            // btnGesColas
            // 
            this.btnGesColas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGesColas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGesColas.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesColas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGesColas.Location = new System.Drawing.Point(325, 76);
            this.btnGesColas.Name = "btnGesColas";
            this.btnGesColas.Size = new System.Drawing.Size(138, 38);
            this.btnGesColas.TabIndex = 6;
            this.btnGesColas.Text = "Gestión de Colas";
            this.btnGesColas.UseVisualStyleBackColor = false;
            // 
            // btnOrdenamientos
            // 
            this.btnOrdenamientos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOrdenamientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenamientos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenamientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOrdenamientos.Location = new System.Drawing.Point(325, 130);
            this.btnOrdenamientos.Name = "btnOrdenamientos";
            this.btnOrdenamientos.Size = new System.Drawing.Size(138, 38);
            this.btnOrdenamientos.TabIndex = 7;
            this.btnOrdenamientos.Text = "Ordenamientos";
            this.btnOrdenamientos.UseVisualStyleBackColor = false;
            // 
            // btnBusquedas
            // 
            this.btnBusquedas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBusquedas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusquedas.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBusquedas.Location = new System.Drawing.Point(325, 183);
            this.btnBusquedas.Name = "btnBusquedas";
            this.btnBusquedas.Size = new System.Drawing.Size(138, 38);
            this.btnBusquedas.TabIndex = 8;
            this.btnBusquedas.Text = "Busquedas";
            this.btnBusquedas.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReportes.Location = new System.Drawing.Point(325, 236);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(138, 38);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnGenerarDatos
            // 
            this.btnGenerarDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGenerarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarDatos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenerarDatos.Location = new System.Drawing.Point(325, 290);
            this.btnGenerarDatos.Name = "btnGenerarDatos";
            this.btnGenerarDatos.Size = new System.Drawing.Size(138, 38);
            this.btnGenerarDatos.TabIndex = 10;
            this.btnGenerarDatos.Text = "Generar Datos";
            this.btnGenerarDatos.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalir.Location = new System.Drawing.Point(195, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 38);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarDatos);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnBusquedas);
            this.Controls.Add(this.btnOrdenamientos);
            this.Controls.Add(this.btnGesColas);
            this.Controls.Add(this.btnGesRepuestos);
            this.Controls.Add(this.btnGesSolis);
            this.Controls.Add(this.btnGesEquipo);
            this.Controls.Add(this.btnGesTecnico);
            this.Controls.Add(this.btnGesCliente);
            this.Controls.Add(this.MenuTitulo);
            this.Name = "MenuPrincipal";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuTitulo;
        private System.Windows.Forms.Button btnGesCliente;
        private System.Windows.Forms.Button btnGesTecnico;
        private System.Windows.Forms.Button btnGesEquipo;
        private System.Windows.Forms.Button btnGesSolis;
        private System.Windows.Forms.Button btnGesRepuestos;
        private System.Windows.Forms.Button btnGesColas;
        private System.Windows.Forms.Button btnOrdenamientos;
        private System.Windows.Forms.Button btnBusquedas;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnGenerarDatos;
        private System.Windows.Forms.Button btnSalir;
    }
}

