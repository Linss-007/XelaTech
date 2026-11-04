namespace XelaTech
{
    partial class ConsultarSolicitud
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
            this.txtConsultaSoli = new System.Windows.Forms.Label();
            this.dgvSolicitudesGuardadas = new System.Windows.Forms.DataGridView();
            this.lblColasSoli = new System.Windows.Forms.Label();
            this.btnFichaSoli = new System.Windows.Forms.Button();
            this.btnVolverSoli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesGuardadas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsultaSoli
            // 
            this.txtConsultaSoli.AutoSize = true;
            this.txtConsultaSoli.Font = new System.Drawing.Font("LEMON MILK Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaSoli.ForeColor = System.Drawing.Color.Navy;
            this.txtConsultaSoli.Location = new System.Drawing.Point(35, 9);
            this.txtConsultaSoli.Name = "txtConsultaSoli";
            this.txtConsultaSoli.Size = new System.Drawing.Size(609, 57);
            this.txtConsultaSoli.TabIndex = 0;
            this.txtConsultaSoli.Text = "Solicitudes Guardadas";
            // 
            // dgvSolicitudesGuardadas
            // 
            this.dgvSolicitudesGuardadas.AllowUserToAddRows = false;
            this.dgvSolicitudesGuardadas.AllowUserToDeleteRows = false;
            this.dgvSolicitudesGuardadas.AllowUserToResizeColumns = false;
            this.dgvSolicitudesGuardadas.AllowUserToResizeRows = false;
            this.dgvSolicitudesGuardadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSolicitudesGuardadas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSolicitudesGuardadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSolicitudesGuardadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSolicitudesGuardadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesGuardadas.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSolicitudesGuardadas.Location = new System.Drawing.Point(21, 69);
            this.dgvSolicitudesGuardadas.Name = "dgvSolicitudesGuardadas";
            this.dgvSolicitudesGuardadas.ReadOnly = true;
            this.dgvSolicitudesGuardadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudesGuardadas.MultiSelect = false;
            this.dgvSolicitudesGuardadas.Size = new System.Drawing.Size(950, 340);
            this.dgvSolicitudesGuardadas.TabIndex = 1;
            // 
            // lblColasSoli
            // 
            this.lblColasSoli.AutoSize = true;
            this.lblColasSoli.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColasSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblColasSoli.Location = new System.Drawing.Point(21, 420);
            this.lblColasSoli.Name = "lblColasSoli";
            this.lblColasSoli.Size = new System.Drawing.Size(400, 18);
            this.lblColasSoli.TabIndex = 2;
            this.lblColasSoli.Text = "";
            // 
            // btnFichaSoli
            // 
            this.btnFichaSoli.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFichaSoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFichaSoli.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFichaSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnFichaSoli.Location = new System.Drawing.Point(330, 455);
            this.btnFichaSoli.Name = "btnFichaSoli";
            this.btnFichaSoli.Size = new System.Drawing.Size(127, 34);
            this.btnFichaSoli.TabIndex = 3;
            this.btnFichaSoli.Text = "Ver Ficha";
            this.btnFichaSoli.UseVisualStyleBackColor = false;
            this.btnFichaSoli.Click += new System.EventHandler(this.btnFichaSoli_Click);
            // 
            // btnVolverSoli
            // 
            this.btnVolverSoli.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolverSoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverSoli.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVolverSoli.Location = new System.Drawing.Point(540, 455);
            this.btnVolverSoli.Name = "btnVolverSoli";
            this.btnVolverSoli.Size = new System.Drawing.Size(127, 34);
            this.btnVolverSoli.TabIndex = 4;
            this.btnVolverSoli.Text = "VOLVER";
            this.btnVolverSoli.UseVisualStyleBackColor = false;
            this.btnVolverSoli.Click += new System.EventHandler(this.btnVolverSoli_Click);
            // 
            // ConsultarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 510);
            this.Controls.Add(this.btnVolverSoli);
            this.Controls.Add(this.btnFichaSoli);
            this.Controls.Add(this.lblColasSoli);
            this.Controls.Add(this.dgvSolicitudesGuardadas);
            this.Controls.Add(this.txtConsultaSoli);
            this.Name = "ConsultarSolicitud";
            this.Text = "ConsultarSolicitud";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultarSolicitud_FormClosed);
            this.Load += new System.EventHandler(this.ConsultarSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesGuardadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtConsultaSoli;
        private System.Windows.Forms.DataGridView dgvSolicitudesGuardadas;
        private System.Windows.Forms.Label lblColasSoli;
        private System.Windows.Forms.Button btnFichaSoli;
        private System.Windows.Forms.Button btnVolverSoli;
    }
}