namespace panalbase
{
    partial class FRMBuscarUsuario
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
            this.btnBusqUs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarUsu = new System.Windows.Forms.TextBox();
            this.panelUsuariosMostrar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnBusqUs
            // 
            this.btnBusqUs.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBusqUs.ForeColor = System.Drawing.Color.White;
            this.btnBusqUs.Location = new System.Drawing.Point(424, 42);
            this.btnBusqUs.Name = "btnBusqUs";
            this.btnBusqUs.Size = new System.Drawing.Size(83, 27);
            this.btnBusqUs.TabIndex = 8;
            this.btnBusqUs.Text = "Buscar";
            this.btnBusqUs.UseVisualStyleBackColor = false;
            this.btnBusqUs.Click += new System.EventHandler(this.btnBusqUs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Búsqueda de usuarios";
            // 
            // txtBuscarUsu
            // 
            this.txtBuscarUsu.Location = new System.Drawing.Point(12, 46);
            this.txtBuscarUsu.Name = "txtBuscarUsu";
            this.txtBuscarUsu.Size = new System.Drawing.Size(406, 20);
            this.txtBuscarUsu.TabIndex = 6;
            // 
            // panelUsuariosMostrar
            // 
            this.panelUsuariosMostrar.AutoScroll = true;
            this.panelUsuariosMostrar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelUsuariosMostrar.Location = new System.Drawing.Point(-6, 73);
            this.panelUsuariosMostrar.Name = "panelUsuariosMostrar";
            this.panelUsuariosMostrar.Size = new System.Drawing.Size(534, 325);
            this.panelUsuariosMostrar.TabIndex = 12;
            // 
            // FRMBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(523, 398);
            this.Controls.Add(this.panelUsuariosMostrar);
            this.Controls.Add(this.btnBusqUs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarUsu);
            this.Name = "FRMBuscarUsuario";
            this.Text = "FRMBuscarUsuario";
            this.Load += new System.EventHandler(this.FRMBuscarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBusqUs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarUsu;
        private System.Windows.Forms.Panel panelUsuariosMostrar;
    }
}