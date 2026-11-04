namespace XelaTech
{
    partial class ConsultarRepuesto
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
            this.txtConsultaRepuesto = new System.Windows.Forms.Label();
            this.dgvRepuestosGuardados = new System.Windows.Forms.DataGridView();
            this.txtLeyendaRepuesto = new System.Windows.Forms.Label();
            this.btnVolverRepuesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestosGuardados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsultaRepuesto
            // 
            this.txtConsultaRepuesto.AutoSize = true;
            this.txtConsultaRepuesto.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaRepuesto.ForeColor = System.Drawing.Color.Navy;
            this.txtConsultaRepuesto.Location = new System.Drawing.Point(35, 9);
            this.txtConsultaRepuesto.Name = "txtConsultaRepuesto";
            this.txtConsultaRepuesto.Size = new System.Drawing.Size(551, 57);
            this.txtConsultaRepuesto.TabIndex = 0;
            this.txtConsultaRepuesto.Text = "Repuestos Guardados";
            // 
            // dgvRepuestosGuardados
            // 
            this.dgvRepuestosGuardados.AllowUserToAddRows = false;
            this.dgvRepuestosGuardados.AllowUserToDeleteRows = false;
            this.dgvRepuestosGuardados.AllowUserToResizeColumns = false;
            this.dgvRepuestosGuardados.AllowUserToResizeRows = false;
            this.dgvRepuestosGuardados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRepuestosGuardados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvRepuestosGuardados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRepuestosGuardados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRepuestosGuardados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestosGuardados.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvRepuestosGuardados.Location = new System.Drawing.Point(21, 69);
            this.dgvRepuestosGuardados.Name = "dgvRepuestosGuardados";
            this.dgvRepuestosGuardados.ReadOnly = true;
            this.dgvRepuestosGuardados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepuestosGuardados.MultiSelect = false;
            this.dgvRepuestosGuardados.Size = new System.Drawing.Size(900, 330);
            this.dgvRepuestosGuardados.TabIndex = 1;
            this.dgvRepuestosGuardados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRepuestosGuardados_CellFormatting);
            // 
            // txtLeyendaRepuesto
            // 
            this.txtLeyendaRepuesto.AutoSize = true;
            this.txtLeyendaRepuesto.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeyendaRepuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtLeyendaRepuesto.Location = new System.Drawing.Point(21, 410);
            this.txtLeyendaRepuesto.Name = "txtLeyendaRepuesto";
            this.txtLeyendaRepuesto.Size = new System.Drawing.Size(400, 18);
            this.txtLeyendaRepuesto.TabIndex = 2;
            this.txtLeyendaRepuesto.Text = "Rojo: agotado   |   Naranja: existencia mínima";
            // 
            // btnVolverRepuesto
            // 
            this.btnVolverRepuesto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolverRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverRepuesto.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverRepuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolverRepuesto.Location = new System.Drawing.Point(410, 440);
            this.btnVolverRepuesto.Name = "btnVolverRepuesto";
            this.btnVolverRepuesto.Size = new System.Drawing.Size(127, 34);
            this.btnVolverRepuesto.TabIndex = 3;
            this.btnVolverRepuesto.Text = "VOLVER";
            this.btnVolverRepuesto.UseVisualStyleBackColor = false;
            this.btnVolverRepuesto.Click += new System.EventHandler(this.btnVolverRepuesto_Click);
            // 
            // ConsultarRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.btnVolverRepuesto);
            this.Controls.Add(this.txtLeyendaRepuesto);
            this.Controls.Add(this.dgvRepuestosGuardados);
            this.Controls.Add(this.txtConsultaRepuesto);
            this.Name = "ConsultarRepuesto";
            this.Text = "ConsultarRepuesto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultarRepuesto_FormClosed);
            this.Load += new System.EventHandler(this.ConsultarRepuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestosGuardados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtConsultaRepuesto;
        private System.Windows.Forms.DataGridView dgvRepuestosGuardados;
        private System.Windows.Forms.Label txtLeyendaRepuesto;
        private System.Windows.Forms.Button btnVolverRepuesto;
    }
}