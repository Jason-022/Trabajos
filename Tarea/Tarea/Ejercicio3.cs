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
        
        private void asignacion(int numero)
        {
            int alumno = numero;
            int x = 1;
            int[] lista = new int[alumno];
            int[] N_impar = new int[20];
            
                registro.Columns.Add("Alumnos", "Alumnos");
                registro.Columns.Add("Pupitre", "Pupitre");
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

                        N_impar[i] = z;
                        registro.Rows.Add(lista[i], z);
                        z += 2;
                        break;

                    }
                }
        }
        
        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void BtnAtras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(TxtCantA.Text);
            if (cantidad <= 10)
            {
                asignacion(cantidad);
                TxtCantA.Clear();
                TxtCantA.Enabled = false;
            }
            else
            {
                TxtCantA.Clear();
                MessageBox.Show("La cantidad maxima es de 10 alumnos por salón, porfavor ingrese un numero que este en el rango establecido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
