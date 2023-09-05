using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaborACielo
{
    public partial class Finicio : Form
    {
        public Finicio()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Ayuda a evitar el parpadeo en la redibujación
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radioEsquinas = 20; // Ajusta el radio de las esquinas según tus preferencias
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.Left, rect.Top, radioEsquinas * 2, radioEsquinas * 2, 180, 90); // Esquina superior izquierda
                path.AddArc(rect.Right - radioEsquinas * 2, rect.Top, radioEsquinas * 2, radioEsquinas * 2, 270, 90); // Esquina superior derecha
                path.AddArc(rect.Right - radioEsquinas * 2, rect.Bottom - radioEsquinas * 2, radioEsquinas * 2, radioEsquinas * 2, 0, 90); // Esquina inferior derecha
                path.AddArc(rect.Left, rect.Bottom - radioEsquinas * 2, radioEsquinas * 2, radioEsquinas * 2, 90, 90); // Esquina inferior izquierda

                path.CloseAllFigures();
                this.Region = new Region(path);
            }
        }

        private void bSalir_Paint(object sender, PaintEventArgs e)
        {
            // Calcular el diámetro del botón (el mínimo entre ancho y alto)
            int diameter = Math.Min(bSalir.Width, bSalir.Height);

            // Crear un camino gráfico que represente un círculo
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, diameter, diameter);

            // Crear una región basada en el camino
            bSalir.Region = new Region(path);
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario MDI que deseas mostrar
            MDIParent1 formularioMDI = new MDIParent1();

            // Muestra el formulario MDI
            // Establece el formulario MDI principal como el padre
            formularioMDI.Show();
        }
    }
}
