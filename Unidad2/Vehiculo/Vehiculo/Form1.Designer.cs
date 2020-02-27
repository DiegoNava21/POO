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
            this.btncobrar = new System.Windows.Forms.Button();
            this.cmbvehiculo = new System.Windows.Forms.ComboBox();
            this.lblcantidadacobrar = new System.Windows.Forms.Label();
            this.txtcobro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncobrar
            // 
            this.btncobrar.Location = new System.Drawing.Point(103, 175);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(75, 23);
            this.btncobrar.TabIndex = 0;
            this.btncobrar.Text = "Cobrar";
            this.btncobrar.UseVisualStyleBackColor = true;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // cmbvehiculo
            // 
            this.cmbvehiculo.FormattingEnabled = true;
            this.cmbvehiculo.Items.AddRange(new object[] {
            "Motociclista",
            "Automovil",
            "Autobus",
            "Trailer"});
            this.cmbvehiculo.Location = new System.Drawing.Point(111, 58);
            this.cmbvehiculo.Name = "cmbvehiculo";
            this.cmbvehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbvehiculo.TabIndex = 1;
            // 
            // lblcantidadacobrar
            // 
            this.lblcantidadacobrar.AutoSize = true;
            this.lblcantidadacobrar.Location = new System.Drawing.Point(47, 115);
            this.lblcantidadacobrar.Name = "lblcantidadacobrar";
            this.lblcantidadacobrar.Size = new System.Drawing.Size(37, 13);
            this.lblcantidadacobrar.TabIndex = 2;
            this.lblcantidadacobrar.Text = "Costo:";
            // 
            // txtcobro
            // 
            this.txtcobro.Location = new System.Drawing.Point(111, 115);
            this.txtcobro.Name = "txtcobro";
            this.txtcobro.Size = new System.Drawing.Size(100, 20);
            this.txtcobro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de transporte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcobro);
            this.Controls.Add(this.lblcantidadacobrar);
            this.Controls.Add(this.cmbvehiculo);
            this.Controls.Add(this.btncobrar);
            this.Name = "Form1";
            this.Text = "Caseta de cobro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.ComboBox cmbvehiculo;
        private System.Windows.Forms.Label lblcantidadacobrar;
        private System.Windows.Forms.TextBox txtcobro;
        private System.Windows.Forms.Label label1;
    }
}

