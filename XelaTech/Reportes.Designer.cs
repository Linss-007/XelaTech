namespace XelaTech
{
    partial class Reportes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblReporte = new System.Windows.Forms.Label();
            this.cbxReporte = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.rtbReporte = new System.Windows.Forms.RichTextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("LEMON MILK Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REPORTES";
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblReporte.Location = new System.Drawing.Point(20, 55);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(65, 18);
            this.lblReporte.TabIndex = 1;
            this.lblReporte.Text = "Reporte:";
            // 
            // cbxReporte
            // 
            this.cbxReporte.BackColor = System.Drawing.Color.PowderBlue;
            this.cbxReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReporte.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxReporte.FormattingEnabled = true;
            this.cbxReporte.Items.AddRange(new object[] {
            "1. Solicitudes en espera por prioridad",
            "2. Solicitudes activas, finalizadas y canceladas",
            "3. Tecnicos disponibles y con carga completa",
            "4. Tecnico con mas servicios finalizados",
            "5. Equipos atendidos por tipo",
            "6. Solicitudes ordenadas por costo total (Bubble Sort)",
            "7. Solicitudes ordenadas por fecha (Quick Sort)",
            "8. Repuestos ordenados por existencia (Shell Sort)",
            "9. Repuestos con existencia minima o agotados",
            "10. Ingresos totales por servicios finalizados",
            "11. Resultados de las tres busquedas secuenciales",
            "12. Matriz semanal de carga de trabajo"});
            this.cbxReporte.Location = new System.Drawing.Point(20, 78);
            this.cbxReporte.Name = "cbxReporte";
            this.cbxReporte.Size = new System.Drawing.Size(620, 23);
            this.cbxReporte.TabIndex = 2;
            this.cbxReporte.SelectedIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(660, 76);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(150, 32);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // rtbReporte
            // 
            this.rtbReporte.BackColor = System.Drawing.Color.White;
            this.rtbReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbReporte.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReporte.Location = new System.Drawing.Point(20, 120);
            this.rtbReporte.Name = "rtbReporte";
            this.rtbReporte.ReadOnly = true;
            this.rtbReporte.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.rtbReporte.Size = new System.Drawing.Size(940, 490);
            this.rtbReporte.TabIndex = 4;
            this.rtbReporte.Text = "";
            this.rtbReporte.WordWrap = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolver.Location = new System.Drawing.Point(860, 625);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 36);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 680);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.rtbReporte);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cbxReporte);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reportes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.ComboBox cbxReporte;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RichTextBox rtbReporte;
        private System.Windows.Forms.Button btnVolver;
    }
}
