
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
            this.txtPubl = new System.Windows.Forms.TextBox();
            this.pbImagPubl = new System.Windows.Forms.PictureBox();
            this.btnAgrImag = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuitarImag = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.labelRuta = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagPubl)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPubl
            // 
            this.txtPubl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPubl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPubl.Location = new System.Drawing.Point(12, 39);
            this.txtPubl.Multiline = true;
            this.txtPubl.Name = "txtPubl";
            this.txtPubl.Size = new System.Drawing.Size(412, 72);
            this.txtPubl.TabIndex = 1;
            // 
            // pbImagPubl
            // 
            this.pbImagPubl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagPubl.Location = new System.Drawing.Point(29, 143);
            this.pbImagPubl.Name = "pbImagPubl";
            this.pbImagPubl.Size = new System.Drawing.Size(555, 202);
            this.pbImagPubl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagPubl.TabIndex = 2;
            this.pbImagPubl.TabStop = false;
            // 
            // btnAgrImag
            // 
            this.btnAgrImag.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAgrImag.FlatAppearance.BorderSize = 0;
            this.btnAgrImag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrImag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrImag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgrImag.Location = new System.Drawing.Point(438, 30);
            this.btnAgrImag.Name = "btnAgrImag";
            this.btnAgrImag.Size = new System.Drawing.Size(146, 43);
            this.btnAgrImag.TabIndex = 3;
            this.btnAgrImag.Text = "Agregar Imagen";
            this.btnAgrImag.UseVisualStyleBackColor = false;
            this.btnAgrImag.Click += new System.EventHandler(this.btnAgrImag_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Publicacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "añadir imagen";
            // 
            // btnQuitarImag
            // 
            this.btnQuitarImag.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnQuitarImag.FlatAppearance.BorderSize = 0;
            this.btnQuitarImag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarImag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarImag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitarImag.Location = new System.Drawing.Point(436, 83);
            this.btnQuitarImag.Name = "btnQuitarImag";
            this.btnQuitarImag.Size = new System.Drawing.Size(146, 43);
            this.btnQuitarImag.TabIndex = 7;
            this.btnQuitarImag.Text = "Quitar Imagen";
            this.btnQuitarImag.UseVisualStyleBackColor = false;
            this.btnQuitarImag.Click += new System.EventHandler(this.btnQuitarImag_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnPublicar.FlatAppearance.BorderSize = 0;
            this.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPublicar.Location = new System.Drawing.Point(239, 351);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(146, 43);
            this.btnPublicar.TabIndex = 8;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.Location = new System.Drawing.Point(26, 349);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(0, 13);
            this.labelRuta.TabIndex = 9;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(137)))), ((int)(((byte)(48)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegresar.Location = new System.Drawing.Point(29, 351);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 43);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // CrearPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(603, 423);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.labelRuta);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnQuitarImag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgrImag);
            this.Controls.Add(this.pbImagPubl);
            this.Controls.Add(this.txtPubl);
            this.Name = "CrearPublicacion";
            this.Text = "CrearPublicacion";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagPubl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPubl;
        private System.Windows.Forms.PictureBox pbImagPubl;
        private System.Windows.Forms.Button btnAgrImag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuitarImag;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.Button btnRegresar;
    }
}