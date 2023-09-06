namespace SaborACielo
{
    partial class Finicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finicio));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            bIngresar = new Button();
            bSalir = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(234, 150);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 41);
            label1.TabIndex = 0;
            label1.Text = "Sabor ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Script MT Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(339, 158);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(26, 29);
            label2.TabIndex = 1;
            label2.Text = "a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Script MT Bold", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(264, 193);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 39);
            label3.TabIndex = 2;
            label3.Text = "Cielo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Script MT Bold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(191, 297);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 24);
            label4.TabIndex = 3;
            label4.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Script MT Bold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(178, 338);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 24);
            label5.TabIndex = 4;
            label5.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(355, 297);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(355, 338);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 6;
            // 
            // bIngresar
            // 
            bIngresar.BackColor = Color.RosyBrown;
            bIngresar.FlatAppearance.BorderColor = Color.RosyBrown;
            bIngresar.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            bIngresar.FlatAppearance.MouseOverBackColor = Color.RosyBrown;
            bIngresar.FlatStyle = FlatStyle.Popup;
            bIngresar.Font = new Font("Script MT Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bIngresar.Location = new Point(234, 396);
            bIngresar.Margin = new Padding(4, 3, 4, 3);
            bIngresar.Name = "bIngresar";
            bIngresar.Size = new Size(154, 40);
            bIngresar.TabIndex = 7;
            bIngresar.Text = "Ingresar";
            bIngresar.UseVisualStyleBackColor = false;
            bIngresar.Click += bIngresar_Click;
            // 
            // bSalir
            // 
            bSalir.BackColor = Color.Transparent;
            bSalir.FlatAppearance.BorderSize = 0;
            bSalir.FlatStyle = FlatStyle.Flat;
            bSalir.Image = (Image)resources.GetObject("bSalir.Image");
            bSalir.Location = new Point(552, 14);
            bSalir.Margin = new Padding(4, 3, 4, 3);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(55, 63);
            bSalir.TabIndex = 8;
            bSalir.UseVisualStyleBackColor = false;
            bSalir.Click += bSalir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Script MT Bold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(267, 254);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 24);
            label6.TabIndex = 9;
            label6.Text = "Inicio";
            // 
            // Finicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(621, 621);
            Controls.Add(label6);
            Controls.Add(bSalir);
            Controls.Add(bIngresar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Finicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button bIngresar;
        private Button bSalir;
        private Label label6;
    }
}

