namespace panalbase
{
    partial class Pais
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Bregresarpais = new System.Windows.Forms.Button();
            this.Beliminar = new System.Windows.Forms.Button();
            this.Bmodificar = new System.Windows.Forms.Button();
            this.Baniadirpais = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBpais = new System.Windows.Forms.TextBox();
            this.TBnombrepais = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(170, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "desactivar";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Bregresarpais
            // 
            this.Bregresarpais.BackColor = System.Drawing.Color.Orange;
            this.Bregresarpais.Location = new System.Drawing.Point(15, 166);
            this.Bregresarpais.Name = "Bregresarpais";
            this.Bregresarpais.Size = new System.Drawing.Size(75, 23);
            this.Bregresarpais.TabIndex = 16;
            this.Bregresarpais.Text = "regresar";
            this.Bregresarpais.UseVisualStyleBackColor = false;
            this.Bregresarpais.Click += new System.EventHandler(this.Bregresarpais_Click);
            // 
            // Beliminar
            // 
            this.Beliminar.BackColor = System.Drawing.Color.Orange;
            this.Beliminar.Enabled = false;
            this.Beliminar.Location = new System.Drawing.Point(150, 91);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.Size = new System.Drawing.Size(108, 23);
            this.Beliminar.TabIndex = 15;
            this.Beliminar.Text = "desactivar/eliminar";
            this.Beliminar.UseVisualStyleBackColor = false;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click_1);
            // 
            // Bmodificar
            // 
            this.Bmodificar.BackColor = System.Drawing.Color.Orange;
            this.Bmodificar.Enabled = false;
            this.Bmodificar.Location = new System.Drawing.Point(150, 55);
            this.Bmodificar.Name = "Bmodificar";
            this.Bmodificar.Size = new System.Drawing.Size(108, 23);
            this.Bmodificar.TabIndex = 14;
            this.Bmodificar.Text = "modificar pais";
            this.Bmodificar.UseVisualStyleBackColor = false;
            this.Bmodificar.Click += new System.EventHandler(this.Bmodificar_Click_1);
            // 
            // Baniadirpais
            // 
            this.Baniadirpais.BackColor = System.Drawing.Color.Orange;
            this.Baniadirpais.Location = new System.Drawing.Point(183, 166);
            this.Baniadirpais.Name = "Baniadirpais";
            this.Baniadirpais.Size = new System.Drawing.Size(75, 23);
            this.Baniadirpais.TabIndex = 13;
            this.Baniadirpais.Text = "añadir pais";
            this.Baniadirpais.UseVisualStyleBackColor = false;
            this.Baniadirpais.Click += new System.EventHandler(this.Baniadirpais_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Codigo del pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "nombre del pais";
            // 
            // TBpais
            // 
            this.TBpais.Location = new System.Drawing.Point(12, 79);
            this.TBpais.Name = "TBpais";
            this.TBpais.Size = new System.Drawing.Size(100, 20);
            this.TBpais.TabIndex = 10;
            // 
            // TBnombrepais
            // 
            this.TBnombrepais.Location = new System.Drawing.Point(12, 27);
            this.TBnombrepais.Name = "TBnombrepais";
            this.TBnombrepais.Size = new System.Drawing.Size(100, 20);
            this.TBnombrepais.TabIndex = 9;
            // 
            // Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(276, 203);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Bregresarpais);
            this.Controls.Add(this.Beliminar);
            this.Controls.Add(this.Bmodificar);
            this.Controls.Add(this.Baniadirpais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBpais);
            this.Controls.Add(this.TBnombrepais);
            this.Name = "Pais";
            this.Text = "Pais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Bregresarpais;
        private System.Windows.Forms.Button Beliminar;
        private System.Windows.Forms.Button Bmodificar;
        private System.Windows.Forms.Button Baniadirpais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBpais;
        private System.Windows.Forms.TextBox TBnombrepais;
    }
}