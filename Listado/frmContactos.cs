using BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listado
{
    public partial class frmContactos : Form
    {
        private Contactos Contactos = new Contactos();
        public frmContactos()
        {
            InitializeComponent();
            DGV.DataSource = Contactos.Lista;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Contacto Contacto = new Contacto(txtCelu.Text,
                                             txtNombre.Text,
                                             txtApellido.Text,
                                             txtLlamadas.Text);

            Contactos.Insert(Contacto);
        }
    }
}
