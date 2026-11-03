namespace XelaTech
{
    partial class RegistroCliente
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
            this.txtTituloRegCliente = new System.Windows.Forms.Label();
            this.txbCodCliente = new System.Windows.Forms.TextBox();
            this.txbNomCliente = new System.Windows.Forms.TextBox();
            this.txbCorreoCliente = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.Label();
            this.txtCorreoCliente = new System.Windows.Forms.Label();
            this.txtTelCliente = new System.Windows.Forms.Label();
            this.txbTelCliente = new System.Windows.Forms.TextBox();
            this.txtTipoCliente = new System.Windows.Forms.Label();
            this.cbxTipoCliente = new System.Windows.Forms.ComboBox();
            this.btnVolverCliente = new System.Windows.Forms.Button();
            this.btnRegCliente = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTituloRegCliente
            // 
            this.txtTituloRegCliente.AutoSize = true;
            this.txtTituloRegCliente.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloRegCliente.ForeColor = System.Drawing.Color.Navy;
            this.txtTituloRegCliente.Location = new System.Drawing.Point(23, 21);
            this.txtTituloRegCliente.Name = "txtTituloRegCliente";
            this.txtTituloRegCliente.Size = new System.Drawing.Size(463, 57);
            this.txtTituloRegCliente.TabIndex = 0;
            this.txtTituloRegCliente.Text = "Registro Clientes";
            // 
            // txbCodCliente
            // 
            this.txbCodCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.txbCodCliente.Location = new System.Drawing.Point(172, 97);
            this.txbCodCliente.Name = "txbCodCliente";
            this.txbCodCliente.Size = new System.Drawing.Size(203, 20);
            this.txbCodCliente.TabIndex = 1;
            // 
            // txbNomCliente
            // 
            this.txbNomCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.txbNomCliente.Location = new System.Drawing.Point(172, 147);
            this.txbNomCliente.Name = "txbNomCliente";
            this.txbNomCliente.Size = new System.Drawing.Size(203, 20);
            this.txbNomCliente.TabIndex = 2;
            // 
            // txbCorreoCliente
            // 
            this.txbCorreoCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.txbCorreoCliente.Location = new System.Drawing.Point(172, 196);
            this.txbCorreoCliente.Name = "txbCorreoCliente";
            this.txbCorreoCliente.Size = new System.Drawing.Size(203, 20);
            this.txbCorreoCliente.TabIndex = 3;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.AutoSize = true;
            this.txtCodCliente.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCodCliente.Location = new System.Drawing.Point(43, 88);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(90, 29);
            this.txtCodCliente.TabIndex = 4;
            this.txtCodCliente.Text = "Código";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.AutoSize = true;
            this.txtNomCliente.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtNomCliente.Location = new System.Drawing.Point(43, 138);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(100, 29);
            this.txtNomCliente.TabIndex = 5;
            this.txtNomCliente.Text = "Nombre";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.AutoSize = true;
            this.txtCorreoCliente.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCorreoCliente.Location = new System.Drawing.Point(43, 187);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(85, 29);
            this.txtCorreoCliente.TabIndex = 6;
            this.txtCorreoCliente.Text = "Correo";
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.AutoSize = true;
            this.txtTelCliente.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTelCliente.Location = new System.Drawing.Point(43, 235);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(109, 29);
            this.txtTelCliente.TabIndex = 7;
            this.txtTelCliente.Text = "Telefono";
            // 
            // txbTelCliente
            // 
            this.txbTelCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.txbTelCliente.Location = new System.Drawing.Point(172, 244);
            this.txbTelCliente.Name = "txbTelCliente";
            this.txbTelCliente.Size = new System.Drawing.Size(203, 20);
            this.txbTelCliente.TabIndex = 8;
            // 
            // txtTipoCliente
            // 
            this.txtTipoCliente.AutoSize = true;
            this.txtTipoCliente.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTipoCliente.Location = new System.Drawing.Point(43, 286);
            this.txtTipoCliente.Name = "txtTipoCliente";
            this.txtTipoCliente.Size = new System.Drawing.Size(61, 29);
            this.txtTipoCliente.TabIndex = 9;
            this.txtTipoCliente.Text = "Tipo";
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
            this.cbxTipoCliente.Location = new System.Drawing.Point(172, 295);
            this.cbxTipoCliente.Name = "cbxTipoCliente";
            this.cbxTipoCliente.Size = new System.Drawing.Size(203, 21);
            this.cbxTipoCliente.TabIndex = 10;
            // 
            // btnVolverCliente
            // 
            this.btnVolverCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolverCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverCliente.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolverCliente.Location = new System.Drawing.Point(33, 365);
            this.btnVolverCliente.Name = "btnVolverCliente";
            this.btnVolverCliente.Size = new System.Drawing.Size(127, 34);
            this.btnVolverCliente.TabIndex = 11;
            this.btnVolverCliente.Text = "VOLVER";
            this.btnVolverCliente.UseVisualStyleBackColor = false;
            this.btnVolverCliente.Click += new System.EventHandler(this.btnVolverCliente_Click);
            // 
            // btnRegCliente
            // 
            this.btnRegCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegCliente.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegCliente.Location = new System.Drawing.Point(359, 365);
            this.btnRegCliente.Name = "btnRegCliente";
            this.btnRegCliente.Size = new System.Drawing.Size(127, 34);
            this.btnRegCliente.TabIndex = 12;
            this.btnRegCliente.Text = "Registrar";
            this.btnRegCliente.UseVisualStyleBackColor = false;
            this.btnRegCliente.Click += new System.EventHandler(this.btnRegCliente_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLimpiar.Location = new System.Drawing.Point(198, 365);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 34);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegCliente);
            this.Controls.Add(this.btnVolverCliente);
            this.Controls.Add(this.cbxTipoCliente);
            this.Controls.Add(this.txtTipoCliente);
            this.Controls.Add(this.txbTelCliente);
            this.Controls.Add(this.txtTelCliente);
            this.Controls.Add(this.txtCorreoCliente);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.txbCorreoCliente);
            this.Controls.Add(this.txbNomCliente);
            this.Controls.Add(this.txbCodCliente);
            this.Controls.Add(this.txtTituloRegCliente);
            this.Name = "RegistroCliente";
            this.Text = "RegistroCliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistroCliente_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTituloRegCliente;
        private System.Windows.Forms.TextBox txbCodCliente;
        private System.Windows.Forms.TextBox txbNomCliente;
        private System.Windows.Forms.TextBox txbCorreoCliente;
        private System.Windows.Forms.Label txtCodCliente;
        private System.Windows.Forms.Label txtNomCliente;
        private System.Windows.Forms.Label txtCorreoCliente;
        private System.Windows.Forms.Label txtTelCliente;
        private System.Windows.Forms.TextBox txbTelCliente;
        private System.Windows.Forms.Label txtTipoCliente;
        private System.Windows.Forms.ComboBox cbxTipoCliente;
        private System.Windows.Forms.Button btnVolverCliente;
        private System.Windows.Forms.Button btnRegCliente;
        private System.Windows.Forms.Button btnLimpiar;
    }
}