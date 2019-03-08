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
    public partial class AvionesForms : Form
    {
        private Form1 form1;

        public AvionesForms(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        //Se crea Lista de Aviones

        List<Aviones> listaaviones = new List<Aviones>();

        private void button1_Click(object sender, EventArgs e)
        {
            //se creo el objeto de la clase aviones

            Aviones aviones1 = new Aviones
            (
                txtcodavion.Text,
                combtipoavion.Text,
                combclaseavion.Text,
                txtlugarsalida.Text,
                txtlugardestino.Text,
                dateTimesalida.Text,
                dateTimellegada.Text,
                combescala.Text,
                Convert.ToInt16 (txtpasajetripu.Text)
            );

            listaaviones.Add(aviones1);

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = listaaviones;

            borrar();
        }
        //Aqui inicio el metodo borrar
        public void borrar()
        {
            txtcodavion.Clear();
            txtlugarsalida.Clear();
            txtlugardestino.Clear();
            txtpasajetripu.Clear();

        }

    }
    
}
