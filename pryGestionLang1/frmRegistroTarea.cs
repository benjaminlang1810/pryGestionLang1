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
    public partial class frmRegistroTarea : Form
    {
        public frmRegistroTarea()
        {
            InitializeComponent();
        }

        private void optNO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value >= DateTime.Today)
            {
                if (cboTipo.SelectedIndex != -1)
                {
                    if (txtDetalle.Text != "")
                    {
                        MessageBox.Show("Vamos a grabar....");
                    }
                    else
                    {
                        MessageBox.Show("Te falta completar el detalle...");
                        txtDetalle.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una actividad...");
                    cboTipo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy", "Carga de Tarea",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
        }       
    }
}
