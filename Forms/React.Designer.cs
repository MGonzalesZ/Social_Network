namespace panalbase
{
    partial class React
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtInsertar = new System.Windows.Forms.Button();
            this.txtModificar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtInsertar
            // 
            this.txtInsertar.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtInsertar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtInsertar.ForeColor = System.Drawing.Color.White;
            this.txtInsertar.Location = new System.Drawing.Point(428, 23);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(94, 37);
            this.txtInsertar.TabIndex = 1;
            this.txtInsertar.Text = "INSERTAR";
            this.txtInsertar.UseVisualStyleBackColor = false;
            this.txtInsertar.Click += new System.EventHandler(this.txtInsertar_Click);
            // 
            // txtModificar
            // 
            this.txtModificar.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtModificar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtModificar.ForeColor = System.Drawing.Color.White;
            this.txtModificar.Location = new System.Drawing.Point(428, 64);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(94, 37);
            this.txtModificar.TabIndex = 2;
            this.txtModificar.Text = "MODIFICAR";
            this.txtModificar.UseVisualStyleBackColor = false;
            this.txtModificar.Click += new System.EventHandler(this.txtModificar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtEliminar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtEliminar.ForeColor = System.Drawing.Color.White;
            this.txtEliminar.Location = new System.Drawing.Point(428, 106);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(94, 37);
            this.txtEliminar.TabIndex = 3;
            this.txtEliminar.Text = "ELIMINAR";
            this.txtEliminar.UseVisualStyleBackColor = false;
            this.txtEliminar.Click += new System.EventHandler(this.txtEliminar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 367);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(137)))), ((int)(((byte)(48)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(244, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtActualizar
            // 
            this.txtActualizar.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtActualizar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtActualizar.ForeColor = System.Drawing.Color.White;
            this.txtActualizar.Location = new System.Drawing.Point(428, 153);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(94, 37);
            this.txtActualizar.TabIndex = 7;
            this.txtActualizar.Text = "ACTUALIZAR";
            this.txtActualizar.UseVisualStyleBackColor = false;
            this.txtActualizar.Click += new System.EventHandler(this.txtActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Introduzca el id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Introduzca el nombre";
            // 
            // React
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActualizar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtModificar);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "React";
            this.Text = "React";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtInsertar;
        private System.Windows.Forms.Button txtModificar;
        private System.Windows.Forms.Button txtEliminar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button txtActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}