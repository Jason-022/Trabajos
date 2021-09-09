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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
        struct Ventas
        {
            public string NombrePro;
            public double PrecioU;
            public double Cantidad;
            public double PrecioV;



        }
        List<Ventas> Total = new List<Ventas>();
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
             Ventas VAll = new Ventas();

            VAll.NombrePro = TxtNombreP.Text;
            VAll.PrecioU = Convert.ToDouble(TxtPrecioU.Text);
            VAll.Cantidad = Convert.ToDouble(TxtCantidad.Text);
            VAll.PrecioV = Convert.ToDouble(TxtPrecioV.Text);

            Total.Add(VAll);

            string pro = "";
            double total = 0;
            

            pro = TxtNombreP.Text;
            total = Convert.ToDouble(TxtPrecioV.Text);

            lb1.Text = pro;
            lb2.Text = Convert.ToString(total);

           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.Columns.Clear();
            Data.Rows.Clear();
            
            Data.Columns.Add("Producto", "Producto");
            Data.Columns.Add("Precio", "Precio");
            Data.Columns.Add("Cantidad", "Cantidad");
            Data.Columns.Add("Total", "Total");            
            foreach (var item in Total)
            {
                Data.Rows[0].Cells[0].Value = item.NombrePro;
                Data.Rows[0].Cells[1].Value = item.PrecioU;
                Data.Rows[0].Cells[2].Value = item.Cantidad;
                Data.Rows[0].Cells[3].Value = item.PrecioV;
                //Data.Rows.Add(item.NombrePro);
                //Data.Rows.Add(item.PrecioU);
                //Data.Rows.Add(item.Cantidad);
                //Data.Rows.Add(item.PrecioV);
            }

            
                
                }
    }
}
