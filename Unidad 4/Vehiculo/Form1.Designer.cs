namespace Vehiculo
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
            this.lblcombustible = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblllantas = new System.Windows.Forms.Label();
            this.lblpuertas = new System.Windows.Forms.Label();
            this.lblventanas = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblalas = new System.Windows.Forms.Label();
            this.lblturbinas = new System.Windows.Forms.Label();
            this.lblhelices = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnparar = new System.Windows.Forms.Button();
            this.btnarrancar = new System.Windows.Forms.Button();
            this.txtSonido = new System.Windows.Forms.TextBox();
            this.btnGuaradar = new System.Windows.Forms.Button();
            this.btnVolar = new System.Windows.Forms.Button();
            this.txtsonidoparar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcombustible
            // 
            this.lblcombustible.AutoSize = true;
            this.lblcombustible.Location = new System.Drawing.Point(3, 26);
            this.lblcombustible.Name = "lblcombustible";
            this.lblcombustible.Size = new System.Drawing.Size(105, 13);
            this.lblcombustible.TabIndex = 0;
            this.lblcombustible.Text = "Tipo de combustible:";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(3, 58);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(34, 13);
            this.lblcolor.TabIndex = 1;
            this.lblcolor.Text = "Color:";
            // 
            // lblllantas
            // 
            this.lblllantas.AutoSize = true;
            this.lblllantas.Location = new System.Drawing.Point(3, 89);
            this.lblllantas.Name = "lblllantas";
            this.lblllantas.Size = new System.Drawing.Size(95, 13);
            this.lblllantas.TabIndex = 2;
            this.lblllantas.Text = "Numero de llantas:";
            // 
            // lblpuertas
            // 
            this.lblpuertas.AutoSize = true;
            this.lblpuertas.Location = new System.Drawing.Point(3, 119);
            this.lblpuertas.Name = "lblpuertas";
            this.lblpuertas.Size = new System.Drawing.Size(100, 13);
            this.lblpuertas.TabIndex = 3;
            this.lblpuertas.Text = "Numero de puertas:";
            // 
            // lblventanas
            // 
            this.lblventanas.AutoSize = true;
            this.lblventanas.Location = new System.Drawing.Point(3, 149);
            this.lblventanas.Name = "lblventanas";
            this.lblventanas.Size = new System.Drawing.Size(109, 13);
            this.lblventanas.TabIndex = 4;
            this.lblventanas.Text = "Numero de ventanas:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(143, 26);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 5;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(143, 55);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 6;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(143, 86);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 7;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(143, 119);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 8;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(143, 149);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 20);
            this.txt5.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt5);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.lblventanas);
            this.groupBox1.Controls.Add(this.lblpuertas);
            this.groupBox1.Controls.Add(this.lblllantas);
            this.groupBox1.Controls.Add(this.lblcolor);
            this.groupBox1.Controls.Add(this.lblcombustible);
            this.groupBox1.Location = new System.Drawing.Point(22, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 198);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales del vehiculo";
            // 
            // lblalas
            // 
            this.lblalas.AutoSize = true;
            this.lblalas.Location = new System.Drawing.Point(7, 20);
            this.lblalas.Name = "lblalas";
            this.lblalas.Size = new System.Drawing.Size(84, 13);
            this.lblalas.TabIndex = 11;
            this.lblalas.Text = "Numero de alas:";
            // 
            // lblturbinas
            // 
            this.lblturbinas.AutoSize = true;
            this.lblturbinas.Location = new System.Drawing.Point(7, 54);
            this.lblturbinas.Name = "lblturbinas";
            this.lblturbinas.Size = new System.Drawing.Size(102, 13);
            this.lblturbinas.TabIndex = 12;
            this.lblturbinas.Text = "Numero de turbinas:";
            // 
            // lblhelices
            // 
            this.lblhelices.AutoSize = true;
            this.lblhelices.Location = new System.Drawing.Point(7, 94);
            this.lblhelices.Name = "lblhelices";
            this.lblhelices.Size = new System.Drawing.Size(98, 13);
            this.lblhelices.TabIndex = 13;
            this.lblhelices.Text = "Numero de helices:";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(7, 134);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(119, 13);
            this.lbltipo.TabIndex = 14;
            this.lbltipo.Text = "Tipo de vehiculo aereo:";
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(147, 20);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 20);
            this.txt6.TabIndex = 15;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(147, 54);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(100, 20);
            this.txt7.TabIndex = 16;
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(147, 94);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(100, 20);
            this.txt8.TabIndex = 17;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "Avion",
            "Helicoptero",
            "Jet",
            "Avioneta"});
            this.cmb1.Location = new System.Drawing.Point(147, 134);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(100, 21);
            this.cmb1.TabIndex = 19;
            this.cmb1.Text = "      Selecionar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb1);
            this.groupBox2.Controls.Add(this.txt8);
            this.groupBox2.Controls.Add(this.txt7);
            this.groupBox2.Controls.Add(this.txt6);
            this.groupBox2.Controls.Add(this.lbltipo);
            this.groupBox2.Controls.Add(this.lblhelices);
            this.groupBox2.Controls.Add(this.lblturbinas);
            this.groupBox2.Controls.Add(this.lblalas);
            this.groupBox2.Location = new System.Drawing.Point(18, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 176);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos especificos aereos";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(366, 18);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 26);
            this.btnnuevo.TabIndex = 21;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnparar
            // 
            this.btnparar.Location = new System.Drawing.Point(217, 465);
            this.btnparar.Name = "btnparar";
            this.btnparar.Size = new System.Drawing.Size(75, 28);
            this.btnparar.TabIndex = 22;
            this.btnparar.Text = "Parar ";
            this.btnparar.UseVisualStyleBackColor = true;
            this.btnparar.Click += new System.EventHandler(this.btnparar_Click);
            // 
            // btnarrancar
            // 
            this.btnarrancar.Location = new System.Drawing.Point(22, 465);
            this.btnarrancar.Name = "btnarrancar";
            this.btnarrancar.Size = new System.Drawing.Size(75, 28);
            this.btnarrancar.TabIndex = 23;
            this.btnarrancar.Text = "Arrancar";
            this.btnarrancar.UseVisualStyleBackColor = true;
            this.btnarrancar.Click += new System.EventHandler(this.btnarrancar_Click);
            // 
            // txtSonido
            // 
            this.txtSonido.Location = new System.Drawing.Point(18, 499);
            this.txtSonido.Name = "txtSonido";
            this.txtSonido.Size = new System.Drawing.Size(84, 20);
            this.txtSonido.TabIndex = 24;
            // 
            // btnGuaradar
            // 
            this.btnGuaradar.Location = new System.Drawing.Point(252, 414);
            this.btnGuaradar.Name = "btnGuaradar";
            this.btnGuaradar.Size = new System.Drawing.Size(75, 23);
            this.btnGuaradar.TabIndex = 25;
            this.btnGuaradar.Text = "Guardar";
            this.btnGuaradar.UseVisualStyleBackColor = true;
            this.btnGuaradar.Click += new System.EventHandler(this.btnGuaradar_Click);
            // 
            // btnVolar
            // 
            this.btnVolar.Location = new System.Drawing.Point(341, 465);
            this.btnVolar.Name = "btnVolar";
            this.btnVolar.Size = new System.Drawing.Size(75, 28);
            this.btnVolar.TabIndex = 26;
            this.btnVolar.Text = "Volar";
            this.btnVolar.UseVisualStyleBackColor = true;
            this.btnVolar.Click += new System.EventHandler(this.btnVolar_Click);
            // 
            // txtsonidoparar
            // 
            this.txtsonidoparar.Location = new System.Drawing.Point(207, 498);
            this.txtsonidoparar.Name = "txtsonidoparar";
            this.txtsonidoparar.Size = new System.Drawing.Size(100, 20);
            this.txtsonidoparar.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(481, 539);
            this.Controls.Add(this.txtsonidoparar);
            this.Controls.Add(this.btnVolar);
            this.Controls.Add(this.btnGuaradar);
            this.Controls.Add(this.txtSonido);
            this.Controls.Add(this.btnarrancar);
            this.Controls.Add(this.btnparar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcombustible;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblllantas;
        private System.Windows.Forms.Label lblpuertas;
        private System.Windows.Forms.Label lblventanas;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblalas;
        private System.Windows.Forms.Label lblturbinas;
        private System.Windows.Forms.Label lblhelices;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnparar;
        private System.Windows.Forms.Button btnarrancar;
        private System.Windows.Forms.TextBox txtSonido;
        private System.Windows.Forms.Button btnGuaradar;
        private System.Windows.Forms.Button btnVolar;
        private System.Windows.Forms.TextBox txtsonidoparar;
    }
}

