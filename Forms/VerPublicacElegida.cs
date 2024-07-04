using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panalbase
{
    public partial class VerPublicacElegida : Form
    {
        public VerPublicacElegida()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarPubl edicion = new EditarPubl();
            edicion.txtEditarTexto.Text = LabelPublic.Text;
            edicion.pbEdicImag.Image = pictureBoxPublSel.Image;
            edicion.ShowDialog();
        }
    }
}
