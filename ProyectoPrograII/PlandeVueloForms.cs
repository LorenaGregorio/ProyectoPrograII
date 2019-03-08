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
    public partial class PlandeVueloForms : Form
    {
        private Form1 form1;

        public PlandeVueloForms(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        //se crea la lista de plan de vuelo

        List<PlandeVuelo> listaplandeVuelos = new List<PlandeVuelo>();

        private void button1_Click(object sender, EventArgs e)
        {
            //se crea el objeto para la clase plan de vuelo

            PlandeVuelo plandevue1 = new PlandeVuelo
            (
                combaccion.Text,
                combpista.Text,
                dateTimedespegue.Text,
                dateTimeaterrizaje.Text
                                

            );

            listaplandeVuelos.Add(plandevue1);

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = listaplandeVuelos;

            borrar();
           
                    
        }
        public void borrar()
        {
            
        }
    }
}
