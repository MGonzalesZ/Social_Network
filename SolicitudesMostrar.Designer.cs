namespace panalbase
{
    partial class SolicitudesMostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudesMostrar));
            this.btnAceptarSoli = new System.Windows.Forms.Button();
            this.btnRechazarSoli = new System.Windows.Forms.Button();
            this.lNombreSoli = new System.Windows.Forms.Label();
            this.pbImgPerfilSoli = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPerfilSoli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarSoli
            // 
            this.btnAceptarSoli.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAceptarSoli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarSoli.FlatAppearance.BorderSize = 0;
            this.btnAceptarSoli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarSoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarSoli.Location = new System.Drawing.Point(332, 32);
            this.btnAceptarSoli.Name = "btnAceptarSoli";
            this.btnAceptarSoli.Size = new System.Drawing.Size(98, 32);
            this.btnAceptarSoli.TabIndex = 1;
            this.btnAceptarSoli.Text = "ACEPTAR";
            this.btnAceptarSoli.UseVisualStyleBackColor = false;
            this.btnAceptarSoli.Click += new System.EventHandler(this.btnAceptarSoli_Click);
            // 
            // btnRechazarSoli
            // 
            this.btnRechazarSoli.BackColor = System.Drawing.Color.Chocolate;
            this.btnRechazarSoli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechazarSoli.FlatAppearance.BorderSize = 0;
            this.btnRechazarSoli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazarSoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarSoli.Location = new System.Drawing.Point(436, 32);
            this.btnRechazarSoli.Name = "btnRechazarSoli";
            this.btnRechazarSoli.Size = new System.Drawing.Size(98, 32);
            this.btnRechazarSoli.TabIndex = 2;
            this.btnRechazarSoli.Text = "RECHAZAR";
            this.btnRechazarSoli.UseVisualStyleBackColor = false;
            this.btnRechazarSoli.Click += new System.EventHandler(this.btnRechazarSoli_Click);
            // 
            // lNombreSoli
            // 
            this.lNombreSoli.AutoSize = true;
            this.lNombreSoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreSoli.Location = new System.Drawing.Point(145, 37);
            this.lNombreSoli.Name = "lNombreSoli";
            this.lNombreSoli.Size = new System.Drawing.Size(51, 20);
            this.lNombreSoli.TabIndex = 3;
            this.lNombreSoli.Text = "label1";
            // 
            // pbImgPerfilSoli
            // 
            this.pbImgPerfilSoli.Image = ((System.Drawing.Image)(resources.GetObject("pbImgPerfilSoli.Image")));
            this.pbImgPerfilSoli.ImageRotate = 0F;
            this.pbImgPerfilSoli.Location = new System.Drawing.Point(50, 8);
            this.pbImgPerfilSoli.Name = "pbImgPerfilSoli";
            this.pbImgPerfilSoli.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbImgPerfilSoli.Size = new System.Drawing.Size(89, 80);
            this.pbImgPerfilSoli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgPerfilSoli.TabIndex = 14;
            this.pbImgPerfilSoli.TabStop = false;
            // 
            // SolicitudesMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(634, 100);
            this.Controls.Add(this.pbImgPerfilSoli);
            this.Controls.Add(this.lNombreSoli);
            this.Controls.Add(this.btnRechazarSoli);
            this.Controls.Add(this.btnAceptarSoli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolicitudesMostrar";
            this.Text = "SolicitudesMostrar";
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPerfilSoli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptarSoli;
        private System.Windows.Forms.Button btnRechazarSoli;
        public System.Windows.Forms.Label lNombreSoli;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbImgPerfilSoli;
    }
}