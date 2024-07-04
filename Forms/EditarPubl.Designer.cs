namespace panalbase
{
    partial class EditarPubl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditarTexto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbEdicImag = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.btnTerminarEdicion = new System.Windows.Forms.Button();
            this.lRuta2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdicImag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEditarTexto
            // 
            this.txtEditarTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditarTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarTexto.Location = new System.Drawing.Point(12, 29);
            this.txtEditarTexto.Name = "txtEditarTexto";
            this.txtEditarTexto.Size = new System.Drawing.Size(345, 22);
            this.txtEditarTexto.TabIndex = 1;
            this.txtEditarTexto.TextChanged += new System.EventHandler(this.txtEditarTexto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imagen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pbEdicImag
            // 
            this.pbEdicImag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEdicImag.Location = new System.Drawing.Point(12, 94);
            this.pbEdicImag.Name = "pbEdicImag";
            this.pbEdicImag.Size = new System.Drawing.Size(492, 214);
            this.pbEdicImag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEdicImag.TabIndex = 3;
            this.pbEdicImag.TabStop = false;
            this.pbEdicImag.Click += new System.EventHandler(this.pbEdicImag_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCargarImagen.FlatAppearance.BorderSize = 0;
            this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargarImagen.Location = new System.Drawing.Point(377, 13);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(127, 60);
            this.btnCargarImagen.TabIndex = 4;
            this.btnCargarImagen.Text = "Cargar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // btnTerminarEdicion
            // 
            this.btnTerminarEdicion.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnTerminarEdicion.FlatAppearance.BorderSize = 0;
            this.btnTerminarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminarEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarEdicion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTerminarEdicion.Location = new System.Drawing.Point(156, 317);
            this.btnTerminarEdicion.Name = "btnTerminarEdicion";
            this.btnTerminarEdicion.Size = new System.Drawing.Size(235, 57);
            this.btnTerminarEdicion.TabIndex = 5;
            this.btnTerminarEdicion.Text = "Terminar edición";
            this.btnTerminarEdicion.UseVisualStyleBackColor = false;
            this.btnTerminarEdicion.Click += new System.EventHandler(this.btnTerminarEdicion_Click);
            // 
            // lRuta2
            // 
            this.lRuta2.AutoSize = true;
            this.lRuta2.BackColor = System.Drawing.Color.Transparent;
            this.lRuta2.Location = new System.Drawing.Point(31, 280);
            this.lRuta2.Name = "lRuta2";
            this.lRuta2.Size = new System.Drawing.Size(0, 13);
            this.lRuta2.TabIndex = 6;
            this.lRuta2.Click += new System.EventHandler(this.lRuta2_Click);
            // 
            // EditarPubl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(528, 386);
            this.Controls.Add(this.lRuta2);
            this.Controls.Add(this.btnTerminarEdicion);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pbEdicImag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEditarTexto);
            this.Controls.Add(this.label1);
            this.Name = "EditarPubl";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbEdicImag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtEditarTexto;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pbEdicImag;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnTerminarEdicion;
        private System.Windows.Forms.Label lRuta2;
    }
}