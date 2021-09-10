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
        List<double> Grades = new List<double>();
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
        
        private void BtnIngresarN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                Grades.Add( Convert.ToDouble(TxtNota.Text));
                TxtNota.Clear();

            }

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            double NoN = Convert.ToDouble(TxtNotaNew.Text);
            double NoO = Convert.ToDouble(TxtNotaOld.Text);
            indice(NoO);
            double ind = Grades.IndexOf(Convert.ToDouble(NoO));
            Grades.RemoveAt(Convert.ToInt32(ind));
            Grades.Insert(Convert.ToInt32(ind), NoN);
            
            
        }
        public double indice(double y)
        {
            double IndiceNoO = Grades.IndexOf(y);
            return IndiceNoO;
        }


        private void Ejercicio4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double NoE = Convert.ToDouble(TxtElimar.Text);

            Grades.RemoveAt(Convert.ToInt32(indice(NoE)));
        }

        private void BtnProm_Click(object sender, EventArgs e)
        {
            double Total = 0;
            double promedio = 0;

            foreach (int i in Grades)
            {
                Total = Total + i;
            }
            promedio = Total / Grades.Count;

            Prom.Text = Convert.ToString(promedio);

                }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            
            foreach (var i in Grades)
            {
                List.Items.Add(i);
            }
            
        }
    }
}
