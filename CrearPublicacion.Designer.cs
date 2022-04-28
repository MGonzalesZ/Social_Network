
namespace panalbase
{
    partial class CrearPublicacion
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
            this.txtTituloPubl = new System.Windows.Forms.TextBox();
            this.txtPubl = new System.Windows.Forms.TextBox();
            this.pbImagPubl = new System.Windows.Forms.PictureBox();
            this.btnAgrImag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuitarImag = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.labelRuta = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagPubl)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTituloPubl
            // 
            this.txtTituloPubl.Location = new System.Drawing.Point(39, 40);
            this.txtTituloPubl.Name = "txtTituloPubl";
            this.txtTituloPubl.Size = new System.Drawing.Size(426, 20);
            this.txtTituloPubl.TabIndex = 0;
            // 
            // txtPubl
            // 
            this.txtPubl.Location = new System.Drawing.Point(39, 93);
            this.txtPubl.Name = "txtPubl";
            this.txtPubl.Size = new System.Drawing.Size(637, 20);
            this.txtPubl.TabIndex = 1;
            // 
            // pbImagPubl
            // 
            this.pbImagPubl.Location = new System.Drawing.Point(42, 145);
            this.pbImagPubl.Name = "pbImagPubl";
            this.pbImagPubl.Size = new System.Drawing.Size(555, 202);
            this.pbImagPubl.TabIndex = 2;
            this.pbImagPubl.TabStop = false;
            // 
            // btnAgrImag
            // 
            this.btnAgrImag.BackColor = System.Drawing.Color.Orange;
            this.btnAgrImag.Location = new System.Drawing.Point(618, 145);
            this.btnAgrImag.Name = "btnAgrImag";
            this.btnAgrImag.Size = new System.Drawing.Size(146, 43);
            this.btnAgrImag.TabIndex = 3;
            this.btnAgrImag.Text = "agregar imagen";
            this.btnAgrImag.UseVisualStyleBackColor = false;
            this.btnAgrImag.Click += new System.EventHandler(this.btnAgrImag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "titulo de la publicacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "descripcion de la publicacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "añadir imagen";
            // 
            // btnQuitarImag
            // 
            this.btnQuitarImag.BackColor = System.Drawing.Color.Orange;
            this.btnQuitarImag.Location = new System.Drawing.Point(618, 194);
            this.btnQuitarImag.Name = "btnQuitarImag";
            this.btnQuitarImag.Size = new System.Drawing.Size(146, 43);
            this.btnQuitarImag.TabIndex = 7;
            this.btnQuitarImag.Text = "quitar imagen";
            this.btnQuitarImag.UseVisualStyleBackColor = false;
            this.btnQuitarImag.Click += new System.EventHandler(this.btnQuitarImag_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.Color.Orange;
            this.btnPublicar.Location = new System.Drawing.Point(319, 384);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(146, 43);
            this.btnPublicar.TabIndex = 8;
            this.btnPublicar.Text = "publicar";
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.Location = new System.Drawing.Point(47, 351);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(0, 13);
            this.labelRuta.TabIndex = 9;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Orange;
            this.btnRegresar.Location = new System.Drawing.Point(42, 389);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(127, 33);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // CrearPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.labelRuta);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnQuitarImag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgrImag);
            this.Controls.Add(this.pbImagPubl);
            this.Controls.Add(this.txtPubl);
            this.Controls.Add(this.txtTituloPubl);
            this.Name = "CrearPublicacion";
            this.Text = "CrearPublicacion";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagPubl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTituloPubl;
        private System.Windows.Forms.TextBox txtPubl;
        private System.Windows.Forms.PictureBox pbImagPubl;
        private System.Windows.Forms.Button btnAgrImag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuitarImag;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.Button btnRegresar;
    }
}