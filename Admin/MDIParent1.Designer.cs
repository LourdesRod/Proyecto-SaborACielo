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
            Bclientes = new Button();
            BFactura = new Button();
            BListaProd = new Button();
            BListarVentas = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Bclientes
            // 
            Bclientes.Location = new Point(540, 85);
            Bclientes.Name = "Bclientes";
            Bclientes.Size = new Size(75, 23);
            Bclientes.TabIndex = 9;
            Bclientes.Text = "Clientes";
            Bclientes.UseVisualStyleBackColor = true;
            // 
            // BFactura
            // 
            BFactura.Image = Properties.Resources.empleados___copia;
            BFactura.ImageAlign = ContentAlignment.TopCenter;
            BFactura.Location = new Point(490, 329);
            BFactura.Name = "BFactura";
            BFactura.Size = new Size(158, 166);
            BFactura.TabIndex = 15;
            BFactura.Text = "Empleados";
            BFactura.TextAlign = ContentAlignment.BottomCenter;
            BFactura.UseVisualStyleBackColor = true;
            // 
            // BListaProd
            // 
            BListaProd.Image = Properties.Resources.decoracion_de_pasteles;
            BListaProd.ImageAlign = ContentAlignment.TopCenter;
            BListaProd.Location = new Point(142, 329);
            BListaProd.Name = "BListaProd";
            BListaProd.Size = new Size(158, 166);
            BListaProd.TabIndex = 14;
            BListaProd.Text = "Productos";
            BListaProd.TextAlign = ContentAlignment.BottomCenter;
            BListaProd.UseVisualStyleBackColor = true;
            // 
            // BListarVentas
            // 
            BListarVentas.Image = Properties.Resources.save_money_1611179;
            BListarVentas.ImageAlign = ContentAlignment.TopCenter;
            BListarVentas.Location = new Point(483, 83);
            BListarVentas.Name = "BListarVentas";
            BListarVentas.Size = new Size(158, 167);
            BListarVentas.TabIndex = 13;
            BListarVentas.Text = "Ventas";
            BListarVentas.TextAlign = ContentAlignment.BottomCenter;
            BListarVentas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.teamwork_2502447;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(142, 85);
            button1.Name = "button1";
            button1.Size = new Size(158, 167);
            button1.TabIndex = 12;
            button1.Text = "Clientes";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.fondoPrincipal;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(791, 523);
            Controls.Add(BFactura);
            Controls.Add(BListaProd);
            Controls.Add(BListarVentas);
            Controls.Add(button1);
            Controls.Add(Bclientes);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDIParent1";
            Load += MDIParent1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button Bclientes;
        private Button BFactura;
        private Button BListaProd;
        private Button BListarVentas;
        private Button button1;
    }
}



