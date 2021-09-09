using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
        List<double> notas = new List<double>();
        private void BtnIngresarN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                notas.Add( Convert.ToDouble(TxtNota.Text));
                TxtNota.Clear();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double notaN = Convert.ToDouble(TxtNotaNew.Text);
            double notaO = Convert.ToDouble(TxtNotaOld.Text);

            
            notas.RemoveAt(Convert.ToInt32(indice(notaO)));
            notas.Insert(Convert.ToInt32(indice(notaO)), notaN);
            
        }
        public double indice( double y)
        {
            double ind = notas.IndexOf(y);
            return ind;
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double notaE = Convert.ToDouble(TxtElimar.Text);

            notas.RemoveAt(Convert.ToInt32(indice(notaE)));
        }

        private void BtnProm_Click(object sender, EventArgs e)
        {
            double total = 0;
            double prom = 0;

            foreach (var item in notas)
            {
                total = total + item;
            }
            prom = total / notas.Count;

            Prom.Text = Convert.ToString(prom);

                }
    }
}
