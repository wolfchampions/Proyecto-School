using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casa_De_Renta
{

    public partial class FormAddReservacion : Form
    {
        private CasaDeRenta csa;
        public FormAddReservacion(CasaDeRenta csa)
        {
            this.csa = csa;
            InitializeComponent();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxCarnet.Clear();
         
            if (radioButton1.Checked)
            {
                radioButton1.Checked = false;
            }

            if (radioButton2.Checked)
            {
                radioButton2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string carnet = textBoxCarnet.Text;
            bool vip = false;
            DateTime fecha = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker2.Value;
            if (fecha > fecha2)
            {
                MessageBox.Show("Ha introducido una fecha errónea");
                Application.Exit();
            }

            if (radioButton1.Checked)
            {
                vip = true;
            }
            else if (radioButton2.Checked)
            {
                vip = false;
            }

            int dif = fecha2.DayOfYear - fecha.DayOfYear;
            int dinero = 0;
            if (dif == 0)
            {
                dif += 1; 
            }
            if (vip)
            {
                dinero = dif * 2500;
            }
            else
            {
                dinero = dif * 2000;
            }

            if (csa.OcupadaCuarto1(fecha) == false)
            {
                Reservaciones res = new Cuarto1(nombre, carnet, vip, fecha, fecha2, dinero);
                csa.AddReserv(res);
                MessageBox.Show("Se ha realizado una reservación para la habitación 1 por un monto total de "+dinero+ " mn");
                this.Close();
            }
            else if (csa.OcupadaCuarto2(fecha) == false)
            {
                Reservaciones res = new Cuarto2(nombre, carnet, vip, fecha, fecha2, dinero);
                csa.AddReserv(res);
                MessageBox.Show("Se ha realizado una reservación para la habitación 2 por un monto total de " + dinero + " mn");
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay habitaciones disponibles para las fechas seleccionadas");
            }

           
        



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormAddReservacion_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxFalse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker2.Value;
            
            int dif = fecha2.DayOfYear - fecha.DayOfYear;
            MessageBox.Show(dif.ToString());
            
        }
    }
}
