using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograII.Aeropuerto;

namespace ProyectoPrograII
{
    public partial class PrioridaddeVueloForms : Form
    {
        private Form1 form1;

        public PrioridaddeVueloForms(Form1 form)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        List<PrioridaddeVuelo> listaprioridaddeVuelos = new List<PrioridaddeVuelo>();


        private void button1_Click(object sender, EventArgs e)
        {
            //se creo objeto de la clase prioridad de vuelo
            PrioridaddeVuelo prioridaddeVuelo1 = new PrioridaddeVuelo
            (
                combtipoemer.Text,
                txtubicacion.Text
            );

            listaprioridaddeVuelos.Add(prioridaddeVuelo1);

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = listaprioridaddeVuelos;

            borrar();

        }

        public void borrar()
        {
            txtubicacion.Clear();
        }
        


    }
}
