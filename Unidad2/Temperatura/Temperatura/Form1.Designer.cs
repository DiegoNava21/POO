namespace Temperatura
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
            this.lblgrados = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtgrados = new System.Windows.Forms.TextBox();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgrados
            // 
            this.lblgrados.AutoSize = true;
            this.lblgrados.Location = new System.Drawing.Point(67, 55);
            this.lblgrados.Name = "lblgrados";
            this.lblgrados.Size = new System.Drawing.Size(44, 13);
            this.lblgrados.TabIndex = 0;
            this.lblgrados.Text = "Grados:";
            this.lblgrados.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtgrados
            // 
            this.txtgrados.Location = new System.Drawing.Point(163, 55);
            this.txtgrados.Name = "txtgrados";
            this.txtgrados.Size = new System.Drawing.Size(100, 20);
            this.txtgrados.TabIndex = 2;
            // 
            // cmbtipo
            // 
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenit"});
            this.cmbtipo.Location = new System.Drawing.Point(142, 104);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(121, 21);
            this.cmbtipo.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbtipo);
            this.Controls.Add(this.txtgrados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblgrados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgrados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtgrados;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.Button button2;
    }
}

