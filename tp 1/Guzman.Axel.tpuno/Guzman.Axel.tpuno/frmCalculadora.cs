using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guzman.Axel.tpuno
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado";
            txtNumeroUno.Text = "";
            txtNumeroDos.Text = "";
            cmbOperacion.Text = "";
        }

        private void txtNumeroDos_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void txtNumeroUno_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Calculadora miCalculadora = new Calculadora();
            Numero numeroUno = new Numero(txtNumeroUno.Text);
            Numero numeroDos = new Numero(txtNumeroDos.Text);

            lblResultado.Text = miCalculadora.Operar(numeroUno, numeroDos, cmbOperacion.Text).ToString();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
