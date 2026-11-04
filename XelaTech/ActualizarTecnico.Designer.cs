namespace XelaTech
{
    partial class ActualizarTecnico
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
            this.txtActuTecnico = new System.Windows.Forms.Label();
            this.btnBuscarTecnico = new System.Windows.Forms.Button();
            this.txbBuscarTecnico = new System.Windows.Forms.TextBox();
            this.txtNomTecnico = new System.Windows.Forms.Label();
            this.txtEspTecnico = new System.Windows.Forms.Label();
            this.txtEstTecnico = new System.Windows.Forms.Label();
            this.txbNomTecnico = new System.Windows.Forms.TextBox();
            this.cbxEspecialidadTec = new System.Windows.Forms.ComboBox();
            this.cbxEstadoTec = new System.Windows.Forms.ComboBox();
            this.btnVolverTecnico = new System.Windows.Forms.Button();
            this.btnActuTecnico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtActuTecnico
            // 
            this.txtActuTecnico.AutoSize = true;
            this.txtActuTecnico.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActuTecnico.ForeColor = System.Drawing.Color.Navy;
            this.txtActuTecnico.Location = new System.Drawing.Point(26, 9);
            this.txtActuTecnico.Name = "txtActuTecnico";
            this.txtActuTecnico.Size = new System.Drawing.Size(492, 57);
            this.txtActuTecnico.TabIndex = 0;
            this.txtActuTecnico.Text = "Actualizar Tecnico";
            // 
            // btnBuscarTecnico
            // 
            this.btnBuscarTecnico.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarTecnico.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscarTecnico.Location = new System.Drawing.Point(51, 69);
            this.btnBuscarTecnico.Name = "btnBuscarTecnico";
            this.btnBuscarTecnico.Size = new System.Drawing.Size(127, 34);
            this.btnBuscarTecnico.TabIndex = 1;
            this.btnBuscarTecnico.Text = "Buscar";
            this.btnBuscarTecnico.UseVisualStyleBackColor = false;
            this.btnBuscarTecnico.Click += new System.EventHandler(this.btnBuscarTecnico_Click);
            // 
            // txbBuscarTecnico
            // 
            this.txbBuscarTecnico.BackColor = System.Drawing.Color.PowderBlue;
            this.txbBuscarTecnico.Location = new System.Drawing.Point(207, 83);
            this.txbBuscarTecnico.Name = "txbBuscarTecnico";
            this.txbBuscarTecnico.Size = new System.Drawing.Size(203, 20);
            this.txbBuscarTecnico.TabIndex = 2;
            // 
            // txtNomTecnico
            // 
            this.txtNomTecnico.AutoSize = true;
            this.txtNomTecnico.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtNomTecnico.Location = new System.Drawing.Point(43, 140);
            this.txtNomTecnico.Name = "txtNomTecnico";
            this.txtNomTecnico.Size = new System.Drawing.Size(80, 24);
            this.txtNomTecnico.TabIndex = 3;
            this.txtNomTecnico.Text = "Nombre";
            // 
            // txtEspTecnico
            // 
            this.txtEspTecnico.AutoSize = true;
            this.txtEspTecnico.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtEspTecnico.Location = new System.Drawing.Point(43, 190);
            this.txtEspTecnico.Name = "txtEspTecnico";
            this.txtEspTecnico.Size = new System.Drawing.Size(120, 24);
            this.txtEspTecnico.TabIndex = 4;
            this.txtEspTecnico.Text = "Especialidad";
            // 
            // txtEstTecnico
            // 
            this.txtEstTecnico.AutoSize = true;
            this.txtEstTecnico.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtEstTecnico.Location = new System.Drawing.Point(43, 240);
            this.txtEstTecnico.Name = "txtEstTecnico";
            this.txtEstTecnico.Size = new System.Drawing.Size(70, 24);
            this.txtEstTecnico.TabIndex = 5;
            this.txtEstTecnico.Text = "Estado";
            // 
            // txbNomTecnico
            // 
            this.txbNomTecnico.BackColor = System.Drawing.Color.PowderBlue;
            this.txbNomTecnico.Location = new System.Drawing.Point(215, 143);
            this.txbNomTecnico.Name = "txbNomTecnico";
            this.txbNomTecnico.Size = new System.Drawing.Size(240, 20);
            this.txbNomTecnico.TabIndex = 6;
            this.txbNomTecnico.Visible = false;
            // 
            // cbxEspecialidadTec
            // 
            this.cbxEspecialidadTec.BackColor = System.Drawing.Color.PowderBlue;
            this.cbxEspecialidadTec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecialidadTec.FormattingEnabled = true;
            this.cbxEspecialidadTec.Items.AddRange(new object[] {
            "1. Software",
            "2. Computadoras",
            "3. Celulares",
            "4. Impresoras" });
            this.cbxEspecialidadTec.Location = new System.Drawing.Point(215, 193);
            this.cbxEspecialidadTec.Name = "cbxEspecialidadTec";
            this.cbxEspecialidadTec.Size = new System.Drawing.Size(240, 21);
            this.cbxEspecialidadTec.TabIndex = 7;
            this.cbxEspecialidadTec.Visible = false;
            // 
            // cbxEstadoTec
            // 
            this.cbxEstadoTec.BackColor = System.Drawing.Color.PowderBlue;
            this.cbxEstadoTec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoTec.FormattingEnabled = true;
            this.cbxEstadoTec.Items.AddRange(new object[] {
            "1. Disponible",
            "2. Fuera de Servicio" });
            this.cbxEstadoTec.Location = new System.Drawing.Point(215, 243);
            this.cbxEstadoTec.Name = "cbxEstadoTec";
            this.cbxEstadoTec.Size = new System.Drawing.Size(240, 21);
            this.cbxEstadoTec.TabIndex = 8;
            this.cbxEstadoTec.Visible = false;
            // 
            // btnVolverTecnico
            // 
            this.btnVolverTecnico.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolverTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverTecnico.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolverTecnico.Location = new System.Drawing.Point(33, 398);
            this.btnVolverTecnico.Name = "btnVolverTecnico";
            this.btnVolverTecnico.Size = new System.Drawing.Size(127, 34);
            this.btnVolverTecnico.TabIndex = 9;
            this.btnVolverTecnico.Text = "VOLVER";
            this.btnVolverTecnico.UseVisualStyleBackColor = false;
            this.btnVolverTecnico.Click += new System.EventHandler(this.btnVolverTecnico_Click);
            // 
            // btnActuTecnico
            // 
            this.btnActuTecnico.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActuTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActuTecnico.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActuTecnico.Location = new System.Drawing.Point(307, 398);
            this.btnActuTecnico.Name = "btnActuTecnico";
            this.btnActuTecnico.Size = new System.Drawing.Size(127, 34);
            this.btnActuTecnico.TabIndex = 10;
            this.btnActuTecnico.Text = "Actualizar";
            this.btnActuTecnico.UseVisualStyleBackColor = false;
            this.btnActuTecnico.Click += new System.EventHandler(this.btnActuTecnico_Click);
            // 
            // ActualizarTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.btnActuTecnico);
            this.Controls.Add(this.btnVolverTecnico);
            this.Controls.Add(this.cbxEstadoTec);
            this.Controls.Add(this.cbxEspecialidadTec);
            this.Controls.Add(this.txbNomTecnico);
            this.Controls.Add(this.txtEstTecnico);
            this.Controls.Add(this.txtEspTecnico);
            this.Controls.Add(this.txtNomTecnico);
            this.Controls.Add(this.txbBuscarTecnico);
            this.Controls.Add(this.btnBuscarTecnico);
            this.Controls.Add(this.txtActuTecnico);
            this.Name = "ActualizarTecnico";
            this.Text = "ActualizarTecnico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarTecnico_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtActuTecnico;
        private System.Windows.Forms.Button btnBuscarTecnico;
        private System.Windows.Forms.TextBox txbBuscarTecnico;
        private System.Windows.Forms.Label txtNomTecnico;
        private System.Windows.Forms.Label txtEspTecnico;
        private System.Windows.Forms.Label txtEstTecnico;
        private System.Windows.Forms.TextBox txbNomTecnico;
        private System.Windows.Forms.ComboBox cbxEspecialidadTec;
        private System.Windows.Forms.ComboBox cbxEstadoTec;
        private System.Windows.Forms.Button btnVolverTecnico;
        private System.Windows.Forms.Button btnActuTecnico;
    }
}