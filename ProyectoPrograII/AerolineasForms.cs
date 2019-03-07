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
    public partial class AerolineasForms : Form
    {

     
        private Form1 form1;

        public AerolineasForms(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }


        //Se creo lista de Aerolineas
        List<Aerolinea> listaaerolinea = new List<Aerolinea>();

        private void button1_Click(object sender, EventArgs e)
        {
            //Se creo el objeto de la clase Aerolinea
            Aerolinea aerolinea1 = new Aerolinea
            (
                combnombreaerolinea.Text,
                Convert.ToInt32( txtnumeroaviones.Text)
                
            );
            //Finaliza el objeto de la clase aerolinea

            //Se crea funcion para extraer el valor de la lista
            //y mostrarlo en el data gridview
            listaaerolinea.Add(aerolinea1);

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = listaaerolinea;

            borrar();
        }
        //Aqui inicio el metodo borrar
        public void borrar()
        {
            txtnumeroaviones.Clear();
        }

    }
}
