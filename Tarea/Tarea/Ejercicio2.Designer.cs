﻿namespace Tarea
{
    partial class Ejercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtNombreP = new System.Windows.Forms.TextBox();
            this.TxtPrecioU = new System.Windows.Forms.TextBox();
            this.TxtPrecioV = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ListPro = new System.Windows.Forms.ListBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnShowPRo = new System.Windows.Forms.Button();
            this.TxtP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(21, 400);
            this.BtnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(143, 23);
            this.BtnAtras.TabIndex = 0;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(723, 46);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(125, 34);
            this.BtnIngresar.TabIndex = 1;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtNombreP
            // 
            this.TxtNombreP.Location = new System.Drawing.Point(151, 33);
            this.TxtNombreP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombreP.Name = "TxtNombreP";
            this.TxtNombreP.Size = new System.Drawing.Size(100, 22);
            this.TxtNombreP.TabIndex = 2;
            // 
            // TxtPrecioU
            // 
            this.TxtPrecioU.Location = new System.Drawing.Point(151, 84);
            this.TxtPrecioU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPrecioU.Name = "TxtPrecioU";
            this.TxtPrecioU.Size = new System.Drawing.Size(100, 22);
            this.TxtPrecioU.TabIndex = 3;
            // 
            // TxtPrecioV
            // 
            this.TxtPrecioV.Location = new System.Drawing.Point(603, 87);
            this.TxtPrecioV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPrecioV.Name = "TxtPrecioV";
            this.TxtPrecioV.Size = new System.Drawing.Size(100, 22);
            this.TxtPrecioV.TabIndex = 4;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(367, 87);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 22);
            this.TxtCantidad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de producto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio unitario: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio de venta: ";
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(469, 231);
            this.Data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Data.Name = "Data";
            this.Data.RowTemplate.Height = 24;
            this.Data.Size = new System.Drawing.Size(365, 192);
            this.Data.TabIndex = 10;
            this.Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellClick);
            this.Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Mostrar ventas del día: ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListPro
            // 
            this.ListPro.FormattingEnabled = true;
            this.ListPro.ItemHeight = 16;
            this.ListPro.Location = new System.Drawing.Point(770, 131);
            this.ListPro.Name = "ListPro";
            this.ListPro.Size = new System.Drawing.Size(78, 36);
            this.ListPro.TabIndex = 16;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(458, 33);
            this.TxtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 22);
            this.TxtID.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID del producto (tres digitos): ";
            // 
            // BtnShowPRo
            // 
            this.BtnShowPRo.Location = new System.Drawing.Point(120, 255);
            this.BtnShowPRo.Name = "BtnShowPRo";
            this.BtnShowPRo.Size = new System.Drawing.Size(173, 23);
            this.BtnShowPRo.TabIndex = 19;
            this.BtnShowPRo.Text = "Mostrar producto";
            this.BtnShowPRo.UseVisualStyleBackColor = true;
            this.BtnShowPRo.Click += new System.EventHandler(this.BtnShowPRo_Click);
            // 
            // TxtP
            // 
            this.TxtP.Location = new System.Drawing.Point(63, 308);
            this.TxtP.Name = "TxtP";
            this.TxtP.Size = new System.Drawing.Size(100, 22);
            this.TxtP.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Precio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Producto: ";
            // 
            // TxtPro
            // 
            this.TxtPro.Location = new System.Drawing.Point(246, 308);
            this.TxtPro.Name = "TxtPro";
            this.TxtPro.Size = new System.Drawing.Size(100, 22);
            this.TxtPro.TabIndex = 24;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.TxtPro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtP);
            this.Controls.Add(this.BtnShowPRo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.ListPro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtPrecioV);
            this.Controls.Add(this.TxtPrecioU);
            this.Controls.Add(this.TxtNombreP);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.BtnAtras);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox TxtNombreP;
        private System.Windows.Forms.TextBox TxtPrecioU;
        private System.Windows.Forms.TextBox TxtPrecioV;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListPro;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnShowPRo;
        private System.Windows.Forms.TextBox TxtP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPro;
    }
}