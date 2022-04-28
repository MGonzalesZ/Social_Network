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
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.btnAniadirAmigos = new System.Windows.Forms.Button();
            this.btnEliminarAmigo = new System.Windows.Forms.Button();
            this.tBBuscarAmigo = new System.Windows.Forms.TextBox();
            this.btnBuscarAmigo = new System.Windows.Forms.Button();
            this.dGVAmigos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAmigos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.BackColor = System.Drawing.Color.Orange;
            this.btnSolicitudes.Location = new System.Drawing.Point(573, 387);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(101, 51);
            this.btnSolicitudes.TabIndex = 11;
            this.btnSolicitudes.Text = "Solicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = false;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
            // 
            // btnAniadirAmigos
            // 
            this.btnAniadirAmigos.BackColor = System.Drawing.Color.Orange;
            this.btnAniadirAmigos.Location = new System.Drawing.Point(351, 387);
            this.btnAniadirAmigos.Name = "btnAniadirAmigos";
            this.btnAniadirAmigos.Size = new System.Drawing.Size(100, 51);
            this.btnAniadirAmigos.TabIndex = 10;
            this.btnAniadirAmigos.Text = "Añadir Amigos";
            this.btnAniadirAmigos.UseVisualStyleBackColor = false;
            this.btnAniadirAmigos.Click += new System.EventHandler(this.btnAniadirAmigos_Click);
            // 
            // btnEliminarAmigo
            // 
            this.btnEliminarAmigo.BackColor = System.Drawing.Color.Orange;
            this.btnEliminarAmigo.Location = new System.Drawing.Point(107, 387);
            this.btnEliminarAmigo.Name = "btnEliminarAmigo";
            this.btnEliminarAmigo.Size = new System.Drawing.Size(163, 51);
            this.btnEliminarAmigo.TabIndex = 9;
            this.btnEliminarAmigo.Text = "Eliminar de amigos";
            this.btnEliminarAmigo.UseVisualStyleBackColor = false;
            this.btnEliminarAmigo.Click += new System.EventHandler(this.btnEliminarAmigo_Click);
            // 
            // tBBuscarAmigo
            // 
            this.tBBuscarAmigo.Location = new System.Drawing.Point(59, 42);
            this.tBBuscarAmigo.Name = "tBBuscarAmigo";
            this.tBBuscarAmigo.Size = new System.Drawing.Size(415, 20);
            this.tBBuscarAmigo.TabIndex = 8;
            // 
            // btnBuscarAmigo
            // 
            this.btnBuscarAmigo.BackColor = System.Drawing.Color.Orange;
            this.btnBuscarAmigo.Location = new System.Drawing.Point(480, 34);
            this.btnBuscarAmigo.Name = "btnBuscarAmigo";
            this.btnBuscarAmigo.Size = new System.Drawing.Size(156, 34);
            this.btnBuscarAmigo.TabIndex = 7;
            this.btnBuscarAmigo.Text = "Buscar amigo";
            this.btnBuscarAmigo.UseVisualStyleBackColor = false;
            this.btnBuscarAmigo.Click += new System.EventHandler(this.btnBuscarAmigo_Click);
            // 
            // dGVAmigos
            // 
            this.dGVAmigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAmigos.Location = new System.Drawing.Point(49, 80);
            this.dGVAmigos.Name = "dGVAmigos";
            this.dGVAmigos.ReadOnly = true;
            this.dGVAmigos.Size = new System.Drawing.Size(702, 273);
            this.dGVAmigos.TabIndex = 6;
            // 
            // Amigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSolicitudes);
            this.Controls.Add(this.btnAniadirAmigos);
            this.Controls.Add(this.btnEliminarAmigo);
            this.Controls.Add(this.tBBuscarAmigo);
            this.Controls.Add(this.btnBuscarAmigo);
            this.Controls.Add(this.dGVAmigos);
            this.Name = "Amigos";
            this.Text = "Amigos";
            ((System.ComponentModel.ISupportInitialize)(this.dGVAmigos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Button btnAniadirAmigos;
        private System.Windows.Forms.Button btnEliminarAmigo;
        private System.Windows.Forms.TextBox tBBuscarAmigo;
        private System.Windows.Forms.Button btnBuscarAmigo;
        private System.Windows.Forms.DataGridView dGVAmigos;
    }
}