namespace XelaTech
{
    partial class DatosPrueba
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("LEMON MILK Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(470, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GENERAR DATOS DE PRUEBA";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 58);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(670, 15);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Genera clientes, tecnicos, equipos, repuestos y solicitudes con valores aleatorios controlados.";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCantidad.Location = new System.Drawing.Point(20, 100);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(164, 18);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad por tipo (5-20):";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.PowderBlue;
            this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCantidad.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(20, 123);
            this.nudCantidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(80, 22);
            this.nudCantidad.TabIndex = 3;
            this.nudCantidad.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(120, 120);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(160, 32);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar datos";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.BackColor = System.Drawing.Color.White;
            this.lblResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResumen.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(20, 180);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Padding = new System.Windows.Forms.Padding(10);
            this.lblResumen.Size = new System.Drawing.Size(920, 400);
            this.lblResumen.TabIndex = 5;
            this.lblResumen.Text = "Presione Generar datos para crear un conjunto de prueba.";
            this.lblResumen.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolver.Location = new System.Drawing.Point(830, 595);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 36);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // DatosPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(960, 645);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DatosPrueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar datos de prueba";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatosPrueba_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnVolver;
    }
}
