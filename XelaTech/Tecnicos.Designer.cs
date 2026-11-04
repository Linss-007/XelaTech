namespace XelaTech
{
    partial class Tecnicos
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
            this.txtTecnicosTit = new System.Windows.Forms.Label();
            this.btnRegisTecnico = new System.Windows.Forms.Button();
            this.btnActuTecnico = new System.Windows.Forms.Button();
            this.btnConsTecnico = new System.Windows.Forms.Button();
            this.btnSalirTecnico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTecnicosTit
            // 
            this.txtTecnicosTit.AutoSize = true;
            this.txtTecnicosTit.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTecnicosTit.ForeColor = System.Drawing.Color.Navy;
            this.txtTecnicosTit.Location = new System.Drawing.Point(82, 9);
            this.txtTecnicosTit.Name = "txtTecnicosTit";
            this.txtTecnicosTit.Size = new System.Drawing.Size(228, 57);
            this.txtTecnicosTit.TabIndex = 0;
            this.txtTecnicosTit.Text = "TECNICOS";
            // 
            // btnRegisTecnico
            // 
            this.btnRegisTecnico.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegisTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisTecnico.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegisTecnico.Location = new System.Drawing.Point(81, 69);
            this.btnRegisTecnico.Name = "btnRegisTecnico";
            this.btnRegisTecnico.Size = new System.Drawing.Size(230, 47);
            this.btnRegisTecnico.TabIndex = 1;
            this.btnRegisTecnico.Text = "Registrar Técnico";
            this.btnRegisTecnico.UseVisualStyleBackColor = false;
            this.btnRegisTecnico.Click += new System.EventHandler(this.btnRegisTecnico_Click);
            // 
            // btnActuTecnico
            // 
            this.btnActuTecnico.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActuTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActuTecnico.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActuTecnico.Location = new System.Drawing.Point(81, 140);
            this.btnActuTecnico.Name = "btnActuTecnico";
            this.btnActuTecnico.Size = new System.Drawing.Size(230, 47);
            this.btnActuTecnico.TabIndex = 2;
            this.btnActuTecnico.Text = "Actualizar Técnico";
            this.btnActuTecnico.UseVisualStyleBackColor = false;
            this.btnActuTecnico.Click += new System.EventHandler(this.btnActuTecnico_Click);
            // 
            // btnConsTecnico
            // 
            this.btnConsTecnico.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsTecnico.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConsTecnico.Location = new System.Drawing.Point(81, 211);
            this.btnConsTecnico.Name = "btnConsTecnico";
            this.btnConsTecnico.Size = new System.Drawing.Size(230, 47);
            this.btnConsTecnico.TabIndex = 3;
            this.btnConsTecnico.Text = "Consultar Técnicos";
            this.btnConsTecnico.UseVisualStyleBackColor = false;
            this.btnConsTecnico.Click += new System.EventHandler(this.btnConsTecnico_Click);
            // 
            // btnSalirTecnico
            // 
            this.btnSalirTecnico.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalirTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirTecnico.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalirTecnico.Location = new System.Drawing.Point(81, 367);
            this.btnSalirTecnico.Name = "btnSalirTecnico";
            this.btnSalirTecnico.Size = new System.Drawing.Size(230, 47);
            this.btnSalirTecnico.TabIndex = 4;
            this.btnSalirTecnico.Text = "VOLVER";
            this.btnSalirTecnico.UseVisualStyleBackColor = false;
            this.btnSalirTecnico.Click += new System.EventHandler(this.btnSalirTecnico_Click);
            // 
            // Tecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.btnSalirTecnico);
            this.Controls.Add(this.btnConsTecnico);
            this.Controls.Add(this.btnActuTecnico);
            this.Controls.Add(this.btnRegisTecnico);
            this.Controls.Add(this.txtTecnicosTit);
            this.Name = "Tecnicos";
            this.Text = "Tecnicos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tecnicos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTecnicosTit;
        private System.Windows.Forms.Button btnRegisTecnico;
        private System.Windows.Forms.Button btnActuTecnico;
        private System.Windows.Forms.Button btnConsTecnico;
        private System.Windows.Forms.Button btnSalirTecnico;
    }
}