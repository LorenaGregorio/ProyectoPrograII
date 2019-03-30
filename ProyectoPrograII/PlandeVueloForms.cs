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
                comboBox1.Text,
                combclaseavion.Text,
                combaccion.Text,
                combpista.Text,
                dateTimeaterrizaje.Text,
                Convert.ToBoolean(combescala.Text),
                textBox1.Text,
                combescala.Text,
                combtipoemer.Text,
                Convert.ToInt32( txtlatitud.Text),
                Convert.ToInt32( txtlongitud.Text),
                Convert.ToDouble(label13.Text),
                Convert.ToDouble(label11.Text)
               



            );

            listaplandeVuelos.Add(plandevue1);

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = listaplandeVuelos;

            borrar();

            combpista.Items.Remove(combpista.SelectedItem);


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

                groupBox1.Visible = false;
             

            }
            else if (combaccion.SelectedItem.Equals("Despegar"))
            {
                label3.Visible = true;
                dateTimeaterrizaje.Visible = true;

                label4.Visible = false;

                groupBox1.Visible = true;

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
            //comboBox1.AddItem AvionesForms.txtcodavion.Text//
            //FormDelCombo.Combo2.AddItem txtnombre.Text

            //comboBox1.Text = AvionesForms.;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                double lon, lat, dis, vel, ti;

                lon = Convert.ToDouble(txtlongitud.Text);
                lat = Convert.ToDouble(txtlatitud.Text);


                dis = Math.Sqrt((Math.Pow(lon, 2) + Math.Pow(lat, 2)));

                label13.Text = (Math.Round(dis, 2)).ToString();


                if (combclaseavion.SelectedItem.Equals("Boeing"))
                {
                    vel = 893;
                    ti = dis / vel;

                    label11.Text = (Math.Round(ti, 2)).ToString();
                }

                if (combclaseavion.SelectedItem.Equals("Airbus"))
                {
                    vel = 871;
                    ti = dis / vel;

                    label11.Text = (Math.Round(ti, 2)).ToString();
                }

                if (combclaseavion.SelectedItem.Equals("Bombardier"))
                {
                    vel = 876;
                    ti = dis / vel;

                    label11.Text = (Math.Round(ti, 2)).ToString();
                }

                if (combclaseavion.SelectedItem.Equals("Embraer"))
                {
                    vel = 875;
                    ti = dis / vel;

                    label11.Text = (Math.Round(ti, 2)).ToString();
                }

                if (combclaseavion.SelectedItem.Equals("Saab Bimotor"))
                {
                    vel = 476;
                    ti = dis / vel;

                    label11.Text = (Math.Round(ti, 2)).ToString();
                }

                if (combclaseavion.SelectedItem.Equals("Piper Seneca Bimotor"))
                {
                    vel = 378;
                    ti = dis / vel;

                    label11.Text = (Math.Round(ti, 2)).ToString();
                }

                if (combclaseavion.SelectedItem.Equals("King Air 300"))
                {
                    vel = 580;
                    ti = dis / vel;

                    label11.Text = (Math.Round(ti, 2)).ToString();
                }
            }
        }

        private void combemerg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combemerg.SelectedItem.Equals("SI"))
            {
                combpista.Text = "PISTA EMERGENCIA";
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                combtipoemer.Visible = true;
                txtlatitud.Visible = true;
                txtlongitud.Visible = true;
                button2.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                MessageBox.Show("Seleccione la Pista Emergencia");

            }
            if (combemerg.SelectedItem.Equals("NO"))
            {
                combpista.Text = "";
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                combtipoemer.Visible = false;
                txtlatitud.Visible = false;
                txtlongitud.Visible = false;
                button2.Visible = false;
                label20.Visible = false;
                label21.Visible = false;

            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void combpista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                double larpis, vel, ti;

                //lon = Convert.ToDouble(txtlongitud.Text);
                //lat = Convert.ToDouble(txtlatitud.Text);


                //ti = Math.Sqrt((Math.Pow(larpis, 2) + Math.Pow(vel, 2)));

                //label22.Text = (Math.Round(dis, 2)).ToString();


                if (combclaseavion.SelectedItem.Equals("Boeing"))
                {
                    vel = 893;
                    ti = 200 / vel;

                    label22.Text = (Math.Round(ti, 2)).ToString();
                }

                if (combclaseavion.SelectedItem.Equals("Airbus"))
                {
                    vel = 871;
                    ti = 200 / vel;

                    label22.Text = (Math.Round(ti, 2)).ToString();
                }

                if (combclaseavion.SelectedItem.Equals("Bombardier"))
                {
                    vel = 876;
                    ti = 200 / vel;

                    label22.Text = (Math.Round(ti, 2)).ToString();
                }

                if (combclaseavion.SelectedItem.Equals("Embraer"))
                {
                    vel = 875;
                    ti = 200 / vel;

                    label22.Text = (Math.Round(ti, 2)).ToString();
                }

                if (combclaseavion.SelectedItem.Equals("Saab Bimotor"))
                {
                    vel = 476;
                    ti = 200 / vel;

                    label22.Text = (Math.Round(ti, 2)).ToString();
                }

                if (combclaseavion.SelectedItem.Equals("Piper Seneca Bimotor"))
                {
                    vel = 378;
                    ti = 200 / vel;

                    label22.Text = (Math.Round(ti, 2)).ToString();
                }

                if (combclaseavion.SelectedItem.Equals("King Air 300"))
                {
                    vel = 580;
                    ti = 200 / vel;

                    label22.Text = (Math.Round(ti, 2)).ToString();
                }
            }

        }
    }
}

