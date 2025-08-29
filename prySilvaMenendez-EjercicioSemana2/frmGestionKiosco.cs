using System.Diagnostics.Eventing.Reader;

namespace prySilvaMenendez_EjercicioSemana2
{
    public partial class frmGestionKiosco : Form
    {
        public frmGestionKiosco()
        {
            InitializeComponent();
        }

        private void btnModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (btnModificar.Checked)
            {
                lblAgregado.Show();
                txtAgregado.Show();
                
            }
            
                
            

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        { 

                if (btnAgregar.Checked)
                    MessageBox.Show("Producto Agregado Correctamente");
                if (btnEliminar.Checked)
                    MessageBox.Show("Producto Eliminado Correctamente");
                if (btnModificar.Checked)
                    MessageBox.Show("Producto Modificado Correctamente");

            }

        }
    }

