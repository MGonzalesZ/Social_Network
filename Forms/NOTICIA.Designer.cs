namespace Prueba_de_panel_de_noticias
{
    partial class NOTICIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NOTICIA));
            this.LabelAutor = new System.Windows.Forms.Label();
            this.btnpr = new System.Windows.Forms.Button();
            this.btnComentario = new System.Windows.Forms.Button();
            this.contreact = new System.Windows.Forms.FlowLayoutPanel();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelcom = new System.Windows.Forms.Panel();
            this.btncoment = new System.Windows.Forms.Button();
            this.btncomx = new System.Windows.Forms.Button();
            this.lblcomususn = new System.Windows.Forms.Label();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.btnEditarPublicacion = new System.Windows.Forms.Button();
            this.btnEliminarPublicacion = new System.Windows.Forms.Button();
            this.panelInferiorNoticia = new System.Windows.Forms.Panel();
            this.panelSuperiorNoticia = new System.Windows.Forms.Panel();
            this.pbNoticia = new System.Windows.Forms.PictureBox();
            this.panelDeImagen = new System.Windows.Forms.Panel();
            this.pbPerfilPubl = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.contreact.SuspendLayout();
            this.panelcom.SuspendLayout();
            this.panelInferiorNoticia.SuspendLayout();
            this.panelSuperiorNoticia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoticia)).BeginInit();
            this.panelDeImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilPubl)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAutor
            // 
            this.LabelAutor.AutoSize = true;
            this.LabelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAutor.Location = new System.Drawing.Point(55, 6);
            this.LabelAutor.Name = "LabelAutor";
            this.LabelAutor.Size = new System.Drawing.Size(53, 20);
            this.LabelAutor.TabIndex = 0;
            this.LabelAutor.Text = "Autor";
            // 
            // btnpr
            // 
            this.btnpr.BackColor = System.Drawing.Color.White;
            this.btnpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpr.Location = new System.Drawing.Point(6, 67);
            this.btnpr.Name = "btnpr";
            this.btnpr.Size = new System.Drawing.Size(75, 52);
            this.btnpr.TabIndex = 2;
            this.btnpr.Text = "☺";
            this.btnpr.UseVisualStyleBackColor = false;
            // 
            // btnComentario
            // 
            this.btnComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(36)))));
            this.btnComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComentario.Location = new System.Drawing.Point(81, 67);
            this.btnComentario.Name = "btnComentario";
            this.btnComentario.Size = new System.Drawing.Size(501, 52);
            this.btnComentario.TabIndex = 3;
            this.btnComentario.Text = "Comentar";
            this.btnComentario.UseVisualStyleBackColor = false;
            // 
            // contreact
            // 
            this.contreact.BackColor = System.Drawing.Color.Transparent;
            this.contreact.Controls.Add(this.btn2);
            this.contreact.Controls.Add(this.btn1);
            this.contreact.Controls.Add(this.btn3);
            this.contreact.Location = new System.Drawing.Point(3, 3);
            this.contreact.Name = "contreact";
            this.contreact.Size = new System.Drawing.Size(245, 60);
            this.contreact.TabIndex = 4;
            this.contreact.Visible = false;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Chocolate;
            this.btn2.Location = new System.Drawing.Point(3, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 52);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "♪";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(84, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 52);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "☺";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Red;
            this.btn3.Location = new System.Drawing.Point(165, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 52);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "♥";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 42);
            this.textBox1.TabIndex = 0;
            // 
            // panelcom
            // 
            this.panelcom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(165)))));
            this.panelcom.Controls.Add(this.btncoment);
            this.panelcom.Controls.Add(this.btncomx);
            this.panelcom.Controls.Add(this.lblcomususn);
            this.panelcom.Controls.Add(this.textBox1);
            this.panelcom.Location = new System.Drawing.Point(181, 0);
            this.panelcom.Name = "panelcom";
            this.panelcom.Size = new System.Drawing.Size(405, 111);
            this.panelcom.TabIndex = 5;
            this.panelcom.Visible = false;
            // 
            // btncoment
            // 
            this.btncoment.Location = new System.Drawing.Point(16, 77);
            this.btncoment.Name = "btncoment";
            this.btncoment.Size = new System.Drawing.Size(381, 28);
            this.btncoment.TabIndex = 3;
            this.btncoment.Text = "Comentar";
            this.btncoment.UseVisualStyleBackColor = true;
            this.btncoment.Click += new System.EventHandler(this.btncoment_Click);
            // 
            // btncomx
            // 
            this.btncomx.BackColor = System.Drawing.Color.Yellow;
            this.btncomx.Location = new System.Drawing.Point(371, 3);
            this.btncomx.Name = "btncomx";
            this.btncomx.Size = new System.Drawing.Size(26, 23);
            this.btncomx.TabIndex = 2;
            this.btncomx.Text = "x";
            this.btncomx.UseVisualStyleBackColor = false;
            this.btncomx.Click += new System.EventHandler(this.btncomx_Click);
            // 
            // lblcomususn
            // 
            this.lblcomususn.AutoSize = true;
            this.lblcomususn.Location = new System.Drawing.Point(13, 13);
            this.lblcomususn.Name = "lblcomususn";
            this.lblcomususn.Size = new System.Drawing.Size(23, 13);
            this.lblcomususn.TabIndex = 1;
            this.lblcomususn.Text = "null";
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescripcion.Location = new System.Drawing.Point(11, 49);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(314, 24);
            this.LabelDescripcion.TabIndex = 6;
            this.LabelDescripcion.Text = "descripcion descripcion descripcion";
            // 
            // btnEditarPublicacion
            // 
            this.btnEditarPublicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditarPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPublicacion.Location = new System.Drawing.Point(405, 6);
            this.btnEditarPublicacion.Name = "btnEditarPublicacion";
            this.btnEditarPublicacion.Size = new System.Drawing.Size(78, 40);
            this.btnEditarPublicacion.TabIndex = 7;
            this.btnEditarPublicacion.Text = "Editar";
            this.btnEditarPublicacion.UseVisualStyleBackColor = false;
            this.btnEditarPublicacion.Click += new System.EventHandler(this.btnEditarPublicacion_Click);
            // 
            // btnEliminarPublicacion
            // 
            this.btnEliminarPublicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminarPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPublicacion.Location = new System.Drawing.Point(489, 6);
            this.btnEliminarPublicacion.Name = "btnEliminarPublicacion";
            this.btnEliminarPublicacion.Size = new System.Drawing.Size(82, 40);
            this.btnEliminarPublicacion.TabIndex = 8;
            this.btnEliminarPublicacion.Text = "Eliminar";
            this.btnEliminarPublicacion.UseVisualStyleBackColor = false;
            this.btnEliminarPublicacion.Click += new System.EventHandler(this.btnEliminarPublicacion_Click);
            // 
            // panelInferiorNoticia
            // 
            this.panelInferiorNoticia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(165)))));
            this.panelInferiorNoticia.Controls.Add(this.panelcom);
            this.panelInferiorNoticia.Controls.Add(this.contreact);
            this.panelInferiorNoticia.Controls.Add(this.btnComentario);
            this.panelInferiorNoticia.Controls.Add(this.btnpr);
            this.panelInferiorNoticia.Location = new System.Drawing.Point(7, 431);
            this.panelInferiorNoticia.Name = "panelInferiorNoticia";
            this.panelInferiorNoticia.Size = new System.Drawing.Size(589, 129);
            this.panelInferiorNoticia.TabIndex = 10;
            // 
            // panelSuperiorNoticia
            // 
            this.panelSuperiorNoticia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(165)))));
            this.panelSuperiorNoticia.Controls.Add(this.pbPerfilPubl);
            this.panelSuperiorNoticia.Controls.Add(this.btnEliminarPublicacion);
            this.panelSuperiorNoticia.Controls.Add(this.btnEditarPublicacion);
            this.panelSuperiorNoticia.Controls.Add(this.LabelDescripcion);
            this.panelSuperiorNoticia.Controls.Add(this.LabelAutor);
            this.panelSuperiorNoticia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperiorNoticia.Location = new System.Drawing.Point(0, 0);
            this.panelSuperiorNoticia.Name = "panelSuperiorNoticia";
            this.panelSuperiorNoticia.Size = new System.Drawing.Size(610, 84);
            this.panelSuperiorNoticia.TabIndex = 11;
            // 
            // pbNoticia
            // 
            this.pbNoticia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(165)))));
            this.pbNoticia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbNoticia.Location = new System.Drawing.Point(3, 3);
            this.pbNoticia.Name = "pbNoticia";
            this.pbNoticia.Size = new System.Drawing.Size(583, 396);
            this.pbNoticia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNoticia.TabIndex = 1;
            this.pbNoticia.TabStop = false;
            // 
            // panelDeImagen
            // 
            this.panelDeImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(165)))));
            this.panelDeImagen.Controls.Add(this.pbNoticia);
            this.panelDeImagen.Location = new System.Drawing.Point(9, 90);
            this.panelDeImagen.Name = "panelDeImagen";
            this.panelDeImagen.Size = new System.Drawing.Size(589, 405);
            this.panelDeImagen.TabIndex = 9;
            // 
            // pbPerfilPubl
            // 
            this.pbPerfilPubl.Image = ((System.Drawing.Image)(resources.GetObject("pbPerfilPubl.Image")));
            this.pbPerfilPubl.ImageRotate = 0F;
            this.pbPerfilPubl.Location = new System.Drawing.Point(13, 6);
            this.pbPerfilPubl.Name = "pbPerfilPubl";
            this.pbPerfilPubl.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbPerfilPubl.Size = new System.Drawing.Size(40, 40);
            this.pbPerfilPubl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfilPubl.TabIndex = 12;
            this.pbPerfilPubl.TabStop = false;
            // 
            // NOTICIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 562);
            this.Controls.Add(this.panelInferiorNoticia);
            this.Controls.Add(this.panelSuperiorNoticia);
            this.Controls.Add(this.panelDeImagen);
            this.Name = "NOTICIA";
            this.Text = "NOTICIA";
            this.contreact.ResumeLayout(false);
            this.panelcom.ResumeLayout(false);
            this.panelcom.PerformLayout();
            this.panelInferiorNoticia.ResumeLayout(false);
            this.panelSuperiorNoticia.ResumeLayout(false);
            this.panelSuperiorNoticia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoticia)).EndInit();
            this.panelDeImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilPubl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LabelAutor;
        private System.Windows.Forms.Button btnComentario;
        private System.Windows.Forms.FlowLayoutPanel contreact;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btncoment;
        private System.Windows.Forms.Button btncomx;
        public System.Windows.Forms.Label LabelDescripcion;
        public System.Windows.Forms.Button btnEditarPublicacion;
        public System.Windows.Forms.Button btnEliminarPublicacion;
        public System.Windows.Forms.Panel panelInferiorNoticia;
        public System.Windows.Forms.Panel panelSuperiorNoticia;
        public System.Windows.Forms.Button btnpr;
        public System.Windows.Forms.Button btn1;
        public System.Windows.Forms.Button btn2;
        public System.Windows.Forms.Button btn3;
        public System.Windows.Forms.Label lblcomususn;
        public System.Windows.Forms.PictureBox pbNoticia;
        public System.Windows.Forms.Panel panelDeImagen;
        public System.Windows.Forms.Panel panelcom;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbPerfilPubl;
    }
}