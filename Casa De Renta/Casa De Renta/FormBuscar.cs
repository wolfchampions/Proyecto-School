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
    public partial class FormBuscar : Form
    {
        

        private CasaDeRenta csa;
        private List<Reservaciones> reser;
       

        public FormBuscar(CasaDeRenta csa)
        {
            this.csa = csa;
            InitializeComponent();
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {

        }
        
        public void Actualizar()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }
        public void Listar()
        {
            foreach (Reservaciones item in csa.Reservaciones)
            {
                listBox1.Items.Add(item.Nombre);
                listBox2.Items.Add(item.Carnet);
                listBox3.Items.Add(Convert.ToString(item.Fecha.Day + "/" + item.Fecha.Month + "/" + item.Fecha.Year));
                listBox4.Items.Add(Convert.ToString(item.Fecha2.Day + "/" + item.Fecha2.Month + "/" + item.Fecha2.Year));
                listBox5.Items.Add(Convert.ToString(item.Dinero));
                if (item is Cuarto1)
                {
                    listBox6.Items.Add("1");
                }

                else
                {
                    listBox6.Items.Add("2");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Actualizar();

            if (radioButton1.Checked)
            {
                string nombre = textBox1.Text;
                reser = csa.BuscarPorNombre(nombre);
                foreach (Reservaciones n in reser)
                {

                    listBox1.Items.Add(n.Nombre);
                    listBox2.Items.Add(n.Carnet);
                    listBox3.Items.Add(Convert.ToString(n.Fecha.Day + "/" + n.Fecha.Month + "/" + n.Fecha.Year));
                    listBox4.Items.Add(Convert.ToString(n.Fecha2.Day + "/" + n.Fecha2.Month + "/" + n.Fecha2.Year));
                    listBox5.Items.Add(Convert.ToString(n.Dinero));
                    if (n is Cuarto1)
                    {
                        listBox6.Items.Add("1");
                    }

                    else
                    {
                        listBox6.Items.Add("2");
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                string carnet = textBox1.Text;
                reser = csa.BuscarPorCi(carnet);
                foreach (Reservaciones n in reser)
                {

                    listBox1.Items.Add(n.Nombre);
                    listBox2.Items.Add(n.Carnet);
                    listBox3.Items.Add(Convert.ToString(n.Fecha.Day + "/" + n.Fecha.Month + "/" + n.Fecha.Year));
                    listBox4.Items.Add(Convert.ToString(n.Fecha2.Day + "/" + n.Fecha2.Month + "/" + n.Fecha2.Year));
                    listBox5.Items.Add(Convert.ToString(n.Dinero));
                    if (n is Cuarto1)
                    {
                        listBox6.Items.Add("1");
                    }

                    else
                    {
                        listBox6.Items.Add("2");
                    }
                }
            }
            else
            {
                Listar();
            }
        }
    }
}
