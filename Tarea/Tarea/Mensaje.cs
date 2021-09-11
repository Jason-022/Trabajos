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
    public partial class Mensaje : Form
    {
        public Mensaje()
        {
            InitializeComponent();
        }
        
        private void Mensaje_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Hide();
            

        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MensajeNombre.Name = TxtN.Text;            
            //Form1 form = new Form1();
            //form.Show();
        }
    }
}
