namespace WindowsForms00
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPulsame = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.btnPersona = new System.Windows.Forms.Button();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.btnNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPulsame
            // 
            this.btnPulsame.Location = new System.Drawing.Point(12, 37);
            this.btnPulsame.Name = "btnPulsame";
            this.btnPulsame.Size = new System.Drawing.Size(650, 23);
            this.btnPulsame.TabIndex = 0;
            this.btnPulsame.Text = "Pulsame";
            this.btnPulsame.UseVisualStyleBackColor = true;
            this.btnPulsame.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(14, 93);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(47, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // apellidos
            // 
            this.apellidos.AutoSize = true;
            this.apellidos.Location = new System.Drawing.Point(14, 140);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(52, 13);
            this.apellidos.TabIndex = 3;
            this.apellidos.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(77, 133);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(124, 20);
            this.txtApellidos.TabIndex = 4;
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(17, 228);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(184, 27);
            this.btnPersona.TabIndex = 5;
            this.btnPersona.Text = "Datos de la persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(314, 93);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(36, 13);
            this.lblNota1.TabIndex = 6;
            this.lblNota1.Text = "Nota1";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(314, 184);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(36, 13);
            this.lblNota3.TabIndex = 7;
            this.lblNota3.Text = "Nota3";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(314, 140);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(36, 13);
            this.lblNota2.TabIndex = 8;
            this.lblNota2.Text = "Nota2";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(357, 90);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(46, 20);
            this.txtNota1.TabIndex = 9;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(357, 181);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(45, 20);
            this.txtNota3.TabIndex = 10;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(357, 133);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(45, 20);
            this.txtNota2.TabIndex = 11;
            // 
            // btnNotas
            // 
            this.btnNotas.Location = new System.Drawing.Point(317, 228);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(86, 27);
            this.btnNotas.TabIndex = 12;
            this.btnNotas.Text = "Sumar notas";
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 379);
            this.Controls.Add(this.btnNotas);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.btnPulsame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPulsame;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label apellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Button btnNotas;
    }
}

