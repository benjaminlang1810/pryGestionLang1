using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionLang1
{
    public partial class frmInicioDeSesion : Form
    {
        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmInicioDeSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "123")
            {
                Form Actividad = new frmRegistroTarea();
                Actividad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de datos");
            }
        }
    }
}
