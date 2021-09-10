namespace Tarea
{
    partial class Ejercicio4
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtNota = new System.Windows.Forms.TextBox();
            this.BtnIngresarN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtNotaNew = new System.Windows.Forms.TextBox();
            this.TxtElimar = new System.Windows.Forms.TextBox();
            this.TxtNotaOld = new System.Windows.Forms.TextBox();
            this.Prom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnProm = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Retroceder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNota
            // 
            this.TxtNota.Location = new System.Drawing.Point(82, 57);
            this.TxtNota.Name = "TxtNota";
            this.TxtNota.Size = new System.Drawing.Size(156, 22);
            this.TxtNota.TabIndex = 1;
            // 
            // BtnIngresarN
            // 
            this.BtnIngresarN.Location = new System.Drawing.Point(38, 22);
            this.BtnIngresarN.Name = "BtnIngresarN";
            this.BtnIngresarN.Size = new System.Drawing.Size(119, 32);
            this.BtnIngresarN.TabIndex = 2;
            this.BtnIngresarN.Text = "Ingresar nota";
            this.BtnIngresarN.UseVisualStyleBackColor = true;
            this.BtnIngresarN.Click += new System.EventHandler(this.BtnIngresarN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Promedio de sus notas: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Modificar Nota";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtNotaNew
            // 
            this.TxtNotaNew.Location = new System.Drawing.Point(178, 113);
            this.TxtNotaNew.Name = "TxtNotaNew";
            this.TxtNotaNew.Size = new System.Drawing.Size(156, 22);
            this.TxtNotaNew.TabIndex = 6;
            // 
            // TxtElimar
            // 
            this.TxtElimar.Location = new System.Drawing.Point(82, 185);
            this.TxtElimar.Name = "TxtElimar";
            this.TxtElimar.Size = new System.Drawing.Size(156, 22);
            this.TxtElimar.TabIndex = 7;
            // 
            // TxtNotaOld
            // 
            this.TxtNotaOld.Location = new System.Drawing.Point(445, 113);
            this.TxtNotaOld.Name = "TxtNotaOld";
            this.TxtNotaOld.Size = new System.Drawing.Size(156, 22);
            this.TxtNotaOld.TabIndex = 8;
            // 
            // Prom
            // 
            this.Prom.AutoSize = true;
            this.Prom.Location = new System.Drawing.Point(606, 57);
            this.Prom.Name = "Prom";
            this.Prom.Size = new System.Drawing.Size(41, 17);
            this.Prom.TabIndex = 9;
            this.Prom.Text = "Prom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nueva nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nota antigua";
            // 
            // BtnProm
            // 
            this.BtnProm.Location = new System.Drawing.Point(482, 12);
            this.BtnProm.Name = "BtnProm";
            this.BtnProm.Size = new System.Drawing.Size(119, 32);
            this.BtnProm.TabIndex = 12;
            this.BtnProm.Text = "Promedio";
            this.BtnProm.UseVisualStyleBackColor = true;
            this.BtnProm.Click += new System.EventHandler(this.BtnProm_Click);
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 16;
            this.List.Location = new System.Drawing.Point(284, 210);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(120, 180);
            this.List.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Eliminar Nota";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(284, 396);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(119, 32);
            this.BtnShow.TabIndex = 14;
            this.BtnShow.Text = "Mostrar Datos";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.List);
            this.Controls.Add(this.BtnProm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Prom);
            this.Controls.Add(this.TxtNotaOld);
            this.Controls.Add(this.TxtElimar);
            this.Controls.Add(this.TxtNotaNew);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIngresarN);
            this.Controls.Add(this.TxtNota);
            this.Controls.Add(this.button1);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.Load += new System.EventHandler(this.Ejercicio4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtNota;
        private System.Windows.Forms.Button BtnIngresarN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtNotaNew;
        private System.Windows.Forms.TextBox TxtElimar;
        private System.Windows.Forms.TextBox TxtNotaOld;
        private System.Windows.Forms.Label Prom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnProm;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnShow;
    }
}