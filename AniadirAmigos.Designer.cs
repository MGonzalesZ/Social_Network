namespace panalbase
{
    partial class AniadirAmigos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviarSoli = new System.Windows.Forms.Button();
            this.tBBuscarUsuarios = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuarios = new System.Windows.Forms.Button();
            this.dGVUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Usuarios encontrados:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // btnEnviarSoli
            // 
            this.btnEnviarSoli.BackColor = System.Drawing.Color.Orange;
            this.btnEnviarSoli.Location = new System.Drawing.Point(133, 321);
            this.btnEnviarSoli.Name = "btnEnviarSoli";
            this.btnEnviarSoli.Size = new System.Drawing.Size(116, 45);
            this.btnEnviarSoli.TabIndex = 11;
            this.btnEnviarSoli.Text = "EnviarSolicitud";
            this.btnEnviarSoli.UseVisualStyleBackColor = false;
            this.btnEnviarSoli.Click += new System.EventHandler(this.btnEnviarSoli_Click);
            // 
            // tBBuscarUsuarios
            // 
            this.tBBuscarUsuarios.Location = new System.Drawing.Point(66, 33);
            this.tBBuscarUsuarios.Name = "tBBuscarUsuarios";
            this.tBBuscarUsuarios.Size = new System.Drawing.Size(100, 20);
            this.tBBuscarUsuarios.TabIndex = 10;
            // 
            // btnBuscarUsuarios
            // 
            this.btnBuscarUsuarios.BackColor = System.Drawing.Color.Orange;
            this.btnBuscarUsuarios.Location = new System.Drawing.Point(243, 22);
            this.btnBuscarUsuarios.Name = "btnBuscarUsuarios";
            this.btnBuscarUsuarios.Size = new System.Drawing.Size(106, 40);
            this.btnBuscarUsuarios.TabIndex = 9;
            this.btnBuscarUsuarios.Text = "Buscar Usuarios";
            this.btnBuscarUsuarios.UseVisualStyleBackColor = false;
            this.btnBuscarUsuarios.Click += new System.EventHandler(this.btnBuscarUsuarios_Click);
            // 
            // dGVUsuarios
            // 
            this.dGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUsuarios.Location = new System.Drawing.Point(12, 86);
            this.dGVUsuarios.Name = "dGVUsuarios";
            this.dGVUsuarios.ReadOnly = true;
            this.dGVUsuarios.Size = new System.Drawing.Size(354, 216);
            this.dGVUsuarios.TabIndex = 8;
            // 
            // AniadirAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(384, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviarSoli);
            this.Controls.Add(this.tBBuscarUsuarios);
            this.Controls.Add(this.btnBuscarUsuarios);
            this.Controls.Add(this.dGVUsuarios);
            this.Name = "AniadirAmigos";
            this.Text = "AniadirAmigos";
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviarSoli;
        private System.Windows.Forms.TextBox tBBuscarUsuarios;
        private System.Windows.Forms.Button btnBuscarUsuarios;
        private System.Windows.Forms.DataGridView dGVUsuarios;
    }
}