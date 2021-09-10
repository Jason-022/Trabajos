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
            public double ID;
            public string NamePro;
            public double PU;
            public double C;
            public double PV;



        }
        List<Ventas> Total = new List<Ventas>();
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
             Ventas VentasTotales = new Ventas();
            VentasTotales.ID = Convert.ToDouble(TxtID.Text);
            VentasTotales.NamePro = TxtNombreP.Text;
            VentasTotales.PU = Convert.ToDouble(TxtPrecioU.Text);
            VentasTotales.C = Convert.ToDouble(TxtCantidad.Text);
            VentasTotales.PV = Convert.ToDouble(TxtPrecioV.Text);

            Total.Add(VentasTotales);        
            TxtCantidad.Clear();
            TxtID.Clear();
            TxtNombreP.Clear();
            TxtPrecioU.Clear();
            TxtPrecioV.Clear();

           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.Columns.Clear();
            Data.Rows.Clear();
            
            Data.Columns.Add("ID", "ID");
            Data.Columns.Add("Producto", "Producto");
            Data.Columns.Add("Precio", "Precio");
            Data.Columns.Add("Cantidad", "Cantidad");
            Data.Columns.Add("Total", "Total"); 
            
                foreach (var item in Total)
                {
                Data.Rows.Add(item.ID, item.NamePro,"$" + item.PU,item.C,"$"+ item.PV);
                }
            
            

            
                
                }
        public static string id;
        public static string nombreP;
        public static string Cantidad;
        public static string preciU;
        public static string preciV;

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void BtnShowPRo_Click(object sender, EventArgs e)
        {
            TxtPro.Text = nombreP;
            TxtP.Text = preciV;
            
        }

        private void Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Data.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            nombreP = Data.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
            preciU = Data.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
            Cantidad = Data.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
            preciV = Data.Rows[e.RowIndex].Cells["Total"].Value.ToString();

        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }
    }
}
