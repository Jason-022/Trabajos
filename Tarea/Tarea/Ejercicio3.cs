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
        private void llenarmatriz(int[] vector)
        {
            int z = 1;
            for (int i = 0; i < 10; i++)
            {
                
                    vector[i] = z;
                //Console.WriteLine(vector[i]);
                    z += 2;
                
            }

            
        }
        string[] alumnos = new string[20];
        List<String> alu = new List<string>();
        int N = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = TxtName.Text;
            for (int i = 0; i < 1; i++)
            {
                alu.Add(TxtName.Text);
                    TxtName.Clear();
                
            }



        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            int[] matriz;
            matriz = new int[10];
            llenarmatriz(matriz);
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(matriz[i]);
            //}
            

            
            //llenarTabla(Data, matriz);

            Data.Columns.Add("Alumnos", "Alumnos");
            Data.Columns.Add("Pupitre", "Pupitre");
            foreach (var item in alu)
            {
                Data.Rows.Add(item);
                
            }
            
            foreach (var item in matriz)
            {
                Data.Rows.Add(Convert.ToString(item));
            } 
                
                

            
                
            
               
            
            
            
                
            

        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }
    }
}
