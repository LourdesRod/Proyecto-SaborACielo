﻿namespace SaborACielo.Vendedor
{
    partial class InicioV
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
            BAgregarCliente = new Button();
            BListarVentas = new Button();
            BListaProd = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // BAgregarCliente
            // 
            BAgregarCliente.Image = Properties.Resources.agregar;
            BAgregarCliente.ImageAlign = ContentAlignment.TopCenter;
            BAgregarCliente.Location = new Point(213, 113);
            BAgregarCliente.Name = "BAgregarCliente";
            BAgregarCliente.Size = new Size(158, 167);
            BAgregarCliente.TabIndex = 0;
            BAgregarCliente.Text = "Clientes";
            BAgregarCliente.TextAlign = ContentAlignment.BottomCenter;
            BAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // BListarVentas
            // 
            BListarVentas.Image = Properties.Resources.product;
            BListarVentas.ImageAlign = ContentAlignment.TopCenter;
            BListarVentas.Location = new Point(561, 113);
            BListarVentas.Name = "BListarVentas";
            BListarVentas.Size = new Size(158, 167);
            BListarVentas.TabIndex = 1;
            BListarVentas.Text = "Ventas";
            BListarVentas.TextAlign = ContentAlignment.BottomCenter;
            BListarVentas.UseVisualStyleBackColor = true;
            // 
            // BListaProd
            // 
            BListaProd.Image = Properties.Resources.verprod;
            BListaProd.ImageAlign = ContentAlignment.TopCenter;
            BListaProd.Location = new Point(213, 414);
            BListaProd.Name = "BListaProd";
            BListaProd.Size = new Size(158, 166);
            BListaProd.TabIndex = 2;
            BListaProd.Text = "Productos";
            BListaProd.TextAlign = ContentAlignment.BottomCenter;
            BListaProd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.recibo;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(561, 414);
            button1.Name = "button1";
            button1.Size = new Size(158, 166);
            button1.TabIndex = 3;
            button1.Text = "Facturas";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // InicioV
            // 
            AutoScaleDimensions = new SizeF(15F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 702);
            Controls.Add(button1);
            Controls.Add(BListaProd);
            Controls.Add(BListarVentas);
            Controls.Add(BAgregarCliente);
            Font = new Font("Brush Script MT", 16F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "InicioV";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button BAgregarCliente;
        private Button BListarVentas;
        private Button BListaProd;
        private Button button1;
    }
}