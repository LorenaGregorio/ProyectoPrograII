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
    public partial class PlandeVueloForms : Form     {
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

        private void PlandeVueloForms_Load(object sender, EventArgs e)
        {
          
        }

        private void combaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combaccion.SelectedItem.Equals("Aterrizar"))
            {

                label4.Visible = true;
                dateTimeaterrizaje.Visible = true;

                label3.Visible = false;
             

            }
            else if (combaccion.SelectedItem.Equals("Despegar"))
            {
                label3.Visible = true;
                dateTimeaterrizaje.Visible = true;

                label4.Visible = false;
         

            }
        }

        private void dateTimedespegue_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimeaterrizaje_ValueChanged(object sender, EventArgs e)
        {
            dateTimeaterrizaje.Value.Equals("0/0/0000 00:00");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

