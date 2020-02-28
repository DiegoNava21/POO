namespace Examen2y3
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
            this.lbltipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblcosto = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.btncobrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(24, 44);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(92, 13);
            this.lbltipo.TabIndex = 0;
            this.lbltipo.Text = "tipo de transporte:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Motociclista",
            "Automovil",
            "Autobus",
            "Trailer"});
            this.cmbTipo.Location = new System.Drawing.Point(12, 70);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.Text = "         Seleccionar";
            // 
            // lblcosto
            // 
            this.lblcosto.AutoSize = true;
            this.lblcosto.Location = new System.Drawing.Point(185, 44);
            this.lblcosto.Name = "lblcosto";
            this.lblcosto.Size = new System.Drawing.Size(37, 13);
            this.lblcosto.TabIndex = 2;
            this.lblcosto.Text = "Costo:";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(151, 71);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(121, 20);
            this.txtc.TabIndex = 3;
            // 
            // btncobrar
            // 
            this.btncobrar.Location = new System.Drawing.Point(99, 131);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(75, 23);
            this.btncobrar.TabIndex = 4;
            this.btncobrar.Text = "Cobrar";
            this.btncobrar.UseVisualStyleBackColor = true;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FAVOR DE PAGAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.lblcosto);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lbltipo);
            this.Name = "Form1";
            this.Text = "CASETA DE COBRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblcosto;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Label label1;
    }
}

