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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNota
            // 
            this.TxtNota.Location = new System.Drawing.Point(497, 23);
            this.TxtNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNota.Name = "TxtNota";
            this.TxtNota.Size = new System.Drawing.Size(156, 22);
            this.TxtNota.TabIndex = 1;
            // 
            // BtnIngresarN
            // 
            this.BtnIngresarN.Location = new System.Drawing.Point(240, 16);
            this.BtnIngresarN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label1.Location = new System.Drawing.Point(15, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Promedio de notas: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Modificar Nota";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtNotaNew
            // 
            this.TxtNotaNew.Location = new System.Drawing.Point(240, 75);
            this.TxtNotaNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNotaNew.Name = "TxtNotaNew";
            this.TxtNotaNew.Size = new System.Drawing.Size(156, 22);
            this.TxtNotaNew.TabIndex = 6;
            // 
            // TxtElimar
            // 
            this.TxtElimar.Location = new System.Drawing.Point(497, 117);
            this.TxtElimar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtElimar.Name = "TxtElimar";
            this.TxtElimar.Size = new System.Drawing.Size(156, 22);
            this.TxtElimar.TabIndex = 7;
            // 
            // TxtNotaOld
            // 
            this.TxtNotaOld.Location = new System.Drawing.Point(497, 70);
            this.TxtNotaOld.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNotaOld.Name = "TxtNotaOld";
            this.TxtNotaOld.Size = new System.Drawing.Size(156, 22);
            this.TxtNotaOld.TabIndex = 8;
            // 
            // Prom
            // 
            this.Prom.AutoSize = true;
            this.Prom.Location = new System.Drawing.Point(153, 208);
            this.Prom.Name = "Prom";
            this.Prom.Size = new System.Drawing.Size(23, 17);
            this.Prom.TabIndex = 9;
            this.Prom.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nueva nota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nota antigua:";
            // 
            // BtnProm
            // 
            this.BtnProm.Location = new System.Drawing.Point(20, 302);
            this.BtnProm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.List.Location = new System.Drawing.Point(369, 208);
            this.List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(120, 180);
            this.List.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Eliminar Nota";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(497, 357);
            this.BtnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(119, 32);
            this.BtnShow.TabIndex = 14;
            this.BtnShow.Text = "Mostrar Datos";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingrese nota:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ingrese nota ha eliminar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Estado academico:";
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.Location = new System.Drawing.Point(157, 245);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(23, 17);
            this.txtEstado.TabIndex = 18;
            this.txtEstado.Text = "---";
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtEstado;
    }
}