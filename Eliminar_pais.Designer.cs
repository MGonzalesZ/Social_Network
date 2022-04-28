namespace panalbase
{
    partial class Eliminar_pais
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
            this.DTGVeliminarusuario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Beliminar = new System.Windows.Forms.Button();
            this.Bregresar = new System.Windows.Forms.Button();
            this.TBseleccionarpais = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVeliminarusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGVeliminarusuario
            // 
            this.DTGVeliminarusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVeliminarusuario.Location = new System.Drawing.Point(12, 12);
            this.DTGVeliminarusuario.Name = "DTGVeliminarusuario";
            this.DTGVeliminarusuario.Size = new System.Drawing.Size(240, 150);
            this.DTGVeliminarusuario.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "seleccionar pais";
            // 
            // Beliminar
            // 
            this.Beliminar.BackColor = System.Drawing.Color.Orange;
            this.Beliminar.Location = new System.Drawing.Point(177, 223);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.Size = new System.Drawing.Size(75, 23);
            this.Beliminar.TabIndex = 8;
            this.Beliminar.Text = "eliminar";
            this.Beliminar.UseVisualStyleBackColor = false;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click);
            // 
            // Bregresar
            // 
            this.Bregresar.BackColor = System.Drawing.Color.Orange;
            this.Bregresar.Location = new System.Drawing.Point(20, 223);
            this.Bregresar.Name = "Bregresar";
            this.Bregresar.Size = new System.Drawing.Size(75, 23);
            this.Bregresar.TabIndex = 7;
            this.Bregresar.Text = "regresar";
            this.Bregresar.UseVisualStyleBackColor = false;
            // 
            // TBseleccionarpais
            // 
            this.TBseleccionarpais.Location = new System.Drawing.Point(53, 181);
            this.TBseleccionarpais.Name = "TBseleccionarpais";
            this.TBseleccionarpais.Size = new System.Drawing.Size(120, 20);
            this.TBseleccionarpais.TabIndex = 6;
            // 
            // Eliminar_pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(271, 267);
            this.Controls.Add(this.DTGVeliminarusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Beliminar);
            this.Controls.Add(this.Bregresar);
            this.Controls.Add(this.TBseleccionarpais);
            this.Name = "Eliminar_pais";
            this.Text = "Eliminar_pais";
            ((System.ComponentModel.ISupportInitialize)(this.DTGVeliminarusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGVeliminarusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Beliminar;
        private System.Windows.Forms.Button Bregresar;
        private System.Windows.Forms.TextBox TBseleccionarpais;
    }
}