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
                dateTimellegada.Text
                //Convert.ToBoolean( combescala.Text),
                //Convert.ToInt16 (txtpasajetripu.Text),
                //combtipoemer.Text,
                //Convert.ToDouble(txtlatitud.Text),
                //Convert.ToDouble(txtlongitud.Text),
                //Convert.ToDouble(label13.Text),
                //Convert.ToDouble(label11.Text)                

            );

            listaaviones.Add(aviones1);

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = listaaviones;
            string cod = txtcodavion.Text;

           
          

            borrar();
        }
        //Aqui inicio el metodo borrar
        public void borrar()
        {
            txtcodavion.Clear();
            txtlugarsalida.Clear();
            txtlugardestino.Clear();
            txtpasajetripu.Clear();
            //txtlatitud.Clear();
            //txtlongitud.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combtipoavion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combclaseavion_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void AvionesForms_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //double lon,lat,dis,vel,ti;

            //lon = Convert.ToDouble(txtlongitud.Text);
            //lat = Convert.ToDouble(txtlatitud.Text);


            //dis = Math.Sqrt((Math.Pow(lon, 2) + Math.Pow(lat, 2)));

            //label13.Text = ( Math.Round(dis,2)).ToString();
            

            //if (combclaseavion.SelectedItem.Equals("Boeing"))
            //{
            //    vel = 893;
            //    ti = dis / vel;

            //    label11.Text= (Math.Round(ti,2)).ToString();
            //}

            //if (combclaseavion.SelectedItem.Equals("Airbus"))
            //{
            //    vel = 871;
            //    ti = dis / vel;

            //    label11.Text = (Math.Round(ti, 2)).ToString();
            //}

            //if (combclaseavion.SelectedItem.Equals("Bombardier"))
            //{
            //    vel = 876;
            //    ti = dis / vel;

            //    label11.Text = (Math.Round(ti, 2)).ToString();
            //}

            //if (combclaseavion.SelectedItem.Equals("Embraer"))
            //{
            //    vel = 875;
            //    ti = dis / vel;

            //    label11.Text = (Math.Round(ti, 2)).ToString();
            //}

            //if (combclaseavion.SelectedItem.Equals("Saab Bimotor"))
            //{
            //    vel = 476;
            //    ti = dis / vel;

            //    label11.Text = (Math.Round(ti, 2)).ToString();
            //}

            //if (combclaseavion.SelectedItem.Equals("Piper Seneca Bimotor"))
            //{
            //    vel = 378;
            //    ti = dis / vel;

            //    label11.Text = (Math.Round(ti, 2)).ToString();
            //}

            //if (combclaseavion.SelectedItem.Equals("King Air 300"))
            //{
            //    vel = 580;
            //    ti = dis / vel;

            //    label11.Text = (Math.Round(ti, 2)).ToString();
            //}

           





        }
    }
    
}
