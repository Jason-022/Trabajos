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
        //Metodos
        private void agregar(List<double> lista, double nota)
        {
            if (lista.Count <= 10)
            {
                lista.Add(nota);
            }
            else 
            {
                MessageBox.Show("Solo puedes ingresar un total de 10 notas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mostrar(ListBox lista, List<double> nota)
        {
            if(lista.Items.Count <= 10)
            {
                foreach (var i in nota)
                {
                    lista.Items.Add(i);
                }
                
            }
            else
            {
                MessageBox.Show("Solo puedes ingresar un total de 10 notas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void estado(List<double> nota)
        {
            double Total = 0;
            double promedio = 0;

            foreach (int i in nota)
            {
                Total = Total + i;
            }
            promedio = Total / nota.Count;

            Prom.Text = Convert.ToString(promedio);

            if(promedio >= 6)
            {
                txtEstado.Text = "Aprobado";
            }
            else
            {
                txtEstado.Text = "Reprobado";
            }
        }
        private void eliminar(List<double> nota, double delete)
        {
            nota.RemoveAt(Convert.ToInt32(indice(delete)));
            List.Items.Clear();
            if (nota.Count <= 10)
            {
                TxtNota.Enabled = true;
            }
        }
        private void reemplazar(List<double> nota, double old, double NEW)
        {
            double ind = Grades.IndexOf(Convert.ToDouble(old));
            nota.RemoveAt(Convert.ToInt32(ind));
            nota.Insert(Convert.ToInt32(ind), NEW);
            List.Items.Clear();
        }
        public double indice(double y)
        {
            double IndiceNoO = Grades.IndexOf(y);
            return IndiceNoO;
        }
        //Fin de los metodos
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
        
        private void BtnIngresarN_Click(object sender, EventArgs e)
        {
            double nota = Convert.ToDouble(TxtNota.Text);
            agregar(Grades, nota );
            TxtNota.Clear();

            if (Grades.Count == 10)
            {
                TxtNota.Enabled = false;
            }
            

        }


        private void button2_Click(object sender, EventArgs e)
        {
            double NoN = Convert.ToDouble(TxtNotaNew.Text);
            double NoO = Convert.ToDouble(TxtNotaOld.Text);
            indice(NoO);
            TxtNotaNew.Clear();
            TxtNotaOld.Clear();
            reemplazar(Grades, NoO, NoN);
            
            
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            double NoE = Convert.ToDouble(TxtElimar.Text);
            eliminar(Grades, NoE);
            TxtElimar.Clear();


        }

        private void BtnProm_Click(object sender, EventArgs e)
        {
            estado(Grades);
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            mostrar(List, Grades);
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {

        }
    }
}
