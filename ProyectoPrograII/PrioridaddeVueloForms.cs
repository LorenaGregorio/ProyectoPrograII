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
        private AvionesForms avionesForms;

        public PrioridaddeVueloForms(AvionesForms avionesForms)
        {
            InitializeComponent();
            this.avionesForms = avionesForms;
        }


        List<PrioridaddeVuelo> listaprioridaddeVuelos = new List<PrioridaddeVuelo>();


        private void button1_Click(object sender, EventArgs e)
                  
        {
            //se creo objeto de la clase prioridad de vuelo
            PrioridaddeVuelo prioridaddeVuelo1 = new PrioridaddeVuelo
            (
                combtipoemer.Text,
                Convert.ToDouble (txtlatitud.Text),
                Convert.ToDouble (txtlongitud.Text),
                Convert.ToDouble(label7.Text),
                Convert.ToDouble(label9.Text)
                
            );

            listaprioridaddeVuelos.Add(prioridaddeVuelo1);

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = listaprioridaddeVuelos;

            borrar();

            

        }

       

        public void borrar()
        {
            txtlatitud.Clear();
            txtlongitud.Clear();
           
        }


        

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void PrioridaddeVueloForms_Load(object sender, EventArgs e)
        {

            
        }
    }
}
