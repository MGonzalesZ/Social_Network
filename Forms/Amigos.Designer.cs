namespace panalbase
{
    partial class Amigos
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
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.btnAniadirAmigos = new System.Windows.Forms.Button();
            this.tBBuscarAmigo = new System.Windows.Forms.TextBox();
            this.btnBuscarAmigo = new System.Windows.Forms.Button();
            this.panelAmigosMostrar = new System.Windows.Forms.Panel();
            this.btnAmigos = new System.Windows.Forms.Button();
            this.notisoli = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSolicitudes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolicitudes.FlatAppearance.BorderSize = 0;
            this.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitudes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSolicitudes.Location = new System.Drawing.Point(235, 387);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(101, 51);
            this.btnSolicitudes.TabIndex = 11;
            this.btnSolicitudes.Text = "Solicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = false;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
            // 
            // btnAniadirAmigos
            // 
            this.btnAniadirAmigos.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAniadirAmigos.FlatAppearance.BorderSize = 0;
            this.btnAniadirAmigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirAmigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirAmigos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAniadirAmigos.Location = new System.Drawing.Point(119, 386);
            this.btnAniadirAmigos.Name = "btnAniadirAmigos";
            this.btnAniadirAmigos.Size = new System.Drawing.Size(100, 51);
            this.btnAniadirAmigos.TabIndex = 10;
            this.btnAniadirAmigos.Text = "Añadir Amigos";
            this.btnAniadirAmigos.UseVisualStyleBackColor = false;
            this.btnAniadirAmigos.Visible = false;
            this.btnAniadirAmigos.Click += new System.EventHandler(this.btnAniadirAmigos_Click);
            // 
            // tBBuscarAmigo
            // 
            this.tBBuscarAmigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBBuscarAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBBuscarAmigo.Location = new System.Drawing.Point(12, 27);
            this.tBBuscarAmigo.Name = "tBBuscarAmigo";
            this.tBBuscarAmigo.Size = new System.Drawing.Size(415, 33);
            this.tBBuscarAmigo.TabIndex = 8;
            // 
            // btnBuscarAmigo
            // 
            this.btnBuscarAmigo.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBuscarAmigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAmigo.FlatAppearance.BorderSize = 0;
            this.btnBuscarAmigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAmigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarAmigo.Location = new System.Drawing.Point(433, 26);
            this.btnBuscarAmigo.Name = "btnBuscarAmigo";
            this.btnBuscarAmigo.Size = new System.Drawing.Size(152, 34);
            this.btnBuscarAmigo.TabIndex = 7;
            this.btnBuscarAmigo.Text = "Buscar amigo";
            this.btnBuscarAmigo.UseVisualStyleBackColor = false;
            this.btnBuscarAmigo.Click += new System.EventHandler(this.btnBuscarAmigo_Click);
            // 
            // panelAmigosMostrar
            // 
            this.panelAmigosMostrar.AutoScroll = true;
            this.panelAmigosMostrar.Location = new System.Drawing.Point(12, 81);
            this.panelAmigosMostrar.Name = "panelAmigosMostrar";
            this.panelAmigosMostrar.Size = new System.Drawing.Size(573, 300);
            this.panelAmigosMostrar.TabIndex = 12;
            // 
            // btnAmigos
            // 
            this.btnAmigos.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAmigos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmigos.Enabled = false;
            this.btnAmigos.FlatAppearance.BorderSize = 0;
            this.btnAmigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmigos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAmigos.Location = new System.Drawing.Point(12, 387);
            this.btnAmigos.Name = "btnAmigos";
            this.btnAmigos.Size = new System.Drawing.Size(101, 51);
            this.btnAmigos.TabIndex = 14;
            this.btnAmigos.Text = "Amigos";
            this.btnAmigos.UseVisualStyleBackColor = false;
            this.btnAmigos.Visible = false;
            this.btnAmigos.Click += new System.EventHandler(this.btnAmigos_Click);
            // 
            // notisoli
            // 
            this.notisoli.BackColor = System.Drawing.Color.SaddleBrown;
            this.notisoli.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.notisoli.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.notisoli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.notisoli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.notisoli.FillColor = System.Drawing.Color.Red;
            this.notisoli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.notisoli.ForeColor = System.Drawing.Color.White;
            this.notisoli.Location = new System.Drawing.Point(313, 387);
            this.notisoli.Name = "notisoli";
            this.notisoli.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.notisoli.Size = new System.Drawing.Size(23, 21);
            this.notisoli.TabIndex = 28;
            this.notisoli.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Amigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(597, 449);
            this.Controls.Add(this.notisoli);
            this.Controls.Add(this.btnAmigos);
            this.Controls.Add(this.panelAmigosMostrar);
            this.Controls.Add(this.btnSolicitudes);
            this.Controls.Add(this.btnAniadirAmigos);
            this.Controls.Add(this.tBBuscarAmigo);
            this.Controls.Add(this.btnBuscarAmigo);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Amigos";
            this.Text = "Amigos";
            this.Load += new System.EventHandler(this.Amigos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Button btnAniadirAmigos;
        private System.Windows.Forms.TextBox tBBuscarAmigo;
        private System.Windows.Forms.Button btnBuscarAmigo;
        private System.Windows.Forms.Panel panelAmigosMostrar;
        private System.Windows.Forms.Button btnAmigos;
        private Guna.UI2.WinForms.Guna2CircleButton notisoli;
        public System.Windows.Forms.Timer timer1;
    }
}