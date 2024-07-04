namespace panalbase
{
    partial class Reactmostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reactmostrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMreact = new System.Windows.Forms.Label();
            this.lblMnombre = new System.Windows.Forms.Label();
            this.pbMusuario = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.pbMusuario);
            this.panel1.Controls.Add(this.lblMreact);
            this.panel1.Controls.Add(this.lblMnombre);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 59);
            this.panel1.TabIndex = 0;
            // 
            // lblMreact
            // 
            this.lblMreact.AutoSize = true;
            this.lblMreact.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMreact.Location = new System.Drawing.Point(163, 16);
            this.lblMreact.Name = "lblMreact";
            this.lblMreact.Size = new System.Drawing.Size(46, 31);
            this.lblMreact.TabIndex = 2;
            this.lblMreact.Text = "☺";
            // 
            // lblMnombre
            // 
            this.lblMnombre.AutoSize = true;
            this.lblMnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnombre.Location = new System.Drawing.Point(55, 7);
            this.lblMnombre.Name = "lblMnombre";
            this.lblMnombre.Size = new System.Drawing.Size(85, 29);
            this.lblMnombre.TabIndex = 1;
            this.lblMnombre.Text = "label1";
            // 
            // pbMusuario
            // 
            this.pbMusuario.Image = ((System.Drawing.Image)(resources.GetObject("pbMusuario.Image")));
            this.pbMusuario.ImageRotate = 0F;
            this.pbMusuario.Location = new System.Drawing.Point(11, 10);
            this.pbMusuario.Name = "pbMusuario";
            this.pbMusuario.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbMusuario.Size = new System.Drawing.Size(40, 40);
            this.pbMusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMusuario.TabIndex = 3;
            this.pbMusuario.TabStop = false;
            // 
            // Reactmostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 66);
            this.Controls.Add(this.panel1);
            this.Name = "Reactmostrar";
            this.Text = "Reactmostrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblMreact;
        public System.Windows.Forms.Label lblMnombre;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbMusuario;
    }
}