namespace panalbase
{
    partial class AmigosMostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmigosMostrar));
            this.lNombreAmigo = new System.Windows.Forms.Label();
            this.bntEliminarAmigo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnIrChat = new System.Windows.Forms.Button();
            this.notichat = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pbImgPerfilAmigo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPerfilAmigo)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombreAmigo
            // 
            this.lNombreAmigo.AutoSize = true;
            this.lNombreAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreAmigo.ForeColor = System.Drawing.Color.Black;
            this.lNombreAmigo.Location = new System.Drawing.Point(145, 15);
            this.lNombreAmigo.Name = "lNombreAmigo";
            this.lNombreAmigo.Size = new System.Drawing.Size(60, 24);
            this.lNombreAmigo.TabIndex = 1;
            this.lNombreAmigo.Text = "label1";
            // 
            // bntEliminarAmigo
            // 
            this.bntEliminarAmigo.BackColor = System.Drawing.Color.Firebrick;
            this.bntEliminarAmigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntEliminarAmigo.FlatAppearance.BorderSize = 0;
            this.bntEliminarAmigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntEliminarAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEliminarAmigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bntEliminarAmigo.Location = new System.Drawing.Point(412, 39);
            this.bntEliminarAmigo.Name = "bntEliminarAmigo";
            this.bntEliminarAmigo.Size = new System.Drawing.Size(110, 23);
            this.bntEliminarAmigo.TabIndex = 2;
            this.bntEliminarAmigo.Text = "ELIMINAR";
            this.bntEliminarAmigo.UseVisualStyleBackColor = false;
            this.bntEliminarAmigo.Click += new System.EventHandler(this.bntEliminarAmigo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(229)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.pbImgPerfilAmigo);
            this.panel1.Controls.Add(this.notichat);
            this.panel1.Controls.Add(this.BtnIrChat);
            this.panel1.Controls.Add(this.bntEliminarAmigo);
            this.panel1.Controls.Add(this.lNombreAmigo);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 110);
            this.panel1.TabIndex = 3;
            // 
            // BtnIrChat
            // 
            this.BtnIrChat.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnIrChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIrChat.FlatAppearance.BorderSize = 0;
            this.BtnIrChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIrChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIrChat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnIrChat.Location = new System.Drawing.Point(331, 39);
            this.BtnIrChat.Name = "BtnIrChat";
            this.BtnIrChat.Size = new System.Drawing.Size(75, 23);
            this.BtnIrChat.TabIndex = 3;
            this.BtnIrChat.Text = "CHAT";
            this.BtnIrChat.UseVisualStyleBackColor = false;
            this.BtnIrChat.Click += new System.EventHandler(this.BtnIrChat_Click);
            // 
            // notichat
            // 
            this.notichat.BackColor = System.Drawing.Color.SaddleBrown;
            this.notichat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.notichat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.notichat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.notichat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.notichat.FillColor = System.Drawing.Color.Red;
            this.notichat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.notichat.ForeColor = System.Drawing.Color.White;
            this.notichat.Location = new System.Drawing.Point(394, 39);
            this.notichat.Name = "notichat";
            this.notichat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.notichat.Size = new System.Drawing.Size(12, 15);
            this.notichat.TabIndex = 27;
            this.notichat.Visible = false;
            // 
            // pbImgPerfilAmigo
            // 
            this.pbImgPerfilAmigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbImgPerfilAmigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImgPerfilAmigo.Image = ((System.Drawing.Image)(resources.GetObject("pbImgPerfilAmigo.Image")));
            this.pbImgPerfilAmigo.ImageRotate = 0F;
            this.pbImgPerfilAmigo.Location = new System.Drawing.Point(47, 15);
            this.pbImgPerfilAmigo.Name = "pbImgPerfilAmigo";
            this.pbImgPerfilAmigo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbImgPerfilAmigo.Size = new System.Drawing.Size(92, 80);
            this.pbImgPerfilAmigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgPerfilAmigo.TabIndex = 28;
            this.pbImgPerfilAmigo.TabStop = false;
            // 
            // AmigosMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 127);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AmigosMostrar";
            this.Text = "AmigosMostrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPerfilAmigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bntEliminarAmigo;
        public System.Windows.Forms.Label lNombreAmigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnIrChat;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbImgPerfilAmigo;
        public Guna.UI2.WinForms.Guna2CircleButton notichat;
    }
}