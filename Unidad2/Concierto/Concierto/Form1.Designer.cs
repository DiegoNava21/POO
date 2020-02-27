namespace Concierto
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
            this.lblcat = new System.Windows.Forms.Label();
            this.lblen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbper = new System.Windows.Forms.ComboBox();
            this.cmbnum = new System.Windows.Forms.ComboBox();
            this.lblbebe = new System.Windows.Forms.Label();
            this.lblniño = new System.Windows.Forms.Label();
            this.lbladulto = new System.Windows.Forms.Label();
            this.lblte = new System.Windows.Forms.Label();
            this.btnre = new System.Windows.Forms.Button();
            this.btnco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Location = new System.Drawing.Point(45, 79);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(52, 13);
            this.lblcat.TabIndex = 0;
            this.lblcat.Text = "Categoria";
            this.lblcat.Click += new System.EventHandler(this.lblcat_Click);
            // 
            // lblen
            // 
            this.lblen.AutoSize = true;
            this.lblen.Location = new System.Drawing.Point(175, 79);
            this.lblen.Name = "lblen";
            this.lblen.Size = new System.Drawing.Size(69, 13);
            this.lblen.TabIndex = 1;
            this.lblen.Text = "No. Entradas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ENTRADAS\r\n";
            // 
            // cmbper
            // 
            this.cmbper.FormattingEnabled = true;
            this.cmbper.Items.AddRange(new object[] {
            "Bebe",
            "Niño",
            "Adulto",
            "Tercera edad"});
            this.cmbper.Location = new System.Drawing.Point(12, 108);
            this.cmbper.Name = "cmbper";
            this.cmbper.Size = new System.Drawing.Size(121, 21);
            this.cmbper.TabIndex = 3;
            // 
            // cmbnum
            // 
            this.cmbnum.FormattingEnabled = true;
            this.cmbnum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbnum.Location = new System.Drawing.Point(151, 108);
            this.cmbnum.Name = "cmbnum";
            this.cmbnum.Size = new System.Drawing.Size(121, 21);
            this.cmbnum.TabIndex = 4;
            // 
            // lblbebe
            // 
            this.lblbebe.AutoSize = true;
            this.lblbebe.Location = new System.Drawing.Point(18, 153);
            this.lblbebe.Name = "lblbebe";
            this.lblbebe.Size = new System.Drawing.Size(32, 13);
            this.lblbebe.TabIndex = 5;
            this.lblbebe.Text = "Bebe";
            // 
            // lblniño
            // 
            this.lblniño.AutoSize = true;
            this.lblniño.Location = new System.Drawing.Point(18, 181);
            this.lblniño.Name = "lblniño";
            this.lblniño.Size = new System.Drawing.Size(29, 13);
            this.lblniño.TabIndex = 6;
            this.lblniño.Text = "Niño";
            // 
            // lbladulto
            // 
            this.lbladulto.AutoSize = true;
            this.lbladulto.Location = new System.Drawing.Point(18, 208);
            this.lbladulto.Name = "lbladulto";
            this.lbladulto.Size = new System.Drawing.Size(37, 13);
            this.lbladulto.TabIndex = 7;
            this.lbladulto.Text = "Adulto";
            // 
            // lblte
            // 
            this.lblte.AutoSize = true;
            this.lblte.Location = new System.Drawing.Point(18, 239);
            this.lblte.Name = "lblte";
            this.lblte.Size = new System.Drawing.Size(42, 13);
            this.lblte.TabIndex = 8;
            this.lblte.Text = "T.Edad";
            // 
            // btnre
            // 
            this.btnre.Location = new System.Drawing.Point(68, 266);
            this.btnre.Name = "btnre";
            this.btnre.Size = new System.Drawing.Size(75, 23);
            this.btnre.TabIndex = 9;
            this.btnre.Text = "Reporte";
            this.btnre.UseVisualStyleBackColor = true;
            this.btnre.Click += new System.EventHandler(this.btnre_Click);
            // 
            // btnco
            // 
            this.btnco.Location = new System.Drawing.Point(169, 266);
            this.btnco.Name = "btnco";
            this.btnco.Size = new System.Drawing.Size(75, 23);
            this.btnco.TabIndex = 10;
            this.btnco.Text = "Contabilizar";
            this.btnco.UseVisualStyleBackColor = true;
            this.btnco.Click += new System.EventHandler(this.btnco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.btnco);
            this.Controls.Add(this.btnre);
            this.Controls.Add(this.lblte);
            this.Controls.Add(this.lbladulto);
            this.Controls.Add(this.lblniño);
            this.Controls.Add(this.lblbebe);
            this.Controls.Add(this.cmbnum);
            this.Controls.Add(this.cmbper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblen);
            this.Controls.Add(this.lblcat);
            this.Name = "Form1";
            this.Text = "COCIERTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.Label lblen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbper;
        private System.Windows.Forms.ComboBox cmbnum;
        private System.Windows.Forms.Label lblbebe;
        private System.Windows.Forms.Label lblniño;
        private System.Windows.Forms.Label lbladulto;
        private System.Windows.Forms.Label lblte;
        private System.Windows.Forms.Button btnre;
        private System.Windows.Forms.Button btnco;
    }
}

