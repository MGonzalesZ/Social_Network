
namespace panalbase
{
    partial class PaginaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccesoChat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblnombreuu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.PanelPublicaciones = new System.Windows.Forms.Panel();
            this.btnEliminarPubl = new System.Windows.Forms.Button();
            this.btnVerPubl = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.noti = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.noti);
            this.panel1.Controls.Add(this.btnAccesoChat);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblnombreuu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dgView);
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 735);
            this.panel1.TabIndex = 0;
            // 
            // btnAccesoChat
            // 
            this.btnAccesoChat.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAccesoChat.Enabled = false;
            this.btnAccesoChat.FlatAppearance.BorderSize = 0;
            this.btnAccesoChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccesoChat.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccesoChat.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAccesoChat.Location = new System.Drawing.Point(14, 656);
            this.btnAccesoChat.Name = "btnAccesoChat";
            this.btnAccesoChat.Size = new System.Drawing.Size(131, 51);
            this.btnAccesoChat.TabIndex = 23;
            this.btnAccesoChat.Text = "IR AL CHAT";
            this.btnAccesoChat.UseVisualStyleBackColor = false;
            this.btnAccesoChat.Visible = false;
            this.btnAccesoChat.Click += new System.EventHandler(this.btnAccesoChat_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(22, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 187);
            this.panel3.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblnombreuu
            // 
            this.lblnombreuu.AutoSize = true;
            this.lblnombreuu.BackColor = System.Drawing.Color.Transparent;
            this.lblnombreuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreuu.Location = new System.Drawing.Point(19, 266);
            this.lblnombreuu.Name = "lblnombreuu";
            this.lblnombreuu.Size = new System.Drawing.Size(138, 20);
            this.lblnombreuu.TabIndex = 22;
            this.lblnombreuu.Text = "Nombre Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "PANAL";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnEditar.Location = new System.Drawing.Point(14, 406);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(131, 54);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar Perfil";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCerrarSesion.Location = new System.Drawing.Point(14, 526);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(131, 60);
            this.btnCerrarSesion.TabIndex = 19;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SaddleBrown;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(97, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 54);
            this.button2.TabIndex = 0;
            this.button2.Text = "Ver Amigos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.GridColor = System.Drawing.Color.Orange;
            this.dgView.Location = new System.Drawing.Point(74, 656);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 51;
            this.dgView.Size = new System.Drawing.Size(16, 21);
            this.dgView.TabIndex = 11;
            this.dgView.Visible = false;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(170)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnBuscarUsuario);
            this.panel2.Controls.Add(this.PanelPublicaciones);
            this.panel2.Controls.Add(this.btnEliminarPubl);
            this.panel2.Controls.Add(this.btnVerPubl);
            this.panel2.Controls.Add(this.btnPublicar);
            this.panel2.Location = new System.Drawing.Point(251, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 735);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "PUBLICACIONES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Gold;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(279, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 39);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.Gold;
            this.btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(547, 12);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(92, 43);
            this.btnBuscarUsuario.TabIndex = 21;
            this.btnBuscarUsuario.Text = "Buscar Usuario";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // PanelPublicaciones
            // 
            this.PanelPublicaciones.AutoScroll = true;
            this.PanelPublicaciones.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.PanelPublicaciones.Location = new System.Drawing.Point(15, 83);
            this.PanelPublicaciones.Name = "PanelPublicaciones";
            this.PanelPublicaciones.Size = new System.Drawing.Size(624, 638);
            this.PanelPublicaciones.TabIndex = 19;
            // 
            // btnEliminarPubl
            // 
            this.btnEliminarPubl.BackColor = System.Drawing.Color.Gold;
            this.btnEliminarPubl.FlatAppearance.BorderSize = 0;
            this.btnEliminarPubl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPubl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPubl.Location = new System.Drawing.Point(196, 12);
            this.btnEliminarPubl.Name = "btnEliminarPubl";
            this.btnEliminarPubl.Size = new System.Drawing.Size(77, 38);
            this.btnEliminarPubl.TabIndex = 13;
            this.btnEliminarPubl.Text = "Eliminar";
            this.btnEliminarPubl.UseVisualStyleBackColor = false;
            this.btnEliminarPubl.Visible = false;
            this.btnEliminarPubl.Click += new System.EventHandler(this.btnEliminarPubl_Click);
            // 
            // btnVerPubl
            // 
            this.btnVerPubl.BackColor = System.Drawing.Color.Gold;
            this.btnVerPubl.FlatAppearance.BorderSize = 0;
            this.btnVerPubl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPubl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPubl.Location = new System.Drawing.Point(113, 12);
            this.btnVerPubl.Name = "btnVerPubl";
            this.btnVerPubl.Size = new System.Drawing.Size(77, 39);
            this.btnVerPubl.TabIndex = 12;
            this.btnVerPubl.Text = "Ver";
            this.btnVerPubl.UseVisualStyleBackColor = false;
            this.btnVerPubl.Visible = false;
            this.btnVerPubl.Click += new System.EventHandler(this.btnVerPubl_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.Color.Gold;
            this.btnPublicar.FlatAppearance.BorderSize = 0;
            this.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.Location = new System.Drawing.Point(13, 12);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(87, 39);
            this.btnPublicar.TabIndex = 0;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(panalbase.Program);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // noti
            // 
            this.noti.BackColor = System.Drawing.Color.SaddleBrown;
            this.noti.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.noti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.noti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.noti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.noti.FillColor = System.Drawing.Color.Red;
            this.noti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.noti.ForeColor = System.Drawing.Color.White;
            this.noti.Location = new System.Drawing.Point(205, 466);
            this.noti.Name = "noti";
            this.noti.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.noti.Size = new System.Drawing.Size(23, 22);
            this.noti.TabIndex = 24;
            this.noti.Visible = false;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaginaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.iniciarDatos);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Button btnVerPubl;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button btnEliminarPubl;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel PanelPublicaciones;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblnombreuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccesoChat;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleButton noti;
    }
}