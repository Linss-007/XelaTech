namespace XelaTech
{
    partial class Solicitudes
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
            this.txtSolicitudesTit = new System.Windows.Forms.Label();
            this.btnRegisSolicitud = new System.Windows.Forms.Button();
            this.btnActuSolicitud = new System.Windows.Forms.Button();
            this.btnConsSolicitud = new System.Windows.Forms.Button();
            this.btnSalirSolicitud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSolicitudesTit
            // 
            this.txtSolicitudesTit.AutoSize = true;
            this.txtSolicitudesTit.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolicitudesTit.ForeColor = System.Drawing.Color.Navy;
            this.txtSolicitudesTit.Location = new System.Drawing.Point(39, 9);
            this.txtSolicitudesTit.Name = "txtSolicitudesTit";
            this.txtSolicitudesTit.Size = new System.Drawing.Size(314, 57);
            this.txtSolicitudesTit.TabIndex = 0;
            this.txtSolicitudesTit.Text = "SOLICITUDES";
            // 
            // btnRegisSolicitud
            // 
            this.btnRegisSolicitud.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegisSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisSolicitud.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegisSolicitud.Location = new System.Drawing.Point(81, 69);
            this.btnRegisSolicitud.Name = "btnRegisSolicitud";
            this.btnRegisSolicitud.Size = new System.Drawing.Size(230, 47);
            this.btnRegisSolicitud.TabIndex = 1;
            this.btnRegisSolicitud.Text = "Registrar Solicitud";
            this.btnRegisSolicitud.UseVisualStyleBackColor = false;
            this.btnRegisSolicitud.Click += new System.EventHandler(this.btnRegisSolicitud_Click);
            // 
            // btnActuSolicitud
            // 
            this.btnActuSolicitud.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActuSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActuSolicitud.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActuSolicitud.Location = new System.Drawing.Point(81, 140);
            this.btnActuSolicitud.Name = "btnActuSolicitud";
            this.btnActuSolicitud.Size = new System.Drawing.Size(230, 47);
            this.btnActuSolicitud.TabIndex = 2;
            this.btnActuSolicitud.Text = "Actualizar Solicitud";
            this.btnActuSolicitud.UseVisualStyleBackColor = false;
            this.btnActuSolicitud.Click += new System.EventHandler(this.btnActuSolicitud_Click);
            // 
            // btnConsSolicitud
            // 
            this.btnConsSolicitud.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsSolicitud.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConsSolicitud.Location = new System.Drawing.Point(81, 211);
            this.btnConsSolicitud.Name = "btnConsSolicitud";
            this.btnConsSolicitud.Size = new System.Drawing.Size(230, 47);
            this.btnConsSolicitud.TabIndex = 3;
            this.btnConsSolicitud.Text = "Consultar Solicitudes";
            this.btnConsSolicitud.UseVisualStyleBackColor = false;
            this.btnConsSolicitud.Click += new System.EventHandler(this.btnConsSolicitud_Click);
            // 
            // btnSalirSolicitud
            // 
            this.btnSalirSolicitud.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalirSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirSolicitud.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalirSolicitud.Location = new System.Drawing.Point(81, 367);
            this.btnSalirSolicitud.Name = "btnSalirSolicitud";
            this.btnSalirSolicitud.Size = new System.Drawing.Size(230, 47);
            this.btnSalirSolicitud.TabIndex = 4;
            this.btnSalirSolicitud.Text = "VOLVER";
            this.btnSalirSolicitud.UseVisualStyleBackColor = false;
            this.btnSalirSolicitud.Click += new System.EventHandler(this.btnSalirSolicitud_Click);
            // 
            // Solicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.btnSalirSolicitud);
            this.Controls.Add(this.btnConsSolicitud);
            this.Controls.Add(this.btnActuSolicitud);
            this.Controls.Add(this.btnRegisSolicitud);
            this.Controls.Add(this.txtSolicitudesTit);
            this.Name = "Solicitudes";
            this.Text = "Solicitudes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Solicitudes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSolicitudesTit;
        private System.Windows.Forms.Button btnRegisSolicitud;
        private System.Windows.Forms.Button btnActuSolicitud;
        private System.Windows.Forms.Button btnConsSolicitud;
        private System.Windows.Forms.Button btnSalirSolicitud;
    }
}