namespace XelaTech
{
    partial class ActualizarCliente
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
            this.txtActuCliente = new System.Windows.Forms.Label();
            this.btnActuCliente = new System.Windows.Forms.Button();
            this.btnVolverCliente = new System.Windows.Forms.Button();
            this.cbxTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtTipoCliente = new System.Windows.Forms.Label();
            this.txbTelCliente = new System.Windows.Forms.TextBox();
            this.txtTelCliente = new System.Windows.Forms.Label();
            this.txtCorreoCliente = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.Label();
            this.txbCorreoCliente = new System.Windows.Forms.TextBox();
            this.txbNomCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txbBuscarCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtActuCliente
            // 
            this.txtActuCliente.AutoSize = true;
            this.txtActuCliente.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActuCliente.ForeColor = System.Drawing.Color.Navy;
            this.txtActuCliente.Location = new System.Drawing.Point(26, 9);
            this.txtActuCliente.Name = "txtActuCliente";
            this.txtActuCliente.Size = new System.Drawing.Size(492, 57);
            this.txtActuCliente.TabIndex = 5;
            this.txtActuCliente.Text = "Actualizar Cliente";
            // 
            // btnActuCliente
            // 
            this.btnActuCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActuCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActuCliente.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActuCliente.Location = new System.Drawing.Point(307, 398);
            this.btnActuCliente.Name = "btnActuCliente";
            this.btnActuCliente.Size = new System.Drawing.Size(127, 34);
            this.btnActuCliente.TabIndex = 24;
            this.btnActuCliente.Text = "Actualizar";
            this.btnActuCliente.UseVisualStyleBackColor = false;
            this.btnActuCliente.Click += new System.EventHandler(this.btnActuCliente_Click);
            // 
            // btnVolverCliente
            // 
            this.btnVolverCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolverCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverCliente.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolverCliente.Location = new System.Drawing.Point(104, 398);
            this.btnVolverCliente.Name = "btnVolverCliente";
            this.btnVolverCliente.Size = new System.Drawing.Size(127, 34);
            this.btnVolverCliente.TabIndex = 23;
            this.btnVolverCliente.Text = "VOLVER";
            this.btnVolverCliente.UseVisualStyleBackColor = false;
            this.btnVolverCliente.Click += new System.EventHandler(this.btnVolverCliente_Click);
            // 
            // cbxTipoCliente
            // 
            this.cbxTipoCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.cbxTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCliente.FormattingEnabled = true;
            this.cbxTipoCliente.Items.AddRange(new object[] {
            "1. Normal",
            "2. Prioritario",
            "3. Ejecutivo",
            "4. Frecuente"});
            this.cbxTipoCliente.Location = new System.Drawing.Point(207, 305);
            this.cbxTipoCliente.Name = "cbxTipoCliente";
            this.cbxTipoCliente.Size = new System.Drawing.Size(203, 21);
            this.cbxTipoCliente.TabIndex = 22;
            this.cbxTipoCliente.Visible = false;
            // 
            // txtTipoCliente
            // 
            this.txtTipoCliente.AutoSize = true;
            this.txtTipoCliente.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTipoCliente.Location = new System.Drawing.Point(78, 296);
            this.txtTipoCliente.Name = "txtTipoCliente";
            this.txtTipoCliente.Size = new System.Drawing.Size(61, 29);
            this.txtTipoCliente.TabIndex = 21;
            this.txtTipoCliente.Text = "Tipo";
            // 
            // txbTelCliente
            // 
            this.txbTelCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.txbTelCliente.Location = new System.Drawing.Point(207, 243);
            this.txbTelCliente.Name = "txbTelCliente";
            this.txbTelCliente.Size = new System.Drawing.Size(203, 20);
            this.txbTelCliente.TabIndex = 20;
            this.txbTelCliente.Visible = false;
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.AutoSize = true;
            this.txtTelCliente.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTelCliente.Location = new System.Drawing.Point(78, 234);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(109, 29);
            this.txtTelCliente.TabIndex = 19;
            this.txtTelCliente.Text = "Telefono";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.AutoSize = true;
            this.txtCorreoCliente.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCorreoCliente.Location = new System.Drawing.Point(78, 182);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(85, 29);
            this.txtCorreoCliente.TabIndex = 18;
            this.txtCorreoCliente.Text = "Correo";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.AutoSize = true;
            this.txtNomCliente.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtNomCliente.Location = new System.Drawing.Point(78, 129);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(100, 29);
            this.txtNomCliente.TabIndex = 17;
            this.txtNomCliente.Text = "Nombre";
            // 
            // txbCorreoCliente
            // 
            this.txbCorreoCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.txbCorreoCliente.Location = new System.Drawing.Point(207, 191);
            this.txbCorreoCliente.Name = "txbCorreoCliente";
            this.txbCorreoCliente.Size = new System.Drawing.Size(203, 20);
            this.txbCorreoCliente.TabIndex = 15;
            this.txbCorreoCliente.Visible = false;
            // 
            // txbNomCliente
            // 
            this.txbNomCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.txbNomCliente.Location = new System.Drawing.Point(207, 138);
            this.txbNomCliente.Name = "txbNomCliente";
            this.txbNomCliente.Size = new System.Drawing.Size(203, 20);
            this.txbNomCliente.TabIndex = 14;
            this.txbNomCliente.Visible = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscarCliente.Location = new System.Drawing.Point(51, 69);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(127, 34);
            this.btnBuscarCliente.TabIndex = 25;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txbBuscarCliente
            // 
            this.txbBuscarCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.txbBuscarCliente.Location = new System.Drawing.Point(207, 83);
            this.txbBuscarCliente.Name = "txbBuscarCliente";
            this.txbBuscarCliente.Size = new System.Drawing.Size(203, 20);
            this.txbBuscarCliente.TabIndex = 26;
            // 
            // ActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.txbBuscarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnActuCliente);
            this.Controls.Add(this.btnVolverCliente);
            this.Controls.Add(this.cbxTipoCliente);
            this.Controls.Add(this.txtTipoCliente);
            this.Controls.Add(this.txbTelCliente);
            this.Controls.Add(this.txtTelCliente);
            this.Controls.Add(this.txtCorreoCliente);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.txbCorreoCliente);
            this.Controls.Add(this.txbNomCliente);
            this.Controls.Add(this.txtActuCliente);
            this.Name = "ActualizarCliente";
            this.Text = "ActualizarCliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarCliente_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtActuCliente;
        private System.Windows.Forms.Button btnActuCliente;
        private System.Windows.Forms.Button btnVolverCliente;
        private System.Windows.Forms.ComboBox cbxTipoCliente;
        private System.Windows.Forms.Label txtTipoCliente;
        private System.Windows.Forms.TextBox txbTelCliente;
        private System.Windows.Forms.Label txtTelCliente;
        private System.Windows.Forms.Label txtCorreoCliente;
        private System.Windows.Forms.Label txtNomCliente;
        private System.Windows.Forms.TextBox txbCorreoCliente;
        private System.Windows.Forms.TextBox txbNomCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txbBuscarCliente;
    }
}