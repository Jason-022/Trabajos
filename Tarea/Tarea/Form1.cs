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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public string n;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Hide();
            if (MensajeNombre.Name == " " )
            {
                
                
                Mensaje men = new Mensaje();
                men.Show();
                
            }
            else if(MensajeNombre.Name != "" )
            {
                
                Mensaje men = new Mensaje();
                men.Hide();
                Form1 form = new Form1();
                

            }
            


        }       
        
        

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio2 eje2 = new Ejercicio2();
            eje2.Show();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio3 eje3 = new Ejercicio3();
            eje3.Show();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio4 eje4 = new Ejercicio4();
            eje4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            lbName.Text =  MensajeNombre.Name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }
    }
}
