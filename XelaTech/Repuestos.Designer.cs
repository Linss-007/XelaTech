namespace XelaTech
{
    partial class Repuestos
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
            this.txtRepuestosTit = new System.Windows.Forms.Label();
            this.btnRegisRepuesto = new System.Windows.Forms.Button();
            this.btnActuRepuesto = new System.Windows.Forms.Button();
            this.btnConsRepuesto = new System.Windows.Forms.Button();
            this.btnSalirRepuesto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRepuestosTit
            // 
            this.txtRepuestosTit.AutoSize = true;
            this.txtRepuestosTit.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepuestosTit.ForeColor = System.Drawing.Color.Navy;
            this.txtRepuestosTit.Location = new System.Drawing.Point(68, 9);
            this.txtRepuestosTit.Name = "txtRepuestosTit";
            this.txtRepuestosTit.Size = new System.Drawing.Size(256, 57);
            this.txtRepuestosTit.TabIndex = 0;
            this.txtRepuestosTit.Text = "REPUESTOS";
            // 
            // btnRegisRepuesto
            // 
            this.btnRegisRepuesto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegisRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisRepuesto.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisRepuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegisRepuesto.Location = new System.Drawing.Point(81, 69);
            this.btnRegisRepuesto.Name = "btnRegisRepuesto";
            this.btnRegisRepuesto.Size = new System.Drawing.Size(230, 47);
            this.btnRegisRepuesto.TabIndex = 1;
            this.btnRegisRepuesto.Text = "Registrar Repuesto";
            this.btnRegisRepuesto.UseVisualStyleBackColor = false;
            this.btnRegisRepuesto.Click += new System.EventHandler(this.btnRegisRepuesto_Click);
            // 
            // btnActuRepuesto
            // 
            this.btnActuRepuesto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActuRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActuRepuesto.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuRepuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActuRepuesto.Location = new System.Drawing.Point(81, 140);
            this.btnActuRepuesto.Name = "btnActuRepuesto";
            this.btnActuRepuesto.Size = new System.Drawing.Size(230, 47);
            this.btnActuRepuesto.TabIndex = 2;
            this.btnActuRepuesto.Text = "Actualizar Repuesto";
            this.btnActuRepuesto.UseVisualStyleBackColor = false;
            this.btnActuRepuesto.Click += new System.EventHandler(this.btnActuRepuesto_Click);
            // 
            // btnConsRepuesto
            // 
            this.btnConsRepuesto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsRepuesto.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsRepuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConsRepuesto.Location = new System.Drawing.Point(81, 211);
            this.btnConsRepuesto.Name = "btnConsRepuesto";
            this.btnConsRepuesto.Size = new System.Drawing.Size(230, 47);
            this.btnConsRepuesto.TabIndex = 3;
            this.btnConsRepuesto.Text = "Consultar Repuestos";
            this.btnConsRepuesto.UseVisualStyleBackColor = false;
            this.btnConsRepuesto.Click += new System.EventHandler(this.btnConsRepuesto_Click);
            // 
            // btnSalirRepuesto
            // 
            this.btnSalirRepuesto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalirRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirRepuesto.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirRepuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalirRepuesto.Location = new System.Drawing.Point(81, 367);
            this.btnSalirRepuesto.Name = "btnSalirRepuesto";
            this.btnSalirRepuesto.Size = new System.Drawing.Size(230, 47);
            this.btnSalirRepuesto.TabIndex = 4;
            this.btnSalirRepuesto.Text = "VOLVER";
            this.btnSalirRepuesto.UseVisualStyleBackColor = false;
            this.btnSalirRepuesto.Click += new System.EventHandler(this.btnSalirRepuesto_Click);
            // 
            // Repuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.btnSalirRepuesto);
            this.Controls.Add(this.btnConsRepuesto);
            this.Controls.Add(this.btnActuRepuesto);
            this.Controls.Add(this.btnRegisRepuesto);
            this.Controls.Add(this.txtRepuestosTit);
            this.Name = "Repuestos";
            this.Text = "Repuestos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Repuestos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtRepuestosTit;
        private System.Windows.Forms.Button btnRegisRepuesto;
        private System.Windows.Forms.Button btnActuRepuesto;
        private System.Windows.Forms.Button btnConsRepuesto;
        private System.Windows.Forms.Button btnSalirRepuesto;
    }
}