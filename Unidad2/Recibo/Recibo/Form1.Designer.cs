namespace Recibo
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
            this.TipoContrato = new System.Windows.Forms.ComboBox();
            this.lblcontrato = new System.Windows.Forms.Label();
            this.btncobrar = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtIntcanwatts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TipoContrato
            // 
            this.TipoContrato.FormattingEnabled = true;
            this.TipoContrato.Items.AddRange(new object[] {
            "Negocio",
            "Hogar"});
            this.TipoContrato.Location = new System.Drawing.Point(130, 53);
            this.TipoContrato.Name = "TipoContrato";
            this.TipoContrato.Size = new System.Drawing.Size(121, 21);
            this.TipoContrato.TabIndex = 0;
            // 
            // lblcontrato
            // 
            this.lblcontrato.AutoSize = true;
            this.lblcontrato.Location = new System.Drawing.Point(40, 56);
            this.lblcontrato.Name = "lblcontrato";
            this.lblcontrato.Size = new System.Drawing.Size(47, 13);
            this.lblcontrato.TabIndex = 1;
            this.lblcontrato.Text = "Contrato";
            // 
            // btncobrar
            // 
            this.btncobrar.Location = new System.Drawing.Point(130, 180);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(75, 23);
            this.btncobrar.TabIndex = 2;
            this.btncobrar.Text = "Cobrra";
            this.btncobrar.UseVisualStyleBackColor = true;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(26, 131);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(76, 13);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "Total  a pagar:";
            // 
            // txtIntcanwatts
            // 
            this.txtIntcanwatts.Location = new System.Drawing.Point(130, 94);
            this.txtIntcanwatts.Name = "txtIntcanwatts";
            this.txtIntcanwatts.Size = new System.Drawing.Size(100, 20);
            this.txtIntcanwatts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "KW consumidos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntcanwatts);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.lblcontrato);
            this.Controls.Add(this.TipoContrato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TipoContrato;
        private System.Windows.Forms.Label lblcontrato;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtIntcanwatts;
        private System.Windows.Forms.Label label1;
    }
}

