namespace Cuadrado
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
            this.lbllado = new System.Windows.Forms.Label();
            this.btnarea = new System.Windows.Forms.Button();
            this.btnperimetro = new System.Windows.Forms.Button();
            this.lblarea = new System.Windows.Forms.Label();
            this.lblperimetro = new System.Windows.Forms.Label();
            this.txtlado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbllado
            // 
            this.lbllado.AutoSize = true;
            this.lbllado.Location = new System.Drawing.Point(59, 35);
            this.lbllado.Name = "lbllado";
            this.lbllado.Size = new System.Drawing.Size(31, 13);
            this.lbllado.TabIndex = 0;
            this.lbllado.Text = "Lado";
            // 
            // btnarea
            // 
            this.btnarea.Location = new System.Drawing.Point(174, 74);
            this.btnarea.Name = "btnarea";
            this.btnarea.Size = new System.Drawing.Size(75, 23);
            this.btnarea.TabIndex = 1;
            this.btnarea.Text = "Area";
            this.btnarea.UseVisualStyleBackColor = true;
            this.btnarea.Click += new System.EventHandler(this.btnarea_Click);
            // 
            // btnperimetro
            // 
            this.btnperimetro.Location = new System.Drawing.Point(174, 118);
            this.btnperimetro.Name = "btnperimetro";
            this.btnperimetro.Size = new System.Drawing.Size(75, 23);
            this.btnperimetro.TabIndex = 2;
            this.btnperimetro.Text = "Perimetro";
            this.btnperimetro.UseVisualStyleBackColor = true;
            this.btnperimetro.Click += new System.EventHandler(this.btnperimetro_Click);
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(32, 84);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(32, 13);
            this.lblarea.TabIndex = 3;
            this.lblarea.Text = "Area:";
            // 
            // lblperimetro
            // 
            this.lblperimetro.AutoSize = true;
            this.lblperimetro.Location = new System.Drawing.Point(32, 123);
            this.lblperimetro.Name = "lblperimetro";
            this.lblperimetro.Size = new System.Drawing.Size(54, 13);
            this.lblperimetro.TabIndex = 4;
            this.lblperimetro.Text = "Perimetro:";
            // 
            // txtlado
            // 
            this.txtlado.Location = new System.Drawing.Point(140, 35);
            this.txtlado.Name = "txtlado";
            this.txtlado.Size = new System.Drawing.Size(100, 20);
            this.txtlado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtlado);
            this.Controls.Add(this.lblperimetro);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.btnperimetro);
            this.Controls.Add(this.btnarea);
            this.Controls.Add(this.lbllado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllado;
        private System.Windows.Forms.Button btnarea;
        private System.Windows.Forms.Button btnperimetro;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label lblperimetro;
        private System.Windows.Forms.TextBox txtlado;
    }
}

