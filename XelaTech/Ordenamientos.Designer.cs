namespace XelaTech
{
    partial class Ordenamientos
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
            this.cbxOpcion = new System.Windows.Forms.ComboBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("LEMON MILK Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(310, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ORDENAMIENTOS";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 55);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(740, 15);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Seleccione el algoritmo y el criterio. Los datos se ordenan sobre una copia, sin modificar las listas originales.";
            // 
            // cbxOpcion
            // 
            this.cbxOpcion.BackColor = System.Drawing.Color.PowderBlue;
            this.cbxOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOpcion.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOpcion.FormattingEnabled = true;
            this.cbxOpcion.Items.AddRange(new object[] {
            "1. Bubble Sort - solicitudes por costo total (descendente)",
            "2. Selection Sort - tecnicos por servicios finalizados (descendente)",
            "3. Shell Sort - repuestos por existencia (ascendente)",
            "4. Quick Sort - solicitudes por fecha de recepcion (ascendente)"});
            this.cbxOpcion.Location = new System.Drawing.Point(20, 80);
            this.cbxOpcion.Name = "cbxOpcion";
            this.cbxOpcion.Size = new System.Drawing.Size(620, 23);
            this.cbxOpcion.TabIndex = 2;
            this.cbxOpcion.SelectedIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenar.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.White;
            this.btnOrdenar.Location = new System.Drawing.Point(660, 76);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(150, 32);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoEllipsis = true;
            this.lblEncabezado.BackColor = System.Drawing.Color.White;
            this.lblEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEncabezado.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.Navy;
            this.lblEncabezado.Location = new System.Drawing.Point(20, 120);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(920, 42);
            this.lblEncabezado.TabIndex = 4;
            this.lblEncabezado.Text = "Seleccione una opcion y presione Ordenar.";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResultados.Location = new System.Drawing.Point(20, 172);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(920, 395);
            this.dgvResultados.TabIndex = 5;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolver.Location = new System.Drawing.Point(830, 580);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 36);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Ordenamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(960, 645);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.cbxOpcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ordenamientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenamientos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ordenamientos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cbxOpcion;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnVolver;
    }
}
