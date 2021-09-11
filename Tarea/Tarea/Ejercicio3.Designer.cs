namespace Tarea
{
    partial class Ejercicio3
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCantA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.registro = new System.Windows.Forms.DataGridView();
            this.BtnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registro)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese la cantidad de alumnos";
            // 
            // TxtCantA
            // 
            this.TxtCantA.Location = new System.Drawing.Point(163, 38);
            this.TxtCantA.Name = "TxtCantA";
            this.TxtCantA.Size = new System.Drawing.Size(100, 20);
            this.TxtCantA.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // registro
            // 
            this.registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registro.Location = new System.Drawing.Point(92, 104);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(264, 150);
            this.registro.TabIndex = 3;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(33, 280);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(75, 23);
            this.BtnAtras.TabIndex = 4;
            this.BtnAtras.Text = "Regresar";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click_1);
            // 
            // Ejercicio3
            // 
            this.ClientSize = new System.Drawing.Size(458, 315);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtCantA);
            this.Controls.Add(this.label2);
            this.Name = "Ejercicio3";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCantA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView registro;
        private System.Windows.Forms.Button BtnAtras;
    }
}