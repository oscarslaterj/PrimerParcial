using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerParcial.Entidades;
using PrimerParcial.BLL;

namespace PrimerParcial.UI.Consultas
{
    public partial class ConsultaPrimerParcial : Form
    {
        public ConsultaPrimerParcial()
        {
            InitializeComponent();
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Vendedores, bool>> filtro = x => true;

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://Id
                    filtro = t => t.VendedorId.Equals(CriteriotextBox.Text)
                    && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month)
                    && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day)
                    && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;

                case 1://Nombres
                    filtro = t => t.Nombres.Equals(CriteriotextBox.Text)
                    && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month)
                    && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day)
                    && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
                case 2://Sueldo
                    filtro = t => t.Sueldo.Equals(CriteriotextBox.Text)
                    && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month)
                    && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day)
                    && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
                case 3://Porciento de retencion
                    filtro = t => t.PorcRetencion.Equals(CriteriotextBox.Text)
                    && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month)
                    && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day)
                    && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
                case 4://Retencion
                    filtro = t => t.Retencion.Equals(CriteriotextBox.Text)
                    && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month)
                    && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day)
                    && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
                case 5://todos
                    filtro = x => true;
                    break;

            }

            ConsultadataGridView.DataSource = BLL.VendedoresBLL.GetList(filtro);
        }
    }
}

