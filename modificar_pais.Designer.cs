namespace panalbase
{
    partial class modificar_pais
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
            this.dataGridViewmodificar = new System.Windows.Forms.DataGridView();
            this.Baplicar = new System.Windows.Forms.Button();
            this.Bvolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBcodpais = new System.Windows.Forms.TextBox();
            this.TBnombrepais = new System.Windows.Forms.TextBox();
            this.TBidPais = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmodificar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewmodificar
            // 
            this.dataGridViewmodificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(229)))), ((int)(((byte)(144)))));
            this.dataGridViewmodificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmodificar.Location = new System.Drawing.Point(159, 30);
            this.dataGridViewmodificar.Name = "dataGridViewmodificar";
            this.dataGridViewmodificar.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewmodificar.TabIndex = 18;
            // 
            // Baplicar
            // 
            this.Baplicar.BackColor = System.Drawing.Color.Orange;
            this.Baplicar.Location = new System.Drawing.Point(228, 192);
            this.Baplicar.Name = "Baplicar";
            this.Baplicar.Size = new System.Drawing.Size(76, 36);
            this.Baplicar.TabIndex = 17;
            this.Baplicar.Text = "aplicar";
            this.Baplicar.UseVisualStyleBackColor = false;
            this.Baplicar.Click += new System.EventHandler(this.Baplicar_Click_1);
            // 
            // Bvolver
            // 
            this.Bvolver.BackColor = System.Drawing.Color.Orange;
            this.Bvolver.Location = new System.Drawing.Point(29, 192);
            this.Bvolver.Name = "Bvolver";
            this.Bvolver.Size = new System.Drawing.Size(84, 36);
            this.Bvolver.TabIndex = 16;
            this.Bvolver.Text = "volver";
            this.Bvolver.UseVisualStyleBackColor = false;
            this.Bvolver.Click += new System.EventHandler(this.Bvolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "codigo del pais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "nombre del pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "id del pais";
            // 
            // TBcodpais
            // 
            this.TBcodpais.Location = new System.Drawing.Point(13, 124);
            this.TBcodpais.Name = "TBcodpais";
            this.TBcodpais.Size = new System.Drawing.Size(100, 20);
            this.TBcodpais.TabIndex = 12;
            // 
            // TBnombrepais
            // 
            this.TBnombrepais.Location = new System.Drawing.Point(13, 76);
            this.TBnombrepais.Name = "TBnombrepais";
            this.TBnombrepais.Size = new System.Drawing.Size(100, 20);
            this.TBnombrepais.TabIndex = 11;
            // 
            // TBidPais
            // 
            this.TBidPais.Location = new System.Drawing.Point(13, 30);
            this.TBidPais.Name = "TBidPais";
            this.TBidPais.Size = new System.Drawing.Size(100, 20);
            this.TBidPais.TabIndex = 10;
            // 
            // modificar_pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(414, 233);
            this.Controls.Add(this.dataGridViewmodificar);
            this.Controls.Add(this.Baplicar);
            this.Controls.Add(this.Bvolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBcodpais);
            this.Controls.Add(this.TBnombrepais);
            this.Controls.Add(this.TBidPais);
            this.Name = "modificar_pais";
            this.Text = "modificar_pais";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmodificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewmodificar;
        private System.Windows.Forms.Button Baplicar;
        private System.Windows.Forms.Button Bvolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBcodpais;
        private System.Windows.Forms.TextBox TBnombrepais;
        private System.Windows.Forms.TextBox TBidPais;
    }
}