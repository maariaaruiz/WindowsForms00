namespace WindowsForms00
{
    partial class Form2
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
            this.rbVerde = new System.Windows.Forms.RadioButton();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.rbAzul = new System.Windows.Forms.RadioButton();
            this.gbColores = new System.Windows.Forms.GroupBox();
            this.lblRadios = new System.Windows.Forms.Label();
            this.btnSeleccionado = new System.Windows.Forms.Button();
            this.gbCalificacion = new System.Windows.Forms.GroupBox();
            this.rbSuspenso = new System.Windows.Forms.RadioButton();
            this.rbAprobado = new System.Windows.Forms.RadioButton();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rbAvanzado = new System.Windows.Forms.RadioButton();
            this.rbBasico = new System.Windows.Forms.RadioButton();
            this.cbEsInformatico = new System.Windows.Forms.CheckBox();
            this.gbColores.SuspendLayout();
            this.gbCalificacion.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbVerde
            // 
            this.rbVerde.AutoSize = true;
            this.rbVerde.Location = new System.Drawing.Point(16, 23);
            this.rbVerde.Name = "rbVerde";
            this.rbVerde.Size = new System.Drawing.Size(53, 17);
            this.rbVerde.TabIndex = 0;
            this.rbVerde.Text = "Verde";
            this.rbVerde.UseVisualStyleBackColor = true;
            this.rbVerde.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Location = new System.Drawing.Point(16, 46);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(47, 17);
            this.rbRojo.TabIndex = 1;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            this.rbRojo.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbAzul
            // 
            this.rbAzul.AutoSize = true;
            this.rbAzul.Location = new System.Drawing.Point(16, 69);
            this.rbAzul.Name = "rbAzul";
            this.rbAzul.Size = new System.Drawing.Size(45, 17);
            this.rbAzul.TabIndex = 2;
            this.rbAzul.Text = "Azul";
            this.rbAzul.UseVisualStyleBackColor = true;
            this.rbAzul.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // gbColores
            // 
            this.gbColores.Controls.Add(this.rbVerde);
            this.gbColores.Controls.Add(this.rbAzul);
            this.gbColores.Controls.Add(this.rbRojo);
            this.gbColores.Location = new System.Drawing.Point(28, 28);
            this.gbColores.Name = "gbColores";
            this.gbColores.Size = new System.Drawing.Size(121, 100);
            this.gbColores.TabIndex = 3;
            this.gbColores.TabStop = false;
            this.gbColores.Text = "Colores";
            // 
            // lblRadios
            // 
            this.lblRadios.AutoSize = true;
            this.lblRadios.Location = new System.Drawing.Point(25, 149);
            this.lblRadios.Name = "lblRadios";
            this.lblRadios.Size = new System.Drawing.Size(0, 13);
            this.lblRadios.TabIndex = 4;
            // 
            // btnSeleccionado
            // 
            this.btnSeleccionado.Location = new System.Drawing.Point(28, 182);
            this.btnSeleccionado.Name = "btnSeleccionado";
            this.btnSeleccionado.Size = new System.Drawing.Size(121, 26);
            this.btnSeleccionado.TabIndex = 5;
            this.btnSeleccionado.Text = "Seleccionado";
            this.btnSeleccionado.UseVisualStyleBackColor = true;
            this.btnSeleccionado.Click += new System.EventHandler(this.btnSeleccionado_Click);
            // 
            // gbCalificacion
            // 
            this.gbCalificacion.Controls.Add(this.rbSuspenso);
            this.gbCalificacion.Controls.Add(this.rbAprobado);
            this.gbCalificacion.Location = new System.Drawing.Point(217, 34);
            this.gbCalificacion.Name = "gbCalificacion";
            this.gbCalificacion.Size = new System.Drawing.Size(115, 94);
            this.gbCalificacion.TabIndex = 6;
            this.gbCalificacion.TabStop = false;
            this.gbCalificacion.Text = "Calificacion";
            // 
            // rbSuspenso
            // 
            this.rbSuspenso.AutoSize = true;
            this.rbSuspenso.Location = new System.Drawing.Point(10, 57);
            this.rbSuspenso.Name = "rbSuspenso";
            this.rbSuspenso.Size = new System.Drawing.Size(72, 17);
            this.rbSuspenso.TabIndex = 1;
            this.rbSuspenso.TabStop = true;
            this.rbSuspenso.Text = "Suspenso";
            this.rbSuspenso.UseVisualStyleBackColor = true;
            this.rbSuspenso.CheckedChanged += new System.EventHandler(this.rbCalificacion_CheckedChanged);
            // 
            // rbAprobado
            // 
            this.rbAprobado.AutoSize = true;
            this.rbAprobado.Location = new System.Drawing.Point(10, 34);
            this.rbAprobado.Name = "rbAprobado";
            this.rbAprobado.Size = new System.Drawing.Size(71, 17);
            this.rbAprobado.TabIndex = 0;
            this.rbAprobado.TabStop = true;
            this.rbAprobado.Text = "Aprobado";
            this.rbAprobado.UseVisualStyleBackColor = true;
            this.rbAprobado.CheckedChanged += new System.EventHandler(this.rbCalificacion_CheckedChanged);
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(214, 149);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(0, 13);
            this.lblCalificacion.TabIndex = 7;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtTelefono);
            this.gbDatos.Controls.Add(this.txtEdad);
            this.gbDatos.Controls.Add(this.txtApellidos);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblTelefono);
            this.gbDatos.Controls.Add(this.lblEdad);
            this.gbDatos.Controls.Add(this.lblApellidos);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.rbAvanzado);
            this.gbDatos.Controls.Add(this.rbBasico);
            this.gbDatos.Location = new System.Drawing.Point(34, 234);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(321, 160);
            this.gbDatos.TabIndex = 7;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(193, 134);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(93, 20);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.Visible = false;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(193, 99);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(93, 20);
            this.txtEdad.TabIndex = 8;
            this.txtEdad.Visible = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(193, 66);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(93, 20);
            this.txtApellidos.TabIndex = 7;
            this.txtApellidos.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(193, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(93, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Visible = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(123, 137);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.Visible = false;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(123, 102);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad";
            this.lblEdad.Visible = false;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(123, 69);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos";
            this.lblApellidos.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(123, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // rbAvanzado
            // 
            this.rbAvanzado.AutoSize = true;
            this.rbAvanzado.Location = new System.Drawing.Point(10, 57);
            this.rbAvanzado.Name = "rbAvanzado";
            this.rbAvanzado.Size = new System.Drawing.Size(73, 17);
            this.rbAvanzado.TabIndex = 1;
            this.rbAvanzado.TabStop = true;
            this.rbAvanzado.Text = "Avanzado";
            this.rbAvanzado.UseVisualStyleBackColor = true;
            this.rbAvanzado.CheckedChanged += new System.EventHandler(this.rbDatos_CheckedChanged);
            // 
            // rbBasico
            // 
            this.rbBasico.AutoSize = true;
            this.rbBasico.Location = new System.Drawing.Point(10, 34);
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.Size = new System.Drawing.Size(57, 17);
            this.rbBasico.TabIndex = 0;
            this.rbBasico.TabStop = true;
            this.rbBasico.Text = "Basico";
            this.rbBasico.UseVisualStyleBackColor = true;
            this.rbBasico.CheckedChanged += new System.EventHandler(this.rbDatos_CheckedChanged);
            // 
            // cbEsInformatico
            // 
            this.cbEsInformatico.AutoSize = true;
            this.cbEsInformatico.Location = new System.Drawing.Point(404, 34);
            this.cbEsInformatico.Name = "cbEsInformatico";
            this.cbEsInformatico.Size = new System.Drawing.Size(90, 17);
            this.cbEsInformatico.TabIndex = 8;
            this.cbEsInformatico.Text = "EsInformatico";
            this.cbEsInformatico.UseVisualStyleBackColor = true;
            this.cbEsInformatico.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 406);
            this.Controls.Add(this.cbEsInformatico);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.gbCalificacion);
            this.Controls.Add(this.btnSeleccionado);
            this.Controls.Add(this.lblRadios);
            this.Controls.Add(this.gbColores);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbColores.ResumeLayout(false);
            this.gbColores.PerformLayout();
            this.gbCalificacion.ResumeLayout(false);
            this.gbCalificacion.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbVerde;
        private System.Windows.Forms.RadioButton rbRojo;
        private System.Windows.Forms.RadioButton rbAzul;
        private System.Windows.Forms.GroupBox gbColores;
        private System.Windows.Forms.Label lblRadios;
        private System.Windows.Forms.Button btnSeleccionado;
        private System.Windows.Forms.GroupBox gbCalificacion;
        private System.Windows.Forms.RadioButton rbSuspenso;
        private System.Windows.Forms.RadioButton rbAprobado;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbAvanzado;
        private System.Windows.Forms.RadioButton rbBasico;
        private System.Windows.Forms.CheckBox cbEsInformatico;
    }
}