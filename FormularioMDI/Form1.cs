using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Supongamos que este código está en un botón de menú de tu ventana principal padre, mediante que se clickea el botóno aparece la otra ventana
            formVentanaText ventanaTexto = new formVentanaText();
            // Le indicamos que esete formulario es el pariente
            ventanaTexto.MdiParent = this;
            // Mostramos la ventana hija
            ventanaTexto.Show();
        }
    }
}
