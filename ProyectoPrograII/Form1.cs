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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aerolineasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aerolineasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (AerolineasForms aero = new AerolineasForms(this))
            {
                aero.ShowDialog();
            }
                

                   

        }

        private void avionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AvionesForms avio = new AvionesForms(this))
            {
                avio.ShowDialog();
            }
        }

        private void pistasDeAterrizajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PlandeVueloForms plan = new PlandeVueloForms(this))
            {
                plan.ShowDialog();
            }
        }

        private void prioridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrioridaddeVueloForms prioridad = new PrioridaddeVueloForms(this))
            {
                prioridad.ShowDialog();
            }
        }
    }
}
