namespace XelaTech
{
    partial class Equipos
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
            this.txtEquiposTit = new System.Windows.Forms.Label();
            this.btnRegisEquipo = new System.Windows.Forms.Button();
            this.btnActuEquipo = new System.Windows.Forms.Button();
            this.btnConsEquipo = new System.Windows.Forms.Button();
            this.btnSalirEquipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEquiposTit
            // 
            this.txtEquiposTit.AutoSize = true;
            this.txtEquiposTit.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquiposTit.ForeColor = System.Drawing.Color.Navy;
            this.txtEquiposTit.Location = new System.Drawing.Point(96, 9);
            this.txtEquiposTit.Name = "txtEquiposTit";
            this.txtEquiposTit.Size = new System.Drawing.Size(200, 57);
            this.txtEquiposTit.TabIndex = 0;
            this.txtEquiposTit.Text = "EQUIPOS";
            // 
            // btnRegisEquipo
            // 
            this.btnRegisEquipo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegisEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisEquipo.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegisEquipo.Location = new System.Drawing.Point(81, 69);
            this.btnRegisEquipo.Name = "btnRegisEquipo";
            this.btnRegisEquipo.Size = new System.Drawing.Size(230, 47);
            this.btnRegisEquipo.TabIndex = 1;
            this.btnRegisEquipo.Text = "Registrar Equipo";
            this.btnRegisEquipo.UseVisualStyleBackColor = false;
            this.btnRegisEquipo.Click += new System.EventHandler(this.btnRegisEquipo_Click);
            // 
            // btnActuEquipo
            // 
            this.btnActuEquipo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActuEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActuEquipo.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActuEquipo.Location = new System.Drawing.Point(81, 140);
            this.btnActuEquipo.Name = "btnActuEquipo";
            this.btnActuEquipo.Size = new System.Drawing.Size(230, 47);
            this.btnActuEquipo.TabIndex = 2;
            this.btnActuEquipo.Text = "Actualizar Equipo";
            this.btnActuEquipo.UseVisualStyleBackColor = false;
            this.btnActuEquipo.Click += new System.EventHandler(this.btnActuEquipo_Click);
            // 
            // btnConsEquipo
            // 
            this.btnConsEquipo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsEquipo.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConsEquipo.Location = new System.Drawing.Point(81, 211);
            this.btnConsEquipo.Name = "btnConsEquipo";
            this.btnConsEquipo.Size = new System.Drawing.Size(230, 47);
            this.btnConsEquipo.TabIndex = 3;
            this.btnConsEquipo.Text = "Consultar Equipos";
            this.btnConsEquipo.UseVisualStyleBackColor = false;
            this.btnConsEquipo.Click += new System.EventHandler(this.btnConsEquipo_Click);
            // 
            // btnSalirEquipo
            // 
            this.btnSalirEquipo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalirEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirEquipo.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalirEquipo.Location = new System.Drawing.Point(81, 367);
            this.btnSalirEquipo.Name = "btnSalirEquipo";
            this.btnSalirEquipo.Size = new System.Drawing.Size(230, 47);
            this.btnSalirEquipo.TabIndex = 4;
            this.btnSalirEquipo.Text = "VOLVER";
            this.btnSalirEquipo.UseVisualStyleBackColor = false;
            this.btnSalirEquipo.Click += new System.EventHandler(this.btnSalirEquipo_Click);
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.btnSalirEquipo);
            this.Controls.Add(this.btnConsEquipo);
            this.Controls.Add(this.btnActuEquipo);
            this.Controls.Add(this.btnRegisEquipo);
            this.Controls.Add(this.txtEquiposTit);
            this.Name = "Equipos";
            this.Text = "Equipos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Equipos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEquiposTit;
        private System.Windows.Forms.Button btnRegisEquipo;
        private System.Windows.Forms.Button btnActuEquipo;
        private System.Windows.Forms.Button btnConsEquipo;
        private System.Windows.Forms.Button btnSalirEquipo;
    }
}