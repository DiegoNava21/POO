namespace InterfacesEjercicio1
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
            this.lblnoombrea = new System.Windows.Forms.Label();
            this.txtnombrea = new System.Windows.Forms.TextBox();
            this.lblañoa = new System.Windows.Forms.Label();
            this.txtañoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnprecioaccion = new System.Windows.Forms.Button();
            this.lblnombred = new System.Windows.Forms.Label();
            this.lblañod = new System.Windows.Forms.Label();
            this.txtnombred = new System.Windows.Forms.TextBox();
            this.txtañod = new System.Windows.Forms.TextBox();
            this.btnPreciodeporte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtprecioa = new System.Windows.Forms.TextBox();
            this.txtpreciod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnoombrea
            // 
            this.lblnoombrea.AutoSize = true;
            this.lblnoombrea.Location = new System.Drawing.Point(2, 13);
            this.lblnoombrea.Name = "lblnoombrea";
            this.lblnoombrea.Size = new System.Drawing.Size(44, 13);
            this.lblnoombrea.TabIndex = 0;
            this.lblnoombrea.Text = "Nombre";
            // 
            // txtnombrea
            // 
            this.txtnombrea.Location = new System.Drawing.Point(52, 13);
            this.txtnombrea.Name = "txtnombrea";
            this.txtnombrea.Size = new System.Drawing.Size(100, 20);
            this.txtnombrea.TabIndex = 1;
            // 
            // lblañoa
            // 
            this.lblañoa.AutoSize = true;
            this.lblañoa.Location = new System.Drawing.Point(2, 65);
            this.lblañoa.Name = "lblañoa";
            this.lblañoa.Size = new System.Drawing.Size(80, 13);
            this.lblañoa.TabIndex = 2;
            this.lblañoa.Text = "Año de Estreno";
            // 
            // txtañoa
            // 
            this.txtañoa.Location = new System.Drawing.Point(88, 65);
            this.txtañoa.Name = "txtañoa";
            this.txtañoa.Size = new System.Drawing.Size(100, 20);
            this.txtañoa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // btnprecioaccion
            // 
            this.btnprecioaccion.Location = new System.Drawing.Point(12, 150);
            this.btnprecioaccion.Name = "btnprecioaccion";
            this.btnprecioaccion.Size = new System.Drawing.Size(75, 23);
            this.btnprecioaccion.TabIndex = 5;
            this.btnprecioaccion.Text = "Precio";
            this.btnprecioaccion.UseVisualStyleBackColor = true;
            this.btnprecioaccion.Click += new System.EventHandler(this.btnprecioaccion_Click);
            // 
            // lblnombred
            // 
            this.lblnombred.AutoSize = true;
            this.lblnombred.Location = new System.Drawing.Point(37, 19);
            this.lblnombred.Name = "lblnombred";
            this.lblnombred.Size = new System.Drawing.Size(44, 13);
            this.lblnombred.TabIndex = 6;
            this.lblnombred.Text = "Nombre";
            // 
            // lblañod
            // 
            this.lblañod.AutoSize = true;
            this.lblañod.Location = new System.Drawing.Point(37, 71);
            this.lblañod.Name = "lblañod";
            this.lblañod.Size = new System.Drawing.Size(80, 13);
            this.lblañod.TabIndex = 7;
            this.lblañod.Text = "Año de Estreno";
            // 
            // txtnombred
            // 
            this.txtnombred.Location = new System.Drawing.Point(123, 19);
            this.txtnombred.Name = "txtnombred";
            this.txtnombred.Size = new System.Drawing.Size(100, 20);
            this.txtnombred.TabIndex = 8;
            // 
            // txtañod
            // 
            this.txtañod.Location = new System.Drawing.Point(123, 71);
            this.txtañod.Name = "txtañod";
            this.txtañod.Size = new System.Drawing.Size(100, 20);
            this.txtañod.TabIndex = 9;
            // 
            // btnPreciodeporte
            // 
            this.btnPreciodeporte.Location = new System.Drawing.Point(40, 150);
            this.btnPreciodeporte.Name = "btnPreciodeporte";
            this.btnPreciodeporte.Size = new System.Drawing.Size(75, 23);
            this.btnPreciodeporte.TabIndex = 10;
            this.btnPreciodeporte.Text = "Precio";
            this.btnPreciodeporte.UseVisualStyleBackColor = true;
            this.btnPreciodeporte.Click += new System.EventHandler(this.btnPreciodeporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtprecioa);
            this.groupBox1.Controls.Add(this.btnprecioaccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtañoa);
            this.groupBox1.Controls.Add(this.lblañoa);
            this.groupBox1.Controls.Add(this.txtnombrea);
            this.groupBox1.Controls.Add(this.lblnoombrea);
            this.groupBox1.Location = new System.Drawing.Point(25, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 251);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtpreciod);
            this.groupBox2.Controls.Add(this.btnPreciodeporte);
            this.groupBox2.Controls.Add(this.txtañod);
            this.groupBox2.Controls.Add(this.txtnombred);
            this.groupBox2.Controls.Add(this.lblañod);
            this.groupBox2.Controls.Add(this.lblnombred);
            this.groupBox2.Location = new System.Drawing.Point(293, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 257);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deporte";
            // 
            // txtprecioa
            // 
            this.txtprecioa.Location = new System.Drawing.Point(88, 106);
            this.txtprecioa.Name = "txtprecioa";
            this.txtprecioa.Size = new System.Drawing.Size(100, 20);
            this.txtprecioa.TabIndex = 6;
            // 
            // txtpreciod
            // 
            this.txtpreciod.Location = new System.Drawing.Point(123, 106);
            this.txtpreciod.Name = "txtpreciod";
            this.txtpreciod.Size = new System.Drawing.Size(100, 20);
            this.txtpreciod.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Precio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 356);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblnoombrea;
        private System.Windows.Forms.TextBox txtnombrea;
        private System.Windows.Forms.Label lblañoa;
        private System.Windows.Forms.TextBox txtañoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnprecioaccion;
        private System.Windows.Forms.Label lblnombred;
        private System.Windows.Forms.Label lblañod;
        private System.Windows.Forms.TextBox txtnombred;
        private System.Windows.Forms.TextBox txtañod;
        private System.Windows.Forms.Button btnPreciodeporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprecioa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpreciod;
    }
}

