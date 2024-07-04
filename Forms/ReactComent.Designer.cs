namespace panalbase
{
    partial class ReactComent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReactComent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreact = new System.Windows.Forms.Label();
            this.lblCnombre = new System.Windows.Forms.Label();
            this.pbCusuario = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.pbCusuario);
            this.panel1.Controls.Add(this.lblCreact);
            this.panel1.Controls.Add(this.lblCnombre);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 59);
            this.panel1.TabIndex = 1;
            // 
            // lblCreact
            // 
            this.lblCreact.AutoSize = true;
            this.lblCreact.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreact.Location = new System.Drawing.Point(157, 7);
            this.lblCreact.Name = "lblCreact";
            this.lblCreact.Size = new System.Drawing.Size(46, 31);
            this.lblCreact.TabIndex = 2;
            this.lblCreact.Text = "☺";
            // 
            // lblCnombre
            // 
            this.lblCnombre.AutoSize = true;
            this.lblCnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnombre.Location = new System.Drawing.Point(55, 7);
            this.lblCnombre.Name = "lblCnombre";
            this.lblCnombre.Size = new System.Drawing.Size(85, 29);
            this.lblCnombre.TabIndex = 1;
            this.lblCnombre.Text = "label1";
            // 
            // pbCusuario
            // 
            this.pbCusuario.Image = ((System.Drawing.Image)(resources.GetObject("pbCusuario.Image")));
            this.pbCusuario.ImageRotate = 0F;
            this.pbCusuario.Location = new System.Drawing.Point(9, 9);
            this.pbCusuario.Name = "pbCusuario";
            this.pbCusuario.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbCusuario.Size = new System.Drawing.Size(40, 40);
            this.pbCusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCusuario.TabIndex = 4;
            this.pbCusuario.TabStop = false;
            // 
            // ReactComent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 65);
            this.Controls.Add(this.panel1);
            this.Name = "ReactComent";
            this.Text = "ReactComent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCusuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblCreact;
        public System.Windows.Forms.Label lblCnombre;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbCusuario;
    }
}