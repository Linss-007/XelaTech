namespace XelaTech
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = true;
            this.MenuTitulo.Font = new System.Drawing.Font("LEMON MILK Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitulo.Location = new System.Drawing.Point(139, 9);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.Size = new System.Drawing.Size(243, 53);
            this.MenuTitulo.TabIndex = 0;
            this.MenuTitulo.Text = "XELA TECH";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.MenuTitulo);
            this.Name = "MenuPrincipal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuTitulo;
    }
}

