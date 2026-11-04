namespace XelaTech
{
    partial class ConsultarEquipo
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
            this.txtConsultaEquipo = new System.Windows.Forms.Label();
            this.dgvEquiposGuardados = new System.Windows.Forms.DataGridView();
            this.btnFichaEquipo = new System.Windows.Forms.Button();
            this.btnVolverEquipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposGuardados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsultaEquipo
            // 
            this.txtConsultaEquipo.AutoSize = true;
            this.txtConsultaEquipo.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaEquipo.ForeColor = System.Drawing.Color.Navy;
            this.txtConsultaEquipo.Location = new System.Drawing.Point(35, 9);
            this.txtConsultaEquipo.Name = "txtConsultaEquipo";
            this.txtConsultaEquipo.Size = new System.Drawing.Size(493, 57);
            this.txtConsultaEquipo.TabIndex = 0;
            this.txtConsultaEquipo.Text = "Equipos Guardados";
            // 
            // dgvEquiposGuardados
            // 
            this.dgvEquiposGuardados.AllowUserToAddRows = false;
            this.dgvEquiposGuardados.AllowUserToDeleteRows = false;
            this.dgvEquiposGuardados.AllowUserToResizeColumns = false;
            this.dgvEquiposGuardados.AllowUserToResizeRows = false;
            this.dgvEquiposGuardados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEquiposGuardados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvEquiposGuardados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquiposGuardados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvEquiposGuardados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquiposGuardados.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvEquiposGuardados.Location = new System.Drawing.Point(21, 69);
            this.dgvEquiposGuardados.Name = "dgvEquiposGuardados";
            this.dgvEquiposGuardados.ReadOnly = true;
            this.dgvEquiposGuardados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquiposGuardados.MultiSelect = false;
            this.dgvEquiposGuardados.Size = new System.Drawing.Size(900, 330);
            this.dgvEquiposGuardados.TabIndex = 1;
            // 
            // btnFichaEquipo
            // 
            this.btnFichaEquipo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFichaEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFichaEquipo.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFichaEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnFichaEquipo.Location = new System.Drawing.Point(300, 420);
            this.btnFichaEquipo.Name = "btnFichaEquipo";
            this.btnFichaEquipo.Size = new System.Drawing.Size(127, 34);
            this.btnFichaEquipo.TabIndex = 2;
            this.btnFichaEquipo.Text = "Ver Ficha";
            this.btnFichaEquipo.UseVisualStyleBackColor = false;
            this.btnFichaEquipo.Click += new System.EventHandler(this.btnFichaEquipo_Click);
            // 
            // btnVolverEquipo
            // 
            this.btnVolverEquipo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolverEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverEquipo.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolverEquipo.Location = new System.Drawing.Point(520, 420);
            this.btnVolverEquipo.Name = "btnVolverEquipo";
            this.btnVolverEquipo.Size = new System.Drawing.Size(127, 34);
            this.btnVolverEquipo.TabIndex = 3;
            this.btnVolverEquipo.Text = "VOLVER";
            this.btnVolverEquipo.UseVisualStyleBackColor = false;
            this.btnVolverEquipo.Click += new System.EventHandler(this.btnVolverEquipo_Click);
            // 
            // ConsultarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(950, 480);
            this.Controls.Add(this.btnVolverEquipo);
            this.Controls.Add(this.btnFichaEquipo);
            this.Controls.Add(this.dgvEquiposGuardados);
            this.Controls.Add(this.txtConsultaEquipo);
            this.Name = "ConsultarEquipo";
            this.Text = "ConsultarEquipo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultarEquipo_FormClosed);
            this.Load += new System.EventHandler(this.ConsultarEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposGuardados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtConsultaEquipo;
        private System.Windows.Forms.DataGridView dgvEquiposGuardados;
        private System.Windows.Forms.Button btnFichaEquipo;
        private System.Windows.Forms.Button btnVolverEquipo;
    }
}