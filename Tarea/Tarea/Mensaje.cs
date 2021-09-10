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
        String name;
        private void Mensaje_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            name = TxtN.Text;
            this.Hide();
            Form1 form = new Form1(name);
            form.Show();
        }
    }
}
