namespace XelaTech
{
    partial class Clientes
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
            this.txtClientesTit = new System.Windows.Forms.Label();
            this.btnRegisCliente = new System.Windows.Forms.Button();
            this.btnConsCliente = new System.Windows.Forms.Button();
            this.btnActuCliente = new System.Windows.Forms.Button();
            this.btnSalirCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClientesTit
            // 
            this.txtClientesTit.AutoSize = true;
            this.txtClientesTit.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientesTit.ForeColor = System.Drawing.Color.Navy;
            this.txtClientesTit.Location = new System.Drawing.Point(80, 9);
            this.txtClientesTit.Name = "txtClientesTit";
            this.txtClientesTit.Size = new System.Drawing.Size(228, 57);
            this.txtClientesTit.TabIndex = 0;
            this.txtClientesTit.Text = "CLIENTES";
            // 
            // btnRegisCliente
            // 
            this.btnRegisCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegisCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisCliente.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegisCliente.Location = new System.Drawing.Point(99, 69);
            this.btnRegisCliente.Name = "btnRegisCliente";
            this.btnRegisCliente.Size = new System.Drawing.Size(187, 47);
            this.btnRegisCliente.TabIndex = 1;
            this.btnRegisCliente.Text = "Registrar Cliente";
            this.btnRegisCliente.UseVisualStyleBackColor = false;
            this.btnRegisCliente.Click += new System.EventHandler(this.btnRegisCliente_Click);
            // 
            // btnConsCliente
            // 
            this.btnConsCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsCliente.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConsCliente.Location = new System.Drawing.Point(99, 211);
            this.btnConsCliente.Name = "btnConsCliente";
            this.btnConsCliente.Size = new System.Drawing.Size(187, 47);
            this.btnConsCliente.TabIndex = 2;
            this.btnConsCliente.Text = "Consultar Clientes";
            this.btnConsCliente.UseVisualStyleBackColor = false;
            // 
            // btnActuCliente
            // 
            this.btnActuCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActuCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActuCliente.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActuCliente.Location = new System.Drawing.Point(99, 136);
            this.btnActuCliente.Name = "btnActuCliente";
            this.btnActuCliente.Size = new System.Drawing.Size(187, 47);
            this.btnActuCliente.TabIndex = 3;
            this.btnActuCliente.Text = "Actualizar Cliente";
            this.btnActuCliente.UseVisualStyleBackColor = false;
            this.btnActuCliente.Click += new System.EventHandler(this.btnActuCliente_Click);
            // 
            // btnSalirCliente
            // 
            this.btnSalirCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirCliente.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalirCliente.Location = new System.Drawing.Point(99, 367);
            this.btnSalirCliente.Name = "btnSalirCliente";
            this.btnSalirCliente.Size = new System.Drawing.Size(187, 47);
            this.btnSalirCliente.TabIndex = 4;
            this.btnSalirCliente.Text = "VOLVER";
            this.btnSalirCliente.UseVisualStyleBackColor = false;
            this.btnSalirCliente.Click += new System.EventHandler(this.btnSalirCliente_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.btnSalirCliente);
            this.Controls.Add(this.btnActuCliente);
            this.Controls.Add(this.btnConsCliente);
            this.Controls.Add(this.btnRegisCliente);
            this.Controls.Add(this.txtClientesTit);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Clientes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtClientesTit;
        private System.Windows.Forms.Button btnRegisCliente;
        private System.Windows.Forms.Button btnConsCliente;
        private System.Windows.Forms.Button btnActuCliente;
        private System.Windows.Forms.Button btnSalirCliente;
    }
}