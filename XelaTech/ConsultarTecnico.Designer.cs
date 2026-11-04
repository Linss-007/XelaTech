namespace XelaTech
{
    partial class ConsultarTecnico
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
            this.txtConsultaTecnico = new System.Windows.Forms.Label();
            this.dgvTecnicosGuardados = new System.Windows.Forms.DataGridView();
            this.btnVolverTecnico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnicosGuardados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsultaTecnico
            // 
            this.txtConsultaTecnico.AutoSize = true;
            this.txtConsultaTecnico.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaTecnico.ForeColor = System.Drawing.Color.Navy;
            this.txtConsultaTecnico.Location = new System.Drawing.Point(35, 9);
            this.txtConsultaTecnico.Name = "txtConsultaTecnico";
            this.txtConsultaTecnico.Size = new System.Drawing.Size(522, 57);
            this.txtConsultaTecnico.TabIndex = 0;
            this.txtConsultaTecnico.Text = "Tecnicos Guardados";
            // 
            // dgvTecnicosGuardados
            // 
            this.dgvTecnicosGuardados.AllowUserToAddRows = false;
            this.dgvTecnicosGuardados.AllowUserToDeleteRows = false;
            this.dgvTecnicosGuardados.AllowUserToResizeColumns = false;
            this.dgvTecnicosGuardados.AllowUserToResizeRows = false;
            this.dgvTecnicosGuardados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTecnicosGuardados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvTecnicosGuardados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTecnicosGuardados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvTecnicosGuardados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecnicosGuardados.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvTecnicosGuardados.Location = new System.Drawing.Point(21, 69);
            this.dgvTecnicosGuardados.Name = "dgvTecnicosGuardados";
            this.dgvTecnicosGuardados.ReadOnly = true;
            this.dgvTecnicosGuardados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTecnicosGuardados.MultiSelect = false;
            this.dgvTecnicosGuardados.Size = new System.Drawing.Size(650, 299);
            this.dgvTecnicosGuardados.TabIndex = 1;
            // 
            // btnVolverTecnico
            // 
            this.btnVolverTecnico.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolverTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverTecnico.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolverTecnico.Location = new System.Drawing.Point(286, 404);
            this.btnVolverTecnico.Name = "btnVolverTecnico";
            this.btnVolverTecnico.Size = new System.Drawing.Size(127, 34);
            this.btnVolverTecnico.TabIndex = 2;
            this.btnVolverTecnico.Text = "VOLVER";
            this.btnVolverTecnico.UseVisualStyleBackColor = false;
            this.btnVolverTecnico.Click += new System.EventHandler(this.btnVolverTecnico_Click);
            // 
            // ConsultarTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnVolverTecnico);
            this.Controls.Add(this.dgvTecnicosGuardados);
            this.Controls.Add(this.txtConsultaTecnico);
            this.Name = "ConsultarTecnico";
            this.Text = "ConsultarTecnico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultarTecnico_FormClosed);
            this.Load += new System.EventHandler(this.ConsultarTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnicosGuardados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtConsultaTecnico;
        private System.Windows.Forms.DataGridView dgvTecnicosGuardados;
        private System.Windows.Forms.Button btnVolverTecnico;
    }
}