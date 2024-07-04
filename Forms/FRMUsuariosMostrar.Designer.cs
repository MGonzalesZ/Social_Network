namespace panalbase
{
    partial class FRMUsuariosMostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMUsuariosMostrar));
            this.btnAccionUsu = new System.Windows.Forms.Button();
            this.lCorreoUsu = new System.Windows.Forms.Label();
            this.lNombreUsu = new System.Windows.Forms.Label();
            this.pbImgPerfilUsu = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPerfilUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccionUsu
            // 
            this.btnAccionUsu.AutoSize = true;
            this.btnAccionUsu.BackColor = System.Drawing.Color.Peru;
            this.btnAccionUsu.FlatAppearance.BorderSize = 0;
            this.btnAccionUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccionUsu.Location = new System.Drawing.Point(314, 48);
            this.btnAccionUsu.Name = "btnAccionUsu";
            this.btnAccionUsu.Size = new System.Drawing.Size(101, 35);
            this.btnAccionUsu.TabIndex = 11;
            this.btnAccionUsu.Text = "button1";
            this.btnAccionUsu.UseVisualStyleBackColor = false;
            this.btnAccionUsu.Click += new System.EventHandler(this.btnAccionUsu_Click);
            // 
            // lCorreoUsu
            // 
            this.lCorreoUsu.AutoSize = true;
            this.lCorreoUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCorreoUsu.Location = new System.Drawing.Point(115, 63);
            this.lCorreoUsu.Name = "lCorreoUsu";
            this.lCorreoUsu.Size = new System.Drawing.Size(51, 20);
            this.lCorreoUsu.TabIndex = 10;
            this.lCorreoUsu.Text = "label2";
            // 
            // lNombreUsu
            // 
            this.lNombreUsu.AutoSize = true;
            this.lNombreUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUsu.Location = new System.Drawing.Point(115, 34);
            this.lNombreUsu.Name = "lNombreUsu";
            this.lNombreUsu.Size = new System.Drawing.Size(51, 20);
            this.lNombreUsu.TabIndex = 9;
            this.lNombreUsu.Text = "label1";
            // 
            // pbImgPerfilUsu
            // 
            this.pbImgPerfilUsu.Image = ((System.Drawing.Image)(resources.GetObject("pbImgPerfilUsu.Image")));
            this.pbImgPerfilUsu.ImageRotate = 0F;
            this.pbImgPerfilUsu.Location = new System.Drawing.Point(12, 12);
            this.pbImgPerfilUsu.Name = "pbImgPerfilUsu";
            this.pbImgPerfilUsu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbImgPerfilUsu.Size = new System.Drawing.Size(100, 102);
            this.pbImgPerfilUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgPerfilUsu.TabIndex = 13;
            this.pbImgPerfilUsu.TabStop = false;
            // 
            // FRMUsuariosMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(427, 128);
            this.Controls.Add(this.pbImgPerfilUsu);
            this.Controls.Add(this.btnAccionUsu);
            this.Controls.Add(this.lCorreoUsu);
            this.Controls.Add(this.lNombreUsu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMUsuariosMostrar";
            this.Text = "FRMUsuariosMostrar";
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPerfilUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAccionUsu;
        public System.Windows.Forms.Label lCorreoUsu;
        public System.Windows.Forms.Label lNombreUsu;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbImgPerfilUsu;
    }
}