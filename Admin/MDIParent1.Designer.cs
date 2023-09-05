namespace SaborACielo
{
    partial class MDIParent1
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
            this.Busuarios = new System.Windows.Forms.Button();
            this.Bproductos = new System.Windows.Forms.Button();
            this.Bventas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Busuarios
            // 
            this.Busuarios.Location = new System.Drawing.Point(42, 80);
            this.Busuarios.Name = "Busuarios";
            this.Busuarios.Size = new System.Drawing.Size(75, 28);
            this.Busuarios.TabIndex = 4;
            this.Busuarios.Text = "Usuarios";
            this.Busuarios.UseVisualStyleBackColor = true;
            this.Busuarios.Click += new System.EventHandler(this.Busuarios_Click);
            // 
            // Bproductos
            // 
            this.Bproductos.Location = new System.Drawing.Point(271, 52);
            this.Bproductos.Name = "Bproductos";
            this.Bproductos.Size = new System.Drawing.Size(75, 23);
            this.Bproductos.TabIndex = 5;
            this.Bproductos.Text = "Productos";
            this.Bproductos.UseVisualStyleBackColor = true;
            // 
            // Bventas
            // 
            this.Bventas.Location = new System.Drawing.Point(516, 52);
            this.Bventas.Name = "Bventas";
            this.Bventas.Size = new System.Drawing.Size(75, 23);
            this.Bventas.TabIndex = 6;
            this.Bventas.Text = "Ventas";
            this.Bventas.UseVisualStyleBackColor = true;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 453);
            this.Controls.Add(this.Bventas);
            this.Controls.Add(this.Bproductos);
            this.Controls.Add(this.Busuarios);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Button Busuarios;
        private System.Windows.Forms.Button Bproductos;
        private System.Windows.Forms.Button Bventas;
    }
}



