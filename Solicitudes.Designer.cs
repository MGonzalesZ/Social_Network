namespace panalbase
{
    partial class Solicitudes
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
            this.btnRechazarSoli = new System.Windows.Forms.Button();
            this.btnAceptarSoli = new System.Windows.Forms.Button();
            this.dGVSoli = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSoli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRechazarSoli
            // 
            this.btnRechazarSoli.BackColor = System.Drawing.Color.Orange;
            this.btnRechazarSoli.Location = new System.Drawing.Point(68, 67);
            this.btnRechazarSoli.Name = "btnRechazarSoli";
            this.btnRechazarSoli.Size = new System.Drawing.Size(127, 23);
            this.btnRechazarSoli.TabIndex = 6;
            this.btnRechazarSoli.Text = "Rechazar solicitud";
            this.btnRechazarSoli.UseVisualStyleBackColor = false;
            this.btnRechazarSoli.Click += new System.EventHandler(this.btnRechazarSoli_Click);
            // 
            // btnAceptarSoli
            // 
            this.btnAceptarSoli.BackColor = System.Drawing.Color.Orange;
            this.btnAceptarSoli.Location = new System.Drawing.Point(68, 17);
            this.btnAceptarSoli.Name = "btnAceptarSoli";
            this.btnAceptarSoli.Size = new System.Drawing.Size(127, 23);
            this.btnAceptarSoli.TabIndex = 5;
            this.btnAceptarSoli.Text = "Aceptar solicitud";
            this.btnAceptarSoli.UseVisualStyleBackColor = false;
            this.btnAceptarSoli.Click += new System.EventHandler(this.btnAceptarSoli_Click_1);
            // 
            // dGVSoli
            // 
            this.dGVSoli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSoli.Location = new System.Drawing.Point(12, 109);
            this.dGVSoli.Name = "dGVSoli";
            this.dGVSoli.ReadOnly = true;
            this.dGVSoli.Size = new System.Drawing.Size(240, 150);
            this.dGVSoli.TabIndex = 4;
            // 
            // Solicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(274, 295);
            this.Controls.Add(this.btnRechazarSoli);
            this.Controls.Add(this.btnAceptarSoli);
            this.Controls.Add(this.dGVSoli);
            this.Name = "Solicitudes";
            this.Text = "Solicitudes";
            ((System.ComponentModel.ISupportInitialize)(this.dGVSoli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRechazarSoli;
        private System.Windows.Forms.Button btnAceptarSoli;
        private System.Windows.Forms.DataGridView dGVSoli;
    }
}