namespace XelaTech
{
    partial class ConsultarCliente
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
            this.txtConsultaCliente = new System.Windows.Forms.Label();
            this.dgvClientesGuardados = new System.Windows.Forms.DataGridView();
            this.btnVolverCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesGuardados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsultaCliente
            // 
            this.txtConsultaCliente.AutoSize = true;
            this.txtConsultaCliente.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaCliente.ForeColor = System.Drawing.Color.Navy;
            this.txtConsultaCliente.Location = new System.Drawing.Point(35, 9);
            this.txtConsultaCliente.Name = "txtConsultaCliente";
            this.txtConsultaCliente.Size = new System.Drawing.Size(526, 57);
            this.txtConsultaCliente.TabIndex = 6;
            this.txtConsultaCliente.Text = "Clientes Guardados";
            // 
            // dgvClientesGuardados
            // 
            this.dgvClientesGuardados.AllowUserToAddRows = false;
            this.dgvClientesGuardados.AllowUserToDeleteRows = false;
            this.dgvClientesGuardados.AllowUserToResizeColumns = false;
            this.dgvClientesGuardados.AllowUserToResizeRows = false;
            this.dgvClientesGuardados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvClientesGuardados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientesGuardados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvClientesGuardados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesGuardados.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvClientesGuardados.Location = new System.Drawing.Point(21, 69);
            this.dgvClientesGuardados.Name = "dgvClientesGuardados";
            this.dgvClientesGuardados.ReadOnly = true;
            this.dgvClientesGuardados.Size = new System.Drawing.Size(552, 299);
            this.dgvClientesGuardados.TabIndex = 8;
            // 
            // btnVolverCliente
            // 
            this.btnVolverCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolverCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverCliente.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolverCliente.Location = new System.Drawing.Point(241, 404);
            this.btnVolverCliente.Name = "btnVolverCliente";
            this.btnVolverCliente.Size = new System.Drawing.Size(127, 34);
            this.btnVolverCliente.TabIndex = 12;
            this.btnVolverCliente.Text = "VOLVER";
            this.btnVolverCliente.UseVisualStyleBackColor = false;
            this.btnVolverCliente.Click += new System.EventHandler(this.btnVolverCliente_Click);
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnVolverCliente);
            this.Controls.Add(this.dgvClientesGuardados);
            this.Controls.Add(this.txtConsultaCliente);
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultarCliente_FormClosed);
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesGuardados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtConsultaCliente;
        private System.Windows.Forms.DataGridView dgvClientesGuardados;
        private System.Windows.Forms.Button btnVolverCliente;
    }
}