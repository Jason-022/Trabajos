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
    public partial class Ejercicio3 : Form
    {
        
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
        //private void llenarmatriz(int[] vector)
        //{
        //    int z = 1;
        //    for (int i = 0; i < nombre; i++)
        //    {

        //            vector[i] = z;
        //            z += 2;

        //    }


        //}


        
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1;
            int[] vector = new int[20];
            int nombre = Convert.ToInt32(TxtNumA.Text);
            int[] lista = new int[nombre];
            if (nombre <= 10)
            {
                Data.Columns.Add("Alumnos", "Alumnos");
                Data.Columns.Add("Pupitre", "Pupitre");
                for (int i = 0; i < nombre; i++)
                {
                    lista[i] = x;
                    x++;
                }
                int z = 1;
                for (int i = 0; i < nombre; i++)
                {
                    for (int j = 0; j < nombre; j++)
                    {

                        vector[i] = z;
                        Data.Rows.Add(lista[i], z);
                        z += 2;
                        break;

                    }
                }
                TxtNumA.Clear();
            }
            else
            {
                MessageBox.Show("La cantidad de alumnos no debe ser mayor a 10", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        
    }
}
