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
        private void asignacion(int numero)
        {
            int alumno = numero;
            int x = 1;
            int[] lista = new int[alumno];
            int[] N_impar = new int[20];
            
                Data.Columns.Add("Alumnos", "Alumnos");
                Data.Columns.Add("Pupitre", "Pupitre");
                for (int i = 0; i < alumno; i++)
                {
                    lista[i] = x;
                    x++;
                }
                int z = 1;
                for (int i = 0; i < alumno; i++)
                {
                    for (int j = 0; j < alumno; j++)
                    {

                        N_impar[j] = z;
                        Data.Rows.Add(lista[i], z);
                        z += 2;
                        break;

                    }
                }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            int cantidad = Convert.ToInt32(TxtCantA.Text);
            if (cantidad <= 10)
            {
                asignacion(cantidad);
                TxtCantA.Clear();
            }
            else
            {
                MessageBox.Show("La cantidad maxima es de 10 alumnos por salón, porfavor ingrese numero que este en el rango establecido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        
    }
}
