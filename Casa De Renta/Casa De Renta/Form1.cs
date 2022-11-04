using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Casa_De_Renta
{
    public partial class Form1 : Form
    {
        private CasaDeRenta casaRenta;
        public Form1()
        {
            casaRenta = new CasaDeRenta();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form agregar = new FormAddReservacion(casaRenta);
            agregar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBuscar buscar = new FormBuscar(casaRenta);
            
            buscar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.AddExtension = true;
            s.DefaultExt = "inn";
            s.ShowDialog();
            if (s.FileName != null && s.FileName != "")
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(s.FileName, FileMode.OpenOrCreate);
                bf.Serialize(fs, casaRenta);
                //pathToSave = s.FileName;
                fs.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.AddExtension = true;
            op.DefaultExt = "inn";
            op.ShowDialog();
            if (op.FileName != null && op.FileName != "")
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(op.FileName, FileMode.Open);
                casaRenta = (CasaDeRenta)bf.Deserialize(fs);
                //es.componentes = componentes;
                //es.premisas = premisas;
                //pathToSave = op.FileName;
                fs.Close();
            }
        }
    }
}
