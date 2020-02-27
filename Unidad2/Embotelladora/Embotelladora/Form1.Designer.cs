namespace Embotelladora
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
            this.label1 = new System.Windows.Forms.Label();
            this.mililitrosVerificados = new System.Windows.Forms.Label();
            this.txtl = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtnivelllenado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nivel de llenado:";
            // 
            // mililitrosVerificados
            // 
            this.mililitrosVerificados.AutoSize = true;
            this.mililitrosVerificados.Location = new System.Drawing.Point(33, 98);
            this.mililitrosVerificados.Name = "mililitrosVerificados";
            this.mililitrosVerificados.Size = new System.Drawing.Size(34, 13);
            this.mililitrosVerificados.TabIndex = 1;
            this.mililitrosVerificados.Text = "Total:";
            // 
            // txtl
            // 
            this.txtl.Location = new System.Drawing.Point(159, 42);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(100, 20);
            this.txtl.TabIndex = 2;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(106, 168);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Comprobar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnivelllenado
            // 
            this.txtnivelllenado.Location = new System.Drawing.Point(159, 95);
            this.txtnivelllenado.Name = "txtnivelllenado";
            this.txtnivelllenado.Size = new System.Drawing.Size(100, 20);
            this.txtnivelllenado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtnivelllenado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.mililitrosVerificados);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mililitrosVerificados;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtnivelllenado;
    }
}

