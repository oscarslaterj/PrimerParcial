using PrimerParcial.BLL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial.UI.Registros
{
    public partial class RegistroPrimerParcial : Form
    {
        public RegistroPrimerParcial()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombrestextBox.Text = string.Empty;
            SueldonumericUpDown.Value = 0;
            PorcRetencionnumericUpDown.Value = 0;
            RetencionnumericUpDown.Value = 0;
        }

        private Vendedores LlenaClase()
        {
            Vendedores vendedor = new Vendedores();
            vendedor.VendedorId = Convert.ToInt32(IDnumericUpDown.Value);
            vendedor.Nombres = NombrestextBox.Text;
            vendedor.Sueldo = Convert.ToInt32(SueldonumericUpDown.Value);
            vendedor.PorcRetencion = Convert.ToInt32(PorcRetencionnumericUpDown.Value);
            vendedor.Retencion = Convert.ToInt32(RetencionnumericUpDown.Value);
            return vendedor;
        }

        private void LlenaCampo(Vendedores vendedor)
        {
            IDnumericUpDown.Value = vendedor.VendedorId;
            NombrestextBox.Text = vendedor.Nombres;
            SueldonumericUpDown.Value = vendedor.Sueldo;
            PorcRetencionnumericUpDown.Value = vendedor.PorcRetencion;
            RetencionnumericUpDown.Value = vendedor.Retencion;

        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Vendedores vendedor = VendedoresBLL.Buscar((int)IDnumericUpDown.Value);

            return (vendedor != null);
        }


        private bool Validar(int validar)
        {
            bool paso = false;
            if (validar == 1 && IDnumericUpDown.Value == 0)
            {
                errorProvider.SetError(IDnumericUpDown, "Ingrese un ID");
                paso = true;
            }
            if (validar == 2 && NombrestextBox.Text == String.Empty)
            {
                errorProvider.SetError(NombrestextBox, "digite los nombres");
                paso = true;
            }
            if (validar == 2 && SueldonumericUpDown.Value == 0)
            {
                errorProvider.SetError(SueldonumericUpDown, "Ingrese Sueldo");
                paso = true;
            }
            if (validar == 2 && PorcRetencionnumericUpDown.Value == 0)
            {
                errorProvider.SetError(PorcRetencionnumericUpDown, "Ingrese el Porciento de retencion");
                paso = true;
            }
            if (validar == 2 && RetencionnumericUpDown.Value == 0)
            {
                errorProvider.SetError(RetencionnumericUpDown, "Ingrese retencion");
                paso = true;
            }
            return paso;
        }


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Vendedores vendedor = new Vendedores();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

           vendedor = VendedoresBLL.Buscar(id);

            if (vendedor!= null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenaCampo(vendedor);
            }
            else
            {
                MessageBox.Show("Persona no Encontada");
            }
        }


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            Vendedores vendedor;
            bool paso = false;

            if (Validar(2))
            {
                MessageBox.Show("LLenar los campos marcados");
                return;
            }

            vendedor = LlenaClase();
            Limpiar();
           
            if (IDnumericUpDown.Value == 0)
                paso = VendedoresBLL.Guardar(vendedor);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un vendedor que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = BLL.VendedoresBLL.Modificar(vendedor);
            }
          
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingresar un ID");
                return;
            }

            int id = Convert.ToInt32(IDnumericUpDown.Value);

            if (BLL.VendedoresBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void RetencionnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PorcRetencionnumericUpDown.Value != 0)
                PorcRetencionnumericUpDown.Value = PorcRetencionnumericUpDown.Value / 100;
        }
    }
}
